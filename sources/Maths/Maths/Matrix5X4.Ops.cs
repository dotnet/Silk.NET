// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X4{T}"/>
    /// </summary>
    public static partial class Matrix5X4
    {
        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix5X4<T> Add<T>(Matrix5X4<T> value1, Matrix5X4<T> value2)
            where T : INumberBase<T>
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector4D<T> Multiply<T>(Vector4D<T> value1, Matrix5X4<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix5X4<T> Multiply<T>(Matrix5X4<T> value1, T value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix5X4<T> Negate<T>(Matrix5X4<T> value)
            where T : INumberBase<T>
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix5X4<T> Subtract<T>(Matrix5X4<T> value1, Matrix5X4<T> value2)
            where T : INumberBase<T>
            => value1 - value2;
    }
}
