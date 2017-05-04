using System;

namespace OneRepMax.Strategies
{
    public class WathanStrategy : ICalculatorStrategy
    {
        public double Calculate(double weight, int reps) => 100.0 * weight / (48.8 + 53.8 * Math.Pow(Math.E, -0.075 * reps));
    }
}