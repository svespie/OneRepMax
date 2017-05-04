using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategy;

namespace OneRepMax.Tests
{
    [TestClass]
    public class InputValidationTests
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();
        private readonly ICalculatorStrategy epley = new EpleyStrategy();

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithWeightGreaterThan1()
        {
            try
            {
                calc.Calculate(135, 5, epley);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithRepsEqual1()
        {
            try
            {
                calc.Calculate(135, 1, epley);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithRepsEqual10()
        {
            try
            {
                calc.Calculate(135, 10, epley);
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
            calc.Calculate(0.999, 5, epley);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenRepsIsLessThan1()
        {
            calc.Calculate(135, 0, epley);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenRepsIsGreaterThan10()
        {
            calc.Calculate(135, 11, epley);
        }
    }
}