using System;

namespace OneRepMax.Formulas
{
    internal class MayhewFormula : IFormula
    {
        public double Calculate(double weight, int reps) => 100.0 * weight / (52.2 + 41.9 * Math.Pow(Math.E, -0.055 * reps));
    }
}