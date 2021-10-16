// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

// casting into non-nullable, unboxing from nullable  
#pragma warning disable 8600
#pragma warning disable 8605

namespace Silk.NET.Maths
{
    /// <summary>
    /// A collection of operations for working with scalar numeric values.
    /// Includes methods like the ones found in <see cref="Math"/> and more.
    /// Supports <see cref="Half"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>, <see cref="sbyte"/>, <see cref="byte"/>, <see cref="ushort"/>, <see cref="short"/>, <see cref="uint"/>, <see cref="int"/>, <see cref="ulong"/> and <see cref="long"/>
    /// </summary>
    /// <seealso cref="Scalar{T}"/>
    public partial class Scalar
    {
        /// <summary>
        /// Convert <paramref name="val"/> from <typeparamref name="TFrom"/> to <typeparamref name="TTo"/>
        /// </summary>
        /// <param name="val">The value to convert</param>
        /// <typeparam name="TFrom">The type converted from</typeparam>
        /// <typeparam name="TTo">The type converted into</typeparam>
        /// <returns>The converted value</returns>
        [MethodImpl(MaxOpt)]
        public static TTo As<TFrom, TTo>(TFrom val) where TFrom : notnull where TTo : notnull
        {
            if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(Half))
            {
                return (TTo) (object) (Half) (Half) (object) val;
            }

            return FromHalfToFloat(val);
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (Half) (object) val;
                }

