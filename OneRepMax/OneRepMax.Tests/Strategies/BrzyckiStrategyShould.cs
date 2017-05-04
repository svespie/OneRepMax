using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategies;

namespace OneRepMax.Tests.Strategies
{
    [TestClass]
    public class BrzyckiStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy brzycki = new BrzyckiStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;


        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.00;
            var actualValue = calc.Calculate(Weight, Reps, brzycki);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}