using System.Collections.Generic;

namespace domain.nvc
{
    public class Trailer : Vehicle
    {
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
        public decimal FrontAxleLoadEmpty { get; set; }
        public decimal FrontAxleLoadLoaded { get; set; }
        public decimal FrontAxleLoadOrgEmpty { get; set; }
        public decimal FrontAxleLoadOrgLoaded { get; set; }
        public decimal HKAZMax { get; set; }
        public decimal HKAZMin { get; set; }
        public decimal LoadLevel { get; set; }
        public ICollection<LoadMass> LoadMasses { get; set; }
        public decimal Neck { get; set; }
        public decimal ObjectEnd { get; set; }
        public decimal RearAxleLoadEmpty { get; set; }
        public decimal RearAxleLoadExtended { get; set; }
        public decimal RearAxleLoadLoaded { get; set; }
        public decimal RearAxleLoadOrgEmpty { get; set; }
        public decimal RearAxleLoadOrgLoaded { get; set; }
        public decimal RearAxLoadOrgExtended { get; set; }
        public decimal V0 { get; set; }
        public decimal VAS { get; set; }
        public decimal XLoadStartPosition { get; set; }
    }


    public class TrekkerEnStandaardOplegger : Trailer
    {
    }
}