#
# EchoValues.as
# This program will get two values, the width and length,
# of a rectangle, from the user and display each of them.
#
READ                      # Get the first number
STORE RECTANGLEWIDTH      # Save the first number as RECTANGLEWIDTH
READ                      # Get the second number
STORE RECTANGLELENGTH     # Save the second number as RECTANGLELENGTH
LOAD  RECTANGLEWIDTH      # Put value of RECTANGLEWIDTH in accumulator
WRITE                     # Display the product in the output window
LOAD  RECTANGLELENGTH     # Put value of RECTANGLELENGTH in accumulator
WRITE                     # Display the product in the output window
HALT                      # END of program

# Memory variable declarations
RECTANGLEWIDTH:     0  # the first term
RECTANGLELENGTH:    0  # the second term
