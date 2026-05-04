// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Rectangle with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Rect2D<T> :
        IEquatable<Rect2D<T>>
        where T : INumber<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        [DataMember]
        public Vector2D<T> Origin;

        /// <summary>
        /// The size.
        /// </summary>
        [DataMember]
        public Vector2D<T> Size;

        /// <summary>
        /// Constructs a Rectangle from an origin and a size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rect2D(Vector2D<T> origin, Vector2D<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>
        /// Constructs a Rectangle from an origin and components of a size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="sizeX">The X component of the size of the rect.</param>
        /// <param name="sizeY">The Y component of the size of the rect.</param>
        public Rect2D(Vector2D<T> origin, T sizeX, T sizeY)
            : this(origin, new Vector2D<T>(sizeX, sizeY))
        {
        }

        /// <summary>
        /// Constructs a Rectangle from components of an origin and a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the rect.</param>
        /// <param name="originY">The Y component of the origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rect2D(T originX, T originY, Vector2D<T> size)
            : this(new Vector2D<T>(originX, originY), size)
        {
        }

        /// <summary>
        /// Constructs a Rectangle from components of an origin and components of a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the rect.</param>
        /// <param name="originY">The Y component of the origin of the rect.</param>
        /// <param name="sizeX">The X component of the size of the rect.</param>
        /// <param name="sizeY">The Y component of the size of the rect.</param>
        public Rect2D(T originX, T originY, T sizeX, T sizeY)
            : this(new Vector2D<T>(originX, originY), new Vector2D<T>(sizeX, sizeY))
        {
        }

        /// <summary>
        /// The center of this rectangle.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Center => Origin + HalfSize;

        /// <summary>
        /// The Maximum point of this Rectangle.
        /// </summary>
        [IgnoreDataMember]
        public readonly Vector2D<T> Max => Origin + Size;

        /// <summary>
        /// Half the size of this rectangle.
        /// </summary>
        [IgnoreDataMember]
        public readonly Vector2D<T> HalfSize => Size / T.CreateTruncating(2);

        /// <summary>
        /// Calculates whether this rectangle contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns><c>true</c> if this rectangle contains the point; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector2D<T> point)
        {
            var max = Max;
            return (point.X >= Origin.X) && (point.Y >= Origin.Y)
                && (point.X <= max.X) && (point.Y <= max.Y);
        }

        /// <summary>
        /// Calculates whether this rectangle contains another rectangle
        /// </summary>
        /// <param name="other">The rectangle.</param>
        /// <returns><c>true</c> if this rectangle contains the given rectangle; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider a rectangle that touches the edge contained.</remarks>
        public bool Contains(Rect2D<T> other)
        {
            var tMax = this.Max;
            var oMax = other.Max;
            return (other.Origin.X >= this.Origin.X) && (other.Origin.Y >= this.Origin.Y)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y);
        }

        /// <summary>
        /// Calculates a new rectangle translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated rectangle.</returns>
        public readonly Rect2D<T> GetTranslated(Vector2D<T> distance) =>
            new(Origin + distance, Size);

        /// <summary>
        /// Calculates a new rectangle scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rect2D<T> GetScaled(Vector2D<T> scale, Vector2D<T> anchor)
        {
            var min = (scale * (Origin - anchor)) + anchor;
            var max = (scale * (Max - anchor)) + anchor;
            return new(min, max - min);
        }

        /// <summary>
        /// Calculates a new rectangle scaled by the given scale around the given anchor.
        /// </summary>
        /// <typeparam name="TScale">The type of the scale.</typeparam>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rect2D<T> GetScaled<TScale>(Vector2D<TScale> scale, Vector2D<T> anchor)
            where TScale : INumberBase<TScale>
        {
            var convertedAnchor = anchor.AsTruncating<TScale>();
            var min = (scale * (Origin.AsTruncating<TScale>() - convertedAnchor)) + convertedAnchor;
            var max = (scale * (Max.AsTruncating<TScale>() - convertedAnchor)) + convertedAnchor;
            return new(min.AsTruncating<T>(), (max - min).AsTruncating<T>());
        }

        /// <summary>
        /// Calculates a rectangle inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rect2D<T> GetInflated(Vector2D<T> point)
        {
            var min = Vector2D.Min(Origin, point);
            var max = Vector2D.Max(Max, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Rectangle is equal to this Rectangle instance.</summary>
        /// <param name="other">The Rectangle to compare this instance to.</param>
        /// <returns><c>true</c> if the other Rectangle is equal to this instance; <c>false</c> otherwise.</returns>
        public bool Equals(Rect2D<T> other) =>
            Origin.Equals(other.Origin) && Size.Equals(other.Size);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rectangle instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Rectangle; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Rect2D<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Origin, Size);

        /// <summary>Returns a boolean indicating whether the two given Rectangles are equal.</summary>
        /// <param name="left">The first Rectangle to compare.</param>
        /// <param name="right">The second Rectangle to compare.</param>
        /// <returns><c>true</c> if the Rectangles are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Rect2D<T> left, Rect2D<T> right) =>
            left.Origin == right.Origin && left.Size == right.Size;

        /// <summary>Returns a boolean indicating whether the two given Rectangles are not equal.</summary>
        /// <param name="left">The first Rectangle to compare.</param>
        /// <param name="right">The second Rectangle to compare.</param>
        /// <returns><c>true</c> if the Rectangles are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Rect2D<T> left, Rect2D<T> right) =>
            left.Origin != right.Origin || left.Size != right.Size;

        /// <summary>
        /// Returns this rectangle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted rectangle</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Rect2D<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.As<TOther>(), Size.As<TOther>());
        }
    }
}
