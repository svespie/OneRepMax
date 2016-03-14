using System;
using System.Linq;

namespace OneRepMax
{
    public static class Calculate
    {
        private const double MinimumWeight = 1.0;
        private const int MinimumReps = 1;
        private const int MaximumReps = 10;
        private const int DecimalPlaces = 2;

        /// <summary>
        /// This is the entry point to use the calculator. This is the only public method, allowing a simple interface. Any recognized errors will result in a result of -1, allowing graceful checking and handling of input issues.
        /// </summary>
        /// <param name="weight">Double value representing the weight used for testing. The weight must be greater than 0. There is no defined limit at this time.</param>
        /// <param name="reps">Integer value representing the number of reps obtained in testing. Allowable range is from 1 to 10 reps.</param>
        /// <param name="formula">Enumeration of type Formula that selects the formula that should be used to perform the calculation. The Formula enumeration is publicly available in this library.</param>
        /// <returns>
        /// Double representing an estimated 1RM based on the indicated weight, reps and formula. An argument out of range exception will be thrown when invalid weight and rep values are passed in.
        /// It is recommended that input parameters be checked for validity prior to calling this method.
        /// </returns>
        public static double OneRepMax(double weight, int reps, Formula formula)
        {
            ValidateWeightAndReps(weight, reps);

            var oneRepMax = SelectFormula(formula)(weight, reps);

            return Math.Round(oneRepMax, digits: DecimalPlaces);
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

        /// <summary>
        /// Estimates a 1RM based on the Wathan formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Wathan(double weight, int reps) => 100.0 * weight / (48.8 + 53.8 * Math.Pow(Math.E, -0.075 * reps));

        /// <summary>
        /// Estimates a 1RM based on the O'Conner formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double OConner(double weight, int reps) => weight * (1.0 + 0.025 * (double)reps);

        /// <summary>
        /// Estimates a 1RM based on the Mayhew formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Mayhew(double weight, int reps) => 100.0 * weight / (52.2 + 41.9 * Math.Pow(Math.E, -0.055 * reps));

        /// <summary>
        /// Estimates a 1RM based on the Lombardi formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Lombardi(double weight, int reps) => weight * Math.Pow(reps, 0.1);

        /// <summary>
        /// Estimates a 1RM based on the Lander formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Lander(double weight, int reps) => 100.0 * weight / (101.3 - 2.67123 * reps);

        /// <summary>
        /// Estimates a 1RM based on the Epley formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Epley(double weight, int reps) => weight * reps / 30.0 + weight;

        /// <summary>
        /// Estimates a 1RM based on the Brzycki formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Brzycki(double weight, int reps) => weight * (36.0 / (37.0 - Convert.ToDouble(reps)));

        /// <summary>
        /// Estimates a 1RM based on an average of all the forumulas implemented within this library.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Average(double weight, int reps) => Avg(Brzycki(weight, reps), Epley(weight, reps), Lander(weight, reps), Lombardi(weight, reps), Mayhew(weight, reps), OConner(weight, reps), Wathan(weight, reps));

        private static double Avg(params double[] maxes) => maxes.Average();
    }
}