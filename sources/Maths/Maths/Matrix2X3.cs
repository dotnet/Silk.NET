// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 2x3 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix2X3<T>
    {
        private static readonly Matrix2X3<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero
        );

        /// <summary>Constructs a <see cref="Matrix2X3{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix2X3(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero);
        }

        /// <summary>Constructs a <see cref="Matrix2X3{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix2X3(Matrix4X3<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, value.M13);
            Row2 = new Vector3D<T>(value.M21, value.M22, value.M23);
        }

        /// <summary>Constructs a <see cref="Matrix2X3{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix2X3(Matrix3X4<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, value.M13);
            Row2 = new Vector3D<T>(value.M21, value.M22, value.M23);
        }

        /// <summary>Constructs a <see cref="Matrix2X3{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix2X3(Matrix2X4<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, value.M13);
            Row2 = new Vector3D<T>(value.M21, value.M22, value.M23);
        }

        /// <summary>Constructs a <see cref="Matrix2X3{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix2X3(Matrix4X2<T> value)
        {
            Row1 = new Vector3D<T>(value.M11, value.M12, T.Zero);
            Row2 = new Vector3D<T>(value.M21, value.M22, T.Zero);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2X3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;
    }
}
