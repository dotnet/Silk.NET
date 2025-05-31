namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Matrix5x4I<T> : IEquatable<Matrix5x4I<T>> where T : IBinaryInteger<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector4I<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector4I<T> Row2;

        /// <summary>The 3rd row of the matrix represented as a vector.</summary>
        public Vector4I<T> Row3;

        /// <summary>The 4th row of the matrix represented as a vector.</summary>
        public Vector4I<T> Row4;

        /// <summary>The 5th row of the matrix represented as a vector.</summary>
        public Vector4I<T> Row5;

        /// <summary>
        /// Constructs a <see cref="Matrix5x4I{T}"/> from the given rows.
        /// </summary>
        public Matrix5x4I(Vector4I<T> row1, Vector4I<T> row2, Vector4I<T> row3, Vector4I<T> row4, Vector4I<T> row5) => (Row1, Row2, Row3, Row4, Row5) = (row1, row2, row3, row4, row5);

        [UnscopedRef]
        public ref Vector4I<T> this[int row]
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

        /// <summary>Gets the element in the 1st row and 1st column of the matrix.</summary>
        public T M11 => Row1.X;

        /// <summary>Gets the element in the 1st row and 2nd column of the matrix.</summary>
        public T M12 => Row1.Y;

        /// <summary>Gets the element in the 1st row and 3rd column of the matrix.</summary>
        public T M13 => Row1.Z;

        /// <summary>Gets the element in the 1st row and 4th column of the matrix.</summary>
        public T M14 => Row1.W;

        /// <summary>Gets the element in the 2nd row and 1st column of the matrix.</summary>
        public T M21 => Row2.X;

        /// <summary>Gets the element in the 2nd row and 2nd column of the matrix.</summary>
        public T M22 => Row2.Y;

        /// <summary>Gets the element in the 2nd row and 3rd column of the matrix.</summary>
        public T M23 => Row2.Z;

        /// <summary>Gets the element in the 2nd row and 4th column of the matrix.</summary>
        public T M24 => Row2.W;

        /// <summary>Gets the element in the 3rd row and 1st column of the matrix.</summary>
        public T M31 => Row3.X;

        /// <summary>Gets the element in the 3rd row and 2nd column of the matrix.</summary>
        public T M32 => Row3.Y;

        /// <summary>Gets the element in the 3rd row and 3rd column of the matrix.</summary>
        public T M33 => Row3.Z;

        /// <summary>Gets the element in the 3rd row and 4th column of the matrix.</summary>
        public T M34 => Row3.W;

        /// <summary>Gets the element in the 4th row and 1st column of the matrix.</summary>
        public T M41 => Row4.X;

        /// <summary>Gets the element in the 4th row and 2nd column of the matrix.</summary>
        public T M42 => Row4.Y;

        /// <summary>Gets the element in the 4th row and 3rd column of the matrix.</summary>
        public T M43 => Row4.Z;

        /// <summary>Gets the element in the 4th row and 4th column of the matrix.</summary>
        public T M44 => Row4.W;

        /// <summary>Gets the element in the 5th row and 1st column of the matrix.</summary>
        public T M51 => Row5.X;

        /// <summary>Gets the element in the 5th row and 2nd column of the matrix.</summary>
        public T M52 => Row5.Y;

        /// <summary>Gets the element in the 5th row and 3rd column of the matrix.</summary>
        public T M53 => Row5.Z;

        /// <summary>Gets the element in the 5th row and 4th column of the matrix.</summary>
        public T M54 => Row5.W;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix5x4I<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix5x4I<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4, Row5);

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix5x4I<T> left, Matrix5x4I<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2 &&
            left.Row3 == right.Row3 &&
            left.Row4 == right.Row4 &&
            left.Row5 == right.Row5;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix5x4I<T> left, Matrix5x4I<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix5x4I<T> operator +(Matrix5x4I<T> left, Matrix5x4I<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2,
                left.Row3 + right.Row3,
                left.Row4 + right.Row4,
                left.Row5 + right.Row5);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix5x4I<T> operator -(Matrix5x4I<T> left, Matrix5x4I<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2,
                left.Row3 - right.Row3,
                left.Row4 - right.Row4,
                left.Row5 - right.Row5);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix5x4I<T> operator *(Matrix5x4I<T> left, Matrix4x4I<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3 + left.M14 * right.Row4,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3 + left.M24 * right.Row4,
                left.M31 * right.Row1 + left.M32 * right.Row2 + left.M33 * right.Row3 + left.M34 * right.Row4,
                left.M41 * right.Row1 + left.M42 * right.Row2 + left.M43 * right.Row3 + left.M44 * right.Row4,
                left.M51 * right.Row1 + left.M52 * right.Row2 + left.M53 * right.Row3 + left.M54 * right.Row4);
    }
}