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
        /// Performs hardware-accelerated Min on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Min<T>(Vector128<T> left, Vector128<T> right) where T : unmanaged
        {
            return Byte(left, right);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(byte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsByte(), right.AsByte()).As<byte, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd128.Add(left.AsByte(), Simd128<byte>.MaxValueOver2);
                        var rightShifted = Simd128.Add(right.AsByte(), Simd128<byte>.MaxValueOver2);
                        var res = Avx2.Min(leftShifted.AsSByte(), rightShifted.AsSByte());
                        return Avx2.Subtract(res.AsByte(), Simd128<byte>.MaxValueOver2).As<Byte, T>();
                    }
#endif
                }
        
                return SByte(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Min(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif
                }
        
                return UInt16(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt16(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsUInt16(), right.AsUInt16()).As<ushort, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd128.Add(left.AsUInt16(), Simd128<ushort>.MaxValueOver2);
                        var rightShifted = Simd128.Add(right.AsUInt16(), Simd128<ushort>.MaxValueOver2);
                        var res = Avx2.Min(leftShifted.AsInt16(), rightShifted.AsInt16());
                        return Avx2.Subtract(res.AsUInt16(), Simd128<ushort>.MaxValueOver2).As<UInt16, T>();
                    }
#endif
                }
        
                return Int16(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int16(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Min(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif
                }
        
                return UInt32(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt32(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(uint))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsUInt32(), right.AsUInt32()).As<uint, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd128.Add(left.AsUInt32(), Simd128<uint>.MaxValueOver2);
                        var rightShifted = Simd128.Add(right.AsUInt32(), Simd128<uint>.MaxValueOver2);
                        var res = Avx2.Min(leftShifted.AsInt32(), rightShifted.AsInt32());
                        return Avx2.Subtract(res.AsUInt32(), Simd128<uint>.MaxValueOver2).As<UInt32, T>();
                    }
#endif
                }
        
                return Int32(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int32(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Min(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif
                }
        
                return Single(left, right);
            }            

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Min(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Min(left.AsSingle(), right.AsSingle()).As<float, T>();
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
                        return Sse2.Min(left.AsDouble(), right.AsDouble()).As<double, T>();
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
                    vec.WithElement(i, Scalar.Min(left.GetElement(i), right.GetElement(i)));
                }
                return vec;
            }
        }
    }
}
#endif
