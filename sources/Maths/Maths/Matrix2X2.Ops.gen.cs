// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Numerics;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Methods for working with <see cref="Matrix2X2{T}"/>.
    /// </summary>
    public static partial class Matrix2X2
    {
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix2X2<T> Lerp<T>(Matrix2X2<T> value1, Matrix2X2<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(Vector2D.Lerp(value1.Row1, value2.Row1, amount),
                Vector2D.Lerp(value1.Row2, value2.Row2, amount));

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix2X2<T> Add<T>(Matrix2X2<T> left, Matrix2X2<T> right)
            where T : INumberBase<T> =>
            left + right;

        /// <summary>Returns a negated copy of the specified matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix2X2<T> Negate<T>(Matrix2X2<T> value)
            where T : INumberBase<T> =>
            -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix2X2<T> Subtract<T>(Matrix2X2<T> left, Matrix2X2<T> right)
            where T : INumberBase<T> =>
            left - right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The source matrix.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X2<T> Multiply<T>(Matrix2X2<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source matrix.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X2<T> Multiply<T>(T left, Matrix2X2<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="rowVector">The first source matrix, expressed as a row vector.</param>
        /// <param name="matrix">The second source matrix.</param>
        /// <returns>The result of the multiplication as a column vector.</returns>
        public static Vector2D<T> Multiply<T>(Vector2D<T> rowVector, Matrix2X2<T> matrix)
            where T : INumberBase<T> =>
            rowVector * matrix;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="matrix">The first source matrix.</param>
        /// <param name="columnVector">The second source matrix, expressed as a column vector.</param>
        /// <returns>The result of the multiplication as a row vector.</returns>
        public static Vector2D<T> Multiply<T>(Matrix2X2<T> matrix, Vector2D<T> columnVector)
            where T : INumberBase<T> =>
            matrix * columnVector;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X2<T> Multiply<T>(Matrix2X2<T> left, Matrix2X2<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X3<T> Multiply<T>(Matrix2X2<T> left, Matrix2X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X4<T> Multiply<T>(Matrix2X2<T> left, Matrix2X4<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X2<T> Multiply<T>(Matrix3X2<T> left, Matrix2X2<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix4X2<T> Multiply<T>(Matrix4X2<T> left, Matrix2X2<T> right)
            where T : INumberBase<T> =>
            left * right;
    }
}
