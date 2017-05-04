using System;

namespace OneRepMax.Strategy
{
    public class LanderStrategy : ICalculatorStrategy
    {
        public double Calculate(double weight, int reps) => 100.0 * weight / (101.3 - 2.67123 * reps);
    }
}