// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix2X4{T}"/>
    /// </summary>
    public static class Matrix2X4
    {
        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X4<T> Add<T>(Matrix2X4<T> value1, Matrix2X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X4<T> Multiply<T>(Matrix2X4<T> value1, Matrix4X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X3<T> Multiply<T>(Matrix2X4<T> value1, Matrix4X3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X2<T> Multiply<T>(Matrix2X4<T> value1, Matrix4X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix4X4<T> Multiply<T>(Matrix4X2<T> value1, Matrix2X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;


        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X4<T> Multiply<T>(Matrix3X2<T> value1, Matrix2X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;


        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X4<T> Multiply<T>(Matrix2X2<T> value1, Matrix2X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector4D<T> Multiply<T>(Vector2D<T> value1, Matrix2X4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix2X4<T> Lerp<T>(Matrix2X4<T> matrix1, Matrix2X4<T> matrix2, T amount)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(Vector4D.Lerp(matrix1.Row1, matrix2.Row1, amount), Vector4D.Lerp(matrix1.Row2, matrix2.Row2, amount));
        }
    }
}