using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            var asQueryable = ((IEnumerable) contrastValue).AsQueryable();

            var type = contrastValue.GetType();
            
            return true;
        }
    }
}
