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
        public static void Store<T>(T* destination, Vector128<T> source) where T : unmanaged
        {

            Byte(destination, source);            
            [MethodImpl(Scalar.MaxOpt)]
            static void Byte(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(byte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((byte*) destination, (Vector128<byte>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((byte*) destination, (Vector128<byte>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((byte*) destination, (Vector128<byte>) (object) source);
                    }
#endif
                }
                
        
                SByte(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void SByte(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((sbyte*) destination, (Vector128<sbyte>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((sbyte*) destination, (Vector128<sbyte>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((sbyte*) destination, (Vector128<sbyte>) (object) source);
                    }
#endif
                }
                
        
                UInt16(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt16(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((ushort*) destination, (Vector128<ushort>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((ushort*) destination, (Vector128<ushort>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((ushort*) destination, (Vector128<ushort>) (object) source);
                    }
#endif
                }
                
        
                Int16(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int16(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((short*) destination, (Vector128<short>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((short*) destination, (Vector128<short>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((short*) destination, (Vector128<short>) (object) source);
                    }
#endif
                }
                
        
                UInt32(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt32(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(uint))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((uint*) destination, (Vector128<uint>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((uint*) destination, (Vector128<uint>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((uint*) destination, (Vector128<uint>) (object) source);
                    }
#endif
                }
                
        
                Int32(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int32(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((int*) destination, (Vector128<int>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((int*) destination, (Vector128<int>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((int*) destination, (Vector128<int>) (object) source);
                    }
#endif
                }
                
        
                UInt64(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt64(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(ulong))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((ulong*) destination, (Vector128<ulong>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((ulong*) destination, (Vector128<ulong>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((ulong*) destination, (Vector128<ulong>) (object) source);
                    }
#endif
                }
                
        
                Int64(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int64(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(long))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((long*) destination, (Vector128<long>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((long*) destination, (Vector128<long>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((long*) destination, (Vector128<long>) (object) source);
                    }
#endif
                }
                
        
                Single(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Single(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(float))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((float*) destination, (Vector128<float>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((float*) destination, (Vector128<float>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((float*) destination, (Vector128<float>) (object) source);
                    }
#endif
                }
                
        
                Double(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Double(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(Double))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((Double*) destination, (Vector128<Double>) (object) source);
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((Double*) destination, (Vector128<Double>) (object) source);
                    }
#endif
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((Double*) destination, (Vector128<Double>) (object) source);
                    }
#endif
                }
                
        
                Other(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Other(T* destination, Vector128<T> source)
            {
                            Unsafe.WriteUnaligned<Vector128<T>>(destination, source);

            }

        }
    }
}
#endif
