using MTechBuss.BankAPI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTechTest.BankAPI
{
    public class DTBuss
    {
        DebtorTest debtorTest = new DebtorTest();
        DebtorBuss debtorBuss = new DebtorBuss();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Reverse()
        {
            Debtor debtorResult = debtorBuss.Reverse(debtorTest.ReverseControl1());

            Assert.AreEqual(debtorResult, debtorTest.ReverseResult1());
        }

        [Test]
        public void Search()
        {
            Debtor debtorControl = debtorTest.GetSearch1Control();
            Debtor debtorResult = debtorBuss.Search(debtorTest.GetSearch1List(), debtorControl.Owes, debtorControl.Payee);

            Assert.AreEqual(debtorResult, debtorControl);
        }
    }
}
