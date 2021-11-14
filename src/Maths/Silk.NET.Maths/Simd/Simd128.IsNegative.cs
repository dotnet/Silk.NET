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
    public static unsafe partial class Simd128
    {
        /// <summary>
        /// Performs hardware-accelerated IsNegative on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> IsNegative<T>(Vector128<T> vector) where T : unmanaged
        {
            return Single(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return LessThan(vector.AsInt32(), Simd128<int>.Zero).As<int, T>();
                }

                return Double(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return LessThan(vector.AsInt64(), Simd128<long>.Zero).As<long, T>();
                }
                
                return Other(vector);
            }
            
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> vector)
            {
                return LessThan(vector, Simd128<T>.Zero);
            }
        }
    }
}
#endif
