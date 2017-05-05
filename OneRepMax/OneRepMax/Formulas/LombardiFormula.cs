using System;

namespace OneRepMax.Formulas
{
    internal class LombardiFormula : IFormula
    {
        public double Calculate(double weight, int reps) => weight * Math.Pow(reps, 0.1);
    }
}