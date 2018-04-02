using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class ContainOf<TU> : Evaluation
    {
        public ContainOf(object baseValue) : base(baseValue)
        {
        }

        public override bool Evaluate<T>(T contrastValue)
        {
            try
            {
                bool boolenValue = ((IEnumerable<TU>)baseValue.ToString().Split(",").AsEnumerable()).Intersect((IEnumerable<TU>)contrastValue.ToString().Split(",").AsEnumerable()).Any();

                return boolenValue;
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
