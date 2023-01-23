// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents a scroll wheel.
    /// </summary>
    public struct ScrollWheel : IEquatable<ScrollWheel>
    {
        /// <summary>
        /// The X position of the scroll wheel.
        /// </summary>
        public float X { get; }

        /// <summary>
        /// The Y position of the scroll wheel.
        /// </summary>
        public float Y { get; }

        /// <summary>
        /// Creates a new instance of the scroll wheel struct.
        /// </summary>
        /// <param name="x">The X position of the scroll wheel.</param>
        /// <param name="y">The Y position of the scroll wheel.</param>
        public ScrollWheel(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>Returns a String representing this <see cref="ScrollWheel"/> instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() => ToString("G", CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this <see cref="ScrollWheel"/> instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this <see cref="ScrollWheel"/> instance, using the specified format to format individual elements and the given IFormatProvider.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <param name="formatProvider">The format provider to use when formatting elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) => obj is ScrollWheel other && Equals(other);

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ScrollWheel other) => this == other;

        /// <inheritdoc />
        public override int GetHashCode() => HashCode.Combine(X, Y);

        /// <summary>Returns a boolean indicating whether the two given ScrollWheels are equal.</summary>
        /// <param name="left">The first ScrollWheel to compare.</param>
        /// <param name="right">The second ScrollWheel to compare.</param>
        /// <returns>True if the ScrollWheel are equal; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ScrollWheel left, ScrollWheel right) =>
            left.X == right.X &&
            left.Y == right.Y;

        /// <summary>Returns a boolean indicating whether the two given ScrollWheels are not equal.</summary>
        /// <param name="left">The first ScrollWheel to compare.</param>
        /// <param name="right">The second ScrollWheel to compare.</param>
        /// <returns>True if the ScrollWheel are not equal; False if they are equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ScrollWheel left, ScrollWheel right) => !(left == right);
    }
}
