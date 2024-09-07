// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public struct Matrix5X4<T> : IEquatable<Matrix5X4<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private static readonly Matrix5X4<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>
        /// Row 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4D<T> Row1;

        /// <summary>
        /// Row 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4D<T> Row2;

        /// <summary>
        /// Row 3 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4D<T> Row3;

        /// <summary>
        /// Row 4 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4D<T> Row4;

        /// <summary>
        /// Row 5 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector4D<T> Row5;

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        [DataMember]
        public T M11
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        [DataMember]
        public T M12
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        [DataMember]
        public T M13
        {
            readonly get => Row1.Z;
            set => Row1.Z = value;
        }

        /// <summary>Value at row 1, column 4 of the matrix.</summary>
        [DataMember]
        public T M14
        {
            readonly get => Row1.W;
            set => Row1.W = value;
        }

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        [DataMember]
        public T M21
        {
            readonly get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        [DataMember]
        public T M22
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        [DataMember]
        public T M23
        {
            readonly get => Row2.Z;
            set => Row2.Z = value;
        }

        /// <summary>Value at row 2, column 4 of the matrix.</summary>
        [DataMember]
        public T M24
        {
            readonly get => Row2.W;
            set => Row2.W = value;
        }

        /// <summary>Value at row 3, column 1 of the matrix.</summary>
        [DataMember]
        public T M31
        {
            readonly get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>Value at row 3, column 2 of the matrix.</summary>
        [DataMember]
        public T M32
        {
            readonly get => Row3.Y;
            set => Row3.Y = value;
        }

        /// <summary>Value at row 3, column 3 of the matrix.</summary>
        [DataMember]
        public T M33
        {
            readonly get => Row3.Z;
            set => Row3.Z = value;
        }

        /// <summary>Value at row 3, column 4 of the matrix.</summary>
        [DataMember]
        public T M34
        {
            readonly get => Row3.W;
            set => Row3.W = value;
        }

        /// <summary>Value at row 4, column 1 of the matrix.</summary>
        [DataMember]
        public T M41
        {
            readonly get => Row4.X;
            set => Row4.X = value;
        }

        /// <summary>Value at row 4, column 2 of the matrix.</summary>
        [DataMember]
        public T M42
        {
            readonly get => Row4.Y;
            set => Row4.Y = value;
        }

        /// <summary>Value at row 4, column 3 of the matrix.</summary>
        [DataMember]
        public T M43
        {
            readonly get => Row4.Z;
            set => Row4.Z = value;
        }

        /// <summary>Value at row 4, column 4 of the matrix.</summary>
        [DataMember]
        public T M44
        {
            readonly get => Row4.W;
            set => Row4.W = value;
        }

        /// <summary>Value at row 5, column 1 of the matrix.</summary>
        [DataMember]
        public T M51
        {
            readonly get => Row5.X;
            set => Row5.X = value;
        }

        /// <summary>Value at row 5, column 2 of the matrix.</summary>
        [DataMember]
        public T M52
        {
            readonly get => Row5.Y;
            set => Row5.Y = value;
        }

        /// <summary>Value at row 5, column 3 of the matrix.</summary>
        [DataMember]
        public T M53
        {
            readonly get => Row5.Z;
            set => Row5.Z = value;
        }

        /// <summary>Value at row 5, column 4 of the matrix.</summary>
        [DataMember]
        public T M54
        {
            readonly get => Row5.W;
            set => Row5.W = value;
        }

        /// <summary>
        /// Indexer for the rows of this matrix.
        /// </summary>
        /// <param name="x">The row to select. Zero based.</param>
        public unsafe Vector4D<T> this[int x]
        {
            get
            {
                static void VerifyBounds(int i)
                {
                    static void ThrowHelper() => throw new IndexOutOfRangeException();

                    if (i > 4 || i < 0)
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

        /// <summary>
        /// Constructs a <see cref="Matrix5X4{T}"/> from the given rows
        /// </summary>
        public Matrix5X4(Vector4D<T> row1, Vector4D<T> row2, Vector4D<T> row3, Vector4D<T> row4, Vector4D<T> row5)
        {
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
            Row4 = row4;
            Row5 = row5;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given components.</summary>
        public Matrix5X4
        (
            T m11,
            T m12,
            T m13,
            T m14,
            T m21,
            T m22,
            T m23,
            T m24,
            T m31,
            T m32,
            T m33,
            T m34,
            T m41,
            T m42,
            T m43,
            T m44,
            T m51,
            T m52,
            T m53,
            T m54
        )
        {
            Row1 = new(m11, m12, m13, m14);
            Row2 = new(m21, m22, m23, m24);
            Row3 = new(m31, m32, m33, m34);
            Row4 = new(m41, m42, m43, m44);
            Row5 = new(m51, m52, m53, m54);
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix5X4(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default, default);
            Row2 = new(value.M21, value.M22, default, default);
            Row5 = new(value.M31, value.M32, default, default);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix4X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X4{T}"/>.</param>
        public Matrix5X4(Matrix4X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = new(value.M31, value.M32, value.M33, value.M34);
            Row4 = new(value.M41, value.M42, value.M43, value.M44);
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix5X4(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, default);
            Row2 = new(value.M21, value.M22, value.M23, default);
            Row3 = new(value.M31, value.M32, value.M33, default);
            Row4 = new(value.M41, value.M42, value.M43, Scalar<T>.One);
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix5X4(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = new(value.M31, value.M32, value.M33, value.M34);
            Row4 = default;
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix5X4(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, default);
            Row2 = new(value.M21, value.M22, value.M23, default);
            Row5 = new(value.M31, value.M32, value.M33, default);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix5X4(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
            Row5 = default;
        }

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix5X4(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default, default);
            Row2 = new(value.M21, value.M22, default, default);
            Row3 = new(value.M31, value.M32, Scalar<T>.One, default);
            Row4 = new(value.M41, value.M42, default, Scalar<T>.One);
            Row5 = default;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix5X4<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) && Scalar.Equal(M22, Scalar<T>.One) &&
               Scalar.Equal(M33, Scalar<T>.One) &&
               Scalar.Equal(M44, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M13, Scalar<T>.Zero) &&
               Scalar.Equal(M14, Scalar<T>.Zero) && Scalar.Equal(M21, Scalar<T>.Zero) &&
               Scalar.Equal(M23, Scalar<T>.Zero) && Scalar.Equal(M24, Scalar<T>.Zero) &&
               Scalar.Equal(M31, Scalar<T>.Zero) && Scalar.Equal(M32, Scalar<T>.Zero) &&
               Scalar.Equal(M34, Scalar<T>.Zero) && Scalar.Equal(M41, Scalar<T>.Zero) &&
               Scalar.Equal(M42, Scalar<T>.Zero) && Scalar.Equal(M43, Scalar<T>.Zero) &&
               Scalar.Equal(M51, Scalar<T>.Zero) && Scalar.Equal(M52, Scalar<T>.Zero) &&
               Scalar.Equal(M53, Scalar<T>.Zero) && Scalar.Equal(M54, Scalar<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix5X4<T> operator +(Matrix5X4<T> value1, Matrix5X4<T> value2)
        {
            return new
            (
                value1.Row1 + value2.Row1, value1.Row2 + value2.Row2, value1.Row3 + value2.Row3,
                value1.Row4 + value2.Row4, value1.Row5 + value2.Row5
            );
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix5X4<T> value1, Matrix5X4<T> value2)
        {
            return Scalar.Equal(value1.M11, value2.M11) && Scalar.Equal(value1.M22, value2.M22) &&
                   Scalar.Equal(value1.M33, value2.M33) &&
                   Scalar.Equal(value1.M44, value2.M44) && // Check diagonal elements first for early out.
                   Scalar.Equal(value1.M12, value2.M12) && Scalar.Equal(value1.M13, value2.M13) &&
                   Scalar.Equal(value1.M14, value2.M14) && Scalar.Equal(value1.M21, value2.M21) &&
                   Scalar.Equal(value1.M23, value2.M23) && Scalar.Equal(value1.M24, value2.M24) &&
                   Scalar.Equal(value1.M31, value2.M31) && Scalar.Equal(value1.M32, value2.M32) &&
                   Scalar.Equal(value1.M34, value2.M34) && Scalar.Equal(value1.M41, value2.M41) &&
                   Scalar.Equal(value1.M42, value2.M42) && Scalar.Equal(value1.M43, value2.M43) &&
                   Scalar.Equal(value1.M51, value2.M51) && Scalar.Equal(value1.M52, value2.M52) &&
                   Scalar.Equal(value1.M53, value2.M53) && Scalar.Equal(value1.M54, value2.M54);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix5X4<T> value1, Matrix5X4<T> value2)
        {
            return Scalar.NotEqual(value1.M11, value2.M11) || Scalar.NotEqual(value1.M22, value2.M22) ||
                   Scalar.NotEqual(value1.M33, value2.M33) ||
                   Scalar.NotEqual(value1.M44, value2.M44) || // Check diagonal elements first for early out.
                   Scalar.NotEqual(value1.M12, value2.M12) || Scalar.NotEqual(value1.M13, value2.M13) ||
                   Scalar.NotEqual(value1.M14, value2.M14) || Scalar.NotEqual(value1.M21, value2.M21) ||
                   Scalar.NotEqual(value1.M23, value2.M23) || Scalar.NotEqual(value1.M24, value2.M24) ||
                   Scalar.NotEqual(value1.M31, value2.M31) || Scalar.NotEqual(value1.M32, value2.M32) ||
                   Scalar.NotEqual(value1.M34, value2.M34) || Scalar.NotEqual(value1.M41, value2.M41) ||
                   Scalar.NotEqual(value1.M42, value2.M42) || Scalar.NotEqual(value1.M43, value2.M43) ||
                   Scalar.NotEqual(value1.M51, value2.M51) || Scalar.NotEqual(value1.M52, value2.M52) ||
                   Scalar.NotEqual(value1.M53, value2.M53) || Scalar.NotEqual(value1.M54, value2.M54);
        }

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector4D<T> operator *(Vector4D<T> value1, Matrix5X4<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3 +
                   value1.W * value2.Row4 + value2.Row5;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix5X4<T> operator *(Matrix5X4<T> value1, T value2)
        {
            return new(
                value1.Row1 * value2,
                value1.Row2 * value2,
                value1.Row3 * value2,
                value1.Row4 * value2,
                value1.Row5 * value2
                );
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix5X4<T> operator -(Matrix5X4<T> value1, Matrix5X4<T> value2)
        {
            return new(
                    value1.Row1 - value2.Row1,
                    value1.Row2 - value2.Row2,
                    value1.Row3 - value2.Row3,
                    value1.Row4 - value2.Row4,
                    value1.Row5 - value2.Row5
                );
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix5X4<T> operator -(Matrix5X4<T> value)
        {
            return new(
                -value.Row1,
                -value.Row2,
                -value.Row3,
                -value.Row4,
                -value.Row5
            );
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix5X4<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix5X4<T> other)
            => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);
            hash.Add(M13);
            hash.Add(M14);

            hash.Add(M21);
            hash.Add(M22);
            hash.Add(M23);
            hash.Add(M24);

            hash.Add(M31);
            hash.Add(M32);
            hash.Add(M33);
            hash.Add(M34);

            hash.Add(M41);
            hash.Add(M42);
            hash.Add(M43);
            hash.Add(M44);

            hash.Add(M51);
            hash.Add(M52);
            hash.Add(M53);
            hash.Add(M54);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} {{M31:{8} M32:{9} M33:{10} M34:{11}}} {{M41:{12} M42:{13} M43:{14} M44:{15}}} {{M51:{16} M52:{17} M53:{18} M54:{19}}} }}",
                                 M11, M12, M13, M14,
                                 M21, M22, M23, M24,
                                 M31, M32, M33, M34,
                                 M41, M42, M43, M44,
                                 M51, M52, M53, M54);
        }

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix5X4<Half>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, Half>(from.M11), Scalar.As<T, Half>(from.M12),
                Scalar.As<T, Half>(from.M13), Scalar.As<T, Half>(from.M14),
                Scalar.As<T, Half>(from.M21), Scalar.As<T, Half>(from.M22),
                Scalar.As<T, Half>(from.M23), Scalar.As<T, Half>(from.M24),
                Scalar.As<T, Half>(from.M31), Scalar.As<T, Half>(from.M32),
                Scalar.As<T, Half>(from.M33), Scalar.As<T, Half>(from.M34),
                Scalar.As<T, Half>(from.M41), Scalar.As<T, Half>(from.M42),
                Scalar.As<T, Half>(from.M43), Scalar.As<T, Half>(from.M44),
                Scalar.As<T, Half>(from.M51), Scalar.As<T, Half>(from.M52),
                Scalar.As<T, Half>(from.M53), Scalar.As<T, Half>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix5X4<float>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M13), Scalar.As<T, float>(from.M14),
                Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M23), Scalar.As<T, float>(from.M24),
                Scalar.As<T, float>(from.M31), Scalar.As<T, float>(from.M32),
                Scalar.As<T, float>(from.M33), Scalar.As<T, float>(from.M34),
                Scalar.As<T, float>(from.M41), Scalar.As<T, float>(from.M42),
                Scalar.As<T, float>(from.M43), Scalar.As<T, float>(from.M44),
                Scalar.As<T, float>(from.M51), Scalar.As<T, float>(from.M52),
                Scalar.As<T, float>(from.M53), Scalar.As<T, float>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix5X4<double>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, double>(from.M11), Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M13), Scalar.As<T, double>(from.M14),
                Scalar.As<T, double>(from.M21), Scalar.As<T, double>(from.M22),
                Scalar.As<T, double>(from.M23), Scalar.As<T, double>(from.M24),
                Scalar.As<T, double>(from.M31), Scalar.As<T, double>(from.M32),
                Scalar.As<T, double>(from.M33), Scalar.As<T, double>(from.M34),
                Scalar.As<T, double>(from.M41), Scalar.As<T, double>(from.M42),
                Scalar.As<T, double>(from.M43), Scalar.As<T, double>(from.M44),
                Scalar.As<T, double>(from.M51), Scalar.As<T, double>(from.M52),
                Scalar.As<T, double>(from.M53), Scalar.As<T, double>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix5X4<decimal>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, decimal>(from.M11), Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M13), Scalar.As<T, decimal>(from.M14),
                Scalar.As<T, decimal>(from.M21), Scalar.As<T, decimal>(from.M22),
                Scalar.As<T, decimal>(from.M23), Scalar.As<T, decimal>(from.M24),
                Scalar.As<T, decimal>(from.M31), Scalar.As<T, decimal>(from.M32),
                Scalar.As<T, decimal>(from.M33), Scalar.As<T, decimal>(from.M34),
                Scalar.As<T, decimal>(from.M41), Scalar.As<T, decimal>(from.M42),
                Scalar.As<T, decimal>(from.M43), Scalar.As<T, decimal>(from.M44),
                Scalar.As<T, decimal>(from.M51), Scalar.As<T, decimal>(from.M52),
                Scalar.As<T, decimal>(from.M53), Scalar.As<T, decimal>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix5X4<sbyte>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, sbyte>(from.M11), Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M13), Scalar.As<T, sbyte>(from.M14),
                Scalar.As<T, sbyte>(from.M21), Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M23), Scalar.As<T, sbyte>(from.M24),
                Scalar.As<T, sbyte>(from.M31), Scalar.As<T, sbyte>(from.M32),
                Scalar.As<T, sbyte>(from.M33), Scalar.As<T, sbyte>(from.M34),
                Scalar.As<T, sbyte>(from.M41), Scalar.As<T, sbyte>(from.M42),
                Scalar.As<T, sbyte>(from.M43), Scalar.As<T, sbyte>(from.M44),
                Scalar.As<T, sbyte>(from.M51), Scalar.As<T, sbyte>(from.M52),
                Scalar.As<T, sbyte>(from.M53), Scalar.As<T, sbyte>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix5X4<byte>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, byte>(from.M11), Scalar.As<T, byte>(from.M12),
                Scalar.As<T, byte>(from.M13), Scalar.As<T, byte>(from.M14),
                Scalar.As<T, byte>(from.M21), Scalar.As<T, byte>(from.M22),
                Scalar.As<T, byte>(from.M23), Scalar.As<T, byte>(from.M24),
                Scalar.As<T, byte>(from.M31), Scalar.As<T, byte>(from.M32),
                Scalar.As<T, byte>(from.M33), Scalar.As<T, byte>(from.M34),
                Scalar.As<T, byte>(from.M41), Scalar.As<T, byte>(from.M42),
                Scalar.As<T, byte>(from.M43), Scalar.As<T, byte>(from.M44),
                Scalar.As<T, byte>(from.M51), Scalar.As<T, byte>(from.M52),
                Scalar.As<T, byte>(from.M53), Scalar.As<T, byte>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix5X4<ushort>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, ushort>(from.M11), Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M13), Scalar.As<T, ushort>(from.M14),
                Scalar.As<T, ushort>(from.M21), Scalar.As<T, ushort>(from.M22),
                Scalar.As<T, ushort>(from.M23), Scalar.As<T, ushort>(from.M24),
                Scalar.As<T, ushort>(from.M31), Scalar.As<T, ushort>(from.M32),
                Scalar.As<T, ushort>(from.M33), Scalar.As<T, ushort>(from.M34),
                Scalar.As<T, ushort>(from.M41), Scalar.As<T, ushort>(from.M42),
                Scalar.As<T, ushort>(from.M43), Scalar.As<T, ushort>(from.M44),
                Scalar.As<T, ushort>(from.M51), Scalar.As<T, ushort>(from.M52),
                Scalar.As<T, ushort>(from.M53), Scalar.As<T, ushort>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix5X4<short>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, short>(from.M11), Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M13), Scalar.As<T, short>(from.M14),
                Scalar.As<T, short>(from.M21), Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M23), Scalar.As<T, short>(from.M24),
                Scalar.As<T, short>(from.M31), Scalar.As<T, short>(from.M32),
                Scalar.As<T, short>(from.M33), Scalar.As<T, short>(from.M34),
                Scalar.As<T, short>(from.M41), Scalar.As<T, short>(from.M42),
                Scalar.As<T, short>(from.M43), Scalar.As<T, short>(from.M44),
                Scalar.As<T, short>(from.M51), Scalar.As<T, short>(from.M52),
                Scalar.As<T, short>(from.M53), Scalar.As<T, short>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix5X4<uint>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, uint>(from.M11), Scalar.As<T, uint>(from.M12),
                Scalar.As<T, uint>(from.M13), Scalar.As<T, uint>(from.M14),
                Scalar.As<T, uint>(from.M21), Scalar.As<T, uint>(from.M22),
                Scalar.As<T, uint>(from.M23), Scalar.As<T, uint>(from.M24),
                Scalar.As<T, uint>(from.M31), Scalar.As<T, uint>(from.M32),
                Scalar.As<T, uint>(from.M33), Scalar.As<T, uint>(from.M34),
                Scalar.As<T, uint>(from.M41), Scalar.As<T, uint>(from.M42),
                Scalar.As<T, uint>(from.M43), Scalar.As<T, uint>(from.M44),
                Scalar.As<T, uint>(from.M51), Scalar.As<T, uint>(from.M52),
                Scalar.As<T, uint>(from.M53), Scalar.As<T, uint>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix5X4<int>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, int>(from.M11), Scalar.As<T, int>(from.M12),
                Scalar.As<T, int>(from.M13), Scalar.As<T, int>(from.M14),
                Scalar.As<T, int>(from.M21), Scalar.As<T, int>(from.M22),
                Scalar.As<T, int>(from.M23), Scalar.As<T, int>(from.M24),
                Scalar.As<T, int>(from.M31), Scalar.As<T, int>(from.M32),
                Scalar.As<T, int>(from.M33), Scalar.As<T, int>(from.M34),
                Scalar.As<T, int>(from.M41), Scalar.As<T, int>(from.M42),
                Scalar.As<T, int>(from.M43), Scalar.As<T, int>(from.M44),
                Scalar.As<T, int>(from.M51), Scalar.As<T, int>(from.M52),
                Scalar.As<T, int>(from.M53), Scalar.As<T, int>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix5X4<ulong>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, ulong>(from.M11), Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M13), Scalar.As<T, ulong>(from.M14),
                Scalar.As<T, ulong>(from.M21), Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M23), Scalar.As<T, ulong>(from.M24),
                Scalar.As<T, ulong>(from.M31), Scalar.As<T, ulong>(from.M32),
                Scalar.As<T, ulong>(from.M33), Scalar.As<T, ulong>(from.M34),
                Scalar.As<T, ulong>(from.M41), Scalar.As<T, ulong>(from.M42),
                Scalar.As<T, ulong>(from.M43), Scalar.As<T, ulong>(from.M44),
                Scalar.As<T, ulong>(from.M51), Scalar.As<T, ulong>(from.M52),
                Scalar.As<T, ulong>(from.M53), Scalar.As<T, ulong>(from.M54)
            );

        /// <summary>
        /// Converts a <see cref="Matrix5X4{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix5X4<long>(Matrix5X4<T> from)
            => new
            (
                Scalar.As<T, long>(from.M11), Scalar.As<T, long>(from.M12),
                Scalar.As<T, long>(from.M13), Scalar.As<T, long>(from.M14),
                Scalar.As<T, long>(from.M21), Scalar.As<T, long>(from.M22),
                Scalar.As<T, long>(from.M23), Scalar.As<T, long>(from.M24),
                Scalar.As<T, long>(from.M31), Scalar.As<T, long>(from.M32),
                Scalar.As<T, long>(from.M33), Scalar.As<T, long>(from.M34),
                Scalar.As<T, long>(from.M41), Scalar.As<T, long>(from.M42),
                Scalar.As<T, long>(from.M43), Scalar.As<T, long>(from.M44),
                Scalar.As<T, long>(from.M51), Scalar.As<T, long>(from.M52),
                Scalar.As<T, long>(from.M53), Scalar.As<T, long>(from.M54)
            );
        
        /// <summary>
        /// Returns this matrix casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted matrix</returns>
        public Matrix5X4<TOther> As<TOther>() where TOther : unmanaged, IFormattable, IEquatable<TOther>, IComparable<TOther>
        {
            return new(Row1.As<TOther>(), Row2.As<TOther>(), Row3.As<TOther>(), Row4.As<TOther>(), Row5.As<TOther>());
        }
    }
}
