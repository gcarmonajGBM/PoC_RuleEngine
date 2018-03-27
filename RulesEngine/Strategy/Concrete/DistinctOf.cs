using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    internal class DistinctOf : Evaluation
    {
        public override bool Evaluate<T>(T contrastValue)
        {
            return true;
        }

        public DistinctOf(object baseValue) : base(baseValue)
        {
        }
    }
}
