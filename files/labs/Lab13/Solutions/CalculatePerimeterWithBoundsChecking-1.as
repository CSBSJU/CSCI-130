#
# CalculatePerimeterWithBoundsChecking.as
# This program will calculate and display the perimeter
# of a rectangular shape where the width and length are
# obtained from the user. The program will check to make
# sure the meaningful values are input.
#
        READ                      # Get the first number
        STORE RECTANGLEWIDTH      # Save the first number as RECTANGLEWIDTH
        READ                      # Get the second number
        STORE RECTANGLELENGTH     # Save the second number as RECTANGLELENGTH

IF:     LOAD  RECTANGLEWIDTH      # Put value of RECTANGLEWIDTH in accumulator
        JPOS  THEN                # Jump to THEN if RECTANGLEWIDTH is > 0

ENDIF:  HALT                      # END of program

THEN:   LOAD  RECTANGLEWIDTH      # Put value of RECTANGLEWIDTH in accumulator
        ADD   RECTANGLEWIDTH      # Add RECTANGLEWIDTH to RECTANGLEWIDTH
        ADD   RECTANGLELENGTH     # Add RECTANGLELENGTH to 2 * RECTANGLEWIDTH
        ADD   RECTANGLELENGTH     # Add RECTANGLELENGTH to 2 * RECTANGLEWIDTH + RECTANGLELENGTH
        STORE RECTANGLEPERIMETER  # Save value of RECTANGLEPERIMETER
        LOAD  RECTANGLEPERIMETER  # Put value of RECTANGLEPERIMETER in accumulator
        WRITE                     # Display the product in the output window
        JUMP ENDIF

# Memory variable declarations
RECTANGLEWIDTH:     0  # the first term
RECTANGLELENGTH:    0  # the second term
RECTANGLEPERIMETER: 0  # the value is initially zero
