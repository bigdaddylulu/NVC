using System.Collections.Generic;

namespace domain.nvc
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleType VehicleType { get; }
        public ICollection<Axle> Axles { get; set; }
        public VehicleGroup VehicleGroup { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}