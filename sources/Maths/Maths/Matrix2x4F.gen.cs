namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Matrix2x4F<T> : IEquatable<Matrix2x4F<T>> where T : IFloatingPointIeee754<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        public Vector4F<T> Row1;
        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        public Vector4F<T> Row2;
        public Matrix2x4F(Vector4F<T> row1, Vector4F<T> row2) => (Row1, Row2) = (row1, row2);
        [UnscopedRef]
        public ref Vector4F<T> this[int row]
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
        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix2x4F<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Matrix2x4F<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2);
        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name = "left">The first matrix to compare.</param>
        /// <param name = "right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix2x4F<T> left, Matrix2x4F<T> right) => left.Row1 == right.Row1 && left.Row2 == right.Row2;
        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name = "left">The first matrix to compare.</param>
        /// <param name = "right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix2x4F<T> left, Matrix2x4F<T> right) => !(left == right);
        /// <summary>Adds two matrices together.</summary>
        /// <param name = "left">The first source matrix.</param>
        /// <param name = "right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix2x4F<T> operator +(Matrix2x4F<T> left, Matrix2x4F<T> right) => new(left.Row1 + right.Row1, left.Row2 + right.Row2);
        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name = "left">The first source matrix.</param>
        /// <param name = "right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix2x4F<T> operator -(Matrix2x4F<T> left, Matrix2x4F<T> right) => new(left.Row1 - right.Row1, left.Row2 - right.Row2);
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name = "left">The first source matrix.</param>
        /// <param name = "right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2x4F<T> operator *(Matrix2x2F<T> left, Matrix2x4F<T> right) => new(left.M11 * right.Row1 + left.M12 * right.Row2, left.M21 * right.Row1 + left.M22 * right.Row2);
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name = "left">The first source matrix.</param>
        /// <param name = "right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2x2F<T> operator *(Matrix2x4F<T> left, Matrix4x2F<T> right) => new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3 + left.M14 * right.Row4, left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3 + left.M24 * right.Row4);
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name = "left">The first source matrix.</param>
        /// <param name = "right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3x4F<T> operator *(Matrix3x2F<T> left, Matrix2x4F<T> right) => new(left.M11 * right.Row1 + left.M12 * right.Row2, left.M21 * right.Row1 + left.M22 * right.Row2, left.M31 * right.Row1 + left.M32 * right.Row2);
    }
}