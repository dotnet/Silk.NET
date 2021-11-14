# Summary
That will bring a number of minor fixes to the [SIMD Proposal](Proposal%20-%20Vectorization%20-%20SIMD.md).

# Contributors
- WhiteBlackGoose

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented


# API changes

`Avx` and `AdvSimd` offer us shifting by a vector, so there is no reason to limit to a fixed amount. Rotation here for consistency with shift.

`Sign` has been decided to return the sign of the values. So I also suggest `CopySign` method, which would work similarly to Avx's `Sign`.

Finally, `IsInteger`, `IsFloat`, `IsUnsignedInteger` and `IsSignedInteger` are shorthands for checking if the type is of a certain "class".

```cs
static Silk.NET.Maths.Simd128.ShiftLeft<T>(Vector128<T> x, Vector128<T> amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.ShiftRight<T>(Vector128<T> x, Vector128<T> amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.RotateLeft<T>(Vector128<T> x, Vector128<T> amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.RotateRight<T>(Vector128<T> x, Vector128<T> amount) -> Vector128<T>
static Silk.NET.Maths.Simd128.CopySign<T>(Vector128<T> source, Vector128<T> destination) -> Vector128<T>

static Silk.NET.Maths.Simd256.ShiftLeft<T>(Vector256<T> x, Vector256<T> amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.ShiftRight<T>(Vector256<T> x, Vector256<T> amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.RotateLeft<T>(Vector256<T> x, Vector256<T> amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.RotateRight<T>(Vector256<T> x, Vector256<T> amount) -> Vector256<T>
static Silk.NET.Maths.Simd256.CopySign<T>(Vector256<T> source, Vector256<T> destination) -> Vector256<T>

static Silk.NET.Maths.Simd64.ShiftLeft<T>(Vector64<T> x, Vector64<T> amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.ShiftRight<T>(Vector64<T> x, Vector64<T> amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.RotateLeft<T>(Vector64<T> x, Vector64<T> amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.RotateRight<T>(Vector64<T> x, Vector64<T> amount) -> Vector64<T>
static Silk.NET.Maths.Simd64.CopySign<T>(Vector64<T> source, Vector64<T> destination) -> Vector64<T>

static readonly Silk.NET.Maths.Simd128<T>.IsFloat -> bool
static readonly Silk.NET.Maths.Simd128<T>.IsInteger -> bool
static readonly Silk.NET.Maths.Simd128<T>.IsUnsignedInteger -> bool
static readonly Silk.NET.Maths.Simd128<T>.IsSignedInteger -> bool

static readonly Silk.NET.Maths.Simd256<T>.IsFloat -> bool
static readonly Silk.NET.Maths.Simd256<T>.IsInteger -> bool
static readonly Silk.NET.Maths.Simd256<T>.IsUnsignedInteger -> bool
static readonly Silk.NET.Maths.Simd256<T>.IsSignedInteger -> bool

static readonly Silk.NET.Maths.Simd64<T>.IsFloat -> bool
static readonly Silk.NET.Maths.Simd64<T>.IsInteger -> bool
static readonly Silk.NET.Maths.Simd64<T>.IsUnsignedInteger -> bool
static readonly Silk.NET.Maths.Simd64<T>.IsSignedInteger -> bool
```

# Behavioural changes

### IEEE754 standard

I propose we do *not* guarantee following it for the sake of performance. For example, artificially normalized values are preferred over the expected abnormal.

### Reciprocal of an integer

**[To discuss]**

### IsHardwareAccelerated

Currently, in the `feature/math-simd` branch it does not depend on the type. I suggest making it dependent on the type (e. g. by doing `&& IsSupported`).

It also does not depend on the method, which may lead to worse performance than just scalar operations (for methods which use other simd methods *which* in turn use scalar operations). This thing **[To discuss]**
