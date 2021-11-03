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
        /// Performs hardware-accelerated Xor on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : unmanaged
        {
            return Byte(left, right);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(byte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsByte(), right.AsByte()).As<byte, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsByte(), right.AsByte()).As<byte, T>();
                    }
#endif
                }
        
                return SByte(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif
                }
        
                return UInt16(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt16(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsUInt16(), right.AsUInt16()).As<ushort, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsUInt16(), right.AsUInt16()).As<ushort, T>();
                    }
#endif
                }
        
                return Int16(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int16(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(short))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif
                }
        
                return UInt32(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt32(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(uint))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsUInt32(), right.AsUInt32()).As<uint, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsUInt32(), right.AsUInt32()).As<uint, T>();
                    }
#endif
                }
        
                return Int32(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int32(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(int))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif
                }
        
                return UInt64(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt64(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(ulong))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
                    }
#endif
                }
        
                return Int64(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int64(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(long))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsInt64(), right.AsInt64()).As<long, T>();
                    }
#endif
                }
        
                return Single(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Xor(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif
                }
        
                return Double(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> left, Vector128<T> right)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.Xor(left.AsDouble(), right.AsDouble()).As<double, T>();
                    }
#endif
                }
        
                return Other(left, right);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> left, Vector128<T> right)
            {
                var vec = Vector128<T>.Zero;
                for (int i = 0; i < Vector128<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Xor(GetElement(left, i), GetElement(right, i)));
                }
                return vec;
            }
        }
    }
}
#endif
