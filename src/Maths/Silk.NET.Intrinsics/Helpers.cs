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
        public static SoftwareRegister SoftwareFallbacks { get; } = new SoftwareRegister();

        public const MethodImplOptions MaxOpt =
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization; 
        // ReSharper restore InconsistentNaming

        public static unsafe bool Double<T>(WorkUnit<T>* @in, out WorkUnit256<double>* @out) where T : unmanaged
        {
            @out = null;
            var flags = @in->Flags;
            if ((flags & WorkUnitFlags.Vector256) != 0 && (flags & WorkUnitFlags.TypeDouble) != 0)
            {
                @out = (WorkUnit256<double>*) @in;
            }

            return @out != null;
        }
        public static unsafe bool Float<T>(WorkUnit<T>* @in, out WorkUnit128<float>* @out) where T : unmanaged
        {
            @out = null;
            var flags = @in->Flags;
            if ((flags & WorkUnitFlags.Vector128) != 0 && (flags & WorkUnitFlags.TypeFloat) != 0)
            {
                @out = (WorkUnit128<float>*) @in;
            }

            return @out != null;
        }

        public static unsafe bool IsSseAny(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSseAll) != 0;
        public static unsafe bool IsAvxAny(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterAvxAll) != 0;
        public static unsafe bool IsSse(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse) != WorkUnitFlags.RegisterSse;
        public static unsafe bool IsSseX64(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSseX64) != WorkUnitFlags.RegisterSseX64;
        public static unsafe bool IsSse2(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse2) != WorkUnitFlags.RegisterSse2;
        public static unsafe bool IsSse2X64(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse2X64) != WorkUnitFlags.RegisterSse2X64;
        public static unsafe bool IsSse3(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse3) != WorkUnitFlags.RegisterSse3;
        public static unsafe bool IsSse41(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse41) != WorkUnitFlags.RegisterSse41;
        public static unsafe bool IsSse41X64(WorkUnit128<float>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse41X64) != WorkUnitFlags.RegisterSse41X64;
        public static unsafe bool IsSseAny(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSseAll) != 0;
        public static unsafe bool IsAvxAny(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterAvxAll) != 0;
        public static unsafe bool IsSse(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse) != WorkUnitFlags.RegisterSse;
        public static unsafe bool IsSseX64(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSseX64) != WorkUnitFlags.RegisterSseX64;
        public static unsafe bool IsSse2(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse2) != WorkUnitFlags.RegisterSse2;
        public static unsafe bool IsSse2X64(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse2X64) != WorkUnitFlags.RegisterSse2X64;
        public static unsafe bool IsSse3(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse3) != WorkUnitFlags.RegisterSse3;
        public static unsafe bool IsSse41(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse41) != WorkUnitFlags.RegisterSse41;
        public static unsafe bool IsSse41X64(WorkUnit256<double>* vec) => (vec->Flags & WorkUnitFlags.RegisterSse41X64) != WorkUnitFlags.RegisterSse41X64;
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
    }
}
