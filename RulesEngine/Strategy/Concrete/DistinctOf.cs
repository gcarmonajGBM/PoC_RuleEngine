using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class DistinctOf : Evaluation
    {
        public override bool Evaluate()
        {
            return true;
        }
    }
}
