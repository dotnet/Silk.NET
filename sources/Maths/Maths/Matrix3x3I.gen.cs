namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Matrix3x3I<T> : IEquatable<Matrix3x3I<T>> where T : IBinaryInteger<T>
    {
        /// <summary>The multiplicative identity matrix of size 3x3.</summary>
        public static readonly Matrix3x3I<T> Identity = new(
            new(T.MultiplicativeIdentity, T.Zero, T.Zero),
            new(T.Zero, T.MultiplicativeIdentity, T.Zero),
            new(T.Zero, T.Zero, T.MultiplicativeIdentity));

        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector3I<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector3I<T> Row2;

        /// <summary>The 3rd row of the matrix represented as a vector.</summary>
        public Vector3I<T> Row3;

        /// <summary>
        /// Constructs a <see cref="Matrix3x3I{T}"/> from the given rows.
        /// </summary>
        public Matrix3x3I(Vector3I<T> row1, Vector3I<T> row2, Vector3I<T> row3) => (Row1, Row2, Row3) = (row1, row2, row3);

        [UnscopedRef]
        public ref Vector3I<T> this[int row]
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
                }

                throw new ArgumentOutOfRangeException(nameof(row));
            }
        }

        [UnscopedRef]
        public ref Vector3I<T> this[int row, int column] => ref this[row][column];

        /// <summary>Gets the element in the 1st row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M11 => ref Row1.X;

        /// <summary>Gets the element in the 1st row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M12 => ref Row1.Y;

        /// <summary>Gets the element in the 1st row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M13 => ref Row1.Z;

        /// <summary>Gets the element in the 2nd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M21 => ref Row2.X;

        /// <summary>Gets the element in the 2nd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M22 => ref Row2.Y;

        /// <summary>Gets the element in the 2nd row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M23 => ref Row2.Z;

        /// <summary>Gets the element in the 3rd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M31 => ref Row3.X;

        /// <summary>Gets the element in the 3rd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M32 => ref Row3.Y;

        /// <summary>Gets the element in the 3rd row and 3rd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M33 => ref Row3.Z;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix3x3I<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix3x3I<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3);

        /// <summary>Computes the transpose of the matrix.</summary>
        public Matrix3x3I<T> Transpose() =>
            new(new(M11, M21, M31),
                new(M12, M22, M32),
                new(M13, M23, M33))

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix3x3I<T> left, Matrix3x3I<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2 &&
            left.Row3 == right.Row3;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix3x3I<T> left, Matrix3x3I<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix3x3I<T> operator +(Matrix3x3I<T> left, Matrix3x3I<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2,
                left.Row3 + right.Row3);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix3x3I<T> operator -(Matrix3x3I<T> left, Matrix3x3I<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2,
                left.Row3 - right.Row3);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix3x3I<T> operator -(Matrix3x3I<T> value) =>
            new(-value.Row1,
                -value.Row2,
                -value.Row3);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2x3I<T> operator *(Matrix2x3I<T> left, Matrix3x3I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3x2I<T> operator *(Matrix3x3I<T> left, Matrix3x2I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3,
                left.M31 * right.Row1 + left.M32 * right.Row2 + left.M33 * right.Row3);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3x3I<T> operator *(Matrix3x3I<T> left, Matrix3x3I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3,
                left.M31 * right.Row1 + left.M32 * right.Row2 + left.M33 * right.Row3);
    }
}
