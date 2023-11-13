# Summary
A new API for generic maths in Silk.NET.Maths 3.X, leveraging modern .NET features such as `INumber<T>` and vectorization.

This API aims to replace the existing implementation of Silk.NET.Maths.

# Contributors
- Maxine H (@uwx)
- Andrew Davis (@Curin)

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal should replace the 2.X implementation of `Silk.Net.Maths`, matching `System.Numerics` where possible, with concessions for design oversights in that api.
- This proposal assumes no knowledge of the 2.x Math library.
- Text herein marked **INFORMATIVE** does not form a normative part of this proposal, and is for background only.
- Within this proposal, the key words **must**, **required**, **shall**, **should**, **recommended**, **may**, **could**, and **optional** are to be interpreted as described in [RFC 2119 - Key words for use in RFCs to Indicate Requirement Levels](https://www.ietf.org/rfc/rfc2119.txt). The additional key word **optionally** is an alternate form of **optional**, for use where grammatically appropriate. These key words are highlighted in the proposal for clarity.

# **INFORMATIVE** Integer and Floating Point Types
While investigating the use of generic math we came to the conclusion that making types which supports both integer and floating point types would not be optimal. This was discussed at length on the discord [here](https://discord.com/channels/521092042781229087/587346162802229298/1167705816812498974). Ultimately it was decided to provide both an integer and floating point variant for each vector type and every type built from them. These types are generic where `Vector2I<T>` will be a 2D vector which takes any binary integer type for `T`. Similarly `Vector2F<T>` will be a 2D vector which takes any floating point type for `T`. By extension we get types like `CubeI<T>` and `RectangleF<T>`. The integer types are granted the bitwise operators `&`, `~`, `|`, and `^`. Floating point types will include some operations that require certain functions unavailable to integer types like `Length` which requires `Sqrt`.

# Vector Types

The main types defined for this proposal are two sets of vector types, `VectorNI<T>` and `VectorNF<T>` where `N` defines the dimensionality of the vector between 2 and 5. Aside from some notable exceptions the vector types will be expected to implement a similar api to the correlating one below (`VectorNI<T>` will follow `Vector2I<T>` and the `VectorNF<T>` will follow `Vector2F<T>`).

Aside from the api below, the following constraints **must** also be followed:
- Three Dimensional Vectors **must** implement a Cross function which takes another vector and returns the cross product with our original vector. A static implementation of this function should be available as well.
- Every Dimension **must** have the relevant number of properties (X and Y for Vector2, and X,Y,Z,W,V for Vector5) and relevant unit vectors
- Constructors for higher dimensions **must** include lower dimension variants that use the lower dimensions for their specific components (vector2 -> X,Y)

```cs
public readonly record struct Vector2I<TScalar> : IEquatable<Vector2I<TScalar>>, 
                           IEquatable<Vector2>,
                           IBinaryIntegerVector<Vector2I<TScalar>, TScalar>,
                           IVector2<Vector2I<TScalar>, TScalar>
                           where TScalar : IBinaryInteger<TScalar>
{
    ///<summary>
    ///The X component of the Vector
    ///</summary>
    [DataMember]
    public TScalar X { get; }

    ///<summary>
    ///The Y component of the Vector
    ///</summary>
    [DataMember]
    public TScalar Y { get; }

    public static Vector2I<TScalar> UnitX { get; }
    public static Vector2I<TScalar> UnitY { get; }

    public static Vector2I<TScalar> Zero { get; }
    public static Vector2I<TScalar> One { get; }

    public TScalar this[int index] { get; }

    public Vector2I(TScalar x, TScalar y);
    public Vector2I(TScalar value);
    public Vector2I(ReadOnlySpan<TScalar> span);

    public Span<TScalar> AsSpan();

    public static Vector2I<TScalar> operator +(Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> operator -(Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> operator *(Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> operator /(Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> operator %(Vector2I<TScalar> left, Vector2I<TScalar> right);

    public static Vector2I<TScalar> operator *(Vector2I<TScalar> left, TScalar right);
    public static Vector2I<TScalar> operator /(Vector2I<TScalar> left, TScalar right);
    public static Vector2I<TScalar> operator %(Vector2I<TScalar> left, TScalar right);

    public static Vector2I<TScalar> operator *(TScalar left, Vector2I<TScalar> right);

    public static Vector2I<TScalar> operator +(Vector2I<TScalar> value);
    public static Vector2I<TScalar> operator -(Vector2I<TScalar> value);

    public static Vector2I<TScalar> operator &(Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> operator |(Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> operator ^(Vector2I<TScalar> left, Vector2I<TScalar> right);

    public static Vector2I<TScalar> operator ~(Vector2I<TScalar> value);

    public TScalar LengthSquared { get; }

    public Vector2I<TScalar> Dot(Vector2I<TScalar> other);
    public TScalar DistanceSquared(Vector2I<TScalar> other);
    public Vector2I<TScalar> Abs();
    public void CopyTo(TScalar[] array);
    public void CopyTo(TScalar[] array, int index);

    public static Vector2I<TScalar> Dot (Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> DistanceSquared (Vector2I<TScalar> left, Vector2I<TScalar> right);
    public static Vector2I<TScalar> Clamp (Vector2I<TScalar> value, Vector2I<TScalar> min, Vector2I<TScalar> max);
    public static Vector2I<TScalar> Min (Vector2I<TScalar> value1, Vector2I<TScalar> value2);
    public static Vector2I<TScalar> Max (Vector2I<TScalar> value1, Vector2I<TScalar> value2);
    public static Vector2I<TScalar> Abs (Vector2I<TScalar> value);
}
```

```cs
public readonly record struct Vector2F<TScalar> : IEquatable<Vector2F<TScalar>>, 
                           IEquatable<Vector2>,
                           IFloatingPointVector<Vector2F<TScalar>, TScalar>,
                           IVector2<Vector2F<TScalar>, TScalar>
                           where TScalar : IFloatingPointIeee754<TScalar>
{
    ///<summary>
    ///The X component of the Vector
    ///</summary>
    [DataMember]
    public TScalar X { get; }

    ///<summary>
    ///The Y component of the Vector
    ///</summary>
    [DataMember]
    public TScalar Y { get; }

    public static Vector2F<TScalar> UnitX { get; }
    public static Vector2F<TScalar> UnitY { get; }

    public static Vector2F<TScalar> Zero { get; }
    public static Vector2F<TScalar> One { get; }

    public TScalar this[int index] { get; }

    public Vector2F(TScalar x, TScalar y);
    public Vector2F(TScalar value);
    public Vector2F(ReadOnlySpan<TScalar> span);

    public Span<TScalar> AsSpan();

    public static Vector2F<TScalar> operator +(Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> operator -(Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> operator *(Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> operator /(Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> operator %(Vector2F<TScalar> left, Vector2F<TScalar> right);

    public static Vector2F<TScalar> operator *(Vector2F<TScalar> left, TScalar right);
    public static Vector2F<TScalar> operator /(Vector2F<TScalar> left, TScalar right);
    public static Vector2F<TScalar> operator %(Vector2F<TScalar> left, TScalar right);

    public static Vector2F<TScalar> operator *(TScalar left, Vector2F<TScalar> right);

    public static Vector2F<TScalar> operator +(Vector2F<TScalar> value);
    public static Vector2F<TScalar> operator -(Vector2F<TScalar> value);

    public TScalar LengthSquared { get; }
    public TScalar Length();

    public Vector2F<TScalar> Dot(Vector2F<TScalar> other);
    public TScalar DistanceSquared(Vector2F<TScalar> other);
    public TScalar Distance(Vector2F<TScalar> other);
    public Vector2F<TScalar> Abs();
    public void CopyTo(TScalar[] array);
    public void CopyTo(TScalar[] array, int index);

    public static Vector2F<TScalar> Dot (Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> DistanceSquared (Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> Distance (Vector2F<TScalar> left, Vector2F<TScalar> right);
    public static Vector2F<TScalar> Clamp (Vector2F<TScalar> value, Vector2F<TScalar> min, Vector2F<TScalar> max);
    public static Vector2F<TScalar> Min (Vector2F<TScalar> value1, Vector2F<TScalar> value2);
    public static Vector2F<TScalar> Max (Vector2F<TScalar> value1, Vector2F<TScalar> value2);
    public static Vector2F<TScalar> Abs (Vector2F<TScalar> value);
}
```
At the end of this proposal is the definition for the new interfaces used in the these classes.

# Matrix Types

This proposal includes the following matrix types:
- Matrix2x2F
- Matrix2x2I
- Matrix2x3F
- Matrix2x3I
- Matrix2x4F
- Matrix2x4I
- Matrix3x2F
- Matrix3x2I
- Matrix3x3F
- Matrix3x3I
- Matrix3x4F
- Matrix3x4I
- Matrix4x2F
- Matrix4x2I
- Matrix4x3F
- Matrix4x3I
- Matrix4x4F
- Matrix4x4I
- Matrix5x4F
- Matrix5x4I

Integer Variants do not require any functions which interact with Quaternions

Matricies **must** fulfill the following requirements:
- be a struct
- Stored in row major format
- F matricies work with F vectors, and I Matricies work with I vectors
- Both column and row vectors and individual values accessible via properties
- An indexer that takes row and column indicies and outputs the value
- Add, subtract, and multiply operators defined with Matricies of the same size
- Multiply operators defined with compatible matricies, if the output matrix type already exists (AxB * BxC = AxC)
- Multiply operator defined with the appropriate Vector type (vector4F * Matrix4x4F is valid)
  - **optionally**, include multiplication operators for Vector types smaller than the appropriate type, assuming 1 for the missing dimensions (vector2F * Matrix4x4F -> (Vector2F.x, Vector2F.y, 1, 1) * Matrix4x4F)
- Negate Operator defined
- Fulfills `IEquatable<T>` where `T` is the same matrix class and the System.Numerics version of the matrix if available
- Implicit conversion to and from the System.Numerics matrix type, if available
- Invert function for square matricies
- GetDeterminant function for square matricies and Matrix3x2
- Transpose function
- static lerp function
- static identity property
- For Matrix3x2, Matrix3x3, Matrix4x3, and Matrix4x4 include the following static functions
  - CreateBillboard
  - CreateRotation
    - 3x3, 4x3, and 4x4 Matricies get X, Y, and Z variants for this function instead
  - CreateTranslation
  - CreateScale
  - Decompose (separate out any transformations)
- For Matrix3x2 include a CreateSkew static function
- For Matrix3x3, Matrix4x3, and Matrix4x4 include the following static functions
  - CreateFromAxisAngle
  - CreateFromQuaternion
  - Transform
    - from a Quaternion
  - CreateFromYawPitchRoll
- For Matrix4x3 and Matrix4x4 include the following static functions
  - CreateConstrainedBillboard
  - CreateLookAt
  - CreateOrthographic
  - CreateOrthographicOffCenter
  - CreatePerspective
  - CreatePerspectiveFieldOfView
  - CreatePerspectiveOffCenter
  - CreateReflection
  - CreateWorld

# Quaternion

Quaternion is required only to fulfill the following api:

```cs
[StructLayout(LayoutKind.Sequential), DataContract, Serializable]
public readonly struct Quaternion<T> : IEquatable<Quaternion<T>>
    where T : INumberBase<T>, ITrigonometricFunctions<T>, IRootFunctions<T>
{
    /// <summary>The X value of the vector component of the quaternion.</summary>
    [DataMember]
    public readonly T X { get; }

    /// <summary>The Y value of the vector component of the quaternion.</summary>
    [DataMember]
    public readonly T Y { get; }

    /// <summary>The Z value of the vector component of the quaternion.</summary>
    [DataMember]
    public readonly T Z { get; }

    /// <summary>The rotation component of the quaternion.</summary>
    [DataMember]
    public readonly T W { get; }
    
    public ReadOnlySpan<T> Components { get; }

    /// <summary>Constructs a quaternion from the specified components.</summary>
    /// <param name="x">The value to assign to the X component of the quaternion.</param>
    /// <param name="y">The value to assign to the Y component of the quaternion.</param>
    /// <param name="z">The value to assign to the Z component of the quaternion.</param>
    /// <param name="w">The value to assign to the W component of the quaternion.</param>
    public Quaternion(T x, T y, T z, T w);

    /// <summary>Creates a quaternion from the specified vector and rotation parts.</summary>
    /// <param name="vectorPart">The vector part of the quaternion.</param>
    /// <param name="scalarPart">The rotation part of the quaternion.</param>
    public Quaternion(Vector3D<T> vectorPart, T scalarPart);

    /// <summary>Gets a quaternion that represents a zero.</summary>
    /// <value>A quaternion whose values are <c>(0, 0, 0, 0)</c>.</value>
    public static Quaternion<T> Zero { get; }

    /// <summary>Gets a quaternion that represents no rotation.</summary>
    /// <value>A quaternion whose values are <c>(0, 0, 0, 1)</c>.</value>
    public static Quaternion<T> Identity { get; }

    /// <summary>Gets or sets the element at the specified index.</summary>
    /// <param name="index">The index of the element to get or set.</param>
    /// <returns>The element at <paramref name="index" />.</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="index" /> was less than zero or greater than the number of elements.</exception>
    public T this[int index];

    /// <summary>Gets a value that indicates whether the current instance is the identity quaternion.</summary>
    /// <value><see langword="true" /> if the current instance is the identity quaternion; otherwise, <see langword="false" />.</value>
    /// <altmember cref="Identity"/>
    public bool IsIdentity { get; }

    /// <summary>Adds each element in one quaternion with its corresponding element in a second quaternion.</summary>
    /// <param name="value1">The first quaternion.</param>
    /// <param name="value2">The second quaternion.</param>
    /// <returns>The quaternion that contains the summed values of <paramref name="value1" /> and <paramref name="value2" />.</returns>
    /// <remarks>The <see cref="op_Addition" /> method defines the operation of the addition operator for <see cref="Quaternion" /> objects.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> operator +(Quaternion<T> value1, Quaternion<T> value2);

    /// <summary>Divides one quaternion by a second quaternion.</summary>
    /// <param name="value1">The dividend.</param>
    /// <param name="value2">The divisor.</param>
    /// <returns>The quaternion that results from dividing <paramref name="value1" /> by <paramref name="value2" />.</returns>
    /// <remarks>The <see cref="op_Division" /> method defines the division operation for <see cref="Quaternion" /> objects.</remarks>
    public static Quaternion<T> operator /(Quaternion<T> value1, Quaternion<T> value2);

    /// <summary>Returns a value that indicates whether two quaternions are equal.</summary>
    /// <param name="value1">The first quaternion to compare.</param>
    /// <param name="value2">The second quaternion to compare.</param>
    /// <returns><see langword="true" /> if the two quaternions are equal; otherwise, <see langword="false" />.</returns>
    /// <remarks>Two quaternions are equal if each of their corresponding components is equal.
    /// The <see cref="op_Equality" /> method defines the operation of the equality operator for <see cref="Quaternion" /> objects.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Quaternion<T> value1, Quaternion<T> value2);

    /// <summary>Returns a value that indicates whether two quaternions are not equal.</summary>
    /// <param name="value1">The first quaternion to compare.</param>
    /// <param name="value2">The second quaternion to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="value1" /> and <paramref name="value2" /> are not equal; otherwise, <see langword="false" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Quaternion<T> value1, Quaternion<T> value2);

    /// <summary>Returns the quaternion that results from multiplying two quaternions together.</summary>
    /// <param name="value1">The first quaternion.</param>
    /// <param name="value2">The second quaternion.</param>
    /// <returns>The product quaternion.</returns>
    /// <remarks>The <see cref="Quaternion.op_Multiply" /> method defines the operation of the multiplication operator for <see cref="Quaternion" /> objects.</remarks>
    public static Quaternion<T> operator *(Quaternion<T> value1, Quaternion<T> value2);

    /// <summary>Returns the quaternion that results from scaling all the components of a specified quaternion by a scalar factor.</summary>
    /// <param name="value1">The source quaternion.</param>
    /// <param name="value2">The scalar value.</param>
    /// <returns>The scaled quaternion.</returns>
    /// <remarks>The <see cref="Quaternion.op_Multiply" /> method defines the operation of the multiplication operator for <see cref="Quaternion" /> objects.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> operator *(Quaternion<T> value1, T value2);

    /// <summary>Subtracts each element in a second quaternion from its corresponding element in a first quaternion.</summary>
    /// <param name="value1">The first quaternion.</param>
    /// <param name="value2">The second quaternion.</param>
    /// <returns>The quaternion containing the values that result from subtracting each element in <paramref name="value2" /> from its corresponding element in <paramref name="value1" />.</returns>
    /// <remarks>The <see cref="op_Subtraction" /> method defines the operation of the subtraction operator for <see cref="Quaternion" /> objects.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> operator -(Quaternion<T> value1, Quaternion<T> value2);

    /// <summary>Reverses the sign of each component of the quaternion.</summary>
    /// <param name="value">The quaternion to negate.</param>
    /// <returns>The negated quaternion.</returns>
    /// <remarks>The <see cref="op_UnaryNegation" /> method defines the operation of the unary negation operator for <see cref="Quaternion" /> objects.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> operator -(Quaternion<T> value);

    /// <summary>Adds each element in one quaternion with its corresponding element in a second quaternion.</summary>
    /// <param name="value1">The first quaternion.</param>
    /// <param name="value2">The second quaternion.</param>
    /// <returns>The quaternion that contains the summed values of <paramref name="value1" /> and <paramref name="value2" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Add<T>(Quaternion<T> value1, Quaternion<T> value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Concatenates two quaternions.</summary>
    /// <param name="value1">The first quaternion rotation in the series.</param>
    /// <param name="value2">The second quaternion rotation in the series.</param>
    /// <returns>A new quaternion representing the concatenation of the <paramref name="value1" /> rotation followed by the <paramref name="value2" /> rotation.</returns>
    public static Quaternion<T> Concatenate<T>(Quaternion<T> value1, Quaternion<T> value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Returns the conjugate of a specified quaternion.</summary>
    /// <param name="value">The quaternion.</param>
    /// <returns>A new quaternion that is the conjugate of <see langword="value" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Conjugate<T>(Quaternion<T> value)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Creates a quaternion from a unit vector and an angle to rotate around the vector.</summary>
    /// <param name="axis">The unit vector to rotate around.</param>
    /// <param name="angle">The angle, in radians, to rotate around the vector.</param>
    /// <returns>The newly created quaternion.</returns>
    /// <remarks><paramref name="axis" /> vector must be normalized before calling this method or the resulting <see cref="Quaternion{T}" /> will be incorrect.</remarks>
    public static Quaternion<T> CreateFromAxisAngle<T>(Vector3DF<T> axis, T angle)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Creates a quaternion from the specified rotation matrix.</summary>
    /// <param name="matrix">The rotation matrix.</param>
    /// <returns>The newly created quaternion.</returns>
    public static Quaternion<T> CreateFromRotationMatrix<T>(Matrix4X4F<T> matrix)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>, IComparisonOperators<T, T, bool>;

    /// <summary>Creates a new quaternion from the given yaw, pitch, and roll.</summary>
    /// <param name="yaw">The yaw angle, in radians, around the Y axis.</param>
    /// <param name="pitch">The pitch angle, in radians, around the X axis.</param>
    /// <param name="roll">The roll angle, in radians, around the Z axis.</param>
    /// <returns>The resulting quaternion.</returns>
    public static Quaternion<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Divides one quaternion by a second quaternion.</summary>
    /// <param name="value1">The dividend.</param>
    /// <param name="value2">The divisor.</param>
    /// <returns>The quaternion that results from dividing <paramref name="value1" /> by <paramref name="value2" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Divide<T>(Quaternion<T> value1, Quaternion<T> value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Divides the specified quaternion by a specified scalar value.</summary>
    /// <param name="left">The quaternion.</param>
    /// <param name="divisor">The scalar value.</param>
    /// <returns>The quaternion that results from the division.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Quaternion<T> Divide<T>(Quaternion<T> left, T divisor)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Calculates the dot product of two quaternions.</summary>
    /// <param name="quaternion1">The first quaternion.</param>
    /// <param name="quaternion2">The second quaternion.</param>
    /// <returns>The dot product.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Dot<T>(Quaternion<T> quaternion1, Quaternion<T> quaternion2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Returns the inverse of a quaternion.</summary>
    /// <param name="value">The quaternion.</param>
    /// <returns>The inverted quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Inverse<T>(Quaternion<T> value)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Performs a linear interpolation between two quaternions based on a value that specifies the weighting of the second quaternion.</summary>
    /// <param name="quaternion1">The first quaternion.</param>
    /// <param name="quaternion2">The second quaternion.</param>
    /// <param name="amount">The relative weight of <paramref name="quaternion2" /> in the interpolation.</param>
    /// <returns>The interpolated quaternion.</returns>
    public static Quaternion<T> Lerp<T>(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>, IComparisonOperators<T, T, bool>;

    /// <summary>Returns the quaternion that results from multiplying two quaternions together.</summary>
    /// <param name="value1">The first quaternion.</param>
    /// <param name="value2">The second quaternion.</param>
    /// <returns>The product quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Multiply<T>(Quaternion<T> value1, Quaternion<T> value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Returns a new quaternion whose values are the product of each pair of elements in specified quaternion and vector.</summary>
    /// <param name="value1">The quaternion.</param>
    /// <param name="value2">The vector.</param>
    /// <returns>The element-wise product vector.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Quaternion<T> Multiply<T>(Quaternion<T> value1, Vector4DF<T> value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Returns the quaternion that results from scaling all the components of a specified quaternion by a scalar factor.</summary>
    /// <param name="value1">The source quaternion.</param>
    /// <param name="value2">The scalar value.</param>
    /// <returns>The scaled quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Multiply<T>(Quaternion<T> value1, T value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Reverses the sign of each component of the quaternion.</summary>
    /// <param name="value">The quaternion to negate.</param>
    /// <returns>The negated quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Negate<T>(Quaternion<T> value)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Divides each component of a specified <see cref="Quaternion{T}" /> by its length.</summary>
    /// <param name="value">The quaternion to normalize.</param>
    /// <returns>The normalized quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Normalize<T>(Quaternion<T> value)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Interpolates between two quaternions, using spherical linear interpolation.</summary>
    /// <param name="quaternion1">The first quaternion.</param>
    /// <param name="quaternion2">The second quaternion.</param>
    /// <param name="amount">The relative weight of the second quaternion in the interpolation.</param>
    /// <returns>The interpolated quaternion.</returns>
    public static Quaternion<T> Slerp<T>(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>, IComparisonOperators<T, T, bool>;

    /// <summary>Subtracts each element in a second quaternion from its corresponding element in a first quaternion.</summary>
    /// <param name="value1">The first quaternion.</param>
    /// <param name="value2">The second quaternion.</param>
    /// <returns>The quaternion containing the values that result from subtracting each element in <paramref name="value2" /> from its corresponding element in <paramref name="value1" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion<T> Subtract<T>(Quaternion<T> value1, Quaternion<T> value2)
        where T : IRootFunctions<T>, ITrigonometricFunctions<T>;
    
    /// <summary>Calculates the length of the quaternion.</summary>
    /// <returns>The computed length of the quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Length<T>(this Quaternion<T> self) where T : IRootFunctions<T>, ITrigonometricFunctions<T>;

    /// <summary>Calculates the squared length of the quaternion.</summary>
    /// <returns>The length squared of the quaternion.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T LengthSquared<T>(this Quaternion<T> self) where T : IRootFunctions<T>, ITrigonometricFunctions<T>;
}
```

# Geometric Types

The following Geometric Types are defined:
- Box2F
- Box2I
- Box3F
- Box3I
- CircleF
- CircleI
- CubeF
- CubeI
- PlaneF
- PlaneI
- Ray2F
- Ray2I
- Ray3F
- Ray3I
- RectangleF
- RectangleI
- SphereF
- SphereI

The Box structs are defined by Min and Max Vectors, while Rectangle and Cube are defined by Origin and Size Vectors. These Types **must** be implicitly castable between each other.

Each type **must** include the following:
- Intersect functions with both another instance of the type and a point
- GetDistanceToNearest(Point,Edge,etc) functions **must** be available for a given point
- For all but the rays and planes, GetInflated function that takes a point and returns the scaled object that is closest to the original and contains the given point
- Include Scale and Translation transformation functions
- For Planes and Rays, Normalize functions
- For Planes include the following static functions
  - CreateFromVerticies
  - Dot
    - with a Vector4
  - DotCoordinate and DotNormal
    - with a Vector3
  - Transform
    - With a Matrix4x4 or Quaternion, if relevant

# Vector Interface Definitions

The following interfaces are defined for Vectors:

```cs
public interface IVector
{
    /// <summary>
    /// The type of scalars in this vector type.
    /// </summary>
    protected static abstract Type ScalarType { get; }
    
    /// <summary>
    /// The amount of scalars in this vector type.
    /// </summary>
    protected internal static abstract int Count { get; }
}

public interface IVectorEquatable<TVector, TScalar>
    : IEquatable<TVector>
    where TVector : IVector<TVector, TScalar>
    where TScalar : INumberBase<TScalar>
{
    public TVector ScalarsEqual(TVector other);
}

public interface IVector<TVector, TScalar> :
    IVector,
    IAdditionOperators<TVector, TVector, TVector>,
    IAdditiveIdentity<TVector, TVector>,
    IDecrementOperators<TVector>,
    IDivisionOperators<TVector, TVector, TVector>,
    IEqualityOperators<TVector, TVector, bool>,
    IIncrementOperators<TVector>,
    IMultiplicativeIdentity<TVector, TVector>,
    IMultiplyOperators<TVector, TVector, TVector>,
    ISpanFormattable,
    ISpanParsable<TVector>,
    ISubtractionOperators<TVector, TVector, TVector>,
    IUnaryPlusOperators<TVector, TVector>,
    IUnaryNegationOperators<TVector, TVector>,
    IUtf8SpanFormattable,
    IUtf8SpanParsable<TVector>,
    IReadOnlyList<TScalar>,
    IVectorEquatable<TVector, TScalar>
    where TVector : IVector<TVector, TScalar>
    where TScalar : INumberBase<TScalar>
{
    static Type IVector.ScalarType => typeof(TScalar);

    static virtual TVector Zero => TVector.Create(TScalar.Zero);

    static virtual TVector One => TVector.Create(TScalar.One);

    int IReadOnlyCollection<TScalar>.Count => TVector.Count;

    TScalar IReadOnlyList<TScalar>.this[int index];
    
    public new TScalar this[int index];
    
    static abstract ReadOnlySpan<TScalar> AsSpan(TVector vec);

    static TVector IAdditiveIdentity<TVector, TVector>.AdditiveIdentity => TVector.Zero;
    static TVector IMultiplicativeIdentity<TVector, TVector>.MultiplicativeIdentity => TVector.One;

    static TVector IDecrementOperators<TVector>.operator --(TVector value) => value - TVector.One;
    static TVector IIncrementOperators<TVector>.operator ++(TVector value) => value + TVector.One;

    static TVector IDecrementOperators<TVector>.operator checked --(TVector value) => value - TVector.One;
    static TVector IIncrementOperators<TVector>.operator checked ++(TVector value) => value + TVector.One;

    static TVector IUnaryPlusOperators<TVector, TVector>.operator +(TVector value) => value;

    /// <summary>Divides two values together to compute their quotient.</summary>
    /// <param name="left">The value which <paramref name="right" /> divides.</param>
    /// <param name="right">The value which divides <paramref name="left" />.</param>
    /// <returns>The quotient of <paramref name="left" /> divided-by <paramref name="right" />.</returns>
    static abstract TVector operator /(TVector left, TScalar right);

    /// <summary>Divides two values together to compute their quotient.</summary>
    /// <param name="left">The value which <paramref name="right" /> divides.</param>
    /// <param name="right">The value which divides <paramref name="left" />.</param>
    /// <returns>The quotient of <paramref name="left" /> divided-by <paramref name="right" />.</returns>
    /// <exception cref="OverflowException">The quotient of <paramref name="left" /> divided-by <paramref name="right" /> is not representable by <typeparamref name="TVector" />.</exception>
    static virtual TVector operator checked /(TVector left, TScalar right) => left / right;

    /// <summary>Multiplies two values together to compute their product.</summary>
    /// <param name="left">The value which <paramref name="right" /> multiplies.</param>
    /// <param name="right">The value which multiplies <paramref name="left" />.</param>
    /// <returns>The product of <paramref name="left" /> multiplied-by <paramref name="right" />.</returns>
    static abstract TVector operator *(TVector left, TScalar right);

    /// <summary>Multiplies two values together to compute their product.</summary>
    /// <param name="left">The value which <paramref name="right" /> multiplies.</param>
    /// <param name="right">The value which multiplies <paramref name="left" />.</param>
    /// <returns>The product of <paramref name="left" /> multiplied-by <paramref name="right" />.</returns>
    /// <exception cref="OverflowException">The product of <paramref name="left" /> multiplied-by <paramref name="right" /> is not representable by <typeparamref name="TVector" />.</exception>
    static virtual TVector operator checked *(TVector left, TScalar right) => left * right;

    /// <summary>Multiplies two values together to compute their product.</summary>
    /// <param name="right">The value which <paramref name="left1" /> multiplies.</param>
    /// <param name="left1">The value which multiplies <paramref name="right" />.</param>
    /// <returns>The product of <paramref name="right" /> multiplied-by <paramref name="left1" />.</returns>
    static virtual TVector operator *(TScalar left1, TVector right) => right * left1;

    /// <summary>Multiplies two values together to compute their product.</summary>
    /// <param name="right">The value which <paramref name="left" /> multiplies.</param>
    /// <param name="left">The value which multiplies <paramref name="right" />.</param>
    /// <returns>The product of <paramref name="right" /> multiplied-by <paramref name="left" />.</returns>
    /// <exception cref="OverflowException">The product of <paramref name="right" /> multiplied-by <paramref name="left" /> is not representable by <typeparamref name="TVector" />.</exception>
    static virtual TVector operator checked *(TScalar left, TVector right) => right * left;

    /// <summary>Returns the string representation of the current instance using the specified format string to format individual elements.</summary>
    /// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using <paramref name="format" /> and the current culture's formatting conventions. The "&lt;" and "&gt;" characters are used to begin and end the string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    /// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">Standard Numeric Format Strings</related>
    /// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings</related>
    public string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format) => ToString(format, null);

    static abstract TVector Create(TScalar scalar);
    static abstract TVector Create(ReadOnlySpan<TScalar> values);

    static abstract TVector GetUnitVector(uint dimension);

    TScalar LengthSquared();
    static virtual TVector Multiply(TVector left, TVector right) => left * right;
    static virtual TVector Multiply(TVector left, TScalar right) => left * right;
    static virtual TVector Multiply(TScalar left, TVector right) => left * right;
    static virtual TVector Negate(TVector value) => -value;
    static virtual TVector Subtract(TVector left, TVector right) => left - right;
    static virtual TVector Add(TVector left, TVector right) => left + right;
    static virtual TVector Divide(TVector left, TVector right) => left / right;
    static virtual TVector Divide(TVector left, TScalar divisor) => left / divisor;
    static virtual TVector Clamp(TVector value1, TScalar min, TScalar max) => TVector.Clamp(value1, TVector.Create(min), TVector.Create(max));
    static abstract TVector Clamp(TVector value1, TVector min, TVector max);
    static abstract TScalar DistanceSquared(TVector value1, TVector value2);
    static abstract TScalar Dot(TVector vector1, TVector vector2);
    static abstract TVector Max(TVector value1, TVector value2);
    static abstract TVector Min(TVector value1, TVector value2);
    static virtual TVector Max(TVector value1, TScalar value2) => TVector.Max(value1, TVector.Create(value2));
    static virtual TVector Min(TVector value1, TScalar value2) => TVector.Min(value1, TVector.Create(value2));
    static abstract TVector Abs(TVector value);
    
    /// <summary>Copies the elements of the vector to a specified array.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="array">The destination array.</param>
    /// <remarks><paramref name="array" /> must have enough elements to fit all scalars in this vector. The method copies the vector's elements starting at index 0.</remarks>
    /// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
    /// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
    static abstract void CopyTo(TVector vector, TScalar[] array);

    /// <summary>Copies the elements of the vector to a specified array starting at a specified index position.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="array">The destination array.</param>
    /// <param name="index">The index at which to copy the first element of the vector.</param>
    /// <remarks><paramref name="array" /> must have a sufficient number of elements to accommodate the vector elements. In other words, elements <paramref name="index" /> through <paramref name="index" /> + 2 must already exist in <paramref name="array" />.</remarks>
    /// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.
    /// -or-
    /// <paramref name="index" /> is greater than or equal to the array length.</exception>
    /// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
    static abstract void CopyTo(TVector vector, TScalar[] array, int index);

    /// <summary>Copies the vector to the given <see cref="Span{TScalar}" />. The length of the destination span must be at least enough to fit all scalars in this vector.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination span.</exception>
    static abstract void CopyTo(TVector vector, Span<TScalar> destination);

    /// <summary>Attempts to copy the vector to the given <see cref="Span{Single}" />. The length of the destination span must be at least enough to fit all scalars in this vector.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <returns><see langword="true" /> if the source vector was successfully copied to <paramref name="destination" />. <see langword="false" /> if <paramref name="destination" /> is not large enough to hold the source vector.</returns>
    static abstract bool TryCopyTo(TVector vector, Span<TScalar> destination);

    #region Conversion

    /// <summary>Creates an instance of the current type from a value, throwing an overflow exception for any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type of <paramref name="value" />.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TVector" />.</param>
    /// <returns>An instance of <typeparamref name="TVector" /> created from <paramref name="value" />.</returns>
    /// <exception cref="NotSupportedException"><typeparamref name="TOther" /> is not supported.</exception>
    /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <typeparamref name="TVector" />.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static virtual TVector CreateChecked<TOther, TOtherScalar>(TOther value)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Creates an instance of the current type from a value, saturating any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type of <paramref name="value" />.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TVector" />.</param>
    /// <returns>An instance of <typeparamref name="TVector" /> created from <paramref name="value" />, saturating if <paramref name="value" /> falls outside the representable range of <typeparamref name="TVector" />.</returns>
    /// <exception cref="NotSupportedException"><typeparamref name="TOther" /> is not supported.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static virtual TVector CreateSaturating<TOther, TOtherScalar>(TOther value)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Creates an instance of the current type from a value, truncating any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type of <paramref name="value" />.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TVector" />.</param>
    /// <returns>An instance of <typeparamref name="TVector" /> created from <paramref name="value" />, truncating if <paramref name="value" /> falls outside the representable range of <typeparamref name="TVector" />.</returns>
    /// <exception cref="NotSupportedException"><typeparamref name="TOther" /> is not supported.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static virtual TVector CreateTruncating<TOther, TOtherScalar>(TOther value)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore
	
    /// <summary>Tries to convert a value to an instance of the current type, throwing an overflow exception for any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type of <paramref name="value" />.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TVector" />.</param>
    /// <param name="result">On return, contains an instance of <typeparamref name="TVector" /> converted from <paramref name="value" />.</param>
    /// <returns><c>false</c> if <typeparamref name="TOther" /> is not supported; otherwise, <c>true</c>.</returns>
    /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <typeparamref name="TVector" />.</exception>
    protected static abstract bool TryConvertFromChecked<TOther, TOtherScalar>(TOther value, [MaybeNullWhen(false)] out TVector result)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Tries to convert a value to an instance of the current type, saturating any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type of <paramref name="value" />.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TVector" />.</param>
    /// <param name="result">On return, contains an instance of <typeparamref name="TVector" /> converted from <paramref name="value" />.</param>
    /// <returns><c>false</c> if <typeparamref name="TOther" /> is not supported; otherwise, <c>true</c>.</returns>
    protected static abstract bool TryConvertFromSaturating<TOther, TOtherScalar>(TOther value, [MaybeNullWhen(false)] out TVector result)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Tries to convert a value to an instance of the current type, truncating any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type of <paramref name="value" />.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TVector" />.</param>
    /// <param name="result">On return, contains an instance of <typeparamref name="TVector" /> converted from <paramref name="value" />.</param>
    /// <returns><c>false</c> if <typeparamref name="TOther" /> is not supported; otherwise, <c>true</c>.</returns>
    protected static abstract bool TryConvertFromTruncating<TOther, TOtherScalar>(TOther value, [MaybeNullWhen(false)] out TVector result)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Tries to convert an instance of the current type to another type, throwing an overflow exception for any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type to which <paramref name="value" /> should be converted.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TOther" />.</param>
    /// <param name="result">On return, contains an instance of <typeparamref name="TOther" /> converted from <paramref name="value" />.</param>
    /// <returns><c>false</c> if <typeparamref name="TOther" /> is not supported; otherwise, <c>true</c>.</returns>
    /// <exception cref="OverflowException"><paramref name="value" /> is not representable by <typeparamref name="TOther" />.</exception>
    protected static abstract bool TryConvertToChecked<TOther, TOtherScalar>(TVector value, [MaybeNullWhen(false)] out TOther result)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Tries to convert an instance of the current type to another type, saturating any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type to which <paramref name="value" /> should be converted.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TOther" />.</param>
    /// <param name="result">On return, contains an instance of <typeparamref name="TOther" /> converted from <paramref name="value" />.</param>
    /// <returns><c>false</c> if <typeparamref name="TOther" /> is not supported; otherwise, <c>true</c>.</returns>
    protected static abstract bool TryConvertToSaturating<TOther, TOtherScalar>(TVector value, [MaybeNullWhen(false)] out TOther result)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore

    /// <summary>Tries to convert an instance of the current type to another type, truncating any values that fall outside the representable range of the current type.</summary>
    /// <typeparam name="TOther">The type to which <paramref name="value" /> should be converted.</typeparam>
    /// <param name="value">The value which is used to create the instance of <typeparamref name="TOther" />.</param>
    /// <param name="result">On return, contains an instance of <typeparamref name="TOther" /> converted from <paramref name="value" />.</param>
    /// <returns><c>false</c> if <typeparamref name="TOther" /> is not supported; otherwise, <c>true</c>.</returns>
    protected static abstract bool TryConvertToTruncating<TOther, TOtherScalar>(TVector value, [MaybeNullWhen(false)] out TOther result)
#nullable disable
        where TOther : IVector<TOther, TOtherScalar> where TOtherScalar : INumberBase<TOtherScalar>;
#nullable restore


    #endregion
}

public interface IModulusVector<TVector, TScalar> :
    IVector<TVector, TScalar>,
    IModulusOperators<TVector, TVector, TVector>
    where TVector : IModulusVector<TVector, TScalar>
    where TScalar : INumberBase<TScalar>, IModulusOperators<TScalar, TScalar, TScalar>
{
    static abstract TVector operator %(TVector left, TScalar right);

    static virtual TVector Remainder(TVector left, TVector right) => left % right;
    static virtual TVector Remainder(TVector left, TScalar right) => left % right;
}

public interface INumberVector<TVector, TScalar> :
    IModulusVector<TVector, TScalar>
    where TVector : INumberVector<TVector, TScalar>
    where TScalar : INumber<TScalar>
{
    static abstract TVector CopySign(TVector value, TVector sign);
    static abstract TVector CopySign(TVector value, TScalar sign);

    static abstract TVector Sign(TVector value);
}

public interface IBinaryNumberVector<TVector, TScalar> :
    INumberVector<TVector, TScalar>,
    IBitwiseOperators<TVector, TVector, TVector>
    where TVector : IBinaryNumberVector<TVector, TScalar>
    where TScalar : IBinaryNumber<TScalar>
{
    static virtual TVector AllBitsSet => TVector.Create(TScalar.AllBitsSet);
    
    /// <summary>Computes the log2 of a value.</summary>
    /// <param name="value">The value whose log2 is to be computed.</param>
    /// <returns>The log2 of <paramref name="value" />.</returns>
    static abstract TVector Log2(TVector value);
}

public interface IBinaryIntegerVector<TVector, TScalar> :
    IBinaryNumberVector<TVector, TScalar>
    where TVector : IBinaryIntegerVector<TVector, TScalar>
    where TScalar : IBinaryInteger<TScalar>
{
    /// <summary>Computes the quotient and remainder of two values.</summary>
    /// <param name="left">The value which <paramref name="right" /> divides.</param>
    /// <param name="right">The value which divides <paramref name="left" />.</param>
    /// <returns>The quotient and remainder of <paramref name="left" /> divided-by <paramref name="right" />.</returns>
    static virtual (TVector Quotient, TVector Remainder) DivRem(TVector left, TVector right);

    /// <summary>Computes the number of bits that are set in a value.</summary>
    /// <param name="value">The value whose set bits are to be counted.</param>
    /// <returns>The number of set bits in <paramref name="value" />.</returns>
    static abstract TVector PopCount(TVector value);

    /// <summary>Tries to read a two's complement number from a span, in big-endian format, and convert it to an instance of the current type.</summary>
    /// <param name="source">The span from which the two's complement number should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <param name="value">On return, contains the value read from <paramref name="source" /> or <c>default</c> if a value could not be read.</param>
    /// <returns><c>true</c> if the value was succesfully read from <paramref name="source" />; otherwise, <c>false</c>.</returns>
    static abstract bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, [MaybeNullWhen(false)] out TVector value);

    /// <summary>Tries to read a two's complement number from a span, in little-endian format, and convert it to an instance of the current type.</summary>
    /// <param name="source">The span from which the two's complement number should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <param name="value">On return, contains the value read from <paramref name="source" /> or <c>default</c> if a value could not be read.</param>
    /// <returns><c>true</c> if the value was succesfully read from <paramref name="source" />; otherwise, <c>false</c>.</returns>
    static abstract bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, [MaybeNullWhen(false)] out TVector value);

    /// <summary>Reads a two's complement number from a given array, in big-endian format, and converts it to an instance of the current type.</summary>
    /// <param name="source">The array from which the two's complement number should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <returns>The value read from <paramref name="source" />.</returns>
    /// <exception cref="OverflowException"><paramref name="source" /> is not representable by <typeparamref name="TVector" /></exception>
    static virtual TVector ReadBigEndian(byte[] source, bool isUnsigned);

    /// <summary>Reads a two's complement number from a given array, in big-endian format, and converts it to an instance of the current type.</summary>
    /// <param name="source">The array from which the two's complement number should be read.</param>
    /// <param name="startIndex">The starting index from which the value should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <returns>The value read from <paramref name="source" /> starting at <paramref name="startIndex" />.</returns>
    /// <exception cref="OverflowException"><paramref name="source" /> is not representable by <typeparamref name="TVector" /></exception>
    static virtual TVector ReadBigEndian(byte[] source, int startIndex, bool isUnsigned);

    /// <summary>Reads a two's complement number from a given span, in big-endian format, and converts it to an instance of the current type.</summary>
    /// <param name="source">The array from which the two's complement number should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <returns>The value read from <paramref name="source" />.</returns>
    /// <exception cref="OverflowException"><paramref name="source" /> is not representable by <typeparamref name="TVector" /></exception>
    static virtual TVector ReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned);

    /// <summary>Reads a two's complement number from a given array, in little-endian format, and converts it to an instance of the current type.</summary>
    /// <param name="source">The array from which the two's complement number should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <returns>The value read from <paramref name="source" />.</returns>
    /// <exception cref="OverflowException"><paramref name="source" /> is not representable by <typeparamref name="TVector" /></exception>
    static virtual TVector ReadLittleEndian(byte[] source, bool isUnsigned);

    /// <summary>Reads a two's complement number from a given array, in little-endian format, and converts it to an instance of the current type.</summary>
    /// <param name="source">The array from which the two's complement number should be read.</param>
    /// <param name="startIndex">The starting index from which the value should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <returns>The value read from <paramref name="source" /> starting at <paramref name="startIndex" />.</returns>
    /// <exception cref="OverflowException"><paramref name="source" /> is not representable by <typeparamref name="TVector" /></exception>
    static virtual TVector ReadLittleEndian(byte[] source, int startIndex, bool isUnsigned);

    /// <summary>Reads a two's complement number from a given span, in little-endian format, and converts it to an instance of the current type.</summary>
    /// <param name="source">The array from which the two's complement number should be read.</param>
    /// <param name="isUnsigned"><c>true</c> if <paramref name="source" /> represents an unsigned two's complement number; otherwise, <c>false</c> to indicate it represents a signed two's complement number.</param>
    /// <returns>The value read from <paramref name="source" />.</returns>
    /// <exception cref="OverflowException"><paramref name="source" /> is not representable by <typeparamref name="TVector" /></exception>
    static virtual TVector ReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned);

    /// <summary>Gets the number of bytes that will be written as part of <see cref="TryWriteLittleEndian(Span{byte}, out int)" />.</summary>
    /// <returns>The number of bytes that will be written as part of <see cref="TryWriteLittleEndian(Span{byte}, out int)" />.</returns>
    int GetByteCount();

    /// <summary>Gets the length, in bits, of the shortest two's complement representation of the current value.</summary>
    /// <returns>The length, in bits, of the shortest two's complement representation of the current value.</returns>
    int GetShortestBitLength() => GetByteCount() * 8;

    /// <summary>Tries to write the current value, in big-endian format, to a given span.</summary>
    /// <param name="destination">The span to which the current value should be written.</param>
    /// <param name="bytesWritten">The number of bytes written to <paramref name="destination" />.</param>
    /// <returns><c>true</c> if the value was successfully written to <paramref name="destination" />; otherwise, <c>false</c>.</returns>
    bool TryWriteBigEndian(Span<byte> destination, out int bytesWritten);

    /// <summary>Tries to write the current value, in little-endian format, to a given span.</summary>
    /// <param name="destination">The span to which the current value should be written.</param>
    /// <param name="bytesWritten">The number of bytes written to <paramref name="destination" />.</param>
    /// <returns><c>true</c> if the value was successfully written to <paramref name="destination" />; otherwise, <c>false</c>.</returns>
    bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten);

    /// <summary>Writes the current value, in big-endian format, to a given array.</summary>
    /// <param name="destination">The array to which the current value should be written.</param>
    /// <returns>The number of bytes written to <paramref name="destination" />.</returns>
    int WriteBigEndian(byte[] destination);

    /// <summary>Writes the current value, in big-endian format, to a given array.</summary>
    /// <param name="destination">The array to which the current value should be written.</param>
    /// <param name="startIndex">The starting index at which the value should be written.</param>
    /// <returns>The number of bytes written to <paramref name="destination" /> starting at <paramref name="startIndex" />.</returns>
    int WriteBigEndian(byte[] destination, int startIndex);

    /// <summary>Writes the current value, in big-endian format, to a given span.</summary>
    /// <param name="destination">The span to which the current value should be written.</param>
    /// <returns>The number of bytes written to <paramref name="destination" />.</returns>
    int WriteBigEndian(Span<byte> destination);

    /// <summary>Writes the current value, in little-endian format, to a given array.</summary>
    /// <param name="destination">The array to which the current value should be written.</param>
    /// <returns>The number of bytes written to <paramref name="destination" />.</returns>
    int WriteLittleEndian(byte[] destination);

    /// <summary>Writes the current value, in little-endian format, to a given array.</summary>
    /// <param name="destination">The array to which the current value should be written.</param>
    /// <param name="startIndex">The starting index at which the value should be written.</param>
    /// <returns>The number of bytes written to <paramref name="destination" /> starting at <paramref name="startIndex" />.</returns>
    int WriteLittleEndian(byte[] destination, int startIndex);

    /// <summary>Writes the current value, in little-endian format, to a given span.</summary>
    /// <param name="destination">The span to which the current value should be written.</param>
    /// <returns>The number of bytes written to <paramref name="destination" />.</returns>
    int WriteLittleEndian(Span<byte> destination);
}

public interface IFloatingPointVector<TVector, TScalar> :
    INumberVector<TVector, TScalar>
    // IHyperbolicFunctions<TVector>,
    // ITrigonometricFunctions<TVector>,
    // ILogarithmicFunctions<TVector>,
    // IExponentialFunctions<TVector>,
    // IPowerFunctions<TVector>,
    // IRootFunctions<TVector>
    where TVector : IFloatingPointVector<TVector, TScalar>
    where TScalar : IBinaryFloatingPointIeee754<TScalar>
{
    TScalar Length();

    static abstract TVector Normalize(TVector value);

    static virtual TScalar Distance(TVector value1, TVector value2);
 
    static abstract TVector Lerp(TVector value1, TVector value2, TVector amount);
    static virtual TVector Lerp(TVector value1, TVector value2, TScalar amount) => TVector.Lerp(value1, value2, TVector.Create(amount));
    static abstract TVector LerpClamped(TVector value1, TVector value2, TVector amount);
    static virtual TVector LerpClamped(TVector value1, TVector value2, TScalar amount) => TVector.LerpClamped(value1, value2, TVector.Create(amount));
    static abstract TVector Reflect(TVector vector, TVector normal);
    static abstract TVector Sqrt(TVector value);
    
    // Equivalent implementing IHyperbolicFunctions<System.Runtime.Intrinsics.Vector3>
    static abstract TVector Acosh(TVector x);
    static abstract TVector Asinh(TVector x);
    static abstract TVector Atanh(TVector x);
    static abstract TVector Cosh(TVector x);
    static abstract TVector Sinh(TVector x);
    static abstract TVector Tanh(TVector x);

    // Equivalent implementing ITrigonometricFunctions<System.Runtime.Intrinsics.Vector3>
    static abstract TVector Acos(TVector x);
    static abstract TVector AcosPi(TVector x);
    static abstract TVector Asin(TVector x);
    static abstract TVector AsinPi(TVector x);
    static abstract TVector Atan(TVector x);
    static abstract TVector AtanPi(TVector x);
    static abstract TVector Cos(TVector x);
    static abstract TVector CosPi(TVector x);
    static abstract TVector DegreesToRadians(TVector degrees);
    static abstract TVector RadiansToDegrees(TVector radians);
    static abstract TVector Sin(TVector x);
    static abstract TVector SinPi(TVector x);
    static abstract TVector Tan(TVector x);
    static abstract TVector TanPi(TVector x);
    static abstract (TVector Sin, TVector Cos) SinCos(TVector x);
    static abstract (TVector SinPi, TVector CosPi) SinCosPi(TVector x);

    // Equivalent implementing ILogarithmicFunctions<System.Runtime.Intrinsics.Vector3>
    static abstract TVector Log(TVector x);
    static abstract TVector Log(TVector x, TVector newBase);
    static abstract TVector Log(TVector x, TScalar newBase);
    static abstract TVector LogP1(TVector x);
    static abstract TVector Log2(TVector x);
    static abstract TVector Log2P1(TVector x);
    static abstract TVector Log10(TVector x);
    static abstract TVector Log10P1(TVector x);

    // Equivalent implementing IExponentialFunctions<System.Runtime.Intrinsics.Vector3>
    static abstract TVector Exp(TVector x);
    static abstract TVector ExpM1(TVector x);
    static abstract TVector Exp2(TVector x);
    static abstract TVector Exp2M1(TVector x);
    static abstract TVector Exp10(TVector x);
    static abstract TVector Exp10M1(TVector x);

    // Equivalent implementing IPowerFunctions<System.Runtime.Intrinsics.Vector3>
    static abstract TVector Pow(TVector x, TVector y);
    static abstract TVector Pow(TVector x, TScalar y);

    // Equivalent implementing IRootFunctions<System.Runtime.Intrinsics.Vector3>
    static abstract TVector Cbrt(TVector x);
    static abstract TVector Hypot(TVector x, TVector y);
    static abstract TVector Hypot(TVector x, TScalar y);
    static abstract TVector RootN(TVector x, int n);

    // IFloatingPoint<TVector>
    static abstract TVector Round(TVector x);
    static abstract TVector Round(TVector x, int digits);
    static abstract TVector Round(TVector x, MidpointRounding mode);
    static abstract TVector Round(TVector x, int digits, MidpointRounding mode);
    static abstract TVector Truncate(TVector x);

    // IFloatingPointIeee754<TVector>
    static abstract TVector Atan2(TVector x, TVector y);
    static abstract TVector Atan2Pi(TVector x, TVector y);
    static abstract TVector Atan2(TVector x, TScalar y);
    static abstract TVector Atan2Pi(TVector x, TScalar y);
    static abstract TVector BitDecrement(TVector x);
    static abstract TVector BitIncrement(TVector x);
    static abstract TVector FusedMultiplyAdd(TVector left, TVector right, TVector addend);
    static virtual TVector FusedMultiplyAdd(TVector left, TScalar right, TVector addend) => TVector.FusedMultiplyAdd(left, TVector.Create(right), addend); 
    static virtual TVector FusedMultiplyAdd(TVector left, TVector right, TScalar addend) => TVector.FusedMultiplyAdd(left, right, TVector.Create(addend)); 
    static virtual TVector FusedMultiplyAdd(TVector left, TScalar right, TScalar addend) => TVector.FusedMultiplyAdd(left, TVector.Create(right), TVector.Create(addend));
    static abstract TVector ReciprocalEstimate(TVector x);
    static abstract TVector ReciprocalSqrtEstimate(TVector x);

    // IFloatingPointIeee754<TVector>
    static virtual TNewVector ILogB<TNewVector>(TVector x) where TNewVector : IVector<TNewVector, int> => TVector.ILogB<TNewVector, int>(x);
    static abstract TNewVector ILogB<TNewVector, TInt>(TVector x) where TNewVector : IVector<TNewVector, TInt> where TInt : IBinaryInteger<TInt>;
    static abstract TVector ScaleB(TVector x, Vector2D<int> n);
    static abstract TVector ScaleB(TVector x, int n);
    static virtual TNewVector RoundToInt<TNewVector>(TVector vector) where TNewVector : IVector<TNewVector, int> => TVector.RoundToInt<TNewVector, int>(vector);
    static virtual TNewVector FloorToInt<TNewVector>(TVector vector) where TNewVector : IVector<TNewVector, int> => TVector.RoundToInt<TNewVector, int>(vector);
    static virtual TNewVector CeilingToInt<TNewVector>(TVector vector) where TNewVector : IVector<TNewVector, int> => TVector.RoundToInt<TNewVector, int>(vector);
    static abstract TNewVector RoundToInt<TNewVector, TInt>(TVector vector)
        where TNewVector : IVector<TNewVector, TInt>
        where TInt : IBinaryInteger<TInt>;
    static abstract TNewVector FloorToInt<TNewVector, TInt>(TVector vector)
        where TNewVector : IVector<TNewVector, TInt>
        where TInt : IBinaryInteger<TInt>;
    static abstract TNewVector CeilingToInt<TNewVector, TInt>(TVector vector)
        where TNewVector : IVector<TNewVector, TInt>
        where TInt : IBinaryInteger<TInt>;

    static virtual Vector64<TScalar> AsVector64(TVector self) => Vector64.Create(TVector.AsSpan(self));
    static virtual Vector128<TScalar> AsVector128(TVector self) => Vector128.Create(TVector.AsSpan(self));
    static virtual Vector256<TScalar> AsVector256(TVector self) => Vector256.Create(TVector.AsSpan(self));
    static virtual Vector512<TScalar> AsVector512(TVector self) => Vector512.Create(TVector.AsSpan(self));
}

public interface IVector2<TVector, TScalar> : IVector<TVector, TScalar>
    where TVector : IVector2<TVector, TScalar>
    where TScalar : INumberBase<TScalar>
{
    static virtual TVector UnitX => { get; }
    static virtual TVector UnitY => { get; }
    
    TScalar X { get; }
    TScalar Y { get; }

    static int IVector.Count => 2;
    
    static abstract TVector Create(TScalar x, TScalar y);
}

public interface IVector3<TVector, TScalar> : IVector<TVector, TScalar>
    where TVector : IVector3<TVector, TScalar>
    where TScalar : INumberBase<TScalar>
{
    static virtual TVector UnitX => { get; }
    static virtual TVector UnitY => { get; }
    static virtual TVector UnitZ => { get; }
    
    TScalar X { get; }
    TScalar Y { get; }
    TScalar Z { get; }

    static int IVector.Count => 3;
    
    static abstract TVector Create(TScalar x, TScalar y);
}

public interface IVector4<TVector, TScalar> : IVector<TVector, TScalar>
    where TVector : IVector4<TVector, TScalar>
    where TScalar : INumberBase<TScalar>
{
    static virtual TVector UnitX { get; }
    static virtual TVector UnitY { get; }
    static virtual TVector UnitZ { get; }
    static virtual TVector UnitW { get; }

    TScalar X { get; }
    TScalar Y { get; }
    TScalar Z { get; }
    TScalar W { get; }

    static int IVector.Count => 4;
    
    static abstract TVector Create(TScalar x, TScalar y);
}

public interface IVector5<TVector, TScalar> : IVector<TVector, TScalar>
    where TVector : IVector5<TVector, TScalar>
    where TScalar : INumberBase<TScalar>
{
    static virtual TVector UnitX { get; }
    static virtual TVector UnitY { get; }
    static virtual TVector UnitZ { get; }
    static virtual TVector UnitW { get; }
    static virtual TVector UnitV { get; }

    TScalar X { get; }
    TScalar Y { get; }
    TScalar Z { get; }
    TScalar W { get; }
    TScalar V { get; }

    static int IVector.Count => 5;
    
    static abstract TVector Create(TScalar x, TScalar y);
}
```

