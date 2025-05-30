// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 2D floating-point vector.</summary>
    internal struct Vector2F<T> :
        IEquatable<Vector2F<T>>,
        IReadOnlyList<T>,
        ISpanFormattable,
        ISpanParsable<Vector2F<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector2F<T>>,
        IParsable<Vector2F<T>>,
        IFormattable
        where T : IBinaryFloatingPointIeee754<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>Initializes both components to the same value.</summary>
        public Vector2F(T value) => (X, Y) = (value, value);

        /// <summary>Initializes the vector with individual values for X and Y.</summary>
        public Vector2F(T x, T y) => (X, Y) = (x, y);

        /// <summary>Initializes the vector from a span of two values.</summary>
        public Vector2F(ReadOnlySpan<T> values)
        {
            if (values.Length != 2)
                throw new ArgumentException("Input span must contain exactly 2 elements.", nameof(values));

            X = values[0];
            Y = values[1];
        }

        /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
        public static Vector2F<T> One => new(Scalar<T>.One);

        /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
        public static Vector2F<T> Zero => default;

        /// <summary>Gets the vector (1, 0).</summary>
        public static Vector2F<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 1).</summary>
        public static Vector2F<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Gets a vector with all bits set for each component.</summary>
        public static Vector2F<T> AllBitsSet => new(T.AllBitsSet, T.AllBitsSet);

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y);

        /// <summary>Gets the length of the vector.</summary>
        public T Length => T.Sqrt(LengthSquared);

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 2;

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y. </summary>
        public T this[int index] => index switch {
            0 => X,
            1 => Y,
            _ => throw new ArgumentOutOfRangeException(nameof(index), "Index must be 0 or 1.")
        };

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Vector2F{T}"/> instance.</summary>
        public override bool Equals(object? obj) => obj is Vector2F<T> other && Equals(other);

        /// <summary>Returns a boolean indicating whether the given Vector2F is equal to this <see cref="Vector2F{T}"/> instance.</summary>
        public bool Equals(Vector2F<T> other) => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        public override int GetHashCode() => HashCode.Combine(X, Y);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
        }

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector2F<T> other) => (X * other.X) + (Y * other.Y);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector2F<T> left, Vector2F<T> right) => (left.X * right.X) + (left.Y * right.Y);

        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public T Cross(Vector2F<T> other) => (X * other.Y) - (Y * other.X);

        /// <summary> Computes the cross product of two vectors. </summary>
        public static T Cross(Vector2F<T> left, Vector2F<T> right) => (left.X * right.Y) - (left.Y * right.X);

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 2);

        /// <summary>Normalizes this vector.</summary>
        public Vector2F<T> Normalize()
        {
            T length = Length;
            return length != T.Zero ? this / length : Zero;
        }

        /// <summary>Normalizes a vector.</summary>
        public static Vector2F<T> Normalize(Vector2F<T> vector)
        {
            T length = vector.Length;
            return length != T.Zero ? vector / length : Zero;
        }

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector2F<T> Max(Vector2F<T> other) =>
            new(T.Max(X, other.X), T.Max(Y, other.Y));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector2F<T> Max(Vector2F<T> left, Vector2F<T> right) =>
            new(T.Max(left.X, right.X), T.Max(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector2F<T> Max(T scalar) =>
            new(T.Max(X, scalar), T.Max(Y, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector2F<T> Max(Vector2F<T> vector, T scalar) =>
            new(T.Max(vector.X, scalar), T.Max(vector.Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector2F<T> Min(Vector2F<T> other) =>
            new(T.Min(X, other.X), T.Min(Y, other.Y));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector2F<T> Min(Vector2F<T> left, Vector2F<T> right) =>
            new(T.Min(left.X, right.X), T.Min(left.Y, right.Y));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector2F<T> Min(T scalar) =>
            new(T.Min(X, scalar), T.Min(Y, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector2F<T> Min(Vector2F<T> vector, T scalar) =>
            new(T.Min(vector.X, scalar), T.Min(vector.Y, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector2F<T> Clamp(Vector2F<T> min, Vector2F<T> max) =>
            new(T.Clamp(X, min.X, max.X), T.Clamp(Y, min.Y, max.Y));

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector2F<T> Clamp(Vector2F<T> vector, Vector2F<T> min, Vector2F<T> max) =>
            new(T.Clamp(vector.X, min.X, max.X), T.Clamp(vector.Y, min.Y, max.Y));

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector2F<T> Clamp(T min, T max) =>
            new(T.Clamp(X, min, max), T.Clamp(Y, min, max));

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector2F<T> Clamp(Vector2F<T> vector, T min, T max) =>
            new(T.Clamp(vector.X, min, max), T.Clamp(vector.Y, min, max));

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector2F<T> Abs() => new(T.Abs(X), T.Abs(Y));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector2F<T> Abs(Vector2F<T> vector) =>
            new(T.Abs(vector.X), T.Abs(vector.Y));

        /// <summary>Linearly interpolates between two vectors using a scalar t-value.</summary>
        public static Vector2F<T> Lerp(Vector2F<T> a, Vector2F<T> b, T t) =>
            new(a.X + (b.X - a.X) * t, a.Y + (b.Y - a.Y) * t);

        /// <summary>Linearly interpolates between two vectors using a vector t-value.</summary>
        public static Vector2F<T> Lerp(Vector2F<T> a, Vector2F<T> b, Vector2F<T> t) =>
            new(a.X + (b.X - a.X) * t.X, a.Y + (b.Y - a.Y) * t.Y);

        /// <summary>Linearly interpolates between two vectors using a scalar t-value (clamped between 0 and 1).</summary>
        public static Vector2F<T> LerpClamped(Vector2F<T> a, Vector2F<T> b, T t) =>
            Lerp(a, b, T.Clamp(t, T.Zero, T.One));

        /// <summary>Linearly interpolates between two vectors using a vector t-value (clamped between 0 and 1).</summary>
        public static Vector2F<T> LerpClamped(Vector2F<T> a, Vector2F<T> b, Vector2F<T> t) =>
            new(
                a.X + (b.X - a.X) * T.Clamp(t.X, T.Zero, T.One),
                a.Y + (b.Y - a.Y) * T.Clamp(t.Y, T.Zero, T.One)
            );

        /// <summary>Reflects a vector over a normal vector.</summary>
        public Vector2F<T> Reflect(Vector2F<T> normal)
        {
            T dot = Dot(normal);
            return this - (normal * (dot + dot));
        }

        /// <summary>Reflects a vector over a normal vector.</summary>
        public static Vector2F<T> Reflect(Vector2F<T> vector, Vector2F<T> normal)
        {
            T dot = Dot(vector, normal);
            return vector - (normal * (dot + dot));
        }

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) => $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";

        /// <summary>Formats the vector as a string.</summary>
        public override string ToString() => $"<{X}, {Y}>";

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

        /// <summary>Parses a span to a <see cref="Vector2F{T}"/> instance.</summary>
        public static Vector2F<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector2F.");

            return result;
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

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector2F<T> Sign() => new(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector2F<T> Sign(Vector2F<T> vector) =>
            new(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector2F<T> CopySign(Vector2F<T> signSource) =>
            new(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector2F<T> CopySign(Vector2F<T> value, Vector2F<T> signSource) =>
            new(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector2F<T> CopySign(T signScalar) =>
            new(T.CopySign(X, signScalar), T.CopySign(Y, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector2F<T> CopySign(Vector2F<T> value, T signScalar) =>
            new(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar));

        /// <summary>Parses a string to a <see cref="Vector2F{T}"/> instance.</summary>
        public static Vector2F<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Tries to parse a span to a <see cref="Vector2F{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2F<T> result)
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
                result = new Vector2F<T>(x, y);
                return true;
            }

            return false;
        }

        /// <summary>Tries to parse a string to a <see cref="Vector2F{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2F<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector2F{T}"/> instance.</summary>
        static Vector2F<T> ISpanParsable<Vector2F<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector2F{T}"/> instance.</summary>
        static Vector2F<T> IParsable<Vector2F<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector2F{T}"/> instance.</summary>
        static bool ISpanParsable<Vector2F<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2F<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector2F{T}"/> instance.</summary>
        static bool IParsable<Vector2F<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2F<T> result) =>
            TryParse(s, provider, out result);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
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

        /// <summary>Parses a UTF-8 span to a <see cref="Vector2F{T}"/> instance.</summary>
        public static Vector2F<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector2F{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector2F<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector2"/> to a <see cref="Vector2F{T}"/>.</summary>
        public static explicit operator Vector2F<T>(System.Numerics.Vector2 v) =>
            new((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector2F{T}"/> to <see cref="System.Numerics.Vector2"/>.</summary>
        public static explicit operator System.Numerics.Vector2(Vector2F<T> v) =>
            new(Convert.ToSingle(v.X), Convert.ToSingle(v.Y));

        // Component Operators
        public static Vector2F<T> operator +(Vector2F<T> left, Vector2F<T> right) =>
            new(left.X + right.X, left.Y + right.Y);

        public static Vector2F<T> operator -(Vector2F<T> left, Vector2F<T> right) =>
            new(left.X - right.X, left.Y - right.Y);

        public static Vector2F<T> operator *(Vector2F<T> left, Vector2F<T> right) =>
            new(left.X * right.X, left.Y * right.Y);

        public static Vector2F<T> operator /(Vector2F<T> left, Vector2F<T> right) =>
            new(left.X / right.X, left.Y / right.Y);

        public static Vector2F<T> operator %(Vector2F<T> left, Vector2F<T> right) =>
            new(left.X % right.X, left.Y % right.Y);

        // Scalar Operators
        public static Vector2F<T> operator +(Vector2F<T> vector, T scalar) =>
            new(vector.X + scalar, vector.Y + scalar);

        public static Vector2F<T> operator -(Vector2F<T> vector, T scalar) =>
            new(vector.X - scalar, vector.Y - scalar);

        public static Vector2F<T> operator *(Vector2F<T> vector, T scalar) =>
            new(vector.X * scalar, vector.Y * scalar);

        public static Vector2F<T> operator /(Vector2F<T> vector, T scalar) =>
            new(vector.X / scalar, vector.Y / scalar);

        public static Vector2F<T> operator %(Vector2F<T> vector, T scalar) =>
            new(vector.X % scalar, vector.Y % scalar);

        // + operator: returns the vector
        public static Vector2F<T> operator +(Vector2F<T> vector) => vector;

        // - operator: returns the negated vector
        public static Vector2F<T> operator -(Vector2F<T> vector) =>
            new(-vector.X, -vector.Y);

        // Equality Operators
        public static bool operator ==(Vector2F<T> left, Vector2F<T> right) =>
            left.X == right.X && left.Y == right.Y;

        public static bool operator !=(Vector2F<T> left, Vector2F<T> right) =>
            left.X != right.X || left.Y != right.Y;

        // IBinaryFloatingPointIeee754
        public static Vector2F<T> Sqrt(Vector2F<T> x) =>
            new(T.Sqrt(x.X), T.Sqrt(x.Y));

        public static Vector2F<T> Acosh(Vector2F<T> x) =>
            new(T.Acosh(x.X), T.Acosh(x.Y));

        public static Vector2F<T> Asinh(Vector2F<T> x) =>
            new(T.Asinh(x.X), T.Asinh(x.Y));

        public static Vector2F<T> Atanh(Vector2F<T> x) =>
            new(T.Atanh(x.X), T.Atanh(x.Y));

        public static Vector2F<T> Cosh(Vector2F<T> x) =>
            new(T.Cosh(x.X), T.Cosh(x.Y));

        public static Vector2F<T> Sinh(Vector2F<T> x) =>
            new(T.Sinh(x.X), T.Sinh(x.Y));

        public static Vector2F<T> Tanh(Vector2F<T> x) =>
            new(T.Tanh(x.X), T.Tanh(x.Y));

        public static Vector2F<T> Acos(Vector2F<T> x) =>
            new(T.Acos(x.X), T.Acos(x.Y));

        public static Vector2F<T> AcosPi(Vector2F<T> x) =>
            new(T.AcosPi(x.X), T.AcosPi(x.Y));

        public static Vector2F<T> Asin(Vector2F<T> x) =>
            new(T.Asin(x.X), T.Asin(x.Y));

        public static Vector2F<T> AsinPi(Vector2F<T> x) =>
            new(T.AsinPi(x.X), T.AsinPi(x.Y));

        public static Vector2F<T> Atan(Vector2F<T> x) =>
            new(T.Atan(x.X), T.Atan(x.Y));

        public static Vector2F<T> AtanPi(Vector2F<T> x) =>
            new(T.AtanPi(x.X), T.AtanPi(x.Y));

        public static Vector2F<T> Cos(Vector2F<T> x) =>
            new(T.Cos(x.X), T.Cos(x.Y));

        public static Vector2F<T> CosPi(Vector2F<T> x) =>
            new(T.CosPi(x.X), T.CosPi(x.Y));

        public static Vector2F<T> Sin(Vector2F<T> x) =>
            new(T.Sin(x.X), T.Sin(x.Y));

        public static Vector2F<T> SinPi(Vector2F<T> x) =>
            new(T.SinPi(x.X), T.SinPi(x.Y));

        public static Vector2F<T> Tan(Vector2F<T> x) =>
            new(T.Tan(x.X), T.Tan(x.Y));

        public static Vector2F<T> TanPi(Vector2F<T> x) =>
            new(T.TanPi(x.X), T.TanPi(x.Y));

        public static Vector2F<T> DegreesToRadians(Vector2F<T> degrees) =>
            new(T.DegreesToRadians(degrees.X), T.DegreesToRadians(degrees.Y));

        public static Vector2F<T> RadiansToDegrees(Vector2F<T> radians) =>
            new(T.RadiansToDegrees(radians.X), T.RadiansToDegrees(radians.Y));

        public static (Vector2F<T> Sin, Vector2F<T> Cos) SinCos(Vector2F<T> x) =>
            (new(T.Sin(x.X), T.Sin(x.Y)), new(T.Cos(x.X), T.Cos(x.Y)));

        public static (Vector2F<T> SinPi, Vector2F<T> CosPi) SinCosPi(Vector2F<T> x) =>
            (new(T.SinPi(x.X), T.SinPi(x.Y)), new(T.CosPi(x.X), T.CosPi(x.Y)));

        public static Vector2F<T> Log(Vector2F<T> x) =>
            new(T.Log(x.X), T.Log(x.Y));

        public static Vector2F<T> Log(Vector2F<T> x, Vector2F<T> newBase) =>
            new(T.Log(x.X, newBase.X), T.Log(x.Y, newBase.Y));

        public static Vector2F<T> Log(Vector2F<T> x, T newBase) =>
            new(T.Log(x.X, newBase), T.Log(x.Y, newBase));

        public static Vector2F<T> LogP1(Vector2F<T> x) =>
            new(T.LogP1(x.X), T.LogP1(x.Y));

        // TODO: Static Log2

        public static Vector2F<T> Log2P1(Vector2F<T> x) =>
            new(T.Log2P1(x.X), T.Log2P1(x.Y));

        public static Vector2F<T> Log10(Vector2F<T> x) =>
            new(T.Log10(x.X), T.Log10(x.Y));

        public static Vector2F<T> Log10P1(Vector2F<T> x) =>
            new(T.Log10P1(x.X), T.Log10P1(x.Y));

        public static Vector2F<T> Exp(Vector2F<T> x) =>
            new(T.Exp(x.X), T.Exp(x.Y));

        public static Vector2F<T> ExpM1(Vector2F<T> x) =>
            new(T.ExpM1(x.X), T.ExpM1(x.Y));

        public static Vector2F<T> Exp2(Vector2F<T> x) =>
            new(T.Exp2(x.X), T.Exp2(x.Y));

        public static Vector2F<T> Exp2M1(Vector2F<T> x) =>
            new(T.Exp2M1(x.X), T.Exp2M1(x.Y));

        public static Vector2F<T> Exp10(Vector2F<T> x) =>
            new(T.Exp10(x.X), T.Exp10(x.Y));

        public static Vector2F<T> Exp10M1(Vector2F<T> x) =>
            new(T.Exp10M1(x.X), T.Exp10M1(x.Y));

        public static Vector2F<T> Pow(Vector2F<T> x, Vector2F<T> y) =>
            new(T.Pow(x.X, y.X), T.Pow(x.Y, y.Y));

        public static Vector2F<T> Pow(Vector2F<T> x, T y) =>
            new(T.Pow(x.X, y), T.Pow(x.Y, y));

        public static Vector2F<T> Cbrt(Vector2F<T> x) =>
            new(T.Cbrt(x.X), T.Cbrt(x.Y));

        public static Vector2F<T> Hypot(Vector2F<T> x, Vector2F<T> y) =>
            new(T.Hypot(x.X, y.X), T.Hypot(x.Y, y.Y));

        public static Vector2F<T> Hypot(Vector2F<T> x, T y) =>
            new(T.Hypot(x.X, y), T.Hypot(x.Y, y));

        public static Vector2F<T> RootN(Vector2F<T> x, int n) =>
            new(T.RootN(x.X, n), T.RootN(x.Y, n));

        public static Vector2F<T> Round(Vector2F<T> x) =>
            new(T.Round(x.X), T.Round(x.Y));

        public static Vector2F<T> Round(Vector2F<T> x, int digits) =>
            new(T.Round(x.X, digits), T.Round(x.Y, digits));

        public static Vector2F<T> Round(Vector2F<T> x, MidpointRounding mode) =>
            new(T.Round(x.X, mode), T.Round(x.Y, mode));

        public static Vector2F<T> Round(Vector2F<T> x, int digits, MidpointRounding mode) =>
            new(T.Round(x.X, digits, mode), T.Round(x.Y, digits, mode));

        public static Vector2F<T> Truncate(Vector2F<T> x) =>
            new(T.Truncate(x.X), T.Truncate(x.Y));

        public static Vector2F<T> Atan2(Vector2F<T> y, Vector2F<T> x) =>
            new(T.Atan2(y.X, x.X), T.Atan2(y.Y, x.Y));

        public static Vector2F<T> Atan2Pi(Vector2F<T> y, Vector2F<T> x) =>
            new(T.Atan2Pi(y.X, x.X), T.Atan2Pi(y.Y, x.Y));

        public static Vector2F<T> Atan2(Vector2F<T> y, T x) =>
            new(T.Atan2(y.X, x), T.Atan2(y.Y, x));

        public static Vector2F<T> Atan2Pi(Vector2F<T> y, T x) =>
            new(T.Atan2Pi(y.X, x), T.Atan2Pi(y.Y, x));

        public static Vector2F<T> BitDecrement(Vector2F<T> x) =>
            new(T.BitDecrement(x.X), T.BitDecrement(x.Y));

        public static Vector2F<T> BitIncrement(Vector2F<T> x) =>
            new(T.BitIncrement(x.X), T.BitIncrement(x.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, Vector2F<T> right, Vector2F<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend.X), T.FusedMultiplyAdd(left.Y, right.Y, addend.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, Vector2F<T> right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right.X, addend), T.FusedMultiplyAdd(left.Y, right.Y, addend));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, T right, Vector2F<T> addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend.X), T.FusedMultiplyAdd(left.Y, right, addend.Y));

        public static Vector2F<T> FusedMultiplyAdd(Vector2F<T> left, T right, T addend) =>
            new(T.FusedMultiplyAdd(left.X, right, addend), T.FusedMultiplyAdd(left.Y, right, addend));

        public static Vector2F<T> ReciprocalEstimate(Vector2F<T> x) =>
            new(T.ReciprocalEstimate(x.X), T.ReciprocalEstimate(x.Y));

        public static Vector2F<T> ReciprocalSqrtEstimate(Vector2F<T> x) =>
            new(T.ReciprocalSqrtEstimate(x.X), T.ReciprocalSqrtEstimate(x.Y));

        public static Vector2I<int> ILogB(Vector2F<T> x) =>
            new(T.ILogB(x.X), T.ILogB(x.Y));

        public static Vector2F<T> ScaleB(Vector2F<T> x, Vector2I<int> n) =>
            new(T.ScaleB(x.X, n.X), T.ScaleB(x.Y, n.Y));

        public static Vector2F<T> ScaleB(Vector2F<T> x, int n) =>
            new(T.ScaleB(x.X, n), T.ScaleB(x.Y, n));
    }
}
