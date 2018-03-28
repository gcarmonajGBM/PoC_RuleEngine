using System;
using System.Collections.Generic;
using System.Text;
using RulesEngine.DTO;

namespace RulesEngine.Entity
{
    public class ContractTransactionEntity : DtoTransactionIncome
    {
        public int CompanyId { get; set; }
        private int ContractTypeId { get; set; }
        private int AccountTypeId { get; set; }
        private int PersonTypeId { get; set; }
        private int TaxableEntityTypeId { get; set; }
        private int NationalityId { get; set; }
        private int AdendumId { get; set; }
        private int ClientTypeId { get; set; }

    }
}
