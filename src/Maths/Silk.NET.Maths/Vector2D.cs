// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    public struct Vector2D<T>
        : IEquatable<Vector2D<T>>, IFormattable
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The X component of the vector.</summary>
        [DataMember]
        public T X;

        /// <summary>The Y component of the vector.</summary>
        [DataMember]
        public T Y;

        /// <summary>Creates a new <see cref="Vector2D{T}"/> object whose two elements have the same value.</summary>
        /// <param name="value">The value to assign to both elements.</param>
        public Vector2D(T value) => (X, Y) = (value, value);

        /// <summary>Creates a vector whose elements have the specified values.</summary>
        /// <param name="x">The value to assign to the <see cref="X"/> field.</param>
        /// <param name="y">The value to assign to the <see cref="Y"/> field.</param>
        public Vector2D(T x, T y) => (X, Y) = (x, y);

        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2D<T> One => new(Scalar<T>.One);

        /// <summary>Gets the vector (1,0).</summary>
        public static Vector2D<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0,1).</summary>
        public static Vector2D<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2D<T> Zero => default;

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
        [MethodImpl((MethodImplOptions) 768)]
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
        [MethodImpl((MethodImplOptions) 768)]
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

        /// <summary>Returns a boolean indicating whether the given <see cref="Vector2D{T}"/> is equal to this <see cref="Vector2D{T}"/> instance.</summary>
        /// <param name="other">The <see cref="Vector2D{T}"/> to compare this instance to.</param>
        /// <returns>True if the other <see cref="Vector2D{T}"/> is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Vector2D<T> other) => this == other;

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Vector2D{T}"/> instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Vector2D; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public override readonly bool Equals(object? obj) => (obj is Vector2D<T> other) && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        /// <summary>Returns the length of the vector.</summary>
        /// <value>The vector's length.</value>
        public T Length
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => Scalar.Sqrt(LengthSquared);
        }

        /// <summary>Returns the length of the vector squared. This operation is cheaper than Length().</summary>
        /// <returns>The vector's length squared.</returns>
        public readonly T LengthSquared
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => Vector2D.Dot(this, this);
        }

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator +(Vector2D<T> left, Vector2D<T> right)
            => new(Scalar.Add(left.X, right.X), Scalar.Add(left.Y, right.Y));

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator /(Vector2D<T> left, Vector2D<T> right)
            => new(Scalar.Divide(left.X, right.X), Scalar.Divide(left.Y, right.Y));

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator /(Vector2D<T> value1, T value2)
            => new(Scalar.Divide(value1.X, value2), Scalar.Divide(value1.Y, value2));

        /// <summary>Returns a boolean indicating whether the two given vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are equal; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static bool operator ==(Vector2D<T> left, Vector2D<T> right)
            => Scalar.Equal(left.X, right.X) && Scalar.Equal(left.Y, right.Y);

        /// <summary>Returns a boolean indicating whether the two given vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are not equal; False if they are equal.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static bool operator !=(Vector2D<T> left, Vector2D<T> right) => !(left == right);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator *(Vector2D<T> left, Vector2D<T> right)
            => new(Scalar.Multiply(left.X, right.X), Scalar.Multiply(left.Y, right.Y));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator *(Vector2D<T> left, T right)
            => new(Scalar.Multiply(left.X, right), Scalar.Multiply(left.Y, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator *(T left, Vector2D<T> right) => right * left;

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator -(Vector2D<T> left, Vector2D<T> right)
            => new(Scalar.Subtract(left.X, right.X), Scalar.Subtract(left.Y, right.Y));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> operator -(Vector2D<T> value) => Zero - value;

        /// <summary>Returns a String representing this <see cref="Vector2D{T}"/> instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() => ToString("G", CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this <see cref="Vector2D{T}"/> instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this <see cref="Vector2D{T}"/> instance, using the specified format to format individual elements and the given IFormatProvider.</summary>
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
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Vector2D<Half>(Vector2D<T> from)
            => new(Scalar.As<T, Half>(from.X), Scalar.As<T, Half>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Vector2D<float>(Vector2D<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into <see cref="System.Numerics.Vector2"/>
        /// </summary>
        /// <param name="from">The source vector</param>
        /// <returns>The <see cref="System.Numerics"/> vector</returns>
        public static explicit operator System.Numerics.Vector2(Vector2D<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y));
        
        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Vector2D<double>(Vector2D<T> from)
            => new(Scalar.As<T, double>(from.X), Scalar.As<T, double>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Vector2D<decimal>(Vector2D<T> from)
            => new(Scalar.As<T, decimal>(from.X), Scalar.As<T, decimal>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Vector2D<sbyte>(Vector2D<T> from)
            => new(Scalar.As<T, sbyte>(from.X), Scalar.As<T, sbyte>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Vector2D<byte>(Vector2D<T> from)
            => new(Scalar.As<T, byte>(from.X), Scalar.As<T, byte>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Vector2D<ushort>(Vector2D<T> from)
            => new(Scalar.As<T, ushort>(from.X), Scalar.As<T, ushort>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Vector2D<short>(Vector2D<T> from)
            => new(Scalar.As<T, short>(from.X), Scalar.As<T, short>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Vector2D<uint>(Vector2D<T> from)
            => new(Scalar.As<T, uint>(from.X), Scalar.As<T, uint>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Vector2D<int>(Vector2D<T> from)
            => new(Scalar.As<T, int>(from.X), Scalar.As<T, int>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Vector2D<ulong>(Vector2D<T> from)
            => new(Scalar.As<T, ulong>(from.X), Scalar.As<T, ulong>(from.Y));

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Vector2D<long>(Vector2D<T> from)
            => new(Scalar.As<T, long>(from.X), Scalar.As<T, long>(from.Y));
        
        /// <summary>
        /// Returns this vector casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted vector</returns>
        public Vector2D<TOther> As<TOther>() where TOther : unmanaged, IFormattable, IEquatable<TOther>, IComparable<TOther>
        {
            return new(Scalar.As<T, TOther>(X), Scalar.As<T, TOther>(Y));
        }
    }
}
