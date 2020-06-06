using MTechBuss.BankAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTechTest
{

    public class MoneyTransferTest
    {
        List<MoneyTransaction> transaction = new List<MoneyTransaction>();
        public MoneyTransferTest()
        {
            
        }

        public List<MoneyTransaction> GetSample1List()
        {
            transaction.Add(new MoneyTransaction { Sender = "BankA", Receiver = "BankB", Amount = 100 });
            transaction.Add(new MoneyTransaction { Sender = "BankB", Receiver = "BankC", Amount = 20 });
            transaction.Add(new MoneyTransaction { Sender = "BankB", Receiver = "BankC", Amount = 120 });
            transaction.Add(new MoneyTransaction { Sender = "BankA", Receiver = "BankB", Amount = 150 });
            transaction.Add(new MoneyTransaction { Sender = "BankC", Receiver = "BankB", Amount = 200 });
            transaction.Add(new MoneyTransaction { Sender = "BankC", Receiver = "BankA", Amount = 100 });

            return transaction;
        }
    }
}
