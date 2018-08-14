#
# CalculateAreaWithBoundsChecking.as
# This program will calculate and display the area
# of a rectangular shape where the width and length are
# obtained from the user. The program will check to make
# sure the meaningful values are input.
#
        READ                    # Get the first number
        STORE  RECTANGLEWIDTH   # Save the first number as "RECTANGLEWIDTH"
        READ                    # Get the second number
        STORE  RECTANGLELENGTH  # Save the second number as "RECTANLGELENGTH"

IF1:    LOAD  RECTANGLEWIDTH    # Put value of RECTANGLEWIDTH in accumulator
        SUB   ZERO              # Subtract zero from RECTANGLEWIDTH
        JPOS  IF2               # Jump to IF2 if RECTANGLEWIDTH is > 0
        JUMP  ENDIF             # Jump to ENDIF if RECTANGLEWIDTH is <= 0

IF2:    LOAD  RECTANGLELENGTH   # Put value of RECTANGLELENGTH in accumulator
        SUB   ZERO              # Subtract zero from RECTANGLELENGTH
        JPOS  LOOP              # Jump to LOOP if RECTANGLELENGTH is > 0
        JUMP  ENDIF             # Jump to ENDIF if RECTANGLELENGTH is <= 0

LOOP:   LOAD  RECTANGLEAREA     # Put value of RECTANLGEAREA in accumulator
        ADD   RECTANGLEWIDTH    # Add RECTANLGLEWIDTH to the RECTANGLEAREA
        STORE RECTANGLEAREA     # Save new value of RECTANGLEAREA
        LOAD  RECTANGLELENGTH   # Put value of RECTANGLELENGTH in accumulator
        SUB   ONE               # Subtract one from RECTANGLELENGTH
        STORE RECTANGLELENGTH   # RECTANGLELENGTH is acting as the counter to
                                # keep track of the number of times to add
                                # RECTANGLEWIDTH to RECTANGLEAREA
        JPOS  LOOP              # Jump to LOOP if RECTANGLELENGTH is positive,
                                # and add RECTANGLEWIDTH to RECTANGLEAREA again

ENDIF:  LOAD  RECTANGLEAREA     # Put the value of RECTANGLEAREA in accumulator
        WRITE                   # Display the product in the output window
        HALT                    # END of program

# Memory variable declarations
RECTANGLEWIDTH:   0 # the multiplicand (number multiplied)
RECTANGLELENGTH:  0 # the multiplier (number of times to add)
RECTANGLEAREA:    0 # the value is initially zero
ONE:              1 # the constant value one
ZERO:             0 # the constant value zero
