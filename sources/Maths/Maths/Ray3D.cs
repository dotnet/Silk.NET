// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
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
    public struct Ray3D<T>
        : IEquatable<Ray3D<T>>
        where T : INumberBase<T>
    {
        /// <summary>
        /// The origin of this Ray.
        /// </summary>
        [DataMember]
        public Vector3D<T> Origin;

        /// <summary>
        /// The direction of this Ray.
        /// </summary>
        [DataMember]
        public Vector3D<T> Direction;

        /// <summary>
        /// Constructs a Ray using an origin and a direction.
        /// </summary>
        /// <param name="origin">The origin of the ray.</param>
        /// <param name="direction">The direction of the ray.</param>
        public Ray3D(Vector3D<T> origin, Vector3D<T> direction)
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
        /// <param name="directionZ">The Z component of the direction of the ray.</param>
        public Ray3D(Vector3D<T> origin, T directionX, T directionY, T directionZ)
            : this(origin, new Vector3D<T>(directionX, directionY, directionZ))
        {
        }

        /// <summary>
        /// Constructs a Ray using components of an origin and a direction.
        /// </summary>
        /// <param name="originX">The X component of the origin of the ray.</param>
        /// <param name="originY">The Y component of the origin of the ray.</param>
        /// <param name="originZ">The Z component of the origin of the ray.</param>
        /// <param name="direction">The direction of the ray.</param>
        public Ray3D(T originX, T originY, T originZ, Vector3D<T> direction)
            : this(new Vector3D<T>(originX, originY, originZ), direction)
        {
        }

        /// <summary>
        /// Constructs a Ray using components of an origin and components of a direction.
        /// </summary>
        /// <param name="originX">The X component of the origin of the ray.</param>
        /// <param name="originY">The Y component of the origin of the ray.</param>
        /// <param name="originZ">The Z component of the origin of the ray.</param>
        /// <param name="directionX">The X component of the direction of the ray.</param>
        /// <param name="directionY">The Y component of the direction of the ray.</param>
        /// <param name="directionZ">The Z component of the direction of the ray.</param>
        public Ray3D(T originX, T originY, T originZ, T directionX, T directionY, T directionZ)
            : this(new Vector3D<T>(originX, originY, originZ), new Vector3D<T>(directionX, directionY, directionZ))
        {
        }

        /// <summary>
        /// Calculates a point at a distance along the ray.
        /// </summary>
        /// <param name="distance">The distance along the ray.</param>
        /// <returns>A point at a distance along the ray.</returns>
        public readonly Vector3D<T> GetPoint(T distance)
        {
            return Origin + (Direction * distance);
        }

        /// <summary>Returns a boolean indicating whether the given Ray3D is equal to this Ray3D instance.</summary>
        /// <param name="other">The Ray3D to compare this instance to.</param>
        /// <returns>True if the other Ray3D is equal to this instance; False otherwise.</returns>
        public bool Equals(Ray3D<T> other)
        {
            return Origin.Equals(other.Origin) && Direction.Equals(other.Direction);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Ray3D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Ray3D; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Ray3D<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Direction);
        }

        /// <summary>Returns a boolean indicating whether the two given Rays are equal.</summary>
        /// <param name="value1">The first Ray to compare.</param>
        /// <param name="value2">The second Ray to compare.</param>
        /// <returns>True if the Rays are equal; False otherwise.</returns>
        public static bool operator ==(Ray3D<T> value1, Ray3D<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Rays are not equal.</summary>
        /// <param name="value1">The first Ray to compare.</param>
        /// <param name="value2">The second Ray to compare.</param>
        /// <returns>True if the Rays are not equal; False if they are equal.</returns>
        public static bool operator !=(Ray3D<T> value1, Ray3D<T> value2)
        {
            return !value1.Equals(value2);
        }

        /// <summary>
        /// Returns this ray casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted ray</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Ray3D<TOther> As<TOther>() where TOther : INumberBase<TOther>
        {
            return new(Origin.As<TOther>(), Direction.As<TOther>());
        }
    }
}
