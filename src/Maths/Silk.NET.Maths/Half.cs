// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//
// This file was sourced from the CoreFX Lab (https://github.com/dotnet/corefxlab).
// Below are the copyright headers associated with System.Numerics.Experimental, as well as the file itself ;)
// File may have changed from the original.
//
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace Silk.NET.Maths
{
    // ===================================================================================================
    // Portions of the code implemented below are based on the 'Berkeley SoftFloat Release 3e' algorithms.
    // ===================================================================================================

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Half : IComparable, IFormattable, IComparable<Half>, IEquatable<Half>
    {
        private const NumberStyles DefaultParseStyle = NumberStyles.Float | NumberStyles.AllowThousands;

        //
        // Constants for manipulating the private bit-representation
        //

        private const ushort SignMask = 0x8000;
        private const ushort SignShift = 15;

        private const ushort ExponentMask = 0x7C00;
        private const ushort ExponentShift = 10;

        private const ushort SignificandMask = 0x03FF;
        private const ushort SignificandShift = 0;

        private const ushort MinSign = 0;
        private const ushort MaxSign = 1;

        private const ushort MinExponent = 0x00;
        private const ushort MaxExponent = 0x1F;

        private const ushort MinSignificand = 0x0000;
        private const ushort MaxSignificand = 0x03FF;

        //
        // Constants representing the private bit-representation for various default values
        //

        private const ushort PositiveZeroBits = 0x0000;
        private const ushort NegativeZeroBits = 0x8000;

        private const ushort EpsilonBits = 0x0001;

        private const ushort PositiveInfinityBits = 0x7C00;
        private const ushort NegativeInfinityBits = 0xFC00;

        private const ushort PositiveQNaNBits = 0x7E00;
        private const ushort NegativeQNaNBits = 0xFE00;

        private const ushort MinValueBits = 0xFBFF;
        private const ushort MaxValueBits = 0x7BFF;

        //
        // Constants that should be returned if values that cannot be represented are converted
        //

        private const long IllegalValueToInt64 = long.MinValue;
        private const ulong IllegalValueToUInt64 = ulong.MinValue;
        private const int IllegalValueToInt32 = int.MinValue;
        private const uint IllegalValueToUInt32 = uint.MinValue;

        //
        // Well-defined and commonly used values
        //

        public static readonly Half Epsilon = new Half(EpsilonBits); //  5.9605E-08

        public static readonly Half PositiveInfinity = new Half(PositiveInfinityBits); //  1.0 / 0.0
        public static readonly Half NegativeInfinity = new Half(NegativeInfinityBits); // -1.0 / 0.0

        public static readonly Half NaN = new Half(NegativeQNaNBits); //  0.0 / 0.0

        public static readonly Half MinValue = new Half(MinValueBits); // -65504
        public static readonly Half MaxValue = new Half(MaxValueBits); //  65504

        // We use these explicit definitions to avoid the confusion between 0.0 and -0.0.
        private static readonly Half PositiveZero = new Half(PositiveZeroBits); //  0.0
        private static readonly Half NegativeZero = new Half(NegativeZeroBits); // -0.0

        private readonly ushort m_value; // Do not rename (binary serialization)

        private Half(ushort value)
        {
            m_value = value;
        }

        private Half(bool sign, ushort exp, ushort sig)
        {
            m_value = (ushort) (((sign ? 1 : 0) << SignShift) + (exp << ExponentShift) + sig);
        }

        private sbyte Exponent => (sbyte) ((m_value & ExponentMask) >> ExponentShift);

        private ushort Significand => (ushort) ((m_value & SignificandMask) >> SignificandShift);

        public static bool operator <(Half left, Half right)
        {
            if (IsNaN(left) || IsNaN(right))
            {
                // IEEE defines that NaN is unordered with respect to everything, including itself.
                return false;
            }

            var leftIsNegative = IsNegative(left);

            if (leftIsNegative != IsNegative(right))
            {
                // When the signs of left and right differ, we know that left is less than right if it is
                // the negative value. The exception to this is if both values are zero, in which case IEEE
                // says they should be equal, even if the signs differ.
                return leftIsNegative && !AreZero(left, right);
            }

            return (short) left.m_value < (short) right.m_value;
        }

        public static bool operator >(Half left, Half right)
        {
            return right < left;
        }

        public static bool operator <=(Half left, Half right)
        {
            if (IsNaN(left) || IsNaN(right))
            {
                // IEEE defines that NaN is unordered with respect to everything, including itself.
                return false;
            }

            var leftIsNegative = IsNegative(left);

            if (leftIsNegative != IsNegative(right))
            {
                // When the signs of left and right differ, we know that left is less than right if it is
                // the negative value. The exception to this is if both values are zero, in which case IEEE
                // says they should be equal, even if the signs differ.
                return leftIsNegative || AreZero(left, right);
            }

            return (short) left.m_value <= (short) right.m_value;
        }

        public static bool operator >=(Half left, Half right)
        {
            return right <= left;
        }

        public static bool operator ==(Half left, Half right)
        {
            if (IsNaN(left) || IsNaN(right))
            {
                // IEEE defines that NaN is not equal to anything, including itself.
                return false;
            }

            // IEEE defines that positive and negative zero are equivalent.
            return left.m_value == right.m_value || AreZero(left, right);
        }

        public static bool operator !=(Half left, Half right)
        {
            return !(left == right);
        }

        // <summary>Determines whether the specified value is finite (zero, subnormal, or normal).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFinite(Half value)
        {
            return StripSign(value) < PositiveInfinityBits;
        }

        /// <summary>Determines whether the specified value is infinite.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsInfinity(Half value)
        {
            return StripSign(value) == PositiveInfinityBits;
        }

        /// <summary>Determines whether the specified value is NaN.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Half value)
        {
            return StripSign(value) > PositiveInfinityBits;
        }

        /// <summary>Determines whether the specified value is negative.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegative(Half value)
        {
            return (short) value.m_value < 0;
        }

        /// <summary>Determines whether the specified value is negative infinity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNegativeInfinity(Half value)
        {
            return value.m_value == NegativeInfinityBits;
        }

        /// <summary>Determines whether the specified value is normal.</summary>
        // This is probably not worth inlining, it has branches and should be rarely called
        public static bool IsNormal(Half value)
        {
            int absValue = StripSign(value);
            return absValue < PositiveInfinityBits // is finite
                   && absValue != 0 // is not zero
                   && (absValue & ExponentMask) != 0; // is not subnormal (has a non-zero exponent)
        }

        /// <summary>Determines whether the specified value is positive infinity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPositiveInfinity(Half value)
        {
            return value.m_value == PositiveInfinityBits;
        }

        /// <summary>Determines whether the specified value is subnormal.</summary>
        // This is probably not worth inlining, it has branches and should be rarely called
        public static bool IsSubnormal(Half value)
        {
            int absValue = StripSign(value);
            return absValue < PositiveInfinityBits // is finite
                   && absValue != 0 // is not zero
                   && (absValue & ExponentMask) == 0; // is subnormal (has a zero exponent)
        }

        public static Half Parse
            (string s, NumberStyles style = DefaultParseStyle, IFormatProvider formatProvider = null)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            return Parse(s.AsSpan(), style, formatProvider);
        }

        public static Half Parse
            (ReadOnlySpan<char> s, NumberStyles style = DefaultParseStyle, IFormatProvider formatProvider = null)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(string s, out Half result)
        {
            return TryParse(s, DefaultParseStyle, null, out result);
        }

        public static bool TryParse(ReadOnlySpan<char> s, out Half result)
        {
            return TryParse(s, DefaultParseStyle, null, out result);
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider formatProvider, out Half result)
        {
            return TryParse(s.AsSpan(), style, formatProvider, out result);
        }

        public static bool TryParse
            (ReadOnlySpan<char> s, NumberStyles style, IFormatProvider formatProvider, out Half result)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool AreZero(Half left, Half right)
        {
            // IEEE defines that positive and negative zero are equal, this gives us a quick equality check
            // for two values by or'ing the private bits together and stripping the sign. They are both zero,
            // and therefore equivalent, if the resulting value is still zero.
            return (ushort) ((left.m_value | right.m_value) & ~SignMask) == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsNaNOrZero(Half value)
        {
            return ((value.m_value - 1) & ~SignMask) >= PositiveInfinityBits;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ushort StripSign(Half value)
        {
            return (ushort) (value.m_value & ~SignMask);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Half))
            {
                return obj is null ? 1 : throw new ArgumentException("The given argument is not a half.", nameof(obj));
            }

            return CompareTo((Half) obj);
        }

        public int CompareTo(Half other)
        {
            if ((short) m_value < (short) other.m_value)
            {
                return -1;
            }

            if ((short) m_value > (short) other.m_value)
            {
                return 1;
            }

            if (m_value == other.m_value)
            {
                return 0;
            }

            if (IsNaN(this))
            {
                return IsNaN(other) ? 0 : -1;
            }

            Debug.Assert(IsNaN(other));
            return 1;
        }

        public override bool Equals(object obj)
        {
            return obj is Half && Equals((Half) obj);
        }

        public bool Equals(Half other)
        {
            return this == other || IsNaN(this) && IsNaN(other);
        }

        public override int GetHashCode()
        {
            if (IsNaNOrZero(this))
            {
                // All NaNs should have the same hash code, as should both Zeros.
                return m_value & PositiveInfinityBits;
            }

            return m_value;
        }

        public override string ToString()
        {
            return $"0x{m_value:X4}";
            // return ToString(format: null, formatProvider: null);
            // TODO: Implement this
        }

        public string ToString(string format = null, IFormatProvider formatProvider = null)
        {
            return $"0x{m_value:X4}";
            // throw new NotImplementedException();
            // TODO: Implement this
        }

        public bool TryFormat
            (Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        // -----------------------Start of to-half conversions-------------------------

        public static implicit operator Half(int value)
        {
            var sign = value < 0;
            Half
                h = (uint) (sign
                    ? -value
                    : value); // Math.Abs but doesn't throw exception, because we cast it to uint anyway
            return sign ? new Half((ushort) (h.m_value | SignMask)) : h;
        }

        public static implicit operator Half(uint value)
        {
            var shiftDist = Helpers.LeadingZeroCount(value) - 21;
            if (shiftDist >= 0)
            {
                return value != 0
                    ? new Half(false, (ushort) (0x18 - shiftDist), (ushort) (value << shiftDist))
                    : default;
            }

            shiftDist += 4;
            var sig = shiftDist < 0 ? Helpers.ShiftRightJam(value, -shiftDist) : value << shiftDist;
            return new Half(RoundPackToHalf(false, (short) (0x1C - shiftDist), (ushort) sig));
        }

        public static implicit operator Half(long value)
        {
            var sign = value < 0;
            Half
                h = (ulong) (sign
                    ? -value
                    : value); // Math.Abs but doesn't throw exception, because we cast it to ulong anyway
            return sign ? new Half((ushort) (h.m_value | SignMask)) : h;
        }

        public static implicit operator Half(ulong value)
        {
            var shiftDist = Helpers.LeadingZeroCount(value) - 53;

            if (shiftDist >= 0)
            {
                return value != 0
                    ? new Half(false, (ushort) (0x18 - shiftDist), (ushort) (value << shiftDist))
                    : default;
            }

            shiftDist += 4;
            var sig =
                (ushort) (shiftDist < 0 ? Helpers.ShiftRightJam(value, -shiftDist) : value << shiftDist);
            return new Half(RoundPackToHalf(false, (short) (0x1C - shiftDist), sig));
        }

        public static implicit operator Half(short value)
        {
            return (int) value;
        }

        public static implicit operator Half(ushort value)
        {
            return (uint) value;
        }

        public static implicit operator Half(byte value)
        {
            return (uint) value;
        }

        public static implicit operator Half(sbyte value)
        {
            return (int) value;
        }

        public static explicit operator Half(float value)
        {
            const int singleMaxExponent = 0xFF;

            var floatInt = Helpers.ToUInt32(value);
            var sign = (floatInt & Helpers.SingleSignMask) >> Helpers.SingleSignShift != 0;
            var exp = (int) (floatInt & Helpers.SingleExponentMask) >> Helpers.SingleExponentShift;
            var sig = floatInt & Helpers.SingleSignificandMask;

            if (exp == singleMaxExponent)
            {
                if (sig != 0) // NaN
                {
                    return Helpers.CreateHalfNaN
                        (sign, (ulong) sig << 41); // Shift the significand bits to the left end
                }

                return sign ? NegativeInfinity : PositiveInfinity;
            }

            var sigHalf = (sig >> 9) | ((sig & 0x1FFU) != 0 ? 1U : 0U); // RightShiftJam

            if ((exp | (int) sigHalf) == 0)
            {
                return new Half(sign, 0, 0);
            }

            return new Half(RoundPackToHalf(sign, (short) (exp - 0x71), (ushort) (sigHalf | 0x4000)));
        }

        public static explicit operator Half(double value)
        {
            const int doubleMaxExponent = 0x7FF;

            var doubleInt = Helpers.ToUInt64(value);
            var sign = (doubleInt & Helpers.DoubleSignMask) >> Helpers.DoubleSignShift != 0;
            var exp = (int) ((doubleInt & Helpers.DoubleExponentMask) >> Helpers.DoubleExponentShift);
            var sig = doubleInt & Helpers.DoubleSignificandMask;

            if (exp == doubleMaxExponent)
            {
                if (sig != 0) // NaN
                {
                    return Helpers.CreateHalfNaN(sign, sig << 12); // Shift the significand bits to the left end
                }

                return sign ? NegativeInfinity : PositiveInfinity;
            }

            var sigHalf = (uint) Helpers.ShiftRightJam(sig, 38);
            if ((exp | (int) sigHalf) == 0)
            {
                return new Half(sign, 0, 0);
            }

            return new Half(RoundPackToHalf(sign, (short) (exp - 0x3F1), (ushort) (sigHalf | 0x4000)));
        }

        // -----------------------Start of from-half conversions-------------------------

        public static explicit operator int(Half value)
        {
            var sign = IsNegative(value);
            int exp = value.Exponent;
            uint sig = value.Significand;

            var shiftDist = exp - 0x0F;
            if (shiftDist < 0) // Value < 1
            {
                return 0;
            }

            if (exp == MaxExponent)
            {
                return IllegalValueToInt32;
            }

            var alignedSig = (int) (sig | 0x0400) << shiftDist;
            alignedSig >>= 10;
            return sign ? -alignedSig : alignedSig;
        }

        public static explicit operator uint(Half value) // 0 for every case
        {
            var sign = IsNegative(value);
            int exp = value.Exponent;
            uint sig = value.Significand;

            var shiftDist = exp - 0x0F;
            if (shiftDist < 0) // Value < 1
            {
                return 0;
            }

            if (exp == MaxExponent)
            {
                return IllegalValueToUInt32;
            }

            var alignedSig = (sig | 0x0400) << shiftDist;
            alignedSig >>= 10;
            return (uint) (sign ? -(int) alignedSig : (int) alignedSig);
        }

        public static explicit operator long(Half value)
        {
            var sign = IsNegative(value);
            int exp = value.Exponent;
            uint sig = value.Significand;

            var shiftDist = exp - 0x0F;
            if (shiftDist < 0) // value < 1
            {
                return 0;
            }

            if (exp == MaxExponent)
            {
                return IllegalValueToInt64;
            }

            var alignedSig = (int) (sig | 0x0400) << shiftDist;
            alignedSig >>= 10;
            return sign ? -alignedSig : alignedSig;
        }

        public static explicit operator ulong(Half value) // 0 for PosInfinity/NaN, long.MinValue for NegInfinity
        {
            var sign = IsNegative(value);
            int exp = value.Exponent;
            uint sig = value.Significand;

            var shiftDist = exp - 0x0F;
            if (shiftDist < 0) // value < 1
            {
                return 0;
            }

            if (exp == MaxExponent)
            {
                return IllegalValueToUInt64;
            }

            var alignedSig = (sig | 0x0400) << shiftDist;
            alignedSig >>= 10;
            return (ulong) (sign ? -alignedSig : alignedSig);
        }

        public static explicit operator short(Half value)
        {
            return (short) (int) value;
        }

        public static explicit operator ushort(Half value)
        {
            return (ushort) (short) (int) value;
        }

        public static explicit operator byte(Half value)
        {
            return (byte) (sbyte) (int) value;
        }

        public static explicit operator sbyte(Half value)
        {
            return (sbyte) (int) value;
        }

        public static implicit operator float(Half value)
        {
            var sign = IsNegative(value);
            int exp = value.Exponent;
            uint sig = value.Significand;

            if (exp == MaxExponent)
            {
                if (sig != 0)
                {
                    return Helpers.CreateSingleNaN(sign, (ulong) sig << 54);
                }

                return sign ? float.NegativeInfinity : float.PositiveInfinity;
            }

            if (exp == 0)
            {
                if (sig == 0)
                {
                    return Helpers.CreateSingle
                        (sign ? Helpers.SingleSignMask : 0); // Positive / Negative zero
                }

                (exp, sig) = NormSubnormalF16Sig(sig);
                exp -= 1;
            }

            return Helpers.CreateSingle(sign, (byte) (exp + 0x70), sig << 13);
        }

        public static implicit operator double(Half value)
        {
            var sign = IsNegative(value);
            int exp = value.Exponent;
            uint sig = value.Significand;

            if (exp == MaxExponent)
            {
                if (sig != 0)
                {
                    return Helpers.CreateDoubleNaN(sign, (ulong) sig << 54);
                }

                return sign ? double.NegativeInfinity : double.PositiveInfinity;
            }

            if (exp == 0)
            {
                if (sig == 0)
                {
                    return Helpers.CreateDouble
                        (sign ? Helpers.DoubleSignMask : 0); // Positive / Negative zero
                }

                (exp, sig) = NormSubnormalF16Sig(sig);
                exp -= 1;
            }

            return Helpers.CreateDouble(sign, (ushort) (exp + 0x3F0), (ulong) sig << 42);
        }

        // IEEE 754 specifies NaNs to be propagated
        public static Half operator -(Half value)
        {
            return IsNaN(value) ? value : new Half((ushort) (value.m_value ^ SignMask));
        }

        public static Half operator +(Half value)
        {
            return value;
        }

        private static ushort RoundPackToHalf(bool sign, short exp, ushort sig)
        {
            const int roundIncrement = 0x8; // Depends on rounding mode but it's always towards closest / ties to even
            var roundBits = sig & 0xF;

            if ((uint) exp >= 0x1D)
            {
                if (exp < 0)
                {
                    sig = (ushort) Helpers.ShiftRightJam(sig, -exp);
                    exp = 0;
                }
                else if (exp > 0x1D || sig + roundIncrement >= 0x8000) // Overflow
                {
                    return sign ? NegativeInfinityBits : PositiveInfinityBits;
                }
            }

            sig = (ushort) ((sig + roundIncrement) >> 4);
            sig &= (ushort) ~(((roundBits ^ 8) != 0 ? 0 : 1) & 1);

            if (sig == 0)
            {
                exp = 0;
            }

            return new Half(sign, (ushort) exp, sig).m_value;
        }

        private static (int Exp, uint Sig) NormSubnormalF16Sig(uint sig)
        {
            var shiftDist = Helpers.LeadingZeroCount(sig) - 16 - 5; // No LZCNT for 16-bit
            return (1 - shiftDist, sig << shiftDist);
        }

        private class Helpers
        {
            public const ulong DoubleSignMask = 0x80000000_00000000;
            public const int DoubleSignShift = 63;
            public const long DoubleExponentMask = 0x7FF00000_00000000;
            public const int DoubleExponentShift = 52;
            public const ulong DoubleSignificandMask = 0x000FFFFF_FFFFFFFF;
            public const int DoubleSignificandShift = 0;

            public const uint SingleSignMask = 0x80000000;
            public const int SingleSignShift = 31;
            public const int SingleExponentMask = 0x7F800000;
            public const int SingleExponentShift = 23;
            public const uint SingleSignificandMask = 0x7FFFFF;
            public const int SingleSignificandShift = 0;

            public const ushort HalfSignMask = 0x8000;
            public const int HalfSignShift = 15;
            public const ushort HalfExponentMask = 0x7C00;
            public const int HalfExponentShift = 10;
            public const ushort HalfSignificandMask = 0x03FF;
            public const int HalfSignificandShift = 0;

            private static ReadOnlySpan<byte> Log2DeBruijn => new byte[32]
            {
                00, 09, 01, 10, 13, 21, 02, 29,
                11, 14, 16, 18, 22, 25, 03, 30,
                08, 12, 20, 28, 15, 17, 24, 07,
                19, 27, 23, 06, 26, 05, 04, 31
            };

            public static double CreateDouble(ulong value)
            {
                return BitConverter.Int64BitsToDouble((long) value);
            }

            public static float CreateSingle(uint value)
            {
                return Int32BitsToSingle((int) value);
            }

            public static unsafe Half CreateHalf(ushort value)
            {
                return *(Half*) &value;
            }

            public static Half CreateHalf(bool sign, ushort exp, ushort sig)
            {
                return CreateHalf
                    ((ushort) (((sign ? 1U : 0U) << HalfSignShift) | ((uint) exp << SingleExponentShift) | sig));
            }

            public static float CreateSingle(bool sign, byte exp, uint sig)
            {
                return Int32BitsToSingle
                    ((int) (((sign ? 1U : 0U) << SingleSignShift) | ((uint) exp << SingleExponentShift) | sig));
            }

            public static double CreateDouble(bool sign, ushort exp, ulong sig)
            {
                return BitConverter.Int64BitsToDouble
                    ((long) (((sign ? 1UL : 0UL) << DoubleSignShift) | ((ulong) exp << DoubleExponentShift) | sig));
            }

            public static unsafe ushort ToUInt16(Half value)
            {
                return *(ushort*) &value;
            }

            public static uint ToUInt32(float value)
            {
                return (uint) SingleToInt32Bits(value);
            }

            public static ulong ToUInt64(double value)
            {
                return (ulong) BitConverter.DoubleToInt64Bits(value);
            }

            public static unsafe float Int32BitsToSingle(int value)
            {
                return *(float*) &value;
            }

            public static unsafe int SingleToInt32Bits(float value)
            {
                return *(int*) &value;
            }

            // Significand bits should be shifted towards to the left end before calling these methods
            // Creates Quiet NaN if significand == 0
            public static Half CreateHalfNaN(bool sign, ulong significand)
            {
                const uint NaNBits = HalfExponentMask | 0x200; // Most significant significand bit

                var signInt = (sign ? 1U : 0U) << HalfSignShift;
                var sigInt = (uint) (significand >> 54);

                return CreateHalf((ushort) (signInt | NaNBits | sigInt));
            }

            public static float CreateSingleNaN(bool sign, ulong significand)
            {
                const uint NaNBits = SingleExponentMask | 0x400000; // Most significant significand bit

                var signInt = (sign ? 1U : 0U) << SingleSignShift;
                var sigInt = (uint) (significand >> 41);

                return CreateSingle(signInt | NaNBits | sigInt);
            }

            public static double CreateDoubleNaN(bool sign, ulong significand)
            {
                const ulong NaNBits = DoubleExponentMask | 0x80000_00000000; // Most significant significand bit

                var signInt = (sign ? 1UL : 0UL) << DoubleSignShift;
                var sigInt = significand >> 12;

                return CreateDouble(signInt | NaNBits | sigInt);
            }

            // TODO: Worth bringing the `ShortShiftRightJam`? looks like some perf difference only.
            // Functional difference is that dist must be [0..32), maybe as part of micro-optimisations

            // If any bits are lost by shifting, "jam" them into the LSB.
            // if dist > bit count, Will be 1 or 0 depending on i
            // (unlike bitwise operators that masks the lower 5 bits)
            public static uint ShiftRightJam(uint i, int dist)
            {
                return dist < 31 ? (i >> dist) | (i << (-dist & 31) != 0 ? 1U : 0U) : i != 0 ? 1U : 0U;
            }

            public static ulong ShiftRightJam(ulong l, int dist)
            {
                return dist < 63 ? (l >> dist) | (l << (-dist & 63) != 0 ? 1UL : 0UL) : l != 0 ? 1UL : 0UL;
            }

            /// <summary>
            /// Count the number of leading zero bits in a mask.
            /// Similar in behavior to the x86 instruction LZCNT.
            /// </summary>
            /// <param name="value">The value.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static int LeadingZeroCount(uint value)
            {
                // Unguarded fallback contract is 0->31
                if (value == 0)
                {
                    return 32;
                }

                return 31 - Log2SoftwareFallback(value);
            }

            /// <summary>
            /// Count the number of leading zero bits in a mask.
            /// Similar in behavior to the x86 instruction LZCNT.
            /// </summary>
            /// <param name="value">The value.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [CLSCompliant(false)]
            public static int LeadingZeroCount(ulong value)
            {
                var hi = (uint) (value >> 32);

                if (hi == 0)
                {
                    return 32 + LeadingZeroCount((uint) value);
                }

                return LeadingZeroCount(hi);
            }

            /// <summary>
            /// Returns the integer (floor) log of the specified value, base 2.
            /// Note that by convention, input value 0 returns 0 since Log(0) is undefined.
            /// Does not directly use any hardware intrinsics, nor does it incur branching.
            /// </summary>
            /// <param name="value">The value.</param>
            private static int Log2SoftwareFallback(uint value)
            {
                // No AggressiveInlining due to large method size
                // Has conventional contract 0->0 (Log(0) is undefined)

                // Fill trailing zeros with ones, eg 00010010 becomes 00011111
                value |= value >> 01;
                value |= value >> 02;
                value |= value >> 04;
                value |= value >> 08;
                value |= value >> 16;

                // uint.MaxValue >> 27 is always in range [0 - 31] so we use Unsafe.AddByteOffset to avoid bounds check
                return Unsafe.AddByteOffset
                (
                    // Using deBruijn sequence, k=2, n=5 (2^5=32) : 0b_0000_0111_1100_0100_1010_1100_1101_1101u
                    ref MemoryMarshal.GetReference(Log2DeBruijn),
                    // uint|long -> IntPtr cast on 32-bit platforms does expensive overflow checks not needed here
                    (IntPtr) (int) ((value * 0x07C4ACDDu) >> 27)
                );
            }
        }
    }
}
