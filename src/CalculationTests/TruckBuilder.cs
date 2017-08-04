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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 3000,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = (decimal) (7.5 / 19)
                }
            };

            T.Axles = lst;
            return T;
        }

        public Truck build6x4()
        {
            var T = new Truck();

            var lst = new List<Axle>
            {
                new Axle
                {
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Distance = 500,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Distance = 500,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.FrontAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Distance = 3000,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Distance = 500,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Distance = 500,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.FrontAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = (decimal) 0.5
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Distance = 500,
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
                    AxleType = AxleType.FrontAxle,
                    Id = 1,
                    SequenceNumber = 1,
                    Size = 10,
                    Distance = 100,
                    WheelBaseFactor = 1
                },
                new Axle
                {
                    AxleType = AxleType.FrontAxle,
                    Id = 2,
                    SequenceNumber = 2,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = (decimal) 0.5
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 3,
                    Size = 10,
                    Distance = 3000,
                    WheelBaseFactor = (decimal) (3.0 / 4.0)
                },
                new Axle
                {
                    AxleType = AxleType.RearAxle,
                    Id = 3,
                    SequenceNumber = 4,
                    Size = 10,
                    Distance = 500,
                    WheelBaseFactor = (decimal) (3.0 / 8.0)
                }
            };

            T.Axles = lst;
            return T;
        }
    }
}