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
        /// Performs hardware-accelerated Sign on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Sign<T>(Vector64<T> vector) where T : unmanaged
        {
            return SignedNumber(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SignedNumber(Vector64<T> vector)
            {
                if (typeof(T) == typeof(float)
                    || typeof(T) == typeof(double)
                    || typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(long))
                {
                    // https://source.dot.net/#System.Private.CoreLib/Math.cs,1361
                    /*
                        if (value < 0)
                        {
                            return -1;
                        }
                        else if (value > 0)
                        {
                            return 1;
                        }
                        else if (value == 0)
                        {
                            return 0;
                        }
                        
                        is the same as
                        
                        (value < 0 & -1)
                        | (value > 0 & 1)
                        
                        Note 0, not IsNegative
                     */
                    return
                        // (value < 0 & -1) | (value > 0 & 1)
                        Or(
                            // value < 0 & -1
                            And(LessThan(vector, Simd64<T>.Zero), Simd64<T>.MinusOne),
                            
                            // value > 0 & 1
                            And(GreaterThan(vector, Simd64<T>.Zero), Simd64<T>.One)
                        );
                }
                
                return UnsignedNumber(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UnsignedNumber(Vector64<T> vector)
            {
                if (typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(ulong))
                {
                    // no need to have the case < 0, since it is always false.
                    return
                        And(
                            GreaterThan(vector, Simd64<T>.Zero),
                            Simd64<T>.One
                        );
                }
                
                return Other(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> vector)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    vec.WithElement(i, 
                        Scalar.GreaterThan(vector.GetElement(i), Scalar<T>.Zero)
                        ? Scalar<T>.One
                        : (
                            Scalar.LessThan(vector.GetElement(i), Scalar<T>.Zero)
                            ? Scalar<T>.MinusOne
                            : Scalar<T>.Zero
                        ));
                }
                return vec;
            }
        }
    }
}
#endif
