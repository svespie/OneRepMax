using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategies;

namespace OneRepMax.Tests.Strategies
{
    [TestClass]
    public class LanderStrategyShould
    {
        private readonly ICalculatorStrategy lander = new LanderStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 180.99;
            var actualValue = lander.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}