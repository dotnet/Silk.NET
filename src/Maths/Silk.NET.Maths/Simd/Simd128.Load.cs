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
        public static Vector128<T> Load<T>(T* ptr) where T : unmanaged
        {

            return Byte(ptr);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(T* ptr)
            {
                if (typeof(T) == typeof(byte))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((byte*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((byte*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((byte*) ptr);
                    }
#endif

                }
                
        
                return SByte(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(T* ptr)
            {
                if (typeof(T) == typeof(sbyte))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((sbyte*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((sbyte*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((sbyte*) ptr);
                    }
#endif

                }
                
        
                return UInt16(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt16(T* ptr)
            {
                if (typeof(T) == typeof(ushort))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((ushort*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((ushort*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((ushort*) ptr);
                    }
#endif

                }
                
        
                return Int16(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int16(T* ptr)
            {
                if (typeof(T) == typeof(short))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((short*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((short*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((short*) ptr);
                    }
#endif

                }
                
        
                return UInt32(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt32(T* ptr)
            {
                if (typeof(T) == typeof(uint))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((uint*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((uint*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((uint*) ptr);
                    }
#endif

                }
                
        
                return Int32(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int32(T* ptr)
            {
                if (typeof(T) == typeof(int))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((int*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((int*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((int*) ptr);
                    }
#endif

                }
                
        
                return UInt64(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt64(T* ptr)
            {
                if (typeof(T) == typeof(ulong))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((ulong*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((ulong*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((ulong*) ptr);
                    }
#endif

                }
                
        
                return Int64(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int64(T* ptr)
            {
                if (typeof(T) == typeof(long))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((long*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((long*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((long*) ptr);
                    }
#endif

                }
                
        
                return Single(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(T* ptr)
            {
                if (typeof(T) == typeof(float))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((float*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((float*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((float*) ptr);
                    }
#endif

                }
                
        
                return Double(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(T* ptr)
            {
                if (typeof(T) == typeof(Double))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((Double*) ptr);
                    }
#endif

#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((Double*) ptr);
                    }
#endif

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return (Vector128<T>) (object) Avx2.LoadVector128((Double*) ptr);
                    }
#endif

                }
                
        
                return Other(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(T* ptr)
            {
            
                return Unsafe.ReadUnaligned<Vector128<T>>(ptr);

            }

        }
    }
}
#endif
