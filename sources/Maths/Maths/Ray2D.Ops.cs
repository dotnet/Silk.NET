// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Helper methods to work with <see cref="Ray2D{T}"/>
    /// </summary>
    public static class Ray2D
    {
        /// <summary>
        /// Calculates the distance to the nearest edge from the point, assuming this struct represents a Line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToLine<T>(this Ray2D<T> line, Vector2D<T> point)
            where T : INumberBase<T>, IRootFunctions<T>
        {
            var pa = point - line.Origin;
            var ba = line.Direction;
            var h = Vector2D.Dot(pa, ba) / Vector2D.Dot(ba, ba);
            return (pa - ba * h).Length;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point, assuming this struct represents a Ray.
        /// </summary>
        /// <param name="ray">The ray.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToRay<T>(this Ray2D<T> ray, Vector2D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var pa = point - ray.Origin;
            var ba = ray.Direction;
            var h = T.Max(Vector2D.Dot(pa, ba) / Vector2D.Dot(ba, ba), T.Zero);
            return (pa - ba * h).Length;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point, assuming this struct represents a Segment.
        /// </summary>
        /// <param name="segment">The segment.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToSegment<T>(this Ray2D<T> segment, Vector2D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var pa = point - segment.Origin;
            var ba = segment.Direction;
            var h = T.Clamp(Vector2D.Dot(pa, ba) / Vector2D.Dot(ba, ba), T.Zero, T.One);
            return (pa - ba * h).Length;
        }
    }
}
