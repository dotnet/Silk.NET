// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using static Silk.NET.Numerics.Helper;

namespace Silk.NET.Numerics
{
    public static partial class Operations
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

        [MethodImpl(MaxOpt)]
        public static T Abs<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) Math.Abs((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Abs((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) Math.Abs((float) (object) x);
#else
                return (T) (object) MathF.Abs((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Abs((double) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) Math.Abs((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) Math.Abs((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) Math.Abs((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return x;
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) Math.Abs((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Decimal(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Acos<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Acos((float) (Half) (object) x); // KIPLING
#else
            return (T) (object) (Half) MathF.Abs((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Acos((float) (object) x); // KIPLING
#else
                return (T) (object) MathF.Acos((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Acos((double) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Acos((sbyte) (object) x); // KIPLING
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Acos((byte) (object) x); // KIPLING
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Acos((int) (object) x); // KIPLING
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Acos((uint) (object) x); // KIPLING
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Acos((long) (object) x); // KIPLING
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Acos((ulong) (object) x); // KIPLING
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Acos((short) (object) x); // KIPLING
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Acos((ushort) (object) x); // KIPLING
                }

                return Decimal(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Acosh<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (float) CoreAcosh((float) (Half) (object) x);
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreAcosh((float) (object) x);
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreAcosh((double) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreAcosh((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) CoreAcosh((byte) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreAcosh((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (byte) CoreAcosh((byte) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreAcosh((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) CoreAcosh((ulong) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreAcosh((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreAcosh((int) (object) x);
                }

                return Decimal(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Asin<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Asin((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Abs((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Asin((float) (object) x);
#else
                return (T) (object) MathF.Asin((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Asin((double) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Asin((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Asin((byte) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Asin((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Asin((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Asin((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Asin((ulong) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Asin((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Asin((ushort) (object) x);
                }

                return Decimal(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Asinh<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (float) CoreAsinh((float) (Half) (object) x);
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreAsinh((float) (object) x);
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreAsinh((double) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreAsinh((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) CoreAsinh((byte) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreAsinh((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) CoreAsinh((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreAsinh((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) CoreAsinh((ulong) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreAsinh((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreAsinh((ushort) (object) x);
                }

                return Decimal(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Atan<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Atan((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Abs((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Atan((float) (object) x);
#else
                return (T) (object) MathF.Atan((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Atan((double) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Atan((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Atan((byte) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Atan((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Atan((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Atan((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Atan((ulong) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Atan((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Atan((ushort) (object) x);
                }

                return Decimal(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Atanh<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) Atanh((float) (Half) (object) x);
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) Atanh((float) (object) x);
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreAtanh((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreAtanh((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) CoreAtanh((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreAtanh((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreAtanh((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreAtanh((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) CoreAtanh((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreAtanh((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Cbrt<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreCbrt((float) (Half) (object) x);
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreCbrt((float) (object) x);
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) CoreCbrt((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) CoreCbrt((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) CoreCbrt((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) CoreCbrt((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) CoreCbrt((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) CoreCbrt((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) CoreCbrt((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) CoreCbrt((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Ceiling<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) Math.Ceiling((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Ceiling((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Ceiling((float) (object) x);
#else
                return (T) (object) MathF.Ceiling((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Ceiling((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) Math.Ceiling((decimal) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Cos<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) Math.Cos((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Cos((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Cos((float) (object) x);
#else
                return (T) (object) MathF.Cos((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Cos((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Cos((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Cos((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Cos((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Cos((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Cos((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Cos((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Cos((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Cosh<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) Math.Cosh((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Cosh((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Cosh((float) (object) x);
#else
                return (T) (object) MathF.Cosh((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Cosh((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Cosh((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Cosh((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Cosh((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Cosh((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Cosh((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Cosh((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Cosh((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Exp<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) Math.Exp((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Exp((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Exp((float) (object) x);
#else
                return (T) (object) MathF.Exp((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Exp((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Exp((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Exp((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Exp((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Exp((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Exp((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Exp((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Exp((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Floor<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) Math.Floor((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Floor((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Floor((float) (object) x);
#else
                return (T) (object) MathF.Floor((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Floor((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) Math.Floor((decimal) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Sign<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Sign((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Sign((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Sign((float) (object) x);
#else
                return (T) (object) MathF.Sign((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Sign((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Sign((decimal) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Sign((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return Constants<T>.One;
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Sign((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return Constants<T>.One;
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Sign((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return Constants<T>.One;
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Sign((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return Constants<T>.One;
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Sin<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if NET5_0
                return (T) (object) (Half) (float) Sin_Ported((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Sin((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if NET5_0
                    return (T) (object) (float) Sin_Ported((float) (object) x);
#else
                return (T) (object) MathF.Sin((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Sin((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Sin((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Sin((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Sin((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Sin((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Sin((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Sin((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Sin((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Sinh<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Sinh((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Sinh((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Sinh((float) (object) x);
#else
                return (T) (object) MathF.Sinh((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Sinh((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Sinh((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Sinh((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Sinh((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Sinh((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Sinh((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Sinh((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Sinh((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Sqrt<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Sqrt((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Sqrt((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Sqrt((float) (object) x);
#else
                return (T) (object) MathF.Sqrt((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Sqrt((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Sqrt((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Sqrt((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Sqrt((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Sqrt((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Sqrt((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Sqrt((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Sqrt((long) (object) x);
                }

                return ULong(x);
            }

            static T ULong(T x)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Sqrt((ulong) (object) x);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Tan<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Tan((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Tan((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Tan((float) (object) x);
#else
                return (T) (object) MathF.Tan((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Tan((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Tan((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Tan((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Tan((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Tan((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Tan((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Tan((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Tan((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Tanh<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Tanh((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Tanh((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Tanh((float) (object) x);
#else
                return (T) (object) MathF.Tanh((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Tanh((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Tanh((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Tanh((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Tanh((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Tanh((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Tanh((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Tanh((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Tanh((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Truncate<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Truncate((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Truncate((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Truncate((float) (object) x);
#else
                return (T) (object) MathF.Truncate((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Truncate((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Truncate((decimal) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Log<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) CoreFastLog((float)(Half)(object)x);
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
                    return (T) (object) CoreFastLog((float)(object)x);
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Log((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Log10<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Log10((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Log10((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Log10((float) (object) x);
#else
                return (T) (object) MathF.Log10((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Log10((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log10((sbyte) (object) x);
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log10((byte) (object) x);
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log10((short) (object) x);
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log10((ushort) (object) x);
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log10((int) (object) x);
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log10((uint) (object) x);
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log10((long) (object) x);
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Round((float) (Half) (object) x);
#else
            return (T) (object) (Half) MathF.Round((float)(Half)(object)x);
#endif
            }

            return Float(x);

            static T Float(T x)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Round((float) (object) x);
#else
                return (T) (object) MathF.Round((float)(object)x);
#endif
                }

                return Double(x);
            }

            static T Double(T x)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) (double) Math.Round((double) (object) x);
                }

                return Decimal(x);
            }

            static T Decimal(T x)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Round((decimal) (object) x);
                }

                return SByte(x);
            }

            static T SByte(T x)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return x;
                }

                return Byte(x);
            }

            static T Byte(T x)
            {
                if (typeof(T) == typeof(byte))
                {
                    return x;
                }

                return Short(x);
            }

            static T Short(T x)
            {
                if (typeof(T) == typeof(short))
                {
                    return x;
                }

                return UShort(x);
            }

            static T UShort(T x)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return x;
                }

                return Int(x);
            }

            static T Int(T x)
            {
                if (typeof(T) == typeof(int))
                {
                    return x;
                }

                return UInt(x);
            }

            static T UInt(T x)
            {
                if (typeof(T) == typeof(uint))
                {
                    return x;
                }

                return Long(x);
            }

            static T Long(T x)
            {
                if (typeof(T) == typeof(long))
                {
                    return x;
                }

                return ULong(x);
            }

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

        [MethodImpl(MaxOpt)]
        public static T IEEERemainder<T>(T x, T y) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.IEEERemainder
                    ((float) (Half) (object) x, (float) (Half) (object) y);
#else
            return (T)(object)(Half)MathF.IEEERemainder((float)(Half)(object)x, (float)(Half)(object)y);
#endif
            }

            return Float(x, y);

            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.IEEERemainder((float) (object) x, (float) (object) y);
#else
                return (T)(object)MathF.IEEERemainder((float)(object)x, (float)(object)y);
#endif
                }

                return Double(x, y);
            }

            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.IEEERemainder((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.IEEERemainder((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.IEEERemainder((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.IEEERemainder((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.IEEERemainder((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.IEEERemainder((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.IEEERemainder((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.IEEERemainder((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Log<T>(T x, T y) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Log((float) (Half) (object) x, (float) (Half) (object) y);
#else
            return (T)(object)(Half)MathF.Log((float)(Half)(object)x, (float)(Half)(object)y);
#endif
            }

            return Float(x, y);

            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Log((float) (object) x, (float) (object) y);
#else
                return (T)(object)MathF.Log((float)(object)x, (float)(object)y);
#endif
                }

                return Double(x, y);
            }

            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Log((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Log((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Log((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Log((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Log((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Log((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Log((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Log((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Max<T>(T x, T y) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Max((float) (Half) (object) x, (float) (Half) (object) y);
#else
            return (T)(object)(Half)MathF.Max((float)(Half)(object)x, (float)(Half)(object)y);
#endif
            }

            return Float(x, y);

            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Max((float) (object) x, (float) (object) y);
#else
                return (T)(object)MathF.Max((float)(object)x, (float)(object)y);
#endif
                }

                return Double(x, y);
            }

            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Max((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Max((decimal) (object) x, (decimal) (object) y);
                }

                return SByte(x, y);
            }

            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Max((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Max((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Max((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Max((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Max((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Max((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Max((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Min<T>(T x, T y) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Min((float) (Half) (object) x, (float) (Half) (object) y);
#else
            return (T)(object)(Half)MathF.Min((float)(Half)(object)x, (float)(Half)(object)y);
#endif
            }

            return Float(x, y);

            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Min((float) (object) x, (float) (object) y);
#else
                return (T)(object)MathF.Min((float)(object)x, (float)(object)y);
#endif
                }

                return Double(x, y);
            }

            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Min((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    return (T) (object) (decimal) Math.Min((decimal) (object) x, (decimal) (object) y);
                }

                return SByte(x, y);
            }

            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Min((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Min((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Min((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Min((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Min((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Min((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Min((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Pow<T>(T x, T y) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Pow((float) (Half) (object) x, (float) (Half) (object) y);
#else
            return (T)(object)(Half)MathF.Pow((float)(Half)(object)x, (float)(Half)(object)y);
#endif
            }

            return Float(x, y);

            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Pow((float) (object) x, (float) (object) y);
#else
                return (T)(object)MathF.Pow((float)(object)x, (float)(object)y);
#endif
                }

                return Double(x, y);
            }

            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Pow((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Pow((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Pow((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Pow((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Pow((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Pow((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Pow((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Pow((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

            static T ULong(T x, T y)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (T) (object) (ulong) Math.Pow((ulong) (object) x, (ulong) (object) y);
                }

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Atan2<T>(T y, T x) where T : unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
#if !NET5_0
                return (T) (object) (Half) (float) Math.Atan2((float) (Half) (object) x, (float) (Half) (object) y);
#else
            return (T)(object)(Half)MathF.Atan2((float)(Half)(object)x, (float)(Half)(object)y);
#endif
            }

            return Float(x, y);

            static T Float(T x, T y)
            {
                if (typeof(T) == typeof(float))
                {
#if !NET5_0
                    return (T) (object) (float) Math.Atan2((float) (object) x, (float) (object) y);
#else
                return (T)(object)MathF.Atan2((float)(object)x, (float)(object)y);
#endif
                }

                return Double(x, y);
            }

            static T Double(T x, T y)
            {
                if (typeof(T) == typeof(double))
                {
                    return (T) (object) Math.Atan2((double) (object) x, (double) (object) y);
                }

                return Decimal(x, y);
            }

            static T Decimal(T x, T y)
            {
                if (typeof(T) == typeof(decimal))
                {
                    ThrowOpUnsupportedPrecision();
                    return default;
                }

                return SByte(x, y);
            }

            static T SByte(T x, T y)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (T) (object) (sbyte) Math.Atan2((sbyte) (object) x, (sbyte) (object) y);
                }

                return Byte(x, y);
            }

            static T Byte(T x, T y)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) (byte) Math.Atan2((byte) (object) x, (byte) (object) y);
                }

                return Short(x, y);
            }

            static T Short(T x, T y)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) (short) Math.Atan2((short) (object) x, (short) (object) y);
                }

                return UShort(x, y);
            }

            static T UShort(T x, T y)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) (ushort) Math.Atan2((ushort) (object) x, (ushort) (object) y);
                }

                return Int(x, y);
            }

            static T Int(T x, T y)
            {
                if (typeof(T) == typeof(int))
                {
                    return (T) (object) (int) Math.Atan2((int) (object) x, (int) (object) y);
                }

                return UInt(x, y);
            }

            static T UInt(T x, T y)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (T) (object) (uint) Math.Atan2((uint) (object) x, (uint) (object) y);
                }

                return Long(x, y);
            }

            static T Long(T x, T y)
            {
                if (typeof(T) == typeof(long))
                {
                    return (T) (object) (long) Math.Atan2((long) (object) x, (long) (object) y);
                }

                return ULong(x, y);
            }

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

        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, int digits) where T : unmanaged
        {
            throw null;
        }

        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, int digits, System.MidpointRounding mode) where T : unmanaged
        {
            throw null;
        }

        [MethodImpl(MaxOpt)]
        public static T Round<T>(T x, System.MidpointRounding mode) where T : unmanaged
        {
            throw null;
        }
    }
}
