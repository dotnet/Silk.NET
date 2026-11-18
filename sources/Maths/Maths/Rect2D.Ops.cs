// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Helper methods to work with <see cref="Rect2D{T}"/>
    /// </summary>
    public static class Rect2D
    {
        /// <summary>
        /// Constructs a Rect2D from the given edge positions.
        /// </summary>
        /// <param name="left">The left edge.</param>
        /// <param name="top">The top edge.</param>
        /// <param name="right">The right edge.</param>
        /// <param name="bottom">The bottom edge.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>The constructed Rect2D.</returns>
        public static Rect2D<T> FromLTRB<T>(T left, T top, T right, T bottom)
            where T : INumber<T>
        {
            Vector2D<T> o = new(left, top);
            return new Rect2D<T>(o, new Vector2D<T>(right, bottom) - o);
        }
    }
}
