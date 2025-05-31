namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using System.Text;

    partial struct Vector2I<T> :
        IEquatable<Vector2I<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector2I<T>>,
        ISpanFormattable,
        ISpanParsable<Vector2I<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector2I<T>>
        where T : IBinaryInteger<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector2I(T value) => (X, Y) = (value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector2I(T x, T y) => (X, Y) = (x, y);

        /// <summary>Initializes the vector from a span of 2 values.</summary>
        public Vector2I(ReadOnlySpan<T> values)
        {
            if (values.Length != 2)
                throw new ArgumentException("Input span must contain exactly 2 elements.", nameof(values));

            X = values[0];
            Y = values[1];
        }

        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2I<T> One => new(Scalar<T>.One);

        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2I<T> Zero => default;

        /// <summary>Gets the vector (1, 0).</summary>
        public static Vector2I<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 1).</summary>
        public static Vector2I<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Gets a vector with all bits set for each component.</summary>
        public static Vector2I<T> AllBitsSet => new Vector2I<T>(T.AllBitsSet, T.AllBitsSet);

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

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 2;

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
        public override string ToString() =>
            $"<{X}, {Y}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";

        /// <summary>Parses a string to a <see cref="Vector2I{T}"/> instance.</summary>
        public static Vector2I<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector2I{T}"/> instance.</summary>
        public static Vector2I<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector2I.");

            return result;
        }

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider)||
                !Y.TryFormat(yBuffer, out int yChars, format, provider))
            {
                bytesWritten = 0;
                return false;
            }

            int estimatedSize = Encoding.UTF8.GetByteCount(xBuffer[..xChars]) +
                                Encoding.UTF8.GetByteCount(yBuffer[..yChars]) +
                                Encoding.UTF8.GetByteCount("<, >");

            if (utf8Destination.Length < estimatedSize)
            {
                bytesWritten = 0;
                return false;
            }

            int totalBytes = 0;

            totalBytes += Encoding.UTF8.GetBytes("<", utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(xBuffer[..xChars], utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(", ", utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(yBuffer[..yChars], utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(">", utf8Destination[totalBytes..]);

            bytesWritten = totalBytes;
            return true;
        }

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider))
            {
                charsWritten = 0;
                return false;
            }

            int requiredLength = 1 + xChars + 2 + yChars + 1;

            if (destination.Length < requiredLength)
            {
                charsWritten = 0;
                return false;
            }

            int pos = 0;
            destination[pos++] = '<';

            xBuffer[..xChars].CopyTo(destination[pos..]);
            pos += xChars;

            destination[pos++] = ',';
            destination[pos++] = ' ';

            yBuffer[..yChars].CopyTo(destination[pos..]);
            pos += yChars;

            destination[pos++] = '>';

            charsWritten = pos;
            return true;
        }

        /// <summary>Tries to parse a span to a <see cref="Vector2I{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result)
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
                result = new Vector2I<T>(x, y);
                return true;
            }

            return false;
        }

        /// <summary>Parses a UTF-8 span to a <see cref="Vector2I{T}"/> instance.</summary>
        public static Vector2I<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector2I{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        /// <summary>Tries to parse a string to a <see cref="Vector2I{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector2I{T}"/> instance.</summary>
        static Vector2I<T> ISpanParsable<Vector2I<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector2I{T}"/> instance.</summary>
        static Vector2I<T> IParsable<Vector2I<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector2I{T}"/> instance.</summary>
        static bool ISpanParsable<Vector2I<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector2I{T}"/> instance.</summary>
        static bool IParsable<Vector2I<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector2I<T> left, Vector2I<T> right) =>
            left.X == right.X &&
            left.Y == right.Y;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector2I<T> left, Vector2I<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector2I<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector2I<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y);

        public static Vector2I<T> operator +(Vector2I<T> vector) =>
            vector;

        public static Vector2I<T> operator -(Vector2I<T> vector) =>
            new Vector2I<T>(-vector.X, -vector.Y);

        public static Vector2I<T> operator +(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X + right.X, left.Y + right.Y);

        public static Vector2I<T> operator -(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X - right.X, left.Y - right.Y);

        public static Vector2I<T> operator *(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X * right.X, left.Y * right.Y);

        public static Vector2I<T> operator /(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X / right.X, left.Y / right.Y);

        public static Vector2I<T> operator %(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X % right.X, left.Y % right.Y);

        public static Vector2I<T> operator +(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X + scalar, vector.Y + scalar);

        public static Vector2I<T> operator -(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X - scalar, vector.Y - scalar);

        public static Vector2I<T> operator *(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X * scalar, vector.Y * scalar);

        public static Vector2I<T> operator *(T scalar, Vector2I<T> vector) =>
            new Vector2I<T>(scalar * vector.X, scalar * vector.Y);

        public static Vector2I<T> operator /(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X / scalar, vector.Y / scalar);

        public static Vector2I<T> operator %(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X % scalar, vector.Y % scalar);

        public static Vector2I<T> operator ~(Vector2I<T> vector) =>
            new Vector2I<T>(~vector.X, ~vector.Y);

        public static Vector2I<T> operator &(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X & right.X, left.Y & right.Y);

        public static Vector2I<T> operator |(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X | right.X, left.Y | right.Y);

        public static Vector2I<T> operator ^(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(left.X ^ right.X, left.Y ^ right.Y);

        public static Vector2I<T> operator &(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X & scalar, vector.Y & scalar);

        public static Vector2I<T> operator &(T scalar, Vector2I<T> vector) =>
            new Vector2I<T>(scalar & vector.X, scalar & vector.Y);

        public static Vector2I<T> operator |(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X | scalar, vector.Y | scalar);

        public static Vector2I<T> operator |(T scalar, Vector2I<T> vector) =>
            new Vector2I<T>(scalar | vector.X, scalar | vector.Y);

        public static Vector2I<T> operator ^(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X ^ scalar, vector.Y ^ scalar);

        public static Vector2I<T> operator ^(T scalar, Vector2I<T> vector) =>
            new Vector2I<T>(scalar ^ vector.X, scalar ^ vector.Y);
    }

    static partial class Vector2I
    {
        public static Vector2I<TSelf> Log<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y));

        public static Vector2I<TSelf> Log<TSelf>(this Vector2I<TSelf> x, Vector2I<TSelf> newBase)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y));

        public static Vector2I<TSelf> LogP1<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y));

        public static Vector2I<TSelf> Log2<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y));

        public static Vector2I<TSelf> Log2P1<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y));

        public static Vector2I<TSelf> Log10<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y));

        public static Vector2I<TSelf> Log10P1<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y));

        public static Vector2I<TSelf> Exp<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y));

        public static Vector2I<TSelf> ExpM1<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y));

        public static Vector2I<TSelf> Exp2<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y));

        public static Vector2I<TSelf> Exp2M1<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y));

        public static Vector2I<TSelf> Exp10<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y));

        public static Vector2I<TSelf> Exp10M1<TSelf>(this Vector2I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y));
    }
}
