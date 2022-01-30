// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
#if SSE || AdvSIMD
using System.Runtime.Intrinsics;
#endif
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif

// it doesn't like default because it may be null
#pragma warning disable 8603

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // This partial contains the helper methods which forward to MathF or Math, used a lot within Silk.NET.Maths
        //
        // For the most part, these are pretty direct forwards. However there are a lot of unnecessary up-casts in a lot
        // of places. Possible tasks could be:
        // a) TODO identifying where we're up-casting unnecessarily
        //    (it's done a lot throughout this file as System.Math pretty much only supports double)
        // b) TODO removing unnecessary up-casts with dedicated, managed methods.
        // c) TODO implement any unimplemented methods
        //    Ctrl+F for ThrowOpUnsupportedPrecision
        //
        // These should be done around 2.0 Preview 5 time, but if you're reading this comment after 2.0's initial
        // release then feel free to PR in some of these changes as we clearly have failed.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        /// <param name="x">The value to get the absolute of</param>
        /// <typeparam name="T">The type of <paramref name="x"/> </typeparam>
        /// <returns>The absolute of the given value</returns>
        [MethodImpl(MaxOpt)]
        public static unsafe T Abs<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if NET5_0 && INTRINSICS
                if (Sse2.IsSupported)
                {
                    return (T)(object)(Half)Sse.And(Vector128.CreateScalarUnsafe((float) (Half) (object) x), Vector128.Create(-0.0f)).ToScalar();
                } 
                else if (AdvSimd.IsSupported)
                {
                    return (T)(object)(Half)AdvSimd.And(Vector128.CreateScalarUnsafe((float) (Half) (object) x), Vector128.Create(-0.0f)).ToScalar();
                }
                else
#elif NETCOREAPP3_1 && INTRINSICS
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(Half)Sse.And(Vector128.CreateScalarUnsafe((float) (Half) (object) x), Vector128.CreateScalarUnsafe(-0.0f)).ToScalar();
                    }
                    else
#endif
                {
                    var v = *(ushort*) &x;
                    v &= 0x7FFF;
                    return *(T*) &v;
                }
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if NET5_0 && INTRINSICS
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(float)Sse.And(Vector128.CreateScalarUnsafe((float)(object)x), Vector128.Create((uint)0x7FFF_FFFF).AsSingle()).ToScalar();
                    }
                    else if (AdvSimd.IsSupported)
                    {
                        return (T) (object) (float)AdvSimd.AbsScalar(Vector64.CreateScalarUnsafe((float) (object) x)).ToScalar();
                    }
                    else
#elif NETCOREAPP3_1 && INTRINSICS
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(float)Sse.And(Vector128.CreateScalarUnsafe((float)(object)x), Vector128.CreateScalarUnsafe((uint)0x7FFF_FFFF).AsSingle()).ToScalar();
                    }
                    else
#endif
                    {
                        var v = *(uint*) &x;
                        v &= 0x7FFF_FFFF;
                        return *(T*) &v;
                    }
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
#if NET5_0 && INTRINSICS
                    if (Sse2.IsSupported)
                    {
                        return (T)(object)(double)Sse2.And(Vector128.CreateScalarUnsafe((double)(object)x), Vector128.Create((ulong)0x7FFF_FFFF_FFFF_FFF).AsDouble()).ToScalar();
                    }
                    else if (AdvSimd.IsSupported)
                    {
                        return (T) (object) (double)AdvSimd.AbsScalar(Vector64.CreateScalar((double) (object) x)).ToScalar();
                    }
                    else
#elif NETCOREAPP3_1 && INTRINSICS
                    if (Sse2.IsSupported)
                    {
                        return (T)(object)(double)Sse2.And(Vector128.CreateScalarUnsafe((double)(object)x), Vector128.CreateScalarUnsafe((ulong)0x7FFF_FFFF_FFFF_FFF).AsDouble()).ToScalar();
                    }
                    else
