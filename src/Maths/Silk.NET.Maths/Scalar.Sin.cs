// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    static partial class Scalar
    {
        //
        // See https://gist.github.com/tannergooding/103be726d48dc3d0b09e890bad0b892f
        //
        // This is a port of the amd/win-libm implementation provided in assembly here: https://github.com/amd/win-libm/blob/master/sinf.asm
        // The original source is Copyright (c) 2002-2019 Advanced Micro Devices, Inc. and provided under the MIT License.
        //
        // Permission is hereby granted, free of charge, to any person obtaining a copy
        // of this Software and associated documentaon files (the "Software"), to deal
        // in the Software without restriction, including without limitation the rights
        // to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        // copies of the Software, and to permit persons to whom the Software is
        // furnished to do so, subject to the following conditions:
        // 
        // The above copyright notice and this permission notice shall be included in
        // all copies or substantial portions of the Software.
        // 
        // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
        // IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
        // FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
        // AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
        // LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
        // OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
        // THE SOFTWARE.

        private static readonly long[] _piBits =
        {
            0,
            5215,
            13000023176,
            11362338026,
            67174558139,
            34819822259,
            10612056195,
            67816420731,
            57840157550,
            19558516809,
            50025467026,
            25186875954,
            18152700886
        };

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static long GetPiBits(int index)
        {
            switch (index)
            {
                case 0:
                    return 0;
                case 1:
                    return 5215;
                case 2:
                    return 13000023176;
                case 3:
                    return 11362338026;
                case 4:
                    return 67174558139;
                case 5:
                    return 34819822259;
                case 6:
                    return 10612056195;
                case 7:
                    return 67816420731;
                case 8:
                    return 57840157550;
                case 9:
                    return 19558516809;
                case 10:
                    return 50025467026;
                case 11:
                    return 25186875954;
                case 12:
                    return 18152700886;
                default:
                    ThrowIndexOutOfRange();
                    return default;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        internal static float Sin_Ported(float x)
        {
            const double PiOverTwo = 1.5707963267948966;
            const double PiOverTwoPartOne = 1.5707963267341256;
            const double PiOverTwoPartOneTail = 6.077100506506192E-11;
            const double PiOverTwoPartTwo = 6.077100506303966E-11;
            const double PiOverTwoPartTwoTail = 2.0222662487959506E-21;
            const double PiOverFour = 0.7853981633974483;
            const double TwoOverPi = 0.6366197723675814;
            const double TwoPowNegSeven = 0.0078125;
            const double TwoPowNegThirteen = 0.0001220703125;
            const double C0 = -1.0 / 2.0; // 1 / 2!
            const double C1 = +1.0 / 24.0; // 1 / 4!
            const double C2 = -1.0 / 720.0; // 1 / 6!
            const double C3 = +1.0 / 40320.0; // 1 / 8!
            const double C4 = -1.0 / 3628800.0; // 1 / 10!
            const double S1 = -1.0 / 6.0; // 1 / 3!
            const double S2 = +1.0 / 120.0; // 1 / 5!
            const double S3 = -1.0 / 5040.0; // 1 / 7!
            const double S4 = +1.0 / 362880.0; // 1 / 9!


            if (CoreIsFinite(x))
            {
                double ax = Math.Abs(x);

                double result;
                if (ax <= PiOverFour)
                {
                    if (ax >= TwoPowNegSeven)
                    {
                        result = SinTaylorSeriesFourIterations(x);
                    }
                    else if (ax >= TwoPowNegThirteen)
                    {
                        result = SinTaylorSeriesOneIteration(x);
                    }
                    else
                    {
                        result = x;
                    }
                }
                else
                {
                    var wasNegative = 0;

                    if (CoreIsNegative(x))
                    {
                        x = -x;
                        wasNegative = 1;
                    }

                    int region;

                    if (x < 16000000.0)
                    {
                        // Reduce x to be in the range of -(PI / 4) to (PI / 4), inclusive

                        // This is done by subtracting multiples of (PI / 2). Double-precision
                        // isn't quite accurate enough and introduces some error, but we account
                        // for that using a tail value that helps account for this.

                        var axExp = BitConverter.DoubleToInt64Bits(ax) >> 52;

                        region = (int) (x * TwoOverPi + 0.5);
                        double piOverTwoCount = region;

                        var rHead = x - (piOverTwoCount * PiOverTwoPartOne);
                        var rTail = (piOverTwoCount * PiOverTwoPartOneTail);

                        var r = rHead - rTail;
                        var rExp = (BitConverter.DoubleToInt64Bits(r) << 1) >> 53;

                        if ((axExp - rExp) > 15)
                        {
                            // The remainder is pretty small compared with x, which implies that x is
                            // near a multiple of (PI / 2). That is, x matches the multiple to at least
                            // 15 bits and so we perform an additional fixup to account for any error

                            r = rHead;

                            rTail = (piOverTwoCount * PiOverTwoPartTwo);
                            rHead = r - rTail;
                            rTail = (piOverTwoCount * PiOverTwoPartTwoTail) - ((r - rHead) - rTail);

                            r = rHead - rTail;
                        }

                        if (rExp >= 0x3F2) // r >= 2^-13
                        {
                            result = (region & 1) == 0
                                ? SinTaylorSeriesFourIterations(r) // region 0 or 2
                                : CosTaylorSeriesFourIterations(r); // region 1 or 3
                        }
                        else if (rExp > 0x3DE) // r > 1.1641532182693481E-10
                        {
                            result = (region & 1) == 0
                                ? SinTaylorSeriesOneIteration(r) // region 0 or 2
                                : CosTaylorSeriesOneIteration(r); // region 1 or 3
                        }
                        else
                        {
                            if ((region & 1) == 0) // region 0 or 2
                            {
                                result = r;
                            }
                            else // region 1 or 3
                            {
                                result = 1;
                            }
                        }
                    }
                    else
                    {
                        var r = ReduceForLargeInput(x, out region);

                        result = (region & 1) == 0
                            ? SinTaylorSeriesFourIterations(r) // region 0 or 2
                            : CosTaylorSeriesFourIterations(r);// region 1 or 3
                    }

                    region >>= 1;

                    var tmp1 = region & wasNegative;

                    region = ~region;
                    wasNegative = ~wasNegative;

                    var tmp2 = region & wasNegative;

                    if (((tmp1 | tmp2) & 1) == 0)
                    {
                        // If the original region was 0/1 and arg is negative, then we negate the result.
                        // -or-
                        // If the original region was 2/3 and arg is positive, then we negate the result.

                        result = -result;
                    }
                }

                return (float) result;
            }

            // modified to raise NaN on infinite 
            return float.NaN;

            [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
            static double CosTaylorSeriesOneIteration(double x1)
            {
                // 1 - (x^2 / 2!)
                var x2 = x1 * x1;
                return 1.0 + (x2 * C1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
            static double CosTaylorSeriesFourIterations(double x1)
            {
                // 1 - (x^2 / 2!) + (x^4 / 4!) - (x^6 / 6!) + (x^8 / 8!) - (x^10 / 10!)

                var x2 = x1 * x1;
                var x4 = x2 * x2;

                return 1.0 + (x2 * C0) + (x4 * ((C1 + (x2 * C2)) + (x4 * (C3 + (x2 * C4)))));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
            static unsafe double ReduceForLargeInput(double x, out int region)
            {
                Debug.Assert(!CoreIsNegative(x));

                // This method simulates multi-precision floating-point
                // arithmetic and is accurate for all 1 <= x < infinity

                const int bitsPerIteration = 36;
                var ux = BitConverter.DoubleToInt64Bits(x);

                var xExp = (int) (((ux & 0x7FF0000000000000) >> 52) - 1023);
                ux = ((ux & 0x000FFFFFFFFFFFFF) | 0x0010000000000000) >> 29;

                // Now ux is the mantissa bit pattern of x as a long integer
                long mask = 1;
                mask = (mask << bitsPerIteration) - 1;

                // Set first and last to the positions of the first and last chunks of (2 / PI) that we need
                var first = xExp / bitsPerIteration;
                var resultExp = xExp - (first * bitsPerIteration);

                // 120 is the theoretical maximum number of bits (actually
                // 115 for IEEE single precision) that we need to extract
                // from the middle of (2 / PI) to compute the reduced argument
                // accurately enough for our purposes

                var last = first + (120 / bitsPerIteration);

                // Unroll the loop. This is only correct because we know that bitsper is fixed as 36.

                var result = stackalloc long[10];

                result[4] = 0;
                var u = _piBits[last] * ux;

                result[3] = u & mask;
                var carry = u >> bitsPerIteration;
                u = _piBits[last - 1] * ux + carry;

                result[2] = u & mask;
                carry = u >> bitsPerIteration;
                u = _piBits[last - 2] * ux + carry;

                result[1] = u & mask;
                carry = u >> bitsPerIteration;
                u = _piBits[first] * ux + carry;

                result[0] = u & mask;

                // Reconstruct the result
                var ltb = (int) ((((result[0] << bitsPerIteration) | result[1]) >> (bitsPerIteration - 1 - resultExp)) &
                                 7);

                long mantissa;
                long nextBits;

                // determ says whether the fractional part is >= 0.5
                var determ = (ltb & 1) != 0;

                var i = 1;

                if (determ)
                {
                    // The mantissa is >= 0.5. We want to subtract it from 1.0 by negating all the bits
                    region = ((ltb >> 1) + 1) & 3;

                    mantissa = 1;
                    mantissa = ~(result[1]) & ((mantissa << (bitsPerIteration - resultExp)) - 1);

                    while (mantissa < 0x0000000000010000)
                    {
                        i++;
                        mantissa = (mantissa << bitsPerIteration) | (~(result[i]) & mask);
                    }

                    nextBits = (~(result[i + 1]) & mask);
                }
                else
                {
                    region = (ltb >> 1);

                    mantissa = 1;
                    mantissa = result[1] & ((mantissa << (bitsPerIteration - resultExp)) - 1);

                    while (mantissa < 0x0000000000010000)
                    {
                        i++;
                        mantissa = (mantissa << bitsPerIteration) | result[i];
                    }

                    nextBits = result[i + 1];
                }

                // Normalize the mantissa.
                // The shift value 6 here, determined by trial and error, seems to give optimal speed.

                var bc = 0;

                while (mantissa < 0x0000400000000000)
                {
                    bc += 6;
                    mantissa <<= 6;
                }

                while (mantissa < 0x0010000000000000)
                {
                    bc++;
                    mantissa <<= 1;
                }

                mantissa |= nextBits >> (bitsPerIteration - bc);

                var rExp = 52 + resultExp - bc - i * bitsPerIteration;

                // Put the result exponent rexp onto the mantissa pattern
                u = (rExp + 1023L) << 52;
                ux = (mantissa & 0x000FFFFFFFFFFFFF) | u;

                if (determ)
                {
                    // If we negated the mantissa we negate x too
                    ux |= unchecked((long) (0x8000000000000000));
                }

                x = BitConverter.Int64BitsToDouble(ux);

                // x is a double precision version of the fractional part of
                // (x * (2 / PI)). Multiply x by (PI / 2) in double precision
                // to get the reduced result.

                return x * PiOverTwo;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
            static double SinTaylorSeriesOneIteration(double x1)
            {
                // x - (x^3 / 3!)

                var x2 = x1 * x1;
                var x3 = x2 * x1;

                return x1 + (x3 * S1);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
            static double SinTaylorSeriesFourIterations(double x1)
            {
                // x - (x^3 / 3!) + (x^5 / 5!) - (x^7 / 7!) + (x^9 / 9!)

                var x2 = x1 * x1;
                var x3 = x2 * x1;
                var x4 = x2 * x2;

                return x1 + ((S1 + (x2 * S2) + (x4 * (S3 + (x2 * S4)))) * x3);
            }
        }

#if NET5_0
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsNegative(double d) => BitConverter.DoubleToInt64Bits(d) < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static unsafe bool CoreIsNegative(float f) => *(int*) &f < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static unsafe bool CoreIsFinite(float f) => (*(int*) &f & 0x7FFFFFFF) < 0x7F800000;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static unsafe bool CoreIsSubnormal(float f)
        {
            var bits = *(int*) &f;
            bits &= 0x7FFFFFFF;
            return (bits < 0x7F800000) && (bits != 0) && ((bits & 0x7F800000) == 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsSubnormal(double f)
        {
            var bits = BitConverter.DoubleToInt64Bits(f);
            bits &= 0x7FFFFFFFFFFFFFFF;
            return (bits < 0x7FF0000000000000) && (bits != 0) && ((bits & 0x7FF0000000000000) == 0);
        }
#else
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsNegative(double d) => BitConverter.DoubleToInt64Bits(d) < 0;

        // ripped straight from BitConverter on > NetStandard2.1.
        // in fact, everything below is ripped from methods on NetStandard2.1, but which aren't available on NetStandard2.0
        private static unsafe int SingleToInt(float f)
        {
            return *((int*) &f);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsNegative(float f)
        {
            // FUCK I HATE NETSTANDARD
            return SingleToInt(f) < 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsFinite(float f) => ((SingleToInt(f)) & 0x7FFFFFFF) < 0x7F800000;

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsSubnormal(float f)
        {
            var bits = SingleToInt(f);
            bits &= 0x7FFFFFFF;
            return (bits < 0x7F800000) && (bits != 0) && ((bits & 0x7F800000) == 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        private static bool CoreIsSubnormal(double f)
        {
            long bits = BitConverter.DoubleToInt64Bits(f);
            bits &= 0x7FFFFFFFFFFFFFFF;
            return (bits < 0x7FF0000000000000) && (bits != 0) && ((bits & 0x7FF0000000000000) == 0);
        }
#endif
    }
}