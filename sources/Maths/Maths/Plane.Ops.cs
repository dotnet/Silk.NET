// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Plane{T}"/>
    /// </summary>
    public static class Plane
    {
        /// <summary>Creates a Plane that contains the three given points.</summary>
        /// <param name="point1">The first point defining the Plane.</param>
        /// <param name="point2">The second point defining the Plane.</param>
        /// <param name="point3">The third point defining the Plane.</param>
        /// <returns>The Plane containing the three points.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Plane<T> CreateFromVertices<T>(Vector3D<T> point1, Vector3D<T> point2, Vector3D<T> point3)
            where T : INumberBase<T>
        {
            var a = point1;
            var b = point2;
            var c = point3;
            var ab = b - a;
            var ac = c - a;

            var cross = Vector3D.Cross(ab, ac);
            Plane<T> p;
            p.Normal = cross;
            p.Distance = Scalar.Negate(Scalar.Add(
                Scalar.Add(Scalar.Multiply(p.Normal.X, a.X), Scalar.Multiply(p.Normal.Y, a.Y)),
                Scalar.Multiply(p.Normal.Z, a.Z)));

            return p;

            /*if (Vector.IsHardwareAccelerated)
            {
                Vector3D<T> a = point2 - point1;
                Vector3D<T> b = point3 - point1;

                // N = Cross(a, b)
                Vector3D<T> n = Vector3D.Cross(a, b);
                Vector3D<T> normal = Vector3D.Normalize(n);

                // D = - Dot(N, point1)
                T d = Scalar.Negate(Vector3D.Dot(normal, point1));

                return new Plane<T>(normal, d);
            }
            else
            {
                T ax = Scalar.Subtract(point2.X, point1.X);
                T ay = Scalar.Subtract(point2.Y, point1.Y);
                T az = Scalar.Subtract(point2.Z, point1.Z);

                T bx = Scalar.Subtract(point3.X, point1.X);
                T by = Scalar.Subtract(point3.Y, point1.Y);
                T bz = Scalar.Subtract(point3.Z, point1.Z);

                // N=Cross(a,b)
                T nx = Scalar.Subtract(Scalar.Multiply(ay, bz), Scalar.Multiply(az, by));
                T ny = Scalar.Subtract(Scalar.Multiply(az, bx), Scalar.Multiply(ax, bz));
                T nz = Scalar.Subtract(Scalar.Multiply(ax, by), Scalar.Multiply(ay, bx));

                // Normalize(N)
                T ls = Scalar.Add(Scalar.Add(Scalar.Multiply(nx, nx), Scalar.Multiply(ny, ny)), Scalar.Multiply(nz, nz));
                T invNorm = Scalar.Inverse(Scalar.Sqrt(ls));

                Vector3D<T> normal = new Vector3D<T>(
                    Scalar.Multiply(nx, invNorm),
                    Scalar.Multiply(ny, invNorm),
                    Scalar.Multiply(nz, invNorm));

                return new(normal,
                    Scalar.Negate(Scalar.Add(
                        Scalar.Add(Scalar.Multiply(normal.X, point1.X),
                            Scalar.Multiply(normal.Y, point1.Y)), Scalar.Multiply(normal.Z, point1.Z))));
            }*/
        }

        /// <summary>Calculates the dot product of a Plane and Vector4D.</summary>
        /// <param name="plane">The Plane.</param>
        /// <param name="value">The Vector4D.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T Dot<T>(Plane<T> plane, Vector4D<T> value)
            where T : INumberBase<T>
            => Scalar.Add(
                Scalar.Add(
                    Scalar.Add(Scalar.Multiply(plane.Normal.X, value.X),
                        Scalar.Multiply(plane.Normal.Y, value.Y)), Scalar.Multiply(plane.Normal.Z, value.Z)),
                Scalar.Multiply(plane.Distance, value.W));

        /// <summary>Returns the dot product of a specified Vector3D and the normal vector of this Plane plus the distance (D) value of the Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3D.</param>
        /// <returns>The resulting value.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T DotCoordinate<T>(Plane<T> plane, Vector3D<T> value)
            where T : INumberBase<T>
            => Scalar.Add(Vector3D.Dot(plane.Normal, value), plane.Distance);

        /// <summary>Returns the dot product of a specified Vector3D and the Normal vector of this Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3D.</param>
        /// <returns>The resulting dot product.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static T DotNormal<T>(Plane<T> plane, Vector3D<T> value)
            where T : INumberBase<T>
            => Vector3D.Dot(plane.Normal, value);

        private const float NormalizeEpsilon = 1.192092896e-07f; // smallest such that 1.0+NormalizeEpsilon != 1.0

        /// <summary>Creates a new Plane whose normal vector is the source Plane's normal vector normalized.</summary>
        /// <param name="value">The source Plane.</param>
        /// <returns>The normalized Plane.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Plane<T> Normalize<T>(Plane<T> value)
            where T : INumberBase<T>
        {
            /*if (Vector.IsHardwareAccelerated)
            {
                T normalLengthSquared = value.Normal.LengthSquared();
                if (MathF.Abs(normalLengthSquared - 1.0f) < NormalizeEpsilon)
                {
                    // It already normalized, so we don't need to farther process.
                    return value;
                }
                T normalLength = MathF.Sqrt(normalLengthSquared);
                return new Plane(
                    value.Normal / normalLength,
                    value.D / normalLength);
            }
            else*/
            {
                T f = Scalar.Add(
                    Scalar.Add(Scalar.Multiply(value.Normal.X, value.Normal.X),
                        Scalar.Multiply(value.Normal.Y, value.Normal.Y)),
                    Scalar.Multiply(value.Normal.Z, value.Normal.Z));

                if (!Scalar.GreaterThanOrEqual(T.Abs(Scalar.Subtract(f, Scalar<T>.One)), Scalar.As<float, T>(NormalizeEpsilon)))
                {
                    return value; // It already normalized, so we don't need to further process.
                }

                T fInv = Scalar.Reciprocal(Scalar.Sqrt(f));

                return new(
                    Scalar.Multiply(value.Normal.X, fInv),
                    Scalar.Multiply(value.Normal.Y, fInv),
                    Scalar.Multiply(value.Normal.Z, fInv),
                    Scalar.Multiply(value.Distance, fInv));
            }
        }

        /// <summary>Transforms a normalized Plane by a Matrix.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="matrix">The transformation matrix to apply to the Plane.</param>
        /// <returns>The transformed Plane.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Plane<T> Transform<T>(Plane<T> plane, Matrix4X4<T> matrix)
            where T : INumberBase<T>
        {
            Matrix4X4.Invert(matrix, out Matrix4X4<T> m);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z, w = plane.Distance;

            return new(
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M11), Scalar.Multiply(y, m.M12)), Scalar.Multiply(z, m.M13)), Scalar.Multiply(w, m.M14)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M21), Scalar.Multiply(y, m.M22)), Scalar.Multiply(z, m.M23)), Scalar.Multiply(w, m.M24)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M31), Scalar.Multiply(y, m.M32)), Scalar.Multiply(z, m.M33)), Scalar.Multiply(w, m.M34)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M41), Scalar.Multiply(y, m.M42)), Scalar.Multiply(z, m.M43)), Scalar.Multiply(w, m.M44)));
        }

        /// <summary> Transforms a normalized Plane by a Quaternion rotation.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="rotation">The Quaternion rotation to apply to the Plane.</param>
        /// <returns>A new Plane that results from applying the rotation.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Plane<T> Transform<T>(Plane<T> plane, Quaternion<T> rotation)
            where T : ITrigonometricFunctions<T>
        {
            // Compute rotation matrix.
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

            T m11 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2);
            T m21 = Scalar.Subtract(xy2, wz2);
            T m31 = Scalar.Add(xz2, wy2);

            T m12 = Scalar.Add(xy2, wz2);
            T m22 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2);
            T m32 = Scalar.Subtract(yz2, wx2);

            T m13 = Scalar.Subtract(xz2, wy2);
            T m23 = Scalar.Add(yz2, wx2);
            T m33 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), yy2);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z;

            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(x, m11), Scalar.Multiply(y, m21)), Scalar.Multiply(z, m31)),
                Scalar.Add(Scalar.Add(Scalar.Multiply(x, m12), Scalar.Multiply(y, m22)), Scalar.Multiply(z, m32)),
                Scalar.Add(Scalar.Add(Scalar.Multiply(x, m13), Scalar.Multiply(y, m23)), Scalar.Multiply(z, m33)),
                plane.Distance);
        }
    }
}
