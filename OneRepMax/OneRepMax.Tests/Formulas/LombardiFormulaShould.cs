using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Formulas;

namespace OneRepMax.Tests.Formulas
{
    [TestClass]
    public class LombardiFormulaShould
    {
        private readonly IFormula lombardi = new LombardiFormula();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmUsingLombardiFormula()
        {
            const double expectedValue = 169.95;
            var actualValue = lombardi.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}