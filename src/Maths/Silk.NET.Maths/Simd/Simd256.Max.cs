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
        /// Performs hardware-accelerated Max on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Max<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
        {
            return Byte(left, right);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Byte(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(byte))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd256.Add(left.AsByte(), Simd256<byte>.MaxValueOver2);
                        var rightShifted = Simd256.Add(right.AsByte(), Simd256<byte>.MaxValueOver2);
                        var res = Avx2.Max(leftShifted.AsSByte(), rightShifted.AsSByte());
                        return Avx2.Subtract(res.AsByte(), Simd256<byte>.MaxValueOver2).As<Byte, T>();
                    }
#endif
                }
        
                return SByte(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Max(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif
                }
        
                return UInt16(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd256.Add(left.AsUInt16(), Simd256<ushort>.MaxValueOver2);
                        var rightShifted = Simd256.Add(right.AsUInt16(), Simd256<ushort>.MaxValueOver2);
                        var res = Avx2.Max(leftShifted.AsInt16(), rightShifted.AsInt16());
                        return Avx2.Subtract(res.AsUInt16(), Simd256<ushort>.MaxValueOver2).As<UInt16, T>();
                    }
#endif
                }
        
                return Int16(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(short))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Max(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif
                }
        
                return UInt32(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(uint))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd256.Add(left.AsUInt32(), Simd256<uint>.MaxValueOver2);
                        var rightShifted = Simd256.Add(right.AsUInt32(), Simd256<uint>.MaxValueOver2);
                        var res = Avx2.Max(leftShifted.AsInt32(), rightShifted.AsInt32());
                        return Avx2.Subtract(res.AsUInt32(), Simd256<uint>.MaxValueOver2).As<UInt32, T>();
                    }
#endif
                }
        
                return Int32(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(int))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Max(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif
                }
        
                return UInt64(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(ulong))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        var leftShifted = Simd256.Add(left.AsUInt64(), Simd256<ulong>.MaxValueOver2);
                        var rightShifted = Simd256.Add(right.AsUInt64(), Simd256<ulong>.MaxValueOver2);
                        var res = Avx2.Max(leftShifted.AsInt64(), rightShifted.AsInt64());
                        return Avx2.Subtract(res.AsUInt64(), Simd256<ulong>.MaxValueOver2).As<UInt64, T>();
                    }
#endif
                }
        
                return Int64(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int64(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(long))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Max(left.AsInt64(), right.AsInt64()).As<long, T>();
                    }
#endif
                }
        
                return Single(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Max(left.AsSingle(), right.AsSingle()).As<float, T>();
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
                        return Avx2.Max(left.AsDouble(), right.AsDouble()).As<double, T>();
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
                    vec.WithElement(i, Scalar.Max(left.GetElement(i), right.GetElement(i)));
                }
                return vec;
            }
        }
    }
}
#endif
