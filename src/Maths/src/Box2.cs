using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Box2 with a <see cref="Min"/> and <see cref="Max"/>
    /// </summary>
    public struct Box2<T>
        : IEquatable<Box2<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The min.
        /// </summary>
        public Vector2<T> Min;
        /// <summary>
        /// The max.
        /// </summary>
        public Vector2<T> Max;
        
        /// <summary>
        /// Constructs a Box2 from a min and a max
        /// </summary>
        /// <param name="min">The min of the rect.</param>
        /// <param name="max">The max of the rect.</param>
        public Box2(Vector2<T> min, Vector2<T> max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>Returns a boolean indicating whether the given Box2 is equal to this Box2 instance.</summary>
        /// <param name="other">The Box2 to compare this instance to.</param>
        /// <returns>True if the other Box2 is equal to this instance; False otherwise.</returns>
        public bool Equals(Box2<T> other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Box2 instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Box2; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Box2<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Min, Max);
        }

        /// <summary>Returns a boolean indicating whether the two given Box2s are equal.</summary>
        /// <param name="value1">The first Box2 to compare.</param>
        /// <param name="value2">The second Box2 to compare.</param>
        /// <returns>True if the Box2s are equal; False otherwise.</returns>
        public static bool operator ==(Box2<T> value1, Box2<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Box2s are not equal.</summary>
        /// <param name="value1">The first Box2 to compare.</param>
        /// <param name="value2">The second Box2 to compare.</param>
        /// <returns>True if the Box2s are not equal; False if they are equal.</returns>
        public static bool operator !=(Box2<T> value1, Box2<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
