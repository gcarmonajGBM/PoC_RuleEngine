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

        private DimentionEntity objTest = new DimentionEntity((int)OperationsAviable.Igual);

        public void testMetod()
        {
            objTest.Evaluator.Evaluate();
        }

    }
}
