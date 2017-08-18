using System;
using System.Reflection;

namespace domain.nvc
{
    public class Axle
    {
        public int Id { get; set; }
        public AsType AsType { get; set; }
        public decimal Afstand { get; set; }
        public decimal Size { get; set; }
        public int SequenceNumber { get; set; }
        public decimal WheelBaseFactor { get; set; }
        public AsEigenschappen AsEigenschappen { get; set; }
    }

    [Flags()]
    public enum AsEigenschappen
    {
        Optrekbaar = 1, Opgetrokken =2
    }

    public enum AsType
    {
        VoorAs = 1, AchterAs = 2
    }
}