// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    public partial struct Matrix4X4<T>
    {
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

            T kp_lo = (k * p) - (l * o);
            T jp_ln = (j * p) - (l * n);
            T jo_kn = (j * o) - (k * n);
            T ip_lm = (i * p) - (l * m);
            T io_km = (i * o) - (k * m);
            T in_jm = (i * n) - (j * m);

            return (a * ((f * kp_lo) - (g * jp_ln) + (h * jo_kn)))
                 - (b * ((e * kp_lo) - (g * ip_lm) + (h * io_km)))
                 + (c * ((e * jp_ln) - (f * ip_lm) + (h * in_jm)))
                 - (d * ((e * jo_kn) - (f * io_km) + (g * in_jm)));
        }
    }
}
