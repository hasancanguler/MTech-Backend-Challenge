using System;
using System.Collections.Generic;
using System.Text;

namespace MTechBuss.BankAPI
{
    public class MoneyTransfer
    {
        DebtorBuss debtorBuss = new DebtorBuss();
        public List<Debtor> Make(List<MoneyTransaction> transaction)
        {
            List<Debtor> debtors = new List<Debtor>();
            Debtor debtor;
            bool isFirst;            

            foreach (var tItem in transaction)
            {
                debtor = new Debtor();
                isFirst = true;

                debtor = debtorBuss.Search(debtors, tItem.Receiver, tItem.Sender);
                if (debtor != null)
                {
                    debtor.Total += tItem.Amount;
                    isFirst = false;
                }

                debtor = debtorBuss.Search(debtors, tItem.Sender, tItem.Receiver);
                if (debtor != null)
                {
                    debtor.Total -= tItem.Amount;
                    if (debtor.Total < 0)
                        debtor = debtorBuss.Reverse(debtor);
                    isFirst = false;
                }

                if (isFirst)
                {
                    debtors.Add(new Debtor
                    {
                        Owes = tItem.Receiver,
                        Payee = tItem.Sender,
                        Total = tItem.Amount
                    });
                }
                debtors.RemoveAll(w => w.Total == 0);
            }
            return debtors;
        }
    }
}
