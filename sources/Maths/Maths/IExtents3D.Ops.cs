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
        extension<TSelf, TPoint>(TSelf region)
            where TSelf : IExtents3D<TPoint>
            where TPoint : INumber<TPoint>
        {
            /// <summary>
            /// Calculates whether this region contains a point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns><c>true</c> if this region contains the point; <c>false</c> otherwise.</returns>
            /// <remarks>This does consider a point on the edge contained.</remarks>
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
