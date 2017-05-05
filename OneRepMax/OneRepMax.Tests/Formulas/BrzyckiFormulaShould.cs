using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Formulas;

namespace OneRepMax.Tests.Formulas
{
    [TestClass]
    public class BrzyckiFormulaShould
    {
        private readonly IFormula brzycki = new BrzyckiFormula();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmUsingBrzyckiFormula()
        {
            const double expectedValue = 180.00;
            var actualValue = brzycki.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}