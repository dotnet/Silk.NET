// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure encapsulating a ray consisting of an <see cref="Origin"/> and a <see cref="Direction"/>.
    /// </summary>
    /// <typeparam name="T">The type used to store numeric values.</typeparam>
    [Serializable]
    [DataContract]
    public struct Ray2D<T> :
        IEquatable<Ray2D<T>>
        where T : INumberBase<T>
    {
        /// <summary>
        /// The origin of this Ray.
        /// </summary>
        [DataMember]
        public Vector2D<T> Origin;

        /// <summary>
        /// The direction of this Ray.
        /// </summary>
        [DataMember]
        public Vector2D<T> Direction;

        /// <summary>
        /// Constructs a Ray using an origin and a direction.
        /// </summary>
        /// <param name="origin">The origin of the ray.</param>
        /// <param name="direction">The direction of the ray.</param>
        public Ray2D(Vector2D<T> origin, Vector2D<T> direction)
        {
            Origin = origin;
            Direction = direction;
        }

        /// <summary>
        /// Constructs a Ray using an origin and components of a direction.
        /// </summary>
        /// <param name="origin">The origin of the ray.</param>
        /// <param name="directionX">The X component of the direction of the ray.</param>
        /// <param name="directionY">The Y component of the direction of the ray.</param>
        public Ray2D(Vector2D<T> origin, T directionX, T directionY)
            : this(origin, new Vector2D<T>(directionX, directionY))
        {
        }

        /// <summary>
        /// Constructs a Ray using components of an origin and a direction.
        /// </summary>
        /// <param name="originX">The X component of the origin of the ray.</param>
        /// <param name="originY">The Y component of the origin of the ray.</param>
        /// <param name="direction">The direction of the ray.</param>
        public Ray2D(T originX, T originY, Vector2D<T> direction)
            : this(new Vector2D<T>(originX, originY), direction)
        {
        }

        /// <summary>
        /// Constructs a Ray using components of an origin and components of a direction.
        /// </summary>
        /// <param name="originX">The X component of the origin of the ray.</param>
        /// <param name="originY">The Y component of the origin of the ray.</param>
        /// <param name="directionX">The X component of the direction of the ray.</param>
        /// <param name="directionY">The Y component of the direction of the ray.</param>
        public Ray2D(T originX, T originY, T directionX, T directionY)
            : this(new Vector2D<T>(originX, originY), new Vector2D<T>(directionX, directionY))
        {
        }

        /// <summary>
        /// Calculates a point at a distance along the ray.
        /// </summary>
        /// <param name="distance">The distance along the ray.</param>
        /// <returns>A point at a distance along the ray.</returns>
        public readonly Vector2D<T> GetPoint(T distance) =>
            Origin + (Direction * distance);

        /// <summary>Returns a boolean indicating whether the given Ray2D is equal to this Ray2D instance.</summary>
        /// <param name="other">The Ray2D to compare this instance to.</param>
        /// <returns><c>true</c> if the other Ray2D is equal to this instance; <c>false</c> otherwise.</returns>
        public bool Equals(Ray2D<T> other) =>
            Origin.Equals(other.Origin) && Direction.Equals(other.Direction);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Ray2D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Ray2D; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Ray2D<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Origin, Direction);

        /// <summary>Returns a boolean indicating whether the two given Rays are equal.</summary>
        /// <param name="left">The first Ray to compare.</param>
        /// <param name="right">The second Ray to compare.</param>
        /// <returns><c>true</c> if the Rays are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Ray2D<T> left, Ray2D<T> right) =>
            left.Origin == right.Origin && left.Direction == right.Direction;

        /// <summary>Returns a boolean indicating whether the two given Rays are not equal.</summary>
        /// <param name="left">The first Ray to compare.</param>
        /// <param name="right">The second Ray to compare.</param>
        /// <returns><c>true</c> if the Rays are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Ray2D<T> left, Ray2D<T> right) =>
            left.Origin != right.Origin || left.Direction != right.Direction;

        /// <summary>
        /// Returns this ray casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted ray</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Ray2D<TOther> As<TOther>()
            where TOther : INumberBase<TOther>
        {
            return new(Origin.As<TOther>(), Direction.As<TOther>());
        }
    }
}
