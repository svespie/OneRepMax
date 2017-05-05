namespace OneRepMax.Formulas
{
    internal class LanderFormula : IFormula
    {
        public double Calculate(double weight, int reps) => 100.0 * weight / (101.3 - 2.67123 * reps);
    }
}