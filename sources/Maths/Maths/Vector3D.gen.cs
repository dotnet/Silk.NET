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

    /// <summary>A structure encapsulating a 3D vector.</summary>
    public partial struct Vector3D<T> :
        IEquatable<Vector3D<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector3D<T>>,
        ISpanFormattable,
        ISpanParsable<Vector3D<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector3D<T>>
        where T : INumberBase<T>
    {
        /// <summary>Gets a vector whose 3 elements are equal to one.</summary>
        public static Vector3D<T> One
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.One);
        }

        /// <summary>Returns a vector whose 3 elements are equal to zero.</summary>
        public static Vector3D<T> Zero
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero);
        }

        /// <summary>Gets the vector (1, 0, 0).</summary>
        public static Vector3D<T> UnitX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.One, T.Zero, T.Zero);
        }

        /// <summary>Gets the vector (0, 1, 0).</summary>
        public static Vector3D<T> UnitY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero, T.One, T.Zero);
        }

        /// <summary>Gets the vector (0, 0, 1).</summary>
        public static Vector3D<T> UnitZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero, T.Zero, T.One);
        }

        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 3;

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => this[index];

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z. </summary>
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
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector3D(T value) => (X, Y, Z) = (value, value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector3D(T x, T y, T z) => (X, Y, Z) = (x, y, z);

        /// <summary> Initializes the vector using a <see cref="Vector2D{T}"/> for the initial elements, and the specified component for the remainder. </summary>
        public Vector3D(Vector2D<T> other, T z) => (X, Y, Z) = (other.X, other.Y, z);

        /// <summary>Initializes the vector from a span of 3 values.</summary>
        public Vector3D(ReadOnlySpan<T> values)
        {
            if (values.Length != 3)
                throw new ArgumentException("Input span must contain exactly 3 elements.", nameof(values));

            X = values[0];
            Y = values[1];
            Z = values[2];
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
            yield return Z;
        }

        /// <summary>Copies the components of the vector to the specified array starting at index 0.</summary>
        public void CopyTo(T[] array) => CopyTo(array, 0);

        /// <summary>Copies the components of the vector to the specified array starting at the given index.</summary>
        public void CopyTo(T[] array, int startIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (startIndex < 0 || startIndex + 3 > array.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            array[startIndex] = X;
            array[startIndex + 1] = Y;
            array[startIndex + 2] = Z;
        }

        /// <summary>Copies the components of the vector to the specified span starting at index 0.</summary>
        public void CopyTo(Span<T> span) => CopyTo(span, 0);

        /// <summary>Copies the components of the vector to the specified span starting at the given index.</summary>
        public void CopyTo(Span<T> span, int startIndex)
        {
            if (startIndex < 0 || startIndex + 3 > span.Length)
                throw new ArgumentOutOfRangeException(nameof(startIndex));

            span[startIndex] = X;
            span[startIndex + 1] = Y;
            span[startIndex + 2] = Z;
        }

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 3);

        /// <summary>Formats the vector as a string.</summary>
        /// <returns>The string representation.</returns>
        public override string ToString() =>
            $"<{X}, {Y}, {Z}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        /// <returns>The string representation.</returns>
        public string ToString(string? format, IFormatProvider? formatProvider = null) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}>";

        /// <summary>Parses a string to a <see cref="Vector3D{T}"/> instance.</summary>
        public static Vector3D<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector3D{T}"/> instance.</summary>
        public static Vector3D<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector3D.");

            return result;
        }

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];
            Span<char> zBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider)||
                !Y.TryFormat(yBuffer, out int yChars, format, provider)||
                !Z.TryFormat(zBuffer, out int zChars, format, provider))
            {
                bytesWritten = 0;
                return false;
            }

            int estimatedSize = Encoding.UTF8.GetByteCount(xBuffer[..xChars]) +
                                Encoding.UTF8.GetByteCount(yBuffer[..yChars]) +
                                Encoding.UTF8.GetByteCount(zBuffer[..zChars]) +
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

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider) ||
                !Z.TryFormat(zBuffer, out int zChars, format, provider))
            {
                charsWritten = 0;
                return false;
            }

            int requiredLength = 1 + xChars + 2 + yChars + 2 + zChars + 1;

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

            destination[pos++] = '>';

            charsWritten = pos;
            return true;
        }

        /// <summary>Tries to parse a span to a <see cref="Vector3D{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3D<T> result)
        {
            result = default;

            s = s.Trim();
            if (s.Length < 6 || s[0] != '<' || s[^1] != '>')
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

            ReadOnlySpan<char> xSpan = s[..commaX].Trim();
            ReadOnlySpan<char> ySpan = s[(commaX + 1)..commaY].Trim();
            ReadOnlySpan<char> zSpan = s[(commaY + 1)..].Trim();

            if (T.TryParse(xSpan, provider, out var x) &&
                T.TryParse(ySpan, provider, out var y) &&
                T.TryParse(zSpan, provider, out var z))
            {
                result = new Vector3D<T>(x, y, z);
                return true;
            }

            return false;
        }

        /// <summary>Parses a UTF-8 span to a <see cref="Vector3D{T}"/> instance.</summary>
        public static Vector3D<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector3D{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3D<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        /// <summary>Tries to parse a string to a <see cref="Vector3D{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3D<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector3D{T}"/> instance.</summary>
        static Vector3D<T> ISpanParsable<Vector3D<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector3D{T}"/> instance.</summary>
        static Vector3D<T> IParsable<Vector3D<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector3D{T}"/> instance.</summary>
        static bool ISpanParsable<Vector3D<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3D<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector3D{T}"/> instance.</summary>
        static bool IParsable<Vector3D<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3D<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector3D<T> left, Vector3D<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector3D<T> left, Vector3D<T> right) =>
            left.X != right.X ||
            left.Y != right.Y ||
            left.Z != right.Z;

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector3D<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector3D<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector3D<T> CreateChecked<TOther>(Vector3D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateChecked(source.X), T.CreateChecked(source.Y), T.CreateChecked(source.Z));

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector3D<T> CreateSaturating<TOther>(Vector3D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateSaturating(source.X), T.CreateSaturating(source.Y), T.CreateSaturating(source.Z));

        /// <summary>Converts the components of this vector to another type.</summary>
        public static Vector3D<T> CreateTruncating<TOther>(Vector3D<TOther> source)
            where TOther : INumberBase<TOther> =>
            new(T.CreateTruncating(source.X), T.CreateTruncating(source.Y), T.CreateTruncating(source.Z));

        /// <summary>Converts the components of this vector to another type.</summary>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Vector3D<TOther> As<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector3D<TOther>.CreateTruncating(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector3D<TOther> AsChecked<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector3D<TOther>.CreateChecked(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector3D<TOther> AsSaturating<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector3D<TOther>.CreateSaturating(this);

        /// <summary>Converts the components of this vector to another type.</summary>
        public Vector3D<TOther> AsTruncating<TOther>()
            where TOther : INumberBase<TOther> =>
            Vector3D<TOther>.CreateTruncating(this);

        /// <summary>Implicitly casts a <see cref="ValueTuple{T, T, T}"/> to a <see cref="Vector3D{T}"/>.</summary>
        public static implicit operator Vector3D<T>((T X, T Y, T Z) value) =>
            new(value.X, value.Y, value.Z);

        /// <summary>Implicitly casts a <see cref="Vector3D{T}"/> to a <see cref="ValueTuple{T, T, T}"/>.</summary>
        public static implicit operator (T X, T Y, T Z)(Vector3D<T> value) =>
            (value.X, value.Y, value.Z);

        /// <summary>Explicitly casts a <see cref="Vector3D{T}"/> to a <see cref="Vector2D{T}"/> .</summary>
        public static explicit operator Vector2D<T>(Vector3D<T> value) =>
            new(value.X, value.Y);

        /// <summary>Explicitly casts a <see cref="Vector2D{T}"/> to a <see cref="Vector3D{T}"/>.</summary>
        public static explicit operator Vector3D<T>(Vector2D<T> value) =>
            new(value.X, value.Y, T.Zero);

        /// <summary>Returns the given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The source vector.</returns>
        public static Vector3D<T> operator +(Vector3D<T> vector) =>
            vector;

        /// <summary>Negates a given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector3D<T> operator -(Vector3D<T> vector) =>
            new(-vector.X, -vector.Y, -vector.Z);

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        public static Vector3D<T> operator +(Vector3D<T> left, Vector3D<T> right) =>
            new(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        public static Vector3D<T> operator -(Vector3D<T> left, Vector3D<T> right) =>
            new(left.X - right.X, left.Y - right.Y, left.Z - right.Z);

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        public static Vector3D<T> operator *(Vector3D<T> left, Vector3D<T> right) =>
            new(left.X * right.X, left.Y * right.Y, left.Z * right.Z);

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        public static Vector3D<T> operator /(Vector3D<T> left, Vector3D<T> right) =>
            new(left.X / right.X, left.Y / right.Y, left.Z / right.Z);

        /// <summary>Adds a scalar to the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector3D<T> operator +(Vector3D<T> vector, T scalar) =>
            new(vector.X + scalar, vector.Y + scalar, vector.Z + scalar);

        /// <summary>Subtracts a scalar from the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector3D<T> operator -(Vector3D<T> vector, T scalar) =>
            new(vector.X - scalar, vector.Y - scalar, vector.Z - scalar);

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector3D<T> operator *(Vector3D<T> vector, T scalar) =>
            new(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="scalar">The scalar value.</param>
        /// <param name="vector">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector3D<T> operator *(T scalar, Vector3D<T> vector) =>
            new(scalar * vector.X, scalar * vector.Y, scalar * vector.Z);

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        public static Vector3D<T> operator /(Vector3D<T> vector, T scalar) =>
            new(vector.X / scalar, vector.Y / scalar, vector.Z / scalar);

        /// <summary>Converts a <see cref="Vector3"/> to a <see cref="Vector3D{T}"/>.</summary>
        public static explicit operator Vector3D<T>(Vector3 from) =>
            new(T.CreateTruncating(from.X), T.CreateTruncating(from.Y), T.CreateTruncating(from.Z));

        /// <summary>Converts a <see cref="Vector3"/> to a <see cref="Vector3D{T}"/>.</summary>
        public static explicit operator checked Vector3D<T>(Vector3 from) =>
            new(T.CreateChecked(from.X), T.CreateChecked(from.Y), T.CreateChecked(from.Z));

        /// <summary>Converts a <see cref="Vector3D{T}"/> to <see cref="Vector3"/>.</summary>
        public static explicit operator Vector3(Vector3D<T> from) =>
            new(float.CreateTruncating(from.X), float.CreateTruncating(from.Y), float.CreateTruncating(from.Z));

        /// <summary>Converts a <see cref="Vector3D{T}"/> to <see cref="Vector3"/>.</summary>
        public static explicit operator checked Vector3(Vector3D<T> from) =>
            new(float.CreateChecked(from.X), float.CreateChecked(from.Y), float.CreateChecked(from.Z));

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="Half"/> vector.</returns>
        public static explicit operator Vector3D<Half>(Vector3D<T> from) =>
            Vector3D<Half>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="Half"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="Half"/> vector.</returns>
        public static explicit operator checked Vector3D<Half>(Vector3D<T> from) =>
            Vector3D<Half>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="float"/> vector.</returns>
        public static explicit operator Vector3D<float>(Vector3D<T> from) =>
            Vector3D<float>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="float"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="float"/> vector.</returns>
        public static explicit operator checked Vector3D<float>(Vector3D<T> from) =>
            Vector3D<float>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="double"/> vector.</returns>
        public static explicit operator Vector3D<double>(Vector3D<T> from) =>
            Vector3D<double>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="double"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="double"/> vector.</returns>
        public static explicit operator checked Vector3D<double>(Vector3D<T> from) =>
            Vector3D<double>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="decimal"/> vector.</returns>
        public static explicit operator Vector3D<decimal>(Vector3D<T> from) =>
            Vector3D<decimal>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="decimal"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="decimal"/> vector.</returns>
        public static explicit operator checked Vector3D<decimal>(Vector3D<T> from) =>
            Vector3D<decimal>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="byte"/> vector.</returns>
        public static explicit operator Vector3D<byte>(Vector3D<T> from) =>
            Vector3D<byte>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="byte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="byte"/> vector.</returns>
        public static explicit operator checked Vector3D<byte>(Vector3D<T> from) =>
            Vector3D<byte>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="short"/> vector.</returns>
        public static explicit operator Vector3D<short>(Vector3D<T> from) =>
            Vector3D<short>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="short"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="short"/> vector.</returns>
        public static explicit operator checked Vector3D<short>(Vector3D<T> from) =>
            Vector3D<short>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="int"/> vector.</returns>
        public static explicit operator Vector3D<int>(Vector3D<T> from) =>
            Vector3D<int>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="int"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="int"/> vector.</returns>
        public static explicit operator checked Vector3D<int>(Vector3D<T> from) =>
            Vector3D<int>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="long"/> vector.</returns>
        public static explicit operator Vector3D<long>(Vector3D<T> from) =>
            Vector3D<long>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="long"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="long"/> vector.</returns>
        public static explicit operator checked Vector3D<long>(Vector3D<T> from) =>
            Vector3D<long>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="sbyte"/> vector.</returns>
        public static explicit operator Vector3D<sbyte>(Vector3D<T> from) =>
            Vector3D<sbyte>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="sbyte"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="sbyte"/> vector.</returns>
        public static explicit operator checked Vector3D<sbyte>(Vector3D<T> from) =>
            Vector3D<sbyte>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ushort"/> vector.</returns>
        public static explicit operator Vector3D<ushort>(Vector3D<T> from) =>
            Vector3D<ushort>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ushort"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ushort"/> vector.</returns>
        public static explicit operator checked Vector3D<ushort>(Vector3D<T> from) =>
            Vector3D<ushort>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="uint"/> vector.</returns>
        public static explicit operator Vector3D<uint>(Vector3D<T> from) =>
            Vector3D<uint>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="uint"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="uint"/> vector.</returns>
        public static explicit operator checked Vector3D<uint>(Vector3D<T> from) =>
            Vector3D<uint>.CreateChecked(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ulong"/> vector.</returns>
        public static explicit operator Vector3D<ulong>(Vector3D<T> from) =>
            Vector3D<ulong>.CreateTruncating(from);

        /// <summary>
        /// Converts a vector of <typeparamref name="T"/> into one with an underlying type of <see cref="ulong"/>.
        /// </summary>
        /// <param name="from">The source vector.</param>
        /// <returns>The <see cref="ulong"/> vector.</returns>
        public static explicit operator checked Vector3D<ulong>(Vector3D<T> from) =>
            Vector3D<ulong>.CreateChecked(from);
    }
}
