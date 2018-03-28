using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Entity;
using RulesEngine.Enums;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine
{
    public class Engine
    {
        //private Evaluation evaluateValues;
        //private List<DimentionEntity<int>> Rules;

        //private DimentionEntity<int> objTest = new DimentionEntity<int>((int)OperationsAviable.Equal, 1);

        //public void testMetod()
        //{
        //    objTest.Evaluator.Evaluate(1);
        //}

        /*create stub for evaluate this*/
        public void GetcontractInfo()
        {

        }

        public void DecorateContractTransaction()
        {

        }

        /*create stub for evaluate this*/
        public void GetRuleDimentions()
        {

        }

        public IList DecorateDimentionEntity<T>(T itemList) where T : IList
        {
            foreach (var item in itemList)
            {
                item.GetType().GetProperties();
            }

            return new List<T>();
        }
    }
}
