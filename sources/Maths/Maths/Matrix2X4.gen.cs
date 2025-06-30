namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    public partial struct Matrix2X4<T> :
        IEquatable<Matrix2X4<T>>
        where T : INumberBase<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector4D<T> Row2;

        /// <summary>
        /// Constructs a <see cref="Matrix2X4{T}"/> from the given rows.
        /// </summary>
        public Matrix2X4(Vector4D<T> row1, Vector4D<T> row2) => (Row1, Row2) = (row1, row2);

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

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix2X4<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix2X4<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2);

        /// <summary>Computes the transpose of the matrix.</summary>
        public Matrix4X2<T> Transpose() =>
            new(new(M11, M21),
                new(M12, M22),
                new(M13, M23),
                new(M14, M24));

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix2X4<T> left, Matrix2X4<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix2X4<T> left, Matrix2X4<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix2X4<T> operator +(Matrix2X4<T> left, Matrix2X4<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix2X4<T> operator -(Matrix2X4<T> left, Matrix2X4<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix2X4<T> operator -(Matrix2X4<T> value) =>
            new(-value.Row1,
                -value.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X4<T> operator *(Matrix2X2<T> left, Matrix2X4<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X2<T> operator *(Matrix2X4<T> left, Matrix4X2<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3 + left.M14 * right.Row4,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3 + left.M24 * right.Row4);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X4<T> operator *(Matrix3X2<T> left, Matrix2X4<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2,
                left.M31 * right.Row1 + left.M32 * right.Row2);
    }

    public static partial class Matrix2X4
    {
        public static Matrix2X4<T> Lerp<T>(Matrix2X4<T> value1, Matrix2X4<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(new(T.Lerp(value1.M11, value2.M11, amount), T.Lerp(value1.M12, value2.M12, amount), T.Lerp(value1.M13, value2.M13, amount), T.Lerp(value1.M14, value2.M14, amount)),
                new(T.Lerp(value1.M21, value2.M21, amount), T.Lerp(value1.M22, value2.M22, amount), T.Lerp(value1.M23, value2.M23, amount), T.Lerp(value1.M24, value2.M24, amount)));
    }
}
