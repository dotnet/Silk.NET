using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Silk.NET.Numerics
{
    public struct Quaternion<T>
        : IEquatable<Quaternion<T>> where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float SlerpEpsilon = 1e-6f;

        /// <summary>Specifies the X-value of the vector component of the Quaternion.</summary>
        public T X;

        /// <summary>Specifies the Y-value of the vector component of the Quaternion.</summary>
        public T Y;

        /// <summary>Specifies the Z-value of the vector component of the Quaternion.</summary>
        public T Z;

        /// <summary>Specifies the rotation component of the Quaternion.</summary>
        public T W;

        /// <summary>Constructs a Quaternion from the given components.</summary>
        /// <param name="x">The X component of the Quaternion.</param>
        /// <param name="y">The Y component of the Quaternion.</param>
        /// <param name="z">The Z component of the Quaternion.</param>
        /// <param name="w">The W component of the Quaternion.</param>
        public Quaternion(T x, T y, T z, T w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>Constructs a Quaternion from the given vector and rotation parts.</summary>
        /// <param name="vectorPart">The vector part of the Quaternion.</param>
        /// <param name="scalarPart">The rotation part of the Quaternion.</param>
        public Quaternion(Vector3<T> vectorPart, T scalarPart)
        {
            X = vectorPart.X;
            Y = vectorPart.Y;
            Z = vectorPart.Z;
            W = scalarPart;
        }

        /// <summary>Returns a Quaternion representing no rotation.</summary>
        public static Quaternion<T> Identity => new(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One);

        /// <summary>Returns whether the Quaternion is the identity Quaternion.</summary>
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Adds two Quaternions element-by-element.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <returns>The result of adding the Quaternions.</returns>
        public static Quaternion<T> operator +(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            ans.X = Operations.Add(value1.X, value2.X);
            ans.Y = Operations.Add(value1.Y, value2.Y);
            ans.Z = Operations.Add(value1.Z, value2.Z);
            ans.W = Operations.Add(value1.W, value2.W);

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
            T ls = Operations.Add(
                Operations.Add(
                    Operations.Add(Operations.Multiply(value2.X, value2.X), Operations.Multiply(value2.Y, value2.Y)),
                    Operations.Multiply(value2.Z, value2.Z)), Operations.Multiply(value2.W, value2.W));
            T invNorm = Operations.Divide(Constants<T>.One, ls);

            T q2x = Operations.Negate(Operations.Multiply(value2.X, invNorm));
            T q2y = Operations.Negate(Operations.Multiply(value2.Y, invNorm));
            T q2z = Operations.Negate(Operations.Multiply(value2.Z, invNorm));
            T q2w = Operations.Multiply(value2.W, invNorm);

            //-------------------------------------
            // Multiply part.

            // cross(av, bv)
            T cx = Operations.Subtract(Operations.Multiply(q1y, q2z), Operations.Multiply(q1z, q2y));
            T cy = Operations.Subtract(Operations.Multiply(q1z, q2x), Operations.Multiply(q1x, q2z));
            T cz = Operations.Subtract(Operations.Multiply(q1x, q2y), Operations.Multiply(q1y, q2x));

            T dot = Operations.Add(Operations.Add(Operations.Multiply(q1x, q2x), Operations.Multiply(q1y, q2y)),
                Operations.Multiply(q1z, q2z));

            ans.X = Operations.Add(Operations.Add(Operations.Multiply(q1x, q2w), Operations.Multiply(q2x, q1w)), cx);
            ans.Y = Operations.Add(Operations.Add(Operations.Multiply(q1y, q2w), Operations.Multiply(q2y, q1w)), cy);
            ans.Z = Operations.Add(Operations.Add(Operations.Multiply(q1z, q2w), Operations.Multiply(q2z, q1w)), cz);
            ans.W = Operations.Subtract(Operations.Multiply(q1w, q2w), dot);

            return ans;
        }

        /// <summary>Returns a boolean indicating whether the two given Quaternions are equal.</summary>
        /// <param name="value1">The first Quaternion to compare.</param>
        /// <param name="value2">The second Quaternion to compare.</param>
        /// <returns>True if the Quaternions are equal; False otherwise.</returns>
        public static bool operator ==(Quaternion<T> value1, Quaternion<T> value2)
            => Operations.Equal(value1.X, value2.X)
            && Operations.Equal(value1.Y, value2.Y)
            && Operations.Equal(value1.Z, value2.Z)
            && Operations.Equal(value1.W, value2.W);

        /// <summary>Returns a boolean indicating whether the two given Quaternions are not equal.</summary>
        /// <param name="value1">The first Quaternion to compare.</param>
        /// <param name="value2">The second Quaternion to compare.</param>
        /// <returns>True if the Quaternions are not equal; False if they are equal.</returns>
        public static bool operator !=(Quaternion<T> value1, Quaternion<T> value2)
            => !(value1 == value2);

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
            T cx = Operations.Subtract(Operations.Multiply(q1y, q2z), Operations.Multiply(q1z, q2y));
            T cy = Operations.Subtract(Operations.Multiply(q1z, q2x), Operations.Multiply(q1x, q2z));
            T cz = Operations.Subtract(Operations.Multiply(q1x, q2y), Operations.Multiply(q1y, q2x));

            T dot = Operations.Add(Operations.Add(Operations.Multiply(q1x, q2x), Operations.Multiply(q1y, q2y)),
                Operations.Multiply(q1z, q2z));

            ans.X = Operations.Add(Operations.Add(Operations.Multiply(q1x, q2w), Operations.Multiply(q2x, q1w)), cx);
            ans.Y = Operations.Add(Operations.Add(Operations.Multiply(q1y, q2w), Operations.Multiply(q2y, q1w)), cy);
            ans.Z = Operations.Add(Operations.Add(Operations.Multiply(q1z, q2w), Operations.Multiply(q2z, q1w)), cz);
            ans.W = Operations.Subtract(Operations.Multiply(q1w, q2w), dot);

            return ans;
        }

        /// <summary>Multiplies a Quaternion by a scalar value.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> value1, T value2)
        {
            Quaternion<T> ans;

            ans.X = Operations.Multiply(value1.X, value2);
            ans.Y = Operations.Multiply(value1.Y, value2);
            ans.Z = Operations.Multiply(value1.Z, value2);
            ans.W = Operations.Multiply(value1.W, value2);

            return ans;
        }

        /// <summary>Subtracts one Quaternion from another.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Quaternion<T> operator -(Quaternion<T> value1, Quaternion<T> value2)
        {
            Quaternion<T> ans;

            ans.X = Operations.Subtract(value1.X, value2.X);
            ans.Y = Operations.Subtract(value1.Y, value2.Y);
            ans.Z = Operations.Subtract(value1.Z, value2.Z);
            ans.W = Operations.Subtract(value1.W, value2.W);

            return ans;
        }

        /// <summary>Flips the sign of each component of the quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The negated Quaternion.</returns>
        public static Quaternion<T> operator -(Quaternion<T> value)
        {
            Quaternion<T> ans;

            ans.X = Operations.Negate(value.X);
            ans.Y = Operations.Negate(value.Y);
            ans.Z = Operations.Negate(value.Z);
            ans.W = Operations.Negate(value.W);

            return ans;
        }

        /// <summary>Adds two Quaternions element-by-element.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second source Quaternion.</param>
        /// <returns>The result of adding the Quaternions.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
            T cx = Operations.Subtract(Operations.Multiply(q1y, q2z), Operations.Multiply(q1z, q2y));
            T cy = Operations.Subtract(Operations.Multiply(q1z, q2x), Operations.Multiply(q1x, q2z));
            T cz = Operations.Subtract(Operations.Multiply(q1x, q2y), Operations.Multiply(q1y, q2x));

            T dot = Operations.Add(Operations.Add(Operations.Multiply(q1x, q2x), Operations.Multiply(q1y, q2y)),
                Operations.Multiply(q1z, q2z));

            ans.X = Operations.Add(Operations.Add(Operations.Multiply(q1x, q2w), Operations.Multiply(q2x, q1w)), cx);
            ans.Y = Operations.Add(Operations.Add(Operations.Multiply(q1y, q2w), Operations.Multiply(q2y, q1w)), cy);
            ans.Z = Operations.Add(Operations.Add(Operations.Multiply(q1z, q2w), Operations.Multiply(q2z, q1w)), cz);
            ans.W = Operations.Subtract(Operations.Multiply(q1w, q2w), dot);
            
            return ans;
        }

        /// <summary>Creates the conjugate of a specified Quaternion.</summary>
        /// <param name="value">The Quaternion of which to return the conjugate.</param>
        /// <returns>A new Quaternion that is the conjugate of the specified one.</returns>
        public static Quaternion<T> Conjugate(Quaternion<T> value)
        {
            Quaternion<T> ans;

            ans.X = Operations.Negate(value.X);
            ans.Y = Operations.Negate(value.Y);
            ans.Z = Operations.Negate(value.Z);
            ans.W = value.W;

            return ans;
        }

        /// <summary>Creates a Quaternion from a normalized vector axis and an angle to rotate about the vector.</summary>
        /// <param name="axis">The unit vector to rotate around.
        /// This vector must be normalized before calling this function or the resulting Quaternion will be incorrect.</param>
        /// <param name="angle">The angle, in radians, to rotate around the vector.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            Quaternion<T> ans;

            T halfAngle = Operations.Divide(angle, Constants<T>.Two);
            T s = Operations.Sin(halfAngle);
            T c = Operations.Cos(halfAngle);

            ans.X = Operations.Multiply(axis.X, s);
            ans.Y = Operations.Multiply(axis.Y, s);
            ans.Z = Operations.Multiply(axis.Z, s);
            ans.W = c;

            return ans;
        }

        /// <summary>Creates a Quaternion from the given rotation matrix.</summary>
        /// <param name="matrix">The rotation matrix.</param>
        /// <returns>The created Quaternion.</returns>
        public static Quaternion<T> CreateFromRotationMatrix(Matrix4x4<T> matrix)
        {
            T trace = Operations.Add(Operations.Add(matrix.M11, matrix.M22), matrix.M33);

            Quaternion<T> q = default;

            if (Operations.GreaterThan(trace, Constants<T>.Zero))
            {
                T s = Operations.Sqrt(Operations.Add(trace, Constants<T>.One));
                q.W = Operations.Divide(s, Constants<T>.Two);
                s = Operations.Divide(Constants<T>.One, Operations.Multiply(Constants<T>.Two, s));
                q.X = Operations.Multiply(Operations.Subtract(matrix.M23, matrix.M32), s);
                q.Y = Operations.Multiply(Operations.Subtract(matrix.M31, matrix.M13), s);
                q.Z = Operations.Multiply(Operations.Subtract(matrix.M12, matrix.M21), s);
            }
            else
            {
                if (Operations.GreaterThanOrEqual(matrix.M11, matrix.M22) && Operations.GreaterThanOrEqual(matrix.M11, matrix.M33))
                {
                    T s = Operations.Sqrt(Operations.Subtract(Operations.Subtract(Operations.Add(Constants<T>.One, matrix.M11), matrix.M22), matrix.M33));
                    T invS = Operations.Divide(Constants<T>.One, Operations.Multiply(Constants<T>.Two, s));
                    q.X = Operations.Divide(s, Constants<T>.Two);
                    q.Y = Operations.Multiply(Operations.Add(matrix.M12, matrix.M21), invS);
                    q.Z = Operations.Multiply(Operations.Add(matrix.M13, matrix.M31), invS);
                    q.W = Operations.Multiply(Operations.Subtract(matrix.M23, matrix.M32), invS);
                }
                else if (Operations.GreaterThan(matrix.M22, matrix.M33))
                {
                    T s = Operations.Sqrt(Operations.Subtract(Operations.Subtract(Operations.Add(Constants<T>.One, matrix.M22), matrix.M11), matrix.M33));
                    T invS = Operations.Divide(Constants<T>.One, Operations.Multiply(Constants<T>.Two, s));
                    q.X = Operations.Multiply(Operations.Add(matrix.M21, matrix.M12), invS);
                    q.Y = Operations.Divide(s, Constants<T>.Two);
                    q.Z = Operations.Multiply(Operations.Add(matrix.M32, matrix.M23), invS);
                    q.W = Operations.Multiply(Operations.Subtract(matrix.M31, matrix.M13), invS);
                }
                else
                {
                    T s = Operations.Sqrt(Operations.Subtract(Operations.Subtract(Operations.Add(Constants<T>.One, matrix.M33), matrix.M11), matrix.M22));
                    T invS = Operations.Divide(Constants<T>.One, Operations.Multiply(Constants<T>.Two, s));
                    q.X = Operations.Multiply(Operations.Add(matrix.M31, matrix.M13), invS);
                    q.Y = Operations.Multiply(Operations.Add(matrix.M32, matrix.M23), invS);
                    q.Z = Operations.Divide(s, Constants<T>.Two);
                    q.W = Operations.Multiply(Operations.Subtract(matrix.M12, matrix.M21), invS);
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

            T halfRoll = Operations.Divide(roll, Constants<T>.Two);
            sr = Operations.Sin(halfRoll);
            cr = Operations.Cos(halfRoll);

            T halfPitch = Operations.Divide(pitch, Constants<T>.Two);
            sp = Operations.Sin(halfPitch);
            cp = Operations.Cos(halfPitch);

            T halfYaw = Operations.Divide(yaw, Constants<T>.Two);
            sy = Operations.Sin(halfYaw);
            cy = Operations.Cos(halfYaw);

            Quaternion<T> result;

            result.X = Operations.Add(Operations.Multiply(Operations.Multiply(cy, sp), cr), Operations.Multiply(Operations.Multiply(sy, cp), sr));
            result.Y = Operations.Subtract(Operations.Multiply(Operations.Multiply(sy, cp), cr), Operations.Multiply(Operations.Multiply(cy, sp), sr));
            result.Z = Operations.Subtract(Operations.Multiply(Operations.Multiply(cy, cp), sr), Operations.Multiply(Operations.Multiply(sy, sp), cr));
            result.W = Operations.Add(Operations.Multiply(Operations.Multiply(cy, cp), cr), Operations.Multiply(Operations.Multiply(sy, sp), sr));

            return result;
        }

        /// <summary>Divides a Quaternion by another Quaternion.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The divisor.</param>
        /// <returns>The result of the division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion<T> Divide(Quaternion<T> value1, Quaternion<T> value2)
            => value1 / value2;

        /// <summary>Calculates the dot product of two Quaternions.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <returns>The dot product of the Quaternions.</returns>
        public static T Dot(Quaternion<T> quaternion1, Quaternion<T> quaternion2)
        {
            return Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(quaternion1.X, quaternion2.X),
                   Operations.Multiply(quaternion1.Y,quaternion2.Y)),
                   Operations.Multiply(quaternion1.Z, quaternion2.Z)),
                   Operations.Multiply(quaternion1.W, quaternion2.W));
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

            T ls = Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(value.X, value.X), Operations.Multiply(value.Y, value.Y)), Operations.Multiply(value.Z, value.Z)), Operations.Multiply(value.W, value.W));
            T invNorm = Operations.Divide(Constants<T>.One, ls);

            ans.X = Operations.Negate(Operations.Multiply(value.X, invNorm));
            ans.Y = Operations.Negate(Operations.Multiply(value.Y, invNorm));
            ans.Z = Operations.Negate(Operations.Multiply(value.Z, invNorm));
            ans.W = Operations.Multiply(value.W, invNorm);

            return ans;
        }

        /// <summary> Linearly interpolates between two quaternions.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Lerp(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        {
            T t = amount;
            T t1 = Operations.Subtract(Constants<T>.One, t);

            Quaternion<T> r = default;

            T dot = Operations.Add(
                Operations.Add(
                    Operations.Add(Operations.Multiply(quaternion1.X, quaternion2.X),
                        Operations.Multiply(quaternion1.Y, quaternion2.Y)),
                    Operations.Multiply(quaternion1.Z, quaternion2.Z)),
                Operations.Multiply(quaternion1.W, quaternion2.W));

            if (Operations.GreaterThanOrEqual(dot, Constants<T>.Zero))
            {
                r.X = Operations.Add(Operations.Multiply(t1, quaternion1.X), Operations.Multiply(t, quaternion2.X));
                r.Y = Operations.Add(Operations.Multiply(t1, quaternion1.Y), Operations.Multiply(t, quaternion2.Y));
                r.Z = Operations.Add(Operations.Multiply(t1, quaternion1.Z), Operations.Multiply(t, quaternion2.Z));
                r.W = Operations.Add(Operations.Multiply(t1, quaternion1.W), Operations.Multiply(t, quaternion2.W));
            }
            else
            {
                r.X = Operations.Subtract(Operations.Multiply(t1, quaternion1.X), Operations.Multiply(t, quaternion2.X));
                r.Y = Operations.Subtract(Operations.Multiply(t1, quaternion1.Y), Operations.Multiply(t, quaternion2.Y));
                r.Z = Operations.Subtract(Operations.Multiply(t1, quaternion1.Z), Operations.Multiply(t, quaternion2.Z));
                r.W = Operations.Subtract(Operations.Multiply(t1, quaternion1.W), Operations.Multiply(t, quaternion2.W));
            }

            // Normalize it.
            T ls = Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(r.X, r.X), Operations.Multiply(r.Y, r.Y)), Operations.Multiply(r.Z, r.Z)), Operations.Multiply(r.W, r.W));
            T invNorm = Operations.Divide(Constants<T>.One, Operations.Sqrt(ls));

            r.X = Operations.Multiply(r.X, invNorm);
            r.Y = Operations.Multiply(r.Y, invNorm);
            r.Z = Operations.Multiply(r.Z, invNorm);
            r.W = Operations.Multiply(r.W, invNorm);

            return r;
        }

        /// <summary>Multiplies two Quaternions together.</summary>
        /// <param name="value1">The Quaternion on the left side of the multiplication.</param>
        /// <param name="value2">The Quaternion on the right side of the multiplication.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion<T> Multiply(Quaternion<T> value1, Quaternion<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a Quaternion by a scalar value.</summary>
        /// <param name="value1">The source Quaternion.</param>
        /// <param name="value2">The scalar value.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion<T> Multiply(Quaternion<T> value1, T value2)
            => value1 * value2;

        /// <summary>Flips the sign of each component of the quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The negated Quaternion.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion<T> Negate(Quaternion<T> value)
            => -value;

        /// <summary>Divides each component of the Quaternion by the length of the Quaternion.</summary>
        /// <param name="value">The source Quaternion.</param>
        /// <returns>The normalized Quaternion.</returns>
        public static Quaternion<T> Normalize(Quaternion<T> value)
        {
            Quaternion<T> ans;

            T ls = Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(value.X, value.X), Operations.Multiply(value.Y, value.Y)), Operations.Multiply(value.Z, value.Z)), Operations.Multiply(value.W, value.W));
            T invNorm = Operations.Divide(Constants<T>.One, Operations.Sqrt(ls));

            ans.X = Operations.Multiply(value.X, invNorm);
            ans.Y = Operations.Multiply(value.Y, invNorm);
            ans.Z = Operations.Multiply(value.Z, invNorm);
            ans.W = Operations.Multiply(value.W, invNorm);

            return ans;
        }

        /// <summary>Interpolates between two quaternions, using spherical linear interpolation.</summary>
        /// <param name="quaternion1">The first source Quaternion.</param>
        /// <param name="quaternion2">The second source Quaternion.</param>
        /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
        /// <returns>The interpolated Quaternion.</returns>
        public static Quaternion<T> Slerp(Quaternion<T> quaternion1, Quaternion<T> quaternion2, T amount)
        {
            T t = amount;

            T cosOmega = Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(quaternion1.X, quaternion2.X), Operations.Multiply(quaternion1.Y, quaternion2.Y)), Operations.Multiply(quaternion1.Z, quaternion2.Z)), Operations.Multiply(quaternion1.W, quaternion2.W));

            bool flip = false;

            if (!Operations.GreaterThanOrEqual(cosOmega, Constants<T>.Zero))
            {
                flip = true;
                cosOmega = Operations.Negate(cosOmega);
            }

            T s1, s2;

            if (Operations.GreaterThan(cosOmega, Operations.Subtract(Constants<T>.One, Operations.As<float, T>(SlerpEpsilon))))
            {
                // Too close, do straight linear interpolation.
                s1 = Operations.Subtract(Constants<T>.One, t);
                s2 = flip ? Operations.Negate(t) : t;
            }
            else
            {
                T omega = Operations.Acos(cosOmega);
                T invSinOmega = Operations.Divide(Constants<T>.One, Operations.Sin(omega));

                s1 = Operations.Multiply(Operations.Sin(Operations.Multiply(Operations.Subtract(Constants<T>.One, t), omega)), invSinOmega);
                s2 = (flip)
                    ? Operations.Negate(Operations.Multiply(Operations.Sin(Operations.Multiply(t, omega)), invSinOmega))
                    : Operations.Multiply(Operations.Sin(Operations.Multiply(t, omega)), invSinOmega);
            }

            Quaternion<T> ans;

            ans.X = Operations.Add(Operations.Multiply(s1, quaternion1.X), Operations.Multiply(s2, quaternion2.X));
            ans.Y = Operations.Add(Operations.Multiply(s1, quaternion1.Y), Operations.Multiply(s2, quaternion2.Y));
            ans.Z = Operations.Add(Operations.Multiply(s1, quaternion1.Z), Operations.Multiply(s2, quaternion2.Z));
            ans.W = Operations.Add(Operations.Multiply(s1, quaternion1.W), Operations.Multiply(s2, quaternion2.W));

            return ans;
        }

        /// <summary>Subtracts one Quaternion from another.</summary>
        /// <param name="value1">The first source Quaternion.</param>
        /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion<T> Subtract(Quaternion<T> value1, Quaternion<T> value2)
            => value1 - value2;

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Quaternion instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Quaternion; False otherwise.</returns>
        public override readonly bool Equals(object? obj)
            => (obj is Quaternion<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether the given Quaternion is equal to this Quaternion instance.</summary>
        /// <param name="other">The Quaternion to compare this instance to.</param>
        /// <returns>True if the other Quaternion is equal to this instance; False otherwise.</returns>
        public readonly bool Equals(Quaternion<T> other)
            => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return unchecked(X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + W.GetHashCode());
        }

        /// <summary>Calculates the length of the Quaternion.</summary>
        /// <returns>The computed length of the Quaternion.</returns>
        public readonly T Length()
            => Operations.Sqrt(LengthSquared());

        /// <summary>Calculates the length squared of the Quaternion. This operation is cheaper than Length().</summary>
        /// <returns>The length squared of the Quaternion.</returns>
        public readonly T LengthSquared()
            => Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(X, X), Operations.Multiply(Y, Y)),Operations.Multiply(Z , Z)), Operations.Multiply(W, W));

        /// <summary>Returns a String representing this Quaternion instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", X, Y, Z, W);
        }
    }
}
