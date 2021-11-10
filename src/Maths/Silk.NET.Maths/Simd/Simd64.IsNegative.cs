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
        /// Performs hardware-accelerated IsNegative on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> IsNegative<T>(Vector64<T> vector) where T : unmanaged
        {
            return Single(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(Vector64<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return LessThan(vector.AsInt32(), Simd64<int>.Zero).As<int, T>();
                }

                return Double(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(Vector64<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return LessThan(vector.AsInt64(), Simd64<long>.Zero).As<long, T>();
                }
                
                return Other(vector);
            }
            
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> vector)
            {
                return LessThan(vector, Simd64<T>.Zero);
            }
        }
    }
}
#endif
