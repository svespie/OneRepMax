using System;

namespace OneRepMax.Strategy
{
    public class LombardiStrategy : ICalculatorStrategy
    {
        public double Calculate(double weight, int reps) => weight * Math.Pow(reps, 0.1);
    }
}