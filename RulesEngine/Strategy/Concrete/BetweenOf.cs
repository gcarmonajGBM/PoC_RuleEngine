using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class BetweenOf : Evaluation
    {
        public override bool Evaluate()
        {
            return true;
        }
    }

}
