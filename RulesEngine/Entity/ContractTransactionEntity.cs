using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.DTO;

namespace RulesEngine.Entity
{
    public class ContractTransactionEntity : DtoTransactionIncome
    {
        public int CompanyId { get; set; }
        public int ContractTypeId { get; set; }
        public int AccountTypeId { get; set; }
        public int PersonTypeId { get; set; }
        public int TaxableEntityTypeId { get; set; }
        public int NationalityId { get; set; }
        public int AdendumId { get; set; }
        public int ClientTypeId { get; set; }
    }
}
