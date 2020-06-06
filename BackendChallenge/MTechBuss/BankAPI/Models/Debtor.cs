using System;
using System.Collections.Generic;
using System.Text;

namespace MTechBuss.BankAPI
{
    public class Debtor
    {
        public string Owes { get; set; }
        public string Payee { get; set; }
        public double Total { get; set; }

        public override string ToString()
        {
            return Owes + " owes " + Payee + " " + Total;
        }

        public override bool Equals(object debtor)
        {
            var other = debtor as Debtor;

            if (other == null)
                return false;

            if (Owes != other.Owes || Payee != other.Payee || Total != other.Total)
                return false;

            return true;
        }
    }

    
}
