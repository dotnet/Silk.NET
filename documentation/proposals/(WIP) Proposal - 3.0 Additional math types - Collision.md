# Summary
Proposal API for additional math types to bring it up to feature parity with other popular math libraries i.e. `SlimDX`, `SharpDX`, or `Stride3D`. Leveraging modern .NET features such as `INumber<T>` and vectorization.

DirectX and other APIs include "collision shapes" that can be used for such things as culling. This proposal covers the addition of similar "Bounding{Shape}" types and their corresponding containment and intersection test.

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

`Silk.NET.Math` and the generic math proposal for 3.0 already contain "geometric types" that would be suitable to use for collision/intersection types. i.e. Box3F.

This proposal is to add additional APIs for the purpose of intersection tests.

### PlaneIntersectionType

```csharp
 public enum PlaneIntersectionType
 {
     Back,
     Front,
     Intersecting,
 }
```

### ContainmentType
```csharp
public enum ContainmentType
{
    Disjoint,
    Contains,
    Intersects,
}
```

### IIntersectWithRay
```csharp
public interface IIntersectWithRay<TSelf, TScalar>
    where TScalar : IFloatingPointIeee754<TScalar>
{
    public bool Intersects(ref readonly Ray3F<TScalar> ray);

    public static abstract bool Intersects(ref readonly TSelf shape, ref readonly Ray3F<TScalar> ray);

    public bool Intersects(ref readonly Ray3F<TScalar> ray, out float distance);

    public static abstract bool Intersects(ref readonly TSelf shape, ref readonly Ray3F<TScalar> ray, out float distance);

    public bool Intersects(ref readonly Ray3F<TScalar> ray, out Vector3F<TScalar> point);

    public static abstract bool Intersects(ref readonly TSelf shape, ref readonly Ray3F<TScalar> ray, out Vector3F<TScalar> point);
}
```

### IIntersectWithPlane
```csharp
public interface IIntersectWithPlane<TSelf, TScalar>
    where TScalar : IFloatingPointIeee754<TScalar>
{
   
    public PlaneIntersectionType Intersects(ref readonly PlaneF<TScalar> plane);
    public static abstract PlaneIntersectionType Intersects(ref readonly TSelf shape, ref readonly PlaneF<TScalar> plane);
}
```

### IIntersect
```csharp
public interface IIntersect<TSelf, TOther>
{
    public bool Intersects(ref readonly TOther other);

    public static abstract bool Intersects(ref readonly TSelf shape, ref readonly TOther other);
}
```

### IContainPoint
```csharp
public interface IContainPoint<TSelf, TScalar>
    where TScalar : IFloatingPointIeee754<TScalar>
{

    public ContainmentType Contains(ref readonly Vector3F<TScalar> point);

    public static abstract ContainmentType Contains(ref readonly TSelf shape, ref readonly Vector3F<TScalar> point);

    public ContainmentType Contains(ref readonly Vector3F<TScalar> vertex1, ref readonly Vector3F<TScalar> vertex2, ref readonly Vector3F<TScalar> vertex3);

    public static abstract ContainmentType Contains(ref readonly TSelf shape, ref readonly Vector3F<TScalar> vertex1, ref readonly Vector3F<TScalar> vertex2, ref readonly Vector3F<TScalar> vertex3);
}
```

### IContain
```csharp
public interface IContain<TSelf, TOther>
{
    public ContainmentType Contains(ref readonly TOther other);

    public static abstract ContainmentType Contains(ref readonly TSelf shape, ref readonly TOther other);
}
```

### IColliderShape
```csharp
public interface IColliderShape<TSelf, TScalar>
    where TScalar : IFloatingPointIeee754<TScalar>
{
    public static abstract TSelf Empty { get; }

    public static abstract void FromPoints(ReadOnlySpan<Vector3F<TScalar>> points, out TSelf result);
    public static abstract TSelf FromPoints(ReadOnlySpan<Vector3F<TScalar>> points);

    public static abstract void Merge(ref readonly TSelf value1, ref readonly TSelf value2, out TSelf result);

    public static abstract TSelf Merge(TSelf value1, TSelf value2);

    public static abstract void Transform(ref readonly TSelf value, ref readonly Matrix4x4F<TScalar> transform);
    public static abstract void Transform(ref readonly TSelf value, ref readonly Matrix4x4F<TScalar> transform, out TSelf result);
}
```

### BoxF

Additional interfaces/members for BoxF. Interface implementations not included for brevity.

