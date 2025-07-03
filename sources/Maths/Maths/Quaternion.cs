// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
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
        where T : ITrigonometricFunctions<T>
    {
        /// <summary>Specifies the X-value of the vector component of the Quaternion.</summary>
        [DataMember]
        public T X;

        /// <summary>Specifies the Y-value of the vector component of the Quaternion.</summary>
        [DataMember]
        public T Y;

        /// <summary>Specifies the Z-value of the vector component of the Quaternion.</summary>
        [DataMember]
        public T Z;

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

        // TODO: Vector4F/Vector3F constructors

        /// <summary>Returns a <see cref="Quaternion{T}"/> representing no rotation.</summary>
        public static Quaternion<T> Identity { get; } = new Quaternion<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

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
    }
}
