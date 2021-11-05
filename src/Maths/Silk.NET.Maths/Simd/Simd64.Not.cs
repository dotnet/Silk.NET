// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif

namespace Silk.NET.Maths
{
    public static unsafe partial class Simd64
    {
        /// <summary>
        /// Performs hardware-accelerated Not on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Not<T>(Vector64<T> vector) where T : unmanaged
        {
            if (Simd64<T>.IsHardwareAccelerated)
                return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                
            return Other(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> vector)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.Not(vector.GetElement(i)));
                }
                return vec;
            }
        }
    }
}
#endif
