// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x3 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix4X3<T>
        : IEquatable<Matrix4X3<T>>
        where T : INumberBase<T>
    {
        private static readonly Matrix4X3<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero
        );

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix4X3(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default);
            Row2 = new(value.M21, value.M22, default);
            Row3 = Vector3D<T>.UnitZ;
            Row4 = new(value.M31, value.M32, default);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix4X3(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
            Row4 = new(value.M41, value.M42, value.M43);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix4X3(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
            Row4 = default;
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix4X3(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = Vector3D<T>.UnitZ;
            Row4 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix4X3(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = Vector3D<T>.UnitZ;
            Row4 = default;
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix4X3(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default);
            Row2 = new(value.M21, value.M22, default);
            Row3 = new(value.M31, value.M32, default);
            Row4 = new(value.M41, value.M42, Scalar<T>.One);
        }

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix4X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X4{T}"/>.</param>
        public Matrix4X3(Matrix4X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
            Row4 = new(value.M41, value.M42, value.M43);
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4X3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) && Scalar.Equal(M22, Scalar<T>.One) &&
               Scalar.Equal(M33, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M13, Scalar<T>.Zero) &&
               Scalar.Equal(M21, Scalar<T>.Zero) && Scalar.Equal(M23, Scalar<T>.Zero) &&
               Scalar.Equal(M31, Scalar<T>.Zero) && Scalar.Equal(M32, Scalar<T>.Zero) &&
               Scalar.Equal(M41, Scalar<T>.Zero) && Scalar.Equal(M42, Scalar<T>.Zero) &&
               Scalar.Equal(M43, Scalar<T>.Zero);

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector3D<T> operator *(Vector4D<T> value1, Matrix4X3<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3 + value1.W * value2.Row4;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix4X3<T> operator *(Matrix4X3<T> value1, T value2)
        {
            return new(value1.Row1 * value2, value1.Row2 * value2, value1.Row3 * value2, value1.Row4 * value2);
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2}}} {{M21:{3} M22:{4} M23:{5}}} {{M31:{6} M32:{7} M33:{8}}} {{M41:{9} M42:{10} M43:{11}}} }}",
                                 M11, M12, M13,
                                 M21, M22, M23,
                                 M31, M32, M33,
                                 M41, M42, M43);
        }

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix4X3<Half>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, Half>(from.M11), Scalar.As<T, Half>(from.M12),
                Scalar.As<T, Half>(from.M13),
                Scalar.As<T, Half>(from.M21), Scalar.As<T, Half>(from.M22),
                Scalar.As<T, Half>(from.M23),
                Scalar.As<T, Half>(from.M31), Scalar.As<T, Half>(from.M32),
                Scalar.As<T, Half>(from.M33),
                Scalar.As<T, Half>(from.M41), Scalar.As<T, Half>(from.M42),
                Scalar.As<T, Half>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix4X3<float>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M13),
                Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M23),
                Scalar.As<T, float>(from.M31), Scalar.As<T, float>(from.M32),
                Scalar.As<T, float>(from.M33),
                Scalar.As<T, float>(from.M41), Scalar.As<T, float>(from.M42),
                Scalar.As<T, float>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix4X3<double>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, double>(from.M11), Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M13),
                Scalar.As<T, double>(from.M21), Scalar.As<T, double>(from.M22),
                Scalar.As<T, double>(from.M23),
                Scalar.As<T, double>(from.M31), Scalar.As<T, double>(from.M32),
                Scalar.As<T, double>(from.M33),
                Scalar.As<T, double>(from.M41), Scalar.As<T, double>(from.M42),
                Scalar.As<T, double>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix4X3<decimal>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, decimal>(from.M11), Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M13),
                Scalar.As<T, decimal>(from.M21), Scalar.As<T, decimal>(from.M22),
                Scalar.As<T, decimal>(from.M23),
                Scalar.As<T, decimal>(from.M31), Scalar.As<T, decimal>(from.M32),
                Scalar.As<T, decimal>(from.M33),
                Scalar.As<T, decimal>(from.M41), Scalar.As<T, decimal>(from.M42),
                Scalar.As<T, decimal>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix4X3<sbyte>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, sbyte>(from.M11), Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M13),
                Scalar.As<T, sbyte>(from.M21), Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M23),
                Scalar.As<T, sbyte>(from.M31), Scalar.As<T, sbyte>(from.M32),
                Scalar.As<T, sbyte>(from.M33),
                Scalar.As<T, sbyte>(from.M41), Scalar.As<T, sbyte>(from.M42),
                Scalar.As<T, sbyte>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix4X3<byte>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, byte>(from.M11), Scalar.As<T, byte>(from.M12),
                Scalar.As<T, byte>(from.M13),
                Scalar.As<T, byte>(from.M21), Scalar.As<T, byte>(from.M22),
                Scalar.As<T, byte>(from.M23),
                Scalar.As<T, byte>(from.M31), Scalar.As<T, byte>(from.M32),
                Scalar.As<T, byte>(from.M33),
                Scalar.As<T, byte>(from.M41), Scalar.As<T, byte>(from.M42),
                Scalar.As<T, byte>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix4X3<ushort>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, ushort>(from.M11), Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M13),
                Scalar.As<T, ushort>(from.M21), Scalar.As<T, ushort>(from.M22),
                Scalar.As<T, ushort>(from.M23),
                Scalar.As<T, ushort>(from.M31), Scalar.As<T, ushort>(from.M32),
                Scalar.As<T, ushort>(from.M33),
                Scalar.As<T, ushort>(from.M41), Scalar.As<T, ushort>(from.M42),
                Scalar.As<T, ushort>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix4X3<short>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, short>(from.M11), Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M13),
                Scalar.As<T, short>(from.M21), Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M23),
                Scalar.As<T, short>(from.M31), Scalar.As<T, short>(from.M32),
                Scalar.As<T, short>(from.M33),
                Scalar.As<T, short>(from.M41), Scalar.As<T, short>(from.M42),
                Scalar.As<T, short>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix4X3<uint>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, uint>(from.M11), Scalar.As<T, uint>(from.M12),
                Scalar.As<T, uint>(from.M13),
                Scalar.As<T, uint>(from.M21), Scalar.As<T, uint>(from.M22),
                Scalar.As<T, uint>(from.M23),
                Scalar.As<T, uint>(from.M31), Scalar.As<T, uint>(from.M32),
                Scalar.As<T, uint>(from.M33),
                Scalar.As<T, uint>(from.M41), Scalar.As<T, uint>(from.M42),
                Scalar.As<T, uint>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix4X3<int>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, int>(from.M11), Scalar.As<T, int>(from.M12),
                Scalar.As<T, int>(from.M13),
                Scalar.As<T, int>(from.M21), Scalar.As<T, int>(from.M22),
                Scalar.As<T, int>(from.M23),
                Scalar.As<T, int>(from.M31), Scalar.As<T, int>(from.M32),
                Scalar.As<T, int>(from.M33),
                Scalar.As<T, int>(from.M41), Scalar.As<T, int>(from.M42),
                Scalar.As<T, int>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix4X3<ulong>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, ulong>(from.M11), Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M13),
                Scalar.As<T, ulong>(from.M21), Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M23),
                Scalar.As<T, ulong>(from.M31), Scalar.As<T, ulong>(from.M32),
                Scalar.As<T, ulong>(from.M33),
                Scalar.As<T, ulong>(from.M41), Scalar.As<T, ulong>(from.M42),
                Scalar.As<T, ulong>(from.M43)
            );

        /// <summary>
        /// Converts a <see cref="Matrix4X3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix4X3<long>(Matrix4X3<T> from)
            => new
            (
                Scalar.As<T, long>(from.M11), Scalar.As<T, long>(from.M12),
                Scalar.As<T, long>(from.M13),
                Scalar.As<T, long>(from.M21), Scalar.As<T, long>(from.M22),
                Scalar.As<T, long>(from.M23),
                Scalar.As<T, long>(from.M31), Scalar.As<T, long>(from.M32),
                Scalar.As<T, long>(from.M33),
                Scalar.As<T, long>(from.M41), Scalar.As<T, long>(from.M42),
                Scalar.As<T, long>(from.M43)
            );
        
        /// <summary>
        /// Returns this matrix casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted matrix</returns>
        public Matrix4X3<TOther> As<TOther>() where TOther : INumberBase<TOther>
        {
            return new(Row1.As<TOther>(), Row2.As<TOther>(), Row3.As<TOther>(), Row4.As<TOther>());
        }
    }
}
