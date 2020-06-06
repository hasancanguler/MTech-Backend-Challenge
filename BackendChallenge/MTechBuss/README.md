## MTechBuss ##

This project hosts the helper functions as a small library.

BankAPI which is created for Question1 serves to WebAPI. It keeps models which is necessary, makes money transfer and DebtorBuss keeps main funcktions releated to Debtor model.

**Money Transfer Process**

This process stars with MoneyTransaction models. 

1- It turns step by step in the loop 

2- First control is that is this row has been added debtor list as a Owes

  ```C#
  debtor = debtorBuss.Search(debtors, tItem.Receiver, tItem.Sender);
  ```

2.1 - If it has this row, add amount to total 

  ```C#
  debtor.Total += tItem.Amount;
  ```
  
3- First control is that is this row has been added debtor list as a Payee 
  ```C#
  debtor = debtorBuss.Search(debtors, tItem.Sender, tItem.Receiver);
  ```

3.1- If it has this row, remove amount to total

  ```C#
  debtor.Total -= tItem.Amount;
  ```
  
3.2- If new total is negative, change Owe and Payee

  ```C#
  debtor = debtorBuss.Reverse(debtor);
  ```
 
4- If this row never add debtor list, add to the debtor as a new row

  ```C#
  debtors.Add(new Debtor
  {
      Owes = tItem.Receiver,
      Payee = tItem.Sender,
      Total = tItem.Amount
  });
  ```
  
5- Clear rows if it is zero

  ```C#
  debtors.RemoveAll(w => w.Total == 0);
  ```
 
6- Finally, return Debtor List Model
