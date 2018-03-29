using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesEngine.Entity;
using RulesEngine.Enums;

namespace UnitTestRulesEngine
{
    [TestClass]
    public class UnitTestEquality
    {
        [TestMethod]
        public void WhenCompareIntEqualValuesThenReturnTrue()
        {
            int baseValue = 1;
            // Act
            DimensionEntity<int> dimention = new DimensionEntity<int>((int)OperationsAviable.Equal, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(1));
        }

        [TestMethod]
        public void WhenCompareStringEqualValuesThenReturnTrue()
        {
            string baseValue = "1";
            // Act
            DimensionEntity<string> dimention = new DimensionEntity<string>((int)OperationsAviable.Equal, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate("1"));
        }

        [TestMethod]
        public void WhenCompareDoubleEqualValuesThenReturnTrue()
        {
            double baseValue = 1.00;
            // Act
            DimensionEntity<double> dimention = new DimensionEntity<double>((int)OperationsAviable.Equal, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(1.00));
        }

        [TestMethod]
        public void WhenCompareDecimalEqualValuesThenReturnTrue()
        {
            decimal baseValue = 1;
            // Act
            DimensionEntity<decimal> dimention = new DimensionEntity<decimal>((int)OperationsAviable.Equal, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(1.00));
        }

        [TestMethod]
        public void WhenCompareCompatibleTypesEqualValuesThenReturnTrue()
        {
            string baseValue = "1";
            // Act
            DimensionEntity<string> dimention = new DimensionEntity<string>((int)OperationsAviable.Equal, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(1.00));
        }

        [TestMethod]
        public void WhenCompareUncompatibleTypesEqualValuesThenReturnFalse_WriteConsole()
        {
            string baseValue = "uno";
            // Act
            DimensionEntity<string> dimention = new DimensionEntity<string>((int)OperationsAviable.Equal, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(1.00));
        }
    }
}
