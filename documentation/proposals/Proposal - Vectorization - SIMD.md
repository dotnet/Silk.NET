# Summary
High Performance, Generic, Maths.
This both exposes more High Performance SIMD API for those that want it, and lays the foundation for using this in our own codebase.

# Contributors
- Kai Jellinghaus, Silk.NET maintainer
- Dylan Perks, Ultz Limited

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
    - SIMD may be renamed to SIMD128 later.

# Proposed API
To make this simpler for both me, and any poor soul that reads through all this, I've provided the API in the form it would appear in a PublicAPI.txt

```cs
Silk.NET.Maths.SIMD
Silk.NET.Maths.SIMD<T>

static readonly Silk.NET.Maths.SIMD<T>.E -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.Epsilon -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.MaxValue -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.MinusOne -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.MinusTwo -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.MinValue -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.NaN -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.NegativeInfinity -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.One -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.Pi -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.PiOver2 -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.PositiveInfinity -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.Tau -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.Two -> Vector128<T>
static readonly Silk.NET.Maths.SIMD<T>.Zero -> Vector128<T>

static Silk.NET.Maths.SIMD.Abs<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Acos<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Acosh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Add<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.As<TFrom, Vector128<T>To>(TFrom val) -> Vector128<T>To
static Silk.NET.Maths.SIMD.Asin<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Asinh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Atan2<T>(Vector128<T> y, T x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Atan<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Atanh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Cbrt<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Ceiling<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Cos<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Cosh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Divide<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.Equal<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.Exp<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Floor<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.GreaterThan<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.GreaterThanOrEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.IEEERemainder<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsFinite<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsHardwareAccelerated.get -Vector128<T> bool
static Silk.NET.Maths.SIMD.IsInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsNaN<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsNegative<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsNegativeInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsNormal<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsPositiveInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.IsSubnormal<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.SIMD.LessThan<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.LessThanOrEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.Log10<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Log<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Log<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.SIMD.Max<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.SIMD.Min<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.SIMD.Multiply<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.Negate<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.NotEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.Pow<T>(Vector128<T> x, T y) -> Vector128<T>
static Silk.NET.Maths.SIMD.Reciprocal<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Round<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Round<T>(Vector128<T> x, System.MidpointRounding mode) -> Vector128<T>
static Silk.NET.Maths.SIMD.Sign<T>(Vector128<T> x) -> Vector128<int>
static Silk.NET.Maths.SIMD.Sin<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Sinh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Sqrt<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Subtract<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.SIMD.Tan<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Tanh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.SIMD.Truncate<T>(Vector128<T> x) -> Vector128<T>

```
