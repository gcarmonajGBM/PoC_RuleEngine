using System;
using System.Runtime.Serialization;

namespace RulesEngine.DTO
{
    [DataContract]
    class DtoTransaccionResponse
    {
        [DataMember]
        public Guid TransactionGuid { get; set; }
        [DataMember]
        public int AccountIdentifierId { get; set; }
        [DataMember]
        public int SecondaryaccountIdentifierId { get; set; }
    }
}
