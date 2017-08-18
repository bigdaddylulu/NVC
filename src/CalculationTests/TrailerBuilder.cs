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

    }
}