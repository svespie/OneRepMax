using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneRepMax.Tests
{
    [TestClass]
    public class CalculateTests
    {
        private readonly IOneRepMaxCalculator calc = new OneRepMaxCalculator();

        [TestMethod]
        public void ShouldNotThrowAnExceptionWithWeightGreaterThan1()
        {
            try
            {
                calc.Calculate(135, 5, Formula.Average);
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
                calc.Calculate(135, 1, Formula.Average);
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
                calc.Calculate(135, 10, Formula.Average);
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
            calc.Calculate(0.999, 5, Formula.Average);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenRepsIsLessThan1()
        {
            calc.Calculate(135, 0, Formula.Average);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldThrowAnExceptionWhenRepsIsGreaterThan10()
        {
            calc.Calculate(135, 11, Formula.Average);
        }
    }
}