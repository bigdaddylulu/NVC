using System.Linq;
using domain.nvc;

namespace nvc.Services
{
    public class CalculatorTrekkerEnStandaardOplegger:Calculator
    {
        private readonly Trailer _trailer;
        private readonly Truck _truck;

        public CalculatorTrekkerEnStandaardOplegger(Truck truck, Trailer trailer)
        {
            _trailer = trailer;
            _truck = truck;
        }

        public decimal calculate()
        {
            decimal result = 0;
            //todo: only for trucktypes 9 to 11
            // calculate wheelbase
            _truck.CalcWB = CalculateWBTruck();
            // calculate frontaxle
            _truck.CalcV0 = CalculateV01Truck();
            // calculate kdb1
            _truck.CalcKD_B1 = CalculateKDB1Trekker();


            return result;
        }

        private decimal CalculateKDB1Trekker()
        {
            decimal result = 0;
            result = ((_truck.RearAxLoadLoaded - _truck.RearAxLoadEmpty) * _truck.CalcWB) / _truck.VZHK - _truck.v01;
                //KD_B1Trekker = ((.RearAxLoadLoaded - (.RearAxLoadEmpty)) * WheelBasis) / (.VZHK - VO1)
            return result;
        }

        private decimal CalculateV01Truck()
        {
            decimal result = 0;
            foreach (var axle in _truck.Axles.Where(x => x.AxleType == AxleType.FrontAxle)
                .OrderBy(x => x.SequenceNumber))
                result += axle.Distance * axle.WheelBaseFactor;

            return result;
        }

        private decimal CalculateWBTruck()
        {
            decimal result = 0;

            foreach (var axle in _truck.Axles.Where(x => x.AxleType == AxleType.RearAxle)
                .OrderBy(x => x.SequenceNumber))
                result += axle.Distance * axle.WheelBaseFactor;
            return result;
        }
    }
}