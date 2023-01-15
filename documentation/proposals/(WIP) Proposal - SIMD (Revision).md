# Summary
That will bring a number of minor fixes to the [SIMD Proposal](Proposal%20-%20Vectorization%20-%20SIMD.md).

# Contributors
- WhiteBlackGoose

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
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

**Also apply that to Scalar.**

# Behavioural changes

### IEEE754 standard

I propose we do *not* guarantee following it for the sake of performance. For example, artificially normalized values are preferred over the expected abnormal.

### Reciprocal of an integer

**OPEN QUESTION:** what should be a reciprocal of an integer? Just 0? What is its behaviour for integer 0?

### IsHardwareAccelerated

Currently, in the `feature/math-simd` branch it does not depend on the type. I suggest making it dependent on the type (e. g. by doing `&& IsSupported`).

It also does not depend on the method, which may lead to worse performance than just scalar operations (for methods which use other simd methods *which* in turn use scalar operations). **OPEN QUESTION:** how can we check that a method is hw-accelerated?

### How else can we guarantee the fastest code?

**OPEN QUESTION:** How can we let the user know if a `method` x `type` x `bitness` x `target machine` indeed makes a use of HW-acceleration? Or is the fallback with loop over vector good enough?

## Meeting Notes

Proposal needs work (open questions addressed). Discussed in Working Group meeting 29/11/2021, 19:13 UTC.

**Note:** it has been assumed that all SIMD proposal elements are also being applied to Scalar.

- IEEE754
    - All methods and code thus far just follows whatever makes it fast, no compliance to any standard or other behaviour (c# builtin, hardware, etc) is guaranteed
        - Pretty good to be that way, as we can be the fastest and 100% accuracy most people don't care about
    - There's a difference between doing things for correctness and doing it for performance.
    - example optimization which could be problematic: treating NaN as 0, assuming it'll never happen (case in point: GCC fastmath)
    - Don't throw exceptions in performant, use NaN instead to represent exceptional circumstances? What about ints?
    - The only time you can accelerate if a value is a constant (JIT-level knowledge...)
    - Separate methods for opt-in correctness-sacrificial optimizations?
        - "I'm aware of the implications, and am ready for them"
    - Most sense, least surprise (0 / 0 = 0)
    - Something like a "IsMaximum" API to represent the "maximum representable value for a T" and use that in operations
    - .NET's default behaviour is changing to match Rust, WASM etc - platform-specifics (i.e. faster paths)
    - "do whatever the operator will do"
    - Just throw exceptions where they're not trivially avoidable.
    - We want all of the APIs to be as close as they can to hardware-accelerated.
        - are we sure? should they be explicitly labelled?
        - If we're using an inaccurate algorithm, should it be explicitly labelled?
        - Figure out ULP, and document if we're making this decision? The user could check the docs, find the ULP, and then either use the library or don't use the library according to that.
        - It's not trivial to find edge cases, could catch people out without realising?
        - Let's just add estimate APIs
    - For estimate APIs should they throw exceptions?

- Reciprocal of int
    - see consensus

- IsHardwareAccelerated
    - Make IsHardwareAccelerated per-type
    - Perhaps we could make a smarter way of doing IsHardwareAccelerated, but the working group thinks it's not necessary (and also has no ideas)
    - "Some or most of the APIs for this type are hardware accelerated"
        - Methods that aren't are slow-path
    - Static class with a whole bunch of static APIs for indicating?
    - Where do we draw the line?
    - Lots of checks can hurt the JIT/inliner
    - Usually we optimize "all or nothing" for a given type. There may be a few exceptions, but these would be few and far between.
    - Per-method and per-type is just pernickety and the working group sees no use case for this today/doesn't really matter...


**Consensus**
- IEEE754: We'll have estimate APIs and "native"/"more precise" APIs, two versions of all except things built in to the hardware (at a given baseline)
- Reciprocal: do what C# does for non-estimate (and for estimate as well we guess)
- IsHardwareAccelerated: one boolean per type. Not worth making a new flag for the few cases where we have a couple of functions which are slow for a given type.
