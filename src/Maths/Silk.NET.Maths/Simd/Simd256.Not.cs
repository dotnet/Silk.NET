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
        /// Performs hardware-accelerated Not on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Not<T>(Vector256<T> vector) where T : unmanaged
        {
            return Byte(vector);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Byte(Vector256<T> vector)
            {
                if (typeof(T) == typeof(byte))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return SByte(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(Vector256<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return UInt16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(Vector256<T> vector)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return Int16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(Vector256<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return UInt32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(Vector256<T> vector)
            {
                if (typeof(T) == typeof(uint))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return Int32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(Vector256<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return UInt64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(Vector256<T> vector)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return Int64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int64(Vector256<T> vector)
            {
                if (typeof(T) == typeof(long))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return Single(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return Double(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(Vector256<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return Simd256.Xor(vector, Vector256<T>.AllBitsSet);
                }
        
                return Other(vector);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> vector)
            {
                var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Not(GetElement(vector, i)));
                }
                return vec;
            }
        }
    }
}
#endif
