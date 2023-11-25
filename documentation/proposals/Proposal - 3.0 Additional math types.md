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
public readonly struct Angle<T> 
    : IEquatable<Angle<T>>
    , IEqualityOperators<Angle<T>,Angle<T>, bool>
    , IComparable<Angle<T>>
    , IComparisonOperators<Angle<T>,Angle<T>, bool>
    , IAdditionOperators<Angle<T>,Angle<T>,Angle<T>>
    , IDivisionOperators<Angle<T>, T, Angle<T>>
    , IDivisionOperators<T, Angle<T>, Angle<T>>
    , IMultiplyOperators<Angle<T>, T, Angle<T>>
    , IMultiplyOperators<T, Angle<T>, Angle<T>>
    , IModulusOperators<Angle<T>, Angle<T>, Angle<T>>
    , ISubtractionOperators<Angle<T>,Angle<T>,Angle<T>>
    , IParsable<Angle<T>>
    , ISpanParsable<Angle<T>>
    where T : IFloatingPointIeee754<T>
{

    public readonly T Radians;

    public Angle(T radians) { }

    
    public T Degrees { get; }
    public T Gradians { get; }
    public T Milliradians { get; }
    public T Minutes { get; }
    public T Seconds { get; }


    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is a right angle (i.e. 90° or π/2).
    /// </summary>    
    public bool IsRight { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is a straight angle (i.e. 180° or π).
    /// </summary>    
    public bool IsStraight { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is a full rotation angle (i.e. 360° or 2π).
    /// </summary>    
    public bool IsFullRotation { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is an oblique angle (i.e. is not 90° or a multiple of 90°).
    /// </summary>    
    public bool IsOblique { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is an acute angle (i.e. less than 90° but greater than 0°).
    /// </summary>    
    public bool IsAcute { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is an obtuse angle (i.e. greater than 90° but less than 180°).
    /// </summary>    
    public bool IsObtuse { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Angle<T>
    /// is a reflex angle (i.e. greater than 180° but less than 360°).
    /// </summary>    
    public bool IsReflex { get; }

    /// <summary>
    /// Gets a Angle<T> instance that complements this angle (i.e. the two angles add to 90°).
    /// </summary>    
    public Angle<T> Complement { get; }

    /// <summary>
    /// Gets a Angle<T> instance that supplements this angle (i.e. the two angles add to 180°).
    /// </summary>    
    public Angle<T> Supplement { get; }

    /// <summary>
    /// Wraps this Angle<T> to be in the range [π, -π].
    /// </summary>
    public Angle<T> Wrap() => default;

    /// <summary>
    /// Wraps this Angle<T> to be in the range [0, 2π).
    /// </summary>
    public Angle<T> WrapPositive() => default;


    /// <summary>Computes the arc-cosine of a value.</summary>
    public T Acos()  => default;

    /// <summary>Computes the arc-cosine of a value and divides the result by <c>pi</c>.</summary>
    public T AcosPi()  => default;

    /// <summary>Computes the arc-sine of a value.</summary>
    public T Asin()  => default;

    /// <summary>Computes the arc-sine of a value and divides the result by <c>pi</c>.</summary>
    public T AsinPi()  => default;

    /// <summary>Computes the arc-tangent of a value.</summary>
    public T Atan()  => default;

    /// <summary>Computes the arc-tangent of a value and divides the result by pi.</summary>
    public T AtanPi()  => default;

    /// <summary>Computes the cosine of a value.</summary>
    public T Cos()  => default;

    /// <summary>Computes the cosine of a value that has been multipled by <c>pi</c>.</summary>
    public T CosPi()  => default;

    /// <summary>Computes the sine of a value.</summary>
    /// <param name="x">The value, in radians, whose sine is to be computed.</param>
    /// <returns>The sine of <paramref name="x" />.</returns>
    /// <remarks>This computes <c>sin(x)</c>.</remarks>
    public T Sin()  => default;

    /// <summary>Computes the sine and cosine of a value.</summary>
    public (T Sin, T Cos) SinCos()  => default;

    /// <summary>Computes the sine and cosine of a value that has been multiplied by <c>pi</c>.</summary>
    public (T SinPi, T CosPi) SinCosPi()  => default;

    /// <summary>Computes the sine of a value that has been multiplied by <c>pi</c>.</summary>
    public T SinPi()  => default;

    /// <summary>Computes the tangent of a value.</summary>
    public T Tan()  => default;

    /// <summary>Computes the tangent of a value that has been multipled by <c>pi</c>.</summary>
    public T TanPi()  => default;

    /// <summary>Implicit cast in radians</summary>
    public static implicit operator T(Angle<T> angle) => default;
}

public static class Angle
{
    public static Angle<T> FromRadians<T>(T radians)
        where T : IFloatingPointIeee754<T>
        => default;
    public static Angle<T> FromDegrees<T>(T degrees)
        where T : IFloatingPointIeee754<T>
         => default;
    public static Angle<T> FromGradians<T>(T gradians)
        where T : IFloatingPointIeee754<T>
         => default;
    public static Angle<T> FromMilliradians<T>(T milliradians)
        where T : IFloatingPointIeee754<T>
         => default;
    public static Angle<T> FromMinutes<T>(T minutes)
        where T : IFloatingPointIeee754<T>
         => default;
    public static Angle<T> FromSeconds<T>(T seconds)
        where T : IFloatingPointIeee754<T>
         => default;

    public static Angle<T> Min<T>(Angle<T> left, Angle<T> right) 
        where T : IFloatingPointIeee754<T>
        => default;

    public static Angle<T> Max<T>(Angle<T> left, Angle<T> right)
        where T : IFloatingPointIeee754<T>
        => default;

    public static Angle<T> Clamp<T>(Angle<T> value, Angle<T> min, Angle<T> max)
        where T : IFloatingPointIeee754<T>
        => default;

    public static Angle<T> Atan2<T>(T y, T x)
        where T : IFloatingPointIeee754<T>
        => default;

    public static Angle<T> ArcTan<T>(T y, T x)
        where T : IFloatingPointIeee754<T>
        => default;

    public static Angle<T> ArcSin<T>(T sin)
        where T : IFloatingPointIeee754<T>
         => default;

    public static Angle<T> ArcCos<T>(T cos)
        where T : IFloatingPointIeee754<T>
         => default;

    public static Angle<T> Between<T>(Vector2F<T> left, Vector2F<T> right)
       where T : IFloatingPointIeee754<T>
       => default;

    public static Angle<T> Between<T>(Vector3F<T> left, Vector3F<T> right)
       where T : IFloatingPointIeee754<T>
       => default;

    public static Angle<T> ZeroAngle<T>()
        where T : IFloatingPointIeee754<T>
         => default;

    public static Angle<T> RightAngle<T>()
        where T : IFloatingPointIeee754<T>
         => default;

    public static Angle<T> StraightAngle<T>()
        where T : IFloatingPointIeee754<T>
         => default;

    public static Angle<T> FullRotationAngle<T>()
        where T : IFloatingPointIeee754<T>
         => default;
}
```

## "Collision" types.

DirectX and other APIs include "collision shapes" that can be used for such things as culling. `Silk.Net.Maths` already includes some types i.e. `BoxF`, `PlaneF`. These are additional.

### Frustum

### OrientedBox

### CollisionHelper

### PlaneIntersectionType

### ContainmentType

## Color types.

### Color

### ColorBGRA

### ColorHSV

### Color3

### Color4
