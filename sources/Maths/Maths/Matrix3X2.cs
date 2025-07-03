// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 3x2 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix3X2<T>
    {
        private static readonly Matrix3X2<T> _identity = new(
            Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix3X2(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix3X2(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix3X2(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix3X2(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = Vector2D<T>.Zero;
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix3X2(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3X2<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Calculates the determinant for this matrix.
        /// The determinant is calculated by expanding the matrix with a third column whose values are (0,0,1).</summary>
        /// <returns>The determinant.</returns>
        public readonly T GetDeterminant()
        {
            // There isn't actually any such thing as a determinant for a non-square matrix,
            // but this 3x2 type is really just an optimization of a 3x3 where we happen to
            // know the rightmost column is always (0, 0, 1). So we expand to 3x3 format:
            //
            //  [ M11, M12, 0 ]
            //  [ M21, M22, 0 ]
            //  [ M31, M32, 1 ]
            //
            // Sum the diagonal products:
            //  (M11 * M22 * 1) + (M12 * 0 * M31) + (0 * M21 * M32)
            //
            // Subtract the opposite diagonal products:
            //  (M31 * M22 * 0) + (M32 * 0 * M11) + (1 * M21 * M12)
            //
            // Collapse out the constants and oh look, this is just a 2x2 determinant!

            return Scalar.Subtract(
                Scalar.Multiply(Row1.X, Row2.Y),
                Scalar.Multiply(Row2.X, Row1.Y));
        }

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into a <see cref="System.Numerics.Matrix3x2"/> one.
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="System.Numerics"/> matrix</returns>
        public static explicit operator System.Numerics.Matrix3x2(Matrix3X2<T> from)
            => new(
                Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M31), Scalar.As<T, float>(from.M32)
            );
    }
}
