// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Extents in 3D space, defined by a minimum and maximum point, or equivalently a center and size.
    /// </summary>
    /// <typeparam name="T">The numeric type of the coordinates.</typeparam>
    public interface IExtents3D<T>
        where T : INumber<T>
    {
        /// <summary>
        /// Gets the coordinates of the minimum corner of the bounding box.
        /// </summary>
        Vector3D<T> Min { get; }

        /// <summary>
        /// Gets the coordinates of the maximum corner of the bounding box.
        /// </summary>
        Vector3D<T> Max { get; }

        /// <summary>
        /// Gets the coordinates of the center of the bounding box.
        /// </summary>
        Vector3D<T> Center { get; }

        /// <summary>
        /// Gets the size of the bounding box.
        /// </summary>
        Vector3D<T> Size { get; }

        /// <summary>
        /// Calculates whether this region contains another region.
        /// </summary>
        /// <param name="other">The region.</param>
        /// <returns><c>true</c> if this region contains the given region; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider regions that share external boundaries to be contained.</remarks>
        bool Contains<TOther>(TOther other)
            where TOther : IExtents3D<T>;
    }
}
