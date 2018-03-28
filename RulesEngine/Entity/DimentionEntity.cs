using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using RulesEngine.Enums;
using RulesEngine.Strategy.Abstract;
using RulesEngine.Strategy.Concrete;

namespace RulesEngine.Entity
{
    public class DimentionEntity<T>
    {
        public string DimentionColumn { get; set; }
        public decimal PercentageWeigth { get; set; }
        public int DimentionsCount { get; set; }
        public bool IsValid { get; set; }
        public Evaluation Evaluator { get; }

        public List<DimentionEntity<T>> ChildDimentions { get; set; }

        public DimentionEntity(int filterTypeId, object baseValue)
        {
            switch (filterTypeId)
            {
                case (int)OperationsAviable.Equal:
                    Evaluator = new EqualsOf(baseValue);
                    break;
                case (int)OperationsAviable.Contains:
                    Evaluator = new ContainOf<T>(baseValue);
                    break;
                case (int)OperationsAviable.GreaterEqual:
                    Evaluator = new RangeOf(baseValue);
                    break;
                case (int)OperationsAviable.LessEqual:
                    Evaluator = new RangeOf(baseValue);
                    break;
                case (int)OperationsAviable.Between:
                    Evaluator = new BetweenOf(baseValue);
                    break;
                case (int)OperationsAviable.Distinct:
                    Evaluator = new DistinctOf(baseValue);
                    break;
                default:
                    throw new ApplicationException("Filter type not support");
            }
        }

        public DimentionEntity()
        {
        }
    }
}
