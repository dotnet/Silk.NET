// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
// ReSharper disable CompareOfFloatsByEqualityOperator

// casting into non-nullable, unboxing from nullable  
#pragma warning disable 8600
#pragma warning disable 8605

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        internal const MethodImplOptions MaxOpt = MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512;

        internal static void ThrowUnsupportedType()
            => throw new NotSupportedException("The given type is unsupported for generic maths.");

        internal static void ThrowOpUnsupportedType()
            => throw new NotSupportedException("This operation is not applicable for the given type.");

        internal static void ThrowOpUnsupportedPrecision()
            => throw new NotImplementedException
            (
                "This operation is not applicable for the given type due to a high-enough precision algorithm not " +
                "being available."
            );

        private static void ThrowIndexOutOfRange() => throw new IndexOutOfRangeException();

        /// <summary>
        /// Indicates whether members are hardware accelerated. Not all members support hardware acceleration.
        /// </summary>
        public static bool IsHardwareAccelerated => false
#if SSE
        || Sse.IsSupported
#endif
#if AdvSIMD
        || AdvSimd.IsSupported
#endif
        ;

        /// <summary>
        /// Determines whether the specified value is finite (zero, subnormal, or normal).
        /// </summary>
        /// <param name="f">A number.</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is finite (zero, subnormal or normal); <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsFinite<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsFinite((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return CoreIsFinite((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    // double.IsFinite doesn't exist on netstandard2.0
                    long bits = BitConverter.DoubleToInt64Bits((double) (object) f);
                    return (bits & 0x7FFFFFFFFFFFFFFF) < 0x7FF0000000000000;
                }

                return Complex(f);
            }
            
            [MethodImpl(MaxOpt)]
            static bool Complex(T f)
            {
                if (typeof(T) == typeof(Complex))
                {
#if NETCOREAPP3_0_OR_GREATER
                    return System.Numerics.Complex.IsFinite((Complex)(object)f);
#else
// https://source.dot.net/#System.Runtime.Numerics/System/Numerics/Complex.cs,6b0a0cd37123d4d3
                    return IsFinite(((Complex)(object)f).Real) && IsFinite(((Complex)(object)f).Imaginary); 
#endif
                }
                
                return Other(f); 
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(sbyte)
                || typeof(T) == typeof(byte)
                || typeof(T) == typeof(ushort)
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(uint)
                || typeof(T) == typeof(int)
                || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(long)
                || typeof(T) == typeof(decimal)
                || typeof(T) == typeof(BigInteger)
                )
                    return true;

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.PositiveInfinity"/> or <see cref="Scalar{T}.NegativeInfinity"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsInfinity<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsInfinity((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsInfinity((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return double.IsInfinity((double) (object) f);
                }

                return Complex(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Complex(T f)
            {
                if (typeof(T) == typeof(Complex))
                {
#if NETCOREAPP3_0_OR_GREATER
                    return System.Numerics.Complex.IsInfinity((Complex)(object)f);
#else
// https://source.dot.net/#System.Runtime.Numerics/System/Numerics/Complex.cs,fbf803cb00899f67,references
                    return double.IsInfinity(((Complex)(object)f).Real) || double.IsInfinity(((Complex)(object)f).Imaginary);
#endif
                }
                
                return Other(f); 
            }
            
            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(ulong)
                    || typeof(T) == typeof(long)
                    || typeof(T) == typeof(decimal)
                    || typeof(T) == typeof(BigInteger)
                )
                    return false;

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether the specified value is not a number (<see cref="Scalar{T}.NaN"/>).
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.NaN"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNaN<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNaN((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsNaN((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return double.IsNaN((double) (object) f);
                }

                return Complex(f);
            }
            
            [MethodImpl(MaxOpt)]
            static bool Complex(T f)
            {
                if (typeof(T) == typeof(Complex))
                {
#if NETCOREAPP3_0_OR_GREATER
                    return System.Numerics.Complex.IsNaN((Complex)(object)f);
#else
                    return !IsInfinity((Complex)(object)f) && !IsFinite((Complex)(object)f);
#endif
                }
                
                return Other(f); 
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(ulong)
                    || typeof(T) == typeof(long)
                    || typeof(T) == typeof(decimal)
                    || typeof(T) == typeof(BigInteger)
                )
                    return false;

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is negative; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNegative<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNegative((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return CoreIsNegative((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return CoreIsNegative((double) (object) f);
                }

                return Short(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T f)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) f < 0;
                }

                return Int(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T f)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) f < 0;
                }

                return Long(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T f)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) f < 0;
                }

                return Decimal(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T f)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) f < 0;
                }

                return SByte(f);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T f)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) f < 0;
                }

                return BigInteger(f);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T f)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) f < 0;
                }

                return Other(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(ulong)
                    
                )
                    return false;

                /* Complex is unsupported for negativity */
                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.NegativeInfinity"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNegativeInfinity<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNegativeInfinity((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsNegativeInfinity((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return double.IsNegativeInfinity((double) (object) f);
                }

                return Other(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(ulong)
                    || typeof(T) == typeof(long)
                    || typeof(T) == typeof(decimal)
                    || typeof(T) == typeof(BigInteger)
                )
                    return false;

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified value is normal.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is normal; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsNormal<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNormal((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return IsNormal((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return IsNormal((double) (object) f);
                }

                return Other(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(ulong)
                    || typeof(T) == typeof(long)
                    || typeof(T) == typeof(decimal)
                    || typeof(T) == typeof(BigInteger)
                )
                    return true;

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to positive infinity.
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if <paramref name="f"/> evaluates to <see cref="Scalar{T}.PositiveInfinity"/>; <code>false</code> otherwise.</returns>
        [MethodImpl(MaxOpt)]
        public static bool IsPositiveInfinity<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsPositiveInfinity((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsPositiveInfinity((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return double.IsPositiveInfinity((double) (object) f);
                }

                return Other(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T f)
            {
                if (typeof(T) == typeof(sbyte)
                    || typeof(T) == typeof(byte)
                    || typeof(T) == typeof(ushort)
                    || typeof(T) == typeof(short)
                    || typeof(T) == typeof(uint)
                    || typeof(T) == typeof(int)
                    || typeof(T) == typeof(ulong)
                    || typeof(T) == typeof(long)
                    || typeof(T) == typeof(decimal)
                    || typeof(T) == typeof(BigInteger)
                )
                    return false;

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified value is subnormal.    
        /// </summary>
        /// <param name="f">A number</param>
        /// <typeparam name="T">The type of the specified number.</typeparam>
        /// <returns><code>true</code> if the value is subnormal; <code>false</code> otherwise.</returns>
        /// <remarks>This function will throw for types other then <see cref="Half"/>, <see cref="float"/>, <see cref="double"/>, because subnormality cannot be determined for other types.</remarks>
        [MethodImpl(MaxOpt)]
        public static bool IsSubnormal<T>(T f) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsSubnormal((Half) (object) f);
            }

            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return CoreIsSubnormal((float) (object) f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return CoreIsSubnormal((double) (object) f);
                }

                ThrowOpUnsupportedType();
                return false;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether two specified values are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> and <paramref name="right"/> are equal; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool Equal<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) left == (Half) (object) right;
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static bool Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (float) (object) left == (float) (object) right;
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (double) (object) left == (double) (object) right;
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (decimal) (object) left == (decimal) (object) right;
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (sbyte) (object) left == (sbyte) (object) right;
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (byte) (object) left == (byte) (object) right;
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) left == (int) (object) right;
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (uint) (object) left == (uint) (object) right;
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) left == (long) (object) right;
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (ulong) (object) left == (ulong) (object) right;
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) left == (short) (object) right;
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (ushort) (object) left == (ushort) (object) right;
                }

                return BigInteger(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) left == (BigInteger) (object) right;
                }

                return Complex(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool Complex(T left, T right)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (Complex) (object) left == (Complex) (object) right;
                }

                return Other(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether two specified values are not equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> and <paramref name="right"/> are not equal; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool NotEqual<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) left != (Half) (object) right;
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static bool Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (float) (object) left != (float) (object) right;
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (double) (object) left != (double) (object) right;
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (decimal) (object) left != (decimal) (object) right;
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (sbyte) (object) left != (sbyte) (object) right;
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (byte) (object) left != (byte) (object) right;
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) left != (int) (object) right;
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (uint) (object) left != (uint) (object) right;
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) left != (long) (object) right;
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (ulong) (object) left != (ulong) (object) right;
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) left != (short) (object) right;
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (ushort) (object) left != (ushort) (object) right;
                }

                return BigInteger(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) left != (BigInteger) (object) right;
                }

                return Complex(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool Complex(T left, T right)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (Complex) (object) left != (Complex) (object) right;
                }

                return Other(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is greater than another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool GreaterThan<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) left > (Half) (object) right;
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static bool Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (float) (object) left > (float) (object) right;
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (double) (object) left > (double) (object) right;
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (decimal) (object) left > (decimal) (object) right;
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (sbyte) (object) left > (sbyte) (object) right;
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (byte) (object) left > (byte) (object) right;
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) left > (int) (object) right;
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (uint) (object) left > (uint) (object) right;
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) left > (long) (object) right;
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (ulong) (object) left > (ulong) (object) right;
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) left > (short) (object) right;
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (ushort) (object) left > (ushort) (object) right;
                }

                return BigInteger(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) left > (BigInteger) (object) right;
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is greater than or equal to another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool GreaterThanOrEqual<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) left >= (Half) (object) right;
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static bool Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (float) (object) left >= (float) (object) right;
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (double) (object) left >= (double) (object) right;
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (decimal) (object) left >= (decimal) (object) right;
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (sbyte) (object) left >= (sbyte) (object) right;
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (byte) (object) left >= (byte) (object) right;
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) left >= (int) (object) right;
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (uint) (object) left >= (uint) (object) right;
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) left >= (long) (object) right;
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (ulong) (object) left >= (ulong) (object) right;
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) left >= (short) (object) right;
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (ushort) (object) left >= (ushort) (object) right;
                }

                return BigInteger(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) left >= (BigInteger) (object) right;
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is less than another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is less than <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool LessThan<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) left < (Half) (object) right;
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static bool Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (float) (object) left < (float) (object) right;
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (double) (object) left < (double) (object) right;
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (decimal) (object) left < (decimal) (object) right;
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (sbyte) (object) left < (sbyte) (object) right;
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (byte) (object) left < (byte) (object) right;
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) left < (int) (object) right;
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (uint) (object) left < (uint) (object) right;
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) left < (long) (object) right;
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (ulong) (object) left < (ulong) (object) right;
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) left < (short) (object) right;
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (ushort) (object) left < (ushort) (object) right;
                }

                return BigInteger(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) left < (BigInteger) (object) right;
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Returns a value that indicates whether a specified value is less than or equal to another specified value.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns><code>true</code> if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise, <code>false</code>.</returns>
        [MethodImpl(MaxOpt)]
        public static bool LessThanOrEqual<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) left <= (Half) (object) right;
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static bool Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (float) (object) left <= (float) (object) right;
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (double) (object) left <= (double) (object) right;
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (decimal) (object) left <= (decimal) (object) right;
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (sbyte) (object) left <= (sbyte) (object) right;
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (byte) (object) left <= (byte) (object) right;
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (int) (object) left <= (int) (object) right;
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (uint) (object) left <= (uint) (object) right;
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (long) (object) left <= (long) (object) right;
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (ulong) (object) left <= (ulong) (object) right;
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (short) (object) left <= (short) (object) right;
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (ushort) (object) left <= (ushort) (object) right;
                }

                return BigInteger(left, right);
            }
            
            [MethodImpl(MaxOpt)]
            static bool BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (BigInteger) (object) left <= (BigInteger) (object) right;
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static bool Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }

        /// <summary>
        /// Adds two specified values.
        /// </summary>
        /// <param name="left">The first value to add.</param>
        /// <param name="right">The second value to add.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of adding <paramref name="left"/> and <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Add<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) left + (float) (Half) (object) right);
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static T Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) ((float) (object) left + (float) (object) right);
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) ((double) (object) left + (double) (object) right);
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) ((decimal) (object) left + (decimal) (object) right);
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) ((sbyte) (object) left + (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) ((byte) (object) left + (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) ((short) (object) left + (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) ((ushort) (object) left + (ushort) (object) right);
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) ((int) (object) left + (int) (object) right);
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) ((uint) (object) left + (uint) (object) right);
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) ((long) (object) left + (long) (object) right);
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) ((ulong) (object) left + (ulong) (object) right);
                }

                return BigInteger(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (T)(object)((BigInteger) (object) left + (BigInteger) (object) right);
                }

                return Complex(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T left, T right)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T)(object)((Complex) (object) left + (Complex) (object) right);
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default!;
            }
        }

        /// <summary>
        /// Subtracts two specified values.
        /// </summary>
        /// <param name="left">The minuend.</param>
        /// <param name="right">The subtrahend.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of subtracting <paramref name="left"/> from <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Subtract<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) left - (float) (Half) (object) right);
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static T Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) ((float) (object) left - (float) (object) right);
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) ((double) (object) left - (double) (object) right);
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) ((decimal) (object) left - (decimal) (object) right);
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) ((sbyte) (object) left - (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) ((byte) (object) left - (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) ((short) (object) left - (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) ((ushort) (object) left - (ushort) (object) right);
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) ((int) (object) left - (int) (object) right);
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) ((uint) (object) left - (uint) (object) right);
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) ((long) (object) left - (long) (object) right);
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) ((ulong) (object) left - (ulong) (object) right);
                }

                return BigInteger(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (T)(object)((BigInteger) (object) left - (BigInteger) (object) right);
                }

                return Complex(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T left, T right)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T)(object)((Complex) (object) left - (Complex) (object) right);
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default!;
            }
        }

        /// <summary>
        /// Multiplies two specified values.
        /// </summary>
        /// <param name="left">The first value to multiply.</param>
        /// <param name="right">The second value to multiply.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of multiplying <paramref name="left"/> and <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Multiply<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) left * (float) (Half) (object) right);
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static T Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) ((float) (object) left * (float) (object) right);
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) ((double) (object) left * (double) (object) right);
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) ((decimal) (object) left * (decimal) (object) right);
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) ((sbyte) (object) left * (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) ((byte) (object) left * (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) ((short) (object) left * (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) ((ushort) (object) left * (ushort) (object) right);
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) ((int) (object) left * (int) (object) right);
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) ((uint) (object) left * (uint) (object) right);
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) ((long) (object) left * (long) (object) right);
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) ((ulong) (object) left * (ulong) (object) right);
                }

                return BigInteger(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (T)(object)((BigInteger) (object) left * (BigInteger) (object) right);
                }

                return Complex(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T left, T right)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T)(object)((Complex) (object) left * (Complex) (object) right);
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default!;
            }
        }

        /// <summary>
        /// Divides two specified values.
        /// </summary>
        /// <param name="left">The dividend.</param>
        /// <param name="right">The divisor.</param>
        /// <typeparam name="T">The type of both values.</typeparam>
        /// <returns>The result of dividing <paramref name="left"/> by <paramref name="right"/>.</returns>
        [MethodImpl(MaxOpt)]
        public static T Divide<T>(T left, T right) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) left / (float) (Half) (object) right);
            }

            return Float(left, right);

            [MethodImpl(MaxOpt)]
            static T Float(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) ((float) (object) left / (float) (object) right);
                }

                return Double(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) ((double) (object) left / (double) (object) right);
                }

                return Decimal(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T left, T right)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) ((decimal) (object) left / (decimal) (object) right);
                }

                return SByte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) ((sbyte) (object) left / (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) ((byte) (object) left / (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) ((short) (object) left / (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) ((ushort) (object) left / (ushort) (object) right);
                }

                return Int(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) ((int) (object) left / (int) (object) right);
                }

                return UInt(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) ((uint) (object) left / (uint) (object) right);
                }

                return Long(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) ((long) (object) left / (long) (object) right);
                }

                return ULong(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) ((ulong) (object) left / (ulong) (object) right);
                }

                return BigInteger(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T BigInteger(T left, T right)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (T)(object)((BigInteger) (object) left / (BigInteger) (object) right);
                }

                return Complex(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T left, T right)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T)(object)((Complex) (object) left / (Complex) (object) right);
                }

                return Other(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T _, T __)
            {
                ThrowUnsupportedType();
                return default!;
            }
        }

        /// <summary>
        /// Returns the result of multiplying the specified value by negative one.
        /// </summary>
        /// <param name="x">The value to negate</param>
        /// <typeparam name="T">The type of the value</typeparam>
        /// <returns>
        /// A number with the value of <paramref name="x"/>, but the opposite sign.
        /// -or-
        /// Zero, if <paramref name="x"/> is zero.
        /// </returns>
        [MethodImpl(MaxOpt)]
        public static T Negate<T>(T x) where T : notnull => Multiply(x, Scalar<T>.MinusOne);
    }
}