using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Formulas;

namespace OneRepMax.Tests.Formulas
{
    [TestClass]
    public class LanderFormulaShould
    {
        private readonly IFormula lander = new LanderFormula();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmUsingLanderFormula()
        {
            const double expectedValue = 180.99;
            var actualValue = lander.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}