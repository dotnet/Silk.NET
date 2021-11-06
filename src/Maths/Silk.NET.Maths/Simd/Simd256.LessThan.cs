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
        /// <summary>
        /// Performs hardware-accelerated LessThan on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> LessThan<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
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
                        return Avx2.CompareLessThan(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
                }
        
                return Double(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(double))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.CompareLessThan(left.AsDouble(), right.AsDouble()).As<double, T>();
                    }
#endif
                }
        
                return OtherHWAccelerated(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> OtherHWAccelerated(Vector256<T> left, Vector256<T> right)
            {
                if (Simd256<T>.IsHardwareAccelerated)
                    return Not(GreaterThanOrEqual(left, right));
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> left, Vector256<T> right)
            {
                var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.LessThan(left.GetElement(i), right.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
