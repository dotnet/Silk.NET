using System;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Rectangle with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    public struct Rectangle<T>
        : IEquatable<Rectangle<T>>
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
        /// Constructs a Rectangle from an origin and an size
        /// </summary>
        /// <param name="origin">The origin of the rect.</param>
        /// <param name="size">The size of the rect.</param>
        public Rectangle(Vector2<T> origin, Vector2<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>Returns a boolean indicating whether the given Rectangle is equal to this Rectangle instance.</summary>
        /// <param name="other">The Rectangle to compare this instance to.</param>
        /// <returns>True if the other Rectangle is equal to this instance; False otherwise.</returns>
        public bool Equals(Rectangle<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Rectangle instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Rectangle; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Rectangle<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are equal.</summary>
        /// <param name="value1">The first Rectangle to compare.</param>
        /// <param name="value2">The second Rectangle to compare.</param>
        /// <returns>True if the Rectangles are equal; False otherwise.</returns>
        public static bool operator ==(Rectangle<T> value1, Rectangle<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Rectangles are not equal.</summary>
        /// <param name="value1">The first Rectangle to compare.</param>
        /// <param name="value2">The second Rectangle to compare.</param>
        /// <returns>True if the Rectangles are not equal; False if they are equal.</returns>
        public static bool operator !=(Rectangle<T> value1, Rectangle<T> value2)
        {
            return !value1.Equals(value2);
        }
    }
}
