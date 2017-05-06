using System;

namespace OneRepMax.Formulas
{
    internal static class FormulaFactory
    {
        internal static IFormula GetDefaultFormula()
        {
            return GetFormula(OneRepMaxFormula.Epley);
        }

        internal static IFormula GetFormula(OneRepMaxFormula formula)
        {
            switch (formula)
            {
                case OneRepMaxFormula.Brzycki: return new BrzyckiFormula();
                case OneRepMaxFormula.Epley: return new EpleyFormula();
                case OneRepMaxFormula.Lander: return new LanderFormula();
                case OneRepMaxFormula.Lombardi: return new LombardiFormula();
                case OneRepMaxFormula.Mayhew: return new MayhewFormula();
                case OneRepMaxFormula.OConner: return new OconnerFormula();
                case OneRepMaxFormula.Wathan: return new WathanFormula();
                default: throw new NotImplementedException();
            }
        }
    }
}