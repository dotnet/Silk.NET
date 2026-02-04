// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Represents a four-dimensional vector used to encode 3D rotations.
    /// </summary>
    public partial struct Quaternion<T> :
        IEquatable<Quaternion<T>>
        where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector3D<T> Axis;

        /// <summary>Specifies the X-value of the vector component of the Quaternion.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T X => ref Axis.X;

        /// <summary>Specifies the Y-value of the vector component of the Quaternion.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T Y => ref Axis.Y;

        /// <summary>Specifies the Z-value of the vector component of the Quaternion.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T Z => ref Axis.Z;

        /// <summary>Specifies the rotation (W) component of the Quaternion.</summary>
        [DataMember]
        public T W;

        /// <summary>Constructs a Quaternion from the given components.</summary>
        /// <param name="x">The X-component of the Quaternion.</param>
        /// <param name="y">The Y-component of the Quaternion.</param>
        /// <param name="z">The Z-component of the Quaternion.</param>
        /// <param name="w">The rotation (W) component of the Quaternion.</param>
        public Quaternion(T x, T y, T z, T w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        // TODO: Vector4F/Vector3F constructors
        /// <summary>Constructs a Quaternion from the given components.</summary>
        /// <param name="axis">The 3-component vector representing a direction.</param>
        /// <param name="w">The rotation (W) component of the Quaternion.</param>
        public Quaternion(Vector3D<T> axis, T w)
        {
            X = axis.X;
            Y = axis.Y;
            Z = axis.Z;
            W = w;
        }

        /// <summary>Constructs a Quaternion from the given vector.</summary>
        /// <param name="components">The 4-component vector representing a Quaternion.</param>
        public Quaternion(Vector4D<T> components)
        {
            X = components.X;
            Y = components.Y;
            Z = components.Z;
            W = components.W;
        }

        /// <summary>Gets the rotation angle represented by the <see cref="Quaternion{T}"/>.</summary>
        public T Angle => T.CreateChecked(2) * T.Acos(W);

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z, 3 = W. </summary>
        // TODO: Make this a ref
        public T this[int index] => index switch {
            0 => X,
            1 => Y,
            2 => Z,
            3 => W,
            _ => throw new IndexOutOfRangeException(nameof(index))
        };

        /// <summary>Returns the zero <see cref="Quaternion{T}"/>, representing an undefined rotation.</summary>
        public static Quaternion<T> Zero { get; } = new Quaternion<T>(T.Zero, T.Zero, T.Zero, T.Zero);

        /// <summary>Returns a <see cref="Quaternion{T}"/> representing no rotation.</summary>
        public static Quaternion<T> Identity { get; } = new Quaternion<T>(T.Zero, T.Zero, T.Zero, T.One);

        /// <summary>Returns whether the Quaternion is the identity Quaternion.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Calculates the length of the Quaternion.</summary>
        /// <returns>The computed length of the Quaternion.</returns>
        public readonly T Length
            => T.Sqrt(LengthSquared);

        /// <summary>Calculates the length squared of the Quaternion. This operation is cheaper than Length().</summary>
        /// <returns>The length squared of the Quaternion.</returns>
        public readonly T LengthSquared
            => (Axis.X * Axis.X) + (Axis.Y * Axis.Y) + (Axis.Z * Axis.Z) + (W * W);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Quaternion{T}"/> instance.</summary>
        public override bool Equals(object? obj) =>
            obj is Quaternion<T> other && Equals(other);

        /// <summary>Returns a boolean indicating whether the given <see cref="Quaternion{T}"/> is equal to this <see cref="Quaternion{T}"/> instance.</summary>
        public bool Equals(Quaternion<T> other) =>
            this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode() =>
            HashCode.Combine(X, Y, Z, W);

        /// <summary>Formats the Quaternion as a string.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() =>
            $"<{Axis.X}, {Axis.Y}, {Axis.Z}, {W}>";

        /// <summary>Returns a boolean indicating whether the two given Quaternions are not equal.</summary>
        /// <param name="left">The first Quaternion to compare.</param>
        /// <param name="right">The second Quaternion to compare.</param>
        /// <returns>True if the Quaternions are not equal; False if they are equal.</returns>
        public static bool operator !=(Quaternion<T> left, Quaternion<T> right) =>
            !(left == right);

        /// <summary>Returns a boolean indicating whether the two given Quaternions are equal.</summary>
        /// <param name="left">The first Quaternion to compare.</param>
        /// <param name="right">The second Quaternion to compare.</param>
        /// <returns>True if the Quaternions are equal; False otherwise.</returns>
        public static bool operator ==(Quaternion<T> left, Quaternion<T> right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;

        /// <summary>Adds two Quaternions element-by-element.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <returns>The result of adding the Quaternions.</returns>
        public static Quaternion<T> operator +(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans = default;

            ans.X = value1.X + value2.X;
            ans.Y = value1.Y + value2.Y;
            ans.Z = value1.Z + value2.Z;
            ans.W = value1.W + value2.W;

            return ans;
        }

        /// <summary>Subtracts one Quaternion from another.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Quaternion<T> operator -(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans = default;

            ans.X = value1.X - value2.X;
            ans.Y = value1.Y - value2.Y;
            ans.Z = value1.Z - value2.Z;
            ans.W = value1.W - value2.W;

            return ans;
        }

        /// <summary>Multiplies two Quaternions together.</summary>
        /// <param name="value1">The Quaternion on the left side of the multiplication.</param>
        /// <param name="value2">The Quaternion on the right side of the multiplication.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans = default;

            T q1x = value1.X;
            T q1y = value1.Y;
            T q1z = value1.Z;
            T q1w = value1.W;

            T q2x = value2.X;
            T q2y = value2.Y;
            T q2z = value2.Z;
            T q2w = value2.W;

            // cross(av, bv)
            var cx = (q1y * q2z) - (q1z * q2y);
            var cy = (q1z * q2x) - (q1x * q2z);
            var cz = (q1x * q2y) - (q1y * q2x);

            var dot = (q1x * q2x) + (q1y * q2y) + (q1z * q2z);

            ans.X = (q1x * q2w) + (q2x * q1w) + cx;
            ans.Y = (q1y * q2w) + (q2y * q1w) + cy;
            ans.Z = (q1z * q2w) + (q2z * q1w) + cz;
            ans.W = (q1w * q2w) - dot;

            return ans;
        }

        /// <summary>Divides a Quaternion by another Quaternion.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The divisor.</param>
        /// <returns>The result of the division.</returns>
        public static Quaternion<T> operator /(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans = default;

            T q1x = value1.X;
            T q1y = value1.Y;
            T q1z = value1.Z;
            T q1w = value1.W;

            //-------------------------------------
            // Inverse part.
            var invNorm = T.One / value2.LengthSquared;

            var q2x = -(value2.X * invNorm);
            var q2y = -(value2.Y * invNorm);
            var q2z = -(value2.Z * invNorm);
            var q2w = value2.W * invNorm;

            //-------------------------------------
            // Multiply part.

            // cross(av, bv)
            var cx = (q1y * q2z) - (q1z * q2y);
            var cy = (q1z * q2x) - (q1x * q2z);
            var cz = (q1x * q2y) - (q1y * q2x);

            var dot = (q1x * q2x) + (q1y * q2y) + (q1z * q2z);

            ans.X = (q1x * q2w) + (q2x * q1w) + cx;
            ans.Y = (q1y * q2w) + (q2y * q1w) + cy;
            ans.Z = (q1z * q2w) + (q2z * q1w) + cz;
            ans.W = (q1w * q2w) - dot;

            return ans;
        }

        /// <summary>Flips the sign of each component of the Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The negated Quaternion.</returns>
        public static Quaternion<T> operator -(Quaternion<T> value)
        {
            Quaternion<T> ans = default;

            ans.X = -value.X;
            ans.Y = -value.Y;
            ans.Z = -value.Z;
            ans.W = -value.W;

            return ans;
        }

        /// <summary>Multiplies a Quaternion by a scalar value.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> value1, T value2)
        {
            Quaternion<T> ans = default;

            ans.X = value1.X * value2;
            ans.Y = value1.Y * value2;
            ans.Z = value1.Z * value2;
            ans.W = value1.W * value2;

            return ans;
        }

        /// <summary>Normalizes a Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The normalized Quaternion.</returns>
        public static Quaternion<T> Normalize(Quaternion<T> value)
        {
            Quaternion<T> ans = default;

            var invNorm = T.One / value.LengthSquared;

            ans.X = value.X * invNorm;
            ans.Y = value.Y * invNorm;
            ans.Z = value.Z * invNorm;
            ans.W = value.W * invNorm;

            return ans;
        }

        /// <summary>Normalizes the Quaternion.</summary>
        /// <remarks>This modifies the Quaternion. Use <see cref="Normalize(Quaternion{T})"/> to obtain a new value without affecting the original.</remarks>
        public void Normalize()
        {
            var invNorm = T.One / LengthSquared;

            X *= invNorm;
            Y *= invNorm;
            Z *= invNorm;
            W *= invNorm;
        }

        /// <summary>Inverts a Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The inverted Quaternion.</returns>
        public static Quaternion<T> Invert(Quaternion<T> value)
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

        /// <summary>Inverts the Quaternion.</summary>
        /// <remarks>This modifies the Quaternion. Use <see cref="Invert(Quaternion{T})"/> to obtain a new value without affecting the original.</remarks>
        public void Invert()
        {
            var invNorm = T.One / LengthSquared;

            X *= -invNorm;
            Y *= -invNorm;
            Z *= -invNorm;
            W *= invNorm;
        }

        /// <summary>Calculates the dot product of two Quaternions.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <returns>The dot product of the Quaternions.</returns>
        public static T Dot(Quaternion<T> quaternion1, Quaternion<T> quaternion2) =>
            (quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y) + (quaternion1.Z * quaternion2.Z) + (quaternion1.W * quaternion2.W);

        /// <summary>Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.</summary>
        /// <param name="value1">The first Quaternion rotation in the series.</param>
        /// <param name="value2">The second Quaternion rotation in the series.</param>
        /// <returns>A new Quaternion representing the concatenation of the value1 rotation followed by the value2 rotation.</returns>
        public static Quaternion<T> Concatenate(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans = default;

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
            var cx = (q1y * q2z) - (q1z * q2y);
            var cy = (q1z * q2x) - (q1x * q2z);
            var cz = (q1x * q2y) - (q1y * q2x);

            var dot = (q1x * q2x) + (q1y * q2y) + (q1z * q2z);

            ans.X = (q1x * q2w) + (q2x * q1w) + cx;
            ans.Y = (q1y * q2w) + (q2y * q1w) + cy;
            ans.Z = (q1z * q2w) + (q2z * q1w) + cz;
            ans.W = (q1w * q2w) - dot;

            return ans;
        }

        /// <summary>Creates the conjugate of a specified Quaternion.</summary>
        /// <param name="value">The Quaternion of which to return the conjugate.</param>
        /// <returns>A new Quaternion that is the conjugate of the specified one.</returns>
        public static Quaternion<T> Conjugate(Quaternion<T> value)
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
        public static Quaternion<T> CreateFromAxisAngle(Vector3D<T> axis, T angle)
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
        public static Quaternion<T> CreateFromRotationMatrix(Matrix4X4<T> matrix)
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
        public static Quaternion<T> CreateFromRotationMatrix(Matrix3X3<T> matrix)
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
        public static Quaternion<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
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
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Lerp(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        {
            var t = amount;
            var t1 = T.One - t;

            Quaternion<T> r = default;

            T dot = (quaternion1.X * quaternion2.X)
                + (quaternion1.Y * quaternion2.Y)
                + (quaternion1.Z * quaternion2.Z)
                + (quaternion1.W * quaternion2.W);

            if (dot >= T.Zero)
            {
                r.X = (t1 * quaternion1.X) + (t * quaternion2.X);
                r.Y = (t1 * quaternion1.Y) + (t * quaternion2.Y);
                r.Z = (t1 * quaternion1.Z) + (t * quaternion2.Z);
                r.W = (t1 * quaternion1.W) + (t * quaternion2.W);
            }
            else
            {
                r.X = (t1 * quaternion1.X) - (t * quaternion2.X);
                r.Y = (t1 * quaternion1.Y) - (t * quaternion2.Y);
                r.Z = (t1 * quaternion1.Z) - (t * quaternion2.Z);
                r.W = (t1 * quaternion1.W) - (t * quaternion2.W);
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
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Slerp(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        {
            const float SlerpEpsilon = 1e-6f;

            var t = amount;

            T cosOmega = (quaternion1.X * quaternion2.X) + (quaternion1.Y * quaternion2.Y) + (quaternion1.Z * quaternion2.Z) + (quaternion1.W * quaternion2.W);

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

            ans.X = (s1 * quaternion1.X) + (s2 * quaternion2.X);
            ans.Y = (s1 * quaternion1.Y) + (s2 * quaternion2.Y);
            ans.Z = (s1 * quaternion1.Z) + (s2 * quaternion2.Z);
            ans.W = (s1 * quaternion1.W) + (s2 * quaternion2.W);

            return ans;
        }
    }
}
