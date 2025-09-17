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
            Row1 = new(value.M11, value.M12, T.Zero, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero, T.Zero);
            Row4 = new(value.M31, value.M32, T.Zero, T.One);
            Row3 = new(T.Zero, T.Zero, T.One, T.Zero);
        }

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix4X4(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13, T.Zero);
            Row2 = new(value.M21, value.M22, value.M23, T.Zero);
            Row3 = new(value.M31, value.M32, value.M33, T.Zero);
            Row4 = new(value.M41, value.M42, value.M43, T.One);
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
            Row1 = new(value.M11, value.M12, value.M13, T.Zero);
            Row2 = new(value.M21, value.M22, value.M23, T.Zero);
            Row4 = new(value.M31, value.M32, value.M33, T.One);
            Row3 = new(T.Zero, T.Zero, T.One, T.Zero);
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
            Row1 = new(value.M11, value.M12, T.Zero, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero, T.Zero);
            Row3 = new(value.M31, value.M32, T.One, T.Zero);
            Row4 = new(value.M41, value.M42, T.Zero, T.One);
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

            T a = Row1.X, b = Row1.Y, c = Row1.Z, d = Row1.W;
            T e = Row2.X, f = Row2.Y, g = Row2.Z, h = Row2.W;
            T i = Row3.X, j = Row3.Y, k = Row3.Z, l = Row3.W;
            T m = Row4.X, n = Row4.Y, o = Row4.Z, p = Row4.W;

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
    }
}
