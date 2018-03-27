using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class BetweenOf : Evaluation
    {
        public override bool Evaluate<T>(T contrastValue)
        {
            return true;
        }

        public BetweenOf(object baseValue) : base(baseValue)
        {
        }
    }

}
