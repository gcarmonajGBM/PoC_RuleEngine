using System.Collections.Generic;

namespace RulesEngine.Strategy.Abstract
{
    public abstract class Evaluation
    {
        public object baseValue;

        protected Evaluation(object baseValue)
        {
            this.baseValue = baseValue;
        }

        public abstract bool Evaluate<T>(T contrastValue);
    }
}
