using OneRepMax.Formulas;

namespace OneRepMax.Calculator
{
    public class OneRepMaxCalculator : IOneRepMaxCalculator
    {
        private readonly IFormula formula;
        private readonly IOneRepMaxValidator validator;

        public OneRepMaxCalculator() : this(ValidatorFactory.GetDefaultValidator(), FormulaFactory.GetDefaultFormula())
        {
        }

        public OneRepMaxCalculator(IOneRepMaxValidator validator) : this(validator, FormulaFactory.GetDefaultFormula())
        {
        }

        public OneRepMaxCalculator(IFormula formula): this(ValidatorFactory.GetDefaultValidator(), formula)
        {
        }

        public OneRepMaxCalculator(OneRepMaxFormula formula) : this(ValidatorFactory.GetDefaultValidator(), FormulaFactory.GetFormula(formula))
        {
        }

        public OneRepMaxCalculator(IOneRepMaxValidator validator, OneRepMaxFormula formulaType) : this(validator, FormulaFactory.GetFormula(formulaType))
        {
        }

        public OneRepMaxCalculator(IOneRepMaxValidator validator, IFormula formula)
        {
            this.formula = formula;
            this.validator = validator;
        }

        public double Calculate(double weight, int reps)
        {
            validator.ValidateWeight(weight);
            validator.ValidateReps(reps);

            return formula.Calculate(weight, reps);
        }
    }
}