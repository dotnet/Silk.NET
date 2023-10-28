# Summary
A new API for generic maths in Silk.NET.Maths 3.X, leveraging modern .NET features such as `INumber<T>` and vectorization.

This API aims to replace the existing implementation of Silk.NET.Maths.

# Contributors
- Maxine H (@uwx)

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- Should replace the existing APIs without too much growing pains
- Should try to roughly match System.Numerics APIs, with concessions for design oversights in those APIs
- Should use vectorized implementations for methods when possible
- Prefer generic specialization and extension methods, and keep the type of `T` as wide as possible in the struct itself
- Primitives are read-only, `with` preferred for modification
- Public fields instead of properties
- Implement the following interfaces:
    - IEquatable
    - IEquatable to equivalent System.Numerics primitive, if available
    - IReadOnlyList
    - IUtf8SpanFormattable
    - IUtf8SpanParsable
- Provide explicit implementations of the following interfaces:
    - INumberBase (except for methods which are relevant to vectors)
- Provide implementations of the following interfaces, but as extension/static methods:
    - IHyperbolicFunctions
    - ITrigonometricFunctions
    - ILogarithmicFunctions
    - IExponentialFunctions
    - IPowerFunctions
    - IRootFunctions
    (The reasoning for this is that the required interface types are more narrow than INumberBase)
- Static helper methods, where the result is expected to be bounded to 0-1 or the type of T has to be scoped to a type narrower than the one used by the primitive, have two variants:
    - Method&lt;T>: T is scoped to a narrower type (e.g IRootFunctions&lt;T>, IFloatingPoint&lt;T>)
    - Method&lt;T, TReturn>: no scope for T, but TReturn is scoped to a narrower type

# Proposed API
- IVector&lt;TVector, T>
- IVectorAlso&lt;TVector, T> - Covers interfaces that can't be implemented by IVector because of compiler restrictions
- Vector2D&lt;T>
- Vector3D&lt;T>
- Vector4D&lt;T>
- Quaternion&lt;T>
- Matrix3x2&lt;T>
- Matrix4x4&lt;T>
- Plane&lt;T>

