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
    public static unsafe partial class Simd256
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Divide<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
        {

            return Single(left, right);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Divide(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
                }
                
        
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> left, Vector256<T> right)
            {
                            var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Divide(GetElement(left, i), GetElement(right, i)));
                }

                return vec;
            }

        }
    }
}
#endif
