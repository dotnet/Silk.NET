// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4x2{T}"/>
    /// </summary>
    public static class Matrix4x2
    {
        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x2<T> Add<T>(Matrix4x2<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x2<T> Multiply<T>(Matrix4x2<T> value1, Matrix2x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x3<T> Multiply<T>(Matrix4x2<T> value1, Matrix2x3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x4<T> Multiply<T>(Matrix4x2<T> value1, Matrix2x4<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix2x2<T> Multiply<T>(Matrix2x4<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x2<T> Multiply<T>(Matrix3x4<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector2<T> Multiply<T>(Vector4<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x2<T> Multiply<T>(Matrix4x4<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;
        
        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x2<T> Negate<T>(Matrix4x2<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x2<T> Subtract<T>(Matrix4x2<T> value1, Matrix4x2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 - value2;

        /*[MethodImpl((MethodImplOptions)768)]
        private static Vector128<T> Permute<T>(Vector128<T> value, byte control)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
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

        
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix4x2<T> Lerp<T>(Matrix4x2<T> matrix1, Matrix4x2<T> matrix2, T amount)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new
            (
                Vector2.Lerp(matrix1.Row1, matrix2.Row1, amount),
                Vector2.Lerp(matrix1.Row2, matrix2.Row2, amount),
                Vector2.Lerp(matrix1.Row3, matrix2.Row3, amount), 
                Vector2.Lerp(matrix1.Row4, matrix2.Row4, amount)
            );
        }
    }
}
