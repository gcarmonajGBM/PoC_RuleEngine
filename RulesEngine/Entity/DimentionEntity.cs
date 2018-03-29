using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using RulesEngine.Enums;
using RulesEngine.Strategy.Abstract;
using RulesEngine.Strategy.Concrete;

namespace RulesEngine.Entity
{
    public class DimensionEntity<T>
    {
		public Evaluation Evaluator { get; }

		public string DimensionColumn { get; set; }
        public decimal PercentageWeigth { get; set; }
        public int DimensionsCount { get; set; }
        public bool IsValidDimension { get; set; }
        public List<DimensionEntity<T>> ChildDimensions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:RulesEngine.Entity.DimensionEntity`1"/> class.
        /// </summary>
        /// <param name="filterTypeId">Filter type identifier.</param>
        /// <param name="baseValue">Base value.</param>
		public DimensionEntity(int filterTypeId, object baseValue)
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

		public decimal EvaluateDimensions(ContractTransactionEntity transactionToEval, DimensionEntity<string> dimension)
		{
			var property = transactionToEval.GetType().GetProperty(dimension.DimensionColumn);

			if (property != null)
			{
				var propertyValue = property.GetValue(transactionToEval);
                dimension.IsValidDimension = dimension.Evaluator.Evaluate(propertyValue.ToString());
			}
			else
			{
				Console.WriteLine("Configured property " + dimension.DimensionColumn + " don't finded.");
			}

			if (dimension.ChildDimensions.Count > 0)
			{
				foreach (var childDimention in dimension.ChildDimensions)
				{
					EvaluateDimensions(transactionToEval, childDimention);
				}

			}

			return new decimal();
		}
    }
}
