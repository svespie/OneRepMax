using System;

namespace OneRepMax.Strategies
{
    public class BrzyckiStrategy : ICalculatorStrategy
    {
        public double Calculate(double weight, int reps) => weight * (36.0 / (37.0 - Convert.ToDouble(reps)));
    }
}