namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    public partial struct Matrix2X4<T> :
        IEquatable<Matrix2X4<T>>
        where T : INumberBase<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector4D<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector4D<T> Row2;

        /// <summary>The 1st column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column1 => new(Row1.X, Row2.X);

        /// <summary>The 2nd column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column2 => new(Row1.Y, Row2.Y);

        /// <summary>The 3rd column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column3 => new(Row1.Z, Row2.Z);

        /// <summary>The 4th column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column4 => new(Row1.W, Row2.W);

        /// <summary>
        /// Constructs a <see cref="Matrix2X4{T}"/> from the given rows.
        /// </summary>
        public Matrix2X4(Vector4D<T> row1, Vector4D<T> row2) =>
            (Row1, Row2) = (row1, row2);

        /// <summary>
        /// Constructs a <see cref="Matrix2X4{T}"/> from the given components.
        /// </summary>
        public Matrix2X4(
            T m11, T m12, T m13, T m14,
            T m21, T m22, T m23, T m24)
        {
            Row1 = new(m11, m12, m13, m14);
            Row2 = new(m21, m22, m23, m24);
        }

        /// <summary>
        /// Indexer for the rows of this matrix.
        /// </summary>
        /// <param name="row">The row to select. Zero based.</param>
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

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Indexer for the values in this matrix.
        /// </summary>
        /// <param name="row">The row to select. Zero based.</param>
        /// <param name="column">The column to select. Zero based.</param>
        [UnscopedRef]
        public ref T this[int row, int column] => ref this[row][column];

        /// <summary>Gets the element in the 1st row and 1st column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M11 => ref Row1.X;

        /// <summary>Gets the element in the 1st row and 2nd column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M12 => ref Row1.Y;

        /// <summary>Gets the element in the 1st row and 3rd column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M13 => ref Row1.Z;

        /// <summary>Gets the element in the 1st row and 4th column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M14 => ref Row1.W;

        /// <summary>Gets the element in the 2nd row and 1st column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M21 => ref Row2.X;

        /// <summary>Gets the element in the 2nd row and 2nd column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M22 => ref Row2.Y;

        /// <summary>Gets the element in the 2nd row and 3rd column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M23 => ref Row2.Z;

        /// <summary>Gets the element in the 2nd row and 4th column of the matrix.</summary>
        [DataMember]
        [UnscopedRef]
        public ref T M24 => ref Row2.W;


        /// <inheritdoc/>
        public override string ToString() =>
            string.Format(
                "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} }}",
                Row1.X, Row1.Y, Row1.Z, Row1.W,
                Row2.X, Row2.Y, Row2.Z, Row2.W);

        /// <inheridoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source matrix.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X4<T> operator *(T left, Matrix2X4<T> right) =>
            new(left * right.Row1,
                left * right.Row2);

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The source matrix.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X4<T> operator *(Matrix2X4<T> left, T right) =>
            new(left.Row1 * right,
                left.Row2 * right);

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
        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="Half"/> matrix.</returns>
        public static explicit operator Matrix2X4<Half>(Matrix2X4<T> from) =>
            new(from.Row1.As<Half>(),
                from.Row2.As<Half>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="float"/> matrix.</returns>
        public static explicit operator Matrix2X4<float>(Matrix2X4<T> from) =>
            new(from.Row1.As<float>(),
                from.Row2.As<float>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="double"/> matrix.</returns>
        public static explicit operator Matrix2X4<double>(Matrix2X4<T> from) =>
            new(from.Row1.As<double>(),
                from.Row2.As<double>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="decimal"/> matrix.</returns>
        public static explicit operator Matrix2X4<decimal>(Matrix2X4<T> from) =>
            new(from.Row1.As<decimal>(),
                from.Row2.As<decimal>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="byte"/> matrix.</returns>
        public static explicit operator Matrix2X4<byte>(Matrix2X4<T> from) =>
            new(from.Row1.As<byte>(),
                from.Row2.As<byte>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="short"/> matrix.</returns>
        public static explicit operator Matrix2X4<short>(Matrix2X4<T> from) =>
            new(from.Row1.As<short>(),
                from.Row2.As<short>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="int"/> matrix.</returns>
        public static explicit operator Matrix2X4<int>(Matrix2X4<T> from) =>
            new(from.Row1.As<int>(),
                from.Row2.As<int>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="long"/> matrix.</returns>
        public static explicit operator Matrix2X4<long>(Matrix2X4<T> from) =>
            new(from.Row1.As<long>(),
                from.Row2.As<long>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="sbyte"/> matrix.</returns>
        public static explicit operator Matrix2X4<sbyte>(Matrix2X4<T> from) =>
            new(from.Row1.As<sbyte>(),
                from.Row2.As<sbyte>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="ushort"/> matrix.</returns>
        public static explicit operator Matrix2X4<ushort>(Matrix2X4<T> from) =>
            new(from.Row1.As<ushort>(),
                from.Row2.As<ushort>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="uint"/> matrix.</returns>
        public static explicit operator Matrix2X4<uint>(Matrix2X4<T> from) =>
            new(from.Row1.As<uint>(),
                from.Row2.As<uint>());

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="ulong"/> matrix.</returns>
        public static explicit operator Matrix2X4<ulong>(Matrix2X4<T> from) =>
            new(from.Row1.As<ulong>(),
                from.Row2.As<ulong>());
    }

    public static partial class Matrix2X4
    {
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix2X4<T> Lerp<T>(Matrix2X4<T> value1, Matrix2X4<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(Vector4D.Lerp(value1.Row1, value2.Row1, amount),
                Vector4D.Lerp(value1.Row2, value2.Row2, amount));
    }
}
