using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using RulesEngine;
using RulesEngine.Entity;
using Xunit;
using Moq;
using Xunit.Abstractions;

namespace XUnitRuleEngine.test
{
    public class RuleEngineEvaluatorShould
    {
        Engine evaluator = new Engine();
        List<DimensionEntity<string>> listDimentionEntity;
        private readonly ITestOutputHelper output;

        private List<ElementsDimentions> listDimensionToEval;
        private List<ContractTransactionEntity> listTransactionToEval;

        public List<ElementsDimentions> createDimentionList()
        {
            List<ElementsDimentions> resulSetDimentions = new List<ElementsDimentions>()
            {
                //new ElementsDimentions(){RuleId = 1, RuleValue= 1511, DimensionId= 1,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1217"},

                //new ElementsDimentions(){RuleId = 2, RuleValue= 1503, DimensionId= 2,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1218"},

                //new ElementsDimentions(){RuleId = 3, RuleValue= 5001, DimensionId= 3,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1219"},

                new ElementsDimentions(){RuleId = 4, RuleValue= 1511, DimensionId= 4,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1217"},
                new ElementsDimentions(){RuleId = 4, RuleValue= 1511, DimensionId= 5,ParentDimentionId= 4,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},

                new ElementsDimentions(){RuleId = 5, RuleValue= 1503, DimensionId= 6,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1218"},
                new ElementsDimentions(){RuleId = 5, RuleValue= 1503, DimensionId= 7,ParentDimentionId= 6,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},

                new ElementsDimentions(){RuleId = 6, RuleValue= 1599, DimensionId= 8,ParentDimentionId= null,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "200"},
                new ElementsDimentions(){RuleId = 6, RuleValue= 1599, DimensionId= 9,ParentDimentionId= 8,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},

                new ElementsDimentions(){RuleId = 7, RuleValue= 0057, DimensionId= 10,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1218"},
                new ElementsDimentions(){RuleId = 7, RuleValue= 0057, DimensionId= 11,ParentDimentionId= 10,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},
                new ElementsDimentions(){RuleId = 7, RuleValue= 0057, DimensionId= 12,ParentDimentionId= 10,DimentionTypeColumn = "TransactionTypeId",RuleFilterTypeId= 1,Value= "50"},

                new ElementsDimentions(){RuleId = 8, RuleValue= 0056, DimensionId= 13,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1217"},
                new ElementsDimentions(){RuleId = 8, RuleValue= 0056, DimensionId= 14,ParentDimentionId= 13,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},
                new ElementsDimentions(){RuleId = 8, RuleValue= 0056, DimensionId= 15,ParentDimentionId= 13,DimentionTypeColumn = "SubAccountId",RuleFilterTypeId= 1,Value= "62914"},
                new ElementsDimentions(){RuleId = 8, RuleValue= 0056, DimensionId= 16,ParentDimentionId= 13,DimentionTypeColumn = "TransactionTypeId",RuleFilterTypeId= 1,Value= "50"},

                new ElementsDimentions(){RuleId = 9, RuleValue= 0056, DimensionId= 17,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1217"},
                new ElementsDimentions(){RuleId = 9, RuleValue= 0056, DimensionId= 18,ParentDimentionId= 17,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},
                new ElementsDimentions(){RuleId = 9, RuleValue= 0056, DimensionId= 19,ParentDimentionId= 17,DimentionTypeColumn = "SubAccountId",RuleFilterTypeId= 1,Value= "62915"},
                new ElementsDimentions(){RuleId = 9, RuleValue= 0056, DimensionId= 20,ParentDimentionId= 17,DimentionTypeColumn = "TransactionTypeId",RuleFilterTypeId= 1,Value= "50"},

                new ElementsDimentions(){RuleId = 10, RuleValue= 5001, DimensionId= 21,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1219"},
                new ElementsDimentions(){RuleId = 10, RuleValue= 5001, DimensionId= 22,ParentDimentionId= 21,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "52"},
                new ElementsDimentions(){RuleId = 10, RuleValue= 5001, DimensionId= 23,ParentDimentionId= 21,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "MX"},
                new ElementsDimentions(){RuleId = 10, RuleValue= 5001, DimensionId= 24,ParentDimentionId= 21,DimentionTypeColumn = "CustodianPartyId",RuleFilterTypeId= 1,Value= "8650"},
                new ElementsDimentions(){RuleId = 10, RuleValue= 5001, DimensionId= 25,ParentDimentionId= 21,DimentionTypeColumn = "SubAccountId",RuleFilterTypeId= 1,Value= "45263"},
                new ElementsDimentions(){RuleId = 10, RuleValue= 5001, DimensionId= 26,ParentDimentionId= 21,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 2,Value= "15,68,65,1"},

                };

            return resulSetDimentions;
        }

        public List<ContractTransactionEntity> CreateTransactionList()
        {
            List<ContractTransactionEntity> resulSetDimentions = new List<ContractTransactionEntity>()
            {
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 45263,
                    TradingLineId = 68,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 52,
                    AccountTypeId = 1219,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1217,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1218,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 200,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 50,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1218,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 62914,
                    TradingLineId = 1,
                    TransactionTypeId = 50,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1217,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = Guid.NewGuid(),
                    SubAccountId = 62915,
                    TradingLineId = 1,
                    TransactionTypeId = 50,
                    CustodyTypeId = 1,
                    CustodianPartyId = 8650,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1217,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = "MX",
                    AdendumId = 1,
                    ClientTypeId = 1},


                //new ContractTransactionEntity() {
                //    TransactionGuid = Guid.NewGuid(),
                //    SubAccountId = 1,
                //    TradingLineId = 1,
                //    TransactionTypeId = 1,
                //    CustodyTypeId = 1,
                //    CustodianPartyId = 1,
                //    CompanyId = 1,
                //    ContractTypeId = 1,
                //    AccountTypeId = 1,
                //    PersonTypeId = 1,
                //    TaxableEntityTypeId = 1,
                //    NationalityId = "MX",
                //    AdendumId = 1,
                //    ClientTypeId = 1},
                //new ContractTransactionEntity() {
                //    TransactionGuid = Guid.NewGuid(),
                //    SubAccountId = 1,
                //    TradingLineId = 1,
                //    TransactionTypeId = 1,
                //    CustodyTypeId = 1,
                //    CustodianPartyId = 1,
                //    CompanyId = 1,
                //    ContractTypeId = 1,
                //    AccountTypeId = 1,
                //    PersonTypeId = 1,
                //    TaxableEntityTypeId = 1,
                //    NationalityId = "MX",
                //    AdendumId = 1,
                //    ClientTypeId = 1},
                //new ContractTransactionEntity() {
                //    TransactionGuid = Guid.NewGuid(),
                //    SubAccountId = 1,
                //    TradingLineId = 1,
                //    TransactionTypeId = 1,
                //    CustodyTypeId = 1,
                //    CustodianPartyId = 1,
                //    CompanyId = 1,
                //    ContractTypeId = 1,
                //    AccountTypeId = 1,
                //    PersonTypeId = 1,
                //    TaxableEntityTypeId = 1,
                //    NationalityId = "MX",
                //    AdendumId = 1,
                //    ClientTypeId = 1}
            };

            return resulSetDimentions;
        }


        public RuleEngineEvaluatorShould(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void AvaregeResponseTime_1700Requests()
        {
            var allResponseTimes = new List<(DateTime Start, DateTime End)>();
            Initialize();

            for (int i = 0; i < 1700; i++)
            {
                var start = DateTime.Now;
                EvaluateLists();
                var end = DateTime.Now;

                allResponseTimes.Add((start, end));
            }

            var expected = 3;
            var actual = (int)allResponseTimes.Select(r => (r.End - r.Start).TotalMilliseconds).Average();
            //this.output.WriteLine(actual.ToString());
            Assert.True(actual <= expected, $"Expected average response time of less than or equal to {expected} ms but was {actual} ms.");
        }

        public void Initialize()
        {
            listDimensionToEval = createDimentionList();
            listTransactionToEval = CreateTransactionList();
            // Act
            listDimentionEntity = evaluator.DecorateDimentionEntity(listDimensionToEval);
        }

        public void EvaluateLists()
        {

            listTransactionToEval.ForEach(F => listDimentionEntity.ForEach(f =>
            {
                f.EvaluateDimensions(F, f, (decimal)100 / f.DimensionsCount, true);
                if (f.CompliancePercentage == 100)
                {
                    Console.WriteLine("Rule Cumplish with value " + f.RuleValue + " for GUID " + F.TransactionGuid + " and AccountTypeId " + F.AccountTypeId);
                }
            }));
        }
    }
}
