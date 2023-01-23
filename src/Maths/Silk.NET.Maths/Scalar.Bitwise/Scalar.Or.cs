// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    static partial class Scalar
    {
        /// <summary>
        /// Performs Or on supported types
        /// </summary>
        public static T Or<T>(T left, T right) where T : unmanaged
        {
            return Byte(left, right);

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) ((byte) (object) left | (byte) (object) right);
                }

                return SByte(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T SByte(T left, T right)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) ((sbyte) (object) left | (sbyte) (object) right);
                }

                return UInt16(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T UInt16(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) ((ushort) (object) left | (ushort) (object) right);
                }

                return Int16(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T Int16(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) ((short) (object) left | (short) (object) right);
                }

                return UInt32(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T UInt32(T left, T right)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) ((uint) (object) left | (uint) (object) right);
                }

                return Int32(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T Int32(T left, T right)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) ((int) (object) left | (int) (object) right);
                }

                return UInt64(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T UInt64(T left, T right)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) ((ulong) (object) left | (ulong) (object) right);
                }

                return Int64(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T Int64(T left, T right)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) ((long) (object) left | (long) (object) right);
                }

                return Single(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T Single(T left, T right)
            {
                if (typeof(T) == typeof(float))
                {
                    var res = Unsafe.As<T, uint>(ref left) | Unsafe.As<T, uint>(ref right);
                    return Unsafe.As<uint, T>(ref res);
                }

                return Double(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T Double(T left, T right)
            {
                if (typeof(T) == typeof(double))
                {
                    var res = Unsafe.As<T, ulong>(ref left) | Unsafe.As<T, ulong>(ref right);
                    return Unsafe.As<ulong, T>(ref res);
                }

                return Other(left, right);
            }
        
            [MethodImpl(MaxOpt)]
            static T Other(T left, T right)
            {
                ThrowUnsupportedType();
                return default;
            }
        }
    }
}