// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Extensions for <see cref="IExtents2D{T}"/>.
    /// </summary>
    public static partial class Extents2D
    {
        /// <summary>
        /// Calculates whether a region contains another region.
        /// </summary>
        /// <param name="a">The containing region.</param>
        /// <param name="b">The contained region.</param>
        /// <returns><c>true</c> if the first region contains the second region; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider regions that share external boundaries to be contained.</remarks>
        public static bool Contains<T1, T2, TPoint>(T1 a, T2 b)
            where T1 : IExtents2D<TPoint>
            where T2 : IExtents2D<TPoint>
            where TPoint : INumber<TPoint>
        {
            var tMin = a.Min;
            var tMax = a.Max;
            var oMin = b.Min;
            var oMax = b.Max;
            return (oMin.X >= tMin.X) && (oMin.Y >= tMin.Y)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y);
        }

        /// <summary>
        /// Calculates whether two regions intersect.
        /// </summary>
        /// <param name="a">The first region.</param>
        /// <param name="b">The second region.</param>
        /// <returns><c>true</c> if the regions intersect; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider regions share boundaries to be intersected.</remarks>
        public static bool Intersects<T1, T2, TPoint>(T1 a, T2 b)
            where T1 : IExtents2D<TPoint>
            where T2 : IExtents2D<TPoint>
            where TPoint : INumber<TPoint>
        {
            var aMin = a.Min;
            var aMax = a.Max;
            var bMin = b.Min;
            var bMax = b.Max;
            return (aMin.X <= bMax.X) && (aMin.Y <= bMax.Y) &&
                (bMin.X <= aMax.X) && (bMin.Y <= aMax.Y);
        }

        extension<TSelf, TPoint>(TSelf region)
            where TSelf : IExtents2D<TPoint>
            where TPoint : INumber<TPoint>
        {
            /// <summary>
            /// Calculates whether this region contains a point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns><c>true</c> if this region contains the point; <c>false</c> otherwise.</returns>
            /// <remarks>This does consider a point on the boundary contained.</remarks>
            public bool Contains(Vector2D<TPoint> point)
            {
                var min = region.Min;
                var max = region.Max;
                return (point.X >= min.X) && (point.Y >= min.Y)
                    && (point.X <= max.X) && (point.Y <= max.Y);
            }
        }

        extension<TSelf, TPoint>(TSelf region)
            where TSelf : IExtents2D<TPoint>
            where TPoint : INumber<TPoint>, IRootFunctions<TPoint>
        {
            /// <summary>
            /// Calculates the signed distance to the nearest edge of the region from the specified point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns>The signed distance to the nearest edge of the region.</returns>
            public TPoint GetSignedDistanceToEdge(Vector2D<TPoint> point)
            {
                var q = Vector2D.Max(region.Min - point, point - region.Max);
                var dInner = TPoint.Max(q.X, q.Y);
                return dInner < TPoint.Zero ? dInner : Vector2D.Max(q, TPoint.Zero).Length;
            }

            /// <summary>
            /// Calculates the distance to the nearest edge from the point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns>The distance.</returns>
            public TPoint GetDistanceToEdge(Vector2D<TPoint> point) =>
                TPoint.Abs(region.GetSignedDistanceToEdge(point));

            /// <summary>
            /// Calculates the distance to the interior from the point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns>The distance.</returns>
            public TPoint GetDistanceToInterior(Vector2D<TPoint> point) =>
                TPoint.Max(region.GetSignedDistanceToEdge(point), TPoint.Zero);
        }
    }
}
