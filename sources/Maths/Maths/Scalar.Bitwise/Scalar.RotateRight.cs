// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    static partial class Scalar
    {
        /// <summary>
        /// Rotates a given value bitwise.
        /// Shifting float and double obeys unsigned integers' behaviour.
        /// </summary>
        public static T RotateRight<T>(T value, int offset)
            where T : unmanaged
        {
            return Byte(value, offset);

            [MethodImpl(MaxOpt)]
            static T Byte(T value, int offset)
            {
                if (typeof(T) == typeof(byte))
                {
                    var v = (byte)(object)value;
                    return (T)(object)(byte)(((v >> offset) | (v << (8 - offset))) & 0xFF);
                }

                return SByte(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T SByte(T value, int offset)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    var v = (sbyte)(object)value;
                    return (T)(object)(sbyte)(((v >> offset) | (v << (8 - offset))) & 0xFF);
                }

                return UShort(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T value, int offset)
            {
                if (typeof(T) == typeof(ushort))
                {
                    var v = (ushort)(object)value;
                    return (T)(object)(ushort)(((v >> offset) | (v << (16 - offset))) & 0xFFFF);
                }

                return Short(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T value, int offset)
            {
                if (typeof(T) == typeof(short))
                {
                    var v = (short)(object)value;
                    return (T)(object)(short)(((v >> offset) | (v << (16 - offset))) & 0xFFFF);
                }

                return UInt(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T UInt(T value, int offset)
            {
                if (typeof(T) == typeof(uint))
                {
                    var v = (uint)(object)value;
                    return (T)(object)(uint)((v >> offset) | (v << (32 - offset)));
                }

                return Int(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T Int(T value, int offset)
            {
                if (typeof(T) == typeof(int))
                {
                    var v = (int)(object)value;
                    return (T)(object)(int)((v >> offset) | (v << (32 - offset)));
                }

                return ULong(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T ULong(T value, int offset)
            {
                if (typeof(T) == typeof(ulong))
                {
                    var v = (ulong)(object)value;
                    return (T)(object)(ulong)((v >> offset) | (v << (64 - offset)));
                }

                return Long(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T Long(T value, int offset)
            {
                if (typeof(T) == typeof(long))
                {
                    var v = (long)(object)value;
                    return (T)(object)(long)((v >> offset) | (v << (64 - offset)));
                }

                return Float(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T Float(T value, int offset)
            {
                if (typeof(T) == typeof(float))
                {
                    var v = Unsafe.As<T, uint>(ref value);
                    var res = (v >> offset) | (v << (32 - offset));
                    return Unsafe.As<uint, T>(ref res);
                }

                return Double(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T Double(T value, int offset)
            {
                if (typeof(T) == typeof(double))
                {
                    var v = Unsafe.As<T, ulong>(ref value);
                    var res = (v >> offset) | (v << (64 - offset));
                    return Unsafe.As<ulong, T>(ref res);
                }

                return Other(value, offset);
            }

            [MethodImpl(MaxOpt)]
            static T Other(T _, int __)
            {
                ThrowUnsupportedType();
                return default;
            }
        }
    }
}
