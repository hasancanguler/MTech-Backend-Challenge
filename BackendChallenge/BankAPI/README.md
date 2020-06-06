## Bank API ##

This project which is written with WebAPI ensures that data is received and transfers to data to the main function.

It can be called this URL http://localhost:xx/api/MoneyTransfer with POST method for using metod.

Main transaction metod name is Start and it takes MoneyTransaction parameter and it returns as a Debtor Model in list type.

**MoneyTransaction Model :**

```C#
public class MoneyTransaction
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public double Amount { get; set; }
    }
```

**Debtor Model :**

```C#
public class Debtor
    {
        public string Owes { get; set; }
        public string Payee { get; set; }
        public double Total { get; set; }
    }
```
