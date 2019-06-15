# Overloaders

Overloaders provide alternate method signatures for the user's convenience. In this namespace, the Overloader class runs
each function signature through each of the overloaders, and returns them to the ProfileWriter.

The profile writer will then write the code blocks to the mixed-mode/abstract class. Note that the overloading step in
the profile writer currently has not been implemented, this will be done once all of the overloaders from the 3.0 binder
have been reimplemented.

Here's a link to the 3.0 overloaders: https://github.com/opentk/opentk/tree/master/src/Generator.Bind/Overloaders