// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x2 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix4X2<T>
    {
        private static readonly Matrix4X2<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>Constructs a <see cref="Matrix4X2{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix4X2(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = default;
            Row4 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix4X2{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix4X2(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
            Row4 = new(value.M41, value.M42);
        }

        /// <summary>Constructs a <see cref="Matrix4X2{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix4X2(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
            Row4 = default;
        }

        /// <summary>Constructs a <see cref="Matrix4X2{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix4X2(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = default;
            Row4 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix4X2{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix4X2(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = default;
            Row4 = default;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4X2<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;
    }
}
