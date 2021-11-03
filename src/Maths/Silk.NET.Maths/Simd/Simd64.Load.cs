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
        /// <summary>
        /// Performs hardware-accelerated Load on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Load<T>(T* ptr) where T : unmanaged
        {

            return Byte(ptr);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Byte(T* ptr)
            {
                if (typeof(T) == typeof(byte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((byte*) ptr);
                    }
#endif
                }
                
        
                return SByte(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SByte(T* ptr)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((sbyte*) ptr);
                    }
#endif
                }
                
        
                return UInt16(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt16(T* ptr)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((ushort*) ptr);
                    }
#endif
                }
                
        
                return Int16(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int16(T* ptr)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((short*) ptr);
                    }
#endif
                }
                
        
                return UInt32(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt32(T* ptr)
            {
                if (typeof(T) == typeof(uint))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((uint*) ptr);
                    }
#endif
                }
                
        
                return Int32(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int32(T* ptr)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((int*) ptr);
                    }
#endif
                }
                
        
                return UInt64(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt64(T* ptr)
            {
                if (typeof(T) == typeof(ulong))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((ulong*) ptr);
                    }
#endif
                }
                
        
                return Int64(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int64(T* ptr)
            {
                if (typeof(T) == typeof(long))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((long*) ptr);
                    }
#endif
                }
                
        
                return Single(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(T* ptr)
            {
                if (typeof(T) == typeof(float))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((float*) ptr);
                    }
#endif
                }
                
        
                return Double(ptr);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(T* ptr)
            {
                if (typeof(T) == typeof(double))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector64<T>) (object) AdvSimd.LoadVector64((double*) ptr);
                    }
#endif
                }
                
        
                return Other(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(T* ptr)
            {
                            return Unsafe.ReadUnaligned<Vector64<T>>(ptr);

            }

        }
    }
}
#endif
