using System;
using System.Reflection;

namespace domain.nvc
{
    public class Axle
    {
        public int Id { get; set; }
        public AxleType AxleType { get; set; }
        public decimal Distance { get; set; }
        public decimal Size { get; set; }
        public int SequenceNumber { get; set; }
        public decimal WheelBaseFactor { get; set; }
        public AxleProperties AxleProperties { get; set; }
    }

    [Flags()]
    public enum AxleProperties
    {
        Liftable = 1, Lifted =2
    }

    public enum AxleType
    {
        FrontAxle = 1, RearAxle= 2
    }
}