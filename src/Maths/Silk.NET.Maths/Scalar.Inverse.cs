// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

// casting into non-nullable, unboxing from nullable  
#pragma warning disable 8600
#pragma warning disable 8605

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        /// <summary>
        /// Calculates the reciprocal of a number.
        /// </summary>
        /// <param name="x">The number.</param>
        /// <typeparam name="T">The type of <paramref name="x"/>.</typeparam>
        /// <returns>The reciprocal of the given number.</returns>
        [MethodImpl(MaxOpt)]
        public static T Reciprocal<T>(T x) where T : notnull
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (1f / (float) (Half) (object) x);
            }

            return Float(x);

            [MethodImpl(MaxOpt)]
            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) (1f / (float) (object) x);
                }

                return Double(x);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (1d / (double) (object) x);
                }

                return Decimal(x);
            }

            [MethodImpl(MaxOpt)]
            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal.One / (decimal) (object) x);
                }

                return SByte(x);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) (((sbyte) 1) / (sbyte) (object) x);
                }

                return Byte(x);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) (((byte) 1) / (byte) (object) x);
                }

                return UShort(x);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) (((ushort) 1) / (ushort) (object) x);
                }

                return Short(x);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) (((short) 1) / (short) (object) x);
                }

                return UInt(x);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (((uint) 1) / (uint) (object) x);
                }

                return Int(x);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (((int) 1) / (int) (object) x);
                }

                return ULong(x);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {

                    return (T) (object) (((ulong) 1) / (ulong) (object) x);

                }

                return Long(x);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (((long) 1) / (long) (object) x);
                }

                return BigInteger(x);
            }

            [MethodImpl(MaxOpt)]
            static T BigInteger(T x)
            {
                if (typeof(T) == typeof(BigInteger))
                {
                    return (T)(object)(1 / (BigInteger)(object)x);
                }

                return Complex(x);
            }

            [MethodImpl(MaxOpt)]
            static T Complex(T x)
            {
                if (typeof(T) == typeof(Complex))
                {
                    return (T)(object)(1 / (Complex)(object)x);
                }

                return Other(x);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T _)
            {
                ThrowUnsupportedType();
                return default!;
            }
        }
    }
}