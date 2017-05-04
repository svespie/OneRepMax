using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategy;

namespace OneRepMax.Tests.Strategy
{
    [TestClass]
    public class OconnerStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy oconner = new OconnerStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 168.75;
            var actualValue = calc.Calculate(Weight, Reps, oconner);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}