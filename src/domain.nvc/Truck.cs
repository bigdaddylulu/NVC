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
        public decimal CalcKdB1 { get; set; }
        public decimal CalcKdB2 { get; set; }
        public decimal CalcTruckVooroverbouw { get; set; }
        public decimal WielBasis { get; set; }
        public int FifthWheelObjectNr { get; set; }
        public ICollection<LoadMass> LoadMasses { get; set; }
        public decimal AchterAsBelastingLeeg { get; set; }
        public decimal AchterAsBelastingBeladen { get; set; }
        public decimal VoorOverbouw { get; set; }
        public decimal VoorZijdeHartKoppel { get; set; }
        public decimal VoorAsLeeg { get; set; }
        public decimal VoorAsBeladen { get; set; }
        /// <summary>
        /// Berekende VO1
        /// </summary>
        public decimal ZwaartePuntVoorAssen { get; set; }

        public decimal Kdb1 { get; set; }
        public decimal Kdb2 { get; set; }
        public decimal Kdb3 { get; set; }
    }
}