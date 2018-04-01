using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesEngine;
using RulesEngine.Entity;

namespace UnitTestRulesEngine
{
    [TestClass]
    public class UnitTestDimentions
    {
		Engine evaluator = new Engine();
		List<DimensionEntity<string>> listDimentionEntity;

        public List<ElementsDimentions> createDimentionList()
        {
            List<ElementsDimentions> resulSetDimentions = new List<ElementsDimentions>()
            {
                new ElementsDimentions(){RuleId = 1,DimensionId= 1,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "1"},

                new ElementsDimentions(){RuleId = 2,DimensionId= 2,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "2"},

                new ElementsDimentions(){RuleId = 3,DimensionId= 3,ParentDimentionId= null,DimentionTypeColumn = "AccountTypeId",RuleFilterTypeId= 1,Value= "3"},

                new ElementsDimentions(){RuleId = 1,DimensionId= 4,ParentDimentionId= 1,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 1,DimensionId= 5,ParentDimentionId= 1,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 1,DimensionId= 6,ParentDimentionId= 1,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"},

                new ElementsDimentions(){RuleId = 2,DimensionId= 7,ParentDimentionId= 2,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 8,ParentDimentionId= 2,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 9,ParentDimentionId= 2,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 10,ParentDimentionId= 9,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 11,ParentDimentionId= 9,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 12,ParentDimentionId= 9,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"},

                new ElementsDimentions(){RuleId = 2,DimensionId= 13,ParentDimentionId= 9,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 14,ParentDimentionId= 9,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 2,DimensionId= 16,ParentDimentionId= 9,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"},

                new ElementsDimentions(){RuleId = 3,DimensionId= 17,ParentDimentionId= 3,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 3,DimensionId= 18,ParentDimentionId= 3,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 3,DimensionId= 18,ParentDimentionId= 3,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"},

                new ElementsDimentions(){RuleId = 1,DimensionId= 20,ParentDimentionId= 1,DimentionTypeColumn = "ContractTypeId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 1,DimensionId= 21,ParentDimentionId= 1,DimentionTypeColumn = "NationalityId",RuleFilterTypeId= 1,Value= "1"},
                new ElementsDimentions(){RuleId = 1,DimensionId= 22,ParentDimentionId= 1,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"},

                new ElementsDimentions(){RuleId = 1,DimensionId= 23,ParentDimentionId= 5,DimentionTypeColumn = "TradingLineId",RuleFilterTypeId= 1,Value= "1"}
            };

            return resulSetDimentions;
        }

        public List<ContractTransactionEntity> CreateTransactionList()
        {
            List<ContractTransactionEntity> resulSetDimentions = new List<ContractTransactionEntity>()
            {
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
				new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1},
                new ContractTransactionEntity() {
                    TransactionGuid = new Guid(),
                    SubAccountId = 1,
                    TradingLineId = 1,
                    TransactionTypeId = 1,
                    CustodyTypeId = 1,
                    CustodianPartyId = 1,
                    CompanyId = 1,
                    ContractTypeId = 1,
                    AccountTypeId = 1,
                    PersonTypeId = 1,
                    TaxableEntityTypeId = 1,
                    NationalityId = 1,
                    AdendumId = 1,
                    ClientTypeId = 1}
            };

            return resulSetDimentions;
        }


        [TestMethod]
        public void A_WhenHaveListDimentionsThenHaveRuleDimentionObject()
        {
            var listToEval = createDimentionList();
            // Act
            // Engine evaluator = new Engine();
			listDimentionEntity = evaluator.DecorateDimentionEntity(listToEval);

            // Acert
            Assert.AreEqual(listToEval.Count(w => w.ParentDimentionId == null), listDimentionEntity.Count());
        }

        [TestMethod]
        public void B_WhenEvaluateDimentionList()
        {
            var listDimensionToEval = createDimentionList();
			var listTransactionToEval = CreateTransactionList();
			// Act

			Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.ffffff", CultureInfo.InvariantCulture));
			listDimentionEntity = evaluator.DecorateDimentionEntity(listDimensionToEval);
            
			Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.ffffff", CultureInfo.InvariantCulture));
			listTransactionToEval.ForEach(F => listDimentionEntity.ForEach(f => f.EvaluateDimensions(F, f, (decimal)100/f.DimensionsCount)));
                    
			Console.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.ffffff", CultureInfo.InvariantCulture));
			// Acert
			Assert.AreEqual(listDimensionToEval.Count(w => w.ParentDimentionId == null), listDimentionEntity.Count());
        }
    }
}
