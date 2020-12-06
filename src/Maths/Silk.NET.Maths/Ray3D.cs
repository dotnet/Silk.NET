using System;
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
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
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
    }
}