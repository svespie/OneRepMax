using System;

namespace OneRepMax.Formulas
{
    internal class BrzyckiFormula : IFormula
    {
        public double Calculate(double weight, int reps) => weight * (36.0 / (37.0 - Convert.ToDouble(reps)));
    }
}