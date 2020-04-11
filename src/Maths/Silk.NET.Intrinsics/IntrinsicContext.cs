// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using Silk.NET.Core.Platform;
using static Silk.NET.Intrinsics.Helpers;

namespace Silk.NET.Intrinsics
{
    public partial class IntrinsicContext<T> where T:unmanaged
    {
        public static WorkUnitFlags CurrentContext { get; } = GetCurrentContext();
        public static IRegister<T> CustomRegister { get; } = SilkManager.GetOrDefault<IRegister<T>>();

        private static WorkUnitFlags GetCurrentContext()
        {
            var flags = (WorkUnitFlags)0;
            flags |= System.Runtime.Intrinsics.X86.Avx.IsSupported ? WorkUnitFlags.RegisterAvx : 0;
            flags |= Avx2.IsSupported ? WorkUnitFlags.RegisterAvx2 : 0;
            flags |= System.Runtime.Intrinsics.X86.Sse.IsSupported ? WorkUnitFlags.RegisterSse : 0;
            flags |= System.Runtime.Intrinsics.X86.Sse.X64.IsSupported ? WorkUnitFlags.RegisterSseX64 : 0;
            flags |= Sse2.IsSupported ? WorkUnitFlags.RegisterSse2 : 0;
            flags |= Sse2.X64.IsSupported ? WorkUnitFlags.RegisterSse2X64 : 0;
            flags |= Sse3.IsSupported ? WorkUnitFlags.RegisterSse3 : 0;
            flags |= Sse41.IsSupported ? WorkUnitFlags.RegisterSse41 : 0;
            flags |= Sse41.X64.IsSupported ? WorkUnitFlags.RegisterSse41X64 : 0;
            flags |= Ssse3.IsSupported ? WorkUnitFlags.RegisterSsse3 : 0;
            flags |= AdvSimd.IsSupported ? WorkUnitFlags.RegisterArm : 0;
            flags |= WorkUnitFlags.RegisterSoftware;
            return flags;
        }

        public static unsafe WorkUnit<T>* LoadScalar(T* ptr)
        {
            if (Float(ptr, out var floatPtr))
            {
                if ((CurrentContext & WorkUnitFlags.RegisterAvxAll) != 0)
                {
                    return (WorkUnit<T>*) AVX.ToScalar(floatPtr);
                }
                if ((CurrentContext & WorkUnitFlags.RegisterSseAll) != 0)
                {
                    return (WorkUnit<T>*) SSE.ToScalar(floatPtr);
                }

                return (WorkUnit<T>*) SoftwareFallbacks.ToScalar(floatPtr);
            }
            
            if (Double(ptr, out var doublePtr))
            {
                if ((CurrentContext & WorkUnitFlags.RegisterAvxAll) != 0)
                {
                    return (WorkUnit<T>*) AVX.ToScalar(doublePtr);
                }
                if ((CurrentContext & WorkUnitFlags.RegisterSseAll) != 0)
                {
                    return (WorkUnit<T>*) SSE.ToScalar(doublePtr);
                }

                return (WorkUnit<T>*) SoftwareFallbacks.ToScalar(doublePtr);
            }
            
            // TODO half(?), int, uint, long, ulong, short, ushort

            if (!(CustomRegister is null))
            {
                return CustomRegister.ToScalar(ptr);
            }
            
            throw new NotSupportedException();
        }
    }
}
