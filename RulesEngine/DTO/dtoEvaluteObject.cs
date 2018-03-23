using System;
using System.Runtime.Serialization;

namespace RulesEngine.DTO
{
    [DataContract]
    class DtoTransactionIncome
    {
        [DataMember]
        public Guid TransactionGuid { get; set; }
        [DataMember]
        public Int64 SubAccountId { get; set; }
        [DataMember]
        public int TradingLineId { get; set; }
        [DataMember]
        public int TransactionTypeId { get; set; }
        [DataMember]
        public int CustodyTypeId { get; set; }
        [DataMember]
        public int CustodianPartyId { get; set; }
    }
}
