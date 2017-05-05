using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OneRepMax.Strategies;

namespace OneRepMax.Tests.Strategies
{
    [TestClass]
    public class MayhewStrategyShould
    {
        private readonly ICalculatorStrategy mayhew = new MayhewStrategy();

        private const double Weight = 135.0;
        private const int Reps = 10;
        private const int DecimalPlaces = 2;

        [TestMethod]
        public void ShouldBeAbleToCalculateA1RmUsingMayhewFormula()
        {
            const double expectedValue = 176.76;
            var actualValue = mayhew.Calculate(Weight, Reps);

            Assert.AreEqual(expectedValue, Math.Round(actualValue, DecimalPlaces));
        }
    }
}