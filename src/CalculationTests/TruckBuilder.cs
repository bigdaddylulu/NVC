using System.Collections.Generic;
using domain.nvc;

namespace nvc.tests.unit
{
    public class TruckBuilder
    {
        public Truck build4x2()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = 1
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build6x2()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 2800,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Afstand = 1400,
                    WheelBaseFactor = (decimal) (7.5 / 19)
                }
            };
            T.VoorZijdeHartKoppel = 4500;
            T.AchterAsBelastingBeladen = 19000;
            T.AchterAsBelastingLeeg = 3000;
            T.Axles = lst;
            return T;
        }

        public Truck build6x4()
        {
            var T = new Truck();
            T.Name = "TR3";
            T.VoorOverbouw = 1420;
            T.VoorZijdeHartKoppel = 5000;
            T.AchterAsBelastingBeladen = 19000;
            T.AchterAsBelastingLeeg = 3000;
            T.VoorAsLeeg = 5500;
            T.VoorAsBeladen = 8500;

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = T.VoorOverbouw,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 3200,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Afstand = 1360,
                    WheelBaseFactor = (decimal) 0.5
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build6x2412()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (11.5 / 19)
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build6x2421()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = (decimal) (11.5 / 19)
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build8x2413()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (3.0 / 8.0)
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build8x4413()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (3.0 / 8.0)
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build8x2422()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) 0.5
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (3.0 / 8.0)
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build8x4422()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Afstand = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AsType = AsType.VoorAs,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) 0.5
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Afstand = 3000,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AsType = AsType.AchterAs,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Afstand = 500,
                    WheelBaseFactor = (decimal) (3.0 / 8.0)
                }
            };

            T.Axles = lst;
            return T;
        }
    }
}