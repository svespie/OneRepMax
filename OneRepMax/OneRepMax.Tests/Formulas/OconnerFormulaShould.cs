using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Formulas;

namespace OneRepMax.Tests.Formulas
{
    [TestClass]
    public class OconnerFormulaShould
    {
        private readonly IFormula oconner = new OconnerFormula();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmUsingOConnerFormula()
        {
            const double expectedValue = 168.75;
            var actualValue = oconner.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}