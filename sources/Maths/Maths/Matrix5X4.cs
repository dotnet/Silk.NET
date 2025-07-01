// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix5X4<T>
    {
        private static readonly Matrix5X4<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero
        );

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
        public Matrix5X4<TOther> As<TOther>() where TOther : INumberBase<TOther>
        {
            return new(Row1.As<TOther>(), Row2.As<TOther>(), Row3.As<TOther>(), Row4.As<TOther>(), Row5.As<TOther>());
        }
    }
}
