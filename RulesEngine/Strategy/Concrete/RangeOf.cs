using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class RangeOf : Evaluation
    {
        public RangeOf(object baseValue) : base(baseValue)
        {
        }

        public override bool Evaluate<T>(T contrastValue)
        {
            return true;
        }
    }
}
