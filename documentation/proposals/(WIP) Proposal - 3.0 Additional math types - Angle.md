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



# Proposed API

## Angle

* `IParsable<TSelf>`, `ISpanParsable<TSelf>`, `IUtf8SpanParsable<TSelf>`
    * must parse angle in degrees using `IParsable<TScalar>`, `ISpanParsable<TScalar>`, `IUtf8SpanParsable<TSelf>`
    * optional handle `°` character

* `IFormattable`, `IUtf8SpanFormattable`
    * must produce text in degrees with default format of 2 decimal places. i.e. format string `0.##`
    * optional include `°` character. i.e. format string `0.##°`

Interface implementations not included for brevity.

```csharp
/// <summary>
/// Represents a unit independant angle using a floating-point
/// internal representation.
/// </summary>
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
    internal Angle(TScalar radians) { }

    /// <summary>Angle in degrees in the range [0, 360]. Without fractional component.</summary>
    public TScalar Degrees { get; }

    /// <summary>Angle in degrees in the range [0, 360]. With fractional component.</summary>
    public TScalar TotalDegrees { get; }

    /// <summary>Angle in radians in range [π, -π].</summary>
    public TScalar Radians { get; }

    /// <summary>Angle in radians in range [0, 2π].</summary>
    public TScalar PositiveRadians { get; }

    /// <summary>Gets or sets the minutes component of the degrees this Silk.NET.Maths.Angle<TScalar> represents.</summary>
    public TScalar Minutes { get; }

    /// <summary>Gets or sets the seconds of the degrees this Silk.NET.Maths.Angle<TScalar> represents.</summary>
    public TScalar Seconds { get; }


    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is a right angle (i.e. 90° or π/2).
    /// </summary>    
    public bool IsRight { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is a straight angle (i.e. 180° or π).
    /// </summary>    
    public bool IsStraight { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is a full rotation angle (i.e. 360° or 2π).
    /// </summary>    
    public bool IsFullRotation { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is an oblique angle (i.e. is not 90° or a multiple of 90°).
    /// </summary>    
    public bool IsOblique { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is an acute angle (i.e. less than 90° but greater than 0°).
    /// </summary>    
    public bool IsAcute { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is an obtuse angle (i.e. greater than 90° but less than 180°).
    /// </summary>    
    public bool IsObtuse { get; }

    /// <summary>
    /// Gets a System.Boolean that determines whether this Silk.NET.Maths.Angle<TScalar>
    /// is a reflex angle (i.e. greater than 180° but less than 360°).
    /// </summary>    
    public bool IsReflex { get; }

    /// <summary>
    /// Gets a Silk.NET.Maths.Angle<TScalar> instance that complements this angle (i.e. the two angles add to 90°).
    /// </summary>    
    public Angle<TScalar> Complement { get; }

    /// <summary>
    /// Gets a Silk.NET.Maths.Angle<TScalar> instance that supplements this angle (i.e. the two angles add to 180°).
    /// </summary>    
    public Angle<TScalar> Supplement { get; }

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

    public static Angle<TScalar> FromDegrees<TScalar>(TScalar degrees, TScalar minutes, TScalar seconds)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Min<TScalar>(Angle<TScalar> left, Angle<TScalar> right) 
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Max<TScalar>(Angle<TScalar> left, Angle<TScalar> right)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Add<TScalar>(Angle<TScalar> left, Angle<TScalar> right)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Subtract<TScalar>(Angle<TScalar> left, Angle<TScalar> right)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Multiply<TScalar>(Angle<TScalar> left, TScalar right)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Divide<TScalar>(Angle<TScalar> left, TScalar right)
        where TScalar : IFloatingPointIeee754<TScalar>
        => default;

    public static Angle<TScalar> Clamp<TScalar>(Angle<TScalar> value, Angle<TScalar> min, Angle<TScalar> max)
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

    public static Angle<TScalar> Between<TScalar>(in Vector2F<TScalar> left, in Vector2F<TScalar> right)
       where TScalar : IFloatingPointIeee754<TScalar>
       => default;

    public static Angle<TScalar> Between<TScalar>(in Vector3F<TScalar> left, in Vector3F<TScalar> right)
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

# Meeting Agenda/Notes
## TDB
* Degrees, minutes and seconds are not fractional. Should they be changed to an integer type (`int`)?
    *   ```csharp
        public int Degrees { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public static Angle<TScalar> FromDegrees<TScalar>(int degrees, int minutes, int seconds)
            where TScalar : IFloatingPointIeee754<TScalar>
            => default;
        ```