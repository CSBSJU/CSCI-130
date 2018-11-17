#
# CalculatePerimeterWithBoundsCheckingLoop.as
# This program will calculate and display the perimeter
# of a rectangular shape where the width and length are
# obtained from the user. The program will check to make
# sure the meaningful values are input.
#
LOOP:     LOAD  COMPUTEANOTHERPERIMETER # Put value of COMPUTEANOTHERPERIMETER in accumulator
          SUB   ONE                     # Subtract 1 from COMPUTERANOTHERPERIMETER
          JZER  BODY                    # Jump to BODY if COMPUTERANOTHERPERIMETER = 1

ENDLOOP:  HALT                          # END of program

BODY:     READ                          # Get the first number
          STORE RECTANGLEWIDTH          # Save the first number as RECTANGLEWIDTH
          READ                          # Get the second number
          STORE RECTANGLELENGTH         # Save the second number as RECTANGLELENGTH

IF1:      LOAD  RECTANGLEWIDTH          # Put value of RECTANGLEWIDTH in accumulator
          JPOS  IF2                     # Jump to IF2 if RECTANGLEWIDTH is > 0

ENDIF1:   READ                          # Get the sentinel value
          STORE COMPUTEANOTHERPERIMETER # Save the second number as RECTANGLELENGTH
          JUMP  LOOP

IF2:      LOAD  RECTANGLELENGTH         # Put value of RECTANGLELENGTH in accumulator
          JPOS  THEN2                   # Jump to THEN2 if RECTANGLELENGTH is > 0

ENDIF2:   JUMP  ENDIF1

THEN2:    LOAD  RECTANGLEWIDTH          # Put value of RECTANGLEWIDTH in accumulator
          ADD   RECTANGLEWIDTH          # Add RECTANGLEWIDTH to RECTANGLEWIDTH
          ADD   RECTANGLELENGTH         # Add RECTANGLELENGTH to 2 * RECTANGLEWIDTH
          ADD   RECTANGLELENGTH         # Add RECTANGLELENGTH to 2 * RECTANGLEWIDTH + RECTANGLELENGTH
          STORE RECTANGLEPERIMETER      # Save value of RECTANGLEPERIMETER
          WRITE                         # Display the product in the output window
          JUMP  ENDIF2

# Memory variable declarations
RECTANGLEWIDTH:          0  # the first term
RECTANGLELENGTH:         0  # the second term
RECTANGLEPERIMETER:      0  # the value is initially zero
COMPUTEANOTHERPERIMETER: 1  # the sentinel variable

# Constant declarations
ONE: 1
