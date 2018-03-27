using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class ContainOf : Evaluation
    {
        public ContainOf(object baseValue) : base(baseValue)
        {

        }
        public override bool Evaluate<T>(T contrastValue)
        {
            var type = contrastValue.GetType();
            
            return true;
        }
    }
}
