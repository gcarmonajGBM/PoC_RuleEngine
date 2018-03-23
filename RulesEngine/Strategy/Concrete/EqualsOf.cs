using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class EqualsOf :Evaluation
    {
        public override bool Evaluate()
        {
            return true;
        }
    }
}
