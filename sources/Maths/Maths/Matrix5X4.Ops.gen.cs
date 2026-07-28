// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Numerics;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Methods for working with <see cref="Matrix5X4{T}"/>.
    /// </summary>
    public static partial class Matrix5X4
    {
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix5X4<T> Lerp<T>(Matrix5X4<T> value1, Matrix5X4<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(Vector4D.Lerp(value1.Row1, value2.Row1, amount),
                Vector4D.Lerp(value1.Row2, value2.Row2, amount),
                Vector4D.Lerp(value1.Row3, value2.Row3, amount),
                Vector4D.Lerp(value1.Row4, value2.Row4, amount),
                Vector4D.Lerp(value1.Row5, value2.Row5, amount));

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix5X4<T> Add<T>(Matrix5X4<T> left, Matrix5X4<T> right)
            where T : INumberBase<T> =>
            left + right;

        /// <summary>Returns a negated copy of the specified matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix5X4<T> Negate<T>(Matrix5X4<T> value)
            where T : INumberBase<T> =>
            -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix5X4<T> Subtract<T>(Matrix5X4<T> left, Matrix5X4<T> right)
            where T : INumberBase<T> =>
            left - right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The source matrix.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix5X4<T> Multiply<T>(Matrix5X4<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source matrix.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix5X4<T> Multiply<T>(T left, Matrix5X4<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix5X4<T> Multiply<T>(Matrix5X4<T> left, Matrix4X4<T> right)
            where T : INumberBase<T> =>
            left * right;
    }
}
