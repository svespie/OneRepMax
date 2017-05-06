namespace OneRepMax.Calculator
{
    internal static class ValidatorFactory
    {
        internal static IOneRepMaxValidator GetDefaultValidator()
        {
            return new OneRepMaxValidator();
        }
    }
}