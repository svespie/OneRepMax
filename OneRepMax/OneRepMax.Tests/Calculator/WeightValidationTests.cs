using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Calculator;

namespace OneRepMax.Tests.Calculator
{
    [TestClass]
    public class WeightValidationTests
    {
        private readonly OneRepMaxValidator validator = new OneRepMaxValidator();

        [TestMethod]
        public void ValidatorShouldNotThrowAnExceptionWithWeightGreaterThan1()
        {
            try
            {
                validator.ValidateWeight(135);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidatorShouldThrowAnExceptionWhenWeightIsLessThan1()
        {
            validator.ValidateWeight(0.999);
        }
    }
}