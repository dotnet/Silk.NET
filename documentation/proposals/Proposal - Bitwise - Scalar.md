# Summary
Bitwise operations in `Scalar[<T>]`

# Contributors
- Kai Jellinghaus, Silk.NET maintainer
- Dylan Perks, Ultz Limited

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [x] [Implemented](https://github.com/dotnet/Silk.NET/pull/667)

# Design Decisions


# Proposed API
To make this simpler for both me, and anyone who reads this, I've provided the API in the form it would appear in a PublicAPI.txt

This same API would also be amended to the Vectorization/SIMD proposal, if both are accepted.

```cs
static Silk.NET.Maths.Scalar.And<T>(T left, T right) -> T
static Silk.NET.Maths.Scalar.Or<T>(T left, T right) -> T
static Silk.NET.Maths.Scalar.Xor<T>(T left, T right) -> T
static Silk.NET.Maths.Scalar.Not<T>(T x) -> T
static Silk.NET.Maths.Scalar.ShiftLeft<T>(T x, int amount) -> T
static Silk.NET.Maths.Scalar.ShiftRight<T>(T x, int amount) -> T
static Silk.NET.Maths.Scalar.RotateLeft<T>(T x, int amount) -> T
static Silk.NET.Maths.Scalar.RotateRight<T>(T x, int amount) -> T
```
