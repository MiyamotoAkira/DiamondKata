# The project
This is a solution to the [Diamond kata](https://github.com/davidwhitney/CodeDojos/tree/master/Diamond%20Kata)

# To execute

This code has been written in [dotnet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

The assembly name is `diamond.dll`. Once you build the solution (with `dotnet build` from the root of the solution), you can run the app using `dotnet [path-to-dll]/diamond.dll "C"`. The path will depend being debug or release.

# Tests

To run the tests you can use `dotnet test` from the root folder of the solution.

# Notes

There is no error handling if the user sends the wrong data. It is a simple app, so just a runtime exception is fine.

The design has been done stateless. The solution is quite simple, and there was no much point to try to extract an object(s) from it (though there is a line concept that could easily be extracted).

For the same reason the methods being all public do not affect in any way the system, as there is no state.
