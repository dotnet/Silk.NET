// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 3D integer vector.</summary>
    internal partial struct Vector3I<T> :
        IEquatable<Vector3I<T>>,
        IReadOnlyList<T>,
        ISpanFormattable,
        ISpanParsable<Vector3I<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector3I<T>>,
        IParsable<Vector3I<T>>,
        IFormattable
        where T : IBinaryInteger<T>
    {
        /// <summary>Initializes all components to the same value.</summary>
        public Vector3I(T value) => (X, Y, Z) = (value, value, value);

        /// <summary>Initializes the vector from a span of three values.</summary>
        public Vector3I(ReadOnlySpan<T> values)
        {
            if (values.Length != 3)
                throw new ArgumentException("Input span must contain exactly 3 elements.", nameof(values));

            X = values[0];
            Y = values[1];
            Z = values[2];
        }

        /// <summary> Initializes the vector using a Vector2I for X and Y, and a separate value for Z. </summary>
        // TODO: Make sure lower dimensional constructors arent meant to zero-out the higher dimensions
        public Vector3I(Vector2I<T> xy, T z) => (X, Y, Z) = (xy.X, xy.Y, z);

        /// <summary>Gets a vector whose 3 elements are equal to one.</summary>
        public static Vector3I<T> One => new(Scalar<T>.One);

        /// <summary>Returns a vector whose 3 elements are equal to zero.</summary>
        public static Vector3I<T> Zero => default;

        /// <summary>Gets the vector (1, 0, 0).</summary>
        public static Vector3I<T> UnitX => new(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 1, 0).</summary>
        public static Vector3I<T> UnitY => new(Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero);

        /// <summary>Gets the vector (0, 0, 1).</summary>
        public static Vector3I<T> UnitZ => new(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

        /// <summary>Gets a vector with all bits set for each component.</summary>
        public static Vector3I<T> AllBitsSet => new Vector3I<T>(T.AllBitsSet, T.AllBitsSet, T.AllBitsSet);

        /// <summary>Gets the squared length of the vector (dot product with itself).</summary>
        public T LengthSquared => (X * X) + (Y * Y) + (Z * Z);

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 3;

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
            yield return Z;
        }

        /// <summary> Computes the dot product of this vector with another vector. </summary>
        public T Dot(Vector3I<T> other) => (X * other.X) + (Y * other.Y) + (Z * other.Z);

        /// <summary> Computes the dot product of two vectors. </summary>
        public static T Dot(Vector3I<T> left, Vector3I<T> right) => (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);

        /// <summary> Computes the cross product of this vector with another vector. </summary>
        public Vector3I<T> Cross(Vector3I<T> other) =>
            new Vector3I<T>(
                (Y * other.Z) - (Z * other.Y),
                (Z * other.X) - (X * other.Z),
                (X * other.Y) - (Y * other.X)
            );

        /// <summary> Computes the cross product of two vectors. </summary>
        public static Vector3I<T> Cross(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(
                (left.Y * right.Z) - (left.Z * right.Y),
                (left.Z * right.X) - (left.X * right.Z),
                (left.X * right.Y) - (left.Y * right.X)
            );

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 3);

        /// <summary>Returns a vector with the component-wise maximum of this and another vector.</summary>
        public Vector3I<T> Max(Vector3I<T> other) =>
            new Vector3I<T>(T.Max(X, other.X), T.Max(Y, other.Y), T.Max(Z, other.Z));

        /// <summary>Returns a vector with the component-wise maximum of two vectors.</summary>
        public static Vector3I<T> Max(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(T.Max(left.X, right.X), T.Max(left.Y, right.Y), T.Max(left.Z, right.Z));

        /// <summary>Returns a vector with the component-wise maximum of this vector and a scalar.</summary>
        public Vector3I<T> Max(T scalar) =>
            new Vector3I<T>(T.Max(X, scalar), T.Max(Y, scalar), T.Max(Z, scalar));

        /// <summary>Returns a vector with the component-wise maximum of a vector and a scalar.</summary>
        public static Vector3I<T> Max(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(T.Max(vector.X, scalar), T.Max(vector.Y, scalar), T.Max(vector.Z, scalar));

        /// <summary>Returns a vector with the component-wise minimum of this and another vector.</summary>
        public Vector3I<T> Min(Vector3I<T> other) =>
            new Vector3I<T>(T.Min(X, other.X), T.Min(Y, other.Y), T.Min(Z, other.Z));

        /// <summary>Returns a vector with the component-wise minimum of two vectors.</summary>
        public static Vector3I<T> Min(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(T.Min(left.X, right.X), T.Min(left.Y, right.Y), T.Min(left.Z, right.Z));

        /// <summary>Returns a vector with the component-wise minimum of this vector and a scalar.</summary>
        public Vector3I<T> Min(T scalar) =>
            new Vector3I<T>(T.Min(X, scalar), T.Min(Y, scalar), T.Min(Z, scalar));

        /// <summary>Returns a vector with the component-wise minimum of a vector and a scalar.</summary>
        public static Vector3I<T> Min(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(T.Min(vector.X, scalar), T.Min(vector.Y, scalar), T.Min(vector.Z, scalar));

        /// <summary>Clamps this vector's components between the corresponding Min and Max vectors.</summary>
        public Vector3I<T> Clamp(Vector3I<T> min, Vector3I<T> max) =>
            new Vector3I<T>(
                T.Clamp(X, min.X, max.X),
                T.Clamp(Y, min.Y, max.Y),
                T.Clamp(Z, min.Z, max.Z)
            );

        /// <summary>Clamps the components of a vector between the corresponding Min and Max vectors.</summary>
        public static Vector3I<T> Clamp(Vector3I<T> vector, Vector3I<T> min, Vector3I<T> max) =>
            new Vector3I<T>(
                T.Clamp(vector.X, min.X, max.X),
                T.Clamp(vector.Y, min.Y, max.Y),
                T.Clamp(vector.Z, min.Z, max.Z)
            );

        /// <summary>Clamps this vector's components between the Min and Max scalar values.</summary>
        public Vector3I<T> Clamp(T min, T max) =>
            new Vector3I<T>(
                T.Clamp(X, min, max),
                T.Clamp(Y, min, max),
                T.Clamp(Z, min, max)
            );

        /// <summary>Clamps the components of a vector between the Min and Max scalar values.</summary>
        public static Vector3I<T> Clamp(Vector3I<T> vector, T min, T max) =>
            new Vector3I<T>(
                T.Clamp(vector.X, min, max),
                T.Clamp(vector.Y, min, max),
                T.Clamp(vector.Z, min, max)
            );

        /// <summary>Returns a vector with the absolute value of each component of this vector.</summary>
        public Vector3I<T> Abs() => new Vector3I<T>(T.Abs(X), T.Abs(Y), T.Abs(Z));

        /// <summary>Returns a vector with the absolute value of each component of the specified vector.</summary>
        public static Vector3I<T> Abs(Vector3I<T> vector) =>
            new Vector3I<T>(T.Abs(vector.X), T.Abs(vector.Y), T.Abs(vector.Z));

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}>";

        /// <summary>Formats the vector as a string.</summary>
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            // Format components individually into temporary buffers
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

            // Calculate total required length: < + x + ", " + y + ", " + z + >
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

        /// <summary>Parses a span to a <see cref="Vector3I{T}"/> instance.</summary>
        public static Vector3I<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                throw new FormatException("Invalid format for Vector3I.");

            return result;
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

        /// <summary>Returns a vector where each component is the sign of the original vector's component.</summary>
        public Vector3I<T> Sign() =>
            new Vector3I<T>(T.CreateChecked(T.Sign(X)), T.CreateChecked(T.Sign(Y)), T.CreateChecked(T.Sign(Z)));

        /// <summary>Returns a vector where each component is the sign of the input vector's component.</summary>
        public static Vector3I<T> Sign(Vector3I<T> vector) =>
            new Vector3I<T>(T.CreateChecked(T.Sign(vector.X)), T.CreateChecked(T.Sign(vector.Y)), T.CreateChecked(T.Sign(vector.Z)));

        /// <summary>Copies the sign of each component from another vector to this vector's components.</summary>
        public Vector3I<T> CopySign(Vector3I<T> signSource) =>
            new Vector3I<T>(T.CopySign(X, signSource.X), T.CopySign(Y, signSource.Y), T.CopySign(Z, signSource.Z));

        /// <summary>Copies the sign of each component from another vector to a new vector.</summary>
        public static Vector3I<T> CopySign(Vector3I<T> value, Vector3I<T> signSource) =>
            new Vector3I<T>(T.CopySign(value.X, signSource.X), T.CopySign(value.Y, signSource.Y), T.CopySign(value.Z, signSource.Z));

        /// <summary>Copies the sign of a scalar onto each component of this vector.</summary>
        public Vector3I<T> CopySign(T signScalar) =>
            new Vector3I<T>(T.CopySign(X, signScalar), T.CopySign(Y, signScalar), T.CopySign(Z, signScalar));

        /// <summary>Copies the sign of a scalar onto each component of a new vector.</summary>
        public static Vector3I<T> CopySign(Vector3I<T> value, T signScalar) =>
            new Vector3I<T>(T.CopySign(value.X, signScalar), T.CopySign(value.Y, signScalar), T.CopySign(value.Z, signScalar));

        /// <summary>Parses a string to a <see cref="Vector3I{T}"/> instance.</summary>
        public static Vector3I<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Tries to parse a span to a <see cref="Vector3I{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3I<T> result)
        {
            result = default;

            s = s.Trim();
            if (s.Length < 7 || s[0] != '<' || s[^1] != '>')
                return false;

            s = s[1..^1]; // Remove < and >

            int firstComma = s.IndexOf(',');
            if (firstComma < 0)
                return false;

            // Kind of hacky, but it works
            // TODO: See if there's a better way
            ReadOnlySpan<char> remainder = s.Slice(firstComma + 1);
            int secondCommaRelative = remainder.IndexOf(',');
            if (secondCommaRelative < 0)
                return false;

            int secondComma = firstComma + 1 + secondCommaRelative;
            if (secondComma < 0)
                return false;

            ReadOnlySpan<char> xSpan = s[..firstComma].Trim();
            ReadOnlySpan<char> ySpan = s[(firstComma + 1)..secondComma].Trim();
            ReadOnlySpan<char> zSpan = s[(secondComma + 1)..].Trim();

            if (T.TryParse(xSpan, provider, out var x) &&
                T.TryParse(ySpan, provider, out var y) &&
                T.TryParse(zSpan, provider, out var z))
            {
                result = new Vector3I<T>(x, y, z);
                return true;
            }

            return false;
        }

        /// <summary>Tries to parse a string to a <see cref="Vector3I{T}"/> instance.</summary>
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3I<T> result) =>
            TryParse(s.AsSpan(), provider, out result);

        /// <summary>Parses a span to a <see cref="Vector3I{T}"/> instance.</summary>
        static Vector3I<T> ISpanParsable<Vector3I<T>>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Parses a string to a <see cref="Vector3I{T}"/> instance.</summary>
        static Vector3I<T> IParsable<Vector3I<T>>.Parse(string s, IFormatProvider? provider) =>
            Parse(s, provider);

        /// <summary>Tries to parse a span to a <see cref="Vector3I{T}"/> instance.</summary>
        static bool ISpanParsable<Vector3I<T>>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3I<T> result) =>
            TryParse(s, provider, out result);

        /// <summary>Tries to parse a string to a <see cref="Vector3I{T}"/> instance.</summary>
        static bool IParsable<Vector3I<T>>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3I<T> result) =>
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

            if (!X.TryFormat(xBuffer, out int xChars, format, provider) ||
                !Y.TryFormat(yBuffer, out int yChars, format, provider) ||
                !Z.TryFormat(zBuffer, out int zChars, format, provider))
            {
                bytesWritten = 0;
                return false;
            }

            // Estimate total required UTF-8 bytes
            int estimatedSize = Encoding.UTF8.GetByteCount(xBuffer[..xChars]) +
                               Encoding.UTF8.GetByteCount(yBuffer[..yChars]) +
                               Encoding.UTF8.GetByteCount(zBuffer[..zChars]) +
                               Encoding.UTF8.GetByteCount("<, , >");

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

        /// <summary>Parses a UTF-8 span to a <see cref="Vector3I{T}"/> instance.</summary>
        public static Vector3I<T> Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return Parse(charBuffer, provider);
        }

        /// <summary>Tries to parse a UTF-8 span to a <see cref="Vector3I{T}"/> instance.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, [MaybeNullWhen(false)] out Vector3I<T> result)
        {
            int charCount = Encoding.UTF8.GetCharCount(utf8Text);
            Span<char> charBuffer = charCount <= 128 ? stackalloc char[charCount] : new char[charCount];
            Encoding.UTF8.GetChars(utf8Text, charBuffer);
            return TryParse(charBuffer, provider, out result);
        }

        // Casts

        /// <summary>Explicitly casts a <see cref="System.Numerics.Vector3"/> to a <see cref="Vector3I{T}"/>.</summary>
        public static explicit operator Vector3I<T>(System.Numerics.Vector3 v) =>
            new Vector3I<T>((T)Convert.ChangeType(v.X, typeof(T)), (T)Convert.ChangeType(v.Y, typeof(T)), (T)Convert.ChangeType(v.Z, typeof(T)));

        /// <summary>Explicitly casts a <see cref="Vector3I{T}"/> to <see cref="System.Numerics.Vector3"/>.</summary>
        public static explicit operator System.Numerics.Vector3(Vector3I<T> v) =>
            new System.Numerics.Vector3(Convert.ToSingle(v.X), Convert.ToSingle(v.Y), Convert.ToSingle(v.Z));

        // Component Operators
        public static Vector3I<T> operator +(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X + right.X, left.Y + right.Y, left.Z + right.Z);

        public static Vector3I<T> operator -(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X - right.X, left.Y - right.Y, left.Z - right.Z);

        public static Vector3I<T> operator *(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X * right.X, left.Y * right.Y, left.Z * right.Z);

        public static Vector3I<T> operator /(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X / right.X, left.Y / right.Y, left.Z / right.Z);

        public static Vector3I<T> operator %(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X % right.X, left.Y % right.Y, left.Z % right.Z);

        // Scalar Operators
        public static Vector3I<T> operator +(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X + scalar, vector.Y + scalar, vector.Z + scalar);

        public static Vector3I<T> operator -(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X - scalar, vector.Y - scalar, vector.Z - scalar);

        public static Vector3I<T> operator *(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);

        public static Vector3I<T> operator /(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X / scalar, vector.Y / scalar, vector.Z / scalar);

        public static Vector3I<T> operator %(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X % scalar, vector.Y % scalar, vector.Z % scalar);

        // + operator: returns the vector (?)
        public static Vector3I<T> operator +(Vector3I<T> vector) => vector;

        //  - operator: returns the negated vector
        public static Vector3I<T> operator -(Vector3I<T> vector) =>
            new Vector3I<T>(-vector.X, -vector.Y, -vector.Z);

        // Bitwise Operators
        public static Vector3I<T> operator &(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X & right.X, left.Y & right.Y, left.Z & right.Z);

        public static Vector3I<T> operator |(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X | right.X, left.Y | right.Y, left.Z | right.Z);

        public static Vector3I<T> operator ^(Vector3I<T> left, Vector3I<T> right) =>
            new Vector3I<T>(left.X ^ right.X, left.Y ^ right.Y, left.Z ^ right.Z);

        public static Vector3I<T> operator &(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X & scalar, vector.Y & scalar, vector.Z & scalar);

        public static Vector3I<T> operator &(T scalar, Vector3I<T> vector) =>
            new Vector3I<T>(scalar & vector.X, scalar & vector.Y, scalar & vector.Z);

        public static Vector3I<T> operator |(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X | scalar, vector.Y | scalar, vector.Z | scalar);

        public static Vector3I<T> operator |(T scalar, Vector3I<T> vector) =>
            new Vector3I<T>(scalar | vector.X, scalar | vector.Y, scalar | vector.Z);

        public static Vector3I<T> operator ^(Vector3I<T> vector, T scalar) =>
            new Vector3I<T>(vector.X ^ scalar, vector.Y ^ scalar, vector.Z ^ scalar);

        public static Vector3I<T> operator ^(T scalar, Vector3I<T> vector) =>
            new Vector3I<T>(scalar ^ vector.X, scalar ^ vector.Y, scalar ^ vector.Z);

        // NOT operator
        public static Vector3I<T> operator ~(Vector3I<T> vector) =>
            new Vector3I<T>(~vector.X, ~vector.Y, ~vector.Z);

        // IBinaryInteger
        public static Vector3I<T> Log2(Vector3I<T> x) =>
            new Vector3I<T>(T.Log2(x.X), T.Log2(x.Y), T.Log2(x.Z));

        public static (Vector3I<T> Quotient, Vector3I<T> Remainder) DivRem(Vector3I<T> left, Vector3I<T> right)
        {
            var (qX, rX) = T.DivRem(left.X, right.X);
            var (qY, rY) = T.DivRem(left.Y, right.Y);
            var (qZ, rZ) = T.DivRem(left.Z, right.Z);
            return (new Vector3I<T>(qX, qY, qZ), new Vector3I<T>(rX, rY, rZ));
        }

        public static Vector3I<T> PopCount(Vector3I<T> x) =>
            new Vector3I<T>(T.PopCount(x.X), T.PopCount(x.Y), T.PopCount(x.Z));
    }
}
