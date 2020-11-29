using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Cube with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    public struct Cube<T>
        : IEquatable<Cube<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        public Vector3<T> Origin;
        /// <summary>
        /// The size.
        /// </summary>
        public Vector3<T> Size;

        /// <summary>
        /// Constructs a Cube from an origin and it's size
        /// </summary>
        /// <param name="origin">The origin of the cube.</param>
        /// <param name="size">The size of the cube.</param>
        public Cube(Vector3<T> origin, Vector3<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>Returns a boolean indicating whether the given Cube is equal to this Cube instance.</summary>
        /// <param name="other">The Cube to compare this instance to.</param>
        /// <returns>True if the other Cube is equal to this instance; False otherwise.</returns>
        public bool Equals(Cube<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Cube instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Cube; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Cube<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Cubes are equal.</summary>
        /// <param name="value1">The first Cube to compare.</param>
        /// <param name="value2">The second Cube to compare.</param>
        /// <returns>True if the Cubes are equal; False otherwise.</returns>
        public static bool operator ==(Cube<T> value1, Cube<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Cubes are not equal.</summary>
        /// <param name="value1">The first Cube to compare.</param>
        /// <param name="value2">The second Cube to compare.</param>
        /// <returns>True if the Cubes are not equal; False if they are equal.</returns>
        public static bool operator !=(Cube<T> value1, Cube<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
