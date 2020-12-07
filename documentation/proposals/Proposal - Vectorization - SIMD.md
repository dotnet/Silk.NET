# Summary
High Performance, Generic, Maths.
This both exposes more High Performance SIMD API for those that want it, and lays the foundation for using this in our own codebase.

# Contributors
- Kai Jellinghaus, Silk.NET Contributor / Maintainer (2020)
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- It's to be discussed whether one unified type for Vector64, Vector128, and Vector256 should be used, but I felt it was easier to read in code this way.
- This is simply a mirror of Scalar\[\<T\>\] with some exceptions:
    - Rounding to a given amount of digits, this could be added, but it's never going to be high performance.
    - Rounding with a given mode is allowed. This is generally backed by intrinsics, but we make no guarantees about perf here.
    - For bool APIs, I felt it was better to return `Vector128<T>` with all elements set to be either all 1s (for `true`) or all 0s (for `false`) this is better for branchless code, which is generally desirable when working with SIMD.
    - We should consider exposing a helper to check all elements / each element to be all 1s (true) or not (false)
    - another proposal will enhance `Scalar[T]` with bitwise operations, and, if this proposal is accepted, will enhance this proposal too.
    - there will be more helpers required, but they are not part of this initial plan (ie Store, Load) and it can be discussed whether they are ammended, or kept internal as required.

# Proposed API
To make this simpler for both me, and any poor soul that reads through all this, I've provided the API in the form it would appear in a PublicAPI.txt

```cs
Silk.NET.Maths.Vector128
Silk.NET.Maths.Vector128<T>

static readonly Silk.NET.Maths.Vector128<T>.E -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.Epsilon -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.MaxValue -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.MinusOne -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.MinusTwo -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.MinValue -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.NaN -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.NegativeInfinity -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.One -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.Pi -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.PiOver2 -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.PositiveInfinity -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.Tau -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.Two -> Vector128<T>
static readonly Silk.NET.Maths.Vector128<T>.Zero -> Vector128<T>

static Silk.NET.Maths.Vector128.Abs<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Acos<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Acosh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Add<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.As<TFrom, Vector128<T>To>(TFrom val) -> Vector128<T>To
static Silk.NET.Maths.Vector128.Asin<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Asinh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Atan2<T>(Vector128<T> y, T x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Atan<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Atanh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Cbrt<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Ceiling<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Cos<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Cosh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Divide<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.Equal<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.Exp<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Floor<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.GreaterThan<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.GreaterThanOrEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.IEEERemainder<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsFinite<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsHardwareAccelerated.get -Vector128<T> bool
static Silk.NET.Maths.Vector128.IsInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsNaN<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsNegative<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsNegativeInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsNormal<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsPositiveInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.IsSubnormal<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Vector128.LessThan<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.LessThanOrEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.Log10<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Log<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Log<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.Vector128.Max<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.Vector128.Min<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.Vector128.Multiply<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.Negate<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.NotEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.Pow<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.Vector128.Reciprocal<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Round<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Round<T>(Vector128<T> x, System.MidpointRounding mode) -> Vector128<T>
static Silk.NET.Maths.Vector128.Sign<T>(Vector128<T> x) -> Vector128<int>
static Silk.NET.Maths.Vector128.Sin<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Sinh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Sqrt<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Subtract<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Vector128.Tan<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Tanh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Vector128.Truncate<T>(Vector128<T> x) -> Vector128<T>

```
