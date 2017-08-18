using System.Collections.Generic;
using System.Linq;
using domain.nvc;
using static System.Math;

namespace nvc.Services
{
    public class CalculatorTrekkerEnStandaardOplegger : Calculator
    {
        private readonly Trailer _trailer;
        private readonly Truck _truck;
        private decimal _addFront;
        private decimal _addRear;
        private decimal _calcKdb1;
        private decimal _calcKdb2;
        private decimal _calcKdb3;
        private decimal _fifthWheeAddMass;
        private decimal _frontMass;
        private decimal _kd_act;
        private decimal _kd_Nut;
        private decimal _loadPosition;
        private decimal _rearAAL_act;
        private decimal _rearAAL_nut;
        private decimal _rearMass;
        private decimal _rearWB;
        private decimal _trailerRearAddMass;
        private decimal _truckFrontAddMass;
        private decimal _truckRearAddMass;
        private decimal _voorOverbouw;

        public CalculatorTrekkerEnStandaardOplegger(Truck truck, Trailer trailer)
        {
            _trailer = trailer;
            _truck = truck;
        }

        public override decimal calculate(bool positionLoad, decimal loadMass)
        {
            decimal result = 0;
            //todo: only for trucktypes 9 to 11
            // calculate wheelbase
            _truck.WielBasis = CalculateWielBasisTruck(_truck);
            // calculate frontaxle
            _truck.ZwaartePuntVoorAssen = CalculateVoorOverbouwTruck(_truck);
            // calculate kdb1 ?
            _truck.Kdb1 = CalculateKdb1Trekker(_truck);
            // calculate kdb2 ?
            _truck.Kdb2 = CalculateKdb2Trekker(_truck);
            // calculate kdb3
            _calcKdb3 = _trailer.FifthWheelLoadLoaded;
            // calculate kdnut
            _kd_Nut = KD_NutCombi(_truck, _trailer);

            // todo: checken
            _rearWB = WBStandaardOplegger(_trailer, false);
            _rearAAL_nut = calculateRearAALNut(_trailer);

            if (positionLoad)
                _loadPosition = X_LoadStandaardOplegger(_rearAAL_nut, _kd_Nut, _rearWB);

            _rearAAL_act = AAL_actStandaarOplegger(_trailer, loadMass, _loadPosition, _rearWB);
            _kd_act = KD_actStandaardCombi(_trailer, loadMass, _rearAAL_act);
            _rearMass = AAL_actTrekker(_truck, _kd_act);
            _frontMass = VAL_actTrekker(_truck, _trailer, _kd_act, _rearMass);

            _truckFrontAddMass = _frontMass - _truck.VoorAsLeeg;
            _truckRearAddMass = _rearMass - _truck.AchterAsBelastingLeeg;
            _trailerRearAddMass = _rearAAL_act - (_trailer.AchterAsBelastingLeeg + _trailer.AddRearLoad);
            _fifthWheeAddMass = _kd_act - (_trailer.FifthWheelLoadEmpty + _trailer.AddFifthWheelLoad);

            return result;
        }

        private decimal VAL_actTrekker(Truck truck, Trailer trailer, decimal kdAct, decimal rearMass)
        {
            return truck.VoorAsLeeg + truck.AchterAsBelastingLeeg + kdAct - rearMass;
        }

        private decimal AAL_actTrekker(Truck truck, decimal kdAct)
        {
            return truck.AchterAsBelastingLeeg + kdAct * (truck.VoorZijdeHartKoppel - truck.ZwaartePuntVoorAssen) /
                   truck.WielBasis;
        }

        private decimal KD_actStandaardCombi(Trailer trailer, decimal loadMass, decimal rearAalAct)
        {
            return loadMass + trailer.FifthWheelLoadEmpty + trailer.AddFifthWheelLoad + trailer.AchterAsBelastingLeeg +
                   trailer.AddRearLoad - _rearAAL_act;
        }

        private decimal AAL_actStandaarOplegger(Trailer trailer, decimal loadMass, decimal loadPosition,
            decimal rearWheelBasis)
        {
            return trailer.AchterAsBelastingLeeg + trailer.AddRearLoad +
                   loadMass * loadPosition / rearWheelBasis;
        }

        private decimal X_LoadStandaardOplegger(decimal rearAalNut, decimal kdNut, decimal rearWb)
        {
            return rearAalNut * rearWb / (kdNut + rearAalNut);
        }

        private decimal calculateRearAALNut(Trailer trailer)
        {
            return trailer.AchterAsBelastingBeladen - (trailer.AchterAsBelastingLeeg + trailer.AddRearLoad);
        }

