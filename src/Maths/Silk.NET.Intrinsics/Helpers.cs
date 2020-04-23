// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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

        public static readonly Vector128<float> AbsConstant;
        public static readonly Vector128<float> NegateConstant;

        static Helpers()
        {
            AbsConstant = Vector128.Create(int.MaxValue).AsSingle();
            NegateConstant = Vector128.Create(int.MinValue).AsSingle();
        }
    }
}
