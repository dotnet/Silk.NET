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
        /// Performs hardware-accelerated Not on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Not<T>(Vector64<T> vector) where T : unmanaged
        {
            return Byte(vector);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Byte(Vector64<T> vector)
            {
                if (typeof(T) == typeof(byte))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return SByte(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SByte(Vector64<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return UInt16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt16(Vector64<T> vector)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return Int16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int16(Vector64<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return UInt32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt32(Vector64<T> vector)
            {
                if (typeof(T) == typeof(uint))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return Int32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int32(Vector64<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return UInt64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt64(Vector64<T> vector)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return Int64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int64(Vector64<T> vector)
            {
                if (typeof(T) == typeof(long))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return Single(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(Vector64<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return Double(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(Vector64<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return Simd64.Xor(vector, Simd64<T>.AllBitsSet);
                }
        
                return Other(vector);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> vector)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Not(GetElement(vector, i)));
                }
                return vec;
            }
        }
    }
}
#endif
