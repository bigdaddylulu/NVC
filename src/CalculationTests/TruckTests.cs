using domain.nvc;
using nvc.Services;
using nvc.tests.unit;
using Xunit;

namespace CalculationTests
{
    public class TruckTests
    {
        private Calculator _sut;
        private TruckBuilder _truckBuilder;
        private TrailerBuilder _trailerBuilder;

        public TruckTests()
        {
            _truckBuilder = new TruckBuilder();
            _trailerBuilder = new TrailerBuilder();

        }
        [Fact]
        public void Test6x2()
        {
            Trailer trailer = _trailerBuilder.buildStandaardTrailer();
            Truck truck = _truckBuilder.build6x4();
            _sut = new CalculatorTrekkerEnStandaardOplegger(truck, trailer);
            decimal result = _sut.calculate(true, 10000);
            
            Assert.Equal(100,result);
        }
    }
}