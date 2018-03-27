using System;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine.Strategy.Concrete
{
    class EqualsOf :Evaluation
    {
        public EqualsOf(object baseValue) : base(baseValue)
        {
        }

        public override bool Evaluate<T>(T contrastValue)
        {
            try
            {
                return ((T) Convert.ChangeType(baseValue, typeof(T))).Equals(contrastValue);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe);
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
