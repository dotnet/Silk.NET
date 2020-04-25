// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#pragma warning disable CA1810

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using Silk.NET.Intrinsics.Avx;
using Silk.NET.Intrinsics.Software;
using Silk.NET.Intrinsics.Sse;

namespace Silk.NET.Intrinsics
{
    public static class Helpers
    {
        // ReSharper disable InconsistentNaming
        public static AvxRegister AVX { get; } = new AvxRegister();
        public static SseRegister SSE { get; } = new SseRegister();
        // TODO arm AdvSimd
        public static SoftwareRegister SoftwareFallbacks { get; } = new SoftwareRegister();

        public const MethodImplOptions MaxOpt =
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization; 
        // ReSharper restore InconsistentNaming
        public static unsafe bool Float<T>(T* inPtr, out float* outPtr) where T : unmanaged
        {
            if (*inPtr is float)
            {
                outPtr = (float*) inPtr;
                return true;
            }
            
            outPtr = default;
            return false;
        }

        public static unsafe bool Double<T>(T* inPtr, out double* outPtr) where T : unmanaged
        {
            if (*inPtr is double)
            {
                outPtr = (double*) inPtr;
                return true;
            }

            outPtr = default;
            return false;
        }

        public const float Pi = MathF.PI;
        public const float Pi2 = Pi * 2f;
        public const float PiDiv2 = Pi / 2;
        public const float OneDivPi = 1f / Pi;
        public const float OneDiv2Pi = 1f / Pi2;

        public static readonly Vector128<float> AbsConstant;
        public static readonly Vector128<float> SignConstant;
        public static readonly Vector128<float> OneF;

        public static readonly Vector128<float> Pi_Vec128;
        public static readonly Vector128<float> PiDiv2_Vec128;
        public static readonly Vector128<float> OneDiv2Pi_Vec128;
        public static readonly Vector128<float> Pi2_Vec128;

        static Helpers()
        {
            AbsConstant = Vector128.Create(int.MaxValue).AsSingle();
            SignConstant = Vector128.Create(int.MinValue).AsSingle();
            OneF = Vector128.Create(1f);

            Pi_Vec128 = Vector128.Create(Pi);
            PiDiv2_Vec128 = Vector128.Create(PiDiv2);
            OneDiv2Pi_Vec128 = Vector128.Create(OneDiv2Pi);
            Pi2_Vec128 = Vector128.Create(Pi2);
        }



        [MethodImpl(MaxOpt)]
        public static Vector128<float> Mod2Pi(Vector128<float> value)
        {
            var result = Sse2.Multiply(value, OneDiv2Pi_Vec128);
            
            if (Sse41.IsSupported)
            {
                result = Sse41.RoundToNearestInteger(result);
            }
            else //TODO: Verify this has the same results
            {
                var tmp = Sse2.ConvertToVector128Int32(result); //SSE2 guarenteed to be available
                result = Sse2.ConvertToVector128Single(tmp);
            }

            result = Sse2.Multiply(result, Pi2_Vec128);

            return Sse2.Subtract(value, result);
        }

        [MethodImpl(MaxOpt)]
        public static Vector128<float> ExtractSign(Vector128<float> value)
        {
            return Sse2.And(value, SignConstant);
        }

        [MethodImpl(MaxOpt)]
        public static Vector128<float> Select(Vector128<float> value0, Vector128<float> value1, Vector128<float> comp)
        {
            if (Sse41.IsSupported)
            {
                return Sse41.BlendVariable(value0, value1, comp);
            }
            else
            {
                var tmp0 = Sse2.And(comp, value1);
                var tmp1 = Sse2.AndNot(comp, value0);
                return Sse2.Or(tmp0, tmp1);
            }
        }

        private static readonly Vector128<float> SinCoefficient0 = Vector128.Create(-0.16666667f, +0.0083333310f, -0.00019840874f, +2.7525562e-06f);
        private static readonly Vector128<float> SinCoefficient1 = Vector128.Create(-2.3889859e-08f, -0.16665852f, +0.0083139502f, -0.00018524670f);
        private const float SinCoefficient1Scalar = -2.3889859e-08f;
        private static readonly Vector128<float> SinCoefficient1Broadcast = Vector128.Create(SinCoefficient1Scalar);

        public static Vector128<float> Sin(Vector128<float> input)
        {
            var vec = Mod2Pi(input);

            var sign = ExtractSign(vec);

            var signPi = Sse2.Or(sign, Pi_Vec128);

            var abs = Sse2.AndNot(sign, vec);

            var neg = Sse2.Subtract(signPi, vec);

            var comp = Sse2.CompareLessThanOrEqual(abs, PiDiv2_Vec128);

            vec = Select(neg, vec, comp);

            var vecSquared = Sse2.Multiply(vec, vec);

            // Polynomial approx
            Vector128<float> sc0 = SinCoefficient0;

            Vector128<float> constants = SinCoefficient1Broadcast;
            Vector128<float> result = MultiplyAdd(constants, vecSquared, Sse2.Shuffle(sc0, sc0, 0b_11_11_11_11)/*Fill with W*/);

            constants = Sse2.Shuffle(sc0, sc0, 0b_10_10_10_10); //Fill with Z
            result = MultiplyAdd(result, vecSquared, constants);

            constants = Sse2.Shuffle(sc0, sc0, 0b_01_01_01_01); //Fill with Y
            result = MultiplyAdd(result, vecSquared, constants);

            constants = Sse2.Shuffle(sc0, sc0, 0b_00_00_00_00); //Fill with X
            result = MultiplyAdd(result, vecSquared, constants);

            result = MultiplyAdd(result, vecSquared, OneF);

            return Sse2.Multiply(result, vec);
        }

        public static Vector128<float> MultiplyAdd(Vector128<float> a, Vector128<float> b, Vector128<float> c)
        {
            if (Fma.IsSupported)
            {
                return Fma.MultiplyAdd(a, b, c);
            }

            return Sse2.Add(Sse2.Multiply(a, b), c);
        }

    }
}
