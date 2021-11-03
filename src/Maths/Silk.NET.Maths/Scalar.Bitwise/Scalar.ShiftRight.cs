// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    static partial class Scalar
    {
        /// <summary>
        /// Performs ShiftRight on supported types
        /// </summary>
        public static T ShiftRight<T>(T value, int offset) where T : unmanaged
        {
            return Byte(value, offset);

            [MethodImpl(MaxOpt)]
            static T Byte(T value, int offset)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) ((byte) (object) value >> offset);
                }

                return SByte(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T SByte(T value, int offset)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) ((sbyte) (object) value >> offset);
                }

                return UInt16(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T UInt16(T value, int offset)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) ((ushort) (object) value >> offset);
                }

                return Int16(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T Int16(T value, int offset)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) ((short) (object) value >> offset);
                }

                return UInt32(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T UInt32(T value, int offset)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) ((uint) (object) value >> offset);
                }

                return Int32(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T Int32(T value, int offset)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) ((int) (object) value >> offset);
                }

                return UInt64(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T UInt64(T value, int offset)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) ((ulong) (object) value >> offset);
                }

                return Int64(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T Int64(T value, int offset)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) ((long) (object) value >> offset);
                }

                return Single(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T Single(T value, int offset)
            {
                if (typeof(T) == typeof(float))
                {
                    var res = Unsafe.As<T, uint>(ref value) >> offset;
                    return Unsafe.As<uint, T>(ref res);
                }

                return Double(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T Double(T value, int offset)
            {
                if (typeof(T) == typeof(double))
                {
                    var res = Unsafe.As<T, ulong>(ref value) >> offset;
                    return Unsafe.As<ulong, T>(ref res);
                }

                return Other(value, offset);
            }
        
            [MethodImpl(MaxOpt)]
            static T Other(T value, int offset)
            {
                ThrowUnsupportedType();
                return default;
            }
        }
    }
}