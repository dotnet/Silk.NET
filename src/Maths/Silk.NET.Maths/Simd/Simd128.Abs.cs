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
        /// Performs hardware-accelerated Abs on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Abs<T>(Vector128<T> vector) where T : unmanaged
        {
            return Byte(vector);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(Vector128<T> vector)
            {
                if (typeof(T) == typeof(byte))
                {
                    return vector;
                }
        
                return SByte(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(Vector128<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Abs(vector.AsSByte()).As<byte, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Ssse3.Abs(vector.AsSByte()).As<byte, T>();
                    }
#endif
                }
        
                return UInt16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt16(Vector128<T> vector)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return vector;
                }
        
                return Int16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int16(Vector128<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Abs(vector.AsInt16()).As<ushort, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Ssse3.Abs(vector.AsInt16()).As<ushort, T>();
                    }
#endif
                }
        
                return UInt32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt32(Vector128<T> vector)
            {
                if (typeof(T) == typeof(uint))
                {
                    return vector;
                }
        
                return Int32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int32(Vector128<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Abs(vector.AsInt32()).As<uint, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Ssse3.Abs(vector.AsInt32()).As<uint, T>();
                    }
#endif
                }
        
                return UInt64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt64(Vector128<T> vector)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return vector;
                }
        
                return Single(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return Simd128.And(vector.AsSingle(), Vector128.Create(0x7FFF_FFFFu).AsSingle()).As<float, T>();
                }
        
                return Double(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return Simd128.And(vector.AsDouble(), Vector128.Create(0x7FFF_FFFF_FFFF_FFFFul).AsDouble()).As<double, T>();
                }
        
                return Other(vector);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> vector)
            {
                var vec = Vector128<T>.Zero;
                for (int i = 0; i < Vector128<T>.Count; i++)
                {
                    vec = vec.WithElement(i, Scalar.Abs(vector.GetElement(i)));
                }
                return vec;
            }
        }
    }
}
#endif
