using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategy;

namespace OneRepMax.Tests.Strategy
{
    [TestClass]
    public class EpleyStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy epley = new EpleyStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;


        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.00;
            var actualValue = calc.Calculate(Weight, Reps, epley);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}