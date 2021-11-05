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
        /// Performs hardware-accelerated Load on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Load<T>(T* ptr) where T : unmanaged
        {
            return Byte(ptr);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Byte(T* ptr)
            {
                if (typeof(T) == typeof(byte))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((byte*) ptr);
                    }
#endif
                }
        
                return SByte(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(T* ptr)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((sbyte*) ptr);
                    }
#endif
                }
        
                return UInt16(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(T* ptr)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((ushort*) ptr);
                    }
#endif
                }
        
                return Int16(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(T* ptr)
            {
                if (typeof(T) == typeof(short))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((short*) ptr);
                    }
#endif
                }
        
                return UInt32(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(T* ptr)
            {
                if (typeof(T) == typeof(uint))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((uint*) ptr);
                    }
#endif
                }
        
                return Int32(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(T* ptr)
            {
                if (typeof(T) == typeof(int))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((int*) ptr);
                    }
#endif
                }
        
                return UInt64(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(T* ptr)
            {
                if (typeof(T) == typeof(ulong))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((ulong*) ptr);
                    }
#endif
                }
        
                return Int64(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int64(T* ptr)
            {
                if (typeof(T) == typeof(long))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((long*) ptr);
                    }
#endif
                }
        
                return Single(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(T* ptr)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((float*) ptr);
                    }
#endif
                }
        
                return Double(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(T* ptr)
            {
                if (typeof(T) == typeof(double))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector256<T>) (object) Avx2.LoadVector256((double*) ptr);
                    }
#endif
                }
        
                return Other(ptr);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(T* ptr)
            {
                return Unsafe.ReadUnaligned<Vector256<T>>(ptr);
            }
        }
    }
}
#endif
