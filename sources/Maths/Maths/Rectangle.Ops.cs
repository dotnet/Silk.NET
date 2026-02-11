// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

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
            where T : INumber<T>
        {
            Vector2D<T> o = new(left, top);
            return new Rectangle<T>(o, new Vector2D<T>(right, bottom) - o);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="rectangle">The rectangle.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToNearestEdge<T>(this Rectangle<T> rectangle, Vector2D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var max = rectangle.Max;
            var dx = T.Max(T.Max(rectangle.Origin.X - point.X, T.Zero), point.X - max.X);
            var dy = T.Max(T.Max(rectangle.Origin.Y - point.Y, T.Zero), point.Y - max.Y);
            return T.Sqrt((dx * dx) + (dy * dy));
        }
    }
}
