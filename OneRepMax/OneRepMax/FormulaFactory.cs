using System;
using OneRepMax.Strategies;

namespace OneRepMax
{
    internal static class FormulaFactory
    {
        internal static ICalculatorStrategy GetFormulaStrategy(OneRepMaxFormula formula)
        {
            switch (formula)
            {
                case OneRepMaxFormula.Brzycki: return new BrzyckiStrategy();
                case OneRepMaxFormula.Epley: return new EpleyStrategy();
                case OneRepMaxFormula.Lander: return new LanderStrategy();
                case OneRepMaxFormula.Lombardi: return new LombardiStrategy();
                case OneRepMaxFormula.Mayhew: return new MayhewStrategy();
                case OneRepMaxFormula.OConner: return new OconnerStrategy();
                case OneRepMaxFormula.Wathan: return new WathanStrategy();
                default: throw new NotImplementedException();
            }
        }
    }
}