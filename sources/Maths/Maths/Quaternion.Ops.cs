// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Extensions for <see cref="Quaternion{T}"/>.
    /// </summary>
    public static class Quaternion
    {
        /// <summary>Normalizes a Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The normalized Quaternion.</returns>
        public static Quaternion<T> Normalize<T>(Quaternion<T> value)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            Quaternion<T> ans = default;

            var invNorm = T.One / value.Length;

            ans.X = value.X * invNorm;
            ans.Y = value.Y * invNorm;
            ans.Z = value.Z * invNorm;
            ans.W = value.W * invNorm;

            return ans;
        }

        /// <summary>Inverts a Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The inverted Quaternion.</returns>
        public static Quaternion<T> Invert<T>(Quaternion<T> value)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            //  -1   (       a              -v       )
            // q   = ( -------------   ------------- )
            //       (  a^2 + |v|^2  ,  a^2 + |v|^2  )

            Quaternion<T> ans = default;

            var invNorm = T.One / value.LengthSquared;

            ans.X = -(value.X * invNorm);
            ans.Y = -(value.Y * invNorm);
            ans.Z = -(value.Z * invNorm);
            ans.W = value.W * invNorm;

            return ans;
        }

        /// <summary>Calculates the dot product of two Quaternions.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <returns>The dot product of the Quaternions.</returns>
        public static T Dot<T>(Quaternion<T> quaternion1, Quaternion<T> quaternion2)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => (quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y) + (quaternion1.Z * quaternion2.Z) + (quaternion1.W * quaternion2.W);

        /// <summary>Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.</summary>
        /// <param name="first">The first Quaternion rotation in the series.</param>
        /// <param name="second">The second Quaternion rotation in the series.</param>
        /// <returns>A new Quaternion representing the concatenation of the value1 rotation followed by the value2 rotation.</returns>
        public static Quaternion<T> Concatenate<T>(Quaternion<T> first, Quaternion<T> second)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => second * first;

        /// <summary>Creates the conjugate of a specified Quaternion.</summary>
        /// <param name="value">The Quaternion of which to return the conjugate.</param>
        /// <returns>A new Quaternion that is the conjugate of the specified one.</returns>
        public static Quaternion<T> Conjugate<T>(Quaternion<T> value)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            Quaternion<T> ans = default;

            ans.X = -value.X;
            ans.Y = -value.Y;
            ans.Z = -value.Z;
            ans.W = value.W;

            return ans;
        }

        /// <summary>Creates a Quaternion from a normalized vector axis and an angle to rotate about the vector.</summary>
        /// <param name="axis">The unit vector to rotate around.
        /// This vector must be normalized before calling this function or the resulting Quaternion will be incorrect.</param>
        /// <param name="angle">The angle, in radians, to rotate around the vector.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromAxisAngle<T>(Vector3D<T> axis, T angle)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            Quaternion<T> ans = default;

            var halfAngle = angle / T.CreateTruncating(2);
            var s = T.Sin(halfAngle);
            var c = T.Cos(halfAngle);

            ans.X = axis.X * s;
            ans.Y = axis.Y * s;
            ans.Z = axis.Z * s;
            ans.W = c;

            return ans;
        }

        /// <summary>Creates a Quaternion from the given rotation matrix.</summary>
        /// <param name="matrix">The rotation matrix.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromRotationMatrix<T>(Matrix4X4<T> matrix)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var trace = matrix.M11 + matrix.M22 + matrix.M33;

            Quaternion<T> q = default;

            if (trace > T.Zero)
            {
                var s = T.Sqrt(trace + T.One);
                q.W = s / T.CreateTruncating(2);
                s = T.One / (T.CreateTruncating(2) * s);
                q.X = (matrix.M23 - matrix.M32) * s;
                q.Y = (matrix.M31 - matrix.M13) * s;
                q.Z = (matrix.M12 - matrix.M21) * s;
            }
            else
            {
                if ((matrix.M11 >= matrix.M22) && (matrix.M11 >= matrix.M33))
                {
                    var s = T.Sqrt(T.One + matrix.M11 - matrix.M22 - matrix.M33);
                    var invS = T.One / (T.CreateTruncating(2) * s);
                    q.X = s / T.CreateTruncating(2);
                    q.Y = (matrix.M12 + matrix.M21) * invS;
                    q.Z = (matrix.M13 + matrix.M31) * invS;
                    q.W = (matrix.M23 - matrix.M32) * invS;
                }
                else if (matrix.M22 > matrix.M33)
                {
                    var s = T.Sqrt(T.One + matrix.M22 - matrix.M11 - matrix.M33);
                    var invS = T.One / (T.CreateTruncating(2) * s);
                    q.X = (matrix.M21 + matrix.M12) * invS;
                    q.Y = s / T.CreateTruncating(2);
                    q.Z = (matrix.M32 + matrix.M23) * invS;
                    q.W = (matrix.M31 - matrix.M13) * invS;
                }
                else
                {
                    var s = T.Sqrt(T.One + matrix.M33 - matrix.M11 - matrix.M22);
                    var invS = T.One / (T.CreateTruncating(2) * s);
                    q.X = (matrix.M31 + matrix.M13) * invS;
                    q.Y = (matrix.M32 + matrix.M23) * invS;
                    q.Z = s / T.CreateTruncating(2);
                    q.W = (matrix.M12 - matrix.M21) * invS;
                }
            }

            return q;
        }

        /// <summary>Creates a Quaternion from the given rotation matrix.</summary>
        /// <param name="matrix">The rotation matrix.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromRotationMatrix<T>(Matrix3X3<T> matrix)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var trace = matrix.M11 + matrix.M22 + matrix.M33;

            Quaternion<T> q = default;

            if (trace > T.Zero)
            {
                var s = T.Sqrt(trace + T.One);
                q.W = s / T.CreateTruncating(2);
                s = T.One / (T.CreateTruncating(2) * s);
                q.X = (matrix.M23 - matrix.M32) * s;
                q.Y = (matrix.M31 - matrix.M13) * s;
                q.Z = (matrix.M12 - matrix.M21) * s;
            }
            else
            {
                if ((matrix.M11 >= matrix.M22) && (matrix.M11 >= matrix.M33))
                {
                    var s = T.Sqrt(T.One + matrix.M11 - matrix.M22 - matrix.M33);
                    var invS = T.One / (T.CreateTruncating(2) * s);
                    q.X = s / T.CreateTruncating(2);
                    q.Y = (matrix.M12 + matrix.M21) * invS;
                    q.Z = (matrix.M13 + matrix.M31) * invS;
                    q.W = (matrix.M23 - matrix.M32) * invS;
                }
                else if (matrix.M22 > matrix.M33)
                {
                    var s = T.Sqrt(T.One + matrix.M22 - matrix.M11 - matrix.M33);
                    var invS = T.One / (T.CreateTruncating(2) * s);
                    q.X = (matrix.M21 + matrix.M12) * invS;
                    q.Y = s / T.CreateTruncating(2);
                    q.Z = (matrix.M32 + matrix.M23) * invS;
                    q.W = (matrix.M31 - matrix.M13) * invS;
                }
                else
                {
                    var s = T.Sqrt(T.One + matrix.M33 - matrix.M11 - matrix.M22);
                    var invS = T.One / (T.CreateTruncating(2) * s);
                    q.X = (matrix.M31 + matrix.M13) * invS;
                    q.Y = (matrix.M32 + matrix.M23) * invS;
                    q.Z = s / T.CreateTruncating(2);
                    q.W = (matrix.M12 - matrix.M21) * invS;
                }
            }

            return q;
        }

        /// <summary>Creates a new Quaternion from the given yaw, pitch, and roll, in radians.</summary>
        /// <param name="yaw">The yaw angle, in radians, around the Y-axis.</param>
        /// <param name="pitch">The pitch angle, in radians, around the X-axis.</param>
        /// <param name="roll">The roll angle, in radians, around the Z-axis.</param>
        /// <returns></returns>
        public static Quaternion<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            //  Roll first, about axis the object is facing, then
            //  pitch upward, then yaw to face into the new heading
            T sr, cr, sp, cp, sy, cy;

            var halfRoll = roll / T.CreateTruncating(2);
            sr = T.Sin(halfRoll);
            cr = T.Cos(halfRoll);

            var halfPitch = pitch / T.CreateTruncating(2);
            sp = T.Sin(halfPitch);
            cp = T.Cos(halfPitch);

            var halfYaw = yaw / T.CreateTruncating(2);
            sy = T.Sin(halfYaw);
            cy = T.Cos(halfYaw);

            Quaternion<T> ans = default;

            ans.X = (cy * sp * cr) + (sy * cp * sr);
            ans.Y = (sy * cp * cr) - (cy * sp * sr);
            ans.Z = (cy * cp * sr) - (sy * sp * cr);
            ans.W = (cy * cp * cr) + (sy * sp * sr);

            return ans;
        }

        /// <summary> Linearly interpolates between two quaternions.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Lerp<T>(Quaternion<T> value1, Quaternion<T> value2, T amount)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var t = amount;
            var t1 = T.One - t;

            Quaternion<T> r = default;

            T dot = (value1.X * value2.X)
                + (value1.Y * value2.Y)
                + (value1.Z * value2.Z)
                + (value1.W * value2.W);

            if (dot >= T.Zero)
            {
                r.X = (t1 * value1.X) + (t * value2.X);
                r.Y = (t1 * value1.Y) + (t * value2.Y);
                r.Z = (t1 * value1.Z) + (t * value2.Z);
                r.W = (t1 * value1.W) + (t * value2.W);
            }
            else
            {
                r.X = (t1 * value1.X) - (t * value2.X);
                r.Y = (t1 * value1.Y) - (t * value2.Y);
                r.Z = (t1 * value1.Z) - (t * value2.Z);
                r.W = (t1 * value1.W) - (t * value2.W);
            }

            // Normalize it.
            T ls = (r.X * r.X) + (r.Y * r.Y) + (r.Z * r.Z) + (r.W * r.W);
            var invNorm = T.One / T.Sqrt(ls);

            r.X = r.X * invNorm;
            r.Y = r.Y * invNorm;
            r.Z = r.Z * invNorm;
            r.W = r.W * invNorm;

            return r;
        }

        /// <summary>Interpolates between two quaternions, using spherical linear interpolation.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Slerp<T>(Quaternion<T> value1, Quaternion<T> value2, T amount)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            const float SlerpEpsilon = 1e-6f;

            var t = amount;

            T cosOmega = (value1.X * value2.X) + (value1.Y * value2.Y) + (value1.Z * value2.Z) + (value1.W * value2.W);

            var flip = false;

            if (!(cosOmega >= T.Zero))
            {
                flip = true;
                cosOmega = -cosOmega;
            }

            T s1, s2;

            if (cosOmega > T.One - T.CreateTruncating(SlerpEpsilon))
            {
                // Too close, do straight linear interpolation.
                s1 = T.One - t;
                s2 = flip ? -t : t;
            }
            else
            {
                var omega = T.Acos(cosOmega);
                var invSinOmega = T.One / T.Sin(omega);

                s1 = T.Sin((T.One - t) * omega) * invSinOmega;
                s2 = flip
                    ? -T.Sin(t * omega) * invSinOmega
                    : T.Sin(t * omega) * invSinOmega;
            }

            Quaternion<T> ans = default;

            ans.X = (s1 * value1.X) + (s2 * value2.X);
            ans.Y = (s1 * value1.Y) + (s2 * value2.Y);
            ans.Z = (s1 * value1.Z) + (s2 * value2.Z);
            ans.W = (s1 * value1.W) + (s2 * value2.W);

            return ans;
        }
    }
}
