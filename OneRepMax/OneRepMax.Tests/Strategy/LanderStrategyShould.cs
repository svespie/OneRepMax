using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategy;

namespace OneRepMax.Tests.Strategy
{
    [TestClass]
    public class LanderStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy lander = new LanderStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.99;
            var actualValue = calc.Calculate(Weight, Reps, lander);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}