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
        /// Performs hardware-accelerated Store on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static void Store<T>(T* destination, Vector256<T> source) where T : unmanaged
        {

            Byte(destination, source);            
            [MethodImpl(Scalar.MaxOpt)]
            static void Byte(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(byte))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((byte*) destination, (Vector256<byte>) (object) source);
                    }
#endif
                }
                
        
                SByte(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void SByte(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((sbyte*) destination, (Vector256<sbyte>) (object) source);
                    }
#endif
                }
                
        
                UInt16(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt16(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((ushort*) destination, (Vector256<ushort>) (object) source);
                    }
#endif
                }
                
        
                Int16(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int16(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(short))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((short*) destination, (Vector256<short>) (object) source);
                    }
#endif
                }
                
        
                UInt32(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt32(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(uint))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((uint*) destination, (Vector256<uint>) (object) source);
                    }
#endif
                }
                
        
                Int32(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int32(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(int))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((int*) destination, (Vector256<int>) (object) source);
                    }
#endif
                }
                
        
                UInt64(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt64(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(ulong))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((ulong*) destination, (Vector256<ulong>) (object) source);
                    }
#endif
                }
                
        
                Int64(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int64(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(long))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((long*) destination, (Vector256<long>) (object) source);
                    }
#endif
                }
                
        
                Single(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Single(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((float*) destination, (Vector256<float>) (object) source);
                    }
#endif
                }
                
        
                Double(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Double(T* destination, Vector256<T> source)
            {
                if (typeof(T) == typeof(double))
                {
#if AVX
                    if (Avx2.IsSupported)
                    {
                        Avx2.Store((double*) destination, (Vector256<double>) (object) source);
                    }
#endif
                }
                
        
                Other(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Other(T* destination, Vector256<T> source)
            {
                            Unsafe.WriteUnaligned<Vector256<T>>(destination, source);

            }

        }
    }
}
#endif
