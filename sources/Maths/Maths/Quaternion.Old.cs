// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Silk.NET.Maths;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Represents a vector that is used to encode three-dimensional physical rotations.
    /// </summary>
    /// <typeparam name="T">The type used to store values.</typeparam>
    [Serializable]
    [DataContract]
    public partial struct Quaternion<T>
    {
        private const float SlerpEpsilon = 1e-6f;

        /// <summary>Constructs a Quaternion from the given vector and rotation parts.</summary>
        /// <param name="vectorPart">The vector part of the Quaternion.</param>
        /// <param name="scalarPart">The rotation part of the Quaternion.</param>
        public Quaternion(Vector3D<T> vectorPart, T scalarPart)
        {
            X = vectorPart.X;
            Y = vectorPart.Y;
            Z = vectorPart.Z;
            W = scalarPart;
        }

        /// <summary>Returns whether the Quaternion is the identity Quaternion.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Adds two Quaternions element-by-element.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <returns>The result of adding the Quaternions.</returns>
        public static Quaternion<T> operator +(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            ans.X = Scalar.Add(value1.X, value2.X);
            ans.Y = Scalar.Add(value1.Y, value2.Y);
            ans.Z = Scalar.Add(value1.Z, value2.Z);
            ans.W = Scalar.Add(value1.W, value2.W);

            return ans;
        }

        /// <summary>Divides a Quaternion by another Quaternion.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The divisor.</param>
        /// <returns>The result of the division.</returns>
        public static Quaternion<T> operator /(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            T q1x = value1.X;
            T q1y = value1.Y;
            T q1z = value1.Z;
            T q1w = value1.W;

            //-------------------------------------
            // Inverse part.
            T ls = Scalar.Add(
                Scalar.Add(
                    Scalar.Add(Scalar.Multiply(value2.X, value2.X), Scalar.Multiply(value2.Y, value2.Y)),
                    Scalar.Multiply(value2.Z, value2.Z)), Scalar.Multiply(value2.W, value2.W));
            var invNorm = Scalar.Reciprocal(ls);

            var q2x = Scalar.Negate(Scalar.Multiply(value2.X, invNorm));
            var q2y = Scalar.Negate(Scalar.Multiply(value2.Y, invNorm));
            var q2z = Scalar.Negate(Scalar.Multiply(value2.Z, invNorm));
            var q2w = Scalar.Multiply(value2.W, invNorm);

            //-------------------------------------
            // Multiply part.

            // cross(av, bv)
            var cx = Scalar.Subtract(Scalar.Multiply(q1y, q2z), Scalar.Multiply(q1z, q2y));
            var cy = Scalar.Subtract(Scalar.Multiply(q1z, q2x), Scalar.Multiply(q1x, q2z));
            var cz = Scalar.Subtract(Scalar.Multiply(q1x, q2y), Scalar.Multiply(q1y, q2x));

            var dot = Scalar.Add(Scalar.Add(Scalar.Multiply(q1x, q2x), Scalar.Multiply(q1y, q2y)),
                Scalar.Multiply(q1z, q2z));

            ans.X = Scalar.Add(Scalar.Add(Scalar.Multiply(q1x, q2w), Scalar.Multiply(q2x, q1w)), cx);
            ans.Y = Scalar.Add(Scalar.Add(Scalar.Multiply(q1y, q2w), Scalar.Multiply(q2y, q1w)), cy);
            ans.Z = Scalar.Add(Scalar.Add(Scalar.Multiply(q1z, q2w), Scalar.Multiply(q2z, q1w)), cz);
            ans.W = Scalar.Subtract(Scalar.Multiply(q1w, q2w), dot);

            return ans;
        }

        /// <summary>Multiplies two Quaternions together.</summary>
        /// <param name="value1">The Quaternion on the left side of the multiplication.</param>
        /// <param name="value2">The Quaternion on the right side of the multiplication.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            T q1x = value1.X;
            T q1y = value1.Y;
            T q1z = value1.Z;
            T q1w = value1.W;

            T q2x = value2.X;
            T q2y = value2.Y;
            T q2z = value2.Z;
            T q2w = value2.W;

            // cross(av, bv)
            var cx = Scalar.Subtract(Scalar.Multiply(q1y, q2z), Scalar.Multiply(q1z, q2y));
            var cy = Scalar.Subtract(Scalar.Multiply(q1z, q2x), Scalar.Multiply(q1x, q2z));
            var cz = Scalar.Subtract(Scalar.Multiply(q1x, q2y), Scalar.Multiply(q1y, q2x));

            var dot = Scalar.Add(Scalar.Add(Scalar.Multiply(q1x, q2x), Scalar.Multiply(q1y, q2y)),
                Scalar.Multiply(q1z, q2z));

            ans.X = Scalar.Add(Scalar.Add(Scalar.Multiply(q1x, q2w), Scalar.Multiply(q2x, q1w)), cx);
            ans.Y = Scalar.Add(Scalar.Add(Scalar.Multiply(q1y, q2w), Scalar.Multiply(q2y, q1w)), cy);
            ans.Z = Scalar.Add(Scalar.Add(Scalar.Multiply(q1z, q2w), Scalar.Multiply(q2z, q1w)), cz);
            ans.W = Scalar.Subtract(Scalar.Multiply(q1w, q2w), dot);

            return ans;
        }

        /// <summary>Multiplies a Quaternion by a scalar value.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> value1, T value2)
        {
            Quaternion<T> ans;

            ans.X = Scalar.Multiply(value1.X, value2);
            ans.Y = Scalar.Multiply(value1.Y, value2);
            ans.Z = Scalar.Multiply(value1.Z, value2);
            ans.W = Scalar.Multiply(value1.W, value2);

            return ans;
        }

        /// <summary>Subtracts one Quaternion from another.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Quaternion<T> operator -(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            ans.X = Scalar.Subtract(value1.X, value2.X);
            ans.Y = Scalar.Subtract(value1.Y, value2.Y);
            ans.Z = Scalar.Subtract(value1.Z, value2.Z);
            ans.W = Scalar.Subtract(value1.W, value2.W);

            return ans;
        }

        /// <summary>Flips the sign of each component of the quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The negated Quaternion.</returns>
        public static Quaternion<T> operator -(Quaternion<T> value)
        {
            Quaternion<T> ans;

            ans.X = Scalar.Negate(value.X);
            ans.Y = Scalar.Negate(value.Y);
            ans.Z = Scalar.Negate(value.Z);
            ans.W = Scalar.Negate(value.W);

            return ans;
        }

        /// <summary>Adds two Quaternions element-by-element.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <returns>The result of adding the Quaternions.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Quaternion<T> Add(Quaternion<T> value1, Quaternion<T> value2)
            => value1 + value2;

        /// <summary>Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.</summary>
        /// <param name="value1">The first Quaternion rotation in the series.</param>
        /// <param name="value2">The second Quaternion rotation in the series.</param>
        /// <returns>A new Quaternion representing the concatenation of the value1 rotation followed by the value2 rotation.</returns>
        public static Quaternion<T> Concatenate(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            // Concatenate rotation is actually q2 * q1 instead of q1 * q2.
            // So that's why value2 goes q1 and value1 goes q2.
            T q1x = value2.X;
            T q1y = value2.Y;
            T q1z = value2.Z;
            T q1w = value2.W;

            T q2x = value1.X;
            T q2y = value1.Y;
            T q2z = value1.Z;
            T q2w = value1.W;

            // cross(av, bv)
            var cx = Scalar.Subtract(Scalar.Multiply(q1y, q2z), Scalar.Multiply(q1z, q2y));
            var cy = Scalar.Subtract(Scalar.Multiply(q1z, q2x), Scalar.Multiply(q1x, q2z));
            var cz = Scalar.Subtract(Scalar.Multiply(q1x, q2y), Scalar.Multiply(q1y, q2x));

            var dot = Scalar.Add(Scalar.Add(Scalar.Multiply(q1x, q2x), Scalar.Multiply(q1y, q2y)),
                Scalar.Multiply(q1z, q2z));

            ans.X = Scalar.Add(Scalar.Add(Scalar.Multiply(q1x, q2w), Scalar.Multiply(q2x, q1w)), cx);
            ans.Y = Scalar.Add(Scalar.Add(Scalar.Multiply(q1y, q2w), Scalar.Multiply(q2y, q1w)), cy);
            ans.Z = Scalar.Add(Scalar.Add(Scalar.Multiply(q1z, q2w), Scalar.Multiply(q2z, q1w)), cz);
            ans.W = Scalar.Subtract(Scalar.Multiply(q1w, q2w), dot);

            return ans;
        }

        /// <summary>Creates the conjugate of a specified Quaternion.</summary>
        /// <param name="value">The Quaternion of which to return the conjugate.</param>
        /// <returns>A new Quaternion that is the conjugate of the specified one.</returns>
        public static Quaternion<T> Conjugate(Quaternion<T> value)
        {
            Quaternion<T> ans;

            ans.X = Scalar.Negate(value.X);
            ans.Y = Scalar.Negate(value.Y);
            ans.Z = Scalar.Negate(value.Z);
            ans.W = value.W;

            return ans;
        }

        /// <summary>Creates a Quaternion from a normalized vector axis and an angle to rotate about the vector.</summary>
        /// <param name="axis">The unit vector to rotate around.
        /// This vector must be normalized before calling this function or the resulting Quaternion will be incorrect.</param>
        /// <param name="angle">The angle, in radians, to rotate around the vector.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromAxisAngle(Vector3D<T> axis, T angle)
        {
            Quaternion<T> ans;

            var halfAngle = Scalar.Divide(angle, Scalar<T>.Two);
            var s = Scalar.Sin(halfAngle);
            var c = Scalar.Cos(halfAngle);

            ans.X = Scalar.Multiply(axis.X, s);
            ans.Y = Scalar.Multiply(axis.Y, s);
            ans.Z = Scalar.Multiply(axis.Z, s);
            ans.W = c;

            return ans;
        }

        /// <summary>Creates a Quaternion from the given rotation matrix.</summary>
        /// <param name="matrix">The rotation matrix.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromRotationMatrix(Matrix4X4<T> matrix)
        {
            var trace = Scalar.Add(Scalar.Add(matrix.M11, matrix.M22), matrix.M33);

            Quaternion<T> q = default;

            if (Scalar.GreaterThan(trace, Scalar<T>.Zero))
            {
                var s = Scalar.Sqrt(Scalar.Add(trace, Scalar<T>.One));
                q.W = Scalar.Divide(s, Scalar<T>.Two);
                s = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                q.X = Scalar.Multiply(Scalar.Subtract(matrix.M23, matrix.M32), s);
                q.Y = Scalar.Multiply(Scalar.Subtract(matrix.M31, matrix.M13), s);
                q.Z = Scalar.Multiply(Scalar.Subtract(matrix.M12, matrix.M21), s);
            }
            else
            {
                if (Scalar.GreaterThanOrEqual(matrix.M11, matrix.M22) && Scalar.GreaterThanOrEqual(matrix.M11, matrix.M33))
                {
                    var s = Scalar.Sqrt(Scalar.Subtract(Scalar.Subtract(Scalar.Add(Scalar<T>.One, matrix.M11), matrix.M22), matrix.M33));
                    var invS = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                    q.X = Scalar.Divide(s, Scalar<T>.Two);
                    q.Y = Scalar.Multiply(Scalar.Add(matrix.M12, matrix.M21), invS);
                    q.Z = Scalar.Multiply(Scalar.Add(matrix.M13, matrix.M31), invS);
                    q.W = Scalar.Multiply(Scalar.Subtract(matrix.M23, matrix.M32), invS);
                }
                else if (Scalar.GreaterThan(matrix.M22, matrix.M33))
                {
                    var s = Scalar.Sqrt(Scalar.Subtract(Scalar.Subtract(Scalar.Add(Scalar<T>.One, matrix.M22), matrix.M11), matrix.M33));
                    var invS = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                    q.X = Scalar.Multiply(Scalar.Add(matrix.M21, matrix.M12), invS);
                    q.Y = Scalar.Divide(s, Scalar<T>.Two);
                    q.Z = Scalar.Multiply(Scalar.Add(matrix.M32, matrix.M23), invS);
                    q.W = Scalar.Multiply(Scalar.Subtract(matrix.M31, matrix.M13), invS);
                }
                else
                {
                    var s = Scalar.Sqrt(Scalar.Subtract(Scalar.Subtract(Scalar.Add(Scalar<T>.One, matrix.M33), matrix.M11), matrix.M22));
                    var invS = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                    q.X = Scalar.Multiply(Scalar.Add(matrix.M31, matrix.M13), invS);
                    q.Y = Scalar.Multiply(Scalar.Add(matrix.M32, matrix.M23), invS);
                    q.Z = Scalar.Divide(s, Scalar<T>.Two);
                    q.W = Scalar.Multiply(Scalar.Subtract(matrix.M12, matrix.M21), invS);
                }
            }

            return q;
        }

        /// <summary>Creates a Quaternion from the given rotation matrix.</summary>
        /// <param name="matrix">The rotation matrix.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromRotationMatrix(Matrix3X3<T> matrix)
        {
            var trace = Scalar.Add(Scalar.Add(matrix.M11, matrix.M22), matrix.M33);

            Quaternion<T> q = default;

            if (Scalar.GreaterThan(trace, Scalar<T>.Zero))
            {
                var s = Scalar.Sqrt(Scalar.Add(trace, Scalar<T>.One));
                q.W = Scalar.Divide(s, Scalar<T>.Two);
                s = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                q.X = Scalar.Multiply(Scalar.Subtract(matrix.M23, matrix.M32), s);
                q.Y = Scalar.Multiply(Scalar.Subtract(matrix.M31, matrix.M13), s);
                q.Z = Scalar.Multiply(Scalar.Subtract(matrix.M12, matrix.M21), s);
            }
            else
            {
                if (Scalar.GreaterThanOrEqual(matrix.M11, matrix.M22) && Scalar.GreaterThanOrEqual(matrix.M11, matrix.M33))
                {
                    var s = Scalar.Sqrt(Scalar.Subtract(Scalar.Subtract(Scalar.Add(Scalar<T>.One, matrix.M11), matrix.M22), matrix.M33));
                    var invS = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                    q.X = Scalar.Divide(s, Scalar<T>.Two);
                    q.Y = Scalar.Multiply(Scalar.Add(matrix.M12, matrix.M21), invS);
                    q.Z = Scalar.Multiply(Scalar.Add(matrix.M13, matrix.M31), invS);
                    q.W = Scalar.Multiply(Scalar.Subtract(matrix.M23, matrix.M32), invS);
                }
                else if (Scalar.GreaterThan(matrix.M22, matrix.M33))
                {
                    var s = Scalar.Sqrt(Scalar.Subtract(Scalar.Subtract(Scalar.Add(Scalar<T>.One, matrix.M22), matrix.M11), matrix.M33));
                    var invS = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                    q.X = Scalar.Multiply(Scalar.Add(matrix.M21, matrix.M12), invS);
                    q.Y = Scalar.Divide(s, Scalar<T>.Two);
                    q.Z = Scalar.Multiply(Scalar.Add(matrix.M32, matrix.M23), invS);
                    q.W = Scalar.Multiply(Scalar.Subtract(matrix.M31, matrix.M13), invS);
                }
                else
                {
                    var s = Scalar.Sqrt(Scalar.Subtract(Scalar.Subtract(Scalar.Add(Scalar<T>.One, matrix.M33), matrix.M11), matrix.M22));
                    var invS = Scalar.Reciprocal(Scalar.Multiply(Scalar<T>.Two, s));
                    q.X = Scalar.Multiply(Scalar.Add(matrix.M31, matrix.M13), invS);
                    q.Y = Scalar.Multiply(Scalar.Add(matrix.M32, matrix.M23), invS);
                    q.Z = Scalar.Divide(s, Scalar<T>.Two);
                    q.W = Scalar.Multiply(Scalar.Subtract(matrix.M12, matrix.M21), invS);
                }
            }

            return q;
        }

        /// <summary>Creates a new Quaternion from the given yaw, pitch, and roll, in radians.</summary>
        /// <param name="yaw">The yaw angle, in radians, around the Y-axis.</param>
        /// <param name="pitch">The pitch angle, in radians, around the X-axis.</param>
        /// <param name="roll">The roll angle, in radians, around the Z-axis.</param>
        /// <returns></returns>
        public static Quaternion<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
        {
            //  Roll first, about axis the object is facing, then
            //  pitch upward, then yaw to face into the new heading
            T sr, cr, sp, cp, sy, cy;

            var halfRoll = Scalar.Divide(roll, Scalar<T>.Two);
            sr = Scalar.Sin(halfRoll);
            cr = Scalar.Cos(halfRoll);

            var halfPitch = Scalar.Divide(pitch, Scalar<T>.Two);
            sp = Scalar.Sin(halfPitch);
            cp = Scalar.Cos(halfPitch);

            var halfYaw = Scalar.Divide(yaw, Scalar<T>.Two);
            sy = Scalar.Sin(halfYaw);
            cy = Scalar.Cos(halfYaw);

            Quaternion<T> result;

            result.X = Scalar.Add(Scalar.Multiply(Scalar.Multiply(cy, sp), cr), Scalar.Multiply(Scalar.Multiply(sy, cp), sr));
            result.Y = Scalar.Subtract(Scalar.Multiply(Scalar.Multiply(sy, cp), cr), Scalar.Multiply(Scalar.Multiply(cy, sp), sr));
            result.Z = Scalar.Subtract(Scalar.Multiply(Scalar.Multiply(cy, cp), sr), Scalar.Multiply(Scalar.Multiply(sy, sp), cr));
            result.W = Scalar.Add(Scalar.Multiply(Scalar.Multiply(cy, cp), cr), Scalar.Multiply(Scalar.Multiply(sy, sp), sr));

            return result;
        }

        /// <summary>Divides a Quaternion by another Quaternion.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The divisor.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Quaternion<T> Divide(Quaternion<T> value1, Quaternion<T> value2)
            => value1 / value2;

        /// <summary>Calculates the dot product of two Quaternions.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <returns>The dot product of the Quaternions.</returns>
        public static T Dot(Quaternion<T> quaternion1, Quaternion<T> quaternion2)
        {
            return Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(quaternion1.X, quaternion2.X),
                   Scalar.Multiply(quaternion1.Y, quaternion2.Y)),
                   Scalar.Multiply(quaternion1.Z, quaternion2.Z)),
                   Scalar.Multiply(quaternion1.W, quaternion2.W));
        }

        /// <summary>Returns the inverse of a Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The inverted Quaternion.</returns>
        public static Quaternion<T> Inverse(Quaternion<T> value)
        {
            //  -1   (       a              -v       )
            // q   = ( -------------   ------------- )
            //       (  a^2 + |v|^2  ,  a^2 + |v|^2  )

            Quaternion<T> ans;

            T ls = Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, value.X), Scalar.Multiply(value.Y, value.Y)), Scalar.Multiply(value.Z, value.Z)), Scalar.Multiply(value.W, value.W));
            var invNorm = Scalar.Reciprocal(ls);

            ans.X = Scalar.Negate(Scalar.Multiply(value.X, invNorm));
            ans.Y = Scalar.Negate(Scalar.Multiply(value.Y, invNorm));
            ans.Z = Scalar.Negate(Scalar.Multiply(value.Z, invNorm));
            ans.W = Scalar.Multiply(value.W, invNorm);

            return ans;
        }

        /// <summary> Linearly interpolates between two quaternions.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Lerp(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        {
            var t = amount;
            var t1 = Scalar.Subtract(Scalar<T>.One, t);

            Quaternion<T> r = default;

            T dot = Scalar.Add(
                Scalar.Add(
                    Scalar.Add(Scalar.Multiply(quaternion1.X, quaternion2.X),
                        Scalar.Multiply(quaternion1.Y, quaternion2.Y)),
                    Scalar.Multiply(quaternion1.Z, quaternion2.Z)),
                Scalar.Multiply(quaternion1.W, quaternion2.W));

            if (Scalar.GreaterThanOrEqual(dot, Scalar<T>.Zero))
            {
                r.X = Scalar.Add(Scalar.Multiply(t1, quaternion1.X), Scalar.Multiply(t, quaternion2.X));
                r.Y = Scalar.Add(Scalar.Multiply(t1, quaternion1.Y), Scalar.Multiply(t, quaternion2.Y));
                r.Z = Scalar.Add(Scalar.Multiply(t1, quaternion1.Z), Scalar.Multiply(t, quaternion2.Z));
                r.W = Scalar.Add(Scalar.Multiply(t1, quaternion1.W), Scalar.Multiply(t, quaternion2.W));
            }
            else
            {
                r.X = Scalar.Subtract(Scalar.Multiply(t1, quaternion1.X), Scalar.Multiply(t, quaternion2.X));
                r.Y = Scalar.Subtract(Scalar.Multiply(t1, quaternion1.Y), Scalar.Multiply(t, quaternion2.Y));
                r.Z = Scalar.Subtract(Scalar.Multiply(t1, quaternion1.Z), Scalar.Multiply(t, quaternion2.Z));
                r.W = Scalar.Subtract(Scalar.Multiply(t1, quaternion1.W), Scalar.Multiply(t, quaternion2.W));
            }

            // Normalize it.
            T ls = Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(r.X, r.X), Scalar.Multiply(r.Y, r.Y)), Scalar.Multiply(r.Z, r.Z)), Scalar.Multiply(r.W, r.W));
            var invNorm = Scalar.Reciprocal(Scalar.Sqrt(ls));

            r.X = Scalar.Multiply(r.X, invNorm);
            r.Y = Scalar.Multiply(r.Y, invNorm);
            r.Z = Scalar.Multiply(r.Z, invNorm);
            r.W = Scalar.Multiply(r.W, invNorm);

            return r;
        }

        /// <summary>Multiplies two Quaternions together.</summary>
        /// <param name="value1">The Quaternion on the left side of the multiplication.</param>
        /// <param name="value2">The Quaternion on the right side of the multiplication.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Quaternion<T> Multiply(Quaternion<T> value1, Quaternion<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a Quaternion by a scalar value.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Quaternion<T> Multiply(Quaternion<T> value1, T value2)
            => value1 * value2;

        /// <summary>Flips the sign of each component of the quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The negated Quaternion.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Quaternion<T> Negate(Quaternion<T> value)
            => -value;

        /// <summary>Divides each component of the Quaternion by the length of the Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The normalized Quaternion.</returns>
        public static Quaternion<T> Normalize(Quaternion<T> value)
        {
            Quaternion<T> ans;

            T ls = Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(value.X, value.X), Scalar.Multiply(value.Y, value.Y)), Scalar.Multiply(value.Z, value.Z)), Scalar.Multiply(value.W, value.W));
            var invNorm = Scalar.Reciprocal(Scalar.Sqrt(ls));

            ans.X = Scalar.Multiply(value.X, invNorm);
            ans.Y = Scalar.Multiply(value.Y, invNorm);
            ans.Z = Scalar.Multiply(value.Z, invNorm);
            ans.W = Scalar.Multiply(value.W, invNorm);

            return ans;
        }

        /// <summary>Interpolates between two quaternions, using spherical linear interpolation.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Slerp(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        {
            var t = amount;

            T cosOmega = Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(quaternion1.X, quaternion2.X), Scalar.Multiply(quaternion1.Y, quaternion2.Y)), Scalar.Multiply(quaternion1.Z, quaternion2.Z)), Scalar.Multiply(quaternion1.W, quaternion2.W));

            var flip = false;

            if (!Scalar.GreaterThanOrEqual(cosOmega, Scalar<T>.Zero))
            {
                flip = true;
                cosOmega = Scalar.Negate(cosOmega);
            }

            T s1, s2;

            if (Scalar.GreaterThan(cosOmega, Scalar.Subtract(Scalar<T>.One, Scalar.As<float, T>(SlerpEpsilon))))
            {
                // Too close, do straight linear interpolation.
                s1 = Scalar.Subtract(Scalar<T>.One, t);
                s2 = flip ? Scalar.Negate(t) : t;
            }
            else
            {
                var omega = Scalar.Acos(cosOmega);
                var invSinOmega = Scalar.Reciprocal(Scalar.Sin(omega));

                s1 = Scalar.Multiply(Scalar.Sin(Scalar.Multiply(Scalar.Subtract(Scalar<T>.One, t), omega)), invSinOmega);
                s2 = flip
                    ? Scalar.Negate(Scalar.Multiply(Scalar.Sin(Scalar.Multiply(t, omega)), invSinOmega))
                    : Scalar.Multiply(Scalar.Sin(Scalar.Multiply(t, omega)), invSinOmega);
            }

            Quaternion<T> ans;

            ans.X = Scalar.Add(Scalar.Multiply(s1, quaternion1.X), Scalar.Multiply(s2, quaternion2.X));
            ans.Y = Scalar.Add(Scalar.Multiply(s1, quaternion1.Y), Scalar.Multiply(s2, quaternion2.Y));
            ans.Z = Scalar.Add(Scalar.Multiply(s1, quaternion1.Z), Scalar.Multiply(s2, quaternion2.Z));
            ans.W = Scalar.Add(Scalar.Multiply(s1, quaternion1.W), Scalar.Multiply(s2, quaternion2.W));

            return ans;
        }

        /// <summary>Subtracts one Quaternion from another.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Quaternion<T> Subtract(Quaternion<T> value1, Quaternion<T> value2)
            => value1 - value2;

        /// <summary>Calculates the length of the Quaternion.</summary>
        /// <returns>The computed length of the Quaternion.</returns>
        public readonly T Length()
            => Scalar.Sqrt(LengthSquared());

        /// <summary>Calculates the length squared of the Quaternion. This operation is cheaper than Length().</summary>
        /// <returns>The length squared of the Quaternion.</returns>
        public readonly T LengthSquared()
            => Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(X, X), Scalar.Multiply(Y, Y)), Scalar.Multiply(Z, Z)), Scalar.Multiply(W, W));

        /// <summary>Returns a String representing this Quaternion instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", X, Y, Z, W);
        }

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Quaternion<Half>(Quaternion<T> from)
            => new(Scalar.As<T, Half>(from.X), Scalar.As<T, Half>(from.Y), Scalar.As<T, Half>(from.Z),
                Scalar.As<T, Half>(from.W));

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Quaternion<float>(Quaternion<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y), Scalar.As<T, float>(from.Z),
                Scalar.As<T, float>(from.W));

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into <see cref="Quaternion"/>
        /// </summary>
        /// <param name="from">The source quaternion</param>
        /// <returns>The <see cref="System.Numerics"/> quaternion</returns>
        public static explicit operator Quaternion(Quaternion<T> from)
            => new(Scalar.As<T, float>(from.X), Scalar.As<T, float>(from.Y), Scalar.As<T, float>(from.Z),
                Scalar.As<T, float>(from.W));

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Quaternion<double>(Quaternion<T> from)
            => new(Scalar.As<T, double>(from.X), Scalar.As<T, double>(from.Y), Scalar.As<T, double>(from.Z),
                Scalar.As<T, double>(from.W));

        /// <summary>
        /// Returns this quaternion casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted quaternion</returns>
        public Quaternion<TOther> As<TOther>() where TOther : ITrigonometricFunctions<TOther>
        {
            return new(Scalar.As<T, TOther>(X), Scalar.As<T, TOther>(Y), Scalar.As<T, TOther>(Z), Scalar.As<T, TOther>(W));
        }
    }
}
