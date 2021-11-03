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
        /// Performs hardware-accelerated Not on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Not<T>(Vector128<T> vector) where T : unmanaged
        {
            return Byte(vector);            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(Vector128<T> vector)
            {
                if (typeof(T) == typeof(byte))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return SByte(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(Vector128<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return UInt16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt16(Vector128<T> vector)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return Int16(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int16(Vector128<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return UInt32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt32(Vector128<T> vector)
            {
                if (typeof(T) == typeof(uint))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return Int32(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int32(Vector128<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return UInt64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt64(Vector128<T> vector)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return Int64(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int64(Vector128<T> vector)
            {
                if (typeof(T) == typeof(long))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return Single(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return Double(vector);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    return Simd128.Xor(vector, Vector128<T>.AllBitsSet);
                }
        
                return Other(vector);
            }
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> vector)
            {
                var vec = Vector128<T>.Zero;
                for (int i = 0; i < Vector128<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Not(GetElement(vector, i)));
                }
                return vec;
            }
        }
    }
}
#endif
