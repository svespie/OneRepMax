namespace OneRepMax.Calculator
{
    public interface IOneRepMaxValidator
    {
        /// <summary>
        /// Validates the weight value passed into the OneRepMax calculator. Throws an argument out of range exception with a message when invalid input is encountered.
        /// </summary>
        /// <param name="weight"></param>
        void ValidateWeight(double weight);

        /// <summary>
        /// Validates the reps value passed into the OneRepMax calculator. Throws an argument out of range exception with a message when invalid input is encountered.
        /// </summary>
        /// <param name="reps"></param>
        void ValidateReps(int reps);
    }
}