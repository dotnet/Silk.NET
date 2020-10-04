// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//
// This file was sourced from OpenTK (https://github.com/opentk/opentk).
// Below are the copyright headers associated with OpenToolkit.Mathematics.Half, as well as the file itself ;)
/*
Copyright (c) 2006 - 2008 The Open Toolkit library.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */
/*
The conversion functions are derived from OpenEXR's implementation and are
governed by the following license:

Copyright (c) 2002, Industrial Light & Magic, a division of Lucas
Digital Ltd. LLC

All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are
met:
*       Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.
*       Redistributions in binary form must reproduce the above
copyright notice, this list of conditions and the following disclaimer
in the documentation and/or other materials provided with the
distribution.
*       Neither the name of Industrial Light & Magic nor the names of
its contributors may be used to endorse or promote products derived
from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Silk.NET.Core.Math
{
    /// <summary>
    /// The name Half is derived from half-precision floating-point number.
    /// It occupies only 16 bits, which are split into 1 Sign bit, 5 Exponent bits and 10 Mantissa bits.
    /// </summary>
    /// <remarks>
    /// Quote from ARB_half_float_pixel specification:
    /// Any representable 16-bit floating-point value is legal as input to a GL command that accepts 16-bit floating-point
    /// data.  The
    /// result of providing a value that is not a floating-point number (such as infinity or NaN) to such a command is
    /// unspecified,
    /// but must not lead to GL interruption or termination. Providing a denormalized number or negative zero to GL must
    /// yield
    /// predictable results.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Half : ISerializable, IComparable<Half>, IFormattable, IEquatable<Half>
    {
        private ushort _bits;

        /// <summary>
        /// Gets a value indicating whether the Half is zero.
        /// </summary>
        public bool IsZero => _bits == 0 || _bits == 0x8000;

        /// <summary>
        /// Gets a value indicating whether the Half represents Not A Number (NaN).
        /// </summary>
        public bool IsNaN => (_bits & 0x7C00) == 0x7C00 && (_bits & 0x03FF) != 0x0000;

        /// <summary>
        /// Gets a value indicating whether the Half represents positive infinity.
        /// </summary>
        public bool IsPositiveInfinity => _bits == 31744;

        /// <summary>
        /// Gets a value indicating whether the Half represents negative infinity.
        /// </summary>
        public bool IsNegativeInfinity => _bits == 64512;

        /// <summary>
        /// Initializes a new instance of the <see cref="Half"/> struct with <paramref name="f"/> being converted
        /// into a 16-bit half-precision floating-point number.
        /// </summary>
        /// <param name="f">32-bit single-precision floating-point number.</param>
        public Half(float f)
            : this()
        {
            unsafe
            {
                _bits = SingleToHalf(*(int*) &f);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Half"/> struct with <paramref name="f"/> being converted
        /// into a 16-bit half-precision floating-point number.
        /// </summary>
        /// <param name="f">32-bit single-precision floating-point number.</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Half(float f, bool throwOnError)
            : this(f)
        {
            if (throwOnError)
            {
                // handle cases that cause overflow rather than silently ignoring it
                if (f > MaxValue)
                {
                    throw new ArithmeticException("Half: Positive maximum value exceeded.");
                }

                if (f < -MaxValue)
                {
                    throw new ArithmeticException("Half: Negative minimum value exceeded.");
                }

                // handle cases that make no sense
                if (float.IsNaN(f))
                {
                    throw new ArithmeticException("Half: Input is not a number (NaN).");
                }

                if (float.IsPositiveInfinity(f))
                {
                    throw new ArithmeticException("Half: Input is positive infinity.");
                }

                if (float.IsNegativeInfinity(f))
                {
                    throw new ArithmeticException("Half: Input is negative infinity.");
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Half"/> struct with <paramref name="d"/> being converted
        /// into a 16-bit half-precision floating-point number.
        /// </summary>
        /// <param name="d">64-bit double-precision floating-point number.</param>
        public Half(double d)
            : this((float) d)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Half"/> struct with <paramref name="d"/> being converted
        /// into a 16-bit half-precision floating-point number.
        /// </summary>
        /// <param name="d">64-bit double-precision floating-point number.</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Half(double d, bool throwOnError)
            : this((float) d, throwOnError)
        {
        }

        /// <summary>
        /// Ported from OpenEXR's IlmBase 1.0.1.
        /// </summary>
        [Pure]
        private ushort SingleToHalf(int si32)
        {
            // Our floating point number, F, is represented by the bit pattern in integer i.
            // Disassemble that bit pattern into the sign, S, the exponent, E, and the significand, M.
            // Shift S into the position where it will go in in the resulting half number.
            // Adjust E, accounting for the different exponent bias of float and half (127 versus 15).
            var sign = (si32 >> 16) & 0x00008000;
            var exponent = ((si32 >> 23) & 0x000000ff) - (127 - 15);
            var mantissa = si32 & 0x007fffff;

            // Now reassemble S, E and M into a half:
            if (exponent <= 0)
            {
                if (exponent < -10)
                {
                    // E is less than -10. The absolute value of F is less than Half.MinValue
                    // (F may be a small normalized float, a denormalized float or a zero).
                    //
                    // We convert F to a half zero with the same sign as F.
                    return (ushort) sign;
                }

                // E is between -10 and 0. F is a normalized float whose magnitude is less than Half.MinNormalizedValue.
                //
                // We convert F to a denormalized half.

                // Add an explicit leading 1 to the significand.
                mantissa = mantissa | 0x00800000;

                // Round to M to the nearest (10+E)-bit value (with E between -10 and 0); in case of a tie, round to the nearest even value.
                //
                // Rounding may cause the significand to overflow and make our number normalized. Because of the way a half's bits
                // are laid out, we don't have to treat this case separately; the code below will handle it correctly.
                var t = 14 - exponent;
                var a = (1 << (t - 1)) - 1;
                var b = (mantissa >> t) & 1;

                mantissa = (mantissa + a + b) >> t;

                // Assemble the half from S, E (==zero) and M.
                return (ushort) (sign | mantissa);
            }

            if (exponent == 0xff - (127 - 15))
            {
                if (mantissa == 0)
                {
                    // F is an infinity; convert F to a half infinity with the same sign as F.
                    return (ushort) (sign | 0x7c00);
                }

                // F is a NAN; we produce a half NAN that preserves the sign bit and the 10 leftmost bits of the
                // significand of F, with one exception: If the 10 leftmost bits are all zero, the NAN would turn
                // into an infinity, so we have to set at least one bit in the significand.
                mantissa >>= 13;
                return (ushort) (sign | 0x7c00 | mantissa | (mantissa == 0 ? 1 : 0));
            }

            // E is greater than zero.  F is a normalized float. We try to convert F to a normalized half.

            // Round to M to the nearest 10-bit value. In case of a tie, round to the nearest even value.
            mantissa = mantissa + 0x00000fff + ((mantissa >> 13) & 1);

            if ((mantissa & 0x00800000) != 0)
            {
                mantissa = 0; // overflow in significand,
                exponent += 1; // adjust exponent
            }

            // exponent overflow
            if (exponent > 30)
            {
                throw new ArithmeticException("Half: Hardware floating-point overflow.");
            }

            // Assemble the half from S, E and M.
            return (ushort) (sign | (exponent << 10) | (mantissa >> 13));
        }

        /// <summary>
        /// Converts the 16-bit half to 32-bit floating-point.
        /// </summary>
        /// <returns>A single-precision floating-point number.</returns>
        public float ToSingle()
        {
            var i = HalfToFloat(_bits);

            unsafe
            {
                return *(float*) &i;
            }
        }

        /// <summary>
        /// Ported from OpenEXR's IlmBase 1.0.1.
        /// </summary>
        [Pure]
        private int HalfToFloat(ushort ui16)
        {
            var sign = (ui16 >> 15) & 0x00000001;
            var exponent = (ui16 >> 10) & 0x0000001f;
            var mantissa = ui16 & 0x000003ff;

            if (exponent == 0)
            {
                if (mantissa == 0)
                {
                    // Plus or minus zero
                    return sign << 31;
                }

                // Denormalized number -- renormalize it
                while ((mantissa & 0x00000400) == 0)
                {
                    mantissa <<= 1;
                    exponent -= 1;
                }

                exponent += 1;
                mantissa &= ~0x00000400;
            }
            else if (exponent == 31)
            {
                if (mantissa == 0)
                {
                    // Positive or negative infinity
                    return (sign << 31) | 0x7f800000;
                }

                // Nan -- preserve sign and significand bits
                return (sign << 31) | 0x7f800000 | (mantissa << 13);
            }

            // Normalized number
            exponent = exponent + (127 - 15);
            mantissa = mantissa << 13;

            // Assemble S, E and M.
            return (sign << 31) | (exponent << 23) | mantissa;
        }

        /// <summary>
        /// Converts a System.Single to a Silk.NET.Core.Math.Half.
        /// </summary>
        /// <param name="f">
        /// The <see cref="float"/> value to convert.
        /// </param>
        /// <returns>
        /// The <see cref="Half"/> result of the conversion.
        /// </returns>
        [Pure]
        public static explicit operator Half(float f)
        {
            return new Half(f);
        }

        /// <summary>
        /// Converts a System.Double to a Silk.NET.Core.Math.Half.
        /// </summary>
        /// <param name="d">
        /// The <see cref="double"/> value to convert.
        /// </param>
        /// <returns>
        /// The <see cref="Half"/> result of the conversion.
        /// </returns>
        [Pure]
        public static explicit operator Half(double d)
        {
            return new Half(d);
        }

        /// <summary>
        /// Converts a Silk.NET.Core.Math.Half to a System.Single.
        /// </summary>
        /// <param name="h">
        /// The <see cref="Half"/> value to convert.
        /// </param>
        /// <returns>
        /// The <see cref="float"/> result of the conversion.
        /// </returns>
        [Pure]
        public static implicit operator float(Half h)
        {
            return h.ToSingle();
        }

        /// <summary>
        /// Converts a Silk.NET.Core.Math.Half to a System.Double.
        /// </summary>
        /// <param name="h">
        /// The <see cref="Half"/> value to convert.
        /// </param>
        /// <returns>
        /// The <see cref="double"/> result of the conversion.
        /// </returns>
        [Pure]
        public static implicit operator double(Half h)
        {
            return h.ToSingle();
        }

        /// <summary>
        /// The size in bytes for an instance of the Half struct.
        /// </summary>
        public static readonly int SizeInBytes = 2;

        /// <summary>
        /// Smallest positive half.
        /// </summary>
        public static readonly float MinValue = 5.96046448e-08f;

        /// <summary>
        /// Smallest positive normalized half.
        /// </summary>
        public static readonly float MinNormalizedValue = 6.10351562e-05f;

        /// <summary>
        /// Largest positive half.
        /// </summary>
        public static readonly float MaxValue = 65504.0f;

        /// <summary>
        /// Smallest positive e for which half (1.0 + e) != half (1.0).
        /// </summary>
        public static readonly float Epsilon = 0.00097656f;

#pragma warning disable SA1611 // Element parameters should be documented
        /// <summary>
        /// Initializes a new instance of the <see cref="Half"/> struct.
        /// Used by <see cref="ISerializable"/> to deserialize the object.
        /// </summary>
        /// <param name="info">The object that contains a serialized <see cref="Half"/> struct.</param>
        /// <param name="context">The destination for this serialization. (This parameter is not used; specify null.).</param>
        public Half(SerializationInfo info, StreamingContext context)
        {
            _bits = (ushort) info.GetValue("bits", typeof(ushort));
        }

        /// <inheritdoc/>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("bits", _bits);
        }
#pragma warning restore SA1611 // Element parameters should be documented

        /// <summary>
        /// Updates the Half by reading from a Stream.
        /// </summary>
        /// <param name="bin">A BinaryReader instance associated with an open Stream.</param>
        public void FromBinaryStream(BinaryReader bin)
        {
            _bits = bin.ReadUInt16();
        }

        /// <summary>
        /// Writes the Half into a Stream.
        /// </summary>
        /// <param name="bin">A BinaryWriter instance associated with an open Stream.</param>
        public void ToBinaryStream(BinaryWriter bin)
        {
            bin.Write(_bits);
        }

        /// <summary>
        /// Returns a value indicating whether this instance is equal to a specified Silk.NET.Core.Math.Half value.
        /// </summary>
        /// <param name="other">Silk.NET.Core.Math.Half object to compare to this instance..</param>
        /// <returns>True, if other is equal to this instance; false otherwise.</returns>
        [Pure]
        public bool Equals(Half other)
        {
            const int maxUlps = 1;

            short k = unchecked((short) other._bits);
            short l = unchecked((short) _bits);

            // Make a lexicographically ordered as a twos-complement int
            if (k < 0)
            {
                k = (short) (0x8000 - k);
            }

            // Make b lexicographically ordered as a twos-complement int
            if (l < 0)
            {
                l = (short) (0x8000 - l);
            }

            var intDiff = System.Math.Abs((short) (k - l));

            if (intDiff <= maxUlps)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Compares this instance to a specified half-precision floating-point number
        /// and returns an integer that indicates whether the value of this instance
        /// is less than, equal to, or greater than the value of the specified half-precision
        /// floating-point number.
        /// </summary>
        /// <param name="other">A half-precision floating-point number to compare.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and value. If the number is:
        ///  <para>
        /// Less than zero, then this instance is less than other, or this instance is not a number
        /// (Silk.NET.Core.Math.Half.NaN) and other is a number.
        ///  </para>
        ///  <para>
        /// Zero: this instance is equal to value, or both this instance and other
        /// are not a number (Silk.NET.Core.Math.Half.NaN), Silk.NET.Core.Math.Half.PositiveInfinity, or
        /// Silk.NET.Core.Math.Half.NegativeInfinity.
        ///  </para>
        ///  <para>
        /// Greater than zero: this instance is greater than othrs, or this instance is a number
        /// and other is not a number (Silk.NET.Core.Math.Half.NaN).
        ///  </para>
        /// </returns>
        [Pure]
        public int CompareTo(Half other)
        {
            return ((float) this).CompareTo(other);
        }

        /// <summary>
        /// Converts this Half into a human-legible string representation.
        /// </summary>
        /// <returns>The string representation of this instance.</returns>
        public override string ToString()
        {
            return ToSingle().ToString();
        }

        /// <summary>
        /// Converts this Half into a human-legible string representation.
        /// </summary>
        /// <param name="format">Formatting for the output string.</param>
        /// <param name="formatProvider">Culture-specific formatting information.</param>
        /// <returns>The string representation of this instance.</returns>
        [Pure]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return ToSingle().ToString(format, formatProvider);
        }

        /// <summary>
        /// Converts the string representation of a number to a half-precision floating-point equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <returns>A new Half instance.</returns>
        [Pure]
        public static Half Parse(string s)
        {
            return (Half) float.Parse(s);
        }

        /// <summary>
        /// Converts the string representation of a number to a half-precision floating-point equivalent.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <param name="style">Specifies the format of s.</param>
        /// <param name="provider">Culture-specific formatting information.</param>
        /// <returns>A new Half instance.</returns>
        [Pure]
        public static Half Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            return (Half) float.Parse(s, style, provider);
        }

        /// <summary>
        /// Converts the string representation of a number to a half-precision floating-point equivalent. Returns success.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <param name="result">The Half instance to write to.</param>
        /// <returns>Success.</returns>
        [Pure]
        public static bool TryParse(string s, out Half result)
        {
            var b = float.TryParse(s, out float f);
            result = (Half) f;
            return b;
        }

        /// <summary>
        /// Converts the string representation of a number to a half-precision floating-point equivalent. Returns success.
        /// </summary>
        /// <param name="s">String representation of the number to convert.</param>
        /// <param name="style">Specifies the format of s.</param>
        /// <param name="provider">Culture-specific formatting information.</param>
        /// <param name="result">The Half instance to write to.</param>
        /// <returns>Success.</returns>
        [Pure]
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Half result)
        {
            var b = float.TryParse(s, style, provider, out float f);
            result = (Half) f;
            return b;
        }

        /// <summary>
        /// Returns the Half as an array of bytes.
        /// </summary>
        /// <param name="h">The Half to convert.</param>
        /// <returns>The input as byte array.</returns>
        [Pure]
        public static byte[] GetBytes(Half h)
        {
            return BitConverter.GetBytes(h._bits);
        }

        /// <summary>
        /// Converts an array of bytes into Half.
        /// </summary>
        /// <param name="value">A Half in it's byte[] representation.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A new Half instance.</returns>
        [Pure]
        public static Half FromBytes(byte[] value, int startIndex)
        {
            Half h;
            h._bits = BitConverter.ToUInt16(value, startIndex);
            return h;
        }
    }
}
