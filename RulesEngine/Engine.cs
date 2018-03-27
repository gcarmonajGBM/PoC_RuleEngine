using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.Entity;
using RulesEngine.Enums;
using RulesEngine.Strategy.Abstract;

namespace RulesEngine
{
    class Engine
    {
        private Evaluation evaluateValues;
        private List<DimentionEntity> Rules;

        private DimentionEntity objTest = new DimentionEntity((int)OperationsAviable.Equal, 1);

        public void testMetod()
        {
            objTest.Evaluator.Evaluate(1);
        }

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

        public void DecorateDimentionEntity()
        {

        }
    }
}
