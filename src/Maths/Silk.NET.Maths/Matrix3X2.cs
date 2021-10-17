// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 3x2 matrix.</summary>
    [Serializable]
    [DataContract]
    public struct Matrix3X2<T>
        : IEquatable<Matrix3X2<T>>
        where T : unmanaged, IFormattable, IComparable<T>, IEquatable<T>
    {
        private static readonly Matrix3X2<T> _identity = new(
            Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>
        /// Row 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Row1;

        /// <summary>
        /// Row 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Row2;

        /// <summary>
        /// Row 3 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Row3;

        /// <summary>
        /// Column 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Column1 => new(Row1.X, Row2.X, Row3.X);

        /// <summary>
        /// Column 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Column2 => new(Row1.Y, Row2.Y, Row3.Y);

        /// <summary>The first element of the first row</summary>
        [DataMember]
        public T M11
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>The second element of the first row</summary>
        [DataMember]
        public T M12
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>The first element of the second row</summary>
        [DataMember]
        public T M21
        {
            readonly get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>The second element of the second row</summary>
        [DataMember]
        public T M22
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>The first element of the third row</summary>
        [DataMember]
        public T M31
        {
            readonly get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>The second element of the third row</summary>
        [DataMember]
        public T M32
        {
            readonly get => Row3.Y;
            set => Row3.Y = value;
        }

        /// <summary>
        /// Indexer for the rows of this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        public unsafe Vector2D<T> this[int x]
        {
            get
            {
                static void VerifyBounds(int i)
                {
                    static void ThrowHelper() => throw new IndexOutOfRangeException();

                    if (i > 2 || i < 0)
                        ThrowHelper();
                }

                VerifyBounds(x);
                return Unsafe.Add(ref Row1, x);
            }
        }

        /// <summary>
        /// Indexer for the values in this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        /// <param name="y">The column to select. Zero based.</param>
        public unsafe T this[int x, int y]
        {
            get
            {
                var row = this[x];
                return row[y];
            }
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given components.</summary>
        public Matrix3X2(T m11, T m12,
            T m21, T m22,
            T m31, T m32)
        {
            Row1 = new(m11, m12);
            Row2 = new(m21, m22);
            Row3 = new(m31, m32);
        }

        /// <summary>
        /// Constructs a <see cref="Matrix3X2{T}"/> from the given rows.
        /// </summary>
        public Matrix3X2(Vector2D<T> row1, Vector2D<T> row2, Vector2D<T> row3)
        {
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix3X2(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix3X2(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix3X2(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix3X2(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = Vector2D<T>.Zero;
        }

        /// <summary>Constructs a <see cref="Matrix3X2{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix3X2(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12);
            Row2 = new(value.M21, value.M22);
            Row3 = new(value.M31, value.M32);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3X2<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Adds each matrix element in value1 with its corresponding element in value2.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the summed values.</returns>
        public static Matrix3X2<T> operator +(Matrix3X2<T> value1, Matrix3X2<T> value2)
        {
            return new(value1.Row1 + value2.Row1, value1.Row2 + value2.Row2, value1.Row3 + value2.Row3);
        }

        /// <summary>Returns a boolean indicating whether the given matrices are equal.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public static bool operator ==(Matrix3X2<T> value1, Matrix3X2<T> value2)
        {
            return (Scalar.Equal(value1.M11, value2.M11)
                 && Scalar.Equal(value1.M22, value2.M22) // Check diagonal element first for early out
                 && Scalar.Equal(value1.M12, value2.M12)
                 && Scalar.Equal(value1.M21, value2.M21)
                 && Scalar.Equal(value1.M31, value2.M31)
                 && Scalar.Equal(value1.M32, value2.M32));
        }

        /// <summary>Returns a boolean indicating whether the given matrices are not equal.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>True if the matrices are not equal; False if they are equal.</returns>
        public static bool operator !=(Matrix3X2<T> value1, Matrix3X2<T> value2)
        {
            return (Scalar.NotEqual(value1.M11, value2.M11)
                    || Scalar.NotEqual(value1.M22, value2.M22) // Check diagonal element first for early out
                    || Scalar.NotEqual(value1.M12, value2.M12)
                    || Scalar.NotEqual(value1.M21, value2.M21)
                    || Scalar.NotEqual(value1.M31, value2.M31)
                    || Scalar.NotEqual(value1.M32, value2.M32));
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3X3<T> operator *(Matrix3X2<T> value1, Matrix2X3<T> value2)
        {
            return new(value1.M11 * value2.Row1 * value1.M12 * value2.Row2,
                value1.M21 * value2.Row1 * value1.M22 * value2.Row2,
                value1.M31 * value2.Row1 * value1.M32 * value2.Row2);
        }

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector2D<T> operator *(Vector3D<T> value1, Matrix3X2<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3X2<T> operator *(Matrix3X2<T> value1, Matrix2X2<T> value2)
        {
            return new(
                value1.M11 * value2.Row1 + value1.M12 * value2.Row2,
                value1.M21 * value2.Row1 + value1.M22 * value2.Row2,
                value1.M31 * value2.Row1 + value1.M32 * value2.Row2
                );
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3X2<T> operator *(Matrix3X3<T> value1, Matrix3X2<T> value2)
        {
            return new(
                value1.M11 * value2.Row1 + value1.M12 * value2.Row2 + value1.M13 * value2.Row3,
                value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M33 * value2.Row3,
                value1.M31 * value2.Row1 + value1.M32 * value2.Row2 + value1.M23 * value2.Row3
                );
        }

        /// <summary>Scales all elements in a matrix by the given scalar factor.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling value to use.</param>
        /// <returns>The resulting matrix.</returns>
        public static Matrix3X2<T> operator *(Matrix3X2<T> value1, T value2)
        {
            return new(value1.Row1 * value2, value1.Row2 * value2, value1.Row3 * value2);
        }

        /// <summary>Subtracts each matrix element in value2 from its corresponding element in value1.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the resulting values.</returns>
        public static Matrix3X2<T> operator -(Matrix3X2<T> value1, Matrix3X2<T> value2)
        {
            return new(value1.Row1 - value2.Row1, value1.Row2 - value2.Row2, value1.Row3 - value2.Row3);
        }

        /// <summary>Negates the given matrix by multiplying all values by -1.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix3X2<T> operator -(Matrix3X2<T> value)
        {
            return new(-value.Row1, -value.Row2, -value.Row3);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix3X2<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether the matrix is equal to the other given matrix.</summary>
        /// <param name="other">The other matrix to test equality against.</param>
        /// <returns>True if this matrix is equal to other; False otherwise.</returns>
        public readonly bool Equals(Matrix3X2<T> other)
        {
            return this == other;
        }

        /// <summary>Calculates the determinant for this matrix.
        /// The determinant is calculated by expanding the matrix with a third column whose values are (0,0,1).</summary>
        /// <returns>The determinant.</returns>
        public readonly T GetDeterminant()
        {
            // There isn't actually any such thing as a determinant for a non-square matrix,
            // but this 3x2 type is really just an optimization of a 3x3 where we happen to
            // know the rightmost column is always (0, 0, 1). So we expand to 3x3 format:
            //
            //  [ M11, M12, 0 ]
            //  [ M21, M22, 0 ]
            //  [ M31, M32, 1 ]
            //
            // Sum the diagonal products:
            //  (M11 * M22 * 1) + (M12 * 0 * M31) + (0 * M21 * M32)
            //
            // Subtract the opposite diagonal products:
            //  (M31 * M22 * 0) + (M32 * 0 * M11) + (1 * M21 * M12)
            //
            // Collapse out the constants and oh look, this is just a 2x2 determinant!

            return Scalar.Subtract(Scalar.Multiply(M11, M22), Scalar.Multiply(M21, M12));
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(M11, M12, M21, M22, M31, M32);
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1}}} {{M21:{2} M22:{3}}} {{M31:{4} M32:{5}}} }}",
                                 M11, M12,
                                 M21, M22,
                                 M31, M32);
        }

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix3X2<Half>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, Half>(from.M11), Scalar.As<T, Half>(from.M12),
                Scalar.As<T, Half>(from.M21), Scalar.As<T, Half>(from.M22),
                Scalar.As<T, Half>(from.M31), Scalar.As<T, Half>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix3X2<float>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M31), Scalar.As<T, float>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into a <see cref="System.Numerics.Matrix3x2"/> one.
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="System.Numerics"/> matrix</returns>
        public static explicit operator System.Numerics.Matrix3x2(Matrix3X2<T> from)
            => new(
                Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M31), Scalar.As<T, float>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix3X2<double>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, double>(from.M11), Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M21), Scalar.As<T, double>(from.M22),
                Scalar.As<T, double>(from.M31), Scalar.As<T, double>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix3X2<decimal>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, decimal>(from.M11), Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M21), Scalar.As<T, decimal>(from.M22),
                Scalar.As<T, decimal>(from.M31), Scalar.As<T, decimal>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix3X2<sbyte>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, sbyte>(from.M11), Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M21), Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M31), Scalar.As<T, sbyte>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix3X2<byte>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, byte>(from.M11), Scalar.As<T, byte>(from.M12),
                Scalar.As<T, byte>(from.M21), Scalar.As<T, byte>(from.M22),
                Scalar.As<T, byte>(from.M31), Scalar.As<T, byte>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix3X2<ushort>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, ushort>(from.M11), Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M21), Scalar.As<T, ushort>(from.M22),
                Scalar.As<T, ushort>(from.M31), Scalar.As<T, ushort>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix3X2<short>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, short>(from.M11), Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M21), Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M31), Scalar.As<T, short>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix3X2<uint>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, uint>(from.M11), Scalar.As<T, uint>(from.M12),
                Scalar.As<T, uint>(from.M21), Scalar.As<T, uint>(from.M22),
                Scalar.As<T, uint>(from.M31), Scalar.As<T, uint>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix3X2<int>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, int>(from.M11), Scalar.As<T, int>(from.M12),
                Scalar.As<T, int>(from.M21), Scalar.As<T, int>(from.M22),
                Scalar.As<T, int>(from.M31), Scalar.As<T, int>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix3X2<ulong>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, ulong>(from.M11), Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M21), Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M31), Scalar.As<T, ulong>(from.M32)
            );

        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix3X2<long>(Matrix3X2<T> from)
            => new(
                Scalar.As<T, long>(from.M11), Scalar.As<T, long>(from.M12),
                Scalar.As<T, long>(from.M21), Scalar.As<T, long>(from.M22),
                Scalar.As<T, long>(from.M31), Scalar.As<T, long>(from.M32)
            );
        
        /// <summary>
        /// Returns this matrix casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted matrix</returns>
        public Matrix3X2<TOther> As<TOther>() where TOther : unmanaged, IFormattable, IEquatable<TOther>, IComparable<TOther>
        {
            return new(Row1.As<TOther>(), Row2.As<TOther>(), Row3.As<TOther>());
        }
    }
}