```csharp
public struct BoxF<TScalar>
    : IIntersectWithRay<BoundingBox<TScalar>, TScalar>
    , IIntersectWithPlane<BoundingBox<TScalar>, TScalar>
    , IColliderShape<BoundingBox<TScalar>, TScalar>
    , IContainPoint<BoundingBox<TScalar>, TScalar>
    , IIntersect<BoxF<TScalar>, BoxF<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<BoxF<TScalar>, BoxF<TScalar>>
    //Implement IContain for other shapes
    where TScalar: IBinaryFloatingPointIeee754<TScalar>
{

}
```

### SphereF

Additional interfaces/members for SphereF. Interface implementations not included for brevity.

```csharp
public struct SphereF<TScalar>
    , IIntersectWithRay<SphereF<TScalar>, TScalar>
    , IIntersectWithPlane<SphereF<TScalar>, TScalar>
    , IColliderShape<SphereF<TScalar>, TScalar>
    , IContainPoint<SphereF<TScalar>, TScalar>
    , IIntersect<SphereF<TScalar>, SphereF<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<SphereF<TScalar>, SphereF<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{

}
```

### BoxExtentF

Access aligned box for fast frustum culling. Interface implementations not included for brevity.

* Must include the same members as mentioned in the Generic Math proposal in the `Geometric Types` section 

```csharp
public struct BoxExtentF<TScalar>
    : IEquatable<BoxExtentF<TScalar>>
    , IEqualityOperators<BoxExtentF<TScalar>, BoxExtentF<TScalar>, bool>
    , IIntersectWithRay<BoxExtentF<TScalar>, TScalar>
    , IIntersectWithPlane<BoxExtentF<TScalar>, TScalar>
    , IColliderShape<BoxExtentF<TScalar>, TScalar>
    , IContainPoint<BoxExtentF<TScalar>, TScalar>
    , IIntersect<BoxExtentF<TScalar>, BoxExtentF<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<BoxExtentF<TScalar>, BoxExtentF<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{
    public Vector3F<TScalar> Center;
    public Vector3F<TScalar> Extents;

    public BoxExtentF(BoxF<TScalar> box);
    public BoxExtentF(Vector3F<TScalar> minimum, Vector3F<TScalar> maximum);

    public static explicit operator BoxF<TScalar>(BoxExtentF<TScalar> boxExtent);
    public static explicit operator BoxExtentF<TScalar>(BoxF<TScalar> box)
}

```

### OrientedBoxF

Box with orientation. Interface implementations not included for brevity.

* Must include the same members as mentioned in the Generic Math proposal in the `Geometric Types` section 

```csharp
public struct OrientedBoxF<TScalar>
    : IEquatable<OrientedBoxF<TScalar>>
    , IEqualityOperators<OrientedBoxF<TScalar>, OrientedBoxF<TScalar>, bool>
    , IIntersectWithRay<OrientedBoxF<TScalar>, TScalar>
    , IIntersectWithPlane<OrientedBoxF<TScalar>, TScalar>
    , IColliderShape<OrientedBoxF<TScalar>, TScalar>
    , IContainPoint<OrientedBoxF<TScalar>, TScalar>
    , IIntersect<OrientedBoxF<TScalar>, OrientedBoxF<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<OrientedBoxF<TScalar>, OrientedBoxF<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{
    public Vector3F<TScalar> Center;
    public Vector3F<TScalar> Extents;
    public Quaternion Orientation;

    public OrientedBoxF(Vector3F<TScalar> center, Vector3F<TScalar> extents, Quaternion orientation);
}
```

### FrustumF

Frustum

```csharp
public struct FrustumF<TScalar>
    , IIntersectWithRay<FrustumF<TScalar>, TScalar>
    , IIntersectWithPlane<FrustumF<TScalar>, TScalar>
    , IColliderShape<FrustumF<TScalar>, TScalar>
    , IContainPoint<FrustumF<TScalar>, TScalar>
    , IIntersect<FrustumF<TScalar>, FrustumF<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<FrustumF<TScalar>, FrustumF<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    , IEquatable<FrustumF<TScalar>>
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{
    public PlaneF<TScaler> LeftPlane;
    public PlaneF<TScaler> RightPlane;
    public PlaneF<TScaler> TopPlane;
    public PlaneF<TScaler> BottomPlane;
    public PlaneF<TScaler> NearPlane;
    public PlaneF<TScaler> FarPlane;
}

```

```csharp
public static class Frustum
{
    public static FrustumF<TScalar> FromMatrix(Matrix4x4F<TScaler>)
        where TScalar : IBinaryFloatingPointIeee754<TScalar>
        => default;
}

```

# Meeting Agenda/Notes