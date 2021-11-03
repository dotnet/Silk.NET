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
        /// Performs hardware-accelerated Create on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Create<T>(T value) where T : unmanaged
        {

            return Byte(value);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Byte(T value)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (Vector64<T>) (object) Vector64.Create((byte) (object) value);
                }
                
        
                return SByte(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SByte(T value)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (Vector64<T>) (object) Vector64.Create((sbyte) (object) value);
                }
                
        
                return UInt16(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt16(T value)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (Vector64<T>) (object) Vector64.Create((ushort) (object) value);
                }
                
        
                return Int16(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int16(T value)
            {
                if (typeof(T) == typeof(short))
                {
                    return (Vector64<T>) (object) Vector64.Create((short) (object) value);
                }
                
        
                return UInt32(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt32(T value)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (Vector64<T>) (object) Vector64.Create((uint) (object) value);
                }
                
        
                return Int32(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int32(T value)
            {
                if (typeof(T) == typeof(int))
                {
                    return (Vector64<T>) (object) Vector64.Create((int) (object) value);
                }
                
        
                return UInt64(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt64(T value)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (Vector64<T>) (object) Vector64.Create((ulong) (object) value);
                }
                
        
                return Int64(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int64(T value)
            {
                if (typeof(T) == typeof(long))
                {
                    return (Vector64<T>) (object) Vector64.Create((long) (object) value);
                }
                
        
                return Single(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(T value)
            {
                if (typeof(T) == typeof(float))
                {
                    return (Vector64<T>) (object) Vector64.Create((float) (object) value);
                }
                
        
                return Double(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(T value)
            {
                if (typeof(T) == typeof(double))
                {
                    return (Vector64<T>) (object) Vector64.Create((double) (object) value);
                }
                
        
                return Other(value);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(T value)
            {
                            Scalar.ThrowUnsupportedType();
                return default;

            }

        }
    }
}
#endif