                return FromHalfToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (Half) (object) val;
                }

                return FromHalfToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (float) (Half) (object) val;
                }

                return FromHalfToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (Half) (object) val;
                }

                return FromHalfToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (Half) (object) val;
                }

                return FromHalfToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (Half) (object) val;
                }

                return FromHalfToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (Half) (object) val;
                }

                return FromHalfToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (Half) (object) val;
                }

                return FromHalfToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (Half) (object) val;
                }

                return FromHalfToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (Half) (object) val;
                }

                return FromHalfToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromHalfToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(Half) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (Half) (object) val;
                }

                return FromFloatToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (float) (object) val;
                }

                return FromFloatToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (float) (object) val;
                }

                return FromFloatToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (float) (object) val;
                }

                return FromFloatToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (float) (object) val;
                }

                return FromFloatToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (float) (object) val;
                }

                return FromFloatToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (float) (object) val;
                }

                return FromFloatToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (float) (object) val;
                }

                return FromFloatToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (float) (object) val;
                }

                return FromFloatToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (float) (object) val;
                }

                return FromFloatToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (float) (object) val;
                }

                return FromFloatToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (float) (object) val;
                }

                return FromFloatToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromFloatToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(float) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (float) (object) val;
                }

                return FromDoubleToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (double) (object) val;
                }

                return FromDoubleToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (double) (object) val;
                }

                return FromDoubleToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (double) (object) val;
                }

                return FromDoubleToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (double) (object) val;
                }

                return FromDoubleToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (double) (object) val;
                }

                return FromDoubleToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (double) (object) val;
                }

                return FromDoubleToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (double) (object) val;
                }

                return FromDoubleToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (double) (object) val;
                }

                return FromDoubleToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (double) (object) val;
                }

                return FromDoubleToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (double) (object) val;
                }

                return FromDoubleToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (double) (object) val;
                }

                return FromDoubleToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDoubleToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(double) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (double) (object) val;
                }

                return FromDecimalToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (float) (decimal) (object) val;
                }

                return FromDecimalToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (decimal) (object) val;
                }

                return FromDecimalToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (decimal) (object) val;
                }

                return FromDecimalToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (decimal) (object) val;
                }

                return FromDecimalToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (decimal) (object) val;
                }

                return FromDecimalToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (decimal) (object) val;
                }

                return FromDecimalToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (decimal) (object) val;
                }

                return FromDecimalToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (decimal) (object) val;
                }

                return FromDecimalToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (decimal) (object) val;
                }

                return FromDecimalToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (decimal) (object) val;
                }

                return FromDecimalToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (decimal) (object) val;
                }

                return FromDecimalToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromDecimalToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(decimal) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (decimal) (object) val;
                }

                return FromSbyteToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (sbyte) (object) val;
                }

                return FromSbyteToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (sbyte) (object) val;
                }

                return FromSbyteToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (sbyte) (object) val;
                }

                return FromSbyteToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (sbyte) (object) val;
                }

                return FromSbyteToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (sbyte) (object) val;
                }

                return FromSbyteToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (sbyte) (object) val;
                }

                return FromSbyteToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (sbyte) (object) val;
                }

                return FromSbyteToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (sbyte) (object) val;
                }

                return FromSbyteToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (sbyte) (object) val;
                }

                return FromSbyteToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (sbyte) (object) val;
                }

                return FromSbyteToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (sbyte) (object) val;
                }

                return FromSbyteToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromSbyteToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(sbyte) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (sbyte) (object) val;
                }

                return FromByteToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (byte) (object) val;
                }

                return FromByteToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (byte) (object) val;
                }

                return FromByteToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (byte) (object) val;
                }

                return FromByteToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (byte) (object) val;
                }

                return FromByteToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (byte) (object) val;
                }

                return FromByteToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (byte) (object) val;
                }

                return FromByteToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (byte) (object) val;
                }

                return FromByteToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (byte) (object) val;
                }

                return FromByteToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (byte) (object) val;
                }

                return FromByteToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (byte) (object) val;
                }

                return FromByteToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (byte) (object) val;
                }

                return FromByteToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromByteToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(byte) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (byte) (object) val;
                }

                return FromShortToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (short) (object) val;
                }

                return FromShortToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (short) (object) val;
                }

                return FromShortToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (short) (object) val;
                }

                return FromShortToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (short) (object) val;
                }

                return FromShortToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (short) (object) val;
                }

                return FromShortToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (short) (object) val;
                }

                return FromShortToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (short) (object) val;
                }

                return FromShortToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (short) (object) val;
                }

                return FromShortToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (short) (object) val;
                }

                return FromShortToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (short) (object) val;
                }

                return FromShortToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (short) (object) val;
                }

                return FromShortToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromShortToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(short) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (short) (object) val;
                }

                return FromUshortToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (ushort) (object) val;
                }

                return FromUshortToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (ushort) (object) val;
                }

                return FromUshortToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (ushort) (object) val;
                }

                return FromUshortToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (ushort) (object) val;
                }

                return FromUshortToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (ushort) (object) val;
                }

                return FromUshortToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (ushort) (object) val;
                }

                return FromUshortToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (ushort) (object) val;
                }

                return FromUshortToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (ushort) (object) val;
                }

                return FromUshortToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (ushort) (object) val;
                }

                return FromUshortToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (ushort) (object) val;
                }

                return FromUshortToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (ushort) (object) val;
                }

                return FromUshortToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUshortToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(ushort) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (ushort) (object) val;
                }

                return FromIntToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (int) (object) val;
                }

                return FromIntToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (int) (object) val;
                }

                return FromIntToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (int) (object) val;
                }

                return FromIntToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (int) (object) val;
                }

                return FromIntToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (int) (object) val;
                }

                return FromIntToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (int) (object) val;
                }

                return FromIntToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (int) (object) val;
                }

                return FromIntToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (int) (object) val;
                }

                return FromIntToInt(val);
            }

            [MethodImpl(MaxOpt)]
            static TTo FromIntToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (int) (object) val;
                }

                return FromIntToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (int) (object) val;
                }

                return FromIntToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (int) (object) val;
                }

                return FromIntToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromIntToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(int) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (int) (object) val;
                }

                return FromUintToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (uint) (object) val;
                }

                return FromUintToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (uint) (object) val;
                }

                return FromUintToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (uint) (object) val;
                }

                return FromUintToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (uint) (object) val;
                }

                return FromUintToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (uint) (object) val;
                }

                return FromUintToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (uint) (object) val;
                }

                return FromUintToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (uint) (object) val;
                }

                return FromUintToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (uint) (object) val;
                }

                return FromUintToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (uint) (object) val;
                }

                return FromUintToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (uint) (object) val;
                }

                return FromUintToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (uint) (object) val;
                }

                return FromUintToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUintToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(uint) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (uint) (object) val;
                }

                return FromLongToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (long) (object) val;
                }

                return FromLongToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (long) (object) val;
                }

                return FromLongToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (long) (object) val;
                }

                return FromLongToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (long) (object) val;
                }

                return FromLongToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (long) (object) val;
                }

                return FromLongToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (long) (object) val;
                }

                return FromLongToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (long) (object) val;
                }

                return FromLongToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (long) (object) val;
                }

                return FromLongToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (long) (object) val;
                }

                return FromLongToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (long) (object) val;
                }

                return FromLongToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (long) (object) val;
                }

                return FromLongToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromLongToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(long) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (long) (object) val;
                }

                return FromUlongToHalf(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToHalf(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(Half))
                {
                    return (TTo) (object) (Half) (ulong) (object) val;
                }

                return FromUlongToFloat(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToFloat(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(float))
                {
                    return (TTo) (object) (float) (ulong) (object) val;
                }

                return FromUlongToDouble(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToDouble(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(double))
                {
                    return (TTo) (object) (double) (ulong) (object) val;
                }

                return FromUlongToDecimal(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToDecimal(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(decimal))
                {
                    return (TTo) (object) (decimal) (ulong) (object) val;
                }

                return FromUlongToSbyte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToSbyte(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(sbyte))
                {
                    return (TTo) (object) (sbyte) (ulong) (object) val;
                }

                return FromUlongToByte(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToByte(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(byte))
                {
                    return (TTo) (object) (byte) (ulong) (object) val;
                }

                return FromUlongToShort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToShort(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(short))
                {
                    return (TTo) (object) (short) (ulong) (object) val;
                }

                return FromUlongToUshort(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToUshort(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(ushort))
                {
                    return (TTo) (object) (ushort) (ulong) (object) val;
                }

                return FromUlongToInt(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToInt(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(int))
                {
                    return (TTo) (object) (int) (ulong) (object) val;
                }

                return FromUlongToUint(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToUint(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(uint))
                {
                    return (TTo) (object) (uint) (ulong) (object) val;
                }

                return FromUlongToLong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToLong(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(long))
                {
                    return (TTo) (object) (long) (ulong) (object) val;
                }

                return FromUlongToUlong(val);
            }
            [MethodImpl(MaxOpt)]
            static TTo FromUlongToUlong(TFrom val)
            {
                if (typeof(TFrom) == typeof(ulong) && typeof(TTo) == typeof(ulong))
                {
                    return (TTo) (object) (ulong) (ulong) (object) val;
                }

                ThrowUnsupportedType();
                return default;
            }
        }
    }
}