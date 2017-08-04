using System.Collections.Generic;

namespace domain.nvc
{
    public class Truck : Vehicle
    {
        public Truck()
        {
            VehicleGroup = VehicleGroup.Trekker;
        }

        public decimal AddFrontLoad { get; set; }
        public decimal AddRearLoad { get; set; }
        public decimal CalcKD_B1 { get; set; }
        public decimal CalcKD_B2 { get; set; }
        public decimal CalcV0 { get; set; }
        public decimal CalcWB { get; set; }
        public int FifthWheelObjectNr { get; set; }
        public decimal FrontAxLoadEmpty { get; set; }
        public decimal FrontAxLoadLoaded { get; set; }
        public ICollection<LoadMass> LoadMasses { get; set; }
        public decimal RearAxLoadEmpty { get; set; }
        public decimal RearAxLoadLoaded { get; set; }
        public decimal VehicleType { get; set; }
        public decimal VO { get; set; }
        public decimal VZHK { get; set; }
    }
}