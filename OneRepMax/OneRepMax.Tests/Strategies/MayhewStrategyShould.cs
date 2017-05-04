using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategies;

namespace OneRepMax.Tests.Strategies
{
    [TestClass]
    public class MayhewStrategyShould
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy mayhew = new MayhewStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 176.76;
            var actualValue = calc.Calculate(Weight, Reps, mayhew);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}