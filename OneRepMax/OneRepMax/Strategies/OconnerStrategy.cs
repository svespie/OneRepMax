namespace OneRepMax.Strategies
{
    public class OconnerStrategy : ICalculatorStrategy
    {
        public double Calculate(double weight, int reps) => weight*(1.0 + 0.025*(double) reps);
    }
}