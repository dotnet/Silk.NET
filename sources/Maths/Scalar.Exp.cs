// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// ported / adopted from https://github.com/amd/aocl-libm-ose/tree/master/src/optmized

/*
 * Copyright (C) 2008-2020 Advanced Micro Devices, Inc. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 *    this list of conditions and the following disclaimer in the documentation
 *    and/or other materials provided with the distribution.
 * 3. Neither the name of the copyright holder nor the names of its contributors
 *    may be used to endorse or promote products derived from this software without
 *    specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA,
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 *
 */

using System;
using System.Runtime.CompilerServices;
#if SSE
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        private static ulong[] InitExp()
        {
#if POH
            var two_to_jby64 = GC.AllocateUninitializedArray<ulong>(64, true);
#else
            var two_to_jby64 = new ulong[64];
#endif
            int i = 0;
            two_to_jby64[i++] = 0x3ff0000000000000;
            two_to_jby64[i++] = 0x3fefec9a3e778061;
            two_to_jby64[i++] = 0x3fefd9b0d3158574;
            two_to_jby64[i++] = 0x3fefc74518759bc8;
            two_to_jby64[i++] = 0x3fefb5586cf9890f;
            two_to_jby64[i++] = 0x3fefa3ec32d3d1a2;
            two_to_jby64[i++] = 0x3fef9301d0125b51;
            two_to_jby64[i++] = 0x3fef829aaea92de0;
            two_to_jby64[i++] = 0x3fef72b83c7d517b;
            two_to_jby64[i++] = 0x3fef635beb6fcb75;
            two_to_jby64[i++] = 0x3fef54873168b9aa;
            two_to_jby64[i++] = 0x3fef463b88628cd6;
            two_to_jby64[i++] = 0x3fef387a6e756238;
            two_to_jby64[i++] = 0x3fef2b4565e27cdd;
            two_to_jby64[i++] = 0x3fef1e9df51fdee1;
            two_to_jby64[i++] = 0x3fef1285a6e4030b;
            two_to_jby64[i++] = 0x3fef06fe0a31b715;
            two_to_jby64[i++] = 0x3feefc08b26416ff;
            two_to_jby64[i++] = 0x3feef1a7373aa9cb;
            two_to_jby64[i++] = 0x3feee7db34e59ff7;
            two_to_jby64[i++] = 0x3feedea64c123422;
            two_to_jby64[i++] = 0x3feed60a21f72e2a;
            two_to_jby64[i++] = 0x3feece086061892d;
            two_to_jby64[i++] = 0x3feec6a2b5c13cd0;
            two_to_jby64[i++] = 0x3feebfdad5362a27;
            two_to_jby64[i++] = 0x3feeb9b2769d2ca7;
            two_to_jby64[i++] = 0x3feeb42b569d4f82;
            two_to_jby64[i++] = 0x3feeaf4736b527da;
            two_to_jby64[i++] = 0x3feeab07dd485429;
            two_to_jby64[i++] = 0x3feea76f15ad2148;
            two_to_jby64[i++] = 0x3feea47eb03a5585;
            two_to_jby64[i++] = 0x3feea23882552225;
            two_to_jby64[i++] = 0x3feea09e667f3bcd;
            two_to_jby64[i++] = 0x3fee9fb23c651a2f;
            two_to_jby64[i++] = 0x3fee9f75e8ec5f74;
            two_to_jby64[i++] = 0x3fee9feb564267c9;
            two_to_jby64[i++] = 0x3feea11473eb0187;
            two_to_jby64[i++] = 0x3feea2f336cf4e62;
            two_to_jby64[i++] = 0x3feea589994cce13;
            two_to_jby64[i++] = 0x3feea8d99b4492ed;
            two_to_jby64[i++] = 0x3feeace5422aa0db;
            two_to_jby64[i++] = 0x3feeb1ae99157736;
            two_to_jby64[i++] = 0x3feeb737b0cdc5e5;
            two_to_jby64[i++] = 0x3feebd829fde4e50;
            two_to_jby64[i++] = 0x3feec49182a3f090;
            two_to_jby64[i++] = 0x3feecc667b5de565;
            two_to_jby64[i++] = 0x3feed503b23e255d;
            two_to_jby64[i++] = 0x3feede6b5579fdbf;
            two_to_jby64[i++] = 0x3feee89f995ad3ad;
            two_to_jby64[i++] = 0x3feef3a2b84f15fb;
            two_to_jby64[i++] = 0x3feeff76f2fb5e47;
            two_to_jby64[i++] = 0x3fef0c1e904bc1d2;
            two_to_jby64[i++] = 0x3fef199bdd85529c;
            two_to_jby64[i++] = 0x3fef27f12e57d14b;
            two_to_jby64[i++] = 0x3fef3720dcef9069;
            two_to_jby64[i++] = 0x3fef472d4a07897c;
            two_to_jby64[i++] = 0x3fef5818dcfba487;
            two_to_jby64[i++] = 0x3fef69e603db3285;
            two_to_jby64[i++] = 0x3fef7c97337b9b5f;
            two_to_jby64[i++] = 0x3fef902ee78b3ff6;
            two_to_jby64[i++] = 0x3fefa4afa2a490da;
            two_to_jby64[i++] = 0x3fefba1bee615a27;
            two_to_jby64[i++] = 0x3fefd0765b6e4540;
            two_to_jby64[i++] = 0x3fefe7c1819e90d8;

            return two_to_jby64;
        }

        private static ulong[] __two_to_jby64 = InitExp();

        [MethodImpl(MaxOpt)]
        private static float CoreFastExp(float x)
        {
            [MethodImpl(MaxOpt)]
            static unsafe uint top12f(float x) => asuint32(x) >> 20;

            [MethodImpl(MaxOpt)]
            static unsafe uint asuint32(float x)
            {
#if SSE
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsUInt32().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
#endif
                return *(uint*) &x; // this produces bad codegen on < net5
            }

            [MethodImpl(MaxOpt)]
            static unsafe float asfloat(uint x)
            {
#if SSE
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsSingle().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
#endif
                return *(float*) &x; // this produces bad codegen on < net5
            }

            [MethodImpl(MaxOpt)]
            static unsafe ulong asuint64(double x)
            {
#if SSE
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsUInt64().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
#endif
                return *(ulong*) &x; // this produces bad codegen on < net5
            }

            [MethodImpl(MaxOpt)]
            static unsafe double asdouble(ulong x)
            {
#if SSE
                if (Sse.IsSupported)
                    return Vector128.CreateScalarUnsafe(x).AsDouble().ToScalar(); // ToScalar "relies" on Sse (the fallback is garbage)
                else
#endif
                return *(double*) &x; // this produces bad codegen on < net5
            }

            double q, dn, r, z;
            ulong n, j;

            uint top = top12f(x);

            if ((top <= top12f(88.0f))) // inverted for likeliness
            {
                goto ENDCHECK;
            }
            else
            {
                if (float.IsNaN(x))
                    return x;

                if (float.IsNegativeInfinity(x))
                    return 0.0f;

                const float EXPF_FARG_MAX = 3.5990256e+33f;
                // const int EXP_Y_INF = 3;
                // const int EXP_Y_ZERO = 2;
                const float EXPF_FARG_MIN = -103.972076416f;
                const uint PINFBITPATT_SP32 = 0x7f800000;

                if (x > EXPF_FARG_MAX)
                {
                    if (asuint32(x) == PINFBITPATT_SP32)
                        return asfloat(PINFBITPATT_SP32);

                    return float.PositiveInfinity;
                }

                if (x < EXPF_FARG_MIN)
                {
                    return 1f;
                }
            }

        ENDCHECK:
            const float EXPF_TBLSZ_BY_LN2 = 92.3324826169f;
            const float EXPF_HUGE = 6.7553994e+15f;
            const float EXPF_LN2_BY_TBLSZ = 0.01083042469f;
            const int EXPF_N = 6;
            const int EXPF_TABLE_SIZE = (1 << EXPF_N);
            z = x * EXPF_TBLSZ_BY_LN2;

            /*
             * n  = (int) scale(x)
             * dn = (double) n
             */
            dn = z + EXPF_HUGE;

            n = asuint64(dn);

            dn -= EXPF_HUGE;

            r = x - dn * EXPF_LN2_BY_TBLSZ;

            j = n % EXPF_TABLE_SIZE;

            double qtmp = 0.5f + (0.26567055393f * r);

            double r2 = r * r;

            double tbl = asdouble(__two_to_jby64[j] + (n << (52 - EXPF_N)));

            q = r + (r2 * qtmp);

            double result = tbl + tbl * q;

            return (float) (result);
        }
    }
}