// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 2D integer vector.</summary>
    internal struct Vector2I<T> :
        IEquatable<Vector2I<T>>,
        IReadOnlyList<T>,
        ISpanFormattable,
        ISpanParsable<Vector2I<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector2I<T>>,
        IParsable<Vector2I<T>>,
        IFormattable
        where T : IBinaryInteger<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>Initializes both components to the same value.</summary>
        public Vector2I(T value) => (X, Y) = (value, value);

        /// <summary>Initializes the vector with individual values for X and Y.</summary>
        public Vector2I(T x, T y) => (X, Y) = (x, y);

        /// <summary>Initializes the vector from a span of two values.</summary>
        public Vector2I(ReadOnlySpan<T> values)
        {
            if (values.Length != 2)
                throw new ArgumentException("Input span must contain exactly 2 elements.", nameof(values));

            X = values[0];
            Y = values[1];
        }

        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2I<T> One => new(Scalar<T>.One);

        /// <summary>Gets the vector (1, 0).</summary>
        public static Vector2I<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 1).</summary>
        public static Vector2I<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2I<T> Zero => default;

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y);

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 2;

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y. </summary>
        public T this[int index] => index switch {
            0 => X,
            1 => Y,
            _ => throw new ArgumentOutOfRangeException(nameof(index), "Index must be 0 or 1.")
        };

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Vector2I{T}"/> instance.</summary>
        public bool Equals(Vector2I<T> other) => X.Equals(other.X) && Y.Equals(other.Y);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
        }

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector2I<T> other) => (X * other.X) + (Y * other.Y);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector2I<T> left, Vector2I<T> right) => (left.X * right.X) + (left.Y * right.Y);

        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public T Cross(Vector2I<T> other) => (X * other.Y) - (Y * other.X);

        /// <summary> Computes the cross product of two vectors. </summary>
        public static T Cross(Vector2I<T> left, Vector2I<T> right) => (left.X * right.Y) - (left.Y * right.X);

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 2);

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector2I<T> Max(Vector2I<T> other) =>
            new Vector2I<T>(T.Max(X, other.X), T.Max(Y, other.Y));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector2I<T> Max(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(T.Max(left.X, right.X), T.Max(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector2I<T> Max(T scalar) =>
            new Vector2I<T>(T.Max(X, scalar), T.Max(Y, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector2I<T> Max(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(T.Max(vector.X, scalar), T.Max(vector.Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector2I<T> Min(Vector2I<T> other) =>
            new Vector2I<T>(T.Min(X, other.X), T.Min(Y, other.Y));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector2I<T> Min(Vector2I<T> left, Vector2I<T> right) =>
            new Vector2I<T>(T.Min(left.X, right.X), T.Min(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector2I<T> Min(T scalar) =>
            new Vector2I<T>(T.Min(X, scalar), T.Min(Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector2I<T> Min(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(T.Min(vector.X, scalar), T.Min(vector.Y, scalar));

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) => $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";

        /// <summary>Formats the vector as a string.</summary>
        public override string ToString() => $"<{X}, {Y}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            // Format components individually into temporary buffers
            // Not too sure about this implementation
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider))
            {
                charsWritten = 0;
                return false;
            }

            // Calculate total required length: < + x + ", " + y + >
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

        /// <summary>Parses a span to a Vector2I instance.</summary>
        public static Vector2I<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector2I.");

            return result;
        }

        /// <summary>Parses a string to a Vector2I instance.</summary>
        public static Vector2I<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Tries to parse a span to a Vector2I instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result)
        {
            result = default;

            s = s.Trim();
            if (s.Length < 5 || s[0] != '<' || s[^1] != '>')
                return false;

            s = s[1..^1]; // Remove < and >

            int commaIndex = s.IndexOf(',');
            if (commaIndex < 0)
                return false;

            ReadOnlySpan<char> xSpan = s[..commaIndex].Trim();
            ReadOnlySpan<char> ySpan = s[(commaIndex + 1)..].Trim();

            if (T.TryParse(xSpan, provider, out var x) &&
                T.TryParse(ySpan, provider, out var y))
            {
                result = new Vector2I<T>(x, y);
                return true;
            }

            return false;
        }


        /// <summary>Tries to parse a string to a Vector2I instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a Vector2I instance.</summary>
        static Vector2I<T> ISpanParsable<Vector2I<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a Vector2I instance.</summary>
        static Vector2I<T> IParsable<Vector2I<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a Vector2I instance.</summary>
        static bool ISpanParsable<Vector2I<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a Vector2I instance.</summary>
        static bool IParsable<Vector2I<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            // Format components individually into temporary buffers
            // Not too sure about this implementation
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider))
            {
                bytesWritten = 0;
                return false;
            }

            // Estimate total required UTF-8 bytes
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

        /// <summary>Parses a UTF-8 span to a Vector2I instance.</summary>
        public static Vector2I<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a Vector2I instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2I<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        // Component Operators
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

        // Scalar Operators
        public static Vector2I<T> operator +(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X + scalar, vector.Y + scalar);

        public static Vector2I<T> operator -(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X - scalar, vector.Y - scalar);

        public static Vector2I<T> operator *(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X * scalar, vector.Y * scalar);

        public static Vector2I<T> operator /(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X / scalar, vector.Y / scalar);

        public static Vector2I<T> operator %(Vector2I<T> vector, T scalar) =>
            new Vector2I<T>(vector.X % scalar, vector.Y % scalar);

        // + operator: returns the vector (?)
        public static Vector2I<T> operator +(Vector2I<T> vector) => vector;

        //  - operator: returns the negated vector
        public static Vector2I<T> operator -(Vector2I<T> vector) =>
            new Vector2I<T>(-vector.X, -vector.Y);
    }
}
