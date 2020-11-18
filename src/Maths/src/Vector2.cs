using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Toolkit.Diagnostics;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating two values and provides hardware accelerated methods.</summary>
    public struct Vector2<T>
        : IEquatable<Vector2<T>>, IFormattable 
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;
        
        /// <summary>The Y component of the vector.</summary>
        public T Y;
        
        /// <summary>Creates a new <see cref="Vector2{T}"/> object whose two elements have the same value.</summary>
        /// <param name="value">The value to assign to both elements.</param>
        public Vector2(T value) => (X, Y) = (value, value);
        
        /// <summary>Creates a vector whose elements have the specified values.</summary>
        /// <param name="x">The value to assign to the <see cref="X"/> field.</param>
        /// <param name="y">The value to assign to the <see cref="Y"/> field.</param>
        public Vector2(T x, T y) => (X, Y) = (x, y);
        
        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2<T> One => new(Constants<T>.One);
        
        /// <summary>Gets the vector (1,0).</summary>
        public static Vector2<T> UnitX => new(Constants<T>.One, Constants<T>.Zero);
        
        /// <summary>Gets the vector (0,1).</summary>
        public static Vector2<T> UnitY => new(Constants<T>.Zero, Constants<T>.One);
        
        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2<T> Zero => default;

        /// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
        /// <param name="value">A vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Abs(Vector2<T> value) => new(Operations.Abs(value.X), Operations.Abs(value.Y));

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first vector to add.</param>
        /// <param name="right">The second vector to add.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Add(Vector2<T> left, Vector2<T> right)
            => new(Operations.Add(left.X, right.X), Operations.Add(left.Y, right.Y));

        /// <summary>Restricts a vector between a minimum and a maximum value.</summary>
        /// <param name="value1">The vector to restrict.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Clamp(Vector2<T> value1, Vector2<T> min, Vector2<T> max) 
            // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);

        /// <summary>Copies the elements of the vector to a specified array.</summary>
        /// <param name="array">The destination array.</param>
        /// <exception cref="ArgumentNullException"><param name="array"> is <c>null</c></param></exception>
        /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
        /// <exception cref="RankException"><param name="array"> is multidimensional.</param></exception>
        /// <remarks><param name="array"></param> must have at least two elements. The method copies the vector's elements starting at index 0.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(T[] array) => CopyTo(array, 0);
        
        /// <summary>Copies the elements of the vector to a specified array starting at a specified index position.</summary>
        /// <param name="array">The destination array.</param>
        /// <param name="index">The index at which to copy the first element of the vector.</param>
        /// <exception cref="ArgumentNullException"><param name="array"> is <c>null</c></param></exception>
        /// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><param name="index"> is less then zero.</param></exception>
        /// <exception cref="ArgumentOutOfRangeException"><param name="index"> is greater then or equal to the array length.</param></exception>
        /// <exception cref="RankException"><param name="array"> is multidimensional.</param></exception>
        /// <remarks>array must have a sufficient number of elements to accommodate the two vector elements. In other words, elements index and index + 1 must already exist in array.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(T[] array, int index)
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

        /// <summary>Computes the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Distance(Vector2<T> value1, Vector2<T> value2)
            => Operations.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between two specified points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DistanceSquared(Vector2<T> value1, Vector2<T> value2)
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Divide(Vector2<T> left, Vector2<T> right)
            => new(Operations.Divide(left.X, right.X), Operations.Divide(left.Y, right.Y));

        /// <summary>Divides the specified vector by a specified scalar value.</summary>
        /// <param name="left">The vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The vector that results from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Divide(Vector2<T> left, T divisor)
            => new(Operations.Divide(left.X, divisor), Operations.Divide(left.Y, divisor));

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="value1">The first vector.</param>
        /// <param name="value2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Dot(Vector2<T> value1, Vector2<T> value2)
            => Operations.Add(Operations.Multiply(value1.X, value2.X), Operations.Multiply(value1.Y, value2.Y));

        /// <summary>Returns a boolean indicating whether the given Vector2 is equal to this Vector2 instance.</summary>
        /// <param name="other">The Vector2 to compare this instance to.</param>
        /// <returns>True if the other Vector2 is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Vector2<T> other) => this == other;
        
        /// <summary>Returns a boolean indicating whether the given Object is equal to this Vector2 instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Vector2; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => (obj is Vector2<T> other) && Equals(other);
        
        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() => HashCode.Combine(X, Y);

        /// <summary>Returns the length of the vector.</summary>
        /// <returns>The vector's length.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T Length() => Operations.Sqrt(LengthSquared());
        
        /// <summary>Returns the length of the vector squared. This operation is cheaper than Length().</summary>
        /// <returns>The vector's length squared.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T LengthSquared() => Dot(this, this);

        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Lerp(Vector2<T> value1, Vector2<T> value2, T amount)
            => (value1 * Operations.Subtract(Constants<T>.One, amount)) + (value2 * amount);

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors</summary>
        /// <param name="value1">The first source vector</param>
        /// <param name="value2">The second source vector</param>
        /// <returns>The maximized vector</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Max(Vector2<T> value1, Vector2<T> value2)
            => new(Operations.Max(value1.X, value2.X), Operations.Max(value1.Y, value2.Y));
        
        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Min(Vector2<T> value1, Vector2<T> value2)
            => new(Operations.Min(value1.X, value2.X), Operations.Min(value1.Y, value2.Y));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Multiply(Vector2<T> left, Vector2<T> right)
            => new(Operations.Multiply(left.X, right.X), Operations.Multiply(left.Y, right.Y));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Multiply(Vector2<T> left, T right)
            => new(Operations.Multiply(left.X, right), Operations.Multiply(left.Y, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Multiply(T left, Vector2<T> right)
            => new(Operations.Multiply(left, right.X), Operations.Multiply(left, right.Y));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Negate(Vector2<T> value) => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="value">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Normalize(Vector2<T> value) => value / value.Length();

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right)
            => new(Operations.Add(left.X, right.X), Operations.Add(left.Y, right.Y));

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator /(Vector2<T> left, Vector2<T> right)
            => new(Operations.Divide(left.X, right.X), Operations.Divide(left.Y, right.Y));

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator /(Vector2<T> value1, T value2)
            => new(Operations.Divide(value1.X, value2), Operations.Divide(value1.Y, value2));

        /// <summary>Returns a boolean indicating whether the two given vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are equal; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector2<T> left, Vector2<T> right)
            => Operations.Equal(left.X, right.X) && Operations.Equal(left.Y, right.Y);

        /// <summary>Returns a boolean indicating whether the two given vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are not equal; False if they are equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector2<T> left, Vector2<T> right) => !(left == right);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator *(Vector2<T> left, Vector2<T> right)
            => new(Operations.Multiply(left.X, right.X), Operations.Multiply(left.Y, right.Y));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator *(Vector2<T> left, T right)
            => new(Operations.Multiply(left.X, right), Operations.Multiply(left.Y, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator *(T left, Vector2<T> right) => right * left;

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right)
            => new(Operations.Subtract(left.X, right.X), Operations.Subtract(left.Y, right.Y));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> operator -(Vector2<T> value) => Zero - value;

        /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="normal">The normal of the surface being reflected off.</param>
        /// <returns>The reflected vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Reflect(Vector2<T> vector, Vector2<T> normal) 
            => vector - Operations.Multiply(Constants<T>.Two, Dot(vector, normal)) * normal;

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> SquareRoot(Vector2<T> value)
            => new(Operations.Sqrt(value.X), Operations.Sqrt(value.Y));

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2<T> Subtract(Vector2<T> left, Vector2<T> right) => left - right;

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

        public static Vector2<T> Transform(Vector2<T> position, Matrix4x4<T> matrix)
        {
            return new(
                Operations.Add(Operations.Add(Operations.Multiply(position.X, matrix.M11), Operations.Multiply(position.Y, matrix.M21)),matrix.M41),
                Operations.Add(Operations.Add(Operations.Multiply(position.X, matrix.M12), Operations.Multiply(position.Y, matrix.M22)),matrix.M42)
            );
        }

        public static Vector2<T> TransformNormal(Vector2<T> normal, Matrix4x4<T> matrix)
        {
            return new(
                Operations.Add(Operations.Multiply(normal.X, matrix.M11), Operations.Multiply(normal.Y, matrix.M21)),
                Operations.Add(Operations.Multiply(normal.X, matrix.M12), Operations.Multiply(normal.Y, matrix.M22)));
        }
        
        // TODO: Matrix3x2
        // public static Vector2<T> Transform(Vector2<T> position, Matrix3x2<T> matrix) { throw null; }
        // TODO: Quaternion
        // public static Vector2<T> Transform(Vector2<T> value, Quaternion<T> rotation) { throw null; }
        // public static Vector2<T> TransformNormal(Vector2<T> normal, Matrix3x2<T> matrix) { throw null; }
    }
}
