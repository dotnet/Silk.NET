using System;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a circle using a <see cref="Center"/> and a <see cref="Radius"/>.
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Circle<T>
        : IEquatable<Circle<T>> where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The center.
        /// </summary>
        [DataMember]
        public Vector2<T> Center;
        /// <summary>
        /// The radius.
        /// </summary>
        [DataMember]
        public T Radius;

        /// <summary>
        /// Constructs a circle from a <paramref name="center"/> and a <paramref name="radius"/>
        /// </summary>
        /// <param name="center">The center.</param>
        /// <param name="radius">The radius.</param>
        public Circle(Vector2<T> center, T radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>Returns a boolean indicating whether the given Circle is equal to this Circle instance.</summary>
        /// <param name="other">The Circle to compare this instance to.</param>
        /// <returns>True if the other Circle is equal to this instance; False otherwise.</returns>
        public bool Equals(Circle<T> other)
        {
            return Center.Equals(other.Center) && Radius.Equals(other.Radius);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Circle instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Circle; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Circle<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Center, Radius);
        }

        /// <summary>Returns a boolean indicating whether the two given Circles are equal.</summary>
        /// <param name="value1">The first Circles to compare.</param>
        /// <param name="value2">The second Circles to compare.</param>
        /// <returns>True if the Circles are equal; False otherwise.</returns>
        public static bool operator ==(Circle<T> value1, Circle<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Circles are not equal.</summary>
        /// <param name="value1">The first Circle to compare.</param>
        /// <param name="value2">The second Circle to compare.</param>
        /// <returns>True if the Circles are not equal; False if they are equal.</returns>
        public static bool operator !=(Circle<T> value1, Circle<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
