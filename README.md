# Unexpected Behavior with Mutable Variables in F#

This example demonstrates a potential issue in F# when using mutable variables.  The code initially calculates the sum of 'x' and 'y', but then modifies these variables before printing a second result.  This may lead to confusion because the second result is not based on the initial values used in 'add'.

## Solution
The improved solution showcases how to handle such cases more effectively by either using immutable values or explicitly stating when and how mutability is used.

## How to run the code
1.  Save the files as `bug.fs` and `bugSolution.fs`.
2.  Open a F# Interactive session.
3.  Compile and execute each code snippet to observe their output.