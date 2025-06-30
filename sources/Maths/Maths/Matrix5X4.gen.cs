namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    public partial struct Matrix5X4<T> :
        IEquatable<Matrix5X4<T>>
        where T : INumberBase<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row2;

        /// <summary>The 3rd row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row3;

        /// <summary>The 4th row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row4;

        /// <summary>The 5th row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row5;

        /// <summary>
        /// Constructs a <see cref="Matrix5X4{T}"/> from the given rows.
        /// </summary>
        public Matrix5X4(Vector4D<T> row1, Vector4D<T> row2, Vector4D<T> row3, Vector4D<T> row4, Vector4D<T> row5) => (Row1, Row2, Row3, Row4, Row5) = (row1, row2, row3, row4, row5);

        [UnscopedRef]
        public ref Vector4D<T> this[int row]
        {
            get
            {
                switch (row)
                {
                    case 0:
                        return ref Row1;
                    case 1:
                        return ref Row2;
                    case 2:
                        return ref Row3;
                    case 3:
                        return ref Row4;
                    case 4:
                        return ref Row5;
                }

                throw new ArgumentOutOfRangeException(nameof(row));
            }
        }

        [UnscopedRef]
        public ref T this[int row, int column] => ref this[row][column];

        /// <summary>Gets the element in the 1st row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M11 => ref Row1.X;

        /// <summary>Gets the element in the 1st row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M12 => ref Row1.Y;

        /// <summary>Gets the element in the 1st row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M13 => ref Row1.Z;

        /// <summary>Gets the element in the 1st row and 4th column of the matrix.</summary>
        [UnscopedRef]
        public ref T M14 => ref Row1.W;

        /// <summary>Gets the element in the 2nd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M21 => ref Row2.X;

        /// <summary>Gets the element in the 2nd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M22 => ref Row2.Y;

        /// <summary>Gets the element in the 2nd row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M23 => ref Row2.Z;

        /// <summary>Gets the element in the 2nd row and 4th column of the matrix.</summary>
        [UnscopedRef]
        public ref T M24 => ref Row2.W;

        /// <summary>Gets the element in the 3rd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M31 => ref Row3.X;

        /// <summary>Gets the element in the 3rd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M32 => ref Row3.Y;

        /// <summary>Gets the element in the 3rd row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M33 => ref Row3.Z;

        /// <summary>Gets the element in the 3rd row and 4th column of the matrix.</summary>
        [UnscopedRef]
        public ref T M34 => ref Row3.W;

        /// <summary>Gets the element in the 4th row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M41 => ref Row4.X;

        /// <summary>Gets the element in the 4th row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M42 => ref Row4.Y;

        /// <summary>Gets the element in the 4th row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M43 => ref Row4.Z;

        /// <summary>Gets the element in the 4th row and 4th column of the matrix.</summary>
        [UnscopedRef]
        public ref T M44 => ref Row4.W;

        /// <summary>Gets the element in the 5th row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M51 => ref Row5.X;

        /// <summary>Gets the element in the 5th row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M52 => ref Row5.Y;

        /// <summary>Gets the element in the 5th row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M53 => ref Row5.Z;

        /// <summary>Gets the element in the 5th row and 4th column of the matrix.</summary>
        [UnscopedRef]
        public ref T M54 => ref Row5.W;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix5X4<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix5X4<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4, Row5);

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix5X4<T> left, Matrix5X4<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2 &&
            left.Row3 == right.Row3 &&
            left.Row4 == right.Row4 &&
            left.Row5 == right.Row5;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix5X4<T> left, Matrix5X4<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix5X4<T> operator +(Matrix5X4<T> left, Matrix5X4<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2,
                left.Row3 + right.Row3,
                left.Row4 + right.Row4,
                left.Row5 + right.Row5);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix5X4<T> operator -(Matrix5X4<T> left, Matrix5X4<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2,
                left.Row3 - right.Row3,
                left.Row4 - right.Row4,
                left.Row5 - right.Row5);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix5X4<T> operator -(Matrix5X4<T> value) =>
            new(-value.Row1,
                -value.Row2,
                -value.Row3,
                -value.Row4,
                -value.Row5);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix5X4<T> operator *(Matrix5X4<T> left, Matrix4X4<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3 + left.M14 * right.Row4,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3 + left.M24 * right.Row4,
                left.M31 * right.Row1 + left.M32 * right.Row2 + left.M33 * right.Row3 + left.M34 * right.Row4,
                left.M41 * right.Row1 + left.M42 * right.Row2 + left.M43 * right.Row3 + left.M44 * right.Row4,
                left.M51 * right.Row1 + left.M52 * right.Row2 + left.M53 * right.Row3 + left.M54 * right.Row4);
    }

    public static partial class Matrix5X4
    {
        public static Matrix5X4<T> Lerp<T>(Matrix5X4<T> value1, Matrix5X4<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(new(T.Lerp(value1.M11, value2.M11, amount), T.Lerp(value1.M12, value2.M12, amount), T.Lerp(value1.M13, value2.M13, amount), T.Lerp(value1.M14, value2.M14, amount)),
                new(T.Lerp(value1.M21, value2.M21, amount), T.Lerp(value1.M22, value2.M22, amount), T.Lerp(value1.M23, value2.M23, amount), T.Lerp(value1.M24, value2.M24, amount)),
                new(T.Lerp(value1.M31, value2.M31, amount), T.Lerp(value1.M32, value2.M32, amount), T.Lerp(value1.M33, value2.M33, amount), T.Lerp(value1.M34, value2.M34, amount)),
                new(T.Lerp(value1.M41, value2.M41, amount), T.Lerp(value1.M42, value2.M42, amount), T.Lerp(value1.M43, value2.M43, amount), T.Lerp(value1.M44, value2.M44, amount)),
                new(T.Lerp(value1.M51, value2.M51, amount), T.Lerp(value1.M52, value2.M52, amount), T.Lerp(value1.M53, value2.M53, amount), T.Lerp(value1.M54, value2.M54, amount)));
    }
}
