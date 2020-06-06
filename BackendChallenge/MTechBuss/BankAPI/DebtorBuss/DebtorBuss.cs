using System;
using System.Collections.Generic;
using System.Text;

namespace MTechBuss.BankAPI
{
    public class DebtorBuss
    {
        public Debtor Search(List<Debtor> debtors, string Owes, string Payee)
        {
            return debtors.Find(w => w.Owes.Equals(Owes) && w.Payee.Equals(Payee));
        }
        
        public Debtor Reverse(Debtor debtor)
        {
            string owes = debtor.Owes;
            debtor.Owes = debtor.Payee;
            debtor.Payee = owes;
            debtor.Total *= -1;
            return debtor;
        }
    }
}