For all `VectorND<T>`:
```cs
public readonly partial struct Vector2D<T> : IVector<Vector2D<T>, T>, IVectorAlso<Vector2D<T>, T>, IEquatable<Vector2>, IVec2
    where T : INumberBase<T>
{
    /// <summary>The X component of the vector.</summary>
    public readonly T X;

    /// <summary>The Y component of the vector.</summary>
    public readonly T Y;

    internal const int Count = 2;

    /// <summary>Creates a new <see cref="Vector2D{T}" /> object whose two elements have the same value.</summary>
    /// <param name="value">The value to assign to all two elements.</param>
    public Vector2D(T value);

    /// <summary>Creates a vector whose elements have the specified values.</summary>
    /// <param name="x">The value to assign to the <see cref="X" /> field.</param>
    /// <param name="y">The value to assign to the <see cref="Y" /> field.</param>
    public Vector2D(T x, T y);

    /// <summary>Constructs a vector from the given <see cref="ReadOnlySpan{T}" />. The span must contain at least 4 elements.</summary>
    /// <param name="values">The span of elements to assign to the vector.</param>
    public Vector2D(ReadOnlySpan<T> values);

    /// <summary>Gets a vector whose 4 elements are equal to zero.</summary>
    /// <value>A vector whose two elements are equal to zero (that is, it returns the vector <c>(0,0)</c>.</value>
    public static Vector2D<T> Zero => new(T.Zero);

    /// <summary>Gets a vector whose 4 elements are equal to one.</summary>
    /// <value>Returns <see cref="Vector2D{T}" />.</value>
    /// <remarks>A vector whose two elements are equal to one (that is, it returns the vector <c>(1,1)</c>.</remarks>
    public static Vector2D<T> One => new(T.One);

    /// <summary>Gets the vector (1,0)).</summary>
    /// <value>The vector <c>(1,0)</c>.</value>
    public static Vector2D<T> UnitX => new(T.One, T.Zero);

    /// <summary>Gets the vector (0,1)).</summary>
    /// <value>The vector <c>(0,1)</c>.</value>
    public static Vector2D<T> UnitY => new(T.Zero, T.One);

    static Vector2D<T> IVector<Vector2D<T>, T>.Create(T scalar);

    public T this[int index] { get; }

    #region Operators
    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector to add.</param>
    /// <param name="right">The second vector to add.</param>
    /// <returns>The summed vector.</returns>
    /// <remarks>The <see cref="op_Addition" /> method defines the addition operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator +(Vector2D<T> left, Vector2D<T> right);

    /// <summary>Subtracts the second vector from the first.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The vector that results from subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
    /// <remarks>The <see cref="op_Subtraction" /> method defines the subtraction operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator -(Vector2D<T> left, Vector2D<T> right);

    /// <summary>Negates the specified vector.</summary>
    /// <param name="value">The vector to negate.</param>
    /// <returns>The negated vector.</returns>
    /// <remarks>The <see cref="op_UnaryNegation" /> method defines the unary negation operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator -(Vector2D<T> value);

    /// <summary>Returns a new vector whose values are the product of each pair of elements in two specified vectors.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The element-wise product vector.</returns>
    /// <remarks>The <see cref="Vector2D{T}.op_Multiply" /> method defines the multiplication operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator *(Vector2D<T> left, Vector2D<T> right);

    /// <summary>Multiplies the specified vector by the specified scalar value.</summary>
    /// <param name="left">The vector.</param>
    /// <param name="right">The scalar value.</param>
    /// <returns>The scaled vector.</returns>
    /// <remarks>The <see cref="Vector2D{T}.op_Multiply" /> method defines the multiplication operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator *(Vector2D<T> left, T right);

    /// <summary>Multiplies the scalar value by the specified vector.</summary>
    /// <param name="left">The vector.</param>
    /// <param name="right">The scalar value.</param>
    /// <returns>The scaled vector.</returns>
    /// <remarks>The <see cref="Vector2D{T}.op_Multiply" /> method defines the multiplication operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator *(T left, Vector2D<T> right);

    /// <summary>Divides the first vector by the second.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The vector that results from dividing <paramref name="left" /> by <paramref name="right" />.</returns>
    /// <remarks>The <see cref="Vector2D{T}.op_Division" /> method defines the division operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator /(Vector2D<T> left, Vector2D<T> right);

    /// <summary>Divides the specified vector by a specified scalar value.</summary>
    /// <param name="value1">The vector.</param>
    /// <param name="value2">The scalar value.</param>
    /// <returns>The result of the division.</returns>
    /// <remarks>The <see cref="Vector2D{T}.op_Division" /> method defines the division operation for <see cref="Vector2D{T}" /> objects.</remarks>
    public static Vector2D<T> operator /(Vector2D<T> value1, T value2);

    /// <summary>Returns a value that indicates whether each pair of elements in two specified vectors is equal.</summary>
    /// <param name="left">The first vector to compare.</param>
    /// <param name="right">The second vector to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
    /// <remarks>Two <see cref="Vector2D{T}" /> objects are equal if each element in <paramref name="left" /> is equal to the corresponding element in <paramref name="right" />.</remarks>
    public static bool operator ==(Vector2D<T> left, Vector2D<T> right);

    /// <summary>Returns a value that indicates whether two specified vectors are not equal.</summary>
    /// <param name="left">The first vector to compare.</param>
    /// <param name="right">The second vector to compare.</param>
    /// <returns><see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <see langword="false" />.</returns>
    public static bool operator !=(Vector2D<T> left, Vector2D<T> right);
    #endregion
1
    static void IVector<Vector2D<T>, T>.CopyTo(in Vector2D<T> vector, T[] array) => vector.CopyTo(array);
    static void IVector<Vector2D<T>, T>.CopyTo(in Vector2D<T> vector, T[] array, int index) => vector.CopyTo(array, index);
    static void IVector<Vector2D<T>, T>.CopyTo(in Vector2D<T> vector, Span<T> destination) => vector.CopyTo(destination);
    static bool IVector<Vector2D<T>, T>.TryCopyTo(in Vector2D<T> vector, Span<T> destination) => vector.TryCopyTo(destination);

    #region Equality
    public bool Equals(Vector2D<T> other);
    public override bool Equals([NotNullWhen(true)] object? obj);
    public bool Equals(Vector2 other);
    public override int GetHashCode();
    #endregion

    #region Format
    /// <summary>Returns the string representation of the current instance using default formatting.</summary>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using the "G" (general) format string and the formatting conventions of the current thread culture. The "&lt;" and "&gt;" characters are used to begin and end the string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    public override string ToString();
    /// <summary>Returns the string representation of the current instance using the specified format string to format individual elements.</summary>
    /// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using <paramref name="format" /> and the current culture's formatting conventions. The "&lt;" and "&gt;" characters are used to begin and end the string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    /// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">Standard Numeric Format Strings</related>
    /// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings</related>
    public string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format);
    /// <summary>Returns the string representation of the current instance using the specified format string to format individual elements and the specified format provider to define culture-specific formatting.</summary>
    /// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
    /// <param name="formatProvider">A format provider that supplies culture-specific formatting information.</param>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using <paramref name="format" /> and <paramref name="formatProvider" />. The "&lt;" and "&gt;" characters are used to begin and end the string, and the format provider's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    /// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">Standard Numeric Format Strings</related>
    /// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings</related>
    public string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format, IFormatProvider? formatProvider);
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider);
    #endregion

    #region Casts
    public Vector2D<TOther> As<TOther>() where TOther : INumberBase<TOther>;
    private Vector2D<TOther> AsChecked<TOther>() where TOther : INumberBase<TOther>;
    public static explicit operator Vector2D<byte>(Vector2D<T> self);
    public static explicit operator Vector2D<sbyte>(Vector2D<T> self);
    public static explicit operator Vector2D<short>(Vector2D<T> self);
    public static explicit operator Vector2D<ushort>(Vector2D<T> self);
    public static explicit operator Vector2D<int>(Vector2D<T> self);
    public static explicit operator Vector2D<uint>(Vector2D<T> self);
    public static explicit operator Vector2D<long>(Vector2D<T> self);
    public static explicit operator Vector2D<ulong>(Vector2D<T> self);
    public static explicit operator Vector2D<Int128>(Vector2D<T> self);
    public static explicit operator Vector2D<UInt128>(Vector2D<T> self);
    public static explicit operator Vector2D<Half>(Vector2D<T> self);
    public static explicit operator Vector2D<float>(Vector2D<T> self);
    public static explicit operator Vector2D<double>(Vector2D<T> self);
    public static explicit operator Vector2D<decimal>(Vector2D<T> self);
    public static explicit operator Vector2D<Complex>(Vector2D<T> self);
    public static explicit operator Vector2D<BigInteger>(Vector2D<T> self);
    public static explicit operator checked Vector2D<byte>(Vector2D<T> self);
    public static explicit operator checked Vector2D<sbyte>(Vector2D<T> self);
    public static explicit operator checked Vector2D<short>(Vector2D<T> self);
    public static explicit operator checked Vector2D<ushort>(Vector2D<T> self);
    public static explicit operator checked Vector2D<int>(Vector2D<T> self);
    public static explicit operator checked Vector2D<uint>(Vector2D<T> self);
    public static explicit operator checked Vector2D<long>(Vector2D<T> self);
    public static explicit operator checked Vector2D<ulong>(Vector2D<T> self);
    public static explicit operator checked Vector2D<Int128>(Vector2D<T> self);
    public static explicit operator checked Vector2D<UInt128>(Vector2D<T> self);
    public static explicit operator checked Vector2D<Half>(Vector2D<T> self);
    public static explicit operator checked Vector2D<float>(Vector2D<T> self);
    public static explicit operator checked Vector2D<double>(Vector2D<T> self);
    public static explicit operator checked Vector2D<decimal>(Vector2D<T> self);
    public static explicit operator checked Vector2D<Complex>(Vector2D<T> self);
    public static explicit operator checked Vector2D<BigInteger>(Vector2D<T> self);

    // Cast to System.Numerics.Vector2
    public static explicit operator Vector2(Vector2D<T> self);
    public static explicit operator checked Vector2(Vector2D<T> self);

    // Downcast

    // Upcast
    public static explicit operator Vector3D<T>(Vector2D<T> self);
    public static explicit operator Vector4D<T>(Vector2D<T> self);

    // Upcast from System.Numerics.Vector < 2

    // Downcast from System.Numerics.Vector >= 2
    public static explicit operator Vector2D<T>(Vector2 self);
    public static explicit operator checked Vector2D<T>(Vector2 self);
    public static explicit operator Vector2D<T>(Vector3 self);
    public static explicit operator checked Vector2D<T>(Vector3 self);
    public static explicit operator Vector2D<T>(Vector4 self);
    public static explicit operator checked Vector2D<T>(Vector4 self);
    public static implicit operator Vector2D<T>((T X, T Y) components);
    #endregion

    public void Deconstruct(out T x, out T y);

    /// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
    /// <param name="value">A vector.</param>
    /// <returns>The absolute value vector.</returns>
    static Vector2D<T> INumberBase<Vector2D<T>>.Abs(Vector2D<T> value);
    static Vector2D<T> IParsable<Vector2D<T>>.Parse(string s, IFormatProvider? provider);
    static Vector2D<T> ISpanParsable<Vector2D<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider);
    public static Vector2D<T> Parse(string s, NumberStyles style = default, IFormatProvider? provider = null);
    public static Vector2D<T> Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.None, IFormatProvider? provider = null);
    public static bool TryParse(string? s, IFormatProvider? provider, out Vector2D<T> result);
    public static bool TryParse(string? s, NumberStyles style, IFormatProvider? provider, out Vector2D<T> result);
    public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out Vector2D<T> result);
    public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out Vector2D<T> result);

    static bool INumberBase<Vector2D<T>>.IsCanonical(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsComplexNumber(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsEvenInteger(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsFinite(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsImaginaryNumber(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsInfinity(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsInteger(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsNaN(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsNegative(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsNegativeInfinity(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsNormal(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsOddInteger(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsPositive(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsPositiveInfinity(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsRealNumber(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsSubnormal(Vector2D<T> value);
    static bool INumberBase<Vector2D<T>>.IsZero(Vector2D<T> value);
    static Vector2D<T> INumberBase<Vector2D<T>>.MaxMagnitude(Vector2D<T> x, Vector2D<T> y);
    static Vector2D<T> INumberBase<Vector2D<T>>.MaxMagnitudeNumber(Vector2D<T> x, Vector2D<T> y);
    static Vector2D<T> INumberBase<Vector2D<T>>.MinMagnitude(Vector2D<T> x, Vector2D<T> y);
    static Vector2D<T> INumberBase<Vector2D<T>>.MinMagnitudeNumber(Vector2D<T> x, Vector2D<T> y);
    static bool INumberBase<Vector2D<T>>.TryConvertFromChecked<TOther>(TOther value, out Vector2D<T> result) where TOther : INumberBase<TOther>;
    static bool INumberBase<Vector2D<T>>.TryConvertFromSaturating<TOther>(TOther value, out Vector2D<T> result) where TOther : INumberBase<TOther>;
    static bool INumberBase<Vector2D<T>>.TryConvertFromTruncating<TOther>(TOther value, out Vector2D<T> result) where TOther : INumberBase<TOther>;
    static bool INumberBase<Vector2D<T>>.TryConvertToChecked<TOther>(Vector2D<T> value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>;
    static bool INumberBase<Vector2D<T>>.TryConvertToSaturating<TOther>(Vector2D<T> value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>;
    static bool INumberBase<Vector2D<T>>.TryConvertToTruncating<TOther>(Vector2D<T> value, [MaybeNullWhen(false)]out TOther result) where TOther : INumberBase<TOther>;

    // For internal use only, not a public API
    // Vector2D<T1>? IVec2.GetChecked<T1>();
    // Vector2D<T1>? IVec2.GetSaturating<T1>();
    // Vector2D<T1>? IVec2.GetTruncating<T1>();

    // IReadOnlyList<T>
    IEnumerator<T> IEnumerable<T>.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator();
    int IReadOnlyCollection<T>.Count => Count;

    // IUtf8SpanFormattable, IUtf8SpanParsable<Vector2D<T>>
    public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider);
    public static Vector2D<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider);
    public static bool TryParse(ReadOnlySpan<byte> s, IFormatProvider? provider, out Vector2D<T> result);

    // IVector<Vector2D<T>>
    T IVector<Vector2D<T>, T>.LengthSquared();
    static Vector2D<T> IVector<Vector2D<T>, T>.Multiply(Vector2D<T> left, Vector2D<T> right);
    static Vector2D<T> IVector<Vector2D<T>, T>.Multiply(Vector2D<T> left, T right);
    static Vector2D<T> IVector<Vector2D<T>, T>.Multiply(T left, Vector2D<T> right);
    static Vector2D<T> IVector<Vector2D<T>, T>.Negate(Vector2D<T> value);
    static Vector2D<T> IVector<Vector2D<T>, T>.Subtract(Vector2D<T> left, Vector2D<T> right);
    static Vector2D<T> IVector<Vector2D<T>, T>.Add(Vector2D<T> left, Vector2D<T> right);
    static Vector2D<T> IVector<Vector2D<T>, T>.Divide(Vector2D<T> left, Vector2D<T> right);
    static Vector2D<T> IVector<Vector2D<T>, T>.Divide(Vector2D<T> left, T divisor);
    static Vector2D<T> IVector<Vector2D<T>, T>.Clamp(Vector2D<T> value1, Vector2D<T> min, Vector2D<T> max);
    static TReturn IVector<Vector2D<T>, T>.Distance<TReturn>(Vector2D<T> value1, Vector2D<T> value2);
    static T IVector<Vector2D<T>, T>.DistanceSquared(Vector2D<T> value1, Vector2D<T> value2);
    static TReturn IVector<Vector2D<T>, T>.DistanceSquared<TReturn>(Vector2D<T> value1, Vector2D<T> value2);
    static T IVector<Vector2D<T>, T>.Dot(Vector2D<T> vector1, Vector2D<T> vector2);
    static TReturn IVector<Vector2D<T>, T>.Dot<TReturn>(Vector2D<T> vector1, Vector2D<T> vector2);
    static Vector2D<T> IVector<Vector2D<T>, T>.Max(Vector2D<T> value1, Vector2D<T> value2);
    static Vector2D<T> IVector<Vector2D<T>, T>.Min(Vector2D<T> value1, Vector2D<T> value2);
    static Vector2D<T> IVector<Vector2D<T>, T>.Lerp(Vector2D<T> value1, Vector2D<T> value2, T amount); /* where T : IFloatingPoint<T> */
    static Vector2D<T> IVector<Vector2D<T>, T>.LerpClamped(Vector2D<T> value1, Vector2D<T> value2, T amount); /* where T : IFloatingPoint<T> */
    static Vector2D<T> IVector<Vector2D<T>, T>.Reflect(Vector2D<T> vector, Vector2D<T> normal); /* where T : IFloatingPoint<T> */
    static ReadOnlySpan<T> IVector<Vector2D<T>, T>.AsSpan<T>(in this Vector2D<T> vec);
}

public static class Vector2D
{
    #region CopyTo
    /// <summary>Copies the elements of the vector to a specified array.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="array">The destination array.</param>
    /// <remarks><paramref name="array" /> must have at least {{ AmountName }} elements. The method copies the vector's elements starting at index 0.</remarks>
    /// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
    /// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyTo<T>(in this Vector2D<T> self, T[] array) where T : INumberBase<T>;

    /// <summary>Copies the elements of the vector to a specified array starting at a specified index position.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="array">The destination array.</param>
    /// <param name="index">The index at which to copy the first element of the vector.</param>
    /// <remarks><paramref name="array" /> must have a sufficient number of elements to accommodate the {{ AmountName }} vector elements. In other words, elements <paramref name="index" /> through <paramref name="index" /> + {{vecN}} must already exist in <paramref name="array" />.</remarks>
    /// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.
    /// -or-
    /// <paramref name="index" /> is greater than or equal to the array length.</exception>
    /// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyTo<T>(in this Vector2D<T> self, T[] array, int index) where T : INumberBase<T>;

    /// <summary>Copies the vector to the given <see cref="Span{T}" />. The length of the destination span must be at least 4.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination span.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyTo<T>(in this Vector2D<T> self, Span<T> destination) where T : INumberBase<T>;

    /// <summary>Attempts to copy the vector to the given <see cref="Span{Single}" />. The length of the destination span must be at least 4.</summary>
    /// <param name="vector">The vector to be copied.</param>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <returns><see langword="true" /> if the source vector was successfully copied to <paramref name="destination" />. <see langword="false" /> if <paramref name="destination" /> is not large enough to hold the source vector.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryCopyTo<T>(in this Vector2D<T> self, Span<T> destination) where T : INumberBase<T>;
    #endregion

    #region Extension
    public static ReadOnlySpan<T> AsSpan<T>(in this Vector2D<T> vec);

    /// <summary>Returns the length of this vector object.</summary>
    /// <returns>The vector's length.</returns>
    /// <altmember cref="LengthSquared{T,TReturn}"/>
    public static TReturn Length<T, TReturn>(this Vector2D<T> vec) where T : INumberBase<T> where TReturn : INumberBase<TReturn>, IRootFunctions<TReturn>;
    /// <summary>Returns the length of the vector squared.</summary>
    /// <returns>The vector's length squared.</returns>
    /// <remarks>This operation offers better performance than a call to the <see cref="Length{T,TReturn}" /> method.</remarks>
    /// <altmember cref="Length{T,TReturn}"/>
    public static TReturn LengthSquared<T, TReturn>(this Vector2D<T> vec) where T : INumberBase<T> where TReturn : INumberBase<TReturn>;
    #endregion

    #region Basic
    /// <summary>Returns a new vector whose values are the product of each pair of elements in two specified vectors.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The element-wise product vector.</returns>
    public static Vector2D<T> Multiply<T>(Vector2D<T> left, Vector2D<T> right) where T : INumberBase<T>;
    /// <summary>Multiplies a vector by a specified scalar.</summary>
    /// <param name="left">The vector to multiply.</param>
    /// <param name="right">The scalar value.</param>
    /// <returns>The scaled vector.</returns>
    public static Vector2D<T> Multiply<T>(Vector2D<T> left, T right) where T : INumberBase<T>;
    /// <summary>Multiplies a scalar value by a specified vector.</summary>
    /// <param name="left">The scaled value.</param>
    /// <param name="right">The vector.</param>
    /// <returns>The scaled vector.</returns>
    public static Vector2D<T> Multiply<T>(T left, Vector2D<T> right) where T : INumberBase<T>;
    /// <summary>Negates a specified vector.</summary>
    /// <param name="value">The vector to negate.</param>
    /// <returns>The negated vector.</returns>
    public static Vector2D<T> Negate<T>(Vector2D<T> value) where T : INumberBase<T>;
    /// <summary>Subtracts the second vector from the first.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The difference vector.</returns>
    public static Vector2D<T> Subtract<T>(Vector2D<T> left, Vector2D<T> right) where T : INumberBase<T>;
    /// <summary>Adds two vectors together.</summary>
    /// <param name="left">The first vector to add.</param>
    /// <param name="right">The second vector to add.</param>
    /// <returns>The summed vector.</returns>
    public static Vector2D<T> Add<T>(Vector2D<T> left, Vector2D<T> right) where T : INumberBase<T>;
    /// <summary>Divides the first vector by the second.</summary>
    /// <param name="left">The first vector.</param>
    /// <param name="right">The second vector.</param>
    /// <returns>The vector resulting from the division.</returns>
    public static Vector2D<T> Divide<T>(Vector2D<T> left, Vector2D<T> right) where T : INumberBase<T>;
    /// <summary>Divides the specified vector by a specified scalar value.</summary>
    /// <param name="left">The vector.</param>
    /// <param name="divisor">The scalar value.</param>
    /// <returns>The vector that results from the division.</returns>
    public static Vector2D<T> Divide<T>(Vector2D<T> left, T divisor) where T : INumberBase<T>;
    #endregion

    #region Other
    /// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
    /// <param name="value">A vector.</param>
    /// <returns>The absolute value vector.</returns>
    public static Vector2D<T> Abs<T>(Vector2D<T> value) where T : INumberBase<T>;

    /// <summary>Restricts a vector between a minimum and a maximum value.</summary>
    /// <param name="value1">The vector to restrict.</param>
    /// <param name="min">The minimum value.</param>
    /// <param name="max">The maximum value.</param>
    /// <returns>The restricted vector.</returns>
    public static Vector2D<T> Clamp<T>(Vector2D<T> value1, Vector2D<T> min, Vector2D<T> max) where T : INumberBase<T>;

    /// <summary>Computes the Euclidean distance between the two given points.</summary>
    /// <param name="value1">The first point.</param>
    /// <param name="value2">The second point.</param>
    /// <returns>The distance.</returns>
    public static TReturn Distance<T, TReturn>(Vector2D<T> value1, Vector2D<T> value2) where T : INumberBase<T> where TReturn : INumberBase<TReturn>, IRootFunctions<TReturn>;

    /// <summary>Returns the Euclidean distance squared between two specified points.</summary>
    /// <param name="value1">The first point.</param>
    /// <param name="value2">The second point.</param>
    /// <returns>The distance squared.</returns>
    public static T DistanceSquared<T>(Vector2D<T> value1, Vector2D<T> value2) where T : INumberBase<T>;

    /// <summary>Returns the Euclidean distance squared between two specified points.</summary>
    /// <param name="value1">The first point.</param>
    /// <param name="value2">The second point.</param>
    /// <returns>The distance squared.</returns>
    public static TReturn DistanceSquared<T, TReturn>(Vector2D<T> value1, Vector2D<T> value2) where T : INumberBase<T> where TReturn : INumberBase<TReturn>;

    /// <summary>Returns the dot product of two vectors.</summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The dot product.</returns>
    public static T Dot<T>(Vector2D<T> vector1, Vector2D<T> vector2) where T : INumberBase<T>;

    /// <summary>Returns the dot product of two vectors.</summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The dot product.</returns>
    public static TReturn Dot<T, TReturn>(Vector2D<T> vector1, Vector2D<T> vector2) where T : INumberBase<T> where TReturn : INumberBase<TReturn>;

    /// <summary>Performs a linear interpolation between two vectors based on the given weighting.</summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">A value between 0 and 1 that indicates the weight of <paramref name="value2" />.</param>
    /// <returns>The interpolated vector.</returns>
    public static Vector2D<TFloat> Lerp<T, TFloat>(Vector2D<T> value1, Vector2D<T> value2, TFloat amount) where T : INumberBase<T> where TFloat : INumberBase<TFloat>, IFloatingPoint<TFloat>;

    // internal static Vector2D<T> LerpUnchecked<T>(Vector2D<T> value1, Vector2D<T> value2, T amount) where T : INumberBase<T>;

    public static Vector2D<TFloat> LerpClamped<T, TFloat>(Vector2D<T> value1, Vector2D<T> value2, TFloat amount) where T : INumberBase<T> where TFloat : INumberBase<TFloat>, IFloatingPoint<TFloat>;

    // internal static Vector2D<T> LerpClampedUnchecked<T>(Vector2D<T> value1, Vector2D<T> value2, T amount) where T : INumberBase<T>;

    /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in two specified vectors.</summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <returns>The maximized vector.</returns>
    public static Vector2D<T> Max<T>(Vector2D<T> value1, Vector2D<T> value2) where T : INumberBase<T>;

    /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in two specified vectors.</summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <returns>The minimized vector.</returns>
    public static Vector2D<T> Min<T>(Vector2D<T> value1, Vector2D<T> value2) where T : INumberBase<T>;

    /// <summary>Returns a vector with the same direction as the specified vector, but with a length of one.</summary>
    /// <param name="value">The vector to normalize.</param>
    /// <returns>The normalized vector.</returns>
    public static Vector2D<TReturn> Normalize<T, TReturn>(Vector2D<T> value) where T : INumberBase<T> where TReturn : INumberBase<TReturn>, IRootFunctions<TReturn>;

    /// <summary>Returns a vector with the same direction as the specified vector, but with a length of one.</summary>
    /// <param name="value">The vector to normalize.</param>
    /// <returns>The normalized vector.</returns>
    public static Vector2D<T> Normalize<T>(Vector2D<T> value) where T : INumberBase<T>, IRootFunctions<T>;

    /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
    /// <param name="vector">The source vector.</param>
    /// <param name="normal">The normal of the surface being reflected off.</param>
    /// <returns>The reflected vector.</returns>
    public static Vector2D<TReturn> Reflect<T, TReturn>(Vector2D<T> vector, Vector2D<T> normal) where T : INumberBase<T> where TReturn : INumberBase<TReturn>;

    /// <summary>Returns a vector whose elements are the square root of each of a specified vector's elements.</summary>
    /// <param name="value">A vector.</param>
    /// <returns>The square root vector.</returns>
    public static Vector2D<TReturn> Sqrt<T, TReturn>(Vector2D<T> value) where T : INumberBase<T> where TReturn : INumberBase<TReturn>, IRootFunctions<TReturn>;

    public static Vector2D<T> Remainder<T>(this Vector2D<T> left, Vector2D<T> right) where T : INumberBase<T>, IModulusOperators<T, T, T>;

    public static Vector2D<T> Remainder<T>(this Vector2D<T> left, T right) where T : INumberBase<T>, IModulusOperators<T, T, T>;
    #endregion

    #region Specializations
    /// <summary>Returns the length of this vector object.</summary>
    /// <returns>The vector's length.</returns>
    /// <altmember cref="LengthSquared{T}"/>
    public static T Length<T>(this Vector2D<T> vec) where T : INumberBase<T>, IRootFunctions<T>;

    /// <summary>Returns the length of the vector squared.</summary>
    /// <returns>The vector's length squared.</returns>
    /// <remarks>This operation offers better performance than a call to the <see cref="Length{T}" /> method.</remarks>
    /// <altmember cref="Length{T}"/>
    public static T LengthSquared<T>(this Vector2D<T> vec) where T : INumberBase<T>;

    /// <summary>Performs a linear interpolation between two vectors based on the given weighting.</summary>
    /// <param name="value1">The first vector.</param>
    /// <param name="value2">The second vector.</param>
    /// <param name="amount">A value between 0 and 1 that indicates the weight of <paramref name="value2" />.</param>
    /// <returns>The interpolated vector.</returns>
    public static Vector2D<T> Lerp<T>(Vector2D<T> value1, Vector2D<T> value2, T amount) where T : INumberBase<T>, IFloatingPoint<T>;

    public static Vector2D<T> LerpClamped<T>(Vector2D<T> value1, Vector2D<T> value2, T amount) where T : INumberBase<T>, IFloatingPoint<T>;

    /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
    /// <param name="vector">The source vector.</param>
    /// <param name="normal">The normal of the surface being reflected off.</param>
    /// <returns>The reflected vector.</returns>
    public static Vector2D<T> Reflect<T>(Vector2D<T> vector, Vector2D<T> normal) where T : IFloatingPoint<T>;

    /// <summary>Returns a vector whose elements are the square root of each of a specified vector's elements.</summary>
    /// <param name="value">A vector.</param>
    /// <returns>The square root vector.</returns>
    public static Vector2D<T> Sqrt<T>(Vector2D<T> value) where T : IFloatingPoint<T>, IRootFunctions<T>;
    #endregion

    // Equivalent implementing IHyperbolicFunctions<System.Runtime.Intrinsics.Vector3>
    public static Vector2D<T> Acosh<T>(Vector2D<T> x) where T : IHyperbolicFunctions<T>;
    public static Vector2D<T> Asinh<T>(Vector2D<T> x) where T : IHyperbolicFunctions<T>;
    public static Vector2D<T> Atanh<T>(Vector2D<T> x) where T : IHyperbolicFunctions<T>;
    public static Vector2D<T> Cosh<T>(Vector2D<T> x) where T : IHyperbolicFunctions<T>;
    public static Vector2D<T> Sinh<T>(Vector2D<T> x) where T : IHyperbolicFunctions<T>;
    public static Vector2D<T> Tanh<T>(Vector2D<T> x) where T : IHyperbolicFunctions<T>;

    // Equivalent implementing ITrigonometricFunctions<System.Runtime.Intrinsics.Vector3>
    public static Vector2D<T> Acos<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> AcosPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> Asin<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> AsinPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> Atan<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> AtanPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> Cos<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> CosPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> DegreesToRadians<T>(Vector2D<T> degrees) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> RadiansToDegrees<T>(Vector2D<T> radians) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> Sin<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> SinPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> Tan<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static Vector2D<T> TanPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>;
    public static (Vector2D<T> Sin, Vector2D<T> Cos) SinCos<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>
    public static (Vector2D<T> SinPi, Vector2D<T> CosPi) SinCosPi<T>(Vector2D<T> x) where T : ITrigonometricFunctions<T>

    // Equivalent implementing ILogarithmicFunctions<System.Runtime.Intrinsics.Vector3>
    public static Vector2D<T> Log<T>(Vector2D<T> x) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> Log<T>(Vector2D<T> x, Vector2D<T> newBase) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> Log<T>(Vector2D<T> x, T newBase) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> LogP1<T>(Vector2D<T> x) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> Log2<T>(Vector2D<T> x) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> Log2P1<T>(Vector2D<T> x) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> Log10<T>(Vector2D<T> x) where T : ILogarithmicFunctions<T>;
    public static Vector2D<T> Log10P1<T>(Vector2D<T> x) where T : ILogarithmicFunctions<T>;

    // Equivalent implementing IExponentialFunctions<System.Runtime.Intrinsics.Vector3>
    public static Vector2D<T> Exp<T>(Vector2D<T> x) where T : IExponentialFunctions<T>;
    public static Vector2D<T> ExpM1<T>(Vector2D<T> x) where T : IExponentialFunctions<T>;
    public static Vector2D<T> Exp2<T>(Vector2D<T> x) where T : IExponentialFunctions<T>;
    public static Vector2D<T> Exp2M1<T>(Vector2D<T> x) where T : IExponentialFunctions<T>;
    public static Vector2D<T> Exp10<T>(Vector2D<T> x) where T : IExponentialFunctions<T>;
    public static Vector2D<T> Exp10M1<T>(Vector2D<T> x) where T : IExponentialFunctions<T>;

    // Equivalent implementing IPowerFunctions<System.Runtime.Intrinsics.Vector3>
    public static Vector2D<T> Pow<T>(Vector2D<T> x, Vector2D<T> y) where T : IPowerFunctions<T>;
    public static Vector2D<T> Pow<T>(Vector2D<T> x, T y) where T : IPowerFunctions<T>;

    // Equivalent implementing IRootFunctions<System.Runtime.Intrinsics.Vector3>
    public static Vector2D<T> Cbrt<T>(Vector2D<T> x) where T : IRootFunctions<T>;
    public static Vector2D<T> Hypot<T>(Vector2D<T> x, Vector2D<T> y) where T : IRootFunctions<T>;
    public static Vector2D<T> Hypot<T>(Vector2D<T> x, T y) where T : IRootFunctions<T>;
    public static Vector2D<T> RootN<T>(Vector2D<T> x, int n) where T : IRootFunctions<T>;

    // IFloatingPoint<TSelf>
    public static Vector2D<T> Round<T>(Vector2D<T> x) where T : IFloatingPoint<T>;
    public static Vector2D<T> Round<T>(Vector2D<T> x, int digits) where T : IFloatingPoint<T>;
    public static Vector2D<T> Round<T>(Vector2D<T> x, MidpointRounding mode) where T : IFloatingPoint<T>;
    public static Vector2D<T> Round<T>(Vector2D<T> x, int digits, MidpointRounding mode) where T : IFloatingPoint<T>;
    public static Vector2D<T> Truncate<T>(Vector2D<T> x) where T : IFloatingPoint<T>;

    // IFloatingPointIeee754<TSelf>
    public static Vector2D<T> Atan2<T>(Vector2D<T> x, Vector2D<T> y) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> Atan2Pi<T>(Vector2D<T> x, Vector2D<T> y) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> Atan2<T>(Vector2D<T> x, T y) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> Atan2Pi<T>(Vector2D<T> x, T y) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> BitDecrement<T>(Vector2D<T> x) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> BitIncrement<T>(Vector2D<T> x) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> FusedMultiplyAdd<T>(Vector2D<T> left, Vector2D<T> right, Vector2D<T> addend) where T : IFloatingPointIeee754<T>;
    // public static Vector2D<T> Lerp<T>(Vector2D<T> value1, Vector2D<T> value2, Vector2D<T> amount) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> ReciprocalEstimate<T>(Vector2D<T> x) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> ReciprocalSqrtEstimate<T>(Vector2D<T> x) where T : IFloatingPointIeee754<T>;

    // INumber<T>
    // public static Vector2D<T> Clamp<T>(Vector2D<T> value, Vector2D<T> min, Vector2D<T> max) where T : INumber<T>;
    public static Vector2D<T> CopySign<T>(Vector2D<T> value, Vector2D<T> sign) where T : INumber<T>;
    public static Vector2D<T> CopySign<T>(Vector2D<T> value, T sign) where T : INumber<T>;
    public static Vector2D<T> MaxNumber<T>(Vector2D<T> x, Vector2D<T> y) where T : INumber<T>;
    public static Vector2D<T> MinNumber<T>(Vector2D<T> x, Vector2D<T> y) where T : INumber<T>;

    // IFloatingPointIeee754<TSelf>
    public static Vector2D<int> ILogB<T>(Vector2D<T> x) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> ScaleB<T>(Vector2D<T> x, Vector2D<int> n) where T : IFloatingPointIeee754<T>;
    public static Vector2D<T> ScaleB<T>(Vector2D<T> x, int n) where T : IFloatingPointIeee754<T>;
    public static Vector2D<int> RoundToInt<T>(Vector2D<T> vector) where T : IFloatingPoint<T>;
    public static Vector2D<int> FloorToInt<T>(Vector2D<T> vector) where T : IFloatingPoint<T>;
    public static Vector2D<int> CeilingToInt<T>(Vector2D<T> vector) where T : IFloatingPoint<T>;
    public static Vector2D<TInt> RoundToInt<T, TInt>(Vector2D<T> vector) where T : IFloatingPoint<T> where TInt : IBinaryInteger<TInt>;
    public static Vector2D<TInt> FloorToInt<T, TInt>(Vector2D<T> vector) where T : IFloatingPoint<T> where TInt : IBinaryInteger<TInt>;
    public static Vector2D<TInt> CeilingToInt<T, TInt>(Vector2D<T> vector) where T : IFloatingPoint<T> where TInt : IBinaryInteger<TInt>;
    public static Vector2D<float> AsGeneric(this Vector2 vector);
    public static Vector2 AsNumerics(this Vector2D<float> vector);

    public static Vector128<T> AsVector128<T>(this Vector2D<T> self) where T : INumberBase<T>;
    public static Vector128<TOut> AsVector128<T, TOut>(this Vector2D<T> self) where T : INumberBase<T>;
}
```

