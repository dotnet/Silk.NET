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
        /// Performs hardware-accelerated Equal on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Equal<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
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
                        return Avx2.CompareEqual(left.AsSByte(), right.AsSByte()).As<SByte, T>();
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
                        return Avx2.CompareEqual(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
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
                        return Avx2.CompareEqual(left.AsInt16(), right.AsInt16()).As<Int16, T>();
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
                        return Avx2.CompareEqual(left.AsInt16(), right.AsInt16()).As<short, T>();
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
                        return Avx2.CompareEqual(left.AsInt32(), right.AsInt32()).As<Int32, T>();
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
                        return Avx2.CompareEqual(left.AsInt32(), right.AsInt32()).As<int, T>();
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
                        return Avx2.CompareEqual(left.AsInt64(), right.AsInt64()).As<Int64, T>();
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
                        return Avx2.CompareEqual(left.AsInt64(), right.AsInt64()).As<long, T>();
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
#if NET5_0_OR_GREATER
                        return Avx2.CompareEqual(left.AsSingle(), right.AsSingle()).As<float, T>();
#else
                        // floats are equal iff int32 are equal
                        return Avx2.CompareEqual(left.AsInt32(), right.AsInt32()).As<int, T>();
#endif
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
#if NET5_0_OR_GREATER
                        return Avx2.CompareEqual(left.AsDouble(), right.AsDouble()).As<double, T>();
#else
                        // doubles are equal iff int64 are equal
                        return Avx2.CompareEqual(left.AsInt64(), right.AsInt64()).As<long, T>();
#endif
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
                    vec = vec.WithElement(i, Scalar.Equal(left.GetElement(i), right.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
