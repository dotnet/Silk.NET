using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Bounds3 with an <see cref="Min"/> and <see cref="Max"/>
    /// </summary>
    public struct Bounds3<T>
        : IEquatable<Bounds3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The min.
        /// </summary>
        public Vector3<T> Min;
        /// <summary>
        /// The max.
        /// </summary>
        public Vector3<T> Max;
        
        /// <summary>
        /// Constructs a Bounds3 from an min and an max
        /// </summary>
        /// <param name="min">The min of the rect.</param>
        /// <param name="max">The max of the rect.</param>
        public Bounds3(Vector3<T> min, Vector3<T> max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>Returns a boolean indicating whether the given Bounds3 is equal to this Bounds3 instance.</summary>
        /// <param name="other">The Bounds3 to compare this instance to.</param>
        /// <returns>True if the other Bounds3 is equal to this instance; False otherwise.</returns>
        public bool Equals(Bounds3<T> other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Bounds3 instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Bounds3; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Bounds3<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Min, Max);
        }

        /// <summary>Returns a boolean indicating whether the two given Bounds3s are equal.</summary>
        /// <param name="value1">The first Bounds3 to compare.</param>
        /// <param name="value2">The second Bounds3 to compare.</param>
        /// <returns>True if the Bounds3s are equal; False otherwise.</returns>
        public static bool operator ==(Bounds3<T> value1, Bounds3<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Bounds3s are not equal.</summary>
        /// <param name="value1">The first Bounds3 to compare.</param>
        /// <param name="value2">The second Bounds3 to compare.</param>
        /// <returns>True if the Bounds3s are not equal; False if they are equal.</returns>
        public static bool operator !=(Bounds3<T> value1, Bounds3<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
