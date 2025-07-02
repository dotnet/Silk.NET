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
    public partial struct Matrix4X4<T>
    {
        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix4X4(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default, default);
            Row2 = new(value.M21, value.M22, default, default);
            Row4 = new(value.M31, value.M32, default, Scalar<T>.One);
            Row3 = new(default, default, Scalar<T>.One, default);
        }

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix4X4(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, default);
            Row2 = new(value.M21, value.M22, value.M23, default);
            Row3 = new(value.M31, value.M32, value.M33, default);
            Row4 = new(value.M41, value.M42, value.M43, Scalar<T>.One);
        }

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix4X4(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = new(value.M31, value.M32, value.M33, value.M34);
            Row4 = default;
        }

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix4X4(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, default);
            Row2 = new(value.M21, value.M22, value.M23, default);
            Row4 = new(value.M31, value.M32, value.M33, Scalar<T>.One);
            Row3 = new(default, default, Scalar<T>.One, default);
        }

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix4X4(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, value.M14);
            Row2 = new(value.M21, value.M22, value.M23, value.M24);
            Row3 = Vector4D<T>.UnitZ;
            Row4 = Vector4D<T>.UnitW;
        }

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix4X4(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, default, default);
            Row2 = new(value.M21, value.M22, default, default);
            Row3 = new(value.M31, value.M32, Scalar<T>.One, default);
            Row4 = new(value.M41, value.M42, default, Scalar<T>.One);
        }

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
               Scalar.Equal(M42, Scalar<T>.Zero) && Scalar.Equal(M43, Scalar<T>.Zero);

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector4D<T> operator *(Vector4D<T> value1, Matrix4X4<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3 +
                   value1.W * value2.Row4;
        }

        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            // | a b c d |     | f g h |     | e g h |     | e f h |     | e f g |
            // | e f g h | = a | j k l | - b | i k l | + c | i j l | - d | i j k |
            // | i j k l |     | n o p |     | m o p |     | m n p |     | m n o |
            // | m n o p |
            //
            //   | f g h |
            // a | j k l | = a ( f ( kp - lo ) - g ( jp - ln ) + h ( jo - kn ) )
            //   | n o p |
            //
            //   | e g h |
            // b | i k l | = b ( e ( kp - lo ) - g ( ip - lm ) + h ( io - km ) )
            //   | m o p |
            //
            //   | e f h |
            // c | i j l | = c ( e ( jp - ln ) - f ( ip - lm ) + h ( in - jm ) )
            //   | m n p |
            //
            //   | e f g |
            // d | i j k | = d ( e ( jo - kn ) - f ( io - km ) + g ( in - jm ) )
            //   | m n o |
            //
            // Cost of operation
            // 17 adds and 28 muls.
            //
            // add: 6 + 8 + 3 = 17
            // mul: 12 + 16 = 28

            T a = M11, b = M12, c = M13, d = M14;
            T e = M21, f = M22, g = M23, h = M24;
            T i = M31, j = M32, k = M33, l = M34;
            T m = M41, n = M42, o = M43, p = M44;

            T kp_lo = Scalar.Subtract(Scalar.Multiply(k, p), Scalar.Multiply(l, o));
            T jp_ln = Scalar.Subtract(Scalar.Multiply(j, p), Scalar.Multiply(l, n));
            T jo_kn = Scalar.Subtract(Scalar.Multiply(j, o), Scalar.Multiply(k, n));
            T ip_lm = Scalar.Subtract(Scalar.Multiply(i, p), Scalar.Multiply(l, m));
            T io_km = Scalar.Subtract(Scalar.Multiply(i, o), Scalar.Multiply(k, m));
            T in_jm = Scalar.Subtract(Scalar.Multiply(i, n), Scalar.Multiply(j, m));

            return Scalar.Add(
                Scalar.Subtract(
                    Scalar.Multiply(a,
                        Scalar.Add(
                            Scalar.Subtract(Scalar.Multiply(f, kp_lo), Scalar.Multiply(g, jp_ln)),
                            Scalar.Multiply(h, jo_kn))),
                    Scalar.Multiply(b,
                        Scalar.Add(
                            Scalar.Subtract(Scalar.Multiply(e, kp_lo), Scalar.Multiply(g, ip_lm)),
                            Scalar.Multiply(h, io_km)))),
                Scalar.Subtract(
                    Scalar.Multiply(c,
                        Scalar.Add(
                            Scalar.Subtract(Scalar.Multiply(e, jp_ln), Scalar.Multiply(f, ip_lm)),
                            Scalar.Multiply(h, in_jm))),
                    Scalar.Multiply(d,
                        Scalar.Add(
                            Scalar.Subtract(Scalar.Multiply(e, jo_kn), Scalar.Multiply(f, io_km)),
                            Scalar.Multiply(g, in_jm)))));
        }

        /// <summary>
        /// Returns this matrix casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted matrix</returns>
        public Matrix4X4<TOther> As<TOther>() where TOther : INumberBase<TOther>
        {
            return new(Row1.As<TOther>(), Row2.As<TOther>(), Row3.As<TOther>(), Row4.As<TOther>());
        }
    }
}
