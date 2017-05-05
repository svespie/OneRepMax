using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Calculator;
using OneRepMax.Formulas;

namespace OneRepMax.Tests.Calculator
{
    [TestClass]
    public class WeightValidationTests
    {
        private readonly OneRepMaxCalculator calc = new OneRepMaxCalculator(OneRepMaxFormula.Epley);

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithWeightGreaterThan1()
        {
            try
            {
                calc.ValidateWeight(135);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenWeightIsLessThan1()
        {
            calc.ValidateWeight(0.999);
        }
    }
}