using System;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a sphere using a <see cref="Center"/> and a <see cref="Radius"/>.
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Sphere<T>
        : IEquatable<Sphere<T>> where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The center.
        /// </summary>
        [DataMember]
        public Vector3<T> Center;
        /// <summary>
        /// The radius.
        /// </summary>
        [DataMember]
        public T Radius;

        /// <summary>
        /// Constructs a sphere from a <paramref name="center"/> and a <paramref name="radius"/>
        /// </summary>
        /// <param name="center">The center.</param>
        /// <param name="radius">The radius.</param>
        public Sphere(Vector3<T> center, T radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>Returns a boolean indicating whether the given Sphere is equal to this Sphere instance.</summary>
        /// <param name="other">The Sphere to compare this instance to.</param>
        /// <returns>True if the other Sphere is equal to this instance; False otherwise.</returns>
        public bool Equals(Sphere<T> other)
        {
            return Center.Equals(other.Center) && Radius.Equals(other.Radius);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Sphere instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Sphere; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Sphere<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Center, Radius);
        }

        /// <summary>Returns a boolean indicating whether the two given Spheres are equal.</summary>
        /// <param name="value1">The first Spheres to compare.</param>
        /// <param name="value2">The second Spheres to compare.</param>
        /// <returns>True if the Spheres are equal; False otherwise.</returns>
        public static bool operator ==(Sphere<T> value1, Sphere<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Spheres are not equal.</summary>
        /// <param name="value1">The first Sphere to compare.</param>
        /// <param name="value2">The second Sphere to compare.</param>
        /// <returns>True if the Spheres are not equal; False if they are equal.</returns>
        public static bool operator !=(Sphere<T> value1, Sphere<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
