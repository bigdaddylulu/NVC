using System.Collections.Generic;
using domain.nvc;

namespace CalculationTests
{
    public class TrailerBuilder
    {
        public Trailer buildStandaardTrailer()
        {
            var T = new Trailer();

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

    }
}