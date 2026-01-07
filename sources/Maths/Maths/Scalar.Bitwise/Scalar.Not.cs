// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    static partial class Scalar
    {
        /// <summary>
        /// Performs Not on supported types
        /// </summary>
        public static T Not<T>(T value)
            where T : unmanaged
        {
            return Byte(value);

            [MethodImpl(MaxOpt)]
            static T Byte(T value)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T)(object)(byte)(~((byte)(object)value) & byte.MaxValue);
                }

                return SByte(value);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T value)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T)(object)(sbyte)(~(sbyte)(object)value);
                }

                return UInt16(value);
            }

            [MethodImpl(MaxOpt)]
            static T UInt16(T value)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T)(object)(ushort)(~(ushort)(object)value);
                }

                return Int16(value);
            }

            [MethodImpl(MaxOpt)]
            static T Int16(T value)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T)(object)(short)(~(short)(object)value);
                }

                return UInt32(value);
            }

            [MethodImpl(MaxOpt)]
            static T UInt32(T value)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T)(object)(uint)(~(uint)(object)value);
                }

                return Int32(value);
            }

            [MethodImpl(MaxOpt)]
            static T Int32(T value)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T)(object)(int)(~(int)(object)value);
                }

                return UInt64(value);
            }

            [MethodImpl(MaxOpt)]
            static T UInt64(T value)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T)(object)(ulong)(~(ulong)(object)value);
                }

                return Int64(value);
            }

            [MethodImpl(MaxOpt)]
            static T Int64(T value)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T)(object)(long)(~(long)(object)value);
                }

                return Single(value);
            }

            [MethodImpl(MaxOpt)]
            static T Single(T value)
            {
                if (typeof(T) == typeof(float))
                {
                    var res = ~Unsafe.As<T, uint>(ref value);
                    return Unsafe.As<uint, T>(ref res);
                }

                return Double(value);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T value)
            {
                if (typeof(T) == typeof(double))
                {
                    var res = ~Unsafe.As<T, ulong>(ref value);
                    return Unsafe.As<ulong, T>(ref res);
                }

                return Other(value);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T value)
            {
                ThrowUnsupportedType();
                return default;
            }
        }
    }
}
