// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Box2D with a <see cref="Min"/> and <see cref="Max"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Box2D<T> :
        IEquatable<Box2D<T>>
        where T : INumber<T>
    {
        /// <summary>
        /// The min.
        /// </summary>
        [DataMember]
        public Vector2D<T> Min;

        /// <summary>
        /// The max.
        /// </summary>
        [DataMember]
        public Vector2D<T> Max;

        /// <summary>
        /// Constructs a Box2D from a min and a max
        /// </summary>
        /// <param name="min">The min of the box.</param>
        /// <param name="max">The max of the box.</param>
        public Box2D(Vector2D<T> min, Vector2D<T> max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Constructs a Box2D from a min and components of a max
        /// </summary>
        /// <param name="min">The min of the box.</param>
        /// <param name="maxX">The max X component of the box.</param>
        /// <param name="maxY">The max Y component of the box.</param>
        public Box2D(Vector2D<T> min, T maxX, T maxY)
            : this(min, new Vector2D<T>(maxX, maxY))
        {
        }

        /// <summary>
        /// Constructs a Box2D from components of a min and a max
        /// </summary>
        /// <param name="minX">The min X component of the box.</param>
        /// <param name="minY">The min Y component of the box.</param>
        /// <param name="max">The max of the box.</param>
        public Box2D(T minX, T minY, Vector2D<T> max)
            : this(new Vector2D<T>(minX, minY), max)
        {
        }

        /// <summary>
        /// Constructs a Box2D from components of a min and components of a max
        /// </summary>
        /// <param name="minX">The min X component of the box.</param>
        /// <param name="minY">The min Y component of the box.</param>
        /// <param name="maxX">The max X component of the box.</param>
        /// <param name="maxY">The max Y component of the box.</param>
        public Box2D(T minX, T minY, T maxX, T maxY)
            : this(new Vector2D<T>(minX, minY), new Vector2D<T>(maxX, maxY))
        {
        }

        /// <summary>
        /// The center of this box.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Center => (Min + Max) / T.CreateTruncating(2);

        /// <summary>
        /// The size of this box.
        /// When setting the box is scaled about its center.
        /// </summary>
        [IgnoreDataMember]
        public Vector2D<T> Size => Max - Min;

        /// <summary>
        /// Calculates whether this box contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this box contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector2D<T> point)
            => (point.X >= Min.X) && (point.Y >= Min.Y)
            && (point.X <= Max.X) && (point.Y <= Max.Y);

        /// <summary>
        /// Calculates whether this box contains another box
        /// </summary>
        /// <param name="other">The box.</param>
        /// <returns>True if this box contains the given box; False otherwise.</returns>
        /// <remarks>This does consider a box that touches the edge contained.</remarks>
        public bool Contains(Box2D<T> other)
            => (other.Min.X >= Min.X) && (other.Min.Y >= Min.Y)
            && (other.Max.X <= Max.X) && (other.Max.Y <= Max.Y);

        /// <summary>
        /// Calculates this box translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated box.</returns>
        public Box2D<T> GetTranslated(Vector2D<T> distance)
        {
            return new(Min + distance, Max + distance);
        }

        /// <summary>
        /// Calculates a new box scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated box.</returns>
        public Box2D<T> GetScaled(Vector2D<T> scale, Vector2D<T> anchor)
        {
            var min = (scale * (Min - anchor)) + anchor;
            var max = (scale * (Max - anchor)) + anchor;
            return new(min, max);
        }

        /// <summary>
        /// Calculates a new box scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <typeparam name="TScale">The type of the scale.</typeparam>
        /// <returns>The calculated box.</returns>
        public Box2D<T> GetScaled<TScale>(Vector2D<TScale> scale, Vector2D<T> anchor)
            where TScale : INumber<TScale>
        {
            return this.AsTruncating<TScale>().GetScaled(scale, anchor.AsTruncating<TScale>()).AsTruncating<T>();
        }

        /// <summary>
        /// Calculates a box inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated box.</returns>
        public Box2D<T> GetInflated(Vector2D<T> point)
        {
            return new(Vector2D.Min(Min, point), Vector2D.Max(Max, point));
        }

        /// <summary>Returns a boolean indicating whether the given Box2D is equal to this Box2D instance.</summary>
        /// <param name="other">The Box2D to compare this instance to.</param>
        /// <returns><c>true</c> if the other Box2D is equal to this instance; <c>false</c> otherwise.</returns>
        public bool Equals(Box2D<T> other) =>
            Min.Equals(other.Min) && Max.Equals(other.Max);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Box2D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Box2D; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Box2D<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Min, Max);

        /// <summary>Returns a boolean indicating whether the two given Box2s are equal.</summary>
        /// <param name="left">The first Box2D to compare.</param>
        /// <param name="right">The second Box2D to compare.</param>
        /// <returns><c>true</c> if the Box2s are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Box2D<T> left, Box2D<T> right) =>
            left.Min == right.Min && left.Max == right.Max;

        /// <summary>Returns a boolean indicating whether the two given Box2s are not equal.</summary>
        /// <param name="left">The first Box2D to compare.</param>
        /// <param name="right">The second Box2D to compare.</param>
        /// <returns><c>true</c> if the Box2s are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Box2D<T> left, Box2D<T> right) =>
            left.Min != right.Min || left.Max != right.Max;

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Box2D<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.As<TOther>(), Max.As<TOther>());
        }

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        public Box2D<TOther> AsChecked<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.AsChecked<TOther>(), Max.AsChecked<TOther>());
        }

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        public Box2D<TOther> AsSaturating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.AsSaturating<TOther>(), Max.AsSaturating<TOther>());
        }

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        public Box2D<TOther> AsTruncating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.AsTruncating<TOther>(), Max.AsTruncating<TOther>());
        }
    }

    /// <summary>
    /// Helper methods to work with <see cref="Box2D{T}"/>
    /// </summary>
    public static class Box2D
    {
        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="box">The box.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToNearestEdge<T>(this Box2D<T> box, Vector2D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var dx = T.Max(T.Max(box.Min.X - point.X, T.Zero), point.X - box.Max.X);
            var dy = T.Max(T.Max(box.Min.Y - point.Y, T.Zero), point.Y - box.Max.Y);
            return T.Sqrt((dx * dx) + (dy * dy));
        }
    }
}
