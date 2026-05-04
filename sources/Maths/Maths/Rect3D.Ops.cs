// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Helper methods to work with <see cref="Rect3D{T}"/>
    /// </summary>
    public static class Rect3D
    {
        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="cube">The cube.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToNearestEdge<T>(Rect3D<T> cube, Vector3D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var max = cube.Max;
            var dx = T.Max(T.Max(cube.Origin.X - point.X, T.Zero), point.X - max.X);
            var dy = T.Max(T.Max(cube.Origin.Y - point.Y, T.Zero), point.Y - max.Y);
            var dz = T.Max(T.Max(cube.Origin.Z - point.Z, T.Zero), point.Z - max.Z);
            return T.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
        }
    }
}
