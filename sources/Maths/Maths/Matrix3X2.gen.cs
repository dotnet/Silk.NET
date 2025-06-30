namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    public partial struct Matrix3X2<T> :
        IEquatable<Matrix3X2<T>>
        where T : INumberBase<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector2D<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector2D<T> Row2;

        /// <summary>The 3rd row of the matrix represented as a vector.</summary>
        public Vector2D<T> Row3;

        /// <summary>
        /// Constructs a <see cref="Matrix3X2{T}"/> from the given rows.
        /// </summary>
        public Matrix3X2(Vector2D<T> row1, Vector2D<T> row2, Vector2D<T> row3) => (Row1, Row2, Row3) = (row1, row2, row3);

        [UnscopedRef]
        public ref Vector2D<T> this[int row]
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

        /// <summary>Gets the element in the 3rd row and 1st column of the matrix.</summary>
        [UnscopedRef]
        public ref T M31 => ref Row3.X;

        /// <summary>Gets the element in the 3rd row and 2nd column of the matrix.</summary>
        [UnscopedRef]
        public ref T M32 => ref Row3.Y;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix3X2<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix3X2<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3);

        /// <summary>Computes the transpose of the matrix.</summary>
        public Matrix2X3<T> Transpose() =>
            new(new(M11, M21, M31),
                new(M12, M22, M32));

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix3X2<T> left, Matrix3X2<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2 &&
            left.Row3 == right.Row3;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix3X2<T> left, Matrix3X2<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix3X2<T> operator +(Matrix3X2<T> left, Matrix3X2<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2,
                left.Row3 + right.Row3);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix3X2<T> operator -(Matrix3X2<T> left, Matrix3X2<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2,
                left.Row3 - right.Row3);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix3X2<T> operator -(Matrix3X2<T> value) =>
            new(-value.Row1,
                -value.Row2,
                -value.Row3);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X2<T> operator *(Matrix3X2<T> left, Matrix2X2<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2,
                left.M31 * right.Row1 + left.M32 * right.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X3<T> operator *(Matrix3X2<T> left, Matrix2X3<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2,
                left.M31 * right.Row1 + left.M32 * right.Row2);
    }

    public static partial class Matrix3X2
    {
        public static Matrix3X2<T> Lerp<T>(Matrix3X2<T> value1, Matrix3X2<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(new(T.Lerp(value1.M11, value2.M11, amount), T.Lerp(value1.M12, value2.M12, amount)),
                new(T.Lerp(value1.M21, value2.M21, amount), T.Lerp(value1.M22, value2.M22, amount)),
                new(T.Lerp(value1.M31, value2.M31, amount), T.Lerp(value1.M32, value2.M32, amount)));
    }
}
