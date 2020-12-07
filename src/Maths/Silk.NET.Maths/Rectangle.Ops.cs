// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Helper methods to work with <see cref="Rectangle{T}"/>
    /// </summary>
    public static class Rectangle
    {
        /// <summary>
        /// Constructs a rectangle from the given edge positions.
        /// </summary>
        /// <param name="left">The left edge.</param>
        /// <param name="top">The top edge.</param>
        /// <param name="right">The right edge.</param>
        /// <param name="bottom">The bottom edge.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The constructed rectangle.</returns>
        public static Rectangle<T> FromLTRB<T>(T left, T top, T right, T bottom)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Vector2<T> o = new(left, top);
            return new Rectangle<T>(o, new Vector2<T>(right, bottom) - o);
        }
    }
}
