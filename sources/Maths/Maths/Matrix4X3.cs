// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x3 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix4X3<T>
        : IEquatable<Matrix4X3<T>>
        where T : INumberBase<T>
    {
        private static readonly Matrix4X3<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix4X3(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero);
            Row3 = Vector3D<T>.UnitZ;
            Row4 = new(value.M31, value.M32, T.Zero);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix4X3(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
            Row4 = new(value.M41, value.M42, value.M43);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix4X3(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
            Row4 = default;
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix4X3(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = Vector3D<T>.UnitZ;
            Row4 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix4X3(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = Vector3D<T>.UnitZ;
            Row4 = default;
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix4X3(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero);
            Row3 = new(value.M31, value.M32, T.Zero);
            Row4 = new(value.M41, value.M42, Scalar<T>.One);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix4X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X4{T}"/>.</param>
        public Matrix4X3(Matrix4X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
            Row4 = new(value.M41, value.M42, value.M43);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4X3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;
    }
}