#endif
                    {
                        var v = *(ulong*) &x;
                        v &= 0x7FFF_FFFF_FFFF_FFFF;
                        return *(T*) &v;
                    }
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if SSE
                    if (Ssse3.IsSupported)
                    {
                        return (T)(object)(sbyte)Ssse3.Abs(Vector128.CreateScalar((sbyte) (object) x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T) (object) (sbyte)AdvSimd.Abs(Vector64.CreateScalar((sbyte) (object) x)).ToScalar();
                    }
#endif
                    var px = (sbyte) (object) x;
                    sbyte mask = (sbyte) (px >> (sizeof(sbyte) - 1));
                    return (T) (object) (sbyte) ((px + mask) ^ mask);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
#if SSE
                    if (Ssse3.IsSupported)
                    {
                        return (T)(object)(int)Ssse3.Abs(Vector128.CreateScalar((int) (object) x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T) (object)(int) AdvSimd.Abs(Vector64.CreateScalar((int) (object) x)).ToScalar();
                    }
#endif
                    var px = (int) (object) x;
                    int mask = (int) (px >> (sizeof(int) - 1));
                    return (T) (object) (int) ((px + mask) ^ mask);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    var px = (long) (object) x;
                    long mask = (long) (px >> (sizeof(long) - 1));
                    return (T) (object) (long) ((px + mask) ^ mask);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
#if SSE
                    if (Ssse3.IsSupported)
                    {
                        return (T)(object)(short)Ssse3.Abs(Vector128.CreateScalar((short) (object) x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T) (object)(short)AdvSimd.Abs(Vector64.CreateScalar((short) (object) x)).ToScalar();
                    }
#endif
                    var px = (short) (object) x;
                    short mask = (short) (px >> (sizeof(short) - 1));
                    return (T) (object) (short) ((px + mask) ^ mask);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                        return (T)(object) new Complex(System.Numerics.Complex.Abs((Complex)(object)x), 0);
                
                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) Math.Abs((decimal) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose cosine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a cosine, where <paramref name="x"/> must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>
        ///An angle, θ, measured in radians, such that 0 ≤ θ ≤ π.
        ///
        /// -or-
        ///
        /// NaN if x &lt; -1 or x &gt; 1 or x equals NaN.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Acos<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Acos((float) (Half) (object) x); // KIPLING
#else
                return (T) (object) (Half) MathF.Abs((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Acos((float) (object) x); // KIPLING
#else
                    return (T) (object) MathF.Acos((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Acos((double) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Acos((sbyte) (object) x); // KIPLING
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Acos((byte) (object) x); // KIPLING
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Acos((int) (object) x); // KIPLING
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Acos((uint) (object) x); // KIPLING
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Acos((long) (object) x); // KIPLING
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Acos((ulong) (object) x); // KIPLING
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Acos((short) (object) x); // KIPLING
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Acos((ushort) (object) x); // KIPLING
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Acos((Complex) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose hyperbolic cosine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a hyperbolic cosine, where <paramref name="x"/> must be greater than or equal to 1, but less than or equal to <see cref="Scalar{T}.PositiveInfinity"/>.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// An angle, θ, measured in radians, such that 0 ≤ θ ≤ ∞.
        /// 
        /// -or-
        /// 
        /// NaN if x &lt; 1 or x equals NaN.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Acosh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (float) CoreAcosh((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreAcosh((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreAcosh((double) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreAcosh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) CoreAcosh((byte) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreAcosh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (byte) CoreAcosh((byte) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreAcosh((long) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) CoreAcosh((ulong) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreAcosh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreAcosh((int) (object) x);
                }

                return Decimal(x);
            }
            
            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a sine, where <paramref name="x"/> must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2.
        /// 
        /// -or-
        /// 
        /// NaN if x &lt; -1 or x &gt; 1 or x equals NaN.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Asin<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Asin((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Abs((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Asin((float) (object) x);
#else
                    return (T) (object) MathF.Asin((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Asin((double) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Asin((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Asin((byte) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Asin((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Asin((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Asin((long) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Asin((ulong) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Asin((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Asin((ushort) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Asin((Complex) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose hyperbolic sine is the specified number.
        /// </summary>
        /// <param name="x">A number representing a hyperbolic sine, where <paramref name="x"/> must be greater than or equal to <see cref="Scalar{T}.NegativeInfinity"/>, but less than or equal to <see cref="Scalar{T}.PositiveInfinity"/>.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl(MaxOpt)]
        public static T Asinh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (float) CoreAsinh((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreAsinh((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreAsinh((double) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreAsinh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) CoreAsinh((byte) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreAsinh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) CoreAsinh((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreAsinh((long) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) CoreAsinh((ulong) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreAsinh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreAsinh((ushort) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        /// <param name="x">A number representing a tangent.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        ///An angle, θ, measured in radians, such that -π/2 ≤ θ ≤ π/2.
        /// 
        /// -or-
        /// 
        /// NaN if <paramref name="x"/> equals <see cref="Scalar{T}.NaN"/>, -π/2 rounded to double precision (-1.5707963267949) if <paramref name="x"/> equals <see cref="Scalar{T}.NegativeInfinity"/>, or π/2 rounded to double precision (1.5707963267949) if <paramref name="x"/> equals <see cref="Scalar{T}.PositiveInfinity"/>.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Atan<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Atan((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Abs((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Atan((float) (object) x);
#else
                    return (T) (object) MathF.Atan((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Atan((double) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Atan((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Atan((byte) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Atan((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Atan((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Atan((long) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Atan((ulong) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Atan((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Atan((ushort) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Atan((Complex) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose hyperbolic tangent is the specified number.
        /// </summary>
        /// <param name="x">A number representing a hyperbolic tangent, where <paramref name="x"/> must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// An angle, θ, measured in radians, such that -∞ &lt; θ &lt; -1, or 1 &lt; θ &lt; ∞.
        /// 
        /// -or-
        /// 
        /// <see cref="Scalar{T}.NaN"/> if x &lt; -1 or x &gt; 1 or x equals <see cref="Scalar{T}.NaN"/>.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Atanh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) Atanh((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) Atanh((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreAtanh((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreAtanh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) CoreAtanh((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreAtanh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreAtanh((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreAtanh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) CoreAtanh((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreAtanh((long) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) CoreAtanh((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the cube root of a specified number.
        /// </summary>
        /// <param name="x">The number whose cube root is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>
        /// The cube root of <paramref name="x"/>.
        /// 
        /// -or-
        /// 
        /// <see cref="Scalar{T}.NaN"/> if <paramref name="x"/> is equals <see cref="Scalar{T}.NaN"/>.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Cbrt<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreCbrt((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreCbrt((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreCbrt((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreCbrt((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) CoreCbrt((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreCbrt((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreCbrt((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreCbrt((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) CoreCbrt((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreCbrt((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Pow((Complex) (object) x, 1.0/3); // TODO: find a more efficient impl?
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) CoreCbrt((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The smallest integral value that is greater than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, that value is returned. Note that this method returns <typeparamref name="T"/> instead of an integral type.</returns>
        [MethodImpl(MaxOpt)]
        public static T Ceiling<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) Math.Ceiling((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Ceiling((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Ceiling((float) (object) x);
#else
                    return (T) (object) MathF.Ceiling((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Ceiling((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) Math.Ceiling((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The cosine of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Cos<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) Math.Cos((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Cos((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Cos((float) (object) x);
#else
                    return (T) (object) MathF.Cos((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Cos((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Cos((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Cos((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Cos((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Cos((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Cos((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Cos((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Cos((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Cos((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Cos((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The hyperbolic cosine of <paramref name="x"/>. If <paramref name="x"/> equal to <see cref="Scalar{T}.NegativeInfinity"/> or <see cref="Scalar{T}.PositiveInfinity"/>, <see cref="Scalar{T}.PositiveInfinity"/> is returned. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NaN"/> is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Cosh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) Math.Cosh((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Cosh((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Cosh((float) (object) x);
#else
                    return (T) (object) MathF.Cosh((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Cosh((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Cosh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Cosh((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Cosh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Cosh((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Cosh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Cosh((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Cosh((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Cosh((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Cosh((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns <c>e</c> raised to the specified power.
        /// </summary>
        /// <param name="x">A number specifying a power.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The number <c>e</c> raised to the power <paramref name="x"/>. If <paramref name="x"/> equals <see cref="Scalar{T}.NaN"/> or <see cref="Scalar{T}.PositiveInfinity"/>, that value is returned. If <paramref name="x"/> equals <see cref="Scalar{T}.NegativeInfinity"/>, 0 is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Exp<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreFastExp((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreFastExp((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Exp((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Exp((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Exp((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Exp((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Exp((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Exp((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Exp((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Exp((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Exp((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Exp((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the largest integral value less than or equal to the specified single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The largest integral value less than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, that value is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Floor<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if SSE
                if (Sse41.IsSupported)
                {
                    return (T)(object)(Half)Sse41.FloorScalar(Vector128.CreateScalarUnsafe((float) (Half) (object) x)).ToScalar();
                }
#endif
#if AdvSIMD
                if (AdvSimd.IsSupported)
                {
                    return (T)(object)(Half)AdvSimd.FloorScalar(Vector64.CreateScalarUnsafe((float) (Half) (object) x)).ToScalar();
                }
#endif  
#if !MATHF
                return (T) (object) (Half) Math.Floor((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Floor((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse41.IsSupported)
                    {
                        return (T)(object)Sse41.FloorScalar(Vector128.CreateScalarUnsafe((float) (object) x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)AdvSimd.FloorScalar(Vector64.CreateScalarUnsafe((float) (object) x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (float) Math.Floor((float) (object) x);
#else
                    return (T) (object) MathF.Floor((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse41.IsSupported)
                    {
                        return (T)(object)Sse41.FloorScalar(Vector128.CreateScalarUnsafe((double) (object) x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)AdvSimd.FloorScalar(Vector64.CreateScalar((double) (object) x)).ToScalar();
                    }
#endif
                    return (T) (object) Math.Floor((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
#if SSE
                    if (Sse41.IsSupported)
                    {
                        return (T)(object)(decimal)Sse41.FloorScalar(Vector128.CreateScalarUnsafe((double)(decimal) (object) x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(decimal)AdvSimd.FloorScalar(Vector64.CreateScalar((double)(decimal) (object) x)).ToScalar();
                    }
#endif      
                    return (T) (object) Math.Floor((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns an integer that indicates the sign of a single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/></typeparam>
        /// <returns>
        /// A number that indicates the sign of <paramref name="x"/>, as shown in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term>Return value</term>
        /// <description>Meaning</description>
        /// </listheader>
        /// <item>
        /// <term>-1</term>
        /// <description><paramref name="x"/> is less than zero.</description>
        /// </item>
        /// <item>
        /// <term>0</term>
        /// <description><paramref name="x"/> is equal to zero.</description>
        /// </item>
        /// <item>
        /// <term>1</term>
        /// <description><paramref name="x"/> is greater than zero.</description>
        /// </item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// For unsigned numbers this will never return -1, but will return 0 when <paramref name="x"/> is 0
        /// </remarks>
        /// <exception cref="ArithmeticException"><paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/></exception>
        [MethodImpl(MaxOpt)]
        public static int Sign<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return Math.Sign((float) (Half) (object) x);
#else
                return MathF.Sign((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static int Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return Math.Sign((float) (object) x);
#else
                    return MathF.Sign((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static int Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return Math.Sign((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static int Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return Math.Sign((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static int SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return Math.Sign((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static int Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return ((byte) (object) x) > 0 ? 1 : 0;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static int Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return Math.Sign((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static int UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return ((ushort) (object) x) > 0 ? 1 : 0;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static int Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return Math.Sign((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static int UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return ((uint) (object) x) > 0 ? 1 : 0;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static int Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return Math.Sign((long) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static int ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return ((ulong) (object) x) > 0 ? 1 : 0;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The sine of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Sin<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (float) Sin_Ported((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) (float) Sin_Ported((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Sin((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Sin((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Sin((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Sin((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Sin((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Sin((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Sin((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Sin((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Sin((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Sin((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">Type of <paramref name="x"/>.</typeparam>
        /// <returns>The hyperbolic sine of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NegativeInfinity"/>, <see cref="Scalar{T}.PositiveInfinity"/>, or <see cref="Scalar{T}.NaN"/> this method returns <paramref name="x"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Sinh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Sinh((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Sinh((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Sinh((float) (object) x);
#else
                    return (T) (object) MathF.Sinh((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Sinh((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Sinh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Sinh((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Sinh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Sinh((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Sinh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Sinh((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Sinh((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Sinh((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Sinh((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="x">The number whose square root is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/> parameter</term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term>Zero or positive</term>
        /// <description>The positive square root of <paramref name="x"/>.</description>
        /// </item>
        /// <item>
        /// <term>Negative</term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equals <see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equals <see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Sqrt<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if SSE
                if (Sse42.IsSupported)
                {
                    return (T)(object)(Half)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(Half)(object)x)).ToScalar();
                }
#endif
#if AdvSIMD
                if (AdvSimd.IsSupported)
                {
                    return (T)(object)(Half)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(Half)(object)x)).ToScalar();
                }
#endif  
#if !MATHF
                return (T) (object) (Half) (float) Math.Sqrt((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Sqrt((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (float) Math.Sqrt((float) (object) x);
#else
                    return (T) (object) MathF.Sqrt((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (T)(object)(double)Sse2.SqrtScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(double)AdvSimd.SqrtScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                    }
#endif      
                    return (T) (object) (double) Math.Sqrt((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(sbyte)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(sbyte)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(sbyte)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(sbyte)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (sbyte) (float) Math.Sqrt((float) (sbyte) (object) x);
#else
                    return (T) (object) (sbyte)(float)MathF.Sqrt((float) (sbyte)(object) x);
#endif
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(byte)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(byte)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(byte)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(byte)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (byte) (float) Math.Sqrt((float) (byte) (object) x);
#else
                    return (T) (object) (byte)(float)MathF.Sqrt((float) (byte)(object) x);
#endif
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(short)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(short)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(short)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(short)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (short) (float) Math.Sqrt((float) (short) (object) x);
#else
                    return (T) (object) (short)(float)MathF.Sqrt((float) (short)(object) x);
#endif
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(ushort)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(ushort)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(ushort)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(ushort)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (ushort) (float) Math.Sqrt((float) (ushort) (object) x);
#else
                    return (T) (object) (ushort)(float)MathF.Sqrt((float) (ushort)(object) x);
#endif
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(int)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(int)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(int)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(int)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (int) (float) Math.Sqrt((float) (int) (object) x);
#else
                    return (T) (object) (int)(float)MathF.Sqrt((float) (int)(object) x);
#endif
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(uint)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(uint)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(uint)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(uint)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (uint) (float) Math.Sqrt((float) (uint) (object) x);
#else
                    return (T) (object) (uint)(float)MathF.Sqrt((float) (uint)(object) x);
#endif
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(long)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(long)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(long)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(long)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (long) (float) Math.Sqrt((float) (long) (object) x);
#else
                    return (T) (object) (long)(float)MathF.Sqrt((float) (long)(object) x);
#endif
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                // TODO: vectorized implementation?
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Sqrt((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (T)(object)(ulong)(float)Sse.SqrtScalar(Vector128.CreateScalarUnsafe((float)(ulong)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(ulong)(float)AdvSimd.SqrtScalar(Vector64.CreateScalarUnsafe((float)(ulong)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (ulong) (float) Math.Sqrt((float) (ulong) (object) x);
#else
                    return (T) (object) (ulong)(float)MathF.Sqrt((float) (ulong)(object) x);
#endif
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The tangent of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NegativeInfinity"/>, or <see cref="Scalar{T}.PositiveInfinity"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Tan<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Tan((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Tan((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Tan((float) (object) x);
#else
                    return (T) (object) MathF.Tan((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Tan((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Tan((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Tan((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Tan((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Tan((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Tan((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Tan((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Tan((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Tan((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Tan((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle.
        /// </summary>
        /// <param name="x">An angle, measured in radians.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The hyperbolic tangent of <paramref name="x"/>. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NegativeInfinity"/>, this method returns -1. If <paramref name="x"/> is equal to <see cref="Scalar{T}.PositiveInfinity"/>, this method returns 1. If <paramref name="x"/> is equal to <see cref="Scalar{T}.NaN"/>, this method returns <see cref="Scalar{T}.NaN"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Tanh<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Tanh((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Tanh((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Tanh((float) (object) x);
#else
                    return (T) (object) MathF.Tanh((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Tanh((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Tanh((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Tanh((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Tanh((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Tanh((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Tanh((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Tanh((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Tanh((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Tanh((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Tanh((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Calculates the integral part of a specified single-precision floating-point number.
        /// </summary>
        /// <param name="x">A number to truncate.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>
        /// The integral part of <paramref name="x"/>; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/></term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term><see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term><see cref="Scalar{T}.NegativeInfinity"/></term>
        /// <description><see cref="Scalar{T}.NegativeInfinity"/></description>
        /// </item>
        /// <item>
        /// <term><see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Truncate<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Truncate((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Truncate((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Truncate((float) (object) x);
#else
                    return (T) (object) MathF.Truncate((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Truncate((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Truncate((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the natural (base <c>e</c>) logarithm of a specified number.
        /// </summary>
        /// <param name="x">The number whose logarithm is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/> parameter</term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term>Positive</term>
        /// <description>The natural logarithm of <paramref name="x"/>; that is, ln <paramref name="x"/>, or log e <paramref name="x"/></description>
        /// </item>
        /// <item>
        /// <term>Zero</term>
        /// <description><see cref="Scalar{T}.NegativeInfinity"/></description>
        /// </item>
        /// <item>
        /// <term>Negative</term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Log<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreFastLog((float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreFastLog((float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Log((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Log((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Log((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="x">The number whose logarithm is to be found.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table.
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/> parameter</term>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term>Positive</term>
        /// <description>The base 10 log of <paramref name="x"/>; that is log 10 <paramref name="x"/></description>
        /// </item>
        /// <item>
        /// <term>Zero</term>
        /// <description><see cref="Scalar{T}.NegativeInfinity"/></description>
        /// </item>
        /// <item>
        /// <term>Negative</term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.NaN"/></term>
        /// <description><see cref="Scalar{T}.NaN"/></description>
        /// </item>
        /// <item>
        /// <term>Equal to <see cref="Scalar{T}.PositiveInfinity"/></term>
        /// <description><see cref="Scalar{T}.PositiveInfinity"/></description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Log10<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Log10((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Log10((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Log10((float) (object) x);
#else
                    return (T) (object) MathF.Log10((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Log10((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log10((sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log10((byte) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log10((short) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log10((ushort) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log10((int) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log10((uint) (object) x);
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log10((long) (object) x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Log10((Complex) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Log10((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="x">A number to be rounded.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>
        /// The integer nearest <paramref name="x"/>. If the fractional component of <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns <typeparamref name="T"/> instead of an integral type
        /// </returns>
        /// <remarks>
        /// This method uses the default rounding convention of <see cref="MidpointRounding.ToEven"/>.
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x);
#else
                return (T) (object) (Half) MathF.Round((float) (Half) (object) x);
#endif
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        return (T)(object)(float)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(float)AdvSimd.RoundToNearestScalar(Vector64.CreateScalar((float)(object)x)).ToScalar();
                    }
#endif      
#if !MATHF
                    return (T) (object) (float) Math.Round((float) (object) x);
#else
                    return (T) (object) MathF.Round((float) (object) x);
#endif
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        return (T)(object)(double)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (T)(object)(double)AdvSimd.RoundToNearestScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                    }
#endif      
                    return (T) (object) (double) Math.Round((double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Round((decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the remainder resulting from the division of a specified number by another specified number.
        /// </summary>
        /// <param name="x">A dividend.</param>
        /// <param name="y">A divisor.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>
        /// A number equal to <paramref name="x"/> - (<paramref name="y"/> Q), where Q is the quotient of <paramref name="x"/> / <paramref name="y"/> rounded to the nearest integer (if <paramref name="x"/> / <paramref name="y"/> falls halfway between two integers, the even integer is returned).
        /// 
        /// If <paramref name="x"/> - (<paramref name="y"/> Q) is zero, the value +0 is returned if <paramref name="x"/> is positive, or -0 if <paramref name="x"/> is negative.
        /// 
        /// If <paramref name="y"/> = 0, NaN is returned.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T IEEERemainder<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.IEEERemainder
                    ((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.IEEERemainder((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.IEEERemainder((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.IEEERemainder((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.IEEERemainder((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.IEEERemainder((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.IEEERemainder((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.IEEERemainder((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.IEEERemainder((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.IEEERemainder((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.IEEERemainder((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.IEEERemainder((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.IEEERemainder((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="x">The number whose logarithm is to be found.</param>
        /// <param name="y">The base.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>
        /// One of the values in the following table. (+Infinity denotes <see cref="Scalar{T}.PositiveInfinity"/>, -Infinity denotes <see cref="Scalar{T}.NegativeInfinity"/>, and NaN denotes <see cref="Scalar{T}.NaN"/>.)
        /// <list type="table">
        /// <listheader>
        /// <term><paramref name="x"/></term>
        /// <description><c>newBase</c></description>
        /// <description>Return value</description>
        /// </listheader>
        /// <item>
        /// <term><paramref name="x"/>&gt;0</term>
        /// <description>(0&lt;<c>newBase</c>&lt;1) -or- (<c>newBase</c>&gt;1)</description>
        /// <description>lognewBase(a)</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/>&lt;0</term>
        /// <description>(any value)</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term>(any value)</term>
        /// <description><c>newBase</c>&lt;0</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> != 1</term>
        /// <description><c>newBase</c> = 0</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> != 1</term>
        /// <description><c>newBase</c> = +Infinity</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = NaN</term>
        /// <description>(any value)</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term>(any value)</term>
        /// <description><c>newBase</c> = NaN</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term>(any value)</term>
        /// <description><c>newBase</c> = 1</description>
        /// <description>NaN</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 0</term>
        /// <description>0 &lt; <c>newBase</c> &lt; 1</description>
        /// <description>+Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 0</term>
        /// <description><c>newBase</c> &gt; 1</description>
        /// <description>-Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = +Infinity</term>
        /// <description>0 &lt; <c>newBase</c> &lt; 1</description>
        /// <description>-Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = +Infinity</term>
        /// <description><c>newBase</c> &gt; 1</description>
        /// <description>+Infinity</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 1</term>
        /// <description><c>newBase</c> = 0</description>
        /// <description>0</description>
        /// </item>
        /// <item>
        /// <term><paramref name="x"/> = 1</term>
        /// <description><c>newBase</c> = +Infinity</description>
        /// <description>0</description>
        /// </item>
        /// </list>
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Log<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Log((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Log((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Log((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Log((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Log((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log((long) (object) x, (long) (object) y);
                }

                return Complex(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x, T y)
            {
                if (typeof(T) == typeof(Complex))
                {
                    // Complex.Log is not defined on two complex numbers
                    var baseValue = (Complex) (object) y;
                    if (baseValue.Imaginary is 0)
                        return (T) (object) (Complex) System.Numerics.Complex.Log((Complex) (object) x, baseValue.Real);
                    // log(x, y) = log(x) / log(y)
                    return (T) (object) (System.Numerics.Complex.Log((Complex) (object) x) / System.Numerics.Complex.Log(baseValue));
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Log((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the larger of two numbers.
        /// </summary>
        /// <param name="x">The first of two numbers to compare.</param>
        /// <param name="y">The second of two numbers to compare.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>Parameter <paramref name="x"/> or <paramref name="y"/>, whichever is larger. If <paramref name="x"/>, or <paramref name="y"/>, or both <paramref name="x"/> and <paramref name="y"/> are equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NaN"/> is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Max<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Max((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Max((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Max((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Max((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Max((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Max((decimal) (object) x, (decimal) (object) y);
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Max((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Max((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Max((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Max((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Max((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Max((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Max((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Max((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the smaller of two numbers.
        /// </summary>
        /// <param name="x">The first of two numbers to compare.</param>
        /// <param name="y">The second of two numbers to compare.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>Parameter <paramref name="x"/> or <paramref name="y"/>, whichever is smaller. If <paramref name="x"/>, or <paramref name="y"/>, or both <paramref name="x"/> and <paramref name="y"/> are equal to <see cref="Scalar{T}.NaN"/>, <see cref="Scalar{T}.NaN"/> is returned.</returns>
        [MethodImpl(MaxOpt)]
        public static T Min<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Min((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Min((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Min((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Min((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Min((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Min((decimal) (object) x, (decimal) (object) y);
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Min((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Min((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Min((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Min((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Min((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Min((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Min((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Min((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A number to be raised to a power.</param>
        /// <param name="y">A number that specifies a power.</param>
        /// <typeparam name="T">The type of <paramref name="x"/> and <paramref name="y"/>.</typeparam>
        /// <returns>The number <paramref name="x"/> raised to the power <paramref name="y"/>.</returns>
        ///         <remarks>
        ///         <format type="text/markdown"><![CDATA[  
        ///   
        /// ## Remarks  
        ///             The following table indicates the return value when various values or ranges of values are specified for the `x` and `y` parameters. For more information, see <xref:System.Single.PositiveInfinity?displayProperty=nameWithType>, <xref:System.Single.NegativeInfinity?displayProperty=nameWithType>, and <xref:System.Single.NaN?displayProperty=nameWithType>.  
        ///   
        ///         |Parameters|Return value|  
        ///         |----------------|------------------|  
        ///         |`x` or `y` = `NaN`.|`NaN`|  
        ///         |`x` = Any value except `NaN`; `y` = 0.|1|  
        ///         |`x` = `NegativeInfinity`; `y` < 0.|0|  
        ///         |`x` = `NegativeInfinity`; `y` is a positive odd integer.|`NegativeInfinity`|  
        ///         |`x` = `NegativeInfinity`; `y` is positive but not an odd integer.|`PositiveInfinity`|  
        ///         |`x` < 0 but not `NegativeInfinity`; `y` is not an integer, `NegativeInfinity`, or `PositiveInfinity`.|`NaN`|  
        ///         |`x` = -1; `y` = `NegativeInfinity` or `PositiveInfinity`.|`NaN`|  
        ///         |-1 < `x` < 1; `y` = `NegativeInfinity`.|`PositiveInfinity`|  
        ///         |-1 < `x` < 1; `y` = `PositiveInfinity`.|0|  
        ///         |`x` < -1 or `x` > 1; `y` = `NegativeInfinity`.|0|  
        ///         |`x` < -1 or `x` > 1; `y` = `PositiveInfinity`.|`PositiveInfinity`|  
        ///         |`x` = 0; `y` < 0.|`PositiveInfinity`|  
        ///         |`x` = 0; `y` > 0.|0|  
        ///         |`x` = 1; `y` is any value except `NaN`.|1|  
        ///         |`x` = `PositiveInfinity`; `y` < 0.|0|  
        ///         |`x` = `PositiveInfinity`; `y` > 0.|`PositiveInfinity`|  
        ///   
        ///         ]]></format>
        ///         </remarks>
        [MethodImpl(MaxOpt)]
        public static T Pow<T>(T x, T y) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreFastPow((float) (Half) (object) x, (float) (Half) (object) y);
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreFastPow((float) (object) x, (float) (object) y);
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Pow((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    var py = (sbyte) (object) y;
                    var px = (sbyte) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        sbyte result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (sbyte) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (sbyte) 1;
                        else return (T) (object) (sbyte) 0;
                    }
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    var py = (byte) (object) y;
                    var px = (byte) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        byte result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (byte) 1;
                        else return (T) (object) (byte) 0;
                    }
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    var py = (short) (object) y;
                    var px = (short) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        short result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (short) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (short) 1;
                        else return (T) (object) (short) 0;
                    }
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    var py = (ushort) (object) y;
                    var px = (ushort) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        ushort result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (ushort) 1;
                        else return (T) (object) (ushort) 0;
                    }
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    var py = (int) (object) y;
                    var px = (int) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        int result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (int) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (int) 1;
                        else return (T) (object) (int) 0;
                    }
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    var py = (uint) (object) y;
                    var px = (uint) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        uint result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (uint) 1;
                        else return (T) (object) (uint) 0;
                    }
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    var py = (long) (object) y;
                    var px = (long) (object) x;
                    if (py != 0)
                    {
                        var oabsy = Abs(py);
                        var absy = oabsy;
                        long result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        if (oabsy == py)
                            return (T) (object) result;
                        return (T) (object) (long) Scalar.Reciprocal(result);
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (long) 1;
                        else return (T) (object) (long) 0;
                    }
                }

                return Complex(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x, T y)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T) (object) (Complex) System.Numerics.Complex.Pow((Complex) (object) x, (Complex) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    var py = (ulong) (object) y;
                    var px = (ulong) (object) x;
                    if (py != 0)
                    {
                        var oabsy = py;
                        var absy = oabsy;
                        ulong result = 1;
                        while (true)
                        {
                            if ((absy & 1) != 0)
                                result *= px;
                            absy >>= 1;
                            if (absy == 0)
                                break;
                            px *= px;
                        }

                        return (T) (object) result;
                    }
                    else
                    {
                        if (px != 0) return (T) (object) (ulong) 1;
                        else return (T) (object) (ulong) 0;
                    }
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers.
        /// </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point.</param>
        /// <typeparam name="T">The type of <paramref name="y"/> and <paramref name="x"/>.</typeparam>
        /// <returns>
        /// An angle, θ, measured in radians, such that -π ≤ θ ≤ π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane. Observe the following:
        /// <list type="bullet">
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 1, 0 &lt; θ &lt; π/2.</description></item>
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 2, π/2 &lt; θ ≤ π.</description></item>
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 3, -π &lt; θ &lt; -π/2.</description></item>
        /// <item><description>For (<paramref name="x"/>, <paramref name="y"/>) in quadrant 4, -π/2 &lt; θ &lt; 0.</description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description>If y is 0 and x is not negative, θ = 0.</description></item>
        /// <item><description>If y is 0 and x is negative, θ = π.</description></item>
        /// <item><description>If y is positive and x is 0, θ = π/2.</description></item>
        /// <item><description>If y is 0 and x is 0, θ = -π/2.</description></item>
        /// </list>
        /// If <paramref name="x"/> or <paramref name="y"/> is <see cref="Scalar{T}.NaN"/>, or if <paramref name="x"/> and <paramref name="y"/> are either <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// </returns>
        /// <remarks>
        /// The return value is the angle in the Cartesian plane formed by the x-axis, and a vector starting from the origin, (0,0), and terminating at the point, (x,y).
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Atan2<T>(T y, T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Atan2((float) (Half) (object) x, (float) (Half) (object) y);
#else
                return (T) (object) (Half) MathF.Atan2((float) (Half) (object) x, (float) (Half) (object) y);
#endif
            }

            return Float(x, y);

            [MethodImpl(MaxOpt)]
            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !MATHF
                    return (T) (object) (float) Math.Atan2((float) (object) x, (float) (object) y);
#else
                    return (T) (object) MathF.Atan2((float) (object) x, (float) (object) y);
#endif
                }

                return Double(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Atan2((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Atan2((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Atan2((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Atan2((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Atan2((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Atan2((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Atan2((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Atan2((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Atan2((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="x">A number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The number nearest to <paramref name="x"/> that contains a number of fractional digits equal to digits.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="digits"/> is less than 0 or greater than the maximum number of integral and fractional digits supported by the <typeparamref name="T"/> type.</exception>
        /// <remarks>
        /// This method uses the default rounding convention of <see cref="MidpointRounding.ToEven"/>
        /// If the value of <paramref name="x"/> is <see cref="Scalar{T}.NaN"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// If <paramref name="x"/> is <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, respectively.
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, int digits) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if MATHF
                return (T) (object) (Half) (float) MathF.Round((float)(Half) (object) x, digits);
#else
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x, digits);
#endif
            }

            return Float(x, digits);

            [MethodImpl(MaxOpt)]
            static T Float(T x, int digits)
            {
                if (typeof(T) == typeof(float))
                {
#if MATHF
                    return (T) (object) (float) MathF.Round((float)(object) x, digits);
#else
                    return (T) (object) (float) Math.Round((float) (object) x, digits);
#endif
                }

                return Double(x, digits);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, int digits)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Round((double) (object) x, digits);
                }

                return Decimal(x, digits);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, int digits)
            {
                if (typeof(T) == typeof(decimal))
                    ThrowOpUnsupportedPrecision();

                return Other(x, digits);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T x, int digits)
            {
                if (typeof(T) == typeof(sbyte)
                || typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(long)
                )
                    return x;

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to a specified number of fractional digits, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="x">A number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <param name="mode">Specification for how to round <paramref name="x"/> if it is midway between two other numbers.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The number nearest to <paramref name="x"/> that contains a number of fractional digits equal to digits. If <paramref name="x"/> has fewer fractional digits than <paramref name="digits"/>, <paramref name="x"/> is returned unchanged.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="digits"/> is less than 0 or greater than the maximum number of integral and fractional digits supported by the <typeparamref name="T"/> type.</exception>
        /// <remarks>
        /// If the value of <paramref name="x"/> is <see cref="Scalar{T}.NaN"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// If <paramref name="x"/> is <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, respectively.
        /// </remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, int digits, System.MidpointRounding mode) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if MATHF
                return (T) (object) (Half) (float) MathF.Round((float)(Half) (object) x, digits, mode);
#else
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x, digits, mode);
#endif
            }

            return Float(x, digits, mode);

            [MethodImpl(MaxOpt)]
            static T Float(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(float))
                {
#if MATHF
                    return (T) (object) (float) MathF.Round((float)(object) x, digits, mode);
#else
                    return (T) (object) (float) Math.Round((float) (object) x, digits, mode);
#endif
                }

                return Double(x, digits, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Round((double) (object) x, digits, mode);
                }

                return Decimal(x, digits, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(decimal))
                    ThrowOpUnsupportedPrecision();

                return Other(x, digits, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T x, int digits, MidpointRounding mode)
            {
                if (typeof(T) == typeof(sbyte)
                || typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(long)

                )
                    return x;

                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Rounds a single-precision floating-point value to the nearest integer, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="x">A single-precision floating-point number to be rounded.</param>
        /// <param name="mode">Specification for how to round x if it is midway between two other numbers.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The integer nearest <paramref name="x"/>. If <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then mode determines which of the two is returned. Note that this method returns <typeparamref name="T"/> instead of an integral type.</returns>
        /// <exception cref="ArgumentException"><paramref name="mode"/> is not a valid value of <see cref="MidpointRounding"/>.</exception>
        /// <remarks>
        /// If the value of <paramref name="x"/> is <see cref="Scalar{T}.NaN"/>, the method returns <see cref="Scalar{T}.NaN"/>.
        /// If <paramref name="x"/> is <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, the method returns <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>, respectively.
        /// \</remarks>
        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, System.MidpointRounding mode) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
#if !MATHF
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x, mode);
#else
                return (T) (object) (Half) MathF.Round((float) (Half) (object) x, mode);
#endif
            }

            return Float(x, mode);

            [MethodImpl(MaxOpt)]
            static T Float(T x, MidpointRounding mode)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(float)Sse41.RoundToZeroScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(float)Sse41.RoundToPositiveInfinityScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                            
                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(float)Sse41.RoundToNegativeInfinityScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(float)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(float)AdvSimd.RoundToZeroScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(float)AdvSimd.RoundToPositiveInfinityScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();
                            
                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(float)AdvSimd.RoundToNegativeInfinityScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(float)AdvSimd.RoundToNearestScalar(Vector64.CreateScalarUnsafe((float)(object)x)).ToScalar();
                    }
#endif
#if !MATHF
                    return (T) (object) (float) Math.Round((float) (object) x, mode);
#else
                    return (T) (object) MathF.Round((float) (object) x, mode);
#endif
                }

                return Double(x, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x, MidpointRounding mode)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse42.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(double)Sse41.RoundToZeroScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(double)Sse41.RoundToPositiveInfinityScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                            
                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(double)Sse41.RoundToNegativeInfinityScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(double)Sse41.RoundToNearestIntegerScalar(Vector128.CreateScalarUnsafe((double)(object)x)).ToScalar();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        if (mode == MidpointRounding.ToZero)
                            return (T)(object)(double)AdvSimd.RoundToZeroScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToPositiveInfinity)
                            return (T)(object)(double)AdvSimd.RoundToPositiveInfinityScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                            
                        if (mode == MidpointRounding.ToNegativeInfinity)
                            return (T)(object)(double)AdvSimd.RoundToNegativeInfinityScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                        
                        if (mode == MidpointRounding.ToEven)
                            return (T)(object)(double)AdvSimd.RoundToNearestScalar(Vector64.CreateScalar((double)(object)x)).ToScalar();
                    }
#endif
                    return (T) (object) (double) Math.Round((double) (object) x, mode);
                }

                return Decimal(x, mode);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x, MidpointRounding mode)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Round((decimal) (object) x, mode);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                ThrowUnsupportedType();
                return default;
            }
        }
    }
}