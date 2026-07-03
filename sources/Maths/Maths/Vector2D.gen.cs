// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>A structure encapsulating a 2D vector.</summary>
    public partial struct Vector2D<T> :
        IEquatable<Vector2D<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector2D<T>>,
        ISpanFormattable,
        ISpanParsable<Vector2D<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector2D<T>>
        where T : INumberBase<T>, IUtf8SpanFormattable
    {
        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2D<T> One
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.One);
        }

        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2D<T> Zero
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero);
        }

        /// <summary>Gets the vector (1, 0).</summary>
        public static Vector2D<T> UnitX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.One, T.Zero);
        }

        /// <summary>Gets the vector (0, 1).</summary>
        public static Vector2D<T> UnitY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero, T.One);
        }

        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 2;

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => this[index];

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y. </summary>
        [UnscopedRef]
        public ref T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return ref X;
                    case 1:
                        return ref Y;
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector2D(T value) => (X, Y) = (value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector2D(T x, T y) => (X, Y) = (x, y);

        /// <summary>Initializes the vector from a span of 2 values.</summary>
        public Vector2D(ReadOnlySpan<T> values)
        {
            if (values.Length != 2)
                throw new ArgumentException("Input span must contain exactly 2 elements.", nameof(values));

            X = values[0];
            Y = values[1];
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
        }

        /// <summary>Copies the components of the vector to the specified array starting at index 0.</summary>
        public void CopyTo(T[] array) => CopyTo(array, 0);

        /// <summary>Copies the components of the vector to the specified array starting at the given index.</summary>
        public void CopyTo(T[] array, int startIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (startIndex < 0 || startIndex + 2 > array.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            array[startIndex] = X;
            array[startIndex + 1] = Y;
        }

        /// <summary>Copies the components of the vector to the specified span starting at index 0.</summary>
        public void CopyTo(Span<T> span) => CopyTo(span, 0);

        /// <summary>Copies the components of the vector to the specified span starting at the given index.</summary>
        public void CopyTo(Span<T> span, int startIndex)
        {
            if (startIndex < 0 || startIndex + 2 > span.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            span[startIndex] = X;
            span[startIndex + 1] = Y;
        }

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 2);

        /// <summary>Formats the vector as a string.</summary>
        /// <returns>The string representation.</returns>
        public override string ToString() =>
            $"<{X}, {Y}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        /// <returns>The string representation.</returns>
        public string ToString(string? format, IFormatProvider? formatProvider = null) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";

        /// <summary>Parses a string to a <see cref="Vector2D{T}"/> instance.</summary>
        public static Vector2D<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector2D{T}"/> instance.</summary>
        public static Vector2D<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector2D.");

            return result;
        }

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            ValueUtf8StringBuilder vsb = new ValueUtf8StringBuilder(provider, utf8Destination);
            if (!vsb.AppendLiteral("<"u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendFormatted(X, format))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendFormatted(Y, format))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendLiteral(">"u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            bytesWritten = vsb.BytesWritten;
            return true;
        }

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            ValueStringBuilder vsb = new ValueStringBuilder(provider, destination);
            if (!vsb.AppendLiteral("<"))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendFormatted(X, format))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendFormatted(Y, format))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendLiteral(">"))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            charsWritten = vsb.CharsWritten;
            return true;
        }

        /// <summary>Tries to parse a span to a <see cref="Vector2D{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2D<T> result)
        {
            result = default;

            s = s.Trim();
            if (s.Length < 4 || s[0] != '<' || s[^1] != '>')
                return false;

            s = s[1..^1]; // Remove < and >

            int commaX = s.IndexOf(',');
            if (commaX < 0)
                return false;

            ReadOnlySpan<char> xSpan = s[..commaX].Trim();
            ReadOnlySpan<char> ySpan = s[(commaX + 1)..].Trim();

            if (T.TryParse(xSpan, provider, out var x) &&
                T.TryParse(ySpan, provider, out var y))
            {
                result = new Vector2D<T>(x, y);
                return true;
            }

            return false;
        }

        /// <summary>Parses a UTF-8 span to a <see cref="Vector2D{T}"/> instance.</summary>
        public static Vector2D<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector2D{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2D<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        /// <summary>Tries to parse a string to a <see cref="Vector2D{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2D<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector2D{T}"/> instance.</summary>
        static Vector2D<T> ISpanParsable<Vector2D<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector2D{T}"/> instance.</summary>
        static Vector2D<T> IParsable<Vector2D<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector2D{T}"/> instance.</summary>
        static bool ISpanParsable<Vector2D<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2D<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector2D{T}"/> instance.</summary>
        static bool IParsable<Vector2D<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2D<T> result) =>
            TryParse(s, provider, out result);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector2D<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector2D<T> other) =>
            X.Equals(other.X) &&
            Y.Equals(other.Y);

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector2D<T> left, Vector2D<T> right) =>
            left.X == right.X &&
            left.Y == right.Y;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector2D<T> left, Vector2D<T> right) =>
            left.X != right.X ||
            left.Y != right.Y;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y);

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector2D<T> CreateChecked<TOther>(Vector2D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateChecked(source.X), T.CreateChecked(source.Y));

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector2D<T> CreateSaturating<TOther>(Vector2D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateSaturating(source.X), T.CreateSaturating(source.Y));

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector2D<T> CreateTruncating<TOther>(Vector2D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateTruncating(source.X), T.CreateTruncating(source.Y));

        /// <summary>Converts the components of this vector to another type.</summary>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Vector2D<TOther> As<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector2D<TOther>.CreateTruncating(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector2D<TOther> AsChecked<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector2D<TOther>.CreateChecked(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector2D<TOther> AsSaturating<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector2D<TOther>.CreateSaturating(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector2D<TOther> AsTruncating<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector2D<TOther>.CreateTruncating(this);

        /// <summary>Implicitly casts a <see cref="ValueTuple{T, T}"/> to a <see cref="Vector2D{T}"/>.</summary>
        public static implicit operator Vector2D<T>((T X, T Y) value) =>
            new(value.X, value.Y);

        /// <summary>Implicitly casts a <see cref="Vector2D{T}"/> to a <see cref="ValueTuple{T, T}"/>.</summary>
        public static implicit operator (T X, T Y)(Vector2D<T> value) =>
            (value.X, value.Y);

        /// <summary>Returns the given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The source vector.</returns>
        public static Vector2D<T> operator +(Vector2D<T> vector) =>
            vector;

        /// <summary>Negates a given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector2D<T> operator -(Vector2D<T> vector)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(-Unsafe.BitCast<Vector2D<T>, Vector2>(vector));
            return new(-vector.X, -vector.Y);
        }

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        public static Vector2D<T> operator +(Vector2D<T> left, Vector2D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(left) + Unsafe.BitCast<Vector2D<T>, Vector2>(right));
            return new(left.X + right.X, left.Y + right.Y);
        }

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        public static Vector2D<T> operator -(Vector2D<T> left, Vector2D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(left) - Unsafe.BitCast<Vector2D<T>, Vector2>(right));
            return new(left.X - right.X, left.Y - right.Y);
        }

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        public static Vector2D<T> operator *(Vector2D<T> left, Vector2D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(left) * Unsafe.BitCast<Vector2D<T>, Vector2>(right));
            return new(left.X * right.X, left.Y * right.Y);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        public static Vector2D<T> operator /(Vector2D<T> left, Vector2D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(left) / Unsafe.BitCast<Vector2D<T>, Vector2>(right));
            return new(left.X / right.X, left.Y / right.Y);
        }

        /// <summary>Adds a scalar to the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector2D<T> operator +(Vector2D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(vector) + new Vector2(Unsafe.BitCast<T, float>(scalar)));
            return new(vector.X + scalar, vector.Y + scalar);
        }

        /// <summary>Subtracts a scalar from the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector2D<T> operator -(Vector2D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(vector) - new Vector2(Unsafe.BitCast<T, float>(scalar)));
            return new(vector.X - scalar, vector.Y - scalar);
        }

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> operator *(Vector2D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(vector) * Unsafe.BitCast<T, float>(scalar));
            return new(vector.X * scalar, vector.Y * scalar);
        }

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="scalar">The scalar value.</param>
        /// <param name="vector">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> operator *(T scalar, Vector2D<T> vector)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<T, float>(scalar) * Unsafe.BitCast<Vector2D<T>, Vector2>(vector));
            return new(scalar * vector.X, scalar * vector.Y);
        }

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        public static Vector2D<T> operator /(Vector2D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector2, Vector2D<T>>(Unsafe.BitCast<Vector2D<T>, Vector2>(vector) / Unsafe.BitCast<T, float>(scalar));
            return new(vector.X / scalar, vector.Y / scalar);
        }

        /// <summary>Converts a <see cref="Vector2"/> to a <see cref="Vector2D{T}"/>.</summary>
        public static explicit operator Vector2D<T>(Vector2 from) =>
            new(T.CreateTruncating(from.X), T.CreateTruncating(from.Y));

        /// <summary>Converts a <see cref="Vector2"/> to a <see cref="Vector2D{T}"/>.</summary>
        public static explicit operator checked Vector2D<T>(Vector2 from) =>
            new(T.CreateChecked(from.X), T.CreateChecked(from.Y));

        /// <summary>Converts a <see cref="Vector2D{T}"/> to <see cref="Vector2"/>.</summary>
        public static explicit operator Vector2(Vector2D<T> from) =>
            new(float.CreateTruncating(from.X), float.CreateTruncating(from.Y));

        /// <summary>Converts a <see cref="Vector2D{T}"/> to <see cref="Vector2"/>.</summary>
        public static explicit operator checked Vector2(Vector2D<T> from) =>
            new(float.CreateChecked(from.X), float.CreateChecked(from.Y));

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="Half"/> vector.</returns>
        public static explicit operator Vector2D<Half>(Vector2D<T> from) =>
            Vector2D<Half>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="Half"/> vector.</returns>
        public static explicit operator checked Vector2D<Half>(Vector2D<T> from) =>
            Vector2D<Half>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="float"/> vector.</returns>
        public static explicit operator Vector2D<float>(Vector2D<T> from) =>
            Vector2D<float>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="float"/> vector.</returns>
        public static explicit operator checked Vector2D<float>(Vector2D<T> from) =>
            Vector2D<float>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="double"/> vector.</returns>
        public static explicit operator Vector2D<double>(Vector2D<T> from) =>
            Vector2D<double>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="double"/> vector.</returns>
        public static explicit operator checked Vector2D<double>(Vector2D<T> from) =>
            Vector2D<double>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="decimal"/> vector.</returns>
        public static explicit operator Vector2D<decimal>(Vector2D<T> from) =>
            Vector2D<decimal>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="decimal"/> vector.</returns>
        public static explicit operator checked Vector2D<decimal>(Vector2D<T> from) =>
            Vector2D<decimal>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="byte"/> vector.</returns>
        public static explicit operator Vector2D<byte>(Vector2D<T> from) =>
            Vector2D<byte>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="byte"/> vector.</returns>
        public static explicit operator checked Vector2D<byte>(Vector2D<T> from) =>
            Vector2D<byte>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="short"/> vector.</returns>
        public static explicit operator Vector2D<short>(Vector2D<T> from) =>
            Vector2D<short>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="short"/> vector.</returns>
        public static explicit operator checked Vector2D<short>(Vector2D<T> from) =>
            Vector2D<short>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="int"/> vector.</returns>
        public static explicit operator Vector2D<int>(Vector2D<T> from) =>
            Vector2D<int>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="int"/> vector.</returns>
        public static explicit operator checked Vector2D<int>(Vector2D<T> from) =>
            Vector2D<int>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="long"/> vector.</returns>
        public static explicit operator Vector2D<long>(Vector2D<T> from) =>
            Vector2D<long>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="long"/> vector.</returns>
        public static explicit operator checked Vector2D<long>(Vector2D<T> from) =>
            Vector2D<long>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="sbyte"/> vector.</returns>
        public static explicit operator Vector2D<sbyte>(Vector2D<T> from) =>
            Vector2D<sbyte>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="sbyte"/> vector.</returns>
        public static explicit operator checked Vector2D<sbyte>(Vector2D<T> from) =>
            Vector2D<sbyte>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ushort"/> vector.</returns>
        public static explicit operator Vector2D<ushort>(Vector2D<T> from) =>
            Vector2D<ushort>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ushort"/> vector.</returns>
        public static explicit operator checked Vector2D<ushort>(Vector2D<T> from) =>
            Vector2D<ushort>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="uint"/> vector.</returns>
        public static explicit operator Vector2D<uint>(Vector2D<T> from) =>
            Vector2D<uint>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="uint"/> vector.</returns>
        public static explicit operator checked Vector2D<uint>(Vector2D<T> from) =>
            Vector2D<uint>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ulong"/> vector.</returns>
        public static explicit operator Vector2D<ulong>(Vector2D<T> from) =>
            Vector2D<ulong>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ulong"/> vector.</returns>
        public static explicit operator checked Vector2D<ulong>(Vector2D<T> from) =>
            Vector2D<ulong>.CreateChecked(from);
    }
}
