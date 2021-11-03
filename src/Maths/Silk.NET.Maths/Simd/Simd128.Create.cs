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
        /// <summary>
        /// Performs hardware-accelerated Create on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Create<T>(T value) where T : unmanaged
        {

            return Byte(value);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(T value)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (Vector128<T>) (object) Vector128.Create((byte) (object) value);
                }
                
        
                return SByte(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(T value)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (Vector128<T>) (object) Vector128.Create((sbyte) (object) value);
                }
                
        
                return UInt16(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt16(T value)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (Vector128<T>) (object) Vector128.Create((ushort) (object) value);
                }
                
        
                return Int16(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int16(T value)
            {
                if (typeof(T) == typeof(short))
                {
                    return (Vector128<T>) (object) Vector128.Create((short) (object) value);
                }
                
        
                return UInt32(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt32(T value)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (Vector128<T>) (object) Vector128.Create((uint) (object) value);
                }
                
        
                return Int32(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int32(T value)
            {
                if (typeof(T) == typeof(int))
                {
                    return (Vector128<T>) (object) Vector128.Create((int) (object) value);
                }
                
        
                return UInt64(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt64(T value)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (Vector128<T>) (object) Vector128.Create((ulong) (object) value);
                }
                
        
                return Int64(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int64(T value)
            {
                if (typeof(T) == typeof(long))
                {
                    return (Vector128<T>) (object) Vector128.Create((long) (object) value);
                }
                
        
                return Single(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(T value)
            {
                if (typeof(T) == typeof(float))
                {
                    return (Vector128<T>) (object) Vector128.Create((float) (object) value);
                }
                
        
                return Double(value);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(T value)
            {
                if (typeof(T) == typeof(double))
                {
                    return (Vector128<T>) (object) Vector128.Create((double) (object) value);
                }
                
        
                return Other(value);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(T value)
            {
                            Scalar.ThrowUnsupportedType();
                return default;

            }

        }
    }
}
#endif
