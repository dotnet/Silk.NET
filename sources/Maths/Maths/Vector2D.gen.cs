namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using System.Text;

    public partial struct Vector2D<T> :
        IEquatable<Vector2D<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector2D<T>>,
        ISpanFormattable,
        ISpanParsable<Vector2D<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector2D<T>>
        where T : INumberBase<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

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

        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2D<T> One => new(T.One);

        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2D<T> Zero => default;

        /// <summary>Gets the vector (1, 0).</summary>
        public static Vector2D<T> UnitX => new(T.One, T.Zero);

        /// <summary>Gets the vector (0, 1).</summary>
        public static Vector2D<T> UnitY => new(T.Zero, T.One);


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
        public static bool operator !=(Vector2D<T> left, Vector2D<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector2D<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector2D<T> other) => this == other;

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
        public static implicit operator Vector2D<T>((T X, T Y) v) =>
            new(v.X, v.Y);

        /// <summary>Implicitly casts a <see cref="Vector2D{T}"/> to a <see cref="ValueTuple{T, T}"/>.</summary>
        public static implicit operator (T X, T Y)(Vector2D<T> v) =>
            (v.X, v.Y);

        /// <summary>Returns the given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The source vector.</returns>
        public static Vector2D<T> operator +(Vector2D<T> vector) =>
            vector;

        /// <summary>Negates a given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector2D<T> operator -(Vector2D<T> vector) =>
            new(-vector.X, -vector.Y);

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        public static Vector2D<T> operator +(Vector2D<T> left, Vector2D<T> right) =>
            new(left.X + right.X, left.Y + right.Y);

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        public static Vector2D<T> operator -(Vector2D<T> left, Vector2D<T> right) =>
            new(left.X - right.X, left.Y - right.Y);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        public static Vector2D<T> operator *(Vector2D<T> left, Vector2D<T> right) =>
            new(left.X * right.X, left.Y * right.Y);

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        public static Vector2D<T> operator /(Vector2D<T> left, Vector2D<T> right) =>
            new(left.X / right.X, left.Y / right.Y);

        /// <summary>Adds a scalar to the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector2D<T> operator +(Vector2D<T> vector, T scalar) =>
            new(vector.X + scalar, vector.Y + scalar);

        /// <summary>Subtracts a scalar from the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector2D<T> operator -(Vector2D<T> vector, T scalar) =>
            new(vector.X - scalar, vector.Y - scalar);

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> operator *(Vector2D<T> vector, T scalar) =>
            new(vector.X * scalar, vector.Y * scalar);

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="scalar">The scalar value.</param>
        /// <param name="vector">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> operator *(T scalar, Vector2D<T> vector) =>
            new(scalar * vector.X, scalar * vector.Y);

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        public static Vector2D<T> operator /(Vector2D<T> vector, T scalar) =>
            new(vector.X / scalar, vector.Y / scalar);

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

    /// <summary>
    /// Methods for working with <see cref="Vector2D{T}"/>.
    /// </summary>
    public static partial class Vector2D
    {
        /// <summary>Extensions for vectors with elements implementing <see cref="IRootFunctions{TSelf}"/>.</summary>
        extension<T>(Vector2D<T> vector)
            where T : IRootFunctions<T>
        {
            /// <summary>Gets the length of the vector.</summary>
            public T Length => T.Sqrt(vector.LengthSquared);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="INumberBase{TSelf}"/>.</summary>
        extension<T>(Vector2D<T> vector)
            where T : INumberBase<T>
        {
            /// <summary>Gets the length squared of the vector.</summary>
            public T LengthSquared => Vector2D.Dot(vector, vector);
        }

        /// <summary>Desconstructs a vector into its components.</summary>
        /// <param name="vector">The vector to deconstruct.</param>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public static void Deconstruct<T>(this Vector2D<T> vector, out T x, out T y)
            where T : INumberBase<T>
        {
            x = vector.X;
            y = vector.Y;
        }

        /// <summary>Computes the dot product of two vectors.</summary>
        public static T Dot<T>(this Vector2D<T> left, Vector2D<T> right)
            where T : INumberBase<T> =>
            left.X * right.X + left.Y * right.Y;

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector2D<T> Reflect<T>(Vector2D<T> vector, Vector2D<T> normal)
            where T : INumberBase<T>
        {
            T dot = vector.Dot(normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Normalizes a vector.</summary>
        public static Vector2D<T> Normalize<T>(this Vector2D<T> vector)
            where T : IRootFunctions<T>
        {
            T length = vector.Length;
            return length != T.Zero ? vector / length : Vector2D<T>.Zero;
        }

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        public static T Distance<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : IRootFunctions<T> =>
            T.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        public static T DistanceSquared<T>(Vector2D<T> value1, Vector2D<T> value2)
            where T : INumberBase<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector2D<T> LerpClamped<T>(Vector2D<T> a, Vector2D<T> b, T amount)
            where T : IFloatingPointIeee754<T> =>
            Lerp(a, b, T.Clamp(amount, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector2D<T> LerpClamped<T>(Vector2D<T> a, Vector2D<T> b, Vector2D<T> amount)
            where T : IFloatingPointIeee754<T> =>
            new(T.Lerp(a.X, b.X, T.Clamp(amount.X, T.Zero, T.One)),
                T.Lerp(a.Y, b.Y, T.Clamp(amount.Y, T.Zero, T.One)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector2D<T> Sin, Vector2D<T> Cos) SinCos<T>(this Vector2D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.Sin(x.X), T.Sin(x.Y)), new(T.Cos(x.X), T.Cos(x.Y)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector2D<T> SinPi, Vector2D<T> CosPi) SinCosPi<T>(this Vector2D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.SinPi(x.X), T.SinPi(x.Y)), new(T.CosPi(x.X), T.CosPi(x.Y)));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static (Vector2D<T> Quotient, Vector2D<T> Remainder) DivRem<T>(Vector2D<T> left, Vector2D<T> right)
            where T : IBinaryInteger<T>
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            return (new Vector2D<T>(qX, qY), new Vector2D<T>(rX, rY));
        }

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> Multiply<T>(Vector2D<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector2D<T> Multiply<T>(T left, Vector2D<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Applies <see cref="INumber{TSelf}.Sign(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<int> Sign<TSelf>(this Vector2D<TSelf> value)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Sign(value.X), TSelf.Sign(value.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Max<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y.X), TSelf.Max(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Max<TSelf>(this Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y), TSelf.Max(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxNumber<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y.X), TSelf.MaxNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxNumber<TSelf>(this Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y), TSelf.MaxNumber(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Min<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y.X), TSelf.Min(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Min<TSelf>(this Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y), TSelf.Min(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinNumber<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y.X), TSelf.MinNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinNumber<TSelf>(this Vector2D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y), TSelf.MinNumber(x.Y, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A vector whose members will be provided for <parameref name="min"/>.</param>
        /// <param name="max">A vector whose members will be provided for <parameref name="max"/>.</param>
        public static Vector2D<TSelf> Clamp<TSelf>(this Vector2D<TSelf> value, Vector2D<TSelf> min, Vector2D<TSelf> max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min.X, max.X), TSelf.Clamp(value.Y, min.Y, max.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A single value provided for <parameref name="min"/>.</param>
        /// <param name="max">A single value provided for <parameref name="max"/>.</param>
        public static Vector2D<TSelf> Clamp<TSelf>(this Vector2D<TSelf> value, TSelf min, TSelf max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min, max), TSelf.Clamp(value.Y, min, max));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A vector whose members will be provided for <parameref name="sign"/>.</param>
        public static Vector2D<TSelf> CopySign<TSelf>(this Vector2D<TSelf> value, Vector2D<TSelf> sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign.X), TSelf.CopySign(value.Y, sign.Y));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A single value provided for <parameref name="sign"/>.</param>
        public static Vector2D<TSelf> CopySign<TSelf>(this Vector2D<TSelf> value, TSelf sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign), TSelf.CopySign(value.Y, sign));

        /// <summary>Applies <see cref="INumberBase{TSelf}.Abs(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<TSelf> Abs<TSelf>(this Vector2D<TSelf> value)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.Abs(value.X), TSelf.Abs(value.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxMagnitude<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitude(x.X, y.X), TSelf.MaxMagnitude(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MaxMagnitudeNumber<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitudeNumber(x.X, y.X), TSelf.MaxMagnitudeNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinMagnitude<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitude(x.X, y.X), TSelf.MinMagnitude(x.Y, y.Y));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> MinMagnitudeNumber<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitudeNumber(x.X, y.X), TSelf.MinMagnitudeNumber(x.Y, y.Y));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.PopCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<TSelf> PopCount<TSelf>(this Vector2D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.PopCount(value.X), TSelf.PopCount(value.Y));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector2D<TSelf> TrailingZeroCount<TSelf>(this Vector2D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.TrailingZeroCount(value.X), TSelf.TrailingZeroCount(value.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Ceiling<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Ceiling(x.X), TSelf.Ceiling(x.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Floor<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Floor(x.X), TSelf.Floor(x.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Round<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X), TSelf.Round(x.Y));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector2D<TSelf> Round<TSelf>(this Vector2D<TSelf> x, int digits, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits, mode), TSelf.Round(x.Y, digits, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Truncate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Truncate<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Truncate(x.X), TSelf.Truncate(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atan2<TSelf>(this Vector2D<TSelf> y, Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2(y.X, x.X), TSelf.Atan2(y.Y, x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2Pi(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atan2Pi<TSelf>(this Vector2D<TSelf> y, Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2Pi(y.X, x.X), TSelf.Atan2Pi(y.Y, x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Lerp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value1">A vector whose members will be provided for <parameref name="value1"/>.</param>
        /// <param name="value2">A vector whose members will be provided for <parameref name="value2"/>.</param>
        /// <param name="amount">A single value provided for <parameref name="amount"/>.</param>
        public static Vector2D<TSelf> Lerp<TSelf>(this Vector2D<TSelf> value1, Vector2D<TSelf> value2, TSelf amount)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Lerp(value1.X, value2.X, amount), TSelf.Lerp(value1.Y, value2.Y, amount));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitDecrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> BitDecrement<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitDecrement(x.X), TSelf.BitDecrement(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitIncrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> BitIncrement<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitIncrement(x.X), TSelf.BitIncrement(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> FusedMultiplyAdd<TSelf>(this Vector2D<TSelf> left, Vector2D<TSelf> right, Vector2D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend.X), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector2D<TSelf> FusedMultiplyAdd<TSelf>(this Vector2D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend), TSelf.FusedMultiplyAdd(left.Y, right, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static Vector2D<TSelf> Ieee754Remainder<TSelf>(this Vector2D<TSelf> left, Vector2D<TSelf> right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right.X), TSelf.Ieee754Remainder(left.Y, right.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        public static Vector2D<TSelf> Ieee754Remainder<TSelf>(this Vector2D<TSelf> left, TSelf right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right), TSelf.Ieee754Remainder(left.Y, right));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ILogB(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<int> ILogB<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ILogB(x.X), TSelf.ILogB(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> ReciprocalEstimate<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalEstimate(x.X), TSelf.ReciprocalEstimate(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalSqrtEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> ReciprocalSqrtEstimate<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalSqrtEstimate(x.X), TSelf.ReciprocalSqrtEstimate(x.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> ScaleB<TSelf>(this Vector2D<TSelf> x, Vector2D<int> n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n.X), TSelf.ScaleB(x.Y, n.Y));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> ScaleB<TSelf>(this Vector2D<TSelf> x, int n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n), TSelf.ScaleB(x.Y, n));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Pow<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y.X), TSelf.Pow(x.Y, y.Y));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Pow<TSelf>(this Vector2D<TSelf> x, TSelf y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y), TSelf.Pow(x.Y, y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Cbrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Cbrt<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Cbrt(x.X), TSelf.Cbrt(x.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Sqrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Sqrt<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Sqrt(x.X), TSelf.Sqrt(x.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> RootN<TSelf>(this Vector2D<TSelf> x, int n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n), TSelf.RootN(x.Y, n));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector2D<TSelf> RootN<TSelf>(this Vector2D<TSelf> x, Vector2D<int> n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n.X), TSelf.RootN(x.Y, n.Y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector2D<TSelf> Hypot<TSelf>(this Vector2D<TSelf> x, Vector2D<TSelf> y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y.X), TSelf.Hypot(x.Y, y.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A single value provided for <parameref name="newBase"/>.</param>
        public static Vector2D<TSelf> Log<TSelf>(this Vector2D<TSelf> x, TSelf newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase), TSelf.Log(x.Y, newBase));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.LogP1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> LogP1<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log2<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log2P1<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log10<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Log10P1<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.ExpM1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> ExpM1<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp2<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp2M1<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp10<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Exp10M1<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Acos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Acos<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Acos(x.X), TSelf.Acos(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AcosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> AcosPi<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AcosPi(x.X), TSelf.AcosPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Asin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Asin<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Asin(x.X), TSelf.Asin(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AsinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> AsinPi<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AsinPi(x.X), TSelf.AsinPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Atan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atan<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Atan(x.X), TSelf.Atan(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AtanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> AtanPi<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AtanPi(x.X), TSelf.AtanPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Cos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Cos<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Cos(x.X), TSelf.Cos(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.CosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> CosPi<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.CosPi(x.X), TSelf.CosPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Sin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Sin<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Sin(x.X), TSelf.Sin(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> SinPi<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.SinPi(x.X), TSelf.SinPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Tan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Tan<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Tan(x.X), TSelf.Tan(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.TanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> TanPi<TSelf>(this Vector2D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.TanPi(x.X), TSelf.TanPi(x.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.DegreesToRadians(TSelf)"/> to the provided arguments.</summary>
        /// <param name="degrees">A vector whose members will be provided for <parameref name="degrees"/>.</param>
        public static Vector2D<TSelf> DegreesToRadians<TSelf>(this Vector2D<TSelf> degrees)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.DegreesToRadians(degrees.X), TSelf.DegreesToRadians(degrees.Y));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.RadiansToDegrees(TSelf)"/> to the provided arguments.</summary>
        /// <param name="radians">A vector whose members will be provided for <parameref name="radians"/>.</param>
        public static Vector2D<TSelf> RadiansToDegrees<TSelf>(this Vector2D<TSelf> radians)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.RadiansToDegrees(radians.X), TSelf.RadiansToDegrees(radians.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Acosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Acosh<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Acosh(x.X), TSelf.Acosh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Asinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Asinh<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Asinh(x.X), TSelf.Asinh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Atanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Atanh<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Atanh(x.X), TSelf.Atanh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Cosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Cosh<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Cosh(x.X), TSelf.Cosh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Sinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Sinh<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Sinh(x.X), TSelf.Sinh(x.Y));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Tanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector2D<TSelf> Tanh<TSelf>(this Vector2D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Tanh(x.X), TSelf.Tanh(x.Y));
    }
}
