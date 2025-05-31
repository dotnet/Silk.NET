namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using System.Text;

    partial struct Vector3F<T> :
        IEquatable<Vector3F<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector3F<T>>,
        ISpanFormattable,
        ISpanParsable<Vector3F<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector3F<T>>
        where T : IFloatingPointIeee754<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector3F(T value) => (X, Y, Z) = (value, value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector3F(T x, T y, T z) => (X, Y, Z) = (x, y, z);

        /// <summary> Initializes the vector using a <see cref="Vector2F{T}"/> for the initial elements, and the specified component for the remainder. </summary>
        public Vector3F(Vector2F<T> other, T z) => (X, Y, Z) = (other.X, other.Y, z);

        /// <summary>Initializes the vector from a span of 3 values.</summary>
        public Vector3F(ReadOnlySpan<T> values)
        {
            if (values.Length != 3)
                throw new ArgumentException("Input span must contain exactly 3 elements.", nameof(values));

            X = values[0];
            Y = values[1];
            Z = values[2];
        }

        /// <summary>Gets a vector whose 3 elements are equal to one.</summary>
        public static Vector3F<T> One => new(Scalar<T>.One);

        /// <summary>Returns a vector whose 3 elements are equal to zero.</summary>
        public static Vector3F<T> Zero => default;

        /// <summary>Gets the vector (1, 0, 0).</summary>
        public static Vector3F<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 1, 0).</summary>
        public static Vector3F<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 0, 1).</summary>
        public static Vector3F<T> UnitZ => new(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => Vector3F.Dot(this, this);

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

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 3;

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
        public override string ToString() =>
            $"<{X}, {Y}, {Z}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}>";

        /// <summary>Parses a string to a <see cref="Vector3F{T}"/> instance.</summary>
        public static Vector3F<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector3F{T}"/> instance.</summary>
        public static Vector3F<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector3F.");

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

        /// <summary>Tries to parse a span to a <see cref="Vector3F{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3F<T> result)
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
                result = new Vector3F<T>(x, y, z);
                return true;
            }

            return false;
        }

        /// <summary>Parses a UTF-8 span to a <see cref="Vector3F{T}"/> instance.</summary>
        public static Vector3F<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector3F{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3F<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        /// <summary>Tries to parse a string to a <see cref="Vector3F{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3F<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector3F{T}"/> instance.</summary>
        static Vector3F<T> ISpanParsable<Vector3F<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector3F{T}"/> instance.</summary>
        static Vector3F<T> IParsable<Vector3F<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector3F{T}"/> instance.</summary>
        static bool ISpanParsable<Vector3F<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3F<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector3F{T}"/> instance.</summary>
        static bool IParsable<Vector3F<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3F<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector3F<T> left, Vector3F<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector3F<T> left, Vector3F<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector3F<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector3F<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        public static Vector3F<T> operator +(Vector3F<T> vector) =>
            vector;

        public static Vector3F<T> operator -(Vector3F<T> vector) =>
            new Vector3F<T>(-vector.X, -vector.Y, -vector.Z);

        public static Vector3F<T> operator +(Vector3F<T> left, Vector3F<T> right) =>
            new Vector3F<T>(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

        public static Vector3F<T> operator -(Vector3F<T> left, Vector3F<T> right) =>
            new Vector3F<T>(left.X - right.X, left.Y - right.Y, left.Z - right.Z);

        public static Vector3F<T> operator *(Vector3F<T> left, Vector3F<T> right) =>
            new Vector3F<T>(left.X * right.X, left.Y * right.Y, left.Z * right.Z);

        public static Vector3F<T> operator /(Vector3F<T> left, Vector3F<T> right) =>
            new Vector3F<T>(left.X / right.X, left.Y / right.Y, left.Z / right.Z);

        public static Vector3F<T> operator %(Vector3F<T> left, Vector3F<T> right) =>
            new Vector3F<T>(left.X % right.X, left.Y % right.Y, left.Z % right.Z);

        public static Vector3F<T> operator +(Vector3F<T> vector, T scalar) =>
            new Vector3F<T>(vector.X + scalar, vector.Y + scalar, vector.Z + scalar);

        public static Vector3F<T> operator -(Vector3F<T> vector, T scalar) =>
            new Vector3F<T>(vector.X - scalar, vector.Y - scalar, vector.Z - scalar);

        public static Vector3F<T> operator *(Vector3F<T> vector, T scalar) =>
            new Vector3F<T>(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);

        public static Vector3F<T> operator *(T scalar, Vector3F<T> vector) =>
            new Vector3F<T>(scalar * vector.X, scalar * vector.Y, scalar * vector.Z);

        public static Vector3F<T> operator /(Vector3F<T> vector, T scalar) =>
            new Vector3F<T>(vector.X / scalar, vector.Y / scalar, vector.Z / scalar);

        public static Vector3F<T> operator %(Vector3F<T> vector, T scalar) =>
            new Vector3F<T>(vector.X % scalar, vector.Y % scalar, vector.Z % scalar);

    }

    static partial class Vector3F
    {
        /// <summary>Computes the dot product of two vectors.</summary>
        public static T Dot<T>(this Vector3F<T> left, Vector3F<T> right)
            where T : IFloatingPointIeee754<T> =>
            left.X * right.X + left.Y * right.Y + left.Z * right.Z;

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector3F<T> Reflect<T>(Vector3F<T> vector, Vector3F<T> normal)
            where T : IFloatingPointIeee754<T>
        {
            T dot = vector.Dot(normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Computes the length of the vector.</summary>
        public static T GetLength<T>(this Vector3F<T> vector)
            where T : IFloatingPointIeee754<T> =>
            T.Sqrt(vector.LengthSquared);

        /// <summary>Normalizes a vector.</summary>
        public static Vector3F<T> Normalize<T>(this Vector3F<T> vector)
            where T : IFloatingPointIeee754<T>
        {
            T length = vector.GetLength();
            return length != T.Zero ? vector / length : Vector3F<T>.Zero;
        }

        public static Vector3F<TSelf> Log<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z));

        public static Vector3F<TSelf> Log<TSelf>(this Vector3F<TSelf> x, Vector3F<TSelf> newBase)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y), TSelf.Log(x.Z, newBase.Z));

        public static Vector3F<TSelf> LogP1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z));

        public static Vector3F<TSelf> Log2<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z));

        public static Vector3F<TSelf> Log2P1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z));

        public static Vector3F<TSelf> Log10<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z));

        public static Vector3F<TSelf> Log10P1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z));

        public static Vector3F<TSelf> Exp<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z));

        public static Vector3F<TSelf> ExpM1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z));

        public static Vector3F<TSelf> Exp2<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z));

        public static Vector3F<TSelf> Exp2M1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z));

        public static Vector3F<TSelf> Exp10<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z));

        public static Vector3F<TSelf> Exp10M1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z));
    }
}
