# Summary
High Performance, Generic, Maths.
This both exposes more High Performance Simd128 API for those that want it, and lays the foundation for using this in our own codebase.

# Contributors
- Kai Jellinghaus, Silk.NET maintainer
- Dylan Perks, Ultz Limited

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

# Design Decisions
- It's to be discussed whether one unified type for Vector64, Vector128, and Vector256 should be used, but I felt it was easier to read in code this way.
- This is simply a mirror of Scalar\[\<T\>\] with some exceptions:
    - Rounding to a given amount of digits, this could be added, but it's never going to be high performance.
    - Rounding with a given mode is allowed. This is generally backed by intrinsics, but we make no guarantees about perf here.
- For bool APIs, I felt it was better to return `Vector128<T>` with all elements set to be either all 1s (for `true`) or all 0s (for `false`) this is better for branchless code, which is generally desirable when working with Simd. (IsHardwareAccelerated is of course exempt from this)
- We should consider exposing a helper to check all elements / each element to be all 1s (true) or not (false)
- another proposal will enhance `Scalar[T]` with bitwise operations, and, if this proposal is accepted, will enhance this proposal too.
- there will be more helpers required, but they are not part of this initial plan (ie Store, Load) and it can be discussed whether they are ammended, or kept internal as required.

# Proposed API
To make this simpler for both me, and any poor soul that reads through all this, I've provided the API in the form it would appear in a PublicAPI.txt

