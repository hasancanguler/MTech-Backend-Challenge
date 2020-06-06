# MTech Backend Challenge
M.. Technology application questions and answers

## Original Question 

Please answer two questions listed below. We want you to present your answers preferably with clean Javascript, but any other language is welcome. Presented code should be well documented and testable. 


**Q1.**

Write a function that takes a list of money transfer transactions performed among a group of banks and returns the result that indicates which bank owes how much to other banks. Please check the expected output section below.

**Notes:**

If the balance between two banks is zero, it should not be included in the result. The amounts in the output needs to be positive.
Please notice that a bank can send money to another bank in multiple lines of transactions. 
A receiver bank can be a sender bank in another transaction record.

**_Sample input:_**

[
  {
    "sender": "BankA",
    "receiver": "BankB",
    "amount": "100"
  },
  {
    "sender": "BankB",
    "receiver": "BankC",
    "amount": "20"
  },
  {
    "sender": "BankB",
    "receiver": "BankC",
    "amount": "120"
  },
  {
    "sender": "BankA",
    "receiver": "BankB",
    "amount": "150"
  },
  {
    "sender": "BankC",
    "receiver": "BankB",
    "amount": "200"
  },
  {
    "sender": "BankC",
    "receiver": "BankA",
    "amount": "100"
  }
]


**_Expected output:_**

BankB owes BankA  250 

BankB owes BankC 60 

BankA owes BankC 100


**Q2.** 

Write a function that reverses an array of integers in place. Don't allocate extra space for another array. 
Don't use any language specific library like reverse() method. 

**_Sample input_**

[1,4,6,9]

**_Expected output:_**

[9,6,4,1]

## Solution :

This solution includes three main project.

- BankAPI
    This project which is written with WebAPI ensures that data is received and transfers to data to the main function.
    
    Please [click](https://github.com/hasancanguler/MTech-Backend-Challenge/tree/master/BackendChallenge/BankAPI/readme.md) for details.
    
- MTechBuss
    This project hosts the helper functions as a small library.
    
    Please [click](https://github.com/hasancanguler/MTech-Backend-Challenge/tree/master/BackendChallenge/MTechBuss/readme.md) for details. .
    
 - MTechTest
    This project makes basic unit test.
