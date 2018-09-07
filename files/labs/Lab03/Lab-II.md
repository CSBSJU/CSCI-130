---
title: "Introduction to Visual Basic II"
---

# Topics

* Get familiar with the VS Express 2013 environment
*	String and number variables
*	Assignment statements
*	Evaluating expressions
*	User input: strings and numbers
* Using `FormatCurrency` function
*	New material for students to learn via online resources: Using format
  strings in Visual Basic

# Video rental store

5. Use **File Explorer** to navigate to the folder containing your
   final version of your project `VideoRentalStore_Part3` in your lab folder.
   Copy and paste this project in the same folder, and then right-click on the
   copy to rename it as `VideoRentalStore_Part5`. Launch VS Express and use it
   to open the project `VideoRentalStore_Part5`.

   Now change your `VideoRentalStore_Part5` to use format strings in Visual
   Basic to produce an itemized receipt, containing the same information as the
   last part, but formatted EXACTLY like the following example.

   ```
   Customer name: Mary Smith
   Rental period: 5 days

   Regular videos (5 @ $2.50)    $1.85
   Premium videos (3 @ $5.25) 
   -----------------------------------
   Subtotal                      $5.45
   Tax                           $0.38
   Total                         $5.83
   ```

   Consider using a format string variable to space your output appropriately.
   Be sure to set the font of your output text box to `Courier New` in order for
   output to display properly. An example of how to declare and use a format
   string follows.

   ```vbnet
   ' The following format string variable displays two strings where the format
   ' for each is described by two comma-separated numbers enclosed between {x,y}
   ' where x describes which string is being formatted (0 is first string, 1 is
   ' second string, etc.) and y represents the number of characters allocated to
   ' the string (in the following example, we’re using 10 characters). Note that
   ' a negative value indicates align left
   Dim fmtStr As String = "{0,-10}{1,10}" & vbNewLine 

   ' In the first example, we’re displaying string “CSCI 130” in 10 characters
   ' left-justified and string "1:00pm" also in 10 characters but
   ' right-justified
   outResults.AppendText(String.Format(fmtStr, "CSCI 130", "1:00pm"))
   outResults.AppendText(String.Format(fmtStr, "CSCI 130L", "11:20am"))
   ```

   The above code will produce the following output:
   
   ```
   CSCI 130      1:00pm
   CSCI 130L    11:20am
   ```

   \BEGIN{Warning}
   When done, save and close project `VideoRentalStore_Part5`.
   \END{Warning}

   \BEGIN{Rubric}
   Part 5 (80/100): A successful `VideoRentalStore_Part5` program:

   * produces an itemized receipt formatted EXACTLY as shown in the previous
     example
   * must also have successfully completed Part 1 

   \END{Rubric}

   \newpage

1. Use **File Explorer** to navigate to the folder containing your
   final version of your project `VideoRentalStore_Part5` in your lab folder.
   Copy and paste this project in the same folder, and then right-click on the
   copy to rename it as `VideoRentalStore_Part6`. Launch VS Express and use it
   to open the project `VideoRentalStore_Part6`.

   Enhance your program to allow users to purchase the following additional items
   during checkout: *candy* @ $1.50, *popcorn* @ $5.00 a bag, and *soda* @ $2.25.

   \BEGIN{Warning}
   When done, save and close project `VideoRentalStore_Part6`.
   \END{Warning}

   \BEGIN{Rubric}
   Part 6 (85/100): A successful `VideoRentalStore_Part6` program:

   * allows user to input number of candy, popcorn and soda units purchased and
     produces an itemized receipt formatted EXACTLY as shown in the previous
     example
   * must also have successfully completed Part 1 

   \END{Rubric}

   \newpage

1. Use **File Explorer** to navigate to the folder containing your
   final version of your project `VideoRentalStore_Part6` in your lab folder.
   Copy and paste this project in the same folder, and then right-click on the
   copy to rename it as `VideoRentalStore_Part7`. Launch VS Express and use it
   to open the project `VideoRentalStore_Part7`.

   Enhance your program again so that the number of *sodas* purchased is not
   input via a textbox, but instead is controlled by the number of times that a
   button is pressed.

   ```vbnet
   "TODO: guide students to add to a running total each time that the "
   "soda button is pressed. And fix the following paragraph."
   ```

   Keep in mind that since the running total needs to be accessed by several
   subroutines on this form, that variable needs to be declared as a form-level
   (i.e. global) variable, available to all of the subroutines on this form. If
   you use the variable name, runningTotal, it should be declared near the top
   of the form just below the class statement and above any subroutines. Recall
   that form-level variables must be declared here to be available to all of the
   subroutines on this form. Subroutine (i.e. local) variables are declared
   within each subroutine. Only declare variables as form-level if they need to
   be accessed by more than one subroutine.

   \BEGIN{Warning}
   When done, save and close project `VideoRentalStore_Part8`.
   \END{Warning}

   \BEGIN{Rubric}
   Part 7 (90/100): A successful `VideoRentalStore_Part7` program:

   * allows user to press a soda button to indicate the sale of a soda item,
     instead of inputting the count of sodas via a text box
   * produces an itemized receipt formatted EXACTLY as shown in the previous
     example
   * must also have successfully completed Part 1 

   \END{Rubric}

   \newpage

1. Use **File Explorer** to navigate to the folder containing your
   final version of your project `VideoRentalStore_Part7` in your lab folder.
   Copy and paste this project in the same folder, and then right-click on the
   copy to rename it as `VideoRentalStore_Part8`. Launch VS Express and use it
   to open the project `VideoRentalStore_Part8`.

   Complete your program by changing it so that every item is sold by pressing a
   button instead of inputting a count into a text box. Effectively, you will
   create a digital cash register where the buttons serve to "ring up" a
   customer. Your program should include buttons that correspond to each of the
   items for sale.

   \BEGIN{Warning}
   When done, save and close project `VideoRentalStore_Part8`.
   \END{Warning}

   \BEGIN{Rubric}
   Part 8 (100/100): A successful `VideoRentalStore_Part8` program:

   * allows user to "ring up" a customer by pressing buttons indicating the
     the sale of an item
   * produces an itemized receipt formatted EXACTLY as shown in the previous
     example
   * must also have successfully completed Part 1 

   \END{Rubric}

## Submission Instructions
Your `M:\CS130\Labs\Lab03_YourLastName_YourFirstName` folder should contain your
solutions to this and Tuesday's lab.

To submit your work, copy this folder and paste it to `N:/Handins/CS130/Lab03`
PRIOR to the end of lab today. Late submissions won’t be accepted and will
receive a grade of 0 instead.
