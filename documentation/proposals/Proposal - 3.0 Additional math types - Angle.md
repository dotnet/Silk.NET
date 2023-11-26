# Summary
Proposal API for additional math types to bring it up to feature parity with other popular math libraries i.e. `SlimDX`, `SharpDX`, or `Stride3D`. Leveraging modern .NET features such as `INumber<T>` and vectorization.

# Contributors
- Daniel Keenan (dfkeenan)

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal should compliment/augment the proposed 3.0 implementation of `Silk.Net.Maths`, matching `System.Numerics` where possible, with concessions for design oversights in that api.
- This proposal assumes no knowledge of the 2.x Math library.
- Text herein marked **INFORMATIVE** does not form a normative part of this proposal, and is for background only.
- Within this proposal, the key words **must**, **required**, **shall**, **should**, **recommended**, **may**, **could**, and **optional** are to be interpreted as described in [RFC 2119 - Key words for use in RFCs to Indicate Requirement Levels](https://www.ietf.org/rfc/rfc2119.txt). The additional key word **optionally** is an alternate form of **optional**, for use where grammatically appropriate. These key words are highlighted in the proposal for clarity.

# **INFORMATIVE** Integer and Floating Point Types
While investigating the use of generic math it was decided to provide both an integer and floating point variant for each vector type and every type built from them. See [Generic Math](Proposal%20-%20Generic%20Math.md) proposal for more details.

# I types versus F Types
Where it is appropriate for a type in this proposal to have both integer and floating point variants they will have a name that ends in I or F, defining whether it is an integer type or floating point type. Integer types **must** use a generic type argument `T` with the constraint of `IBinaryInteger<T>`. On the other hand, floating point types **must** use a generic type argument `T` with the constraint of `IFloatingPointIeee754<T>`.

# Proposed API

## Angle

Interface implementations not included for brevity.

```csharp
public readonly struct Angle<TScalar> 
    : IEquatable<Angle<TScalar>>
    , IEqualityOperators<Angle<TScalar>,Angle<TScalar>, bool>
    , IComparable<Angle<TScalar>>
    , IComparisonOperators<Angle<TScalar>,Angle<TScalar>, bool>
    , IAdditionOperators<Angle<TScalar>,Angle<TScalar>,Angle<TScalar>>
    , IDivisionOperators<Angle<TScalar>, TScalar, Angle<TScalar>>
    , IDivisionOperators<TScalar, Angle<TScalar>, Angle<TScalar>>
    , IMultiplyOperators<Angle<TScalar>, TScalar, Angle<TScalar>>
    , IMultiplyOperators<TScalar, Angle<TScalar>, Angle<TScalar>>
    , IModulusOperators<Angle<TScalar>, Angle<TScalar>, Angle<TScalar>>
    , ISubtractionOperators<Angle<TScalar>,Angle<TScalar>,Angle<TScalar>>
    , IParsable<Angle<TScalar>>
    , ISpanParsable<Angle<TScalar>>
    , IUtf8SpanParsable<Angle<TScalar>>
    , IFormattable
    , IUtf8SpanFormattable
    where TScalar : IFloatingPointIeee754<TScalar>
{

    public readonly TScalar TotalRadians;

    public Angle(TScalar totalRadians) { }

    /// <summary>Angle in degrees in the range [0, 360].</summary>
    public TScalar Degrees { get; }
    /// <summary>Total angle in degrees.</summary>
    public TScalar TotalDegrees { get; }
    /// <summary>Angle in radians in range [π, -π].</summary>
    public TScalar Radians { get; }

    public TScalar Hours { get; }
    public TScalar Minutes { get; }
    public TScalar Seconds { get; }


    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is a right angle (i.e. 90° or π/2).
    /// </summary>    
    public bool IsRight { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is a straight angle (i.e. 180° or π).
    /// </summary>    
    public bool IsStraight { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is a full rotation angle (i.e. 360° or 2π).
    /// </summary>    
    public bool IsFullRotation { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is an oblique angle (i.e. is not 90° or a multiple of 90°).
    /// </summary>    
    public bool IsOblique { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is an acute angle (i.e. less than 90° but greater than 0°).
    /// </summary>    
    public bool IsAcute { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is an obtuse angle (i.e. greater than 90° but less than 180°).
    /// </summary>    
    public bool IsObtuse { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<TScalar>
    /// is a reflex angle (i.e. greater than 180° but less than 360°).
    /// </summary>    
    public bool IsReflex { get; }

    /// <summary>
    /// Gets a Angle<TScalar> instance that complements this angle (i.e. the two angles add to 90°).
    /// </summary>    
    public Angle<TScalar> Complement { get; }

    /// <summary>
    /// Gets a Angle<TScalar> instance that supplements this angle (i.e. the two angles add to 180°).
    /// </summary>    
    public Angle<TScalar> Supplement { get; }

    /// <summary>
    /// Wraps this Angle<TScalar> to be in the range [π, -π].
    /// </summary>
    public Angle<TScalar> Wrap() => default;

    /// <summary>
    /// Wraps this Angle<TScalar> to be in the range [0, 2π).
    /// </summary>
    public Angle<TScalar> WrapPositive() => default;


    /// <summary>Computes the arc-cosine of a value.</summary>
    public TScalar Acos()  => default;

    /// <summary>Computes the arc-cosine of a value and divides the result by <c>pi</c>.</summary>
    public TScalar AcosPi()  => default;

    /// <summary>Computes the arc-sine of a value.</summary>
    public TScalar Asin()  => default;

    /// <summary>Computes the arc-sine of a value and divides the result by <c>pi</c>.</summary>
    public TScalar AsinPi()  => default;

    /// <summary>Computes the arc-tangent of a value.</summary>
    public TScalar Atan()  => default;

    /// <summary>Computes the arc-tangent of a value and divides the result by pi.</summary>
    public TScalar AtanPi()  => default;

    /// <summary>Computes the cosine of a value.</summary>
    public TScalar Cos()  => default;

    /// <summary>Computes the cosine of a value that has been multipled by <c>pi</c>.</summary>
    public TScalar CosPi()  => default;

    /// <summary>Computes the sine of a value.</summary>
    /// <param name="x">The value, in radians, whose sine is to be computed.</param>
    /// <returns>The sine of <paramref name="x" />.</returns>
    /// <remarks>This computes <c>sin(x)</c>.</remarks>
    public TScalar Sin()  => default;

    /// <summary>Computes the sine and cosine of a value.</summary>
    public (TScalar Sin, TScalar Cos) SinCos()  => default;

    /// <summary>Computes the sine and cosine of a value that has been multiplied by <c>pi</c>.</summary>
    public (TScalar SinPi, TScalar CosPi) SinCosPi()  => default;

    /// <summary>Computes the sine of a value that has been multiplied by <c>pi</c>.</summary>
    public TScalar SinPi()  => default;

    /// <summary>Computes the tangent of a value.</summary>
    public TScalar Tan()  => default;

    /// <summary>Computes the tangent of a value that has been multipled by <c>pi</c>.</summary>
    public TScalar TanPi()  => default;

    /// <summary>Implicit cast in radians</summary>
    public static implicit operator TScalar(Angle<TScalar> angle) => default;
}

```



```csharp

public static class Angle
{
    public static Angle<TScalar> FromRadians<TScalar>(TScalar radians)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;
    public static Angle<TScalar> FromDegrees<TScalar>(TScalar degrees)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;
    public static Angle<TScalar> FromHours<TScalar>(TScalar hours)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;
    public static Angle<TScalar> FromMinutes<TScalar>(TScalar minutes)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;
    public static Angle<TScalar> FromSeconds<TScalar>(TScalar seconds)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> FromTimeSpan<TScalar>(TimeSpan timeSpan)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> Min<TScalar>(Angle<TScalar> left, Angle<TScalar> right) 
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Max<TScalar>(Angle<TScalar> left, Angle<TScalar> right)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Clamp<TScalar>(Angle<TScalar> value, Angle<TScalar> min, Angle<TScalar> max)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

     public static Angle<TScalar> Lerp<TScalar>(Angle<TScalar> start, Angle<TScalar> end, TScalar amount)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

     public static Angle<TScalar> SmoothStep<TScalar>(Angle<TScalar> start, Angle<TScalar> end, TScalar amount)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Atan2<TScalar>(TScalar y, TScalar x)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> ArcTan<TScalar>(TScalar y, TScalar x)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> ArcSin<TScalar>(TScalar sin)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> ArcCos<TScalar>(TScalar cos)
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> Between<TScalar>(Vector2F<TScalar> left, Vector2F<TScalar> right)
       where TScalar : IFloatingPointIeee754<TScalar>
       => default;

    public static Angle<TScalar> Between<TScalar>(Vector3F<TScalar> left, Vector3F<TScalar> right)
       where TScalar : IFloatingPointIeee754<TScalar>
       => default;

    public static Angle<TScalar> ZeroAngle<TScalar>()
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> RightAngle<TScalar>()
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> StraightAngle<TScalar>()
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;

    public static Angle<TScalar> FullRotationAngle<TScalar>()
        where TScalar : IFloatingPointIeee754<TScalar>
         => default;
}
```