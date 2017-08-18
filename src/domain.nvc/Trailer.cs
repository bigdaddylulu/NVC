using System.Collections.Generic;

namespace domain.nvc
{
    public class Trailer : Vehicle
    {
        public decimal AddFifthWheelLoad { get; set; }
        public decimal AddFifthWheelLoadMass { get; set; }
        public decimal AddFrontLoad { get; set; }
        public decimal AddRearLoad { get; set; }
        public decimal Bed { get; set; }
        public decimal Extended { get; set; }
        public decimal ExtendGridRow { get; set; }
        public decimal ExtendObject { get; set; }
        public decimal FifthWheelLoadEmpty { get; set; }
        public decimal FifthWheelLoadLoaded { get; set; }
        public decimal FithWheelLoadOrgEmpty { get; set; }
        public decimal FithWheelLoadOrgLoaded { get; set; }
        public decimal HKAZMax { get; set; }
        public decimal HKAZMin { get; set; }
        public decimal LoadLevel { get; set; }
        public ICollection<LoadMass> LoadMasses { get; set; }
        public decimal Neck { get; set; }
        public decimal ObjectEnd { get; set; }
        public decimal AchterAsBelastingLeeg { get; set; }
        public decimal AchterAsBelastingUitgetrokken { get; set; }
        public decimal AchterAsBelastingBeladen { get; set; }
        public decimal AchterAsBelastingOrigineelLeeg { get; set; }
        public decimal AchterAsBelastingOrigineelBeladen { get; set; }
        public decimal AchterAsBelastingOrigineelUitgetrokken { get; set; }
        public decimal V0 { get; set; }
        public decimal VAS { get; set; }
        public decimal XLoadStartPosition { get; set; }
    }


    public class TrekkerEnStandaardOplegger : Trailer
    {
    }
}