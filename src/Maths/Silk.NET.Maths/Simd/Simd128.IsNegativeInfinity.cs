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
        /// Performs hardware-accelerated IsNegativeInfinity on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> IsNegativeInfinity<T>(Vector128<T> vector) where T : unmanaged
        {
            return SingleOrDouble(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SingleOrDouble(Vector128<T> vector)
            {
                if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
                {
                    return Equal(vector, Simd128<T>.NegativeInfinity);
                }
                
                return Integer(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Integer(Vector128<T> vector)
            {
                if (typeof(T) == typeof(byte)
                    || typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(ulong)
                    || typeof(T) == typeof(long))
                {
                    return Simd128<T>.Zero;
                } 
                
                return Other(vector);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> vector)
            {
                var vec = Vector128<T>.Zero;
                for (int i = 0; i < Vector128<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.IsNegativeInfinity(vector.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
