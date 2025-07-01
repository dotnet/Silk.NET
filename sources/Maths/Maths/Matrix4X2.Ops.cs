// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X2{T}"/>
    /// </summary>
    public static partial class Matrix4X2
    {
        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X2<T> Add<T>(Matrix4X2<T> value1, Matrix4X2<T> value2)
            where T : INumberBase<T>
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X2<T> Multiply<T>(Matrix4X2<T> value1, Matrix2X2<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X3<T> Multiply<T>(Matrix4X2<T> value1, Matrix2X3<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X4<T> Multiply<T>(Matrix4X2<T> value1, Matrix2X4<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X2<T> Multiply<T>(Matrix2X4<T> value1, Matrix4X2<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Multiply<T>(Matrix3X4<T> value1, Matrix4X2<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(Vector4D<T> value1, Matrix4X2<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X2<T> Multiply<T>(Matrix4X4<T> value1, Matrix4X2<T> value2)
            where T : INumberBase<T>
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X2<T> Negate<T>(Matrix4X2<T> value)
            where T : INumberBase<T>
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X2<T> Subtract<T>(Matrix4X2<T> value1, Matrix4X2<T> value2)
            where T : INumberBase<T>
            => value1 - value2;

        /*[MethodImpl((MethodImplOptions)768)]
        private static Vector128<T> Permute<T>(Vector128<T> value, byte control)
            where T : INumberBase<T>
        {
            if (Avx.IsSupported)
            {
                return Avx.Permute(value, control);
            }
            else if (Sse.IsSupported)
            {
                return Sse.Shuffle(value, value, control);
            }
            else
            {
                // Redundant test so we won't prejit remainder of this method on platforms without AdvSimd.
                throw new PlatformNotSupportedException();
            }
        }*/
    }
}
