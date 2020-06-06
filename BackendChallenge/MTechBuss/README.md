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


**ArrayServices Process**

Array service is created for question 2. Reverse method is in order class.

In the loop, not only changing uses the first item but also changing uses the last item. Therefore, the limit which is half of the array length adjust loop length.

  ```C#
  double limit = ((double)array.Length / 2) ;
  ```
Beginning of the array item is added end of the array.

  ```C#
  reverseArr[index] = array[array.Length -1  - index];
  ```
Meanwhile, end of the array item is added Beginning of the array.
  ```C#
  reverseArr[array.Length - 1 - index] = array[index];
  ```

For example;

| | Item0 | Item1 | Item2 | Item3 |
| --- | --- | --- |--- |--- |
|Original | 1 | 4 | 6 | 9 |
|Loop1	  | 9	| 4 | 6 | 1 |
|Loop2	  | 9	| 6 | 4 | 1 |
