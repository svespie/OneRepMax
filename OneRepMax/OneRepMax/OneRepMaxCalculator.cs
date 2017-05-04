using System;

namespace OneRepMax
{
    public class OneRepMaxCalculator : IOneRepMaxCalculator
    {
        private const double MinimumWeight = 1.0;
        private const int MinimumReps = 1;
        private const int MaximumReps = 10;
        private const int DecimalPlaces = 2;

        public double Calculate(double weight, int reps, ICalculatorStrategy formula)
        {
            ValidateWeightAndReps(weight, reps);

            return Math.Round(formula.Calculate(weight, reps), DecimalPlaces);
        }

        private static void ValidateWeightAndReps(double weight, int reps)
        {
            if (weight < MinimumWeight)
            {
                throw new ArgumentOutOfRangeException($"The weight value must be greater than or equal to {MinimumWeight} ({weight}).");
            }

            if (reps < MinimumReps || reps > MaximumReps)
            {
                throw new ArgumentOutOfRangeException($"The reps value must be greater than or equal to {MinimumReps} and less than or equal to {MaximumReps} ({reps}).");
            }
        }
    }
}