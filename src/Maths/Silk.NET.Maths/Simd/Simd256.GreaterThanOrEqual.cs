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
        /// Performs hardware-accelerated GreaterThanOrEqual on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> GreaterThanOrEqual<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
        {
            return Single(left, right);            
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX && NET5_0_OR_GREATER
                    return Avx2.CompareGreaterThanOrEqual(left.AsSingle(), right.AsSingle()).As<float, T>();
#elif AVX
                    return Avx2.Compare(left.AsSingle(), right.AsSingle(), FloatComparisonMode.OrderedGreaterThanOrEqualSignaling).As<float, T>();
#endif
                }
        
                return Double(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(double))
                {
#if AVX && NET5_0_OR_GREATER
                    return Avx2.CompareGreaterThanOrEqual(left.AsDouble(), right.AsDouble()).As<double, T>();
#elif AVX
                    return Avx2.Compare(left.AsDouble(), right.AsDouble(), FloatComparisonMode.OrderedGreaterThanOrEqualSignaling).As<double, T>();
#endif
                }
        
                return OtherHWAccelerated(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> OtherHWAccelerated(Vector256<T> left, Vector256<T> right)
            {
                if (Simd128<T>.IsHardwareAccelerated)
                {   
#if AdvSIMD
                    var lower = Simd128.GreaterThanOrEqual(left.GetLower(), right.GetLower());
                    var upper = Simd128.GreaterThanOrEqual(left.GetUpper(), right.GetUpper());
                    // There's no generic Vector256.Create
                    return Vector256.Create(lower.AsByte(), upper.AsByte()).As<byte, T>();
#else
                    /*
                     
                    128 bit Avx2 doesn't have accelerated GreaterThanOrEqual
                    
                    */
                    return Not(LessThan(left, right));
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
                    vec = vec.WithElement(i, Scalar.GreaterThanOrEqual(left.GetElement(i), right.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
