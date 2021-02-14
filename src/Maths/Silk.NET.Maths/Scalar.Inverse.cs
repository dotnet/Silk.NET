// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;

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
        public static T Reciprocal<T>(T x) where T : unmanaged
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

                ThrowUnsupportedType();
                return default;
            }
        }
    }
}