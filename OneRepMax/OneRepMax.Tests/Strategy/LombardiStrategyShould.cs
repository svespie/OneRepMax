using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategy;

namespace OneRepMax.Tests.Strategy
{
    [TestClass]
    public class LombardiStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy lombardi = new LombardiStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 169.95;
            var actualValue = calc.Calculate(Weight, Reps, lombardi);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}