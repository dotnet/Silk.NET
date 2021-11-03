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
        /// Performs hardware-accelerated Abs on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Abs<T>(Vector256<T> vector) where T : unmanaged
        {

            return Byte(vector);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Byte(Vector256<T> vector)
            {
                if (typeof(T) == typeof(byte))
                {
                    return vector;
                }
                
        
                return SByte(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(Vector256<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if AVX
                    return Avx2.Abs(vector.AsSByte()).As<byte, T>();
#endif
                }
                
        
                return UInt16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(Vector256<T> vector)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return vector;
                }
                
        
                return Int16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(Vector256<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
#if AVX
                    return Avx2.Abs(vector.AsInt16()).As<ushort, T>();
#endif
                }
                
        
                return UInt32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(Vector256<T> vector)
            {
                if (typeof(T) == typeof(uint))
                {
                    return vector;
                }
                
        
                return Int32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(Vector256<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
#if AVX
                    return Avx2.Abs(vector.AsInt32()).As<uint, T>();
#endif
                }
                
        
                return UInt64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(Vector256<T> vector)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return vector;
                }
                
        
                return Single(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX
                    return Avx2.And(vector.AsSingle(), Vector256.Create(0x7FFF_FFFFu).AsSingle()).As<float, T>();
#endif
                }
                
        
                return Double(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(Vector256<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
#if AVX
                    return Avx2.And(vector.AsDouble(), Vector256.Create(0x7FFF_FFFF_FFFF_FFFFul).AsDouble()).As<double, T>();
#endif
                }
                
        
                return Other(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> vector)
            {
            
                var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Abs(GetElement(vector, i)));
                }

                return vec;
            }

        }
    }
}
#endif
