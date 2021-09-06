// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    partial class Scalar
    {
        ///////////////////////////////////////////////// BEGIN GO CODE ///////////////////////////////////////////////

        // Adapted from https://golang.org/src/math/atanh.go
        // ====================================================
        // Copyright 2010 The Go Authors. All rights reserved.
        // Use of this source code is governed by a BSD-style
        // license that can be found in the LICENSE file.
        // ====================================================
        // The original C code, the long comment, and the constants
        // below are from FreeBSD's /usr/src/lib/msun/src/e_atanh.c
        // and came with this notice. The go code is a simplified
        // version of the original C.
        // ====================================================
        // Copyright (C) 1993 by Sun Microsystems, Inc. All rights reserved.
        //
        // Developed at SunPro, a Sun Microsystems, Inc. business.
        // Permission to use, copy, modify, and distribute this
        // software is freely granted, provided that this notice
        // is preserved.
        // ====================================================
        [MethodImpl(MaxOpt)]
        private static double CoreAtanh(double x)
        {
            const double nearZero = 1.0 / (1 << 28); // 2**-28
            // special cases
            if (x < -1 || x > 1 || double.IsNaN(x))
            {
                return double.NaN;
            }

            switch (x)
            {
                case 1:
                    {
                        return double.PositiveInfinity;
                    }
                case -1:
                    {
                        return double.NegativeInfinity;
                    }
            }

            var sign = false;
            if (x < 0)
            {
                x = -x;
                sign = true;
            }

            double temp;
            if (x < nearZero)
            {
                temp = x;
            }
            else if (x < 0.5)
            {
                temp = x + x;
                temp = 0.5 * Log1P(temp + temp * x / (1 - x));
            }
            else
            {
                temp = 0.5 * Log1P((x + x) / (1 - x));
            }

            if (sign)
            {
                temp = -temp;
            }

            return temp;
        }

        // Adapted from: https://golang.org/src/math/log1p.go
        // ====================================================
        // Copyright 2010 The Go Authors. All rights reserved.
        // Use of this source code is governed by a BSD-style
        // license that can be found in the LICENSE file.
        // ====================================================
        // The original C code, the long comment, and the constants
        // below are from FreeBSD's /usr/src/lib/msun/src/s_log1p.c
        // and came with this notice. The go code is a simplified
        // version of the original C.
        // ====================================================
        // Copyright (C) 1993 by Sun Microsystems, Inc. All rights reserved.
        //
        // Developed at SunPro, a Sun Microsystems, Inc. business.
        // Permission to use, copy, modify, and distribute this
        // software is freely granted, provided that this notice
        // is preserved.
        // ====================================================

        [MethodImpl(MaxOpt)]
        private static unsafe double Log1P(double x)
        {
            const double sqrt2M1 = 4.142135623730950488017e-01; // Sqrt(2)-1 = 0x3fda827999fcef34
            const double sqrt2HalfM1 = -2.928932188134524755992e-01; // Sqrt(2)/2-1 = 0xbfd2bec333018866
            const double small = 1.0 / (1 << 29); // 2**-29 = 0x3e20000000000000
            const double tiny = 1.0 / (1L << 54); // 2**-54
            const double two53 = 1L << 53; // 2**53
            const double ln2Hi = 6.93147180369123816490e-01; // 3fe62e42fee00000
            const double ln2Lo = 1.90821492927058770002e-10; // 3dea39ef35793c76
            const double lp1 = 6.666666666666735130e-01; // 3FE5555555555593
            const double lp2 = 3.999999999940941908e-01; // 3FD999999997FA04
            const double lp3 = 2.857142874366239149e-01; // 3FD2492494229359
            const double lp4 = 2.222219843214978396e-01; // 3FCC71C51D8E78AF
            const double lp5 = 1.818357216161805012e-01; // 3FC7466496CB03DE
            const double lp6 = 1.531383769920937332e-01; // 3FC39A09D078C69F
            const double lp7 = 1.479819860511658591e-01; // 3FC2F112DF3E5244

            // special cases
            if (x < -1 || double.IsNaN(x))
            {
                // includes -Inf
                return double.NaN;
            }

            if (x == -1)
            {
                return double.NegativeInfinity;
            }

            if (double.IsPositiveInfinity(x))
            {
                return double.PositiveInfinity;
            }

            var absx = x;
            if (absx < 0)
            {
                absx = -absx;
            }

            double f = default;
            ulong iu = default;
            var k = 1;
            if (absx < sqrt2M1)
            {
                //  |x| < Sqrt(2)-1
                if (absx < small)
                {
                    // |x| < 2**-29
                    if (absx < tiny)
                    {
                        // |x| < 2**-54
                        return x;
                    }

                    return x - x * x * 0.5;
                }

                if (x > sqrt2HalfM1)
                {
                    // Sqrt(2)/2-1 < x
                    // (Sqrt(2)/2-1) < x < (Sqrt(2)-1)
                    k = 0;
                    f = x;
                    iu = 1;
                }
            }

            double c = default;
            if (k != 0)
            {
                double u;
                if (absx < two53)
                {
                    // 1<<53
                    u = 1.0 + x;
                    var ius = BitConverter.DoubleToInt64Bits(u);
                    iu = *(ulong*) &ius;
                    k = (int) ((iu >> 52) - 1023);
                    // correction term
                    if (k > 0)
                    {
                        c = 1.0 - (u - x);
                    }
                    else
                    {
                        c = x - (u - 1.0);
                    }

                    c /= u;
                }
                else
                {
                    u = x;
                    var ius = BitConverter.DoubleToInt64Bits(u);
                    iu = *(ulong*) &ius;
                    k = (int) ((iu >> 52) - 1023);
                    c = 0;
                }

                iu &= 0x000fffffffffffff;
                if (iu < 0x0006a09e667f3bcd)
                {
                    // mantissa of Sqrt(2)
                    var uu = iu | 0x3ff0000000000000;
                    u = BitConverter.Int64BitsToDouble(*(long*) &uu); // normalize u
                }
                else
                {
                    k++;
                    var uu = iu | 0x3fe0000000000000;
                    u = BitConverter.Int64BitsToDouble(*(long*) &uu); // normalize u/2
                    iu = (0x0010000000000000 - iu) >> 2;
                }

                f = u - 1.0; // Sqrt(2)/2 < u < Sqrt(2)
            }

            var hfsq = 0.5 * f * f;
            double s, r, z;
            if (iu == 0)
            {
                // |f| < 2**-20
                if (f == 0)
                {
                    if (k == 0)
                    {
                        return 0;
                    }

                    c += k * ln2Lo;
                    return k * ln2Hi + c;
                }

                r = hfsq * (1.0 - 0.66666666666666666 * f); // avoid division
                if (k == 0)
                {
                    return f - r;
                }

                return k * ln2Hi - (r - (k * ln2Lo + c) - f);
            }

            s = f / (2.0 + f);
            z = s * s;

            r = z * (lp1 + z * (lp2 + z * (lp3 + z * (lp4 + z * (lp5 + z * (lp6 + z * lp7))))));
            if (k == 0)
            {
                return f - (hfsq - s * (hfsq + r));
            }

            return k * ln2Hi - (hfsq - (s * (hfsq + r) + (k * ln2Lo + c)) - f);
        }

        // Adapted from: https://golang.org/src/math/acosh.go
        // ====================================================
        // Copyright 2010 The Go Authors. All rights reserved.
        // Use of this source code is governed by a BSD-style
        // license that can be found in the LICENSE file.
        // ====================================================
        // The original C code, the long comment, and the constants
        // below are from FreeBSD's /usr/src/lib/msun/src/e_acosh.c
        // and came with this notice. The go code is a simplified
        // version of the original C.
        // ====================================================
        // Copyright (C) 1993 by Sun Microsystems, Inc. All rights reserved.
        //
        // Developed at SunPro, a Sun Microsystems, Inc. business.
        // Permission to use, copy, modify, and distribute this
        // software is freely granted, provided that this notice
        // is preserved.
        // ====================================================
        [MethodImpl(MaxOpt)]
        private static double CoreAcosh(double x)
        {
            const double ln2 = 6.93147180559945286227e-01; // 0x3FE62E42FEFA39EF
            const double large = 1 << 28; // 2**28
            // first case is special case
            if (x < 1 || double.IsNaN(x))
            {
                return double.NaN;
            }

            if (x == 1)
            {
                return 0;
            }

            if (x >= large)
            {
                return Log(x) + ln2; // x > 2**28
            }

            if (x > 2)
            {
                return Log(2 * x - 1 / (x + Sqrt(x * x - 1))); // 2**28 > x > 2
            }

            var t = x - 1;
            return Log1P(t + Sqrt(2 * t + t * t)); // 2 >= x > 1
        }

        // Adapted from: https://golang.org/src/math/asinh.go
        // ====================================================
        // Copyright 2010 The Go Authors. All rights reserved.
        // Use of this source code is governed by a BSD-style
        // license that can be found in the LICENSE file.
        // ====================================================
        // The original C code, the long comment, and the constants
        // below are from FreeBSD's /usr/src/lib/msun/src/s_asinh.c
        // and came with this notice. The go code is a simplified
        // version of the original C.
        // ====================================================
        // Copyright (C) 1993 by Sun Microsystems, Inc. All rights reserved.
        //
        // Developed at SunPro, a Sun Microsystems, Inc. business.
        // Permission to use, copy, modify, and distribute this
        // software is freely granted, provided that this notice
        // is preserved.
        // ====================================================
        [MethodImpl(MaxOpt)]
        private static double CoreAsinh(double x)
        {
            const double ln2 = 6.93147180559945286227e-01; // 0x3FE62E42FEFA39EF
            const double nearZero = 1.0 / (1 << 28); // 2**-28
            const double large = 1 << 28; // 2**28
            // special cases
            if (IsNaN(x) || double.IsInfinity(x))
            {
                return x;
            }

            var sign = false;
            if (x < 0)
            {
                x = -x;
                sign = true;
            }

            double temp;
            if (x > large)
            {
                temp = Log(x) + ln2; // |x| > 2**28
            }
            else if (x > 2)
            {
                temp = Log(2 * x + 1 / (Sqrt(x * x + 1) + x)); // 2**28 > |x| > 2.0
            }
            else if (x < nearZero)
            {
                temp = x; // |x| < 2**-28
            }
            else
            {
                temp = Log1P(x + x * x / (1 + Sqrt(1 + x * x))); // 2.0 > |x| > 2**-28
            }

            if (sign)
            {
                temp = -temp;
            }

            return temp;
        }

        ////////////////////////////////////////////////// END GO CODE ////////////////////////////////////////////////

        [MethodImpl(MaxOpt)]
        private static double CoreCbrt(double x)
#if NETSTANDARD2_0
            => Math.Ceiling(Math.Pow(x, 1d / 3));
#else
            => Math.Cbrt(x);
#endif
    }
}