// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Vector3D{T}"/>
    /// </summary>
    public static class Vector3D
    {

        /// <summary>Returns a vector whose elements are the absolute values of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The absolute value vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Abs<T>(Vector3D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Abs(value.X), Scalar.Abs(value.Y), Scalar.Abs(value.Z));

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Add<T>(Vector3D<T> left, Vector3D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left + right;

        /// <summary>Restricts a vector between a min and max value.</summary>
        /// <param name="value1">The source vector.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The restricted vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Clamp<T>(Vector3D<T> value1, Vector3D<T> min, Vector3D<T> max)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            // We must follow HLSL behavior in the case user specified min value is bigger than max value.
            => Min(Max(value1, min), max);

        /// <summary>Computes the cross product of two vectors.</summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The cross product.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Cross<T>(Vector3D<T> vector1, Vector3D<T> vector2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(
                Scalar.Subtract(Scalar.Multiply(vector1.Y, vector2.Z),
                    Scalar.Multiply(vector1.Z, vector2.Y)),
                Scalar.Subtract(Scalar.Multiply(vector1.Z, vector2.X),
                    Scalar.Multiply(vector1.X, vector2.Z)),
                Scalar.Subtract(Scalar.Multiply(vector1.X, vector2.Y),
                    Scalar.Multiply(vector1.Y, vector2.X)));

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T Distance<T>(Vector3D<T> value1, Vector3D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T DistanceSquared<T>(Vector3D<T> value1, Vector3D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Divide<T>(Vector3D<T> left, Vector3D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left / right;

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="divisor">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Divide<T>(Vector3D<T> left, T divisor)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left / divisor;

        /// <summary>Returns the dot product of two vectors.</summary>
        /// <param name="vector1">The first vector.</param>
        /// <param name="vector2">The second vector.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T Dot<T>(Vector3D<T> vector1, Vector3D<T> vector2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Add(
                Scalar.Add(Scalar.Multiply(vector1.X, vector2.X),
                    Scalar.Multiply(vector1.Y, vector2.Y)),
                Scalar.Multiply(vector1.Z, vector2.Z));

        /// <summary>Linearly interpolates between two vectors based on the given weighting.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
        /// <returns>The interpolated vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Lerp<T>(Vector3D<T> value1, Vector3D<T> value2, T amount)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return (value1 * Scalar.Subtract(Scalar<T>.One, amount) + (value2 * amount));
        }

        /// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The maximized vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Max<T>(Vector3D<T> value1, Vector3D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Max(value1.X, value2.X), Scalar.Max(value1.Y, value2.Y),
                Scalar.Max(value1.Z, value2.Z));

        /// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.</summary>
        /// <param name="value1">The first source vector.</param>
        /// <param name="value2">The second source vector.</param>
        /// <returns>The minimized vector.</returns>
        public static Vector3D<T> Min<T>(Vector3D<T> value1, Vector3D<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Min(value1.X, value2.X), Scalar.Min(value1.Y, value2.Y),
                Scalar.Min(value1.Z, value2.Z));

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Multiply<T>(Vector3D<T> left, Vector3D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left * right;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector4D<T> Multiply<T>(Vector3D<T> value1, Matrix3X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Multiply<T>(Vector3D<T> value1, Matrix3X3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(Vector3D<T> value1, Matrix3X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Multiply<T>(Vector3D<T> left, T right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left * right;

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="left">The scalar value.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Multiply<T>(T left, Vector3D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left * right;

        /// <summary>Negates a given vector.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The negated vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Negate<T>(Vector3D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => -value;

        /// <summary>Returns a vector with the same direction as the given vector, but with a length of 1.</summary>
        /// <param name="value">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Normalize<T>(Vector3D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value / value.Length;

        /// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="normal">The normal of the surface being reflected off.</param>
        /// <returns>The reflected vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Reflect<T>(Vector3D<T> vector, Vector3D<T> normal)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => vector - (Scalar.Multiply(Scalar<T>.Two, Dot(vector, normal)) * normal);

        /// <summary>Returns a vector whose elements are the square root of each of the source vector's elements.</summary>
        /// <param name="value">The source vector.</param>
        /// <returns>The square root vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> SquareRoot<T>(Vector3D<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => new(Scalar.Sqrt(value.X), Scalar.Sqrt(value.Y), Scalar.Sqrt(value.Z));

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Subtract<T>(Vector3D<T> left, Vector3D<T> right)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => left - right;


        /// <summary>Transforms a vector by the given matrix.</summary>
        /// <param name="position">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Transform<T>(Vector3D<T> position, Matrix4X4<T> matrix) // TODO: Matrix4X3
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M11), Scalar.Multiply(position.Y, matrix.M21)), Scalar.Multiply(position.Z, matrix.M31)), matrix.M41),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M12), Scalar.Multiply(position.Y, matrix.M22)), Scalar.Multiply(position.Z, matrix.M32)), matrix.M42),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(position.X, matrix.M13), Scalar.Multiply(position.Y, matrix.M23)), Scalar.Multiply(position.Z, matrix.M33)), matrix.M43)
            );
        }

        /// <summary>Transforms a vector by the given Quaternion rotation value.</summary>
        /// <param name="value">The source vector to be rotated.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> Transform<T>(Vector3D<T> value, Legacy.Quaternion<T> rotation)
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

            // TODO: Vectorize
            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2)), Scalar.Multiply(value.Y, Scalar.Subtract(xy2, wz2))), Scalar.Multiply(value.Z, Scalar.Add(xz2, wy2))),
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Add(xy2, wz2)), Scalar.Multiply(value.Y, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2))), Scalar.Multiply(value.Z, Scalar.Subtract(yz2, wx2))),
                Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, Scalar.Subtract(xz2, wy2)), Scalar.Multiply(value.Y, Scalar.Add(yz2, wx2))), Scalar.Multiply(value.Z, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), yy2)))
            );
        }



        /// <summary>Transforms a vector normal by the given matrix.</summary>
        /// <param name="normal">The source vector.</param>
        /// <param name="matrix">The transformation matrix.</param>
        /// <returns>The transformed vector.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector3D<T> TransformNormal<T>(Vector3D<T> normal, Matrix4X4<T> matrix) // TODO: Matrix3X3
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(normal.X, matrix.M11), Scalar.Multiply(normal.Y, matrix.M21)), Scalar.Multiply(normal.Z, matrix.M31)),
                Scalar.Add(Scalar.Add(Scalar.Multiply(normal.X, matrix.M12), Scalar.Multiply(normal.Y, matrix.M22)), Scalar.Multiply(normal.Z, matrix.M32)),
                Scalar.Add(Scalar.Add(Scalar.Multiply(normal.X, matrix.M13), Scalar.Multiply(normal.Y, matrix.M23)), Scalar.Multiply(normal.Z, matrix.M33))
            );
        }
    }
}
