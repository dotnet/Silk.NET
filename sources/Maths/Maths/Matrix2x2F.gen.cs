namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Matrix2x2F<T> : IEquatable<Matrix2x2F<T>> where T : IFloatingPointIeee754<T>
    {
        /// <summary>The multiplicative identity matrix of size 2x2.</summary>
        public static readonly Matrix2x2F<T> Identity = new(
            new(T.MultiplicativeIdentity, T.Zero),
            new(T.Zero, T.MultiplicativeIdentity));

        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector2F<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector2F<T> Row2;

        /// <summary>
        /// Constructs a <see cref="Matrix2x2F{T}"/> from the given rows.
        /// </summary>
        public Matrix2x2F(Vector2F<T> row1, Vector2F<T> row2) => (Row1, Row2) = (row1, row2);

        [UnscopedRef]
        public ref Vector2F<T> this[int row]
        {
            get
            {
                switch (row)
                {
                    case 0:
                        return ref Row1;
                    case 1:
                        return ref Row2;
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

        /// <summary>Gets the element in the 2nd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M21 => ref Row2.X;

        /// <summary>Gets the element in the 2nd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M22 => ref Row2.Y;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix2x2F<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix2x2F<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2);

        /// <summary>Computes the transpose of the matrix.</summary>
        public Matrix2x2F<T> Transpose() =>
            new(new(M11, M21),
                new(M12, M22));

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix2x2F<T> left, Matrix2x2F<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix2x2F<T> left, Matrix2x2F<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix2x2F<T> operator +(Matrix2x2F<T> left, Matrix2x2F<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix2x2F<T> operator -(Matrix2x2F<T> left, Matrix2x2F<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix2x2F<T> operator -(Matrix2x2F<T> value) =>
            new(-value.Row1,
                -value.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2x2F<T> operator *(Matrix2x2F<T> left, Matrix2x2F<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2);
    }

    static partial class Matrix2x2F
    {
        public static Matrix2x2F<T> Lerp<T>(Matrix2x2F<T> value1, Matrix2x2F<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(new(T.Lerp(value1.M11, value2.M11, amount), T.Lerp(value1.M12, value2.M12, amount)),
                new(T.Lerp(value1.M21, value2.M21, amount), T.Lerp(value1.M22, value2.M22, amount)));
    }
}
