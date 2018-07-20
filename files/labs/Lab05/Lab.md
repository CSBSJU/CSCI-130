---
title: "Lab05"
geometry: margin=1in
---

**IMPORTANT:** While writing programs involving loops, sometimes you may
accidentally write code that contains an *infinite loop*. An infinite loop will
cause your display to freeze up or output continually to a text box, depending
on what your loop contains. If this happens you can break out of the infinite
loop and stop the run of the program by clicking the Stop icon (a red square to
the right of the Play icon).

## Part 1

Consider your fair coin flip python program from before.

a. Modify it so it flips a FAIR coin 100 times each time reporting the number
   generated and whether it was "Head" or "Tail".
a. Change your python program to report the number of generated "Head" and
   "Tail". Does it look like a fair coin?

* * *
D level --- simple for loops that repeat a predefined number of times. Simple
counting.

* * *

## Part 2

Create a Raptor program that computes the total amount of interest earned on a
savings account after a user specified number of years. Assuming that the
interest is [compounded](https://en.wikipedia.org/wiki/Compound_interest)
annually, then the interest earned for a single year can be expressed as:

[1] *P &times; R*,

where *P* is the principal amount, the amount in the savings account at the
beginning of the year (note: this will change each year as interest is
compounded), and *R* is the [nominal interest
rate](https://en.wikipedia.org/wiki/Nominal_interest_rate).

  a. When done, convert your program to VB. Present the total amount of earned
     interest to the user using a MsgBox and in a sentence of the following
     form:

     ```
     After 10 years of compounding, your savings account with an initial balance
     of $500.00 and APR of 3%, will have earned a total of $XXX.XX in interest.
     ```

     In this example, `10 years`, `$500.00` and `3%` should be replaced with
     whatever values were input by the user.

* * *
C level --- loops that repeat a user-defined (fixed) number of times.

* * *

Create a Raptor program that computes the numbers of years of compounding
interest required to reach a target principal, given a starting principal and a
nominal interest rate. Also output a table with the following information for
each year.

**The following is an example of how this problem will be formated.**

Write a program that will compute and print out the information about the
earnings on a savings account in table form, including the year, interest for
that year, and the balance at the end of each year and the total interest earned
during those years, where the initial balance, `initialDeposit`, the annual
interest rate, `interestRate`, and the number of years earning interest,
`numberOfYears`, is obtained from the user via use of InputBox functions. Your
output should look *exactly* like the table below. Assume the interest is
compounded annually and that no withdrawals are made from this account. Include
a button to cause the table to be created and displayed and also a quit button.
For example, if `initialDeposit` was $500, `numberOfYears` was 10, and
`interestRate` was 0.03, the following table would be printed.

**NOTE:** Remember to set the output text field’s font to `Courier New` for your
results to display correctly when using a format string.

![](pic1.png)

* * *
B level --- loops that repeat a data dependent (variable) number of times
(Raptor only).

* * *

* * *
A level --- loops that repeat a data dependent (variable) number of times (VB).

* * *

* Maybe A level could also incorporate user input compounding periods.
* For grades C and B, students should be asked to fill in tables to check their
  work.
