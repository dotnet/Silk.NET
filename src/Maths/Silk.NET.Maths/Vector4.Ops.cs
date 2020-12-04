// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Vector4{T}"/>
    /// </summary>
    public static class Vector4
    {
        /// <summary>Returns a vector whose elements are the absolute values of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Abs<T>(Vector4<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>            
            => new(
                Scalar.Abs(value.X),
                Scalar.Abs(value.Y),
                Scalar.Abs(value.Z),
                Scalar.Abs(value.W)
            );

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Add<T>(Vector4<T> left, Vector4<T> right) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left + right;

        /// <summary>Restricts a vector between a min and max value.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Clamp<T>(Vector4<T> value1, Vector4<T> min, Vector4<T> max)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T Distance<T>(Vector4<T> value1, Vector4<T> value2) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T DistanceSquared<T>(Vector4<T> value1, Vector4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Divide<T>(Vector4<T> left, Vector4<T> right) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left / right;

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Divide<T>(Vector4<T> left, T divisor) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left / divisor;

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T Dot<T>(Vector4<T> vector1, Vector4<T> vector2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Add(
                Scalar.Add(
                    Scalar.Add(Scalar.Multiply(vector1.X, vector2.X),
                        Scalar.Multiply(vector1.Y, vector2.Y)), Scalar.Multiply(vector1.Z, vector2.Z)),
                Scalar.Multiply(vector1.W, vector2.W));

        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Lerp<T>(Vector4<T> value1, Vector4<T> value2, T amount) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => (value1 * Scalar.Subtract(Scalar<T>.One, amount)) + (value2 * amount);

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The maximized vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Max<T>(Vector4<T> value1, Vector4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Max(value1.X, value2.X), Scalar.Max(value1.Y, value2.Y),
                Scalar.Max(value1.Z, value2.Z), Scalar.Max(value1.W, value2.W));

        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Min<T>(Vector4<T> value1, Vector4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Min(value1.X, value2.X), Scalar.Min(value1.Y, value2.Y),
                Scalar.Min(value1.Z, value2.Z), Scalar.Min(value1.W, value2.W));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Multiply<T>(Vector4<T> left, Vector4<T> right) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left * right;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Multiply<T>(Vector4<T> value1, Matrix4x4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector3<T> Multiply<T>(Vector4<T> value1, Matrix4x3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Multiply<T>(Vector4<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Multiply<T>(Vector4<T> left, T right) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left * right;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Multiply<T>(T left, Vector4<T> right) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left * right;

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Negate<T>(Vector4<T> value) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="vector">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Normalize<T>(Vector4<T> vector) 
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => vector / vector.Length;

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> SquareRoot<T>(Vector4<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(Scalar.Sqrt(value.X), Scalar.Sqrt(value.Y), Scalar.Sqrt(value.Z),
                Scalar.Sqrt(value.W));
        }

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Subtract<T>(Vector4<T> left, Vector4<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left - right;

        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Transform<T>(Vector2<T> position, Matrix4x4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M11), Scalar.Multiply(position.Y, matrix.M21)), matrix.M41),
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M12), Scalar.Multiply(position.Y, matrix.M22)), matrix.M42),
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M13), Scalar.Multiply(position.Y, matrix.M23)), matrix.M43),
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M14), Scalar.Multiply(position.Y, matrix.M24)), matrix.M44)
            );
        }

        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Transform<T>(Vector2<T> value, Quaternion<T> rotation)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            T x2 = Scalar.Add(rotation.X, rotation.X);
            T y2 = Scalar.Add(rotation.Y, rotation.Y);
            T z2 = Scalar.Add(rotation.Z, rotation.Z);

            T wx2 = Scalar.Multiply(rotation.W, x2);
            T wy2 = Scalar.Multiply(rotation.W, y2);
            T wz2 = Scalar.Multiply(rotation.W, z2);
            T xx2 = Scalar.Multiply(rotation.X, x2);
            T xy2 = Scalar.Multiply(rotation.X, y2);
            T xz2 = Scalar.Multiply(rotation.X, z2);
            T yy2 = Scalar.Multiply(rotation.Y, y2);
            T yz2 = Scalar.Multiply(rotation.Y, z2);
            T zz2 = Scalar.Multiply(rotation.Z, z2);

            return new(
                Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2)), Scalar.Multiply(value.Y, Scalar.Subtract(xy2, wz2))),
                Scalar.Add(Scalar.Multiply(value.X, Scalar.Add(xy2, wz2)), Scalar.Multiply(value.Y, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2))),
                Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(xz2, wy2)), Scalar.Multiply(value.Y, Scalar.Add(yz2, wx2))),
                Scalar<T>.One
            );
        }

        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Transform<T>(Vector3<T> position, Matrix4x4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M11), Scalar.Multiply(position.Y, matrix.M21)), Scalar.Multiply(position.Z, matrix.M31)), matrix.M41),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M12), Scalar.Multiply(position.Y, matrix.M22)), Scalar.Multiply(position.Z, matrix.M32)), matrix.M42),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M13), Scalar.Multiply(position.Y, matrix.M23)), Scalar.Multiply(position.Z, matrix.M33)), matrix.M43),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M14), Scalar.Multiply(position.Y, matrix.M24)), Scalar.Multiply(position.Z, matrix.M34)), matrix.M44)
            );
        }
        
        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Transform<T>(Vector3<T> value, Quaternion<T> rotation)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            T x2 = Scalar.Add(rotation.X, rotation.X);
            T y2 = Scalar.Add(rotation.Y, rotation.Y);
            T z2 = Scalar.Add(rotation.Z, rotation.Z);

            T wx2 = Scalar.Multiply(rotation.W, x2);
            T wy2 = Scalar.Multiply(rotation.W, y2);
            T wz2 = Scalar.Multiply(rotation.W, z2);
            T xx2 = Scalar.Multiply(rotation.X, x2);
            T xy2 = Scalar.Multiply(rotation.X, y2);
            T xz2 = Scalar.Multiply(rotation.X, z2);
            T yy2 = Scalar.Multiply(rotation.Y, y2);
            T yz2 = Scalar.Multiply(rotation.Y, z2);
            T zz2 = Scalar.Multiply(rotation.Z, z2);

            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2)), Scalar.Multiply(value.Y, Scalar.Subtract(xy2, wz2))), Scalar.Multiply(value.Z, Scalar.Add(xz2, wy2))),
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Add(xy2, wz2)), Scalar.Multiply(value.Y, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2))), Scalar.Multiply(value.Z, Scalar.Subtract(yz2, wx2))),
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(xz2, wy2)), Scalar.Multiply(value.Y, Scalar.Add(yz2, wx2))), Scalar.Multiply(value.Z, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), yy2))),
                Scalar<T>.One
            );
        }

        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Transform<T>(Vector4<T> vector, Matrix4x4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(vector.X, matrix.M11), Scalar.Multiply(vector.Y, matrix.M21)), Scalar.Multiply(vector.Z, matrix.M31)), Scalar.Multiply(vector.W, matrix.M41)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(vector.X, matrix.M12), Scalar.Multiply(vector.Y, matrix.M22)), Scalar.Multiply(vector.Z, matrix.M32)), Scalar.Multiply(vector.W, matrix.M42)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(vector.X, matrix.M13), Scalar.Multiply(vector.Y, matrix.M23)), Scalar.Multiply(vector.Z, matrix.M33)), Scalar.Multiply(vector.W, matrix.M43)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(vector.X, matrix.M14), Scalar.Multiply(vector.Y, matrix.M24)), Scalar.Multiply(vector.Z, matrix.M34)), Scalar.Multiply(vector.W, matrix.M44))
            );
        }

        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector4<T> Transform<T>(Vector4<T> value, Quaternion<T> rotation)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            T x2 = Scalar.Add(rotation.X, rotation.X);
            T y2 = Scalar.Add(rotation.Y, rotation.Y);
            T z2 = Scalar.Add(rotation.Z, rotation.Z);

            T wx2 = Scalar.Multiply(rotation.W, x2);
            T wy2 = Scalar.Multiply(rotation.W, y2);
            T wz2 = Scalar.Multiply(rotation.W, z2);
            T xx2 = Scalar.Multiply(rotation.X, x2);
            T xy2 = Scalar.Multiply(rotation.X, y2);
            T xz2 = Scalar.Multiply(rotation.X, z2);
            T yy2 = Scalar.Multiply(rotation.Y, y2);
            T yz2 = Scalar.Multiply(rotation.Y, z2);
            T zz2 = Scalar.Multiply(rotation.Z, z2);

            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2)), Scalar.Multiply(value.Y, Scalar.Subtract(xy2, wz2))), Scalar.Multiply(value.Z, Scalar.Add(xz2, wy2))),
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Add(xy2, wz2)), Scalar.Multiply(value.Y, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2))), Scalar.Multiply(value.Z, Scalar.Subtract(yz2, wx2))),
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(xz2, wy2)), Scalar.Multiply(value.Y, Scalar.Add(yz2, wx2))), Scalar.Multiply(value.Z, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), yy2))),
                value.W
            );
        }
    }
}
