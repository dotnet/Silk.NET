// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Represents a four-dimensional vector used to encode 3D rotations.
    /// </summary>
    internal struct Quaternion<T> :
        IEquatable<Quaternion<T>>
        where T : IBinaryFloatingPointIeee754<T>
    {
        /// <summary>Specifies the X-value of the vector component of the Quaternion.</summary>
        public T X;

        /// <summary>Specifies the Y-value of the vector component of the Quaternion.</summary>
        public T Y;

        /// <summary>Specifies the Z-value of the vector component of the Quaternion.</summary>
        public T Z;

        /// <summary>Specifies the W-value of the scalar component of the Quaternion.</summary>
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

        // TODO: Vector4F/Vector3F constructors

        /// <summary>Returns a Quaternion representing no rotation.</summary>
        public static Quaternion<T> Identity => new Quaternion<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Quaternion instance.</summary>
        public override bool Equals(object? obj) =>
            obj is Quaternion<T> other && Equals(other);

        /// <summary>Returns a boolean indicating whether the given Quaternion is equal to this Quaternion instance.</summary>
        public bool Equals(Quaternion<T> other) =>
            this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        public override int GetHashCode() =>
            HashCode.Combine(X, Y, Z, W);


        // Equality Operators
        public static bool operator ==(Quaternion<T> left, Quaternion<T> right) =>
            left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;

        public static bool operator !=(Quaternion<T> left, Quaternion<T> right) =>
            !(left == right);
    }
}
