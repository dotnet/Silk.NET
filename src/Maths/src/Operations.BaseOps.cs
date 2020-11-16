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

        [MethodImpl(MaxOpt)]
        public static bool IsFinite<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsFinite((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return CoreIsFinite((float)(object)f);
                }

                return Double(f);
            }

            [MethodImpl(MaxOpt)]
            static bool Double(T f)
            {
                if (typeof(T) == typeof(double))
                {
                    return IsFinite((double) (object) f);
                }

                ThrowOpUnsupportedType();
                return false;
            }
        }

            [MethodImpl(MaxOpt)]
        public static bool IsInfinity<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsInfinity((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsInfinity((float)(object)f);
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

                ThrowOpUnsupportedType();
                return false;
            }
        }

            [MethodImpl(MaxOpt)]
        public static bool IsNaN<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNaN((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsNaN((float)(object)f);
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

                ThrowOpUnsupportedType();
                return false;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool IsNegative<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNegative((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return CoreIsNegative((float)(object)f);
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

                ThrowOpUnsupportedType();
                return false;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool IsNegativeInfinity<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNegativeInfinity((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsNegativeInfinity((float)(object)f);
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

                ThrowOpUnsupportedType();
                return false;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool IsNormal<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNormal((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return IsNormal((float)(object)f);
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

                ThrowOpUnsupportedType();
                return false;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool IsPositiveInfinity<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsPositiveInfinity((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return float.IsPositiveInfinity((float)(object)f);
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

                ThrowOpUnsupportedType();
                return false;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool IsSubnormal<T>(T f) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return Half.IsSubnormal((Half)(object)f);
            }
            
            return Float(f);

            [MethodImpl(MaxOpt)]
            static bool Float(T f)
            {
                if (typeof(T) == typeof(float))
                {
                    return CoreIsSubnormal((float)(object)f);
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

        [MethodImpl(MaxOpt)]
        public static bool Equal<T>(T left, T right) where T : unmanaged
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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool NotEqual<T>(T left, T right) where T : unmanaged
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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool GreaterThan<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) leftOg > (Half) (object) rightOg;
            }

            return Float(leftOg, rightOg);

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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool GreaterThanOrEqual<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) leftOg >= (Half) (object) rightOg;
            }

            return Float(leftOg, rightOg);

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

                ThrowUnsupportedType();
                return default;
            }
        }

            [MethodImpl(MaxOpt)]
        public static bool LessThan<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) leftOg < (Half) (object) rightOg;
            }

            return Float(leftOg, rightOg);

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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static bool LessThanOrEqual<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (Half) (object) leftOg <= (Half) (object) rightOg;
            }

            return Float(leftOg, rightOg);

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

                ThrowUnsupportedType();
                return default;
            }
        }

        // ReSharper disable RedundantCast
        [MethodImpl(MaxOpt)]
        public static T Add<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) leftOg + (float) (Half) (object) rightOg);
            }

            return Float(leftOg, rightOg);

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
                    return (T) (object) ((sbyte) (object) left + (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) ((byte) (object) left + (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) ((short) (object) left + (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) ((ushort) (object) left + (ushort) (object) right);
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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Subtract<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) leftOg - (float) (Half) (object) rightOg);
            }

            return Float(leftOg, rightOg);

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
                    return (T) (object) ((sbyte) (object) left - (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) ((byte) (object) left - (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) ((short) (object) left - (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) ((ushort) (object) left - (ushort) (object) right);
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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Multiply<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) leftOg * (float) (Half) (object) rightOg);
            }

            return Float(leftOg, rightOg);

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
                    return (T) (object) ((sbyte) (object) left * (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) ((byte) (object) left * (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) ((short) (object) left * (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) ((ushort) (object) left * (ushort) (object) right);
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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Divide<T>(T leftOg, T rightOg) where T:unmanaged
        {
            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((float) (Half) (object) leftOg / (float) (Half) (object) rightOg);
            }

            return Float(leftOg, rightOg);

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
                    return (T) (object) ((sbyte) (object) left / (sbyte) (object) right);
                }

                return Byte(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Byte(T left, T right)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T) (object) ((byte) (object) left / (byte) (object) right);
                }

                return Short(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T Short(T left, T right)
            {
                if (typeof(T) == typeof(short))
                {
                    return (T) (object) ((short) (object) left / (short) (object) right);
                }

                return UShort(left, right);
            }

            [MethodImpl(MaxOpt)]
            static T UShort(T left, T right)
            {
                if (typeof(T) == typeof(ushort))
                {
                    return (T) (object) ((ushort) (object) left / (ushort) (object) right);
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

                ThrowUnsupportedType();
                return default;
            }
        }

        [MethodImpl(MaxOpt)]
        public static T Negate<T>(T x) where T : unmanaged => Multiply(x, Constants<T>.MinusOne);
        // ReSharper restore RedundantCast
    }
}
