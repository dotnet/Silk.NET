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
        /// Performs hardware-accelerated IsNormal on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> IsNormal<T>(Vector64<T> vector) where T : unmanaged
        {
            return Single(vector);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(Vector64<T> vector)
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
                        // we exclude bits != 0
                        // because we don't have short-circuited "and" in simd,
                        // so doing this is useless since bits != 0 is a weaker
                        // statement than (bits & 0x7F800000) != 0.
                        // (bits < 0x7F800000) && ((bits & 0x7F800000) != 0)
                        And(
                            // bits < 0x7F800000
                            LessThan(bits, SingleFiniteThreshold),
                            // (bits & 0x7F800000) != 0
                            NotEqual(
                                // bits & 0x7F800000
                                And(
                                    bits,
                                    SingleFiniteThreshold
                                ),
                                Simd64<int>.Zero
                            )
                        ).As<int, T>();
                }

                return Double(vector);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(Vector64<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
                    /*
                     https://source.dot.net/#System.Private.CoreLib/Double.cs,125
                    long bits = BitConverter.DoubleToInt64Bits(d);
                    bits &= 0x7FFFFFFFFFFFFFFF;
                    return (bits < 0x7FF0000000000000) && (bits != 0) && ((bits & 0x7FF0000000000000) != 0);
                     */
                    var bits = And(vector.AsInt64(), DoubleUnsignedMask);
                    return 
                        // we exclude bits != 0
                        // because we don't have short-circuited "and" in simd,
                        // so doing this is useless since bits != 0 is a weaker
                        // statement than (bits & 0x7FF0000000000000) != 0.
                        // (bits < 0x7FF0000000000000) && ((bits & 0x7FF0000000000000) != 0)
                        And(
                            // bits < 0x7FF0000000000000
                            LessThan(bits, DoubleFiniteThreshold),
                            // (bits & 0x7FF0000000000000) != 0
                            NotEqual(
                                // bits & 0x7FF0000000000000
                                And(
                                    bits,
                                    DoubleFiniteThreshold
                                ),
                                Simd64<long>.Zero
                            )
                        ).As<long, T>();
                }
                
                return Integer(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Integer(Vector64<T> vector)
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
                    return Simd64<T>.AllBitsSet;
                } 
                
                return Other(vector);
            }

        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> vector)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    vec.WithElement(i, Scalar.IsNormal(vector.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
