// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Rect3D with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Rect3D<T> :
        IEquatable<Rect3D<T>>, IExtents3D<T>
        where T : INumber<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        [DataMember]
        public Vector3D<T> Origin { get; set; }

        /// <inheritdoc/>
        [DataMember]
        public Vector3D<T> Size { get; set; }

        /// <summary>
        /// Constructs a Rect3D from an origin and a size
        /// </summary>
        /// <param name="origin">The origin of the Rect3D.</param>
        /// <param name="size">The size of the Rect3D.</param>
        public Rect3D(Vector3D<T> origin, Vector3D<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>
        /// Constructs a Rect3D from an origin and components of a size
        /// </summary>
        /// <param name="origin">The origin of the Rect3D.</param>
        /// <param name="sizeX">The X component of the size of the Rect3D.</param>
        /// <param name="sizeY">The Y component of the size of the Rect3D.</param>
        /// <param name="sizeZ">The Z component of the size of the Rect3D.</param>
        public Rect3D(Vector3D<T> origin, T sizeX, T sizeY, T sizeZ)
            : this(origin, new Vector3D<T>(sizeX, sizeY, sizeZ))
        {
        }

        /// <summary>
        /// Constructs a Rect3D from components of an origin and a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the Rect3D.</param>
        /// <param name="originY">The Y component of the origin of the Rect3D.</param>
        /// <param name="originZ">The Z component of the origin of the Rect3D.</param>
        /// <param name="size">The size of the Rect3D.</param>
        public Rect3D(T originX, T originY, T originZ, Vector3D<T> size)
            : this(new Vector3D<T>(originX, originY, originZ), size)
        {
        }

        /// <summary>
        /// Constructs a Rect3D from components of an origin and components of a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the Rect3D.</param>
        /// <param name="originY">The Y component of the origin of the Rect3D.</param>
        /// <param name="originZ">The Z component of the origin of the Rect3D.</param>
        /// <param name="sizeX">The X component of the size of the Rect3D.</param>
        /// <param name="sizeY">The Y component of the size of the Rect3D.</param>
        /// <param name="sizeZ">The Z component of the size of the Rect3D.</param>
        public Rect3D(T originX, T originY, T originZ, T sizeX, T sizeY, T sizeZ)
            : this(new Vector3D<T>(originX, originY, originZ), new Vector3D<T>(sizeX, sizeY, sizeZ))
        {
        }

        /// <inheritdoc/>
        [IgnoreDataMember]
        readonly Vector3D<T> IExtents3D<T>.Min => Origin;

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector3D<T> Max => Origin + Size;

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector3D<T> Center => Origin + Size / T.CreateTruncating(2);

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector3D<T> HalfSize => Size / T.CreateTruncating(2);

        /// <inheritdoc/>
        public readonly bool Contains<TOther>(TOther other)
            where TOther : IExtents3D<T>
        {
            var tMin = Origin;
            var tMax = Max;
            var oMin = other.Min;
            var oMax = other.Max;
            return (oMin.X >= tMin.X) && (oMin.Y >= tMin.Y) && (oMin.Z >= tMin.Z)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y) && (oMax.Z <= tMax.Z);
        }

        /// <summary>
        /// Calculates a new Rect3D scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated Rect3D.</returns>
        public readonly Rect3D<T> GetScaled(Vector3D<T> scale, Vector3D<T> anchor)
        {
            var min = (scale * (Origin - anchor)) + anchor;
            return new(min, scale * Size);
        }

        /// <summary>
        /// Calculates a new Rect3D translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated Rect3D.</returns>
        public readonly Rect3D<T> GetTranslated(Vector3D<T> distance) =>
            new(Origin + distance, Size);

        /// <summary>
        /// Calculates a Rect3D inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The Rect3D.</returns>
        public readonly Rect3D<T> GetInflated(Vector3D<T> point)
        {
            var min = Vector3D.Min(Origin, point);
            var max = Vector3D.Max(Origin + Size, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Rect3D is equal to this Rect3D instance.</summary>
        /// <param name="other">The Rect3D to compare this instance to.</param>
        /// <returns><c>true</c> if the other Rect3D is equal to this instance; <c>false</c> otherwise.</returns>
        public readonly bool Equals(Rect3D<T> other) =>
            Origin.Equals(other.Origin) && Size.Equals(other.Size);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rect3D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Rect3D; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Rect3D<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Origin, Size);

        /// <summary>Returns a boolean indicating whether the two given Rect3Ds are equal.</summary>
        /// <param name="left">The first Rect3D to compare.</param>
        /// <param name="right">The second Rect3D to compare.</param>
        /// <returns><c>true</c> if the Rect3Ds are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Rect3D<T> left, Rect3D<T> right) =>
            left.Origin == right.Origin && left.Size == right.Size;

        /// <summary>Returns a boolean indicating whether the two given Rect3Ds are not equal.</summary>
        /// <param name="left">The first Rect3D to compare.</param>
        /// <param name="right">The second Rect3D to compare.</param>
        /// <returns><c>true</c> if the Rect3Ds are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Rect3D<T> left, Rect3D<T> right) =>
            left.Origin != right.Origin || left.Size != right.Size;

        /// <summary>
        /// Returns this circle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect3D</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public readonly Rect3D<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.As<TOther>(), Size.As<TOther>());
        }

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        public readonly Rect3D<TOther> AsChecked<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.AsChecked<TOther>(), Size.AsChecked<TOther>());
        }

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        public readonly Rect3D<TOther> AsSaturating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.AsSaturating<TOther>(), Size.AsSaturating<TOther>());
        }

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        public readonly Rect3D<TOther> AsTruncating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.AsTruncating<TOther>(), Size.AsTruncating<TOther>());
        }
    }
}
