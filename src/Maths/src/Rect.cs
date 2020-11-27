using System;

namespace Silk.NET.Numerics
{
    /// <summary>
    /// A structure representing a Rectangle with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    public struct Rect<T>
        : IEquatable<Rect<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        public Vector2<T> Origin;
        /// <summary>
        /// The size.
        /// </summary>
        public Vector2<T> Size;
        
        /// <summary>
        /// Constructs a Rect from an origin and an size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rect(Vector2<T> origin, Vector2<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>Returns a boolean indicating whether the given Rect is equal to this Rect instance.</summary>
        /// <param name="other">The Rect to compare this instance to.</param>
        /// <returns>True if the other Rect is equal to this instance; False otherwise.</returns>
        public bool Equals(Rect<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rect instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Rect; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Rect<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are equal.</summary>
        /// <param name="value1">The first Rect to compare.</param>
        /// <param name="value2">The second Rect to compare.</param>
        /// <returns>True if the Rectangles are equal; False otherwise.</returns>
        public static bool operator ==(Rect<T> value1, Rect<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are not equal.</summary>
        /// <param name="value1">The first Rect to compare.</param>
        /// <param name="value2">The second Rect to compare.</param>
        /// <returns>True if the Rectangles are not equal; False if they are equal.</returns>
        public static bool operator !=(Rect<T> value1, Rect<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