For specific Vectors:
```cs
public static class Vector2D
{
    /// <summary>Transforms a vector by a specified 3x2 matrix.</summary>
    /// <param name="position">The vector to transform.</param>
    /// <param name="matrix">The transformation matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector2D<T> Transform<T>(Vector2D<T> position, Matrix3X2<T> matrix);

    /// <summary>Transforms a vector by a specified 4x4 matrix.</summary>
    /// <param name="position">The vector to transform.</param>
    /// <param name="matrix">The transformation matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector2D<T> Transform<T>(Vector2D<T> position, Matrix4X4<T> matrix) where T : INumberBase<T>;


    /// <summary>Transforms a vector by the specified Quaternion<T> rotation value.</summary>
    /// <param name="value">The vector to rotate.</param>
    /// <param name="rotation">The rotation to apply.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector2D<T> Transform<T>(Vector2D<T> value, Quaternion<T> rotation) where T : ITrigonometricFunctions<T>, IRootFunctions<T>;

    /// <summary>Transforms a vector normal by the given 3x2 matrix.</summary>
    /// <param name="normal">The source vector.</param>
    /// <param name="matrix">The matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector2D<T> TransformNormal<T>(Vector2D<T> normal, Matrix3X2<T> matrix) where T : INumberBase<T>;

    /// <summary>Transforms a vector normal by the given 4x4 matrix.</summary>
    /// <param name="normal">The source vector.</param>
    /// <param name="matrix">The matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector2D<T> TransformNormal<T>(Vector2D<T> normal, Matrix4X4<T> matrix) where T : INumberBase<T>;
}

public static class Vector3D
{
    /// <summary>Computes the cross product of two vectors.</summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The cross product.</returns>
    public static Vector3D<T> Cross<T>(Vector3D<T> vector1, Vector3D<T> vector2) where T : INumberBase<T>;

    /// <summary>Computes the cross product of two vectors.</summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The cross product.</returns>
    public static Vector3D<T> Cross<T, TIntermediate>(Vector3D<T> vector1, Vector3D<T> vector2) where T : INumberBase<T> where TIntermediate : INumberBase<TIntermediate>;

    /// <summary>Transforms a vector by the specified Quaternion rotation value.</summary>
    /// <param name="value">The vector to rotate.</param>
    /// <param name="rotation">The rotation to apply.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector3D<TReturn> Transform<T, TQuat, TReturn>(Vector3D<T> value, Quaternion<TQuat> rotation) where T : INumberBase<T> where TReturn : INumberBase<TReturn> where TQuat : ITrigonometricFunctions<TQuat>, IRootFunctions<TQuat>;

    /// <summary>Transforms a vector normal by the given 4x4 matrix.</summary>
    /// <param name="normal">The source vector.</param>
    /// <param name="matrix">The matrix.</param>
    /// <returns>The transformed vector.</returns>
    internal static Vector3D<T> TransformNormal<T>(Vector3D<T> normal, Matrix4X4<T> matrix) where T : INumberBase<T>;
}

public static class Vector4D
{
    /// <summary>Transforms a two-dimensional vector by a specified 4x4 matrix.</summary>
    /// <param name="position">The vector to transform.</param>
    /// <param name="matrix">The transformation matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector4D<T> Transform<T>(Vector2D<T> position, Matrix4X4<T> matrix) where T : INumberBase<T>;

    /// <summary>Transforms a two-dimensional vector by the specified Quaternion<T> rotation value.</summary>
    /// <param name="value">The vector to rotate.</param>
    /// <param name="rotation">The rotation to apply.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector4D<T> Transform<T>(Vector2D<T> value, Quaternion<T> rotation) where T : ITrigonometricFunctions<T>, IRootFunctions<T>;

    /// <summary>Transforms a three-dimensional vector by a specified 4x4 matrix.</summary>
    /// <param name="position">The vector to transform.</param>
    /// <param name="matrix">The transformation matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector4D<T> Transform<T>(Vector3D<T> position, Matrix4X4<T> matrix) where T : INumberBase<T>;

    /// <summary>Transforms a three-dimensional vector by the specified Quaternion{T} rotation value.</summary>
    /// <param name="value">The vector to rotate.</param>
    /// <param name="rotation">The rotation to apply.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector4D<T> Transform<T>(Vector3D<T> value, Quaternion<T> rotation) where T : ITrigonometricFunctions<T>, IRootFunctions<T>;

    /// <summary>Transforms a four-dimensional vector by a specified 4x4 matrix.</summary>
    /// <param name="vector">The vector to transform.</param>
    /// <param name="matrix">The transformation matrix.</param>
    /// <returns>The transformed vector.</returns>
    public static Vector4D<T> Transform<T>(Vector4D<T> vector, Matrix4X4<T> matrix) where T : INumberBase<T>;
}
```

