// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 2x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix2X4<T>
    {
        private static readonly Matrix2X4<T> _identity = new
        (
            T.One, T.Zero, T.Zero, T.Zero,
            T.Zero, T.One, T.Zero, T.Zero
        );

        /// <summary>Constructs a <see cref="Matrix2X4{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix2X4(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero, T.Zero);
        }

        /// <summary>Constructs a <see cref="Matrix2X4{T}"/> from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix2X4(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, T.Zero);
            Row2 = new(value.M21, value.M22, value.M23, T.Zero);
        }

        /// <summary>Constructs a <see cref="Matrix2X4{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix2X4(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
        }

        /// <summary>Constructs a <see cref="Matrix2X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix2X4(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, T.Zero);
            Row2 = new(value.M21, value.M22, value.M23, T.Zero);
        }

        /// <summary>Constructs a Matrix2x4 from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix2X4(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero, T.Zero);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2X4<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;
    }
}
