namespace OneRepMax.Strategies
{
    internal class EpleyStrategy : ICalculatorStrategy
    {
        public double Calculate(double weight, int reps) => weight * reps / 30.0 + weight;
    }
}