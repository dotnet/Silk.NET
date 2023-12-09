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

`BoundingOrientedBox<T>` is defined with a quaternion as it's orientation. `Quaternion<T>` is constrained by the `IBinaryFloatingPointIeee754<T>` scalar type. Therefore all bounding shapes with be constrained by the `IBinaryFloatingPointIeee754<T>` scalar type.

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
    public static abstract void FromPoints(ReadOnlySpan<Vector3F<TScalar>> points, out TSelf result);
    public static abstract TSelf FromPoints(ReadOnlySpan<Vector3F<TScalar>> points);

    public static abstract void Merge(ref readonly TSelf value1, ref readonly TSelf value2, out TSelf result);

    public static abstract TSelf Merge(TSelf value1, TSelf value2);

    public static abstract void Transform(ref readonly TSelf value, ref readonly Matrix4x4F<TScalar> transform);
    public static abstract void Transform(ref readonly TSelf value, ref readonly Matrix4x4F<TScalar> transform, out TSelf result);
}
```

### BoundingBox

Access aligned box

```csharp
public struct BoundingBox<TScalar>
    : IEquatable<BoundingBox<TScalar>>
    , IEqualityOperators<BoundingBox<TScalar>, BoundingBox<TScalar>, bool>
    , IIntersectWithRay<BoundingBox<TScalar>, TScalar>
    , IIntersectWithPlane<BoundingBox<TScalar>, TScalar>
    , IColliderShape<BoundingBox<TScalar>, TScalar>
    , IContainPoint<BoundingBox<TScalar>, TScalar>
    , IIntersect<BoundingBox<TScalar>, BoundingBox<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<BoundingBox<TScalar>, BoundingBox<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    where TScalar: IBinaryFloatingPointIeee754<TScalar>
{

}
```

### BoundingBoxExtent

Access aligned box for fast frustum culling.

```csharp

```

### BoundingOrientedBox

Box with orientation

```csharp
public struct BoundingOrientedBox<TScalar>
    : IEquatable<BoundingOrientedBox<TScalar>>
    , IEqualityOperators<BoundingOrientedBox<TScalar>, BoundingOrientedBox<TScalar>, bool>
    , IIntersectWithRay<BoundingOrientedBox<TScalar>, TScalar>
    , IIntersectWithPlane<BoundingOrientedBox<TScalar>, TScalar>
    , IColliderShape<BoundingOrientedBox<TScalar>, TScalar>
    , IContainPoint<BoundingOrientedBox<TScalar>, TScalar>
    , IIntersect<BoundingOrientedBox<TScalar>, BoundingOrientedBox<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<BoundingOrientedBox<TScalar>, BoundingOrientedBox<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{

}
```

### BoundingFrustum

Frustum

```csharp

```

### BoundingSphere

Sphere

```csharp
public struct BoundingSphere<TScalar>
    : IEquatable<BoundingSphere<TScalar>>
    , IEqualityOperators<BoundingSphere<TScalar>, BoundingSphere<TScalar>, bool>
    , IIntersectWithRay<BoundingSphere<TScalar>, TScalar>
    , IIntersectWithPlane<BoundingSphere<TScalar>, TScalar>
    , IColliderShape<BoundingSphere<TScalar>, TScalar>
    , IContainPoint<BoundingSphere<TScalar>, TScalar>
    , IIntersect<BoundingSphere<TScalar>, BoundingSphere<TScalar>>
    //Implement IIntersect for other shapes
    , IContain<BoundingSphere<TScalar>, BoundingSphere<TScalar>>
    //Implement IContain for other shapes
    , IFormattable
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{

}
```

### CollisionHelper

```csharp

```