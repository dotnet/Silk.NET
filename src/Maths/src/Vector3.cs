using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating three values and provides hardware accelerated methods.</summary>
    public struct Vector3<T>
        : IEquatable<Vector3<T>>, IFormattable
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>Constructs a vector whose elements are all the single specified value.</summary>
        /// <param name="value">The element to fill the vector with.</param>
        public Vector3(T value) => (X, Y, Z) = (value, value, value);

        /// <summary>Constructs a Vector3 from the given Vector2 and a third value.</summary>
        /// <param name="value">The Vector to extract X and Y components from.</param>
        /// <param name="z">The Z component.</param>
        public Vector3(Vector2<T> value, T z) => (X, Y, Z) = (value.X, value.Y, z);

        /// <summary>Constructs a vector with the given individual elements.</summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public Vector3(T x, T y, T z) => (X, Y, Z) = (x, y, z);

        /// <summary>Returns the vector (0,0,0).</summary>
        public static Vector3<T> Zero => default;

        /// <summary>Returns the vector (1,1,1).</summary>
        public static Vector3<T> One => new(Constants<T>.One);

        /// <summary>Returns the vector (1,0,0).</summary>
        public static Vector3<T> UnitX => new(Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero);

        /// <summary>Returns the vector (0,1,0).</summary>
        public static Vector3<T> UnitY => new(Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero);

        /// <summary>Returns the vector (0,0,1).</summary>
        public static Vector3<T> UnitZ => new(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One);

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator +(Vector3<T> left, Vector3<T> right)
            => new(Operations.Add(left.X, right.X), Operations.Add(left.Y, right.Y), Operations.Add(left.Z, right.Z));

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator /(Vector3<T> left, Vector3<T> right)
            => new(Operations.Divide(left.X, right.X), Operations.Divide(left.Y, right.Y),
                Operations.Divide(left.Z, right.Z));

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator /(Vector3<T> value1, T value2)
            => new(Operations.Divide(value1.X, value2), Operations.Divide(value1.Y, value2),
                Operations.Divide(value1.Z, value2));

        /// <summary>Returns a boolean indicating whether the two given vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are equal; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector3<T> left, Vector3<T> right)
            => Operations.Equal(left.X, right.X) 
            && Operations.Equal(left.Y, right.Y) 
            && Operations.Equal(left.Z, right.Z);

        /// <summary>Returns a boolean indicating whether the two given vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns>True if the vectors are not equal; False if they are equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector3<T> left, Vector3<T> right) => !(left == right);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator *(Vector3<T> left, Vector3<T> right)
            => new(Operations.Multiply(left.X, right.X), Operations.Multiply(left.Y, right.Y),
                Operations.Multiply(left.Z, right.Z));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator *(Vector3<T> left, T right)
            => new(Operations.Multiply(left.X, right), Operations.Multiply(left.Y, right),
                Operations.Multiply(left.Z, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator *(T left, Vector3<T> right) 
            => right * left;

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator -(Vector3<T> left, Vector3<T> right)
            => new(Operations.Subtract(left.X, right.X), Operations.Subtract(left.Y, right.Y),
                Operations.Subtract(left.Z, right.Z));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> operator -(Vector3<T> value)
            => Zero - value;

        /// <summary>Returns a vector whose elements are the absolute values of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Abs(Vector3<T> value) 
            => new(Operations.Abs(value.X), Operations.Abs(value.Y), Operations.Abs(value.Z));

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Add(Vector3<T> left, Vector3<T> right) 
            => left + right;

        /// <summary>Restricts a vector between a min and max value.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Clamp(Vector3<T> value1, Vector3<T> min, Vector3<T> max) 
            // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);

        /// <summary>Computes the cross product of two vectors.</summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The cross product.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Cross(Vector3<T> vector1, Vector3<T> vector2)
            => new(
                Operations.Subtract(Operations.Multiply(vector1.Y, vector2.Z),
                    Operations.Multiply(vector1.Z, vector2.Y)),
                Operations.Subtract(Operations.Multiply(vector1.Z, vector2.X),
                    Operations.Multiply(vector1.X, vector2.Z)),
                Operations.Subtract(Operations.Multiply(vector1.X, vector2.Y),
                    Operations.Multiply(vector1.Y, vector2.X)));

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Distance(Vector3<T> value1, Vector3<T> value2)
            => Operations.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DistanceSquared(Vector3<T> value1, Vector3<T> value2)
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Divide(Vector3<T> left, Vector3<T> right) 
            => left / right;

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Divide(Vector3<T> left, T divisor) 
            => left / divisor;

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Dot(Vector3<T> vector1, Vector3<T> vector2)
            => Operations.Add(
                Operations.Add(Operations.Multiply(vector1.X, vector2.X),
                    Operations.Multiply(vector1.Y, vector2.Y)),
                Operations.Multiply(vector1.Z, vector2.Z));

        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Lerp(Vector3<T> value1, Vector3<T> value2, T amount)
        {
            return (value1 * Operations.Subtract(Constants<T>.One, amount) + (value2 * amount));
        }

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The maximized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Max(Vector3<T> value1, Vector3<T> value2)
            => new(Operations.Max(value1.X, value2.X), Operations.Max(value1.Y, value2.Y),
                Operations.Max(value1.Z, value2.Z));

        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        public static Vector3<T> Min(Vector3<T> value1, Vector3<T> value2)
            => new(Operations.Min(value1.X, value2.X), Operations.Min(value1.Y, value2.Y),
                Operations.Min(value1.Z, value2.Z));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Multiply(Vector3<T> left, Vector3<T> right) 
            => left * right;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Multiply(Vector3<T> left, T right) 
            => left * right;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Multiply(T left, Vector3<T> right)
            => left * right;

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Negate(Vector3<T> value)
            => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="value">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Normalize(Vector3<T> value) 
            => value / value.Length();

        /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="normal">The normal of the surface being reflected off.</param>
        /// <returns>The reflected vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Reflect(Vector3<T> vector, Vector3<T> normal) 
            => vector - (Operations.Multiply(Constants<T>.Two, Dot(vector, normal)) * normal);

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> SquareRoot(Vector3<T> value)
            => new(Operations.Sqrt(value.X), Operations.Sqrt(value.Y), Operations.Sqrt(value.Z));

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Subtract(Vector3<T> left, Vector3<T> right) 
            => left - right;
        
        
        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Transform(Vector3<T> position, Matrix4x4<T> matrix) // TODO: Matrix4x3
        {
            return new(
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(position.X, matrix.M11), Operations.Multiply(position.Y, matrix.M21)), Operations.Multiply(position.Z, matrix.M31)), matrix.M41),
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(position.X, matrix.M12), Operations.Multiply(position.Y, matrix.M22)), Operations.Multiply(position.Z, matrix.M32)), matrix.M42),
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(position.X, matrix.M13), Operations.Multiply(position.Y, matrix.M23)), Operations.Multiply(position.Z, matrix.M33)), matrix.M43)
            );
        }

        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Transform(Vector3<T> value, Quaternion<T> rotation)
        {
            T x2 = Operations.Add(rotation.X, rotation.X);
            T y2 = Operations.Add(rotation.Y, rotation.Y);
            T z2 = Operations.Add(rotation.Z, rotation.Z);

            T wx2 = Operations.Multiply(rotation.W, x2);
            T wy2 = Operations.Multiply(rotation.W, y2);
            T wz2 = Operations.Multiply(rotation.W, z2);
            T xx2 = Operations.Multiply(rotation.X, x2);
            T xy2 = Operations.Multiply(rotation.X, y2);
            T xz2 = Operations.Multiply(rotation.X, z2);
            T yy2 = Operations.Multiply(rotation.Y, y2);
            T yz2 = Operations.Multiply(rotation.Y, z2);
            T zz2 = Operations.Multiply(rotation.Z, z2);

            return new(
                Operations.Add(Operations.Add(Operations.Multiply(value.X, Operations.Subtract(Operations.Subtract(Constants<T>.One, yy2), zz2)), Operations.Multiply(value.Y, Operations.Subtract(xy2, wz2))), Operations.Multiply(value.Z, Operations.Add(xz2, wy2))),
                Operations.Add(Operations.Add(Operations.Multiply(value.X, Operations.Add(xy2, wz2)), Operations.Multiply(value.Y, Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), zz2))), Operations.Multiply(value.Z, Operations.Subtract(yz2, wx2))),
                Operations.Add(Operations.Add(Operations.Multiply(value.X, Operations.Subtract(xz2, wy2)), Operations.Multiply(value.Y, Operations.Add(yz2, wx2))), Operations.Multiply(value.Z, Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), yy2)))
            );
        }
        

        
        /// <summary>Transforms a vector normal by the given matrix.</summary>
        /// <param name="normal">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> TransformNormal(Vector3<T> normal, Matrix4x4<T> matrix) // TODO: Matrix3x3
        {
            return new(
                Operations.Add(Operations.Add(Operations.Multiply(normal.X, matrix.M11), Operations.Multiply(normal.Y, matrix.M21)), Operations.Multiply(normal.Z, matrix.M31)),
                Operations.Add(Operations.Add(Operations.Multiply(normal.X, matrix.M12), Operations.Multiply(normal.Y, matrix.M22)), Operations.Multiply(normal.Z, matrix.M32)),
                Operations.Add(Operations.Add(Operations.Multiply(normal.X, matrix.M13), Operations.Multiply(normal.Y, matrix.M23)), Operations.Multiply(normal.Z, matrix.M33))
            );
        }
        
        /// <summary>Copies the contents of the vector into the given array.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void CopyTo(T[]? array) 
            => CopyTo(array, 0);

        /// <summary>Copies the contents of the vector into the given array, starting from index.</summary>
        /// <exception cref="ArgumentNullException">If array is null.</exception>
        /// <exception cref="RankException">If array is multidimensional.</exception>
        /// <exception cref="ArgumentOutOfRangeException">If index is greater than end of the array or index is less than zero.</exception>
        /// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination array.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            if ((array.Length - index) < 3)
            {
                throw new ArgumentException("Value does not fall within the expected range.");
            }

            array[index] = X;
            array[index + 1] = Y;
            array[index + 2] = Z;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Vector3 instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Vector3; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
        {
            return (obj is Vector3<T> other) && Equals(other);
        }

        /// <summary>Returns a boolean indicating whether the given Vector3 is equal to this Vector3 instance.</summary>
        /// <param name="other">The Vector3 to compare this instance to.</param>
        /// <returns>True if the other Vector3 is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Vector3<T> other)
        {
            return this == other;
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        /// <summary>Returns the length of the vector.</summary>
        /// <returns>The vector's length.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T Length() => Operations.Sqrt(LengthSquared());

        /// <summary>Returns the length of the vector squared. This operation is cheaper than Length().</summary>
        /// <returns>The vector's length squared.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T LengthSquared() => Dot(this, this);

        /// <summary>Returns a String representing this Vector3 instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() => ToString("G", CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this Vector3 instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this Vector3 instance, using the specified format to format individual elements and the given IFormatProvider.</summary>
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
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Z.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }
    }
}
