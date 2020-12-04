using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating two values and provides hardware accelerated methods.</summary>
    [Serializable]
    [DataContract]
    public struct Vector2<T>
        : IEquatable<Vector2<T>>, IFormattable 
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The X component of the vector.</summary>
        [DataMember]
        public T X;
        
        /// <summary>The Y component of the vector.</summary>
        [DataMember]
        public T Y;
        
        /// <summary>Creates a new <see cref="Vector2{T}"/> object whose two elements have the same value.</summary>
        /// <param name="value">The value to assign to both elements.</param>
        public Vector2(T value) => (X, Y) = (value, value);
        
        /// <summary>Creates a vector whose elements have the specified values.</summary>
        /// <param name="x">The value to assign to the <see cref="X"/> field.</param>
        /// <param name="y">The value to assign to the <see cref="Y"/> field.</param>
        public Vector2(T x, T y) => (X, Y) = (x, y);
        
        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2<T> One => new(Scalar<T>.One);
        
        /// <summary>Gets the vector (1,0).</summary>
        public static Vector2<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero);
        
        /// <summary>Gets the vector (0,1).</summary>
        public static Vector2<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One);
        
        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2<T> Zero => default;

        /// <summary>
        /// Indexer for the components of this vector.
        /// </summary>
        /// <param name="i">The component to select. Zero based.</param>
        public T this[int i]
        {
            get
            {
                static void VerifyBounds(int i)
                {
                    static void ThrowHelper() => throw new IndexOutOfRangeException();
                    
                    if (i > 1 || i < 0)
                        ThrowHelper();
                }
                
                VerifyBounds(i);
                return Unsafe.Add(ref X, i);
            }
        }

        /// <summary>Copies the elements of the vector to a specified array.</summary>
        /// <param name="array">The destination array.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"> is <c>null</c></paramref></exception>
        /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
        /// <exception cref="RankException"><paramref name="array"> is multidimensional.</paramref></exception>
        /// <remarks><paramref name="array"></paramref> must have at least two elements. The method copies the vector's elements starting at index 0.</remarks>
        [MethodImpl((MethodImplOptions)768)]
        public readonly void CopyTo(T[]? array) => CopyTo(array, 0);
        
        /// <summary>Copies the elements of the vector to a specified array starting at a specified index position.</summary>
        /// <param name="array">The destination array.</param>
        /// <param name="index">The index at which to copy the first element of the vector.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"> is <c>null</c></paramref></exception>
        /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"> is less then zero.</paramref></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="index"> is greater then or equal to the array length.</paramref></exception>
        /// <exception cref="RankException"><paramref name="array"> is multidimensional.</paramref></exception>
        /// <remarks>array must have a sufficient number of elements to accommodate the two vector elements. In other words, elements index and index + 1 must already exist in array.</remarks>
        [MethodImpl((MethodImplOptions)768)]
        public readonly void CopyTo(T[]? array, int index)
        {
            if (array is null)
            {
                throw new NullReferenceException("Object reference not set to an instance of an object.");
            }

            if ((index < 0) || (index >= array.Length))
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Specified argument was out of the range of valid values.");
            }

            if ((array.Length - index) < 2)
            {
                throw new ArgumentException("Value does not fall within the expected range.");
            }

            array[index] = X;
            array[index + 1] = Y;
        }

        /// <summary>Returns a boolean indicating whether the given Vector2 is equal to this Vector2 instance.</summary>
        /// <param name="other">The Vector2 to compare this instance to.</param>
        /// <returns>True if the other Vector2 is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Vector2<T> other) => this == other;
        
        /// <summary>Returns a boolean indicating whether the given Object is equal to this Vector2 instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Vector2; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public override readonly bool Equals(object? obj) => (obj is Vector2<T> other) && Equals(other);
        
        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        /// <summary>Returns the length of the vector.</summary>
        /// <value>The vector's length.</value>
        public T Length
        {
            [MethodImpl((MethodImplOptions)768)]
            get => Scalar.Sqrt(LengthSquared);
        }

        /// <summary>Returns the length of the vector squared. This operation is cheaper than Length().</summary>
        /// <returns>The vector's length squared.</returns>
        public readonly T LengthSquared
        {
            [MethodImpl((MethodImplOptions) 768)] get => Vector2.Dot(this, this);
        }

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right)
            => new(Scalar.Add(left.X, right.X), Scalar.Add(left.Y, right.Y));

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator /(Vector2<T> left, Vector2<T> right)
            => new(Scalar.Divide(left.X, right.X), Scalar.Divide(left.Y, right.Y));

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator /(Vector2<T> value1, T value2)
            => new(Scalar.Divide(value1.X, value2), Scalar.Divide(value1.Y, value2));

        /// <summary>Returns a boolean indicating whether the two given vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are equal; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static bool operator ==(Vector2<T> left, Vector2<T> right)
            => Scalar.Equal(left.X, right.X) && Scalar.Equal(left.Y, right.Y);

        /// <summary>Returns a boolean indicating whether the two given vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are not equal; False if they are equal.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static bool operator !=(Vector2<T> left, Vector2<T> right) => !(left == right);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator *(Vector2<T> left, Vector2<T> right)
            => new(Scalar.Multiply(left.X, right.X), Scalar.Multiply(left.Y, right.Y));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator *(Vector2<T> left, T right)
            => new(Scalar.Multiply(left.X, right), Scalar.Multiply(left.Y, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator *(T left, Vector2<T> right) => right * left;

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right)
            => new(Scalar.Subtract(left.X, right.X), Scalar.Subtract(left.Y, right.Y));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> operator -(Vector2<T> value) => Zero - value;

        /// <summary>Returns a String representing this Vector2 instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() => ToString("G", CultureInfo.CurrentCulture);
        
        /// <summary>Returns a String representing this Vector2 instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this Vector2 instance, using the specified format to format individual elements and the given IFormatProvider.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <param name="formatProvider">The format provider to use when formatting elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }

        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Vector2<Half>(Vector2<T> from)
            => new(Scalar.As<T, Half>(from.X), Scalar.As<T, Half>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Vector2<float>(Vector2<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Vector2<double>(Vector2<T> from)
            => new(Scalar.As<T, double>(from.X), Scalar.As<T, double>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Vector2<decimal>(Vector2<T> from)
            => new(Scalar.As<T, decimal>(from.X), Scalar.As<T, decimal>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Vector2<sbyte>(Vector2<T> from)
            => new(Scalar.As<T, sbyte>(from.X), Scalar.As<T, sbyte>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Vector2<byte>(Vector2<T> from)
            => new(Scalar.As<T, byte>(from.X), Scalar.As<T, byte>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Vector2<ushort>(Vector2<T> from)
            => new(Scalar.As<T, ushort>(from.X), Scalar.As<T, ushort>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Vector2<short>(Vector2<T> from)
            => new(Scalar.As<T, short>(from.X), Scalar.As<T, short>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Vector2<uint>(Vector2<T> from)
            => new(Scalar.As<T, uint>(from.X), Scalar.As<T, uint>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Vector2<int>(Vector2<T> from)
            => new(Scalar.As<T, int>(from.X), Scalar.As<T, int>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Vector2<ulong>(Vector2<T> from)
            => new(Scalar.As<T, ulong>(from.X), Scalar.As<T, ulong>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Vector2<long>(Vector2<T> from)
            => new(Scalar.As<T, long>(from.X), Scalar.As<T, long>(from.Y));
    }

    public static class Vector2
    {
        /// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
        /// <param name="value">A vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Abs<T>(Vector2<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Abs(value.X), Scalar.Abs(value.Y));

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first vector to add.</param>
        /// <param name="right">The second vector to add.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Add<T>(Vector2<T> left, Vector2<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Add(left.X, right.X), Scalar.Add(left.Y, right.Y));

        /// <summary>Restricts a vector between a minimum and a maximum value.</summary>
        /// <param name="value1">The vector to restrict.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Clamp<T>(Vector2<T> value1, Vector2<T> min, Vector2<T> max) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);
        
        /// <summary>Computes the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T Distance<T>(Vector2<T> value1, Vector2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between two specified points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T DistanceSquared<T>(Vector2<T> value1, Vector2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Divide<T>(Vector2<T> left, Vector2<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Divide(left.X, right.X), Scalar.Divide(left.Y, right.Y));

        /// <summary>Divides the specified vector by a specified scalar value.</summary>
        /// <param name="left">The vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The vector that results from the division.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Divide<T>(Vector2<T> left, T divisor)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Divide(left.X, divisor), Scalar.Divide(left.Y, divisor));

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="value1">The first vector.</param>
        /// <param name="value2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T Dot<T>(Vector2<T> value1, Vector2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Add(Scalar.Multiply(value1.X, value2.X), Scalar.Multiply(value1.Y, value2.Y));
        
        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Lerp<T>(Vector2<T> value1, Vector2<T> value2, T amount)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => (value1 * Scalar.Subtract(Scalar<T>.One, amount)) + (value2 * amount);

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors</summary>
        /// <param name="value1">The first source vector</param>
        /// <param name="value2">The second source vector</param>
        /// <returns>The maximized vector</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Max<T>(Vector2<T> value1, Vector2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Max(value1.X, value2.X), Scalar.Max(value1.Y, value2.Y));
        
        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Min<T>(Vector2<T> value1, Vector2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Min(value1.X, value2.X), Scalar.Min(value1.Y, value2.Y));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Multiply<T>(Vector2<T> left, Vector2<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Multiply(left.X, right.X), Scalar.Multiply(left.Y, right.Y));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Multiply<T>(Vector2<T> left, T right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Multiply(left.X, right), Scalar.Multiply(left.Y, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Multiply<T>(T left, Vector2<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Multiply(left, right.X), Scalar.Multiply(left, right.Y));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Negate<T>(Vector2<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="value">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Normalize<T>(Vector2<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value / value.Length;
        
        /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="normal">The normal of the surface being reflected off.</param>
        /// <returns>The reflected vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Reflect<T>(Vector2<T> vector, Vector2<T> normal) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => vector - Scalar.Multiply(Scalar<T>.Two, Dot(vector, normal)) * normal;

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> SquareRoot<T>(Vector2<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Sqrt(value.X), Scalar.Sqrt(value.Y));

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Subtract<T>(Vector2<T> left, Vector2<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left - right;
        
        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2<T> Transform<T>(Vector2<T> position, Matrix4x4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M11), Scalar.Multiply(position.Y, matrix.M21)),matrix.M41),
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M12), Scalar.Multiply(position.Y, matrix.M22)),matrix.M42)
            );
        }

        /// <summary>Transforms a vector normal by the given matrix.</summary>
        /// <param name="normal">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2<T> TransformNormal<T>(Vector2<T> normal, Matrix4x4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Multiply(normal.X, matrix.M11), Scalar.Multiply(normal.Y, matrix.M21)),
                Scalar.Add(Scalar.Multiply(normal.X, matrix.M12), Scalar.Multiply(normal.Y, matrix.M22)));
        }

        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2<T> Transform<T>(Vector2<T> value, Quaternion<T> rotation)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            T x2 = Scalar.Add(rotation.X, rotation.X);
            T y2 = Scalar.Add(rotation.Y, rotation.Y);
            T z2 = Scalar.Add(rotation.Z, rotation.Z);
            
            T wz2 = Scalar.Multiply(rotation.W, z2);
            T xx2 = Scalar.Multiply(rotation.X, x2);
            T xy2 = Scalar.Multiply(rotation.X, y2);
            T yy2 = Scalar.Multiply(rotation.Y, y2);
            T zz2 = Scalar.Multiply(rotation.Z, z2);

            return new(
                Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2)), Scalar.Multiply(value.Y, Scalar.Subtract(xy2, wz2))),
                Scalar.Add(Scalar.Multiply(value.X, Scalar.Add(xy2, wz2)), Scalar.Multiply(value.Y, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2)))
            );
        }

        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2<T> Transform<T>(Vector2<T> position, Matrix3x2<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M11), Scalar.Multiply(position.Y, matrix.M21)), matrix.M31),
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M12), Scalar.Multiply(position.Y, matrix.M22)), matrix.M32)
            );
        }

        /// <summary>Transforms a vector normal by the given matrix.</summary>
        /// <param name="normal">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2<T> TransformNormal<T>(Vector2<T> normal, Matrix3x2<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Multiply(normal.X, matrix.M11), Scalar.Multiply(normal.Y, matrix.M21)),
                Scalar.Add(Scalar.Multiply(normal.X, matrix.M12), Scalar.Multiply(normal.Y, matrix.M22))
            );
        }
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Multiply<T>(Vector2<T> value1, Matrix2x4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector3<T> Multiply<T>(Vector2<T> value1, Matrix2x3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Multiply<T>(Vector2<T> value1, Matrix2x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
    }
}
