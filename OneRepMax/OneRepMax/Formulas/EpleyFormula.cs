namespace OneRepMax.Formulas
{
    internal class EpleyFormula : IFormula
    {
        public double Calculate(double weight, int reps) => weight * reps / 30.0 + weight;
    }
}