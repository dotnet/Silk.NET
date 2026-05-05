// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Rect2D with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Rect2D<T> :
        IEquatable<Rect2D<T>>, IExtents2D<T>
        where T : INumber<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        [DataMember]
        public Vector2D<T> Origin { get; set; }

        /// <inheritdoc/>
        [DataMember]
        public Vector2D<T> Size { get; set; }

        /// <summary>
        /// Constructs a Rect2D from an origin and a size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rect2D(Vector2D<T> origin, Vector2D<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>
        /// Constructs a Rect2D from an origin and components of a size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="sizeX">The X component of the size of the rect.</param>
        /// <param name="sizeY">The Y component of the size of the rect.</param>
        public Rect2D(Vector2D<T> origin, T sizeX, T sizeY)
            : this(origin, new Vector2D<T>(sizeX, sizeY))
        {
        }

        /// <summary>
        /// Constructs a Rect2D from components of an origin and a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the rect.</param>
        /// <param name="originY">The Y component of the origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rect2D(T originX, T originY, Vector2D<T> size)
            : this(new Vector2D<T>(originX, originY), size)
        {
        }

        /// <summary>
        /// Constructs a Rect2D from components of an origin and components of a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the rect.</param>
        /// <param name="originY">The Y component of the origin of the rect.</param>
        /// <param name="sizeX">The X component of the size of the rect.</param>
        /// <param name="sizeY">The Y component of the size of the rect.</param>
        public Rect2D(T originX, T originY, T sizeX, T sizeY)
            : this(new Vector2D<T>(originX, originY), new Vector2D<T>(sizeX, sizeY))
        {
        }

        /// <inheritdoc/>
        [IgnoreDataMember]
        readonly Vector2D<T> IExtents2D<T>.Min => Origin;

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector2D<T> Max => Origin + Size;

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector2D<T> Center => Origin + Size / T.CreateTruncating(2);

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector2D<T> HalfSize => Size / T.CreateTruncating(2);

        /// <inheritdoc/>
        public readonly bool Contains<TOther>(TOther other)
            where TOther : IExtents2D<T>
        {
            var tMin = Origin;
            var tMax = Max;
            var oMin = other.Min;
            var oMax = other.Max;
            return (oMin.X >= tMin.X) && (oMin.Y >= tMin.Y)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y);
        }

        /// <summary>
        /// Calculates a new Rect2D scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated Rect2D.</returns>
        public readonly Rect2D<T> GetScaled(Vector2D<T> scale, Vector2D<T> anchor)
        {
            var min = (scale * (Origin - anchor)) + anchor;
            return new(min, scale * Size);
        }

        /// <summary>
        /// Calculates a new Rect2D translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated Rect2D.</returns>
        public readonly Rect2D<T> GetTranslated(Vector2D<T> distance) =>
            new(Origin + distance, Size);

        /// <summary>
        /// Calculates a Rect2D inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated Rect2D.</returns>
        public readonly Rect2D<T> GetInflated(Vector2D<T> point)
        {
            var min = Vector2D.Min(Origin, point);
            var max = Vector2D.Max(Origin + Size, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Rect2D is equal to this Rect2D instance.</summary>
        /// <param name="other">The Rect2D to compare this instance to.</param>
        /// <returns><c>true</c> if the other Rect2D is equal to this instance; <c>false</c> otherwise.</returns>
        public readonly bool Equals(Rect2D<T> other) =>
            Origin.Equals(other.Origin) && Size.Equals(other.Size);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rect2D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Rect2D; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Rect2D<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Origin, Size);

        /// <summary>Returns a boolean indicating whether the two given Rect2Ds are equal.</summary>
        /// <param name="left">The first Rect2D to compare.</param>
        /// <param name="right">The second Rect2D to compare.</param>
        /// <returns><c>true</c> if the Rect2Ds are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Rect2D<T> left, Rect2D<T> right) =>
            left.Origin == right.Origin && left.Size == right.Size;

        /// <summary>Returns a boolean indicating whether the two given Rect2Ds are not equal.</summary>
        /// <param name="left">The first Rect2D to compare.</param>
        /// <param name="right">The second Rect2D to compare.</param>
        /// <returns><c>true</c> if the Rect2Ds are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Rect2D<T> left, Rect2D<T> right) =>
            left.Origin != right.Origin || left.Size != right.Size;

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public readonly Rect2D<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.As<TOther>(), Size.As<TOther>());
        }

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        public readonly Rect2D<TOther> AsChecked<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.AsChecked<TOther>(), Size.AsChecked<TOther>());
        }

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        public readonly Rect2D<TOther> AsSaturating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.AsSaturating<TOther>(), Size.AsSaturating<TOther>());
        }

        /// <summary>
        /// Returns this Rect2D casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted Rect2D</returns>
        public readonly Rect2D<TOther> AsTruncating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.AsTruncating<TOther>(), Size.AsTruncating<TOther>());
        }
    }
}
