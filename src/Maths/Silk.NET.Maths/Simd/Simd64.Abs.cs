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
        /// Performs hardware-accelerated Abs on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Abs<T>(Vector64<T> vector) where T : unmanaged
        {
            return Byte(vector);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Byte(Vector64<T> vector)
            {
                if (typeof(T) == typeof(byte))
                {
                    return vector;
                }
        
                return SByte(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SByte(Vector64<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    return AdvSimd.Abs(vector.AsSByte()).As<byte, T>();
#endif
                }
        
                return UInt16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt16(Vector64<T> vector)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return vector;
                }
        
                return Int16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int16(Vector64<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    return AdvSimd.Abs(vector.AsInt16()).As<ushort, T>();
#endif
                }
        
                return UInt32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt32(Vector64<T> vector)
            {
                if (typeof(T) == typeof(uint))
                {
                    return vector;
                }
        
                return Int32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int32(Vector64<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    return AdvSimd.Abs(vector.AsInt32()).As<uint, T>();
#endif
                }
        
                return UInt64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt64(Vector64<T> vector)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return vector;
                }
        
                return Single(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(Vector64<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return Simd64.And(vector.AsSingle(), Vector64.Create(0x7FFF_FFFFu).AsSingle()).As<float, T>();
                }
        
                return Double(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(Vector64<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return Simd64.And(vector.AsDouble(), Vector64.Create(0x7FFF_FFFF_FFFF_FFFFul).AsDouble()).As<double, T>();
                }
        
                return Other(vector);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> vector)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    vec = vec.WithElement(i, Scalar.Abs(vector.GetElement(i)));
                }
                return vec;
            }
        }
    }
}
#endif