        private decimal WBStandaardOplegger(Trailer trailer, bool isDefault)
        {
            decimal result = 0;

            //var activeWheels = trailer.Axles
            //    .Count(x => (x.AsEigenschappen & AsEigenschappen.Opgetrokken) != 0 && isDefault
            //                && x.AsType == AsType.AchterAs);

            decimal lngRearSum = 0;
            var liActiveWheels = new List<int>();
            var iNrOfWheels = 0;

            var achterassen = trailer.Axles.Where(x => x.AsType == AsType.AchterAs).ToArray();
            for (var i = 0; i < achterassen.Count(); i++)
                if (isDefault || !achterassen[i].AsEigenschappen.HasFlag(AsEigenschappen.Opgetrokken))
                {
                    iNrOfWheels++;
                    liActiveWheels.Add(i);
                }
            lngRearSum = 0;

            var iActiveWheels = liActiveWheels.ToArray();
            for (var i = 2; i <= iNrOfWheels; i++)
                lngRearSum += (iNrOfWheels - i + 1)
                              // correction of -1 for zero based array
                              * (achterassen[iActiveWheels[i] - 1].Afstand - achterassen[iActiveWheels[i] - 2].Afstand);

            result = achterassen
                         .Where(x => (x.AsEigenschappen & AsEigenschappen.Opgetrokken) == 0)
                         .OrderBy(y => y.SequenceNumber).First().Afstand
                     + trailer.Extended
                     + lngRearSum / iNrOfWheels;

            return result;
        }

        /// <summary>
        ///     KD_Nutcombi
        /// </summary>
        /// <param name="truck"></param>
        /// <param name="trailer"></param>
        /// <returns></returns>
        private decimal KD_NutCombi(Truck truck, Trailer trailer)
        {
            decimal kdbMin;

            if (truck.WielBasis + truck.ZwaartePuntVoorAssen - truck.VoorZijdeHartKoppel == 0)
                kdbMin = Min(truck.Kdb1, truck.Kdb3);
            else
                kdbMin = Min(Min(truck.Kdb1, truck.Kdb2), truck.Kdb3);


            return kdbMin 
                - (trailer.FifthWheelLoadEmpty + trailer.AddFifthWheelLoad);
        }

        /// <summary>
        ///     KDB2 Trekker
        /// </summary>
        /// <param name="truck"></param>
        /// <returns></returns>
        private decimal CalculateKdb2Trekker(Truck truck)
        {
            decimal result = 0;
            // hart koppel bevindt zich exact op VO + WB
            if (_truck.WielBasis + truck.ZwaartePuntVoorAssen - truck.VoorZijdeHartKoppel != 0)
                // hart koppel achter VO + WB
                if (truck.WielBasis + truck.ZwaartePuntVoorAssen - truck.VoorZijdeHartKoppel > 0)
                    result =
                        (truck.VoorAsBeladen - truck.VoorAsLeeg)
                        * truck.WielBasis
                        / (truck.WielBasis + truck.ZwaartePuntVoorAssen - truck.VoorZijdeHartKoppel);
                else
                    // hart koppel voor VO + WB
                    result =
                        (truck.VoorAsBeladen - truck.VoorAsLeeg)
                        * truck.WielBasis
                        / (truck.VoorZijdeHartKoppel - (truck.WielBasis + truck.ZwaartePuntVoorAssen));

            return result;
        }

        /// <summary>
        ///     kdb1Trekker
        /// </summary>
        /// <param name="truck"></param>
        /// <returns></returns>
        private decimal CalculateKdb1Trekker(Truck truck)
        {
            if (truck.VoorZijdeHartKoppel - truck.ZwaartePuntVoorAssen <= 0)
                throw new InvalidTruckConfigurationException(
                    "VoorzijdeHartKoppel moet groter zijn dan TruckVooroverbouw");

            return
                (truck.AchterAsBelastingBeladen - truck.AchterAsBelastingLeeg)
                * truck.WielBasis
                / (truck.VoorZijdeHartKoppel - truck.ZwaartePuntVoorAssen);
        }

        /// <summary>
        ///     VO1Trekker
        /// </summary>
        /// <param name="truck"></param>
        /// <returns></returns>
        private decimal CalculateVoorOverbouwTruck(Truck truck)
        {
            decimal result = 0;
            foreach (var axle in truck.Axles.Where(x => x.AsType == AsType.VoorAs)
                .OrderBy(x => x.SequenceNumber))
                result += axle.Afstand * axle.WheelBaseFactor;

            return result;
        }

        /// <summary>
        ///     WBTrekker
        /// </summary>
        /// <param name="truck"></param>
        /// <returns></returns>
        private decimal CalculateWielBasisTruck(Truck truck)
        {
            decimal result = 0;

            foreach (var axle in truck.Axles.Where(x => x.AsType == AsType.AchterAs)
                .OrderBy(x => x.SequenceNumber))
                result += axle.Afstand * axle.WheelBaseFactor;
            return result;
        }
    }
}