using MTechBuss.BankAPI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTechTest.BankAPI
{

    public class MTController
    {
        MoneyTransferTest mTTest = new MoneyTransferTest();
        DebtorTest debtorTest = new DebtorTest();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Make()
        {
            MoneyTransfer moneyTransfer = new MoneyTransfer();
            List<Debtor> result = moneyTransfer.Make(mTTest.GetSample1List());
            List<Debtor> control = debtorTest.GetResult1List();

            CollectionAssert.AreEqual(control, result);
        }
    }
}
