// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Extensions for <see cref="IExtents3D{T}"/>.
    /// </summary>
    public static partial class Extents3D
    {
        /// <summary>
        /// Calculates whether a region contains another region.
        /// </summary>
        /// <param name="a">The containing region.</param>
        /// <param name="b">The contained region.</param>
        /// <returns><c>true</c> if the first region contains the second region; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider regions that share external boundaries to be contained.</remarks>
        public static bool Contains<T1, T2, TPoint>(T1 a, T2 b)
            where T1 : IExtents3D<TPoint>
            where T2 : IExtents3D<TPoint>
            where TPoint : INumber<TPoint>
        {
            var tMin = a.Min;
            var tMax = a.Max;
            var oMin = b.Min;
            var oMax = b.Max;
            return (oMin.X >= tMin.X) && (oMin.Y >= tMin.Y) && (oMin.Z >= tMin.Z)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y) && (oMax.Z <= tMax.Z);
        }

        /// <summary>
        /// Calculates whether two regions intersect.
        /// </summary>
        /// <param name="a">The first region.</param>
        /// <param name="b">The second region.</param>
        /// <returns><c>true</c> if the regions intersect; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider regions share boundaries to be intersected.</remarks>
        public static bool Intersects<T1, T2, TPoint>(T1 a, T2 b)
            where T1 : IExtents3D<TPoint>
            where T2 : IExtents3D<TPoint>
            where TPoint : INumber<TPoint>
        {
            var aMin = a.Min;
            var aMax = a.Max;
            var bMin = b.Min;
            var bMax = b.Max;
            return (aMin.X <= bMax.X) && (aMin.Y <= bMax.Y) && (aMin.Z <= bMax.Z) &&
                (bMin.X <= aMax.X) && (bMin.Y <= aMax.Y) && (bMin.Z <= aMax.Z);
        }

        extension<TSelf, TPoint>(TSelf region)
            where TSelf : IExtents3D<TPoint>
            where TPoint : INumber<TPoint>
        {
            /// <summary>
            /// Calculates whether this region contains a point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns><c>true</c> if this region contains the point; <c>false</c> otherwise.</returns>
            /// <remarks>This does consider a point on the boundary contained.</remarks>
            public bool Contains(Vector3D<TPoint> point)
            {
                var min = region.Min;
                var max = region.Max;
                return (point.X >= min.X) && (point.Y >= min.Y) && (point.Z >= min.Z)
                    && (point.X <= max.X) && (point.Y <= max.Y) && (point.Z <= max.Z);
            }
        }

        extension<TSelf, TPoint>(TSelf region)
            where TSelf : IExtents3D<TPoint>
            where TPoint : INumber<TPoint>, IRootFunctions<TPoint>
        {
            /// <summary>
            /// Calculates the distance to the interior of the region from the specified point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns>The distance to the interior of the region.</returns>
            public TPoint GetDistanceToInterior(Vector3D<TPoint> point)
            {
                var min = region.Min;
                var max = region.Max;
                var dx = TPoint.Max(TPoint.Max(min.X - point.X, TPoint.Zero), point.X - max.X);
                var dy = TPoint.Max(TPoint.Max(min.Y - point.Y, TPoint.Zero), point.Y - max.Y);
                var dz = TPoint.Max(TPoint.Max(min.Z - point.Z, TPoint.Zero), point.Z - max.Z);
                return TPoint.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
            }
        }
    }
}
