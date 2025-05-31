namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Matrix4x2I<T> : IEquatable<Matrix4x2I<T>> where T : IBinaryInteger<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector2I<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector2I<T> Row2;

        /// <summary>The 3rd row of the matrix represented as a vector.</summary>
        public Vector2I<T> Row3;

        /// <summary>The 4th row of the matrix represented as a vector.</summary>
        public Vector2I<T> Row4;

        /// <summary>
        /// Constructs a <see cref="Matrix4x2I{T}"/> from the given rows.
        /// </summary>
        public Matrix4x2I(Vector2I<T> row1, Vector2I<T> row2, Vector2I<T> row3, Vector2I<T> row4) => (Row1, Row2, Row3, Row4) = (row1, row2, row3, row4);

        [UnscopedRef]
        public ref Vector2I<T> this[int row]
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
                }

                throw new ArgumentOutOfRangeException(nameof(row));
            }
        }

        [UnscopedRef]
        public ref Vector2I<T> this[int row, int column] => ref this[row][column];

        /// <summary>Gets the element in the 1st row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M11 => ref Row1.X;

        /// <summary>Gets the element in the 1st row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M12 => ref Row1.Y;

        /// <summary>Gets the element in the 2nd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M21 => ref Row2.X;

        /// <summary>Gets the element in the 2nd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M22 => ref Row2.Y;

        /// <summary>Gets the element in the 3rd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M31 => ref Row3.X;

        /// <summary>Gets the element in the 3rd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M32 => ref Row3.Y;

        /// <summary>Gets the element in the 4th row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M41 => ref Row4.X;

        /// <summary>Gets the element in the 4th row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M42 => ref Row4.Y;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix4x2I<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix4x2I<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4);

        /// <summary>Computes the transpose of the matrix.</summary>
        public Matrix2x4I<T> Transpose() =>
            new(new(M11, M21, M31, M41),
                new(M12, M22, M32, M42))

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix4x2I<T> left, Matrix4x2I<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2 &&
            left.Row3 == right.Row3 &&
            left.Row4 == right.Row4;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix4x2I<T> left, Matrix4x2I<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix4x2I<T> operator +(Matrix4x2I<T> left, Matrix4x2I<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2,
                left.Row3 + right.Row3,
                left.Row4 + right.Row4);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix4x2I<T> operator -(Matrix4x2I<T> left, Matrix4x2I<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2,
                left.Row3 - right.Row3,
                left.Row4 - right.Row4);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix4x2I<T> operator -(Matrix4x2I<T> value) =>
            new(-value.Row1,
                -value.Row2,
                -value.Row3,
                -value.Row4);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix4x2I<T> operator *(Matrix4x2I<T> left, Matrix2x2I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2,
                left.M31 * right.Row1 + left.M32 * right.Row2,
                left.M41 * right.Row1 + left.M42 * right.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix4x3I<T> operator *(Matrix4x2I<T> left, Matrix2x3I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2,
                left.M31 * right.Row1 + left.M32 * right.Row2,
                left.M41 * right.Row1 + left.M42 * right.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix4x4I<T> operator *(Matrix4x2I<T> left, Matrix2x4I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2,
                left.M31 * right.Row1 + left.M32 * right.Row2,
                left.M41 * right.Row1 + left.M42 * right.Row2);
    }
}
