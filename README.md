# F# Immutability Demonstration

This repository showcases an example of how F#'s immutability can lead to unexpected behavior if not fully understood. The `bug.fs` file contains code that demonstrates the issue; the solution is provided in `bugSolution.fs`.

**Problem:** In F#, function arguments are treated as immutable by default.  Modifying the original variable after a function call does not change the values used within the function's scope.  This is in contrast to mutable languages where the function would directly work on the variable's current state.

**Solution:**  The solution file illustrates that to update `y` based on updated `x` value, a function needs to be called again with the updated value, making the code more explicit and avoids the surprise that can occur with implicit immutability.

This example is useful for understanding how to work effectively with immutability in F# and demonstrating how this feature differs from languages where variables are mutable.