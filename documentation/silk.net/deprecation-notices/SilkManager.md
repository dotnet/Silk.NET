# SilkManager
## Information
- Introduced in Preview 2
- Active in 1.1.1
- Deprecated in 1.2
- Removed in 2.0

## Summary
SilkManager was our solution to accessing classes and interfaces that needed to be shared across packages without introducing a
direct (often circular) dependency.

## Why are we removing it?
In Silk.NET 2.0, we intend to couple all of the default windowing implementations into one package to eliminate the storage
overhead of having a bridge DLL with just one class in it (Silk.NET.Windowing and Silk.NET.Input). This is because .NET 5
makes cross-platform a lot easier. The new package structure will look like this:

- Silk.NET.Windowing
    - Silk.NET.Windowing.Desktop merged into this package
    - depends on Silk.NET.Windowing.Common
- Silk.NET.Input
    - Silk.NET.Input.Desktop merged into this package
    - depends on Silk.NET.Input.Common
        - depends on Silk.NET.Windowing.Common (subject to change)
