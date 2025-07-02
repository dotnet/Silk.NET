// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix5X4<T>
    {
        private static readonly Matrix5X4<T> _identity = new
        (
            T.One, T.Zero, T.Zero, T.Zero,
            T.Zero, T.One, T.Zero, T.Zero,
            T.Zero, T.Zero, T.One, T.Zero,
            T.Zero, T.Zero, T.Zero, T.One,
            T.Zero, T.Zero, T.Zero, T.Zero
        );

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix5X4(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero, T.Zero);
            Row5 = new(value.M31, value.M32, T.Zero, T.Zero);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix4X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X4{T}"/>.</param>
        public Matrix5X4(Matrix4X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = new(value.M31, value.M32, value.M33, value.M34);
            Row4 = new(value.M41, value.M42, value.M43, value.M44);
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix5X4(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, T.Zero);
            Row2 = new(value.M21, value.M22, value.M23, T.Zero);
            Row3 = new(value.M31, value.M32, value.M33, T.Zero);
            Row4 = new(value.M41, value.M42, value.M43, T.One);
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix5X4(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = new(value.M31, value.M32, value.M33, value.M34);
            Row4 = default;
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix5X4(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, T.Zero);
            Row2 = new(value.M21, value.M22, value.M23, T.Zero);
            Row5 = new(value.M31, value.M32, value.M33, T.Zero);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix5X4(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix5X4(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero, T.Zero);
            Row3 = new(value.M31, value.M32, T.One, T.Zero);
            Row4 = new(value.M41, value.M42, T.Zero, T.One);
            Row5 = default;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix5X4<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector4D<T> operator *(Vector4D<T> value1, Matrix5X4<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3 +
                   value1.W * value2.Row4 + value2.Row5;
        }
    }
}
