// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Plane{T}"/>
    /// </summary>
    public static class Plane
    {
        /// <summary>Creates a Plane that contains the given point and is perpendicular to the given normal.</summary>
        /// <param name="point">The point defining the Plane.</param>
        /// <param name="normal">The normal of the Plane.</param>
        /// <returns>The Plane containing the three points.</returns>
        public static Plane<T> CreateFromPointNormal<T>(Vector3D<T> point, Vector3D<T> normal)
            where T : IRootFunctions<T>
        {
            return new Plane<T>(normal, -Vector3D.Dot(normal, point));
        }

        /// <summary>Creates a Plane that contains the three given points.</summary>
        /// <param name="point1">The first point defining the Plane.</param>
        /// <param name="point2">The second point defining the Plane.</param>
        /// <param name="point3">The third point defining the Plane.</param>
        /// <returns>The Plane containing the three points.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> CreateFromVertices<T>(Vector3D<T> point1, Vector3D<T> point2, Vector3D<T> point3)
            where T : IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<System.Numerics.Plane, Plane<T>>(System.Numerics.Plane.CreateFromVertices(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(point1),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(point2),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(point3)
                ));
            }

            var a = point2 - point1;
            var b = point3 - point1;

            // N = Cross(a, b)
            var n = Vector3D.Cross(a, b);
            var normal = Vector3D.Normalize(n);

            // D = - Dot(N, point1)
            var d = -Vector3D.Dot(normal, point1);

            return new Plane<T>(normal, d);
        }

        /// <summary>Calculates the dot product of a Plane and Vector4D.</summary>
        /// <param name="plane">The Plane.</param>
        /// <param name="value">The Vector4D.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T Dot<T>(Plane<T> plane, Vector4D<T> value)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<float, T>(System.Numerics.Plane.Dot(
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(plane),
                    Unsafe.BitCast<Vector4D<T>, Vector4>(value)
                ));
            }

            return (plane.Normal.X * value.X) + (plane.Normal.Y * value.Y) + (plane.Normal.Z * value.Z) +
                   (plane.Distance * value.W);
        }

        /// <summary>Returns the dot product of a specified Vector3D and the normal vector of this Plane plus the distance (D) value of the Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3D.</param>
        /// <returns>The resulting value.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T DotCoordinate<T>(Plane<T> plane, Vector3D<T> value)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<float, T>(System.Numerics.Plane.DotCoordinate(
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(plane),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(value)
                ));
            }

            return Vector3D.Dot(plane.Normal, value) + plane.Distance;
        }

        /// <summary>Returns the dot product of a specified Vector3D and the Normal vector of this Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3D.</param>
        /// <returns>The resulting dot product.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T DotNormal<T>(Plane<T> plane, Vector3D<T> value)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<float, T>(System.Numerics.Plane.DotNormal(
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(plane),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(value)
                ));
            }

            return Vector3D.Dot(plane.Normal, value);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="plane">The plane.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T GetDistanceToEdge<T>(this Plane<T> plane, Vector3D<T> point)
            where T : INumberBase<T>
        {
            return T.Abs(GetSignedDistanceToEdge(plane, point));
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="plane">The plane.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T GetSignedDistanceToEdge<T>(this Plane<T> plane, Vector3D<T> point)
            where T : INumberBase<T>
            => T.Abs(Vector3D.Dot(plane.Normal, point) + plane.Distance);

        /// <summary>Scales the Plane.</summary>
        /// <param name="value">The plane to scale.</param>
        /// <param name="scale">The scaling factor to apply.</param>
        /// <returns>The scaled Plane.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Scale<T>(Plane<T> value, T scale)
            where T : INumberBase<T>
            => new(value.Normal, value.Distance * scale);

        /// <summary>Translates the Plane.</summary>
        /// <param name="value">The plane to translate.</param>
        /// <param name="translation">The translation to apply.</param>
        /// <returns>The scaled Plane.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Translate<T>(Plane<T> value, Vector3D<T> translation)
            where T : INumberBase<T>
            => new(value.Normal, value.Distance - Vector3D.Dot(value.Normal, translation));

        /// <summary>Normalizes the Plane.</summary>
        /// <param name="value">The plane to normalize.</param>
        /// <returns>The normalized Plane.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Normalize<T>(Plane<T> value)
            where T : INumberBase<T>, IRootFunctions<T>
        {
            var fInv = T.One / value.Normal.Length;
            return new(
                value.Normal * fInv,
                value.Distance * fInv);
        }

        /// <summary>Transforms a normalized Plane by a Matrix.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="matrix">The transformation matrix to apply to the Plane.</param>
        /// <returns>The transformed Plane.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Transform<T>(Plane<T> plane, Matrix4X4<T> matrix)
            where T : IFloatingPointIeee754<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<System.Numerics.Plane, Plane<T>>(System.Numerics.Plane.Transform(
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(plane),
                    Unsafe.BitCast<Matrix4X4<T>, Matrix4x4>(matrix)
                ));
            }

            Matrix4X4.Invert(matrix, out Matrix4X4<T> m);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z, w = plane.Distance;

            return new(
                (x * m.M11) + (y * m.M12) + (z * m.M13) + (w * m.M14),
                (x * m.M21) + (y * m.M22) + (z * m.M23) + (w * m.M24),
                (x * m.M31) + (y * m.M32) + (z * m.M33) + (w * m.M34),
                (x * m.M41) + (y * m.M42) + (z * m.M43) + (w * m.M44));
        }

        /// <summary> Transforms a normalized Plane by a Quaternion rotation.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="rotation">The Quaternion rotation to apply to the Plane.</param>
        /// <returns>A new Plane that results from applying the rotation.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Transform<T>(Plane<T> plane, Quaternion<T> rotation)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<System.Numerics.Plane, Plane<T>>(System.Numerics.Plane.Transform(
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(plane),
                    Unsafe.BitCast<Quaternion<T>, System.Numerics.Quaternion>(rotation)
                ));
            }

            // Compute rotation matrix.
            T x2 = rotation.X + rotation.X;
            T y2 = rotation.Y + rotation.Y;
            T z2 = rotation.Z + rotation.Z;

            T wx2 = rotation.W * x2;
            T wy2 = rotation.W * y2;
            T wz2 = rotation.W * z2;
            T xx2 = rotation.X * x2;
            T xy2 = rotation.X * y2;
            T xz2 = rotation.X * z2;
            T yy2 = rotation.Y * y2;
            T yz2 = rotation.Y * z2;
            T zz2 = rotation.Z * z2;

            T m11 = T.One - yy2 - zz2;
            T m21 = xy2 - wz2;
            T m31 = xz2 + wy2;

            T m12 = xy2 + wz2;
            T m22 = T.One - xx2 - zz2;
            T m32 = yz2 - wx2;

            T m13 = xz2 - wy2;
            T m23 = yz2 + wx2;
            T m33 = T.One - xx2 - yy2;

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z;

            return new(
                (x * m11) + (y * m21) + (z * m31),
                (x * m12) + (y * m22) + (z * m32),
                (x * m13) + (y * m23) + (z * m33),
                plane.Distance);
        }
    }
}
