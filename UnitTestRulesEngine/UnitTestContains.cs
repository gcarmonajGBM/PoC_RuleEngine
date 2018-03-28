using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesEngine.Entity;
using RulesEngine.Enums;

namespace UnitTestRulesEngine
{
    [TestClass]
    public class UnitTestContains
    {
        [TestMethod]
        public void WhenCompareListIntContainedValuesThenReturnTrue()
        {
            List<int> baseValue = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> contrastValue = new List<int>() { 1, 4 };

            // Act
            DimentionEntity<int> dimention = new DimentionEntity<int>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListIntNotContainedValuesThenReturnTrue()
        {
            List<int> baseValue = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> contrastValue = new List<int>() { 7, 8 };
            
            // Act
            DimentionEntity<int> dimention = new DimentionEntity<int>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListStringContainedValuesThenReturnTrue()
        {
            List<string> baseValue = new List<string>() { "1", "2", "3", "4", "5" };
            List<string> contrastValue = new List<string>() { "1", "4" };
            
            // Act
            DimentionEntity<string> dimention = new DimentionEntity<string>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListStringNotContainedValuesThenReturnTrue()
        {
            List<string> baseValue = new List<string>() { "1", "2", "3", "4", "5" };
            List<string> contrastValue = new List<string>() { "7", "8" };
            
            // Act
            DimentionEntity<string> dimention = new DimentionEntity<string>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListDoubleContainedValuesThenReturnTrue()
        {
            List<double> baseValue = new List<double>() { 1.00, 2.00, 3.00, 4.00, 5.00 };
            List<double> contrastValue = new List<double>() { 1.00, 4.00 };
            
            // Act
            DimentionEntity<double> dimention = new DimentionEntity<double>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareDoubleStringNotContainedValuesThenReturnTrue()
        {
            List<double> baseValue = new List<double>() { 1.00, 2.00, 3.00, 4.00, 5.00 };
            List<double> contrastValue = new List<double>() { 7.00, 8.00 };
            
            // Act
            DimentionEntity<double> dimention = new DimentionEntity<double>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListStringNotContainedValuesThenReturnTrue_ComparitionStringInt()
        {
            List<string> baseValue = new List<string>() { "1", "2", "3", "4", "5" };
            List<string> contrastValue = new List<string>() { "1", "4" };

            // Act
            DimentionEntity<int> dimention = new DimentionEntity<int>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListStringNotContainedValuesThenReturnTrue_ComparitionIntString()
        {
            List<int> baseValue = new List<int>() { 1,2,3,4,5 };
            List<int> contrastValue = new List<int>() { 1,4 };

            // Act
            DimentionEntity<string> dimention = new DimentionEntity<string>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListDistincTypesContainedValuesThenReturnTrue()
        {
            List<int> baseValue = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> contrastValue = new List<string>() { "1", "2" };

            // Act
            DimentionEntity<int> dimention = new DimentionEntity<int>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }

        [TestMethod]
        public void WhenCompareListDistincTypesNotContainedValuesThenReturnTrue()
        {
            List<int> baseValue = new List<int>() { 1, 2, 3, 4, 5 };
            List<string> contrastValue = new List<string>() { "7", "8" };
            
            // Act
            DimentionEntity<int> dimention = new DimentionEntity<int>((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsFalse(dimention.Evaluator.Evaluate(contrastValue));
        }
    }
}
