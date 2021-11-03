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
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Divide<T>(Vector128<T> left, Vector128<T> right) where T : unmanaged
        {

            return Single(left, right);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Divide(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Divide(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
                }
                
        
                return Double(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Divide(left.AsDouble(), right.AsDouble()).As<double, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Divide(left.AsDouble(), right.AsDouble()).As<double, T>();
                    }
#endif
                }
                
        
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> left, Vector128<T> right)
            {
            
                var vec = Vector128<T>.Zero;
                for (int i = 0; i < Vector128<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Divide(GetElement(left, i), GetElement(right, i)));
                }

                return vec;
            }

        }
    }
}
#endif
