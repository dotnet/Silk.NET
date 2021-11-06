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
        /// Performs hardware-accelerated NotEqual on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> NotEqual<T>(Vector64<T> left, Vector64<T> right) where T : unmanaged
        {
            return OtherHWAccelerated(left, right);            
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> OtherHWAccelerated(Vector64<T> left, Vector64<T> right)
            {
                if (Simd64<T>.IsHardwareAccelerated)
                    return Not(Equal(left, right));
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> left, Vector64<T> right)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.NotEqual(left.GetElement(i), right.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
