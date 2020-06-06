using MTechBuss.BankAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTechTest
{
    public class DebtorTest
    {
        List<Debtor> debtors = new List<Debtor>();

        public List<Debtor> GetResult1List()
        {
            debtors.Add(new Debtor { Owes = "BankB", Payee = "BankA", Total = 250 });
            debtors.Add(new Debtor { Owes = "BankB", Payee = "BankC", Total = 60 });
            debtors.Add(new Debtor { Owes = "BankA", Payee = "BankC", Total = 100 });

            return debtors;
        }

        public Debtor ReverseControl1()
        {
            Debtor debtor = new Debtor
            {
                Owes = "BankB",
                Payee = "BankA",
                Total = -250
            };
            return debtor;
        }

        public Debtor ReverseResult1()
        {
            Debtor debtor = new Debtor
            {
                Owes = "BankA",
                Payee = "BankB",
                Total = 250
            };
            return debtor;
        }

        public List<Debtor> GetSearch1List()
        {
            debtors.Add(new Debtor { Owes = "BankB", Payee = "BankA", Total = 250 });
            debtors.Add(new Debtor { Owes = "BankB", Payee = "BankC", Total = 60 });
            debtors.Add(new Debtor { Owes = "BankA", Payee = "BankC", Total = 100 });

            return debtors;
        }

        public Debtor GetSearch1Control()
        {
            Debtor debtor = new Debtor
            {
                Owes = "BankB",
                Payee = "BankC",
                Total = 60
            };
            return debtor;
        }
    }
}
