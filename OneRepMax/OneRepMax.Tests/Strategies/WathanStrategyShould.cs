using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategies;

namespace OneRepMax.Tests.Strategies
{
    [TestClass]
    public class WathanStrategyShould
    {
        private readonly ICalculatorStrategy wathan = new WathanStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmToTwoDecimalPlaces()
        {
            const double expectedValue = 181.91;
            var actualValue = wathan.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}