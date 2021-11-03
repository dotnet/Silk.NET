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
    public static unsafe partial class Simd64
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static void Store<T>(T* destination, Vector64<T> source) where T : unmanaged
        {

            Byte(destination, source);            
            [MethodImpl(Scalar.MaxOpt)]
            static void Byte(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(byte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((byte*) destination, (Vector64<byte>) (object) source);
                    }
#endif
                }
                
        
                SByte(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void SByte(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((sbyte*) destination, (Vector64<sbyte>) (object) source);
                    }
#endif
                }
                
        
                UInt16(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt16(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((ushort*) destination, (Vector64<ushort>) (object) source);
                    }
#endif
                }
                
        
                Int16(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int16(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((short*) destination, (Vector64<short>) (object) source);
                    }
#endif
                }
                
        
                UInt32(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt32(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(uint))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((uint*) destination, (Vector64<uint>) (object) source);
                    }
#endif
                }
                
        
                Int32(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int32(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((int*) destination, (Vector64<int>) (object) source);
                    }
#endif
                }
                
        
                UInt64(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt64(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(ulong))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((ulong*) destination, (Vector64<ulong>) (object) source);
                    }
#endif
                }
                
        
                Int64(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int64(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(long))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((long*) destination, (Vector64<long>) (object) source);
                    }
#endif
                }
                
        
                Single(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Single(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(float))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((float*) destination, (Vector64<float>) (object) source);
                    }
#endif
                }
                
        
                Double(destination, source);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static void Double(T* destination, Vector64<T> source)
            {
                if (typeof(T) == typeof(double))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((double*) destination, (Vector64<double>) (object) source);
                    }
#endif
                }
                
        
                Other(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Other(T* destination, Vector64<T> source)
            {
                            Unsafe.WriteUnaligned<Vector64<T>>(destination, source);

            }

        }
    }
}
#endif
