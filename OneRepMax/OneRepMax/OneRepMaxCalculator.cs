using System;

namespace OneRepMax
{
    public class OneRepMaxCalculator : IOneRepMaxCalculator
    {
        private const double MinimumWeight = 1.0;
        private const int MinimumReps = 1;
        private const int MaximumReps = 10;

        private readonly ICalculatorStrategy formula;

        public OneRepMaxCalculator(ICalculatorStrategy formula)
        {
            this.formula = formula;
        }

        public OneRepMaxCalculator(OneRepMaxFormula formulaType)
        {
            formula = FormulaFactory.GetFormulaStrategy(formulaType);
        }

        public double Calculate(double weight, int reps)
        {
            ValidateWeight(weight);
            ValidateReps(reps);

            return formula.Calculate(weight, reps);
        }

        public void ValidateWeight(double weight)
        {
            if (weight < MinimumWeight)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(weight)} value must be greater than or equal to {MinimumWeight} ({weight}).");
            }
        }

        public void ValidateReps(int reps)
        {
            if (reps < MinimumReps)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(reps)} value must be greater than or equal to {MinimumReps} ({reps}).");
            }

            if (reps > MaximumReps)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(reps)} value must be less than or equal to {MaximumReps} ({reps}).");
            }
        }
    }
}