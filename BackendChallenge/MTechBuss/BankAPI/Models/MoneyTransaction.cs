using System;
using System.Collections.Generic;
using System.Text;

namespace MTechBuss.BankAPI
{
    public class MoneyTransaction
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public double Amount { get; set; }
    }
}
