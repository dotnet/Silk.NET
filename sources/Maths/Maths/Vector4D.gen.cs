namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using System.Text;

    public partial struct Vector4D<T> :
        IEquatable<Vector4D<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector4D<T>>,
        ISpanFormattable,
        ISpanParsable<Vector4D<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector4D<T>>
        where T : INumberBase<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>The W component of the vector.</summary>
        public T W;

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector4D(T value) => (X, Y, Z, W) = (value, value, value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector4D(T x, T y, T z, T w) => (X, Y, Z, W) = (x, y, z, w);

        /// <summary> Initializes the vector using a <see cref="Vector2D{T}"/> for the initial elements, and the specified components for the remainder. </summary>
        public Vector4D(Vector2D<T> other, T z, T w) => (X, Y, Z, W) = (other.X, other.Y, z, w);

        /// <summary> Initializes the vector using a <see cref="Vector3D{T}"/> for the initial elements, and the specified component for the remainder. </summary>
        public Vector4D(Vector3D<T> other, T w) => (X, Y, Z, W) = (other.X, other.Y, other.Z, w);

        /// <summary>Initializes the vector from a span of 4 values.</summary>
        public Vector4D(ReadOnlySpan<T> values)
        {
            if (values.Length != 4)
                throw new ArgumentException("Input span must contain exactly 4 elements.", nameof(values));

            X = values[0];
            Y = values[1];
            Z = values[2];
            W = values[3];
        }

        /// <summary>Gets a vector whose 4 elements are equal to one.</summary>
        public static Vector4D<T> One => new(T.One);

        /// <summary>Returns a vector whose 4 elements are equal to zero.</summary>
        public static Vector4D<T> Zero => default;

        /// <summary>Gets the vector (1, 0, 0, 0).</summary>
        public static Vector4D<T> UnitX => new(T.One, T.Zero, T.Zero, T.Zero);

        /// <summary>Gets the vector (0, 1, 0, 0).</summary>
        public static Vector4D<T> UnitY => new(T.Zero, T.One, T.Zero, T.Zero);

        /// <summary>Gets the vector (0, 0, 1, 0).</summary>
        public static Vector4D<T> UnitZ => new(T.Zero, T.Zero, T.One, T.Zero);

        /// <summary>Gets the vector (0, 0, 0, 1).</summary>
        public static Vector4D<T> UnitW => new(T.Zero, T.Zero, T.Zero, T.One);


        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => this[index];

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z, 3 = W. </summary>
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
                    case 2:
                        return ref Z;
                    case 3:
                        return ref W;
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 4;

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
            yield return Z;
            yield return W;
        }

        /// <summary>Copies the components of the vector to the specified array starting at index 0.</summary>
        public void CopyTo(T[] array) => CopyTo(array, 0);

        /// <summary>Copies the components of the vector to the specified array starting at the given index.</summary>
        public void CopyTo(T[] array, int startIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (startIndex < 0 || startIndex + 4 > array.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            array[startIndex] = X;
            array[startIndex + 1] = Y;
            array[startIndex + 2] = Z;
            array[startIndex + 3] = W;
        }

        /// <summary>Copies the components of the vector to the specified span starting at index 0.</summary>
        public void CopyTo(Span<T> span) => CopyTo(span, 0);

        /// <summary>Copies the components of the vector to the specified span starting at the given index.</summary>
        public void CopyTo(Span<T> span, int startIndex)
        {
            if (startIndex < 0 || startIndex + 4 > span.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            span[startIndex] = X;
            span[startIndex + 1] = Y;
            span[startIndex + 2] = Z;
            span[startIndex + 3] = W;
        }

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 4);

        /// <summary>Formats the vector as a string.</summary>
        public override string ToString() =>
            $"<{X}, {Y}, {Z}, {W}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}, {W.ToString(format, formatProvider)}>";

        /// <summary>Parses a string to a <see cref="Vector4D{T}"/> instance.</summary>
        public static Vector4D<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector4D{T}"/> instance.</summary>
        public static Vector4D<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector4D.");

            return result;
        }

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];
            Span<char> zBuffer = stackalloc char[64];
            Span<char> wBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider)||
                !Y.TryFormat(yBuffer, out int yChars, format, provider)||
                !Z.TryFormat(zBuffer, out int zChars, format, provider)||
                !W.TryFormat(wBuffer, out int wChars, format, provider))
            {
                bytesWritten = 0;
                return false;
            }

            int estimatedSize = Encoding.UTF8.GetByteCount(xBuffer[..xChars]) +
                                Encoding.UTF8.GetByteCount(yBuffer[..yChars]) +
                                Encoding.UTF8.GetByteCount(zBuffer[..zChars]) +
                                Encoding.UTF8.GetByteCount(wBuffer[..wChars]) +
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
            totalBytes += Encoding.UTF8.GetBytes(", ", utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(zBuffer[..zChars], utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(", ", utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(wBuffer[..wChars], utf8Destination[totalBytes..]);
            totalBytes += Encoding.UTF8.GetBytes(">", utf8Destination[totalBytes..]);

            bytesWritten = totalBytes;
            return true;
        }

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];
            Span<char> zBuffer = stackalloc char[64];
            Span<char> wBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider) ||
                !Z.TryFormat(zBuffer, out int zChars, format, provider) ||
                !W.TryFormat(wBuffer, out int wChars, format, provider))
            {
                charsWritten = 0;
                return false;
            }

            int requiredLength = 1 + xChars + 2 + yChars + 2 + zChars + 2 + wChars + 1;

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

            destination[pos++] = ',';
            destination[pos++] = ' ';

            zBuffer[..zChars].CopyTo(destination[pos..]);
            pos += zChars;

            destination[pos++] = ',';
            destination[pos++] = ' ';

            wBuffer[..wChars].CopyTo(destination[pos..]);
            pos += wChars;

            destination[pos++] = '>';

            charsWritten = pos;
            return true;
        }

        /// <summary>Tries to parse a span to a <see cref="Vector4D{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4D<T> result)
        {
            result = default;

            s = s.Trim();
            if (s.Length < 8 || s[0] != '<' || s[^1] != '>')
                return false;

            s = s[1..^1]; // Remove < and >

            int commaX = s.IndexOf(',');
            if (commaX < 0)
                return false;

            ReadOnlySpan<char> remainder1 = s.Slice(commaX + 1);
            int commaYRelative = remainder1.IndexOf(',');
            if (commaYRelative < 0)
                return false;
            int commaY = commaX + 1 + commaYRelative;

            ReadOnlySpan<char> remainder2 = s.Slice(commaY + 1);
            int commaZRelative = remainder2.IndexOf(',');
            if (commaZRelative < 0)
                return false;
            int commaZ = commaY + 1 + commaZRelative;

            ReadOnlySpan<char> xSpan = s[..commaX].Trim();
            ReadOnlySpan<char> ySpan = s[(commaX + 1)..commaY].Trim();
            ReadOnlySpan<char> zSpan = s[(commaY + 1)..commaZ].Trim();
            ReadOnlySpan<char> wSpan = s[(commaZ + 1)..].Trim();

            if (T.TryParse(xSpan, provider, out var x) &&
                T.TryParse(ySpan, provider, out var y) &&
                T.TryParse(zSpan, provider, out var z) &&
                T.TryParse(wSpan, provider, out var w))
            {
                result = new Vector4D<T>(x, y, z, w);
                return true;
            }

            return false;
        }

        /// <summary>Parses a UTF-8 span to a <see cref="Vector4D{T}"/> instance.</summary>
        public static Vector4D<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector4D{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4D<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        /// <summary>Tries to parse a string to a <see cref="Vector4D{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4D<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector4D{T}"/> instance.</summary>
        static Vector4D<T> ISpanParsable<Vector4D<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector4D{T}"/> instance.</summary>
        static Vector4D<T> IParsable<Vector4D<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector4D{T}"/> instance.</summary>
        static bool ISpanParsable<Vector4D<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4D<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector4D{T}"/> instance.</summary>
        static bool IParsable<Vector4D<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4D<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector4D<T> left, Vector4D<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z &&
            left.W == right.W;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector4D<T> left, Vector4D<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector4D<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector4D<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector4D<T> CreateChecked<TOther>(Vector4D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateChecked(source.X), T.CreateChecked(source.Y), T.CreateChecked(source.Z), T.CreateChecked(source.W));

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector4D<T> CreateSaturating<TOther>(Vector4D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateSaturating(source.X), T.CreateSaturating(source.Y), T.CreateSaturating(source.Z), T.CreateSaturating(source.W));

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector4D<T> CreateTruncating<TOther>(Vector4D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateTruncating(source.X), T.CreateTruncating(source.Y), T.CreateTruncating(source.Z), T.CreateTruncating(source.W));

        /// <summary>Converts the components of this vector to another type.</summary>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Vector4D<TOther> As<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector4D<TOther>.CreateTruncating(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector4D<TOther> AsChecked<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector4D<TOther>.CreateChecked(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector4D<TOther> AsSaturating<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector4D<TOther>.CreateSaturating(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector4D<TOther> AsTruncating<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector4D<TOther>.CreateTruncating(this);

        /// <summary>Implicitly casts a <see cref="ValueTuple{T, T, T, T}"/> to a <see cref="Vector4D{T}"/>.</summary>
        public static implicit operator Vector4D<T>((T X, T Y, T Z, T W) v) =>
            new(v.X, v.Y, v.Z, v.W);

        /// <summary>Implicitly casts a <see cref="Vector4D{T}"/> to a <see cref="ValueTuple{T, T, T, T}"/>.</summary>
        public static implicit operator (T X, T Y, T Z, T W)(Vector4D<T> v) =>
            (v.X, v.Y, v.Z, v.W);

        /// <summary>Returns the given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The source vector.</returns>
        public static Vector4D<T> operator +(Vector4D<T> vector) =>
            vector;

        /// <summary>Negates a given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector4D<T> operator -(Vector4D<T> vector) =>
            new(-vector.X, -vector.Y, -vector.Z, -vector.W);

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        public static Vector4D<T> operator +(Vector4D<T> left, Vector4D<T> right) =>
            new(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        public static Vector4D<T> operator -(Vector4D<T> left, Vector4D<T> right) =>
            new(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        public static Vector4D<T> operator *(Vector4D<T> left, Vector4D<T> right) =>
            new(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        public static Vector4D<T> operator /(Vector4D<T> left, Vector4D<T> right) =>
            new(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);

        /// <summary>Adds a scalar to the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector4D<T> operator +(Vector4D<T> vector, T scalar) =>
            new(vector.X + scalar, vector.Y + scalar, vector.Z + scalar, vector.W + scalar);

        /// <summary>Subtracts a scalar from the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector4D<T> operator -(Vector4D<T> vector, T scalar) =>
            new(vector.X - scalar, vector.Y - scalar, vector.Z - scalar, vector.W - scalar);

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> operator *(Vector4D<T> vector, T scalar) =>
            new(vector.X * scalar, vector.Y * scalar, vector.Z * scalar, vector.W * scalar);

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="scalar">The scalar value.</param>
        /// <param name="vector">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> operator *(T scalar, Vector4D<T> vector) =>
            new(scalar * vector.X, scalar * vector.Y, scalar * vector.Z, scalar * vector.W);

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        public static Vector4D<T> operator /(Vector4D<T> vector, T scalar) =>
            new(vector.X / scalar, vector.Y / scalar, vector.Z / scalar, vector.W / scalar);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="Half"/> vector.</returns>
        public static explicit operator Vector4D<Half>(Vector4D<T> from) =>
            Vector4D<Half>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="Half"/> vector.</returns>
        public static explicit operator checked Vector4D<Half>(Vector4D<T> from) =>
            Vector4D<Half>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="float"/> vector.</returns>
        public static explicit operator Vector4D<float>(Vector4D<T> from) =>
            Vector4D<float>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="float"/> vector.</returns>
        public static explicit operator checked Vector4D<float>(Vector4D<T> from) =>
            Vector4D<float>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="double"/> vector.</returns>
        public static explicit operator Vector4D<double>(Vector4D<T> from) =>
            Vector4D<double>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="double"/> vector.</returns>
        public static explicit operator checked Vector4D<double>(Vector4D<T> from) =>
            Vector4D<double>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="decimal"/> vector.</returns>
        public static explicit operator Vector4D<decimal>(Vector4D<T> from) =>
            Vector4D<decimal>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="decimal"/> vector.</returns>
        public static explicit operator checked Vector4D<decimal>(Vector4D<T> from) =>
            Vector4D<decimal>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="byte"/> vector.</returns>
        public static explicit operator Vector4D<byte>(Vector4D<T> from) =>
            Vector4D<byte>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="byte"/> vector.</returns>
        public static explicit operator checked Vector4D<byte>(Vector4D<T> from) =>
            Vector4D<byte>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="short"/> vector.</returns>
        public static explicit operator Vector4D<short>(Vector4D<T> from) =>
            Vector4D<short>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="short"/> vector.</returns>
        public static explicit operator checked Vector4D<short>(Vector4D<T> from) =>
            Vector4D<short>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="int"/> vector.</returns>
        public static explicit operator Vector4D<int>(Vector4D<T> from) =>
            Vector4D<int>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="int"/> vector.</returns>
        public static explicit operator checked Vector4D<int>(Vector4D<T> from) =>
            Vector4D<int>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="long"/> vector.</returns>
        public static explicit operator Vector4D<long>(Vector4D<T> from) =>
            Vector4D<long>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="long"/> vector.</returns>
        public static explicit operator checked Vector4D<long>(Vector4D<T> from) =>
            Vector4D<long>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="sbyte"/> vector.</returns>
        public static explicit operator Vector4D<sbyte>(Vector4D<T> from) =>
            Vector4D<sbyte>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="sbyte"/> vector.</returns>
        public static explicit operator checked Vector4D<sbyte>(Vector4D<T> from) =>
            Vector4D<sbyte>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ushort"/> vector.</returns>
        public static explicit operator Vector4D<ushort>(Vector4D<T> from) =>
            Vector4D<ushort>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ushort"/> vector.</returns>
        public static explicit operator checked Vector4D<ushort>(Vector4D<T> from) =>
            Vector4D<ushort>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="uint"/> vector.</returns>
        public static explicit operator Vector4D<uint>(Vector4D<T> from) =>
            Vector4D<uint>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="uint"/> vector.</returns>
        public static explicit operator checked Vector4D<uint>(Vector4D<T> from) =>
            Vector4D<uint>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ulong"/> vector.</returns>
        public static explicit operator Vector4D<ulong>(Vector4D<T> from) =>
            Vector4D<ulong>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ulong"/> vector.</returns>
        public static explicit operator checked Vector4D<ulong>(Vector4D<T> from) =>
            Vector4D<ulong>.CreateChecked(from);
    }

    /// <summary>
    /// Methods for working with <see cref="Vector4D{T}"/>.
    /// </summary>
    public static partial class Vector4D
    {
        /// <summary>Extensions for vectors with elements implementing <see cref="IRootFunctions{TSelf}"/>.</summary>
        extension<T>(Vector4D<T> vector)
            where T : IRootFunctions<T>
        {
            /// <summary>Gets the length of the vector.</summary>
            public T Length => T.Sqrt(vector.LengthSquared);
        }

        /// <summary>Extensions for vectors with elements implementing <see cref="INumberBase{TSelf}"/>.</summary>
        extension<T>(Vector4D<T> vector)
            where T : INumberBase<T>
        {
            /// <summary>Gets the length squared of the vector.</summary>
            public T LengthSquared => Vector4D.Dot(vector, vector);
        }

        /// <summary>Desconstructs a vector into its components.</summary>
        /// <param name="vector">The vector to deconstruct.</param>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public static void Deconstruct<T>(this Vector4D<T> vector, out T x, out T y, out T z, out T w)
            where T : INumberBase<T>
        {
            x = vector.X;
            y = vector.Y;
            z = vector.Z;
            w = vector.W;
        }

        /// <summary>Computes the dot product of two vectors.</summary>
        public static T Dot<T>(this Vector4D<T> left, Vector4D<T> right)
            where T : INumberBase<T> =>
            left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector4D<T> Reflect<T>(Vector4D<T> vector, Vector4D<T> normal)
            where T : INumberBase<T>
        {
            T dot = vector.Dot(normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Normalizes a vector.</summary>
        public static Vector4D<T> Normalize<T>(this Vector4D<T> vector)
            where T : IRootFunctions<T>
        {
            T length = vector.Length;
            return length != T.Zero ? vector / length : Vector4D<T>.Zero;
        }

        /// <summary>Returns the Euclidean distance between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance.</returns>
        public static T Distance<T>(Vector4D<T> value1, Vector4D<T> value2)
            where T : IRootFunctions<T> =>
            T.Sqrt(DistanceSquared(value1, value2));

        /// <summary>Returns the Euclidean distance squared between the two given points.</summary>
        /// <param name="value1">The first point.</param>
        /// <param name="value2">The second point.</param>
        /// <returns>The distance squared.</returns>
        public static T DistanceSquared<T>(Vector4D<T> value1, Vector4D<T> value2)
            where T : INumberBase<T>
        {
            var difference = value1 - value2;
            return Dot(difference, difference);
        }

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector4D<T> LerpClamped<T>(Vector4D<T> a, Vector4D<T> b, T amount)
            where T : IFloatingPointIeee754<T> =>
            Lerp(a, b, T.Clamp(amount, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector4D<T> LerpClamped<T>(Vector4D<T> a, Vector4D<T> b, Vector4D<T> amount)
            where T : IFloatingPointIeee754<T> =>
            new(T.Lerp(a.X, b.X, T.Clamp(amount.X, T.Zero, T.One)),
                T.Lerp(a.Y, b.Y, T.Clamp(amount.Y, T.Zero, T.One)),
                T.Lerp(a.Z, b.Z, T.Clamp(amount.Z, T.Zero, T.One)),
                T.Lerp(a.W, b.W, T.Clamp(amount.W, T.Zero, T.One)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector4D<T> Sin, Vector4D<T> Cos) SinCos<T>(this Vector4D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.Sin(x.X), T.Sin(x.Y), T.Sin(x.Z), T.Sin(x.W)), new(T.Cos(x.X), T.Cos(x.Y), T.Cos(x.Z), T.Cos(x.W)));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinCosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static (Vector4D<T> SinPi, Vector4D<T> CosPi) SinCosPi<T>(this Vector4D<T> x)
            where T : ITrigonometricFunctions<T> =>
            (new(T.SinPi(x.X), T.SinPi(x.Y), T.SinPi(x.Z), T.SinPi(x.W)), new(T.CosPi(x.X), T.CosPi(x.Y), T.CosPi(x.Z), T.CosPi(x.W)));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.DivRem(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static (Vector4D<T> Quotient, Vector4D<T> Remainder) DivRem<T>(Vector4D<T> left, Vector4D<T> right)
            where T : IBinaryInteger<T>
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            var (qW, rW) = T.DivRem(left.W, right.W);
            return (new Vector4D<T>(qX, qY, qZ, qW), new Vector4D<T>(rX, rY, rZ, rW));
        }

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The source vector.</param>
        /// <param name="right">The scaling factor.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> Multiply<T>(Vector4D<T> left, T right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Multiplies a vector by a scalar value.</summary>
        /// <param name="left">The scaling factor.</param>
        /// <param name="right">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> Multiply<T>(T left, Vector4D<T> right)
            where T : INumberBase<T> =>
            left * right;

        /// <summary>Applies <see cref="INumber{TSelf}.Sign(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<int> Sign<TSelf>(this Vector4D<TSelf> value)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Sign(value.X), TSelf.Sign(value.Y), TSelf.Sign(value.Z), TSelf.Sign(value.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Max<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y.X), TSelf.Max(x.Y, y.Y), TSelf.Max(x.Z, y.Z), TSelf.Max(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Max(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Max<TSelf>(this Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Max(x.X, y), TSelf.Max(x.Y, y), TSelf.Max(x.Z, y), TSelf.Max(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxNumber<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y.X), TSelf.MaxNumber(x.Y, y.Y), TSelf.MaxNumber(x.Z, y.Z), TSelf.MaxNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.MaxNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxNumber<TSelf>(this Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MaxNumber(x.X, y), TSelf.MaxNumber(x.Y, y), TSelf.MaxNumber(x.Z, y), TSelf.MaxNumber(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Min<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y.X), TSelf.Min(x.Y, y.Y), TSelf.Min(x.Z, y.Z), TSelf.Min(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Min(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Min<TSelf>(this Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Min(x.X, y), TSelf.Min(x.Y, y), TSelf.Min(x.Z, y), TSelf.Min(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinNumber<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y.X), TSelf.MinNumber(x.Y, y.Y), TSelf.MinNumber(x.Z, y.Z), TSelf.MinNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumber{TSelf}.MinNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinNumber<TSelf>(this Vector4D<TSelf> x, TSelf y)
            where TSelf : INumber<TSelf> =>
            new(TSelf.MinNumber(x.X, y), TSelf.MinNumber(x.Y, y), TSelf.MinNumber(x.Z, y), TSelf.MinNumber(x.W, y));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A vector whose members will be provided for <parameref name="min"/>.</param>
        /// <param name="max">A vector whose members will be provided for <parameref name="max"/>.</param>
        public static Vector4D<TSelf> Clamp<TSelf>(this Vector4D<TSelf> value, Vector4D<TSelf> min, Vector4D<TSelf> max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min.X, max.X), TSelf.Clamp(value.Y, min.Y, max.Y), TSelf.Clamp(value.Z, min.Z, max.Z), TSelf.Clamp(value.W, min.W, max.W));

        /// <summary>Applies <see cref="INumber{TSelf}.Clamp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="min">A single value provided for <parameref name="min"/>.</param>
        /// <param name="max">A single value provided for <parameref name="max"/>.</param>
        public static Vector4D<TSelf> Clamp<TSelf>(this Vector4D<TSelf> value, TSelf min, TSelf max)
            where TSelf : INumber<TSelf> =>
            new(TSelf.Clamp(value.X, min, max), TSelf.Clamp(value.Y, min, max), TSelf.Clamp(value.Z, min, max), TSelf.Clamp(value.W, min, max));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A vector whose members will be provided for <parameref name="sign"/>.</param>
        public static Vector4D<TSelf> CopySign<TSelf>(this Vector4D<TSelf> value, Vector4D<TSelf> sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign.X), TSelf.CopySign(value.Y, sign.Y), TSelf.CopySign(value.Z, sign.Z), TSelf.CopySign(value.W, sign.W));

        /// <summary>Applies <see cref="INumber{TSelf}.CopySign(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        /// <param name="sign">A single value provided for <parameref name="sign"/>.</param>
        public static Vector4D<TSelf> CopySign<TSelf>(this Vector4D<TSelf> value, TSelf sign)
            where TSelf : INumber<TSelf> =>
            new(TSelf.CopySign(value.X, sign), TSelf.CopySign(value.Y, sign), TSelf.CopySign(value.Z, sign), TSelf.CopySign(value.W, sign));

        /// <summary>Applies <see cref="INumberBase{TSelf}.Abs(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<TSelf> Abs<TSelf>(this Vector4D<TSelf> value)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.Abs(value.X), TSelf.Abs(value.Y), TSelf.Abs(value.Z), TSelf.Abs(value.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxMagnitude<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitude(x.X, y.X), TSelf.MaxMagnitude(x.Y, y.Y), TSelf.MaxMagnitude(x.Z, y.Z), TSelf.MaxMagnitude(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MaxMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MaxMagnitudeNumber<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MaxMagnitudeNumber(x.X, y.X), TSelf.MaxMagnitudeNumber(x.Y, y.Y), TSelf.MaxMagnitudeNumber(x.Z, y.Z), TSelf.MaxMagnitudeNumber(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitude(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinMagnitude<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitude(x.X, y.X), TSelf.MinMagnitude(x.Y, y.Y), TSelf.MinMagnitude(x.Z, y.Z), TSelf.MinMagnitude(x.W, y.W));

        /// <summary>Applies <see cref="INumberBase{TSelf}.MinMagnitudeNumber(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> MinMagnitudeNumber<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : INumberBase<TSelf> =>
            new(TSelf.MinMagnitudeNumber(x.X, y.X), TSelf.MinMagnitudeNumber(x.Y, y.Y), TSelf.MinMagnitudeNumber(x.Z, y.Z), TSelf.MinMagnitudeNumber(x.W, y.W));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.PopCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<TSelf> PopCount<TSelf>(this Vector4D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.PopCount(value.X), TSelf.PopCount(value.Y), TSelf.PopCount(value.Z), TSelf.PopCount(value.W));

        /// <summary>Applies <see cref="IBinaryInteger{TSelf}.TrailingZeroCount(TSelf)"/> to the provided arguments.</summary>
        /// <param name="value">A vector whose members will be provided for <parameref name="value"/>.</param>
        public static Vector4D<TSelf> TrailingZeroCount<TSelf>(this Vector4D<TSelf> value)
            where TSelf : IBinaryInteger<TSelf> =>
            new(TSelf.TrailingZeroCount(value.X), TSelf.TrailingZeroCount(value.Y), TSelf.TrailingZeroCount(value.Z), TSelf.TrailingZeroCount(value.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Ceiling(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Ceiling<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Ceiling(x.X), TSelf.Ceiling(x.Y), TSelf.Ceiling(x.Z), TSelf.Ceiling(x.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Floor(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Floor<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Floor(x.X), TSelf.Floor(x.Y), TSelf.Floor(x.Z), TSelf.Floor(x.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Round<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X), TSelf.Round(x.Y), TSelf.Round(x.Z), TSelf.Round(x.W));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Round(TSelf, int, MidpointRounding)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="digits">A single value provided for <parameref name="digits"/>.</param>
        /// <param name="mode">A single value provided for <parameref name="mode"/>.</param>
        public static Vector4D<TSelf> Round<TSelf>(this Vector4D<TSelf> x, int digits, MidpointRounding mode)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Round(x.X, digits, mode), TSelf.Round(x.Y, digits, mode), TSelf.Round(x.Z, digits, mode), TSelf.Round(x.W, digits, mode));

        /// <summary>Applies <see cref="IFloatingPoint{TSelf}.Truncate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Truncate<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPoint<TSelf> =>
            new(TSelf.Truncate(x.X), TSelf.Truncate(x.Y), TSelf.Truncate(x.Z), TSelf.Truncate(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atan2<TSelf>(this Vector4D<TSelf> y, Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2(y.X, x.X), TSelf.Atan2(y.Y, x.Y), TSelf.Atan2(y.Z, x.Z), TSelf.Atan2(y.W, x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Atan2Pi(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atan2Pi<TSelf>(this Vector4D<TSelf> y, Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Atan2Pi(y.X, x.X), TSelf.Atan2Pi(y.Y, x.Y), TSelf.Atan2Pi(y.Z, x.Z), TSelf.Atan2Pi(y.W, x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Lerp(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="value1">A vector whose members will be provided for <parameref name="value1"/>.</param>
        /// <param name="value2">A vector whose members will be provided for <parameref name="value2"/>.</param>
        /// <param name="amount">A single value provided for <parameref name="amount"/>.</param>
        public static Vector4D<TSelf> Lerp<TSelf>(this Vector4D<TSelf> value1, Vector4D<TSelf> value2, TSelf amount)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Lerp(value1.X, value2.X, amount), TSelf.Lerp(value1.Y, value2.Y, amount), TSelf.Lerp(value1.Z, value2.Z, amount), TSelf.Lerp(value1.W, value2.W, amount));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitDecrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> BitDecrement<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitDecrement(x.X), TSelf.BitDecrement(x.Y), TSelf.BitDecrement(x.Z), TSelf.BitDecrement(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.BitIncrement(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> BitIncrement<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.BitIncrement(x.X), TSelf.BitIncrement(x.Y), TSelf.BitIncrement(x.Z), TSelf.BitIncrement(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        /// <param name="addend">A vector whose members will be provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> FusedMultiplyAdd<TSelf>(this Vector4D<TSelf> left, Vector4D<TSelf> right, Vector4D<TSelf> addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right.X, addend.X), TSelf.FusedMultiplyAdd(left.Y, right.Y, addend.Y), TSelf.FusedMultiplyAdd(left.Z, right.Z, addend.Z), TSelf.FusedMultiplyAdd(left.W, right.W, addend.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.FusedMultiplyAdd(TSelf, TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        /// <param name="addend">A single value provided for <parameref name="addend"/>.</param>
        public static Vector4D<TSelf> FusedMultiplyAdd<TSelf>(this Vector4D<TSelf> left, TSelf right, TSelf addend)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.FusedMultiplyAdd(left.X, right, addend), TSelf.FusedMultiplyAdd(left.Y, right, addend), TSelf.FusedMultiplyAdd(left.Z, right, addend), TSelf.FusedMultiplyAdd(left.W, right, addend));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A vector whose members will be provided for <parameref name="right"/>.</param>
        public static Vector4D<TSelf> Ieee754Remainder<TSelf>(this Vector4D<TSelf> left, Vector4D<TSelf> right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right.X), TSelf.Ieee754Remainder(left.Y, right.Y), TSelf.Ieee754Remainder(left.Z, right.Z), TSelf.Ieee754Remainder(left.W, right.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.Ieee754Remainder(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="left">A vector whose members will be provided for <parameref name="left"/>.</param>
        /// <param name="right">A single value provided for <parameref name="right"/>.</param>
        public static Vector4D<TSelf> Ieee754Remainder<TSelf>(this Vector4D<TSelf> left, TSelf right)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.Ieee754Remainder(left.X, right), TSelf.Ieee754Remainder(left.Y, right), TSelf.Ieee754Remainder(left.Z, right), TSelf.Ieee754Remainder(left.W, right));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ILogB(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<int> ILogB<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ILogB(x.X), TSelf.ILogB(x.Y), TSelf.ILogB(x.Z), TSelf.ILogB(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> ReciprocalEstimate<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalEstimate(x.X), TSelf.ReciprocalEstimate(x.Y), TSelf.ReciprocalEstimate(x.Z), TSelf.ReciprocalEstimate(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ReciprocalSqrtEstimate(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> ReciprocalSqrtEstimate<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ReciprocalSqrtEstimate(x.X), TSelf.ReciprocalSqrtEstimate(x.Y), TSelf.ReciprocalSqrtEstimate(x.Z), TSelf.ReciprocalSqrtEstimate(x.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> ScaleB<TSelf>(this Vector4D<TSelf> x, Vector4D<int> n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n.X), TSelf.ScaleB(x.Y, n.Y), TSelf.ScaleB(x.Z, n.Z), TSelf.ScaleB(x.W, n.W));

        /// <summary>Applies <see cref="IFloatingPointIeee754{TSelf}.ScaleB(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> ScaleB<TSelf>(this Vector4D<TSelf> x, int n)
            where TSelf : IFloatingPointIeee754<TSelf> =>
            new(TSelf.ScaleB(x.X, n), TSelf.ScaleB(x.Y, n), TSelf.ScaleB(x.Z, n), TSelf.ScaleB(x.W, n));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Pow<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y.X), TSelf.Pow(x.Y, y.Y), TSelf.Pow(x.Z, y.Z), TSelf.Pow(x.W, y.W));

        /// <summary>Applies <see cref="IPowerFunctions{TSelf}.Pow(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A single value provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Pow<TSelf>(this Vector4D<TSelf> x, TSelf y)
            where TSelf : IPowerFunctions<TSelf> =>
            new(TSelf.Pow(x.X, y), TSelf.Pow(x.Y, y), TSelf.Pow(x.Z, y), TSelf.Pow(x.W, y));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Cbrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Cbrt<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Cbrt(x.X), TSelf.Cbrt(x.Y), TSelf.Cbrt(x.Z), TSelf.Cbrt(x.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Sqrt(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Sqrt<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Sqrt(x.X), TSelf.Sqrt(x.Y), TSelf.Sqrt(x.Z), TSelf.Sqrt(x.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A single value provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> RootN<TSelf>(this Vector4D<TSelf> x, int n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n), TSelf.RootN(x.Y, n), TSelf.RootN(x.Z, n), TSelf.RootN(x.W, n));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.RootN(TSelf, int)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="n">A vector whose members will be provided for <parameref name="n"/>.</param>
        public static Vector4D<TSelf> RootN<TSelf>(this Vector4D<TSelf> x, Vector4D<int> n)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.RootN(x.X, n.X), TSelf.RootN(x.Y, n.Y), TSelf.RootN(x.Z, n.Z), TSelf.RootN(x.W, n.W));

        /// <summary>Applies <see cref="IRootFunctions{TSelf}.Hypot(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="y">A vector whose members will be provided for <parameref name="y"/>.</param>
        public static Vector4D<TSelf> Hypot<TSelf>(this Vector4D<TSelf> x, Vector4D<TSelf> y)
            where TSelf : IRootFunctions<TSelf> =>
            new(TSelf.Hypot(x.X, y.X), TSelf.Hypot(x.Y, y.Y), TSelf.Hypot(x.Z, y.Z), TSelf.Hypot(x.W, y.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z), TSelf.Log(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log(TSelf, TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        /// <param name="newBase">A single value provided for <parameref name="newBase"/>.</param>
        public static Vector4D<TSelf> Log<TSelf>(this Vector4D<TSelf> x, TSelf newBase)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase), TSelf.Log(x.Y, newBase), TSelf.Log(x.Z, newBase), TSelf.Log(x.W, newBase));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.LogP1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> LogP1<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z), TSelf.LogP1(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log2<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z), TSelf.Log2(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log2P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log2P1<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z), TSelf.Log2P1(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log10<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z), TSelf.Log10(x.W));

        /// <summary>Applies <see cref="ILogarithmicFunctions{TSelf}.Log10P1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Log10P1<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z), TSelf.Log10P1(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z), TSelf.Exp(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.ExpM1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> ExpM1<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z), TSelf.ExpM1(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp2<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z), TSelf.Exp2(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp2M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp2M1<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z), TSelf.Exp2M1(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp10<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z), TSelf.Exp10(x.W));

        /// <summary>Applies <see cref="IExponentialFunctions{TSelf}.Exp10M1(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Exp10M1<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z), TSelf.Exp10M1(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Acos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Acos<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Acos(x.X), TSelf.Acos(x.Y), TSelf.Acos(x.Z), TSelf.Acos(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AcosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> AcosPi<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AcosPi(x.X), TSelf.AcosPi(x.Y), TSelf.AcosPi(x.Z), TSelf.AcosPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Asin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Asin<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Asin(x.X), TSelf.Asin(x.Y), TSelf.Asin(x.Z), TSelf.Asin(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AsinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> AsinPi<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AsinPi(x.X), TSelf.AsinPi(x.Y), TSelf.AsinPi(x.Z), TSelf.AsinPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Atan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atan<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Atan(x.X), TSelf.Atan(x.Y), TSelf.Atan(x.Z), TSelf.Atan(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.AtanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> AtanPi<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.AtanPi(x.X), TSelf.AtanPi(x.Y), TSelf.AtanPi(x.Z), TSelf.AtanPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Cos(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Cos<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Cos(x.X), TSelf.Cos(x.Y), TSelf.Cos(x.Z), TSelf.Cos(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.CosPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> CosPi<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.CosPi(x.X), TSelf.CosPi(x.Y), TSelf.CosPi(x.Z), TSelf.CosPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Sin(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Sin<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Sin(x.X), TSelf.Sin(x.Y), TSelf.Sin(x.Z), TSelf.Sin(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.SinPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> SinPi<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.SinPi(x.X), TSelf.SinPi(x.Y), TSelf.SinPi(x.Z), TSelf.SinPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.Tan(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Tan<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.Tan(x.X), TSelf.Tan(x.Y), TSelf.Tan(x.Z), TSelf.Tan(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.TanPi(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> TanPi<TSelf>(this Vector4D<TSelf> x)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.TanPi(x.X), TSelf.TanPi(x.Y), TSelf.TanPi(x.Z), TSelf.TanPi(x.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.DegreesToRadians(TSelf)"/> to the provided arguments.</summary>
        /// <param name="degrees">A vector whose members will be provided for <parameref name="degrees"/>.</param>
        public static Vector4D<TSelf> DegreesToRadians<TSelf>(this Vector4D<TSelf> degrees)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.DegreesToRadians(degrees.X), TSelf.DegreesToRadians(degrees.Y), TSelf.DegreesToRadians(degrees.Z), TSelf.DegreesToRadians(degrees.W));

        /// <summary>Applies <see cref="ITrigonometricFunctions{TSelf}.RadiansToDegrees(TSelf)"/> to the provided arguments.</summary>
        /// <param name="radians">A vector whose members will be provided for <parameref name="radians"/>.</param>
        public static Vector4D<TSelf> RadiansToDegrees<TSelf>(this Vector4D<TSelf> radians)
            where TSelf : ITrigonometricFunctions<TSelf> =>
            new(TSelf.RadiansToDegrees(radians.X), TSelf.RadiansToDegrees(radians.Y), TSelf.RadiansToDegrees(radians.Z), TSelf.RadiansToDegrees(radians.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Acosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Acosh<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Acosh(x.X), TSelf.Acosh(x.Y), TSelf.Acosh(x.Z), TSelf.Acosh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Asinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Asinh<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Asinh(x.X), TSelf.Asinh(x.Y), TSelf.Asinh(x.Z), TSelf.Asinh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Atanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Atanh<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Atanh(x.X), TSelf.Atanh(x.Y), TSelf.Atanh(x.Z), TSelf.Atanh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Cosh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Cosh<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Cosh(x.X), TSelf.Cosh(x.Y), TSelf.Cosh(x.Z), TSelf.Cosh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Sinh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Sinh<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Sinh(x.X), TSelf.Sinh(x.Y), TSelf.Sinh(x.Z), TSelf.Sinh(x.W));

        /// <summary>Applies <see cref="IHyperbolicFunctions{TSelf}.Tanh(TSelf)"/> to the provided arguments.</summary>
        /// <param name="x">A vector whose members will be provided for <parameref name="x"/>.</param>
        public static Vector4D<TSelf> Tanh<TSelf>(this Vector4D<TSelf> x)
            where TSelf : IHyperbolicFunctions<TSelf> =>
            new(TSelf.Tanh(x.X), TSelf.Tanh(x.Y), TSelf.Tanh(x.Z), TSelf.Tanh(x.W));
    }
}
