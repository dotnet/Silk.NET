namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    public partial struct Matrix2X3<T> :
        IEquatable<Matrix2X3<T>>
        where T : INumberBase<T>
    {
        /// <summary>The 1st row of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector3D<T> Row1;

        /// <summary>The 2nd row of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector3D<T> Row2;

        /// <summary>The 1st column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column1 => new(Row1.X, Row2.X);

        /// <summary>The 2nd column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column2 => new(Row1.Y, Row2.Y);

        /// <summary>The 3rd column of the matrix represented as a vector.</summary>
        [IgnoreDataMember]
        public Vector2D<T> Column3 => new(Row1.Z, Row2.Z);

        /// <summary>
        /// Constructs a <see cref="Matrix2X3{T}"/> from the given rows.
        /// </summary>
        public Matrix2X3(Vector3D<T> row1, Vector3D<T> row2) =>
            (Row1, Row2) = (row1, row2);

        /// <summary>
        /// Constructs a <see cref="Matrix2X3{T}"/> from the given components.
        /// </summary>
        public Matrix2X3(
            T m11, T m12, T m13,
            T m21, T m22, T m23)
        {
            Row1 = new(m11, m12, m13);
            Row2 = new(m21, m22, m23);
        }

        /// <summary>
        /// Indexer for the rows of this matrix.
        /// </summary>
        /// <param name="row">The row to select. Zero based.</param>
        [UnscopedRef]
        public ref Vector3D<T> this[int row]
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


        /// <inheritdoc/>
        public override string ToString() =>
            string.Format(
                "{{ {{M11:{0} M12:{1} M13:{2}}} {{M21:{3} M22:{4} M23:{5}}} }}",
                Row1.X, Row1.Y, Row1.Z,
                Row2.X, Row2.Y, Row2.Z);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Matrix2X3<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Matrix2X3<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2);

        /// <summary>Converts the components of this matrix to another type.</summary>
        public static Matrix2X3<T> CreateChecked<TOther>(Matrix2X3<TOther> other)
            where TOther : INumberBase<TOther> =>
            new(Vector3D<T>.CreateChecked(other.Row1), Vector3D<T>.CreateChecked(other.Row2));

        /// <summary>Converts the components of this matrix to another type.</summary>
        public static Matrix2X3<T> CreateSaturating<TOther>(Matrix2X3<TOther> other)
            where TOther : INumberBase<TOther> =>
            new(Vector3D<T>.CreateSaturating(other.Row1), Vector3D<T>.CreateSaturating(other.Row2));

        /// <summary>Converts the components of this matrix to another type.</summary>
        public static Matrix2X3<T> CreateTruncating<TOther>(Matrix2X3<TOther> other)
            where TOther : INumberBase<TOther> =>
            new(Vector3D<T>.CreateTruncating(other.Row1), Vector3D<T>.CreateTruncating(other.Row2));

        /// <summary>Converts the components of this matrix to another type.</summary>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Matrix2X3<TOther> As<TOther>()
            where TOther : INumberBase<TOther> =>
            new(Row1.As<TOther>(), Row2.As<TOther>());

        /// <summary>Converts the components of this matrix to another type.</summary>
        public Matrix2X3<TOther> AsChecked<TOther>()
            where TOther : INumberBase<TOther> =>
            Matrix2X3<TOther>.CreateChecked(this);

        /// <summary>Converts the components of this matrix to another type.</summary>
        public Matrix2X3<TOther> AsSaturating<TOther>()
            where TOther : INumberBase<TOther> =>
            Matrix2X3<TOther>.CreateSaturating(this);

        /// <summary>Converts the components of this matrix to another type.</summary>
        public Matrix2X3<TOther> AsTruncating<TOther>()
            where TOther : INumberBase<TOther> =>
            Matrix2X3<TOther>.CreateTruncating(this);

        /// <summary>Computes the transpose of the matrix.</summary>
        public Matrix3X2<T> Transpose() =>
            new(new(M11, M21),
                new(M12, M22),
                new(M13, M23));

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix2X3<T> left, Matrix2X3<T> right) =>
            left.Row1 == right.Row1 &&
            left.Row2 == right.Row2;

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="left">The first matrix to compare.</param>
        /// <param name="right">The second matrix to compare.</param>
        /// <returns><c>true</c> if the given matrices are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix2X3<T> left, Matrix2X3<T> right) => !(left == right);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix2X3<T> operator +(Matrix2X3<T> left, Matrix2X3<T> right) =>
            new(left.Row1 + right.Row1,
                left.Row2 + right.Row2);

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix2X3<T> operator -(Matrix2X3<T> left, Matrix2X3<T> right) =>
            new(left.Row1 - right.Row1,
                left.Row2 - right.Row2);

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix2X3<T> operator -(Matrix2X3<T> value) =>
            new(-value.Row1,
                -value.Row2);

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source matrix.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X3<T> operator *(T left, Matrix2X3<T> right) =>
            new(left * right.Row1,
                left * right.Row2);

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The source matrix.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X3<T> operator *(Matrix2X3<T> left, T right) =>
            new(left.Row1 * right,
                left.Row2 * right);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="rowVector">The first source matrix, expressed as a row vector.</param>
        /// <param name="matrix">The second source matrix.</param>
        /// <returns>The result of the multiplication as a column vector.</returns>
        public static Vector3D<T> operator *(Vector2D<T> rowVector, Matrix2X3<T> matrix) =>
            rowVector.X * matrix.Row1 + rowVector.Y * matrix.Row2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="matrix">The first source matrix.</param>
        /// <param name="columnVector">The second source matrix, expressed as a column vector.</param>
        /// <returns>The result of the multiplication as a row vector.</returns>
        public static Vector2D<T> operator *(Matrix2X3<T> matrix, Vector3D<T> columnVector) =>
             matrix.Column1 * columnVector.X +  matrix.Column2 * columnVector.Y +  matrix.Column3 * columnVector.Z;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X3<T> operator *(Matrix2X2<T> left, Matrix2X3<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2,
                left.M21 * right.Row1 + left.M22 * right.Row2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X2<T> operator *(Matrix2X3<T> left, Matrix3X2<T> right) =>
            new(left.M11 * right.Row1 + left.M12 * right.Row2 + left.M13 * right.Row3,
                left.M21 * right.Row1 + left.M22 * right.Row2 + left.M23 * right.Row3);

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="Half"/> matrix.</returns>
        public static explicit operator Matrix2X3<Half>(Matrix2X3<T> from) =>
            new(Vector3D<Half>.CreateTruncating(from.Row1),
                Vector3D<Half>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="Half"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<Half>(Matrix2X3<T> from) =>
            new(Vector3D<Half>.CreateChecked(from.Row1),
                Vector3D<Half>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="float"/> matrix.</returns>
        public static explicit operator Matrix2X3<float>(Matrix2X3<T> from) =>
            new(Vector3D<float>.CreateTruncating(from.Row1),
                Vector3D<float>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="float"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<float>(Matrix2X3<T> from) =>
            new(Vector3D<float>.CreateChecked(from.Row1),
                Vector3D<float>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="double"/> matrix.</returns>
        public static explicit operator Matrix2X3<double>(Matrix2X3<T> from) =>
            new(Vector3D<double>.CreateTruncating(from.Row1),
                Vector3D<double>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="double"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<double>(Matrix2X3<T> from) =>
            new(Vector3D<double>.CreateChecked(from.Row1),
                Vector3D<double>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="decimal"/> matrix.</returns>
        public static explicit operator Matrix2X3<decimal>(Matrix2X3<T> from) =>
            new(Vector3D<decimal>.CreateTruncating(from.Row1),
                Vector3D<decimal>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="decimal"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<decimal>(Matrix2X3<T> from) =>
            new(Vector3D<decimal>.CreateChecked(from.Row1),
                Vector3D<decimal>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="byte"/> matrix.</returns>
        public static explicit operator Matrix2X3<byte>(Matrix2X3<T> from) =>
            new(Vector3D<byte>.CreateTruncating(from.Row1),
                Vector3D<byte>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="byte"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<byte>(Matrix2X3<T> from) =>
            new(Vector3D<byte>.CreateChecked(from.Row1),
                Vector3D<byte>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="short"/> matrix.</returns>
        public static explicit operator Matrix2X3<short>(Matrix2X3<T> from) =>
            new(Vector3D<short>.CreateTruncating(from.Row1),
                Vector3D<short>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="short"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<short>(Matrix2X3<T> from) =>
            new(Vector3D<short>.CreateChecked(from.Row1),
                Vector3D<short>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="int"/> matrix.</returns>
        public static explicit operator Matrix2X3<int>(Matrix2X3<T> from) =>
            new(Vector3D<int>.CreateTruncating(from.Row1),
                Vector3D<int>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="int"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<int>(Matrix2X3<T> from) =>
            new(Vector3D<int>.CreateChecked(from.Row1),
                Vector3D<int>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="long"/> matrix.</returns>
        public static explicit operator Matrix2X3<long>(Matrix2X3<T> from) =>
            new(Vector3D<long>.CreateTruncating(from.Row1),
                Vector3D<long>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="long"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<long>(Matrix2X3<T> from) =>
            new(Vector3D<long>.CreateChecked(from.Row1),
                Vector3D<long>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="sbyte"/> matrix.</returns>
        public static explicit operator Matrix2X3<sbyte>(Matrix2X3<T> from) =>
            new(Vector3D<sbyte>.CreateTruncating(from.Row1),
                Vector3D<sbyte>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="sbyte"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<sbyte>(Matrix2X3<T> from) =>
            new(Vector3D<sbyte>.CreateChecked(from.Row1),
                Vector3D<sbyte>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="ushort"/> matrix.</returns>
        public static explicit operator Matrix2X3<ushort>(Matrix2X3<T> from) =>
            new(Vector3D<ushort>.CreateTruncating(from.Row1),
                Vector3D<ushort>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="ushort"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<ushort>(Matrix2X3<T> from) =>
            new(Vector3D<ushort>.CreateChecked(from.Row1),
                Vector3D<ushort>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="uint"/> matrix.</returns>
        public static explicit operator Matrix2X3<uint>(Matrix2X3<T> from) =>
            new(Vector3D<uint>.CreateTruncating(from.Row1),
                Vector3D<uint>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="uint"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<uint>(Matrix2X3<T> from) =>
            new(Vector3D<uint>.CreateChecked(from.Row1),
                Vector3D<uint>.CreateChecked(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="ulong"/> matrix.</returns>
        public static explicit operator Matrix2X3<ulong>(Matrix2X3<T> from) =>
            new(Vector3D<ulong>.CreateTruncating(from.Row1),
                Vector3D<ulong>.CreateTruncating(from.Row2));

        /// <summary>
        /// Converts a matrix of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source matrix.</param>
        /// <returns>The <see cref="ulong"/> matrix.</returns>
        public static explicit operator checked Matrix2X3<ulong>(Matrix2X3<T> from) =>
            new(Vector3D<ulong>.CreateChecked(from.Row1),
                Vector3D<ulong>.CreateChecked(from.Row2));
    }

    /// <summary>
    /// Methods for working with <see cref="Matrix2X3{T}"/>.
    /// </summary>
    public static partial class Matrix2X3
    {
        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix2X3<T> Lerp<T>(Matrix2X3<T> value1, Matrix2X3<T> value2, T amount)
            where T : IFloatingPointIeee754<T> =>
            new(Vector3D.Lerp(value1.Row1, value2.Row1, amount),
                Vector3D.Lerp(value1.Row2, value2.Row2, amount));

        /// <summary>Adds two matrices together.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the addition.</returns>
        public static Matrix2X3<T> Add<T>(Matrix2X3<T> left, Matrix2X3<T> right)
            where T : INumberBase<T> =>
            left + right;

        /// <summary>Returns a negated copy of the specified matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix2X3<T> Negate<T>(Matrix2X3<T> value)
            where T : INumberBase<T>
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static Matrix2X3<T> Subtract<T>(Matrix2X3<T> left, Matrix2X3<T> right)
            where T : INumberBase<T>
            => left - right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The source matrix.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X3<T> Multiply<T>(Matrix2X3<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source matrix.</param>
        /// <returns>The scaled matrix.</returns>
        public static Matrix2X3<T> Multiply<T>(T left, Matrix2X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="rowVector">The first source matrix, expressed as a row vector.</param>
        /// <param name="matrix">The second source matrix.</param>
        /// <returns>The result of the multiplication as a column vector.</returns>
        public static Vector3D<T> Multiply<T>(Vector2D<T> rowVector, Matrix2X3<T> matrix)
            where T : INumberBase<T> =>
            rowVector * matrix;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="matrix">The first source matrix.</param>
        /// <param name="columnVector">The second source matrix, expressed as a column vector.</param>
        /// <returns>The result of the multiplication as a row vector.</returns>
        public static Vector2D<T> Multiply<T>(Matrix2X3<T> matrix, Vector3D<T> columnVector)
            where T : INumberBase<T> =>
            matrix * columnVector;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X3<T> Multiply<T>(Matrix2X2<T> left, Matrix2X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X2<T> Multiply<T>(Matrix2X3<T> left, Matrix3X2<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X3<T> Multiply<T>(Matrix2X3<T> left, Matrix3X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix2X4<T> Multiply<T>(Matrix2X3<T> left, Matrix3X4<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix3X3<T> Multiply<T>(Matrix3X2<T> left, Matrix2X3<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="left">The first source matrix.</param>
        /// <param name="right">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static Matrix4X3<T> Multiply<T>(Matrix4X2<T> left, Matrix2X3<T> right)
            where T : INumberBase<T> =>
            left * right;
    }
}
