// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Numerics;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Methods for working with <see cref="Matrix3X3{T}"/>.
    /// </summary>
    public static partial class Matrix3X3
    {
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix3X3<T> Lerp<T>(Matrix3X3<T> value1, Matrix3X3<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(Vector3D.Lerp(value1.Row1, value2.Row1, amount),
                Vector3D.Lerp(value1.Row2, value2.Row2, amount),
                Vector3D.Lerp(value1.Row3, value2.Row3, amount));

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix3X3<T> Add<T>(Matrix3X3<T> left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left + right;

        /// <summary>Returns a negated copy of the specified matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix3X3<T> Negate<T>(Matrix3X3<T> value)
            where T : INumberBase<T> =>
            -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix3X3<T> Subtract<T>(Matrix3X3<T> left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left - right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The source matrix.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix3X3<T> Multiply<T>(Matrix3X3<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source matrix.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix3X3<T> Multiply<T>(T left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="rowVector">The first source matrix, expressed as a row vector.</param>
        /// <param name="matrix">The second source matrix.</param>
        /// <returns>The result of the multiplication as a column vector.</returns>
        public static Vector3D<T> Multiply<T>(Vector3D<T> rowVector, Matrix3X3<T> matrix)
            where T : INumberBase<T> =>
            rowVector * matrix;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="matrix">The first source matrix.</param>
        /// <param name="columnVector">The second source matrix, expressed as a column vector.</param>
        /// <returns>The result of the multiplication as a row vector.</returns>
        public static Vector3D<T> Multiply<T>(Matrix3X3<T> matrix, Vector3D<T> columnVector)
            where T : INumberBase<T> =>
            matrix * columnVector;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X3<T> Multiply<T>(Matrix2X3<T> left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X2<T> Multiply<T>(Matrix3X3<T> left, Matrix3X2<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X3<T> Multiply<T>(Matrix3X3<T> left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X4<T> Multiply<T>(Matrix3X3<T> left, Matrix3X4<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix4X3<T> Multiply<T>(Matrix4X3<T> left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left * right;
    }
}
