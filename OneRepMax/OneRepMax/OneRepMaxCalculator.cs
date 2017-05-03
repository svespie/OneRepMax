using System;
using System.Linq;

namespace OneRepMax
{
    public class OneRepMaxCalculator : IOneRepMaxCalculator
    {
        private const double MinimumWeight = 1.0;
        private const int MinimumReps = 1;
        private const int MaximumReps = 10;
        private const int DecimalPlaces = 2;

        public double Calculate(double weight, int reps, Formula formula)
        {
            ValidateWeightAndReps(weight, reps);

            var oneRepMax = SelectFormula(formula)(weight, reps);

            return Math.Round(oneRepMax, DecimalPlaces);
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

        private static Func<double, int, double> SelectFormula(Formula formula)
        {
            switch (formula)
            {
                case Formula.Average:
                    return Average;
                case Formula.Brzycki:
                    return Brzycki;
                case Formula.Epley:
                    return Epley;
                case Formula.Lander:
                    return Lander;
                case Formula.Lombardi:
                    return Lombardi;
                case Formula.Mayhew:
                    return Mayhew;
                case Formula.OConner:
                    return OConner;
                case Formula.Wathan:
                    return Wathan;
                default:
                    throw new NotImplementedException($"The formula {formula} does not appear to have been implemented.");
            }
        }

        private static double Wathan(double weight, int reps) => 100.0 * weight / (48.8 + 53.8 * Math.Pow(Math.E, -0.075 * reps));

        private static double OConner(double weight, int reps) => weight * (1.0 + 0.025 * (double)reps);

        private static double Mayhew(double weight, int reps) => 100.0 * weight / (52.2 + 41.9 * Math.Pow(Math.E, -0.055 * reps));

        private static double Lombardi(double weight, int reps) => weight * Math.Pow(reps, 0.1);

        private static double Lander(double weight, int reps) => 100.0 * weight / (101.3 - 2.67123 * reps);

        private static double Epley(double weight, int reps) => weight * reps / 30.0 + weight;

        private static double Brzycki(double weight, int reps) => weight * (36.0 / (37.0 - Convert.ToDouble(reps)));

        private static double Average(double weight, int reps) => Avg(Brzycki(weight, reps), Epley(weight, reps), Lander(weight, reps), Lombardi(weight, reps), Mayhew(weight, reps), OConner(weight, reps), Wathan(weight, reps));

        private static double Avg(params double[] maxes) => maxes.Average();
    }
}