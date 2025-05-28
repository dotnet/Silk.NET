// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 4D integer vector.</summary>
    internal struct Vector4I<T> :
        IEquatable<Vector4I<T>>,
        IReadOnlyList<T>,
        ISpanFormattable,
        ISpanParsable<Vector4I<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector4I<T>>,
        IParsable<Vector4I<T>>,
        IFormattable
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

        /// <summary>Initializes all components to the same value.</summary>
        public Vector4I(T value) => (X, Y, Z, W) = (value, value, value, value);

        /// <summary>Initializes the vector with individual values for X, Y, Z and W.</summary>
        public Vector4I(T x, T y, T z, T w) => (X, Y, Z, W) = (x, y, z, w);

        /// <summary>Initializes the vector from a span of four values.</summary>
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

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y) + (Z * Z) + (W * W);

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 4;

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z, 3 = W. </summary>
        // TODO: Make this a ref
        public T this[int index] => index switch {
            0 => X,
            1 => Y,
            2 => Z,
            3 => W,
            _ => throw new ArgumentOutOfRangeException(nameof(index), "Index must be 0, 1, 2, or 3.")
        };

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Vector4I{T}"/> instance.</summary>
        public override bool Equals(object? obj) => obj is Vector4I<T> other && Equals(other);

        /// <summary>Returns a boolean indicating whether the given Vector4I is equal to this <see cref="Vector4I{T}"/> instance.</summary>
        public bool Equals(Vector4I<T> other) => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
            yield return Z;
            yield return W;
        }

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector4I<T> other) => (X * other.X) + (Y * other.Y) + (Z * other.Z) + (W * other.W);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector4I<T> left, Vector4I<T> right) => (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 4);

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector4I<T> Max(Vector4I<T> other) =>
            new Vector4I<T>(T.Max(X, other.X), T.Max(Y, other.Y), T.Max(Z, other.Z), T.Max(W, other.W));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector4I<T> Max(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(T.Max(left.X, right.X), T.Max(left.Y, right.Y), T.Max(left.Z, right.Z), T.Max(left.W, right.W));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector4I<T> Max(T scalar) =>
            new Vector4I<T>(T.Max(X, scalar), T.Max(Y, scalar), T.Max(Z, scalar), T.Max(W, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector4I<T> Max(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(T.Max(vector.X, scalar), T.Max(vector.Y, scalar), T.Max(vector.Z, scalar), T.Max(vector.W, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector4I<T> Min(Vector4I<T> other) =>
            new Vector4I<T>(T.Min(X, other.X), T.Min(Y, other.Y), T.Min(Z, other.Z), T.Min(W, other.W));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector4I<T> Min(Vector4I<T> left, Vector4I<T> right) =>
            new Vector4I<T>(T.Min(left.X, right.X), T.Min(left.Y, right.Y), T.Min(left.Z, right.Z), T.Min(left.W, right.W));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector4I<T> Min(T scalar) =>
            new Vector4I<T>(T.Min(X, scalar), T.Min(Y, scalar), T.Min(Z, scalar), T.Min(W, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector4I<T> Min(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(T.Min(vector.X, scalar), T.Min(vector.Y, scalar), T.Min(vector.Z, scalar), T.Min(vector.W, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector4I<T> Clamp(Vector4I<T> min, Vector4I<T> max) =>
            new Vector4I<T>(
                T.Clamp(X, min.X, max.X),
                T.Clamp(Y, min.Y, max.Y),
                T.Clamp(Z, min.Z, max.Z),
                T.Clamp(W, min.W, max.W)
            );

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector4I<T> Clamp(Vector4I<T> vector, Vector4I<T> min, Vector4I<T> max) =>
            new Vector4I<T>(
                T.Clamp(vector.X, min.X, max.X),
                T.Clamp(vector.Y, min.Y, max.Y),
                T.Clamp(vector.Z, min.Z, max.Z),
                T.Clamp(vector.W, min.W, max.W)
            );

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector4I<T> Clamp(T min, T max) =>
            new Vector4I<T>(
                T.Clamp(X, min, max),
                T.Clamp(Y, min, max),
                T.Clamp(Z, min, max),
                T.Clamp(W, min, max)
            );

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector4I<T> Clamp(Vector4I<T> vector, T min, T max) =>
            new Vector4I<T>(
                T.Clamp(vector.X, min, max),
                T.Clamp(vector.Y, min, max),
                T.Clamp(vector.Z, min, max),
                T.Clamp(vector.W, min, max)
            );

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector4I<T> Abs() => new Vector4I<T>(T.Abs(X), T.Abs(Y), T.Abs(Z), T.Abs(W));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector4I<T> Abs(Vector4I<T> vector) =>
            new Vector4I<T>(T.Abs(vector.X), T.Abs(vector.Y), T.Abs(vector.Z), T.Abs(vector.W));

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}, {W.ToString(format, formatProvider)}>";

        /// <summary>Formats the vector as a string.</summary>
        public override string ToString() => $"<{X}, {Y}, {Z}, {W}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            // Format components individually into temporary buffers
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

            // Calculate total required length: < + x + ", " + y + ", " + z + ", " + w + >
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

        /// <summary>Parses a span to a Vector4I instance.</summary>
        public static Vector4I<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector4I.");

            return result;
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

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector4I<T> Sign() =>
            new Vector4I<T>(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)), T.CreateChecked(T.Sign(Z)), T.CreateChecked(T.Sign(W)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector4I<T> Sign(Vector4I<T> vector) =>
            new Vector4I<T>(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)), T.CreateChecked(T.Sign(vector.Z)), T.CreateChecked(T.Sign(vector.W)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector4I<T> CopySign(Vector4I<T> signSource) =>
            new Vector4I<T>(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y), T.CopySign(Z, signSource.Z), T.CopySign(W, signSource.W));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector4I<T> CopySign(Vector4I<T> value, Vector4I<T> signSource) =>
            new Vector4I<T>(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y), T.CopySign(value.Z, signSource.Z), T.CopySign(value.W, signSource.W));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector4I<T> CopySign(T signScalar) =>
            new Vector4I<T>(T.CopySign(X, signScalar), T.CopySign(Y, signScalar), T.CopySign(Z, signScalar), T.CopySign(W, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector4I<T> CopySign(Vector4I<T> value, T signScalar) =>
            new Vector4I<T>(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar), T.CopySign(value.Z, signScalar), T.CopySign(value.W, signScalar));

        /// <summary>Parses a string to a Vector4I instance.</summary>
        public static Vector4I<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Tries to parse a span to a Vector4I instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result)
        {
            result = default;

            s = s.Trim();
            if (s.Length < 9 || s[0] != '<' || s[^1] != '>')
                return false;

            s = s[1..^1]; // Remove < and >

            int firstComma = s.IndexOf(',');
            if (firstComma < 0)
                return false;

            ReadOnlySpan<char> remainder1 = s.Slice(firstComma + 1);
            int secondCommaRelative = remainder1.IndexOf(',');
            if (secondCommaRelative < 0)
                return false;
            int secondComma = firstComma + 1 + secondCommaRelative;

            ReadOnlySpan<char> remainder2 = s.Slice(secondComma + 1);
            int thirdCommaRelative = remainder2.IndexOf(',');
            if (thirdCommaRelative < 0)
                return false;
            int thirdComma = secondComma + 1 + thirdCommaRelative;

            ReadOnlySpan<char> xSpan = s[..firstComma].Trim();
            ReadOnlySpan<char> ySpan = s[(firstComma + 1)..secondComma].Trim();
            ReadOnlySpan<char> zSpan = s[(secondComma + 1)..thirdComma].Trim();
            ReadOnlySpan<char> wSpan = s[(thirdComma + 1)..].Trim();

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

        /// <summary>Tries to parse a string to a Vector4I instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a Vector4I instance.</summary>
        static Vector4I<T> ISpanParsable<Vector4I<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a Vector4I instance.</summary>
        static Vector4I<T> IParsable<Vector4I<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a Vector4I instance.</summary>
        static bool ISpanParsable<Vector4I<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a Vector4I instance.</summary>
        static bool IParsable<Vector4I<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            // Format components individually into temporary buffers
            Span<char> xBuffer = stackalloc char[64];
            Span<char> yBuffer = stackalloc char[64];
            Span<char> zBuffer = stackalloc char[64];
            Span<char> wBuffer = stackalloc char[64];

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider) ||
                !Z.TryFormat(zBuffer, out int zChars, format, provider) ||
                !W.TryFormat(wBuffer, out int wChars, format, provider))
            {
                bytesWritten = 0;
                return false;
            }

            // Estimate total required UTF-8 bytes
            int estimatedSize = Encoding.UTF8.GetByteCount(xBuffer[..xChars]) +
                               Encoding.UTF8.GetByteCount(yBuffer[..yChars]) +
                               Encoding.UTF8.GetByteCount(zBuffer[..zChars]) +
                               Encoding.UTF8.GetByteCount(wBuffer[..wChars]) +
                               Encoding.UTF8.GetByteCount("<, , , >");

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

        /// <summary>Parses a UTF-8 span to a Vector4I instance.</summary>
        public static Vector4I<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a Vector4I instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector4I<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        // Casts

        /// <summary>Explicitly casts a System.Numerics.Vector4 to a Vector4I.</summary>
        public static explicit operator Vector4I<T>(System.Numerics.Vector4 v) =>
            new Vector4I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)), (T)Convert.ChangeType(v.W, typeof(T)));

        /// <summary>Explicitly casts a Vector4I to System.Numerics.Vector4.</summary>
        public static explicit operator System.Numerics.Vector4(Vector4I<T> v) =>
            new System.Numerics.Vector4(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z), Convert.ToSingle(v.W));

        // Component Operators
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

        // Scalar Operators
        public static Vector4I<T> operator +(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X + scalar, vector.Y + scalar, vector.Z + scalar, vector.W + scalar);

        public static Vector4I<T> operator -(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X - scalar, vector.Y - scalar, vector.Z - scalar, vector.W - scalar);

        public static Vector4I<T> operator *(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X * scalar, vector.Y * scalar, vector.Z * scalar, vector.W * scalar);

        public static Vector4I<T> operator /(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X / scalar, vector.Y / scalar, vector.Z / scalar, vector.W / scalar);

        public static Vector4I<T> operator %(Vector4I<T> vector, T scalar) =>
            new Vector4I<T>(vector.X % scalar, vector.Y % scalar, vector.Z % scalar, vector.W % scalar);

        // + operator: returns the vector (?)
        public static Vector4I<T> operator +(Vector4I<T> vector) => vector;

        //  - operator: returns the negated vector
        public static Vector4I<T> operator -(Vector4I<T> vector) =>
            new Vector4I<T>(-vector.X, -vector.Y, -vector.Z, -vector.W);

        // Bitwise Operators
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

        // NOT operator
        public static Vector4I<T> operator ~(Vector4I<T> vector) =>
            new Vector4I<T>(~vector.X, ~vector.Y, ~vector.Z, ~vector.W);

        // Equality Operators
        public static bool operator ==(Vector4I<T> left, Vector4I<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z &&
            left.W == right.W;

        public static bool operator !=(Vector4I<T> left, Vector4I<T> right) =>
            left.X != right.X ||
            left.Y != right.Y ||
            left.Z != right.Z ||
            left.W != right.W;

        // IBinaryInteger
        public static Vector4I<T> Log2(Vector4I<T> x) =>
            new Vector4I<T>(T.Log2(x.X), T.Log2(x.Y), T.Log2(x.Z), T.Log2(x.W));

        public static (Vector4I<T> Quotient, Vector4I<T> Remainder) DivRem(Vector4I<T> left, Vector4I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            var (qW, rW) = T.DivRem(left.W, right.W);
            return (new Vector4I<T>(qX, qY, qZ, qW), new Vector4I<T>(rX, rY, rZ, rW));
        }

        public static Vector4I<T> PopCount(Vector4I<T> x) =>
            new Vector4I<T>(T.PopCount(x.X), T.PopCount(x.Y), T.PopCount(x.Z), T.PopCount(x.W));
    }
}
