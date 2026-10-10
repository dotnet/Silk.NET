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

    /// <summary>A structure encapsulating a 4D vector.</summary>
    public partial struct Vector4D<T> :
        IEquatable<Vector4D<T>>,
        IReadOnlyList<T>,
        IFormattable,
        IParsable<Vector4D<T>>,
        ISpanFormattable,
        ISpanParsable<Vector4D<T>>,
        IUtf8SpanFormattable,
        IUtf8SpanParsable<Vector4D<T>>
        where T : INumberBase<T>, IUtf8SpanFormattable
    {
        /// <summary>Gets a vector whose 4 elements are equal to one.</summary>
        public static Vector4D<T> One
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.One);
        }

        /// <summary>Returns a vector whose 4 elements are equal to zero.</summary>
        public static Vector4D<T> Zero
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero);
        }

        /// <summary>Gets the vector (1, 0, 0, 0).</summary>
        public static Vector4D<T> UnitX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.One, T.Zero, T.Zero, T.Zero);
        }

        /// <summary>Gets the vector (0, 1, 0, 0).</summary>
        public static Vector4D<T> UnitY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero, T.One, T.Zero, T.Zero);
        }

        /// <summary>Gets the vector (0, 0, 1, 0).</summary>
        public static Vector4D<T> UnitZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero, T.Zero, T.One, T.Zero);
        }

        /// <summary>Gets the vector (0, 0, 0, 1).</summary>
        public static Vector4D<T> UnitW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new(T.Zero, T.Zero, T.Zero, T.One);
        }

        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>The W component of the vector.</summary>
        public T W;

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 4;

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

                ThrowHelpers.ArgumentOutOfRangeException_index();
                return ref X; // Unreachable, but required to satisfy the compiler.
            }
        }

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
                ThrowHelpers.ArgumentException_InputSpanTooSmall_4();

            X = values[0];
            Y = values[1];
            Z = values[2];
            W = values[3];
        }

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
                ThrowHelpers.ArgumentNullException_array();
            if (startIndex < 0 || startIndex + 4 > array.Length)
                ThrowHelpers.ArgumentOutOfRangeException_startIndex();

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
                ThrowHelpers.ArgumentOutOfRangeException_startIndex();

            span[startIndex] = X;
            span[startIndex + 1] = Y;
            span[startIndex + 2] = Z;
            span[startIndex + 3] = W;
        }

        /// <summary>Returns a span over the vector components.</summary>
        public Span<T> AsSpan() => MemoryMarshal.CreateSpan(ref X, 4);

        /// <summary>Formats the vector as a string.</summary>
        /// <returns>The string representation.</returns>
        public override string ToString() =>
            $"<{X}, {Y}, {Z}, {W}>";

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        /// <returns>The string representation.</returns>
        public string ToString(string? format, IFormatProvider? formatProvider = null) =>
            $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}, {W.ToString(format, formatProvider)}>";

        /// <summary>Parses a string to a <see cref="Vector4D{T}"/> instance.</summary>
        public static Vector4D<T> Parse(string s, IFormatProvider? provider) => Parse(s.AsSpan(), provider);

        /// <summary>Parses a span to a <see cref="Vector4D{T}"/> instance.</summary>
        public static Vector4D<T> Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            if (!TryParse(s, provider, out var result))
                ThrowHelpers.FormatException_InvalidFormatVector4D();

            return result;
        }

        /// <summary>Formats the vector as a UTF-8 string using the specified format and format provider.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            ValueUtf8StringBuilder vsb = new ValueUtf8StringBuilder(provider, utf8Destination);
            if (!vsb.AppendLiteral("<"u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendFormatted(X, format))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendFormatted(Y, format))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendFormatted(Z, format))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendFormatted(W, format))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            if (!vsb.AppendLiteral(">"u8))
            {
                bytesWritten = vsb.BytesWritten;
                return false;
            }
            bytesWritten = vsb.BytesWritten;
            return true;
        }

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            ValueStringBuilder vsb = new ValueStringBuilder(provider, destination);
            if (!vsb.AppendLiteral("<"))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendFormatted(X, format))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendFormatted(Y, format))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendFormatted(Z, format))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendLiteral(", "))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendFormatted(W, format))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            if (!vsb.AppendLiteral(">"))
            {
                charsWritten = vsb.CharsWritten;
                return false;
            }
            charsWritten = vsb.CharsWritten;
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

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector4D<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector4D<T> other) =>
            X.Equals(other.X) &&
            Y.Equals(other.Y) &&
            Z.Equals(other.Z) &&
            W.Equals(other.W);

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
        public static bool operator !=(Vector4D<T> left, Vector4D<T> right) =>
            left.X != right.X ||
            left.Y != right.Y ||
            left.Z != right.Z ||
            left.W != right.W;

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
        public static implicit operator Vector4D<T>((T X, T Y, T Z, T W) value) =>
            new(value.X, value.Y, value.Z, value.W);

        /// <summary>Implicitly casts a <see cref="Vector4D{T}"/> to a <see cref="ValueTuple{T, T, T, T}"/>.</summary>
        public static implicit operator (T X, T Y, T Z, T W)(Vector4D<T> value) =>
            (value.X, value.Y, value.Z, value.W);

        /// <summary>Explicitly casts a <see cref="Vector4D{T}"/> to a <see cref="Vector2D{T}"/> .</summary>
        public static explicit operator Vector2D<T>(Vector4D<T> value) =>
            new(value.X, value.Y);

        /// <summary>Explicitly casts a <see cref="Vector2D{T}"/> to a <see cref="Vector4D{T}"/>.</summary>
        public static explicit operator Vector4D<T>(Vector2D<T> value) =>
            new(value.X, value.Y, T.Zero, T.Zero);

        /// <summary>Explicitly casts a <see cref="Vector4D{T}"/> to a <see cref="Vector3D{T}"/> .</summary>
        public static explicit operator Vector3D<T>(Vector4D<T> value) =>
            new(value.X, value.Y, value.Z);

        /// <summary>Explicitly casts a <see cref="Vector3D{T}"/> to a <see cref="Vector4D{T}"/>.</summary>
        public static explicit operator Vector4D<T>(Vector3D<T> value) =>
            new(value.X, value.Y, value.Z, T.Zero);

        /// <summary>Returns the given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The source vector.</returns>
        public static Vector4D<T> operator +(Vector4D<T> vector) =>
            vector;

        /// <summary>Negates a given vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector4D<T> operator -(Vector4D<T> vector)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(-Unsafe.BitCast<Vector4D<T>, Vector4>(vector));
            return new(-vector.X, -vector.Y, -vector.Z, -vector.W);
        }

        /// <summary>Adds two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The summed vector.</returns>
        public static Vector4D<T> operator +(Vector4D<T> left, Vector4D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(left) + Unsafe.BitCast<Vector4D<T>, Vector4>(right));
            return new(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        /// <summary>Subtracts the second vector from the first.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The difference vector.</returns>
        public static Vector4D<T> operator -(Vector4D<T> left, Vector4D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(left) - Unsafe.BitCast<Vector4D<T>, Vector4>(right));
            return new(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        /// <summary>Multiplies two vectors together.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The product vector.</returns>
        public static Vector4D<T> operator *(Vector4D<T> left, Vector4D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(left) * Unsafe.BitCast<Vector4D<T>, Vector4>(right));
            return new(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
        }

        /// <summary>Divides the first vector by the second.</summary>
        /// <param name="left">The first source vector.</param>
        /// <param name="right">The second source vector.</param>
        /// <returns>The vector resulting from the division.</returns>
        public static Vector4D<T> operator /(Vector4D<T> left, Vector4D<T> right)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(left) / Unsafe.BitCast<Vector4D<T>, Vector4>(right));
            return new(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
        }

        /// <summary>Adds a scalar to the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector4D<T> operator +(Vector4D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(vector) + new Vector4(Unsafe.BitCast<T, float>(scalar)));
            return new(vector.X + scalar, vector.Y + scalar, vector.Z + scalar, vector.W + scalar);
        }

        /// <summary>Subtracts a scalar from the components of a vector.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The offset vector.</returns>
        public static Vector4D<T> operator -(Vector4D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(vector) - new Vector4(Unsafe.BitCast<T, float>(scalar)));
            return new(vector.X - scalar, vector.Y - scalar, vector.Z - scalar, vector.W - scalar);
        }

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> operator *(Vector4D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(vector) * Unsafe.BitCast<T, float>(scalar));
            return new(vector.X * scalar, vector.Y * scalar, vector.Z * scalar, vector.W * scalar);
        }

        /// <summary>Multiplies a vector by the given scalar.</summary>
        /// <param name="scalar">The scalar value.</param>
        /// <param name="vector">The source vector.</param>
        /// <returns>The scaled vector.</returns>
        public static Vector4D<T> operator *(T scalar, Vector4D<T> vector)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<T, float>(scalar) * Unsafe.BitCast<Vector4D<T>, Vector4>(vector));
            return new(scalar * vector.X, scalar * vector.Y, scalar * vector.Z, scalar * vector.W);
        }

        /// <summary>Divides the vector by the given scalar.</summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The result of the division.</returns>
        public static Vector4D<T> operator /(Vector4D<T> vector, T scalar)
        {
            if (typeof(T) == typeof(float))
                return Unsafe.BitCast<Vector4, Vector4D<T>>(Unsafe.BitCast<Vector4D<T>, Vector4>(vector) / Unsafe.BitCast<T, float>(scalar));
            return new(vector.X / scalar, vector.Y / scalar, vector.Z / scalar, vector.W / scalar);
        }

        /// <summary>Converts a <see cref="Vector4"/> to a <see cref="Vector4D{T}"/>.</summary>
        public static explicit operator Vector4D<T>(Vector4 from) =>
            new(T.CreateTruncating(from.X), T.CreateTruncating(from.Y), T.CreateTruncating(from.Z), T.CreateTruncating(from.W));

        /// <summary>Converts a <see cref="Vector4"/> to a <see cref="Vector4D{T}"/>.</summary>
        public static explicit operator checked Vector4D<T>(Vector4 from) =>
            new(T.CreateChecked(from.X), T.CreateChecked(from.Y), T.CreateChecked(from.Z), T.CreateChecked(from.W));

        /// <summary>Converts a <see cref="Vector4D{T}"/> to <see cref="Vector4"/>.</summary>
        public static explicit operator Vector4(Vector4D<T> from) =>
            new(float.CreateTruncating(from.X), float.CreateTruncating(from.Y), float.CreateTruncating(from.Z), float.CreateTruncating(from.W));

        /// <summary>Converts a <see cref="Vector4D{T}"/> to <see cref="Vector4"/>.</summary>
        public static explicit operator checked Vector4(Vector4D<T> from) =>
            new(float.CreateChecked(from.X), float.CreateChecked(from.Y), float.CreateChecked(from.Z), float.CreateChecked(from.W));

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
}
