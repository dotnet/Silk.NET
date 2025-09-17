// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Rectangle with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Rectangle<T>
        : IEquatable<Rectangle<T>>
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
        public Rectangle(Vector2D<T> origin, Vector2D<T> size)
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
        public Rectangle(Vector2D<T> origin, T sizeX, T sizeY)
            : this(origin, new Vector2D<T>(sizeX, sizeY))
        {
        }

        /// <summary>
        /// Constructs a Rectangle from components of an origin and a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the rect.</param>
        /// <param name="originY">The Y component of the origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rectangle(T originX, T originY, Vector2D<T> size)
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
        public Rectangle(T originX, T originY, T sizeX, T sizeY)
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
        public Vector2D<T> Max => Origin + Size;

        /// <summary>
        /// Half the size of this rectangle.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> HalfSize => Size / Scalar<T>.Two;

        /// <summary>
        /// Calculates whether this rectangle contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this rectangle contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector2D<T> point)
        {
            var max = Max;
            return Scalar.GreaterThanOrEqual(point.X, Origin.X) && Scalar.GreaterThanOrEqual
                (point.Y, Origin.Y) && Scalar.LessThanOrEqual(point.X, max.X) && Scalar.LessThanOrEqual(point.Y, max.Y);
        }

        /// <summary>
        /// Calculates whether this rectangle contains another rectangle
        /// </summary>
        /// <param name="other">The rectangle.</param>
        /// <returns>True if this rectangle contains the given rectangle; False otherwise.</returns>
        /// <remarks>This does consider a rectangle that touches the edge contained.</remarks>
        public bool Contains(Rectangle<T> other)
        {
            var tMax = this.Max;
            var oMax = other.Max;
            return Scalar.GreaterThanOrEqual(other.Origin.X, this.Origin.X) && Scalar.GreaterThanOrEqual
                (other.Origin.Y, this.Origin.Y) && Scalar.LessThanOrEqual(oMax.X, tMax.X) && Scalar.LessThanOrEqual
                (oMax.Y, tMax.Y);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector2D<T> point)
        {
            var max = Max;
            var dx = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.X, point.X), Scalar<T>.Zero), Scalar.Subtract(point.X, max.X));
            var dy = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.Y, point.Y), Scalar<T>.Zero), Scalar.Subtract(point.Y, max.Y));
            return Scalar.Sqrt(Scalar.Add(Scalar.Multiply(dx, dx), Scalar.Multiply(dy, dy)));
        }

        /// <summary>
        /// Calculates a new rectangle translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rectangle<T> GetTranslated(Vector2D<T> distance)
        {
            return new(Origin + distance, Size);
        }

        /// <summary>
        /// Calculates a new rectangle scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated rectangle.</returns>
        public Rectangle<T> GetScaled(Vector2D<T> scale, Vector2D<T> anchor)
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
        public Rectangle<T> GetScaled<TScale>(Vector2D<TScale> scale, Vector2D<T> anchor)
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
        public Rectangle<T> GetInflated(Vector2D<T> point)
        {
            var min = Vector2D.Min(Origin, point);
            var max = Vector2D.Max(Max, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Rectangle is equal to this Rectangle instance.</summary>
        /// <param name="other">The Rectangle to compare this instance to.</param>
        /// <returns>True if the other Rectangle is equal to this instance; False otherwise.</returns>
        public bool Equals(Rectangle<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rectangle instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Rectangle; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Rectangle<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are equal.</summary>
        /// <param name="value1">The first Rectangle to compare.</param>
        /// <param name="value2">The second Rectangle to compare.</param>
        /// <returns>True if the Rectangles are equal; False otherwise.</returns>
        public static bool operator ==(Rectangle<T> value1, Rectangle<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are not equal.</summary>
        /// <param name="value1">The first Rectangle to compare.</param>
        /// <param name="value2">The second Rectangle to compare.</param>
        /// <returns>True if the Rectangles are not equal; False if they are equal.</returns>
        public static bool operator !=(Rectangle<T> value1, Rectangle<T> value2)
        {
            return !value1.Equals(value2);
        }

        /// <summary>
        /// Returns this rectangle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted rectangle</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Rectangle<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.As<TOther>(), Size.As<TOther>());
        }
    }
}
