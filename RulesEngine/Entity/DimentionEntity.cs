using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using RulesEngine.Enums;
using RulesEngine.Strategy.Abstract;
using RulesEngine.Strategy.Concrete;

namespace RulesEngine.Entity
{
    public class DimentionEntity
    {
        public int RuleId { get; set; }
        public int DimentionId { get; set; }
        public List<DimentionEntity> ChildDimentions { get; set; }
        public int ParentDimentionId { get; set; }
        public string DimentionColumn { get; set; }
        public string Value { get; set; }

        public Evaluation Evaluator { get; }

        public DimentionEntity(int filterTypeId)
        {
            switch (filterTypeId)
            {
                case (int)OperationsAviable.Igual:
                    Evaluator = new EqualsOf();
                    break;
                case (int)OperationsAviable.Contiene:
                    Evaluator = new ContainOf();
                    break;
                case (int)OperationsAviable.MayorIgual:
                    Evaluator = new RangeOf();
                    break;
                case (int)OperationsAviable.MenorIgual:
                    Evaluator = new RangeOf();
                    break;
                case (int)OperationsAviable.Entre:
                    Evaluator = new BetweenOf();
                    break;
                case (int)OperationsAviable.Distinto:
                    Evaluator = new DistinctOf();
                    break;
                default:
                    throw new ApplicationException("Filter type not support");
            }
        }
    }
}
