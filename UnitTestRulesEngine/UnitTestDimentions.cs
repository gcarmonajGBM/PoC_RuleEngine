using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Serialization;
using RulesEngine;
using RulesEngine.Entity;

namespace UnitTestRulesEngine
{
    [TestClass]
    public class UnitTestDimentions
    {
        [TestMethod]
        public void WhenHaveListDimentionsThenHaveRuleDimentionObject()
        {
            List<ElementsDimentions> resulSetDimentions = new List<ElementsDimentions>()
            {
                new ElementsDimentions(){RuleId = 1,DimensionId= 1,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 2,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "2"},
                new ElementsDimentions(){RuleId = 3,DimensionId= 3,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "3"}
            };

            // Act
            Engine evaluator = new Engine();
            var listDimentionEntity = evaluator.DecorateDimentionEntity(resulSetDimentions);

            // Acert
            Assert.AreEqual(resulSetDimentions.Count(), listDimentionEntity.Count);
        }
    }

    class ElementsDimentions
    {
        public long RuleId { get; set; }
        public long DimensionId { get; set; }
        public long? ParentDimentionId { get; set; }
        public string DimentionTypeColumn { get; set; }
        public int RuleFilterTypeId { get; set; }
        public string Value { get; set; }
    }
}
