namespace OneRepMax.Formulas
{
    internal class OconnerFormula : IFormula
    {
        public double Calculate(double weight, int reps) => weight*(1.0 + 0.025*(double) reps);
    }
}