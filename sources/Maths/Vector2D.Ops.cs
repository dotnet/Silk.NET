// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Vector2D{T}"/>
    /// </summary>
    public static class Vector2D
    {
        /// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
        /// <param name="value">A vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Abs<T>(Vector2D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Abs(value.X), Scalar.Abs(value.Y));

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first vector to add.</param>
        /// <param name="right">The second vector to add.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Add<T>(Vector2D<T> left, Vector2D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Add(left.X, right.X), Scalar.Add(left.Y, right.Y));

        /// <summary>Restricts a vector between a minimum and a maximum value.</summary>
        /// <param name="value1">The vector to restrict.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Clamp<T>(Vector2D<T> value1, Vector2D<T> min, Vector2D<T> max)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);

        /// <summary>Computes the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T Distance<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between two specified points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T DistanceSquared<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first vector.</param>
        /// <param name="right">The second vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Divide<T>(Vector2D<T> left, Vector2D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Divide(left.X, right.X), Scalar.Divide(left.Y, right.Y));

        /// <summary>Divides the specified vector by a specified scalar value.</summary>
        /// <param name="left">The vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The vector that results from the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Divide<T>(Vector2D<T> left, T divisor)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Divide(left.X, divisor), Scalar.Divide(left.Y, divisor));

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="value1">The first vector.</param>
        /// <param name="value2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T Dot<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Add(Scalar.Multiply(value1.X, value2.X), Scalar.Multiply(value1.Y, value2.Y));

        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Lerp<T>(Vector2D<T> value1, Vector2D<T> value2, T amount)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => (value1 * Scalar.Subtract(Scalar<T>.One, amount)) + (value2 * amount);

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors</summary>
        /// <param name="value1">The first source vector</param>
        /// <param name="value2">The second source vector</param>
        /// <returns>The maximized vector</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Max<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Max(value1.X, value2.X), Scalar.Max(value1.Y, value2.Y));

        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Min<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Min(value1.X, value2.X), Scalar.Min(value1.Y, value2.Y));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(Vector2D<T> left, Vector2D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Multiply(left.X, right.X), Scalar.Multiply(left.Y, right.Y));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(Vector2D<T> left, T right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Multiply(left.X, right), Scalar.Multiply(left.Y, right));

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(T left, Vector2D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Multiply(left, right.X), Scalar.Multiply(left, right.Y));

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Negate<T>(Vector2D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="value">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Normalize<T>(Vector2D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value / value.Length;

        /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="normal">The normal of the surface being reflected off.</param>
        /// <returns>The reflected vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Reflect<T>(Vector2D<T> vector, Vector2D<T> normal)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => vector - Scalar.Multiply(Scalar<T>.Two, Dot(vector, normal)) * normal;

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> SquareRoot<T>(Vector2D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Sqrt(value.X), Scalar.Sqrt(value.Y));

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Subtract<T>(Vector2D<T> left, Vector2D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left - right;

        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2D<T> Transform<T>(Vector2D<T> position, Matrix4X4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M11), Scalar.Multiply(position.Y, matrix.M21)), matrix.M41),
                Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M12), Scalar.Multiply(position.Y, matrix.M22)), matrix.M42)
            );
        }

        /// <summary>Transforms a vector normal by the given matrix.</summary>
        /// <param name="normal">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> normal, Matrix4X4<T> matrix)
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
        public static Vector2D<T> Transform<T>(Vector2D<T> value, Quaternion<T> rotation)
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
        public static Vector2D<T> Transform<T>(Vector2D<T> position, Matrix3X2<T> matrix)
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
        public static Vector2D<T> TransformNormal<T>(Vector2D<T> normal, Matrix3X2<T> matrix)
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
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector4D<T> Multiply<T>(Vector2D<T> value1, Matrix2X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Multiply<T>(Vector2D<T> value1, Matrix2X3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(Vector2D<T> value1, Matrix2X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
    }
}