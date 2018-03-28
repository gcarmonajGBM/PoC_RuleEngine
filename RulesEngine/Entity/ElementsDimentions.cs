using System;
using System.Collections.Generic;
using System.Text;

namespace RulesEngine.Entity
{
    public class ElementsDimentions
    {
        public long RuleId { get; set; }
        public long DimensionId { get; set; }
        public long? ParentDimentionId { get; set; }
        public string DimentionTypeColumn { get; set; }
        public int RuleFilterTypeId { get; set; }
        public string Value { get; set; }
    }
}
