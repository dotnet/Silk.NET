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
        /// Performs hardware-accelerated LessThanOrEqual on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> LessThanOrEqual<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
        {
            return Single(left, right);            
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX && NET5_0_OR_GREATER
                    if (Avx2.IsSupported)
                    {
                        return Avx2.CompareLessThanOrEqual(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#elif AVX
                    if (Avx2.IsSupported)
                    {
                        var leftLow = *(Vector128<float>*)&left;
                        var leftHigh = *((Vector128<float>*)&left + 1);
                        var rightLow = *(Vector128<float>*)&right;
                        var rightHigh = *((Vector128<float>*)&right + 1);
                        Vector256<float> res;
                        *(Vector128<float>*)&res = Avx2.CompareLessThanOrEqual(leftLow, rightLow);
                        *((Vector128<float>*)&res + 1) = Avx2.CompareLessThanOrEqual(leftHigh, rightHigh);
                        return res.As<float, T>();
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
#if AVX && NET5_0_OR_GREATER
                    if (Avx2.IsSupported)
                    {
                        return Avx2.CompareLessThanOrEqual(left.AsDouble(), right.AsDouble()).As<double, T>();
                    }
#elif AVX
                    if (Avx2.IsSupported)
                    {
                        var leftLow = *(Vector128<double>*)&left;
                        var leftHigh = *((Vector128<double>*)&left + 1);
                        var rightLow = *(Vector128<double>*)&right;
                        var rightHigh = *((Vector128<double>*)&right + 1);
                        Vector256<double> res;
                        *(Vector128<double>*)&res = Avx2.CompareLessThanOrEqual(leftLow, rightLow);
                        *((Vector128<double>*)&res + 1) = Avx2.CompareLessThanOrEqual(leftHigh, rightHigh);
                        return res.As<double, T>();
                    }
#endif
                }
        
                return Integer(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Integer(Vector256<T> left, Vector256<T> right)
            {
                if (Simd256<T>.IsHardwareAccelerated)
                    return Or(LessThan(left, right), Equal(left, right));
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> left, Vector256<T> right)
            {
                var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.LessThanOrEqual(left.GetElement(i), right.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
