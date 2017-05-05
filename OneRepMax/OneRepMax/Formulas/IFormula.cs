namespace OneRepMax.Formulas
{
    public interface IFormula
    {
        double Calculate(double weight, int reps);
    }
}