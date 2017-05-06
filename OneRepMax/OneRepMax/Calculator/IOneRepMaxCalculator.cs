namespace OneRepMax.Calculator
{
    public interface IOneRepMaxCalculator
    {
        /// <summary>
        /// Calculates an estimated 1RM based on weight and repetitions.
        /// </summary>
        /// <param name="weight">Double value representing the weight used for testing.</param>
        /// <param name="reps">Integer value representing the number of reps obtained in testing.</param>
        /// <returns>
        /// Double representing an estimated 1RM based on the input parameters. An argument out of range exception will be thrown when invalid weight and rep values are passed in.
        /// It is recommended that input be checked for validity prior to calling this method.
        /// </returns>
        double Calculate(double weight, int reps);
    }
}