// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Collections;
using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>A structure representing a 2D integer vector.</summary>
    internal struct Vector2I<T> : IEquatable<Vector2I<T>>, IReadOnlyList<T>, ISpanFormattable
        where T : IBinaryInteger<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>Creates a vector whose elements have the specified values.</summary>
        /// <param name="x">The value to assign to the <see cref="X"/> field.</param>
        /// <param name="y">The value to assign to the <see cref="Y"/> field.</param>
        public Vector2I(T x, T y) => (X, Y) = (x, y);

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y. </summary>
        public T this[int index] => index switch {
            0 => X,
            1 => Y,
            _ => throw new ArgumentOutOfRangeException(nameof(index), "Index must be 0 or 1.")
        };

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 2;

        /// <summary>Returns a boolean indicating whether the given Object is equal to this <see cref="Vector2I{T}"/> instance.</summary>
        public bool Equals(Vector2I<T> other) => X.Equals(other.X) && Y.Equals(other.Y);

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
        }

        /// <summary>Formats the vector as a string using the specified format and format provider.</summary>
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";
        }

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

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
