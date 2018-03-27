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
        public void WhenCompareListIntEqualValuesThenReturnTrue()
        {
            List<int> baseValue = new List<int>(){1,2,3,4,5};
            // Act
            DimentionEntity dimention = new DimentionEntity((int)OperationsAviable.Contains, baseValue);

            // Assert
            Assert.IsTrue(dimention.Evaluator.Evaluate<List<int>>(baseValue));
        }
    }
}
