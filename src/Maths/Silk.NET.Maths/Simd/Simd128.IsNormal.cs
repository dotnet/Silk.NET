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
        /// Performs hardware-accelerated IsNormal on 128-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> IsNormal<T>(Vector128<T> vector) where T : unmanaged
        {
            return Single(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Single(Vector128<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
                    /*
                        https://source.dot.net/#System.Private.CoreLib/Single.cs,121
                        int bits = BitConverter.SingleToInt32Bits(f);
                        bits &= 0x7FFFFFFF;
                        return (bits < 0x7F800000) && (bits != 0) && ((bits & 0x7F800000) != 0);
                     */
                    var bits = And(vector.AsInt32(), SingleUnsignedMask);
                    return 
                    // (bits < 0x7F800000) && (bits != 0) && ((bits & 0x7F800000) != 0)
                    And(
                        // (bits < 0x7F800000) && (bits != 0)
                        And(
                            // bits < 0x7F800000
                            LessThan(bits, SingleFiniteThreshold),
                            
                            // bits != 0
                            NotEqual(bits, Simd128<int>.Zero)
                        ),
                        
                        // (bits & 0x7F800000) != 0
                        NotEqual(
                            // bits & 0x7F800000
                            And(
                                bits,
                                SingleFiniteThreshold
                            ),
                            
                            Simd128<int>.Zero
                        )
                    ).As<int, T>();
                }

                return Double(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    /*
                     https://source.dot.net/#System.Private.CoreLib/Double.cs,125
                    long bits = BitConverter.DoubleToInt64Bits(d);
                    bits &= 0x7FFFFFFFFFFFFFFF;
                    return (bits < 0x7FF0000000000000) && (bits != 0) && ((bits & 0x7FF0000000000000) != 0);
                     */
                    return LessThan(vector.AsInt64(), Simd128<long>.Zero).As<long, T>();
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
                    return Simd128<T>.AllBitsSet;
                } 
                
                return Other(vector);
            }

        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> vector)
            {
                var vec = Vector128<T>.Zero;
                for (int i = 0; i < Vector128<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.IsNormal(vector.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
