namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using System.Text;

    partial struct Vector4I<T> :
        IEquatable<Vector4I<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector4I<T>>,
        ISpanFormattable,
        ISpanParsable<Vector4I<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector4I<T>>
        where T : IBinaryInteger<T>
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
        public Vector4I(T value) => (X, Y, Z, W) = (value, value, value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector4I(T x, T y, T z, T w) => (X, Y, Z, W) = (x, y, z, w);

        /// <summary> Initializes the vector using a <see cref="Vector2I{T}"/> for the initial elements, and the specified components for the remainder. </summary>
        public Vector4I(Vector2I<T> other, T z, T w) => (X, Y, Z, W) = (other.X, other.Y, z, w);

        /// <summary> Initializes the vector using a <see cref="Vector3I{T}"/> for the initial elements, and the specified component for the remainder. </summary>
        public Vector4I(Vector3I<T> other, T w) => (X, Y, Z, W) = (other.X, other.Y, other.Z, w);

        /// <summary>Initializes the vector from a span of 4 values.</summary>
        public Vector4I(ReadOnlySpan<T> values)
        {
            if (values.Length != 4)
                throw new ArgumentException("Input span must contain exactly 4 elements.", nameof(values));

            X = values[0];
            Y = values[1];
            Z = values[2];
            W = values[3];
        }

        /// <summary>Gets a vector whose 4 elements are equal to one.</summary>
        public static Vector4I<T> One => new(Scalar<T>.One);

        /// <summary>Returns a vector whose 4 elements are equal to zero.</summary>
        public static Vector4I<T> Zero => default;

        /// <summary>Gets the vector (1, 0, 0, 0).</summary>
        public static Vector4I<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 1, 0, 0).</summary>
        public static Vector4I<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 0, 1, 0).</summary>
        public static Vector4I<T> UnitZ => new(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 0, 0, 1).</summary>
        public static Vector4I<T> UnitW => new(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Gets a vector with all bits set for each component.</summary>
        public static Vector4I<T> AllBitsSet => new Vector4I<T>(T.AllBitsSet, T.AllBitsSet, T.AllBitsSet, T.AllBitsSet);

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

        /// <summary>Parses a string to a <see cref="Vector4I{T}"/> instance.</summary>
        public static Vector4I<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector4I{T}"/> instance.</summary>
        public static Vector4I<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector4I.");

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

        /// <summary>Tries to parse a span to a <see cref="Vector4I{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result)
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
                result = new Vector4I<T>(x, y, z, w);
                return true;
            }

            return false;
        }

        /// <summary>Parses a UTF-8 span to a <see cref="Vector4I{T}"/> instance.</summary>
        public static Vector4I<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector4I{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        /// <summary>Tries to parse a string to a <see cref="Vector4I{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector4I{T}"/> instance.</summary>
        static Vector4I<T> ISpanParsable<Vector4I<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector4I{T}"/> instance.</summary>
        static Vector4I<T> IParsable<Vector4I<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector4I{T}"/> instance.</summary>
        static bool ISpanParsable<Vector4I<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector4I{T}"/> instance.</summary>
        static bool IParsable<Vector4I<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector4I<T> left, Vector4I<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z &&
            left.W == right.W;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector4I<T> left, Vector4I<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector4I<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector4I<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        public static Vector4I<T> operator +(Vector4I<T> vector) =>
            vector;

        public static Vector4I<T> operator -(Vector4I<T> vector) =>
            new Vector4I<T>(-vector.X, -vector.Y, -vector.Z, -vector.W);

        public static Vector4I<T> operator +(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);

        public static Vector4I<T> operator -(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);

        public static Vector4I<T> operator *(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);

        public static Vector4I<T> operator /(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);

        public static Vector4I<T> operator %(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X % right.X, left.Y % right.Y, left.Z % right.Z, left.W % right.W);

        public static Vector4I<T> operator +(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X + scalar, vector.Y + scalar, vector.Z + scalar, vector.W + scalar);

        public static Vector4I<T> operator -(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X - scalar, vector.Y - scalar, vector.Z - scalar, vector.W - scalar);

        public static Vector4I<T> operator *(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X * scalar, vector.Y * scalar, vector.Z * scalar, vector.W * scalar);

        public static Vector4I<T> operator *(T scalar, Vector4I<T> vector) =>
            new Vector4I<T>(scalar * vector.X, scalar * vector.Y, scalar * vector.Z, scalar * vector.W);

        public static Vector4I<T> operator /(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X / scalar, vector.Y / scalar, vector.Z / scalar, vector.W / scalar);

        public static Vector4I<T> operator %(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X % scalar, vector.Y % scalar, vector.Z % scalar, vector.W % scalar);

        public static Vector4I<T> operator ~(Vector4I<T> vector) =>
            new Vector4I<T>(~vector.X, ~vector.Y, ~vector.Z, ~vector.W);

        public static Vector4I<T> operator &(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X & right.X, left.Y & right.Y, left.Z & right.Z, left.W & right.W);

        public static Vector4I<T> operator |(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X | right.X, left.Y | right.Y, left.Z | right.Z, left.W | right.W);

        public static Vector4I<T> operator ^(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(left.X ^ right.X, left.Y ^ right.Y, left.Z ^ right.Z, left.W ^ right.W);

        public static Vector4I<T> operator &(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X & scalar, vector.Y & scalar, vector.Z & scalar, vector.W & scalar);

        public static Vector4I<T> operator &(T scalar, Vector4I<T> vector) =>
            new Vector4I<T>(scalar & vector.X, scalar & vector.Y, scalar & vector.Z, scalar & vector.W);

        public static Vector4I<T> operator |(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X | scalar, vector.Y | scalar, vector.Z | scalar, vector.W | scalar);

        public static Vector4I<T> operator |(T scalar, Vector4I<T> vector) =>
            new Vector4I<T>(scalar | vector.X, scalar | vector.Y, scalar | vector.Z, scalar | vector.W);

        public static Vector4I<T> operator ^(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X ^ scalar, vector.Y ^ scalar, vector.Z ^ scalar, vector.W ^ scalar);

        public static Vector4I<T> operator ^(T scalar, Vector4I<T> vector) =>
            new Vector4I<T>(scalar ^ vector.X, scalar ^ vector.Y, scalar ^ vector.Z, scalar ^ vector.W);
    }

    static partial class Vector4I
    {
        public static Vector4I<TSelf> Log<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z), TSelf.Log(x.W));

        public static Vector4I<TSelf> Log<TSelf>(this Vector4I<TSelf> x, Vector4I<TSelf> newBase)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y), TSelf.Log(x.Z, newBase.Z), TSelf.Log(x.W, newBase.W));

        public static Vector4I<TSelf> LogP1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z), TSelf.LogP1(x.W));

        public static Vector4I<TSelf> Log2<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z), TSelf.Log2(x.W));

        public static Vector4I<TSelf> Log2P1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z), TSelf.Log2P1(x.W));

        public static Vector4I<TSelf> Log10<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z), TSelf.Log10(x.W));

        public static Vector4I<TSelf> Log10P1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z), TSelf.Log10P1(x.W));

        public static Vector4I<TSelf> Exp<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z), TSelf.Exp(x.W));

        public static Vector4I<TSelf> ExpM1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z), TSelf.ExpM1(x.W));

        public static Vector4I<TSelf> Exp2<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z), TSelf.Exp2(x.W));

        public static Vector4I<TSelf> Exp2M1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z), TSelf.Exp2M1(x.W));

        public static Vector4I<TSelf> Exp10<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z), TSelf.Exp10(x.W));

        public static Vector4I<TSelf> Exp10M1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z), TSelf.Exp10M1(x.W));
    }
}
