// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

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
        [DataMember]
        public Vector3D<T> Axis;

        /// <summary>Specifies the X-value of the vector component of the Quaternion.</summary>
        [IgnoreDataMember]
        [UnscopedRef]
        public ref T X => ref Axis.X;

        /// <summary>Specifies the Y-value of the vector component of the Quaternion.</summary>
        [IgnoreDataMember]
        [UnscopedRef]
        public ref T Y => ref Axis.Y;

        /// <summary>Specifies the Z-value of the vector component of the Quaternion.</summary>
        [IgnoreDataMember]
        [UnscopedRef]
        public ref T Z => ref Axis.Z;

        /// <summary>Specifies the rotation (W) component of the Quaternion.</summary>
        [DataMember]
        public T W;

        /// <summary>Constructs a Quaternion from the given components.</summary>
        /// <param name="axis">The 3-component vector representing a direction.</param>
        /// <param name="w">The rotation (W) component of the Quaternion.</param>
        public Quaternion(Vector3D<T> axis, T w)
        {
            Axis = axis;
            W = w;
        }

        /// <summary>Constructs a Quaternion from the given components.</summary>
        /// <param name="x">The X-component of the Quaternion.</param>
        /// <param name="y">The Y-component of the Quaternion.</param>
        /// <param name="z">The Z-component of the Quaternion.</param>
        /// <param name="w">The rotation (W) component of the Quaternion.</param>
        public Quaternion(T x, T y, T z, T w)
            : this(new(x, y, z), w)
        {
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
        public readonly T Angle => T.CreateChecked(2) * T.Acos(W);

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z, 3 = W. </summary>
        [UnscopedRef]
        public ref T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return ref X;
                    case 1:
                        return ref Y;
                    case 2:
                        return ref Z;
                    case 3:
                        return ref W;
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>Returns the zero <see cref="Quaternion{T}"/>, representing an undefined rotation.</summary>
        public static Quaternion<T> Zero { get; } = new Quaternion<T>(T.Zero, T.Zero, T.Zero, T.Zero);

        /// <summary>Returns a <see cref="Quaternion{T}"/> representing no rotation.</summary>
        public static Quaternion<T> Identity { get; } = new Quaternion<T>(T.Zero, T.Zero, T.Zero, T.One);

        /// <summary>Returns whether the Quaternion is the identity Quaternion.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Calculates the length of the Quaternion.</summary>
        /// <returns>The computed length of the Quaternion.</returns>
        public readonly T Length =>
            T.Sqrt(LengthSquared);

        /// <summary>Calculates the length squared of the Quaternion. This operation is cheaper than Length().</summary>
        /// <returns>The length squared of the Quaternion.</returns>
        public readonly T LengthSquared =>
            (Axis.X * Axis.X) + (Axis.Y * Axis.Y) + (Axis.Z * Axis.Z) + (W * W);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Quaternion{T}"/> instance.</summary>
        public override bool Equals(object? obj) =>
            obj is Quaternion<T> other && Equals(other);

        /// <summary>Returns a boolean indicating whether the given <see cref="Quaternion{T}"/> is equal to this <see cref="Quaternion{T}"/> instance.</summary>
        public readonly bool Equals(Quaternion<T> other) =>
            this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode() =>
            HashCode.Combine(X, Y, Z, W);

        /// <summary>Formats the Quaternion as a string.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() =>
            $"<{Axis.X}, {Axis.Y}, {Axis.Z}, {W}>";

        /// <summary>Returns a span over the Quaternion components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 4);

        /// <summary>Returns a boolean indicating whether the two given Quaternions are equal.</summary>
        /// <param name="left">The first Quaternion to compare.</param>
        /// <param name="right">The second Quaternion to compare.</param>
        /// <returns><c>true</c> if the Quaternions are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Quaternion<T> left, Quaternion<T> right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;

        /// <summary>Returns a boolean indicating whether the two given Quaternions are not equal.</summary>
        /// <param name="left">The first Quaternion to compare.</param>
        /// <param name="right">The second Quaternion to compare.</param>
        /// <returns><c>true</c> if the Quaternions are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Quaternion<T> left, Quaternion<T> right) =>
            left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;

        /// <summary>Converts a <see cref="System.Numerics.Quaternion"/> to a <see cref="Quaternion{T}"/>.</summary>
        public static explicit operator Quaternion<T>(System.Numerics.Quaternion from) =>
            new(T.CreateTruncating(from.X), T.CreateTruncating(from.Y), T.CreateTruncating(from.Z), T.CreateTruncating(from.W));

        /// <summary>Converts a <see cref="System.Numerics.Quaternion"/> to a <see cref="Quaternion{T}"/>.</summary>
        public static explicit operator checked Quaternion<T>(System.Numerics.Quaternion from) =>
            new(T.CreateChecked(from.X), T.CreateChecked(from.Y), T.CreateChecked(from.Z), T.CreateChecked(from.W));

        /// <summary>Converts a <see cref="Quaternion{T}"/> to <see cref="System.Numerics.Quaternion"/>.</summary>
        public static explicit operator System.Numerics.Quaternion(Quaternion<T> from) =>
            new(float.CreateTruncating(from.X), float.CreateTruncating(from.Y), float.CreateTruncating(from.Z), float.CreateTruncating(from.W));

        /// <summary>Converts a <see cref="Quaternion{T}"/> to <see cref="System.Numerics.Quaternion"/>.</summary>
        public static explicit operator checked System.Numerics.Quaternion(Quaternion<T> from) =>
            new(float.CreateChecked(from.X), float.CreateChecked(from.Y), float.CreateChecked(from.Z), float.CreateChecked(from.W));

        /// <summary>Adds two Quaternions element-by-element.</summary>
        /// <param name="left">The first source Quaternion.</param>
        /// <param name="right">The second source Quaternion.</param>
        /// <returns>The result of adding the Quaternions.</returns>
        public static Quaternion<T> operator +(Quaternion<T> left, Quaternion<T> right)
        {
            Quaternion<T> ans = default;

            ans.X = left.X + right.X;
            ans.Y = left.Y + right.Y;
            ans.Z = left.Z + right.Z;
            ans.W = left.W + right.W;

            return ans;
        }

        /// <summary>Subtracts one Quaternion from another.</summary>
        /// <param name="left">The first source Quaternion.</param>
        /// <param name="right">The second Quaternion, to be subtracted from the first.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Quaternion<T> operator -(Quaternion<T> left, Quaternion<T> right)
        {
            Quaternion<T> ans = default;

            ans.X = left.X - right.X;
            ans.Y = left.Y - right.Y;
            ans.Z = left.Z - right.Z;
            ans.W = left.W - right.W;

            return ans;
        }

        /// <summary>Multiplies two Quaternions together.</summary>
        /// <param name="left">The Quaternion on the left side of the multiplication.</param>
        /// <param name="right">The Quaternion on the right side of the multiplication.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> left, Quaternion<T> right)
        {
            Quaternion<T> ans = default;

            T q1x = left.X;
            T q1y = left.Y;
            T q1z = left.Z;
            T q1w = left.W;

            T q2x = right.X;
            T q2y = right.Y;
            T q2z = right.Z;
            T q2w = right.W;

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
        /// <param name="left">The source Quaternion.</param>
        /// <param name="right">The divisor.</param>
        /// <returns>The result of the division.</returns>
        public static Quaternion<T> operator /(Quaternion<T> left, Quaternion<T> right)
        {
            Quaternion<T> ans = default;

            T q1x = left.X;
            T q1y = left.Y;
            T q1z = left.Z;
            T q1w = left.W;

            //-------------------------------------
            // Inverse part.
            var invNorm = T.One / right.LengthSquared;

            var q2x = -(right.X * invNorm);
            var q2y = -(right.Y * invNorm);
            var q2z = -(right.Z * invNorm);
            var q2w = right.W * invNorm;

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
        /// <param name="left">The source Quaternion.</param>
        /// <param name="right">The scalar value.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Quaternion<T> operator *(Quaternion<T> left, T right)
        {
            Quaternion<T> ans = default;

            ans.X = left.X * right;
            ans.Y = left.Y * right;
            ans.Z = left.Z * right;
            ans.W = left.W * right;

            return ans;
        }

        /// <summary>
        /// Returns this quaternion casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted quaternion</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Quaternion<TOther> As<TOther>()
            where TOther : INumber<TOther>, IRootFunctions<TOther>, ITrigonometricFunctions<TOther>
        {
            return new(TOther.CreateTruncating(X), TOther.CreateTruncating(Y), TOther.CreateTruncating(Z), TOther.CreateTruncating(W));
        }
    }
}
