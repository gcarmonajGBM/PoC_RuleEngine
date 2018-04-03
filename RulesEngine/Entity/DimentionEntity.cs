using System;
using System.Collections.Generic;
using RulesEngine.Enums;
using RulesEngine.Strategy.Abstract;
using RulesEngine.Strategy.Concrete;

namespace RulesEngine.Entity
{
    public class DimensionEntity<T>
    {
		public Evaluation Evaluator { get; }

        public string RuleValue { get; set; }
        public string DimensionColumn { get; set; }
        public decimal CompliancePercentage { get; set; }
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
                default:
                    throw new ApplicationException("Filter type not support");
            }
        }

		public void EvaluateDimensions(ContractTransactionEntity transactionToEval, DimensionEntity<string> dimension, decimal percentagevalue, bool isparentEval = false)
		{
			var property = transactionToEval.GetType().GetProperty(dimension.DimensionColumn);

		    if (isparentEval)
		    {
		        CompliancePercentage = 0;
		    }
            
			if (property != null)
			{
				var propertyValue = property.GetValue(transactionToEval);
                dimension.IsValidDimension = dimension.Evaluator.Evaluate(propertyValue.ToString());
				CompliancePercentage = dimension.IsValidDimension ? CompliancePercentage+percentagevalue:CompliancePercentage;
			}
			else
			{
				Console.WriteLine("Configured property " + dimension.DimensionColumn + " don't finded.");
			}

			if (dimension.ChildDimensions.Count > 0)
			{
				foreach (var childDimention in dimension.ChildDimensions)
				{
					EvaluateDimensions(transactionToEval, childDimention, percentagevalue);
				}

			}
		}
    }
}
