using System;

namespace OneRepMax.Calculator
{
    internal class OneRepMaxValidator : IOneRepMaxValidator
    {
        private const double MinimumWeight = 1.0;
        private const int MinimumReps = 1;
        private const int MaximumReps = 10;

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