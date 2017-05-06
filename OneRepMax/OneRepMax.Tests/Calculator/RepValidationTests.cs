using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Calculator;

namespace OneRepMax.Tests.Calculator
{
    [TestClass]
    public class RepValidationTests
    {
        private readonly OneRepMaxValidator validator = new OneRepMaxValidator();

        [TestMethod]
        public void ValidatorShouldNotThrowAnExceptionWithRepsEqual1()
        {
            try
            {
                validator.ValidateReps(1);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void ValidatorShouldNotThrowAnExceptionWithRepsEqual10()
        {
            try
            {
                validator.ValidateReps(10);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidatorShouldThrowAnExceptionWhenRepsIsLessThan1()
        {
            validator.ValidateReps(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidatorShouldThrowAnExceptionWhenRepsIsGreaterThan10()
        {
            validator.ValidateReps(11);
        }
    }
}