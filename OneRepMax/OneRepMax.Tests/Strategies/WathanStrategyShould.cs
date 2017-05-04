using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategies;

namespace OneRepMax.Tests.Strategies
{
    [TestClass]
    public class WathanStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy wathan = new WathanStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 181.91;
            var actualValue = calc.Calculate(Weight, Reps, wathan);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}