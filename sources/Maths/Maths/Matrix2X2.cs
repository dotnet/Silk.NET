// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 2x2 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix2X2<T>
    {
        /// <summary>Constructs a <see cref="Matrix2X2{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix2X2(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
        }

        /// <summary>Constructs a <see cref="Matrix2X2{T}"/> from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix2X2(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
        }

        /// <summary>Constructs a <see cref="Matrix2X2{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix2X2(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
        }

        /// <summary>Constructs a <see cref="Matrix2X2{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix2X2(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
        }

        /// <summary>Constructs a <see cref="Matrix2X2{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix2X2(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
        }

        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            //   | a b |
            //   | c d | = ad - bc

            T a = Row1.X, b = Row1.Y;
            T d = Row2.X, c = Row1.Y;

            return Scalar.Subtract(Scalar.Multiply(a, d), Scalar.Multiply(b, c));
        }
    }
}
