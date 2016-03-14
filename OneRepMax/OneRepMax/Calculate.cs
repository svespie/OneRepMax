using System;
using System.Linq;

namespace OneRepMax
{
    public static class Calculate
    {
        /// <summary>
        /// This is the entry point to use the calculator. This is the only public method, allowing a simple interface. Any recognized errors will result in a result of -1, allowing graceful checking and handling of input issues.
        /// </summary>
        /// <param name="weight">Double value representing the weight used for testing. The weight must be greater than 0. There is no defined limit at this time.</param>
        /// <param name="reps">Integer value representing the number of reps obtained in testing. Allowable range is from 1 to 10 reps.</param>
        /// <param name="formula">Enumeration of type Formula that selects the formula that should be used to perform the calculation. The Formula enumeration is publicly available in this library.</param>
        /// <returns>
        /// Double representing an estimated 1RM based on the indicated weight, reps and formula. A value of -1 will be returned when the input parameters are found to be unsupported. There
        /// will not be any detail information regarding what the issue was. It is recommended that input parameters be checked for validity prior to calling this method as well as checking the output
        /// before using it.
        /// </returns>
        public static double OneRepMax(double weight, int reps, Formula formula)
        {
            if (weight < 1.0 || reps < 1 || reps > 10)
            {
                return -1.0;
            }

            double oneRepMax;

            switch (formula)
            {
                case Formula.Average:
                    oneRepMax = Average(weight, reps);
                    break;
                case Formula.Brzycki:
                    oneRepMax = Brzycki(weight, reps);
                    break;
                case Formula.Epley:
                    oneRepMax = Epley(weight, reps);
                    break;
                case Formula.Lander:
                    oneRepMax = Lander(weight, reps);
                    break;
                case Formula.Lombardi:
                    oneRepMax = Lombardi(weight, reps);
                    break;
                case Formula.Mayhew:
                    oneRepMax = Mayhew(weight, reps);
                    break;
                case Formula.OConner:
                    oneRepMax = OConner(weight, reps);
                    break;
                case Formula.Wathan:
                    oneRepMax = Wathan(weight, reps);
                    break;
                default:
                    return -1.0;
            }

            return Math.Round(oneRepMax, 2);
        }

        /// <summary>
        /// Estimates a 1RM based on the Wathan formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Wathan(double weight, int reps)
        {
            return 100.0 * weight / (48.8 + 53.8 * Math.Pow(Math.E, -0.075 * reps));
        }

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
        private static double Mayhew(double weight, int reps)
        {
            return 100.0 * weight / (52.2 + 41.9 * Math.Pow(Math.E, -0.055 * reps));
        }

        /// <summary>
        /// Estimates a 1RM based on the Lombardi formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Lombardi(double weight, int reps)
        {
            return weight * Math.Pow(reps, 0.1);
        }

        /// <summary>
        /// Estimates a 1RM based on the Lander formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Lander(double weight, int reps)
        {
            return 100.0 * weight / (101.3 - 2.67123 * reps);
        }

        /// <summary>
        /// Estimates a 1RM based on the Epley formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Epley(double weight, int reps)
        {
            return weight * reps / 30.0 + weight;
        }

        /// <summary>
        /// Estimates a 1RM based on the Brzycki formula.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Brzycki(double weight, int reps)
        {
            return weight * (36.0 / (37.0 - Convert.ToDouble(reps)));
        }

        /// <summary>
        /// Estimates a 1RM based on an average of all the forumulas implemented within this library.
        /// </summary>
        /// <param name="weight">The weight used in testing. Units are not necessary. The output will be in the same units as this value. Valid values are &gt;= 1.</param>
        /// <param name="reps">The number of repetitions performed. A range of 1 through 9 is often considered to be most accurate. Valid values are &gt;= 1 and &lt;=10.</param>
        /// <returns>
        /// Returns an estimated 1RM max rounded to two decimals or -1 if the input is deemed invalid.
        /// </returns>
        private static double Average(double weight, int reps)
        {
            return Avg(Brzycki(weight, reps), Epley(weight, reps), Lander(weight, reps), Lombardi(weight, reps), Mayhew(weight, reps), OConner(weight, reps), Wathan(weight, reps));
        }

        private static double Avg(params double[] maxes)
        {
            return maxes.Average();
        }
    }
}