```cs
Silk.NET.Maths.Scalar<T>.IsSupported.get -> bool
Silk.NET.Maths.Simd128<T>.IsSupported.get -> bool
Silk.NET.Maths.Simd64<T>.IsSupported.get -> bool
Silk.NET.Maths.Simd256<T>.IsSupported.get -> bool

Silk.NET.Maths.Simd128
Silk.NET.Maths.Simd128<T>

static readonly Silk.NET.Maths.Simd128<T>.E -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.Epsilon -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.MaxValue -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.MinusOne -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.MinusTwo -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.MinValue -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.NaN -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.NegativeInfinity -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.One -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.Pi -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.PiOver2 -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.PositiveInfinity -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.Tau -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.Two -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.Zero -> Vector128<T>
static readonly Silk.NET.Maths.Simd128<T>.AllBitsSet -> Vector128<T>

static Silk.NET.Maths.Simd128.Load<T>(T* ptr) -> Vector128<T>
static Silk.NET.Maths.Simd128.Store<T>(Vector128<T> source, T* destination)
static Silk.NET.Maths.Simd128.Create<T>(T value) -> Vector128<T>
static Silk.NET.Maths.Simd128.AllBitsSet(Vector128<T> vector) -> bool

static Silk.NET.Maths.Simd128.Abs<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Acos<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Acosh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Add<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.As<TFrom, Vector128<T>To>(TFrom val) -> Vector128<T>To
static Silk.NET.Maths.Simd128.Asin<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Asinh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Atan2<T>(Vector128<T> y, Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Atan<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Atanh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Cbrt<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Ceiling<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Cos<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Cosh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Divide<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Equal<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Exp<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Floor<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.GreaterThan<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.GreaterThanOrEqual<T>(Vector128<T> left, T right) -> Vector128<T>
static Silk.NET.Maths.Simd128.IEEERemainder<T>(Vector128<T> x, Vector128<T> y) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsFinite<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsHardwareAccelerated.get -> bool
static Silk.NET.Maths.Simd128.IsInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsNaN<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsNegative<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsNegativeInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsNormal<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsPositiveInfinity<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.IsSubnormal<T>(Vector128<T> f) -> Vector128<T>
static Silk.NET.Maths.Simd128.LessThan<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.LessThanOrEqual<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Log10<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Log<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Log<T>(Vector128<T> x, Vector128<T> y) -> Vector128<T>
static Silk.NET.Maths.Simd128.Max<T>(Vector128<T> x, Vector128<T> y) -> Vector128<T>
static Silk.NET.Maths.Simd128.Min<T>(Vector128<T> x, Vector128<T> y) -> Vector128<T>
static Silk.NET.Maths.Simd128.Multiply<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Negate<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.NotEqual<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Pow<T>(Vector128<T> x, Vector128<T> y) -> Vector128<T>
static Silk.NET.Maths.Simd128.Reciprocal<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Round<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Round<T>(Vector128<T> x, System.MidpointRounding mode) -> Vector128<T>
static Silk.NET.Maths.Simd128.Sign<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Sin<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Sinh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Sqrt<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Subtract<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Tan<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Tanh<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.Truncate<T>(Vector128<T> x) -> Vector128<T>

static Silk.NET.Maths.Simd128.And<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Or<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Xor<T>(Vector128<T> left, Vector128<T> right) -> Vector128<T>
static Silk.NET.Maths.Simd128.Not<T>(Vector128<T> x) -> Vector128<T>
static Silk.NET.Maths.Simd128.ShiftLeft<T>(Vector128<T> x, int amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.ShiftRight<T>(Vector128<T> x, int amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.RotateLeft<T>(Vector128<T> x, int amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.RotateRight<T>(Vector128<T> x, int amount) -> Vector128<T>

Silk.NET.Maths.Simd64
Silk.NET.Maths.Simd64<T>

static readonly Silk.NET.Maths.Simd64<T>.E -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.Epsilon -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.MaxValue -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.MinusOne -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.MinusTwo -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.MinValue -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.NaN -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.NegativeInfinity -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.One -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.Pi -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.PiOver2 -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.PositiveInfinity -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.Tau -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.Two -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.Zero -> Vector64<T>
static readonly Silk.NET.Maths.Simd64<T>.AllBitsSet -> Vector64<T>

static Silk.NET.Maths.Simd64.Load<T>(T* ptr) -> Vector64<T>
static Silk.NET.Maths.Simd64.Store<T>(Vector64<T> source, T* destination)
static Silk.NET.Maths.Simd64.Create<T>(T value) -> Vector64<T>
static Silk.NET.Maths.Simd64.AllBitsSet(Vector64<T> vector) -> bool

static Silk.NET.Maths.Simd64.Abs<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Acos<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Acosh<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Add<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.As<TFrom, Vector64<T>To>(TFrom val) -> Vector64<T>To
static Silk.NET.Maths.Simd64.Asin<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Asinh<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Atan2<T>(Vector64<T> y, Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Atan<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Atanh<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Cbrt<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Ceiling<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Cos<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Cosh<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Divide<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Equal<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Exp<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Floor<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.GreaterThan<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.GreaterThanOrEqual<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.IEEERemainder<T>(Vector64<T> x, Vector64<T> y) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsFinite<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsHardwareAccelerated.get -> bool
static Silk.NET.Maths.Simd64.IsInfinity<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsNaN<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsNegative<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsNegativeInfinity<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsNormal<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsPositiveInfinity<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.IsSubnormal<T>(Vector64<T> f) -> Vector64<T>
static Silk.NET.Maths.Simd64.LessThan<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.LessThanOrEqual<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Log10<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Log<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Log<T>(Vector64<T> x, Vector64<T> y) -> Vector64<T>
static Silk.NET.Maths.Simd64.Max<T>(Vector64<T> x, Vector64<T> y) -> Vector64<T>
static Silk.NET.Maths.Simd64.Min<T>(Vector64<T> x, Vector64<T> y) -> Vector64<T>
static Silk.NET.Maths.Simd64.Multiply<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Negate<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.NotEqual<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Pow<T>(Vector64<T> x, Vector64<T> y) -> Vector64<T>
static Silk.NET.Maths.Simd64.Reciprocal<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Round<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Round<T>(Vector64<T> x, System.MidpointRounding mode) -> Vector64<T>
static Silk.NET.Maths.Simd64.Sign<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Sin<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Sinh<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Sqrt<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Subtract<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Tan<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Tanh<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.Truncate<T>(Vector64<T> x) -> Vector64<T>

static Silk.NET.Maths.Simd64.And<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Or<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Xor<T>(Vector64<T> left, Vector64<T> right) -> Vector64<T>
static Silk.NET.Maths.Simd64.Not<T>(Vector64<T> x) -> Vector64<T>
static Silk.NET.Maths.Simd64.ShiftLeft<T>(Vector64<T> x, int amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.ShiftRight<T>(Vector64<T> x, int amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.RotateLeft<T>(Vector64<T> x, int amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.RotateRight<T>(Vector64<T> x, int amount) -> Vector64<T>

Silk.NET.Maths.Simd256
Silk.NET.Maths.Simd256<T>

static readonly Silk.NET.Maths.Simd256<T>.E -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.Epsilon -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.MaxValue -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.MinusOne -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.MinusTwo -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.MinValue -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.NaN -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.NegativeInfinity -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.One -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.Pi -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.PiOver2 -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.PositiveInfinity -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.Tau -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.Two -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.Zero -> Vector256<T>
static readonly Silk.NET.Maths.Simd256<T>.AllBitsSet -> Vector256<T>

static Silk.NET.Maths.Simd256.Load<T>(T* ptr) -> Vector256<T>
static Silk.NET.Maths.Simd256.Store<T>(Vector256<T> source, T* destination)
static Silk.NET.Maths.Simd256.Create<T>(T value) -> Vector256<T>
static Silk.NET.Maths.Simd256.AllBitsSet(Vector256<T> vector) -> bool

static Silk.NET.Maths.Simd256.Abs<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Acos<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Acosh<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Add<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.As<TFrom, Vector256<T>To>(TFrom val) -> Vector256<T>To
static Silk.NET.Maths.Simd256.Asin<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Asinh<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Atan2<T>(Vector256<T> y, Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Atan<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Atanh<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Cbrt<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Ceiling<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Cos<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Cosh<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Divide<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Equal<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Exp<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Floor<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.GreaterThan<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.GreaterThanOrEqual<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.IEEERemainder<T>(Vector256<T> x, Vector256<T> y) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsFinite<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsHardwareAccelerated.get -> bool
static Silk.NET.Maths.Simd256.IsInfinity<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsNaN<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsNegative<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsNegativeInfinity<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsNormal<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsPositiveInfinity<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.IsSubnormal<T>(Vector256<T> f) -> Vector256<T>
static Silk.NET.Maths.Simd256.LessThan<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.LessThanOrEqual<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Log10<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Log<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Log<T>(Vector256<T> x, Vector256<T> y) -> Vector256<T>
static Silk.NET.Maths.Simd256.Max<T>(Vector256<T> x, Vector256<T> y) -> Vector256<T>
static Silk.NET.Maths.Simd256.Min<T>(Vector256<T> x, Vector256<T> y) -> Vector256<T>
static Silk.NET.Maths.Simd256.Multiply<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Negate<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.NotEqual<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Pow<T>(Vector256<T> x, T y) -> Vector256<T>
static Silk.NET.Maths.Simd256.Reciprocal<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Round<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Round<T>(Vector256<T> x, System.MidpointRounding mode) -> Vector256<T>
static Silk.NET.Maths.Simd256.Sign<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Sin<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Sinh<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Sqrt<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Subtract<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Tan<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Tanh<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.Truncate<T>(Vector256<T> x) -> Vector256<T>

static Silk.NET.Maths.Simd256.And<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Or<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Xor<T>(Vector256<T> left, Vector256<T> right) -> Vector256<T>
static Silk.NET.Maths.Simd256.Not<T>(Vector256<T> x) -> Vector256<T>
static Silk.NET.Maths.Simd256.ShiftLeft<T>(Vector256<T> x, int amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.ShiftRight<T>(Vector256<T> x, int amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.RotateLeft<T>(Vector256<T> x, int amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.RotateRight<T>(Vector256<T> x, int amount) -> Vector256<T>

```
