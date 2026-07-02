// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Runtime.CompilerServices;
    using System.Text;

    internal ref struct ValueStringBuilder
    {
        /// <summary>Optional provider to pass to IFormattable.ToString or ISpanFormattable.TryFormat calls.</summary>
        private readonly IFormatProvider? _provider;

        /// <summary>The span to write into.</summary>
        private Span<char> _chars;

        /// <summary>Position at which to write the next character.</summary>
        private int _pos;

        public int CharsWritten => _pos;

        public ValueStringBuilder(IFormatProvider? provider, Span<char> chars)
        {
            _provider = provider;
            _chars = chars;
        }

        public ValueStringBuilder(Span<char> chars)
        {
            _provider = null;
            _chars = chars;
        }

        /// <summary>Writes the specified string to the handler.</summary>
        /// <param name="value">The string to write.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AppendLiteral(ReadOnlySpan<char> value)
        {
            if (value.TryCopyTo(_chars[_pos..]))
            {
                _pos += value.Length;
                return true;
            }

            return false;
        }

        /// <summary>Writes the specified value to the handler.</summary>
        /// <param name="value">The value to write.</param>
        /// <param name="format">The format string.</param>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        public bool AppendFormatted<T>(T value, ReadOnlySpan<char> format) where T : ISpanFormattable
        {
            if (value is null)
            {
                return true;
            }

            {
                if (!value.TryFormat(_chars[_pos..], out var charsWritten, format, _provider))
                {
                    return false;
                }

                _pos += charsWritten;
                return true;
            }
        }
    }

    internal ref struct ValueUtf8StringBuilder
    {
        /// <summary>Optional provider to pass to IFormattable.ToString or ISpanFormattable.TryFormat calls.</summary>
        private readonly IFormatProvider? _provider;

        /// <summary>The span to write into.</summary>
        private Span<byte> _chars;

        /// <summary>Position at which to write the next character.</summary>
        private int _pos;

        public int BytesWritten => _pos;

        public ValueUtf8StringBuilder(IFormatProvider? provider, Span<byte> chars)
        {
            _provider = provider;
            _chars = chars;
        }

        public ValueUtf8StringBuilder(Span<byte> chars)
        {
            _provider = null;
            _chars = chars;
        }

        /// <summary>Writes the specified string to the handler.</summary>
        /// <param name="value">The string to write.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AppendLiteral(ReadOnlySpan<byte> value)
        {
            if (value.TryCopyTo(_chars[_pos..]))
            {
                _pos += value.Length;
                return true;
            }

            return false;
        }

        /// <summary>Writes the specified value to the handler.</summary>
        /// <param name="value">The value to write.</param>
        /// <param name="format">The format string.</param>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        public bool AppendFormatted<T>(T value, ReadOnlySpan<char> format) where T : ISpanFormattable
        {
            if (value is null)
            {
                return true;
            }

            if (value is IUtf8SpanFormattable utf8Value)
            {
                if (!utf8Value.TryFormat(_chars[_pos..], out var charsWritten, format, _provider))
                {
                    return false;
                }

                _pos += charsWritten;
                return true;
            }
            else
            {
                Span<char> intermediateBuf = stackalloc char[64];
                if (!value.TryFormat(intermediateBuf, out var charsWritten, format, _provider))
                {
                    return false;
                }

                if (Encoding.UTF8.GetByteCount(intermediateBuf[..charsWritten]) > _chars.Length - _pos)
                {
                    return false;
                }

                _pos += Encoding.UTF8.GetBytes(intermediateBuf[..charsWritten], _chars[_pos..]);
                return true;
            }
        }
    }
}
