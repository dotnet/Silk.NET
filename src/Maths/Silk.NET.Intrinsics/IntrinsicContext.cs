// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.Intrinsics.X86;
using Silk.NET.Core.Platform;
using static Silk.NET.Intrinsics.Helpers;

namespace Silk.NET.Intrinsics
{
    public class IntrinsicContext<T> where T:unmanaged
    {
        public static WorkUnitFlags CurrentContext { get; } = GetCurrentContext();
        public static IRegister<T> CustomRegister { get; } = SilkManager.GetOrDefault<IRegister<T>>();

        private static WorkUnitFlags GetCurrentContext()
        {
            var flags = (WorkUnitFlags)0;
            if (System.Runtime.Intrinsics.X86.Avx.IsSupported)
            {
                flags |= WorkUnitFlags.RegisterAvx;
            }

            if (Avx2.IsSupported)
            {
                flags |= WorkUnitFlags.RegisterAvx2;
            }

            if (Sse41.IsSupported)
            {
                flags |= WorkUnitFlags.RegisterSse41;
            }

            flags |= WorkUnitFlags.RegisterSoftware;
        }

        public static unsafe WorkUnit<T>* LoadScalar(T* ptr)
        {
            if (Float(ptr, out var floatPtr))
            {
                if ((CurrentContext & WorkUnitFlags.RegisterAvx) != 0)
                {
                    return (WorkUnit<T>*) AVX.ToScalar(floatPtr);
                }
            }
            
            if (Double(ptr, out var doublePtr))
            {
                if ((CurrentContext & WorkUnitFlags.RegisterAvx) != 0)
                {
                    return (WorkUnit<T>*) AVX.ToScalar(doublePtr);
                }
            }
            
            return 
        }
    }
}
