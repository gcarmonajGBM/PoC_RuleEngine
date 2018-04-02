using System.Collections.Generic;
using System.Linq;
using RulesEngine.Entity;

namespace RulesEngine
{
    public class Engine
    {
        private int internalRules;

        //private int compliancePercentage;

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

        public List<DimensionEntity<string>> DecorateDimentionEntity(List<ElementsDimentions> itemList, long? parentDimention = null)
        {
            List<DimensionEntity<string>> listDimentionEntities = new List<DimensionEntity<string>>();
            List<ElementsDimentions> parenDimentions = itemList.Where(w => w.ParentDimentionId == parentDimention).ToList();

            foreach (var dimention in parenDimentions)
            {
                if (dimention.ParentDimentionId == null)
                {
                    internalRules = 1;
                }
                else
                {
                    internalRules++;
                }

                DimensionEntity<string> newDimention = new DimensionEntity<string>(dimention.RuleFilterTypeId, dimention.Value)
                {
                    DimensionColumn = dimention.DimentionTypeColumn,
                    IsValidDimension = false,
                    RuleValue = dimention.RuleValue.ToString().Trim(),
                    ChildDimensions = DecorateDimentionEntity(itemList, dimention.DimensionId)
                };

                newDimention.DimensionsCount = internalRules;

                listDimentionEntities.Add(newDimention);
            }

            return listDimentionEntities;
        }
    }
}
