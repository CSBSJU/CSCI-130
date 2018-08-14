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

IF1:    LOAD  ONE                 # Put value of ONE in accumulator
        SUB   RECTANGLEWIDTH      # Subtract RECTANGLEWIDTH from ONE
        JPOS  ENDIF               # Jump to ENDIF if ONE - RECTANGLEWIDTH > 0,
                                  # which is true iff RECTANGLEWIDTH <= 0

IF2:    LOAD  ONE                 # Put value of ONE in accumulator
        SUB   RECTANGLELENGTH     # Subtract RECTANGLELENGTH from ONE
        JPOS  ENDIF               # Jump to ENDIF if ONE - RECTANGLELENGTH > 0,
                                  # which is true iff RECTANGLELENGTH <= 0

THEN:   LOAD  RECTANGLEWIDTH      # Put value of RECTANGLEWIDTH in accumulator
        ADD   RECTANGLEWIDTH      # Add RECTANGLEWIDTH to RECTANGLEWIDTH
        ADD   RECTANGLELENGTH     # Add RECTANGLELENGTH to 2 * RECTANGLEWIDTH
        ADD   RECTANGLELENGTH     # Add RECTANGLELENGTH to 2 * RECTANGLEWIDTH +
                                  # RECTANGLELENGTH
        STORE RECTANGLEPERIMETER  # Save value of RECTANGLEPERIMETER

ENDIF:  LOAD  RECTANGLEPERIMETER  # Put value of RECTANGLEPERIMETER in
                                  # accumulator
        WRITE                     # Display the product in the output window
        HALT                      # END of program

# Memory variable declarations
RECTANGLEWIDTH:     0  # the first term
RECTANGLELENGTH:    0  # the second term
RECTANGLEPERIMETER: 0  # the value is initially zero
ONE:                1  # the constant value one
