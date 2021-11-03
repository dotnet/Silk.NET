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
        /// Performs hardware-accelerated Create on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Create<T>(T value) where T : unmanaged
        {
            return Byte(value);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Byte(T value)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (Vector256<T>) (object) Vector256.Create((byte) (object) value);
                }
        
                return SByte(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(T value)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (Vector256<T>) (object) Vector256.Create((sbyte) (object) value);
                }
        
                return UInt16(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(T value)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (Vector256<T>) (object) Vector256.Create((ushort) (object) value);
                }
        
                return Int16(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(T value)
            {
                if (typeof(T) == typeof(short))
                {
                    return (Vector256<T>) (object) Vector256.Create((short) (object) value);
                }
        
                return UInt32(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(T value)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (Vector256<T>) (object) Vector256.Create((uint) (object) value);
                }
        
                return Int32(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(T value)
            {
                if (typeof(T) == typeof(int))
                {
                    return (Vector256<T>) (object) Vector256.Create((int) (object) value);
                }
        
                return UInt64(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(T value)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (Vector256<T>) (object) Vector256.Create((ulong) (object) value);
                }
        
                return Int64(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int64(T value)
            {
                if (typeof(T) == typeof(long))
                {
                    return (Vector256<T>) (object) Vector256.Create((long) (object) value);
                }
        
                return Single(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(T value)
            {
                if (typeof(T) == typeof(float))
                {
                    return (Vector256<T>) (object) Vector256.Create((float) (object) value);
                }
        
                return Double(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(T value)
            {
                if (typeof(T) == typeof(double))
                {
                    return (Vector256<T>) (object) Vector256.Create((double) (object) value);
                }
        
                return Other(value);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(T value)
            {
                Scalar.ThrowUnsupportedType();
                return default;

            }
        }
    }
}
#endif
