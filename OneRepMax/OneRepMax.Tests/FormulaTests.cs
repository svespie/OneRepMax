using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneRepMax.Tests
{
    [TestClass]
    public class FormulaTests
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();

        private const double Weight = 135.0;
        private const int Reps = 10;

        [TestMethod]
        public void ShouldBeAbleToCalculateAnAverage1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 176.91;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Average);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateABrzycki1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.00;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Brzycki);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateAnEpley1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.00;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Epley);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateALander1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.99;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Lander);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateALombardi1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 169.95;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Lombardi);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateAMayhew1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 176.76;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Mayhew);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateAnOConner1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 168.75;
            var actualValue = calc.Calculate(Weight, Reps, Formula.OConner);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ShouldBeAbleToCalculateAWathan1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 181.91;
            var actualValue = calc.Calculate(Weight, Reps, Formula.Wathan);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}