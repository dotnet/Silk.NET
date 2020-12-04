using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Box2 with a <see cref="Min"/> and <see cref="Max"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Box2<T>
        : IEquatable<Box2<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>
        /// The min.
        /// </summary>
        [DataMember]
        public Vector2<T> Min;
        /// <summary>
        /// The max.
        /// </summary>
        [DataMember]
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

        /// <summary>
        /// The center of this box.
        /// </summary>
        [IgnoreDataMember]
        public Vector2<T> Center => Min + Max / Scalar<T>.Two;

        /// <summary>
        /// The size of this box.
        /// When setting the box is scaled about it's center.
        /// </summary>
        [IgnoreDataMember]
        public Vector2<T> Size => Max - Min;

        /// <summary>
        /// Calculates whether this box contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this box contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector2<T> point)
            => Scalar.GreaterThanOrEqual(point.X, Min.X) && Scalar.GreaterThanOrEqual(point.Y, Min.Y) 
            && Scalar.LessThanOrEqual(point.X, Max.X) && Scalar.LessThanOrEqual(point.Y, Max.Y);

        /// <summary>
        /// Calculates whether this box contains another box
        /// </summary>
        /// <param name="other">The box.</param>
        /// <returns>True if this box contains the given box; False otherwise.</returns>
        /// <remarks>This does consider a box that touches the edge contained.</remarks>
        public bool Contains(Box2<T> other)
            => Scalar.GreaterThanOrEqual(other.Min.X, Min.X) && Scalar.GreaterThanOrEqual(other.Min.Y, Min.Y)
            && Scalar.LessThanOrEqual(other.Max.X, Max.X) && Scalar.LessThanOrEqual(other.Max.Y, Max.Y);

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector2<T> point)
        {
            var dx = Scalar.Max(Scalar.Max(Scalar.Subtract(Min.X, point.X), Scalar<T>.Zero), Scalar.Subtract(point.X, Max.X));
            var dy = Scalar.Max(Scalar.Max(Scalar.Subtract(Min.Y, point.Y), Scalar<T>.Zero), Scalar.Subtract(point.Y, Max.Y));
            return Scalar.Sqrt(Scalar.Add(Scalar.Multiply(dx, dx), Scalar.Multiply(dy, dy)));
        }

        /// <summary>
        /// Calculates this box translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated box.</returns>
        public Box2<T> GetTranslated(Vector2<T> distance)
        {
            return new(Min + distance, Max + distance);
        }

        /// <summary>
        /// Calculates a new box scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated box.</returns>
        public Box2<T> GetScaled(Vector2<T> scale, Vector2<T> anchor)
        {
            var min = (scale * (Min - anchor)) + Min;
            var max = (scale * (Max - anchor)) + Max;
            return new(min, max);
        }

        /// <summary>
        /// Calculates a box inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated box.</returns>
        public Box2<T> GetInflated(Vector2<T> point)
        {
            return new(Vector2.Min(Min, point), Vector2.Max(Max, point));
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
