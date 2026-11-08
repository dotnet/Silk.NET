// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Helper methods to work with <see cref="Ray3D{T}"/>
    /// </summary>
    public static class Ray3D
    {
        /// <summary>
        /// Calculates the distance to the nearest edge from the point, assuming this struct represents a Line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T GetDistanceToLine<T>(this Ray3D<T> line, Vector3D<T> point)
            where T : INumberBase<T>, IRootFunctions<T>
        {
            var pa = point - line.Origin;
            var ba = line.Direction;
            var h = Vector3D.Dot(pa, ba) / Vector3D.Dot(ba, ba);
            return (pa - ba * h).Length;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point, assuming this struct represents a Ray.
        /// </summary>
        /// <param name="ray">The ray.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T GetDistanceToRay<T>(this Ray3D<T> ray, Vector3D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var pa = point - ray.Origin;
            var ba = ray.Direction;
            var h = T.Max(Vector3D.Dot(pa, ba) / Vector3D.Dot(ba, ba), T.Zero);
            return (pa - ba * h).Length;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point, assuming this struct represents a Segment.
        /// </summary>
        /// <param name="segment">The segment.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T GetDistanceToSegment<T>(this Ray3D<T> segment, Vector3D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var pa = point - segment.Origin;
            var ba = segment.Direction;
            var h = T.Clamp(Vector3D.Dot(pa, ba) / Vector3D.Dot(ba, ba), T.Zero, T.One);
            return (pa - ba * h).Length;
        }

        /// <summary>Normalizes the Ray.</summary>
        /// <param name="value">The ray to normalize.</param>
        /// <returns>The normalized Ray.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Ray3D<T> Normalize<T>(Ray3D<T> value)
            where T : INumberBase<T>, IRootFunctions<T>
            => new(value.Origin, Vector3D.Normalize(value.Direction));
    }
}