IVector base type:
```cs
/*
 * Explanation for this interface:
 * If IDivisionOperators<TVector, T, TVector>/IMultiplyOperators<TVector, T, TVector> are implemented via IVector, they conflict with
 * IDivisionOperators<TVector, TVector, TVector> from INumberBase<TVector> IMultiplyOperators<TVector, TVector, TVector>, which we need.
 * This causes the following compiler error:
 *
 * Interface 'GenericVector.IVector<TVector,T>' cannot implement both 'System.Numerics.IDivisionOperators<TVector,TVector,TVector>' and
 * 'System.Numerics.IDivisionOperators<TVector,T,TVector>' because they may unify for some type parameter substitutions
 *
 * As we can't add a "not-constraint" to generics, we have to live with this. An alternative is to not implement the interface but still
 * provide the operator; this could be discussed with the working group.
 */
public interface IVectorAlso<TVector, T> :
    IDivisionOperators<TVector, T, TVector>,
    IMultiplyOperators<TVector, T, TVector>
    where TVector : IVectorAlso<TVector, T>, IVector<TVector, T>
    where T : INumberBase<T>;

public interface IVector<TVector, T> :
    INumberBase<TVector>,
    IUtf8SpanFormattable,
    IReadOnlyList<T>
    where TVector : IVector<TVector, T>
    where T : INumberBase<T>
{
    // Disambiguate TryFormat between INumberBase and IUtf8SpanFormattable by redirecting to a new method
    bool INumberBase<TVector>.TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider);
    bool IUtf8SpanFormattable.TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider);

    /// <inheritdoc cref="IUtf8SpanFormattable.TryFormat"/>
    new bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider);

    static abstract TVector Create(T scalar);

    static TVector INumberBase<TVector>.Zero { get; }
    static TVector INumberBase<TVector>.One { get; }

    /// <summary>Gets a vector whose elements are equal to zero.</summary>
    /// <value>Returns <typeparamref name="TVector"/>.</value>
    /// <value>A vector whose elements are equal to zero.</value>
    new static virtual TVector Zero { get; }

    /// <summary>Gets a vector whose elements are equal to one.</summary>
    /// <value>Returns <typeparamref name="TVector"/>.</value>
    /// <value>A vector whose elements are equal to one.</value>
    new static virtual TVector One { get; }

    T IReadOnlyList<T>.this[int index]  { get; }

    public new T this[int index] { get; }

    static abstract TVector operator /(TVector left, T right);
    static abstract TVector operator *(TVector left, T right);
    static abstract TVector operator *(T left, TVector right);

    // Commented out methods are not able to be implemented in the current .NET version (8.0) due to requiring a narrower type of T
    //T Length() /* where T : IRootFunctions<T> */;
    T LengthSquared();
    static abstract TVector Multiply(TVector left, TVector right);
    static abstract TVector Multiply(TVector left, T right);
    static abstract TVector Multiply(T left, TVector right);
    static abstract TVector Negate(TVector value);
    static abstract TVector Subtract(TVector left, TVector right);
    static abstract TVector Add(TVector left, TVector right);
    static abstract TVector Divide(TVector left, TVector right);
    static abstract TVector Divide(TVector left, T divisor);
    static abstract TVector Clamp(TVector value1, TVector min, TVector max);
    static abstract TReturn Distance<TReturn>(TVector value1, TVector value2) where TReturn : INumberBase<TReturn>, IRootFunctions<TReturn>;
    static abstract T DistanceSquared(TVector value1, TVector value2);
    static abstract TReturn DistanceSquared<TReturn>(TVector value1, TVector value2) where TReturn : INumberBase<TReturn>;
    static abstract T Dot(TVector vector1, TVector vector2);
    static abstract TReturn Dot<TReturn>(TVector vector1, TVector vector2) where TReturn : INumberBase<TReturn>;
    static abstract TVector Max(TVector value1, TVector value2);
    static abstract TVector Min(TVector value1, TVector value2);
    //static abstract TVector Normalize(TVector value) /* where T : IRootFunctions<T> */;
    //TVector Remainder(TVector right) /* where T : IModulusOperators<T, T, T> */;
    //TVector Remainder(T right) /* where T : IModulusOperators<T, T, T> */;
    static abstract TVector Lerp(TVector value1, TVector value2, T amount) /* where T : IFloatingPoint<T> */;
    static abstract TVector LerpClamped(TVector value1, TVector value2, T amount) /* where T : IFloatingPoint<T> */;
    static abstract TVector Reflect(TVector vector, TVector normal) /* where T : IFloatingPoint<T> */;
    //static abstract TVector Sqrt(TVector value) /* where T : IFloatingPoint<T>, IRootFunctions<T> */;

    /// <summary>Copies the elements of the vector to a specified array.</summary>
    /// <param name="array">The destination array.</param>
    /// <remarks><paramref name="array" /> must have enough elements to fit all scalars in this vector. The method copies the vector's elements starting at index 0.</remarks>
    /// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
    /// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
    void CopyTo(T[] array);

    /// <summary>Copies the elements of the vector to a specified array starting at a specified index position.</summary>
    /// <param name="array">The destination array.</param>
    /// <param name="index">The index at which to copy the first element of the vector.</param>
    /// <remarks><paramref name="array" /> must have a sufficient number of elements to accommodate the vector elements. In other words, elements <paramref name="index" /> through <paramref name="index" /> + 2 must already exist in <paramref name="array" />.</remarks>
    /// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="index" /> is less than zero.
    /// -or-
    /// <paramref name="index" /> is greater than or equal to the array length.</exception>
    /// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
    void CopyTo(T[] array, int index);

    /// <summary>Copies the vector to the given <see cref="Span{T}" />. The length of the destination span must be at least enough to fit all scalars in this vector.</summary>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination span.</exception>
    void CopyTo(Span<T> destination);

    /// <summary>Attempts to copy the vector to the given <see cref="Span{Single}" />. The length of the destination span must be at least enough to fit all scalars in this vector.</summary>
    /// <param name="destination">The destination span which the values are copied into.</param>
    /// <returns><see langword="true" /> if the source vector was successfully copied to <paramref name="destination" />. <see langword="false" /> if <paramref name="destination" /> is not large enough to hold the source vector.</returns>
    bool TryCopyTo(Span<T> destination);

    static TVector IAdditiveIdentity<TVector, TVector>.AdditiveIdentity => TVector.Zero;
    static TVector IMultiplicativeIdentity<TVector, TVector>.MultiplicativeIdentity => TVector.One;

    static TVector IDecrementOperators<TVector>.operator --(TVector value) => value - TVector.One;
    static TVector IIncrementOperators<TVector>.operator ++(TVector value) => value + TVector.One;

    static TVector IUnaryPlusOperators<TVector, TVector>.operator +(TVector value) => value;

    static int INumberBase<TVector>.Radix => T.Radix;

    static abstract ReadOnlySpan<T> AsSpan(in TVector vec);
}
```
