// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a circle using a <see cref="Center"/> and a <see cref="Radius"/>.
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Circle<T> :
        IEquatable<Circle<T>>
        where T : IRootFunctions<T>
    {
        /// <summary>
        /// The center.
        /// </summary>
        [DataMember]
        public Vector2D<T> Center;

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
        public Circle(Vector2D<T> center, T radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// Constructs a circle from components of a center and a <paramref name="radius"/>
        /// </summary>
        /// <param name="centerX">The X component of the center.</param>
        /// <param name="centerY">The Y component of the center.</param>
        /// <param name="radius">The radius.</param>
        public Circle(T centerX, T centerY, T radius)
            : this(new Vector2D<T>(centerX, centerY), radius)
        {
        }

        /// <summary>
        /// The diameter.
        /// </summary>
        [IgnoreDataMember]
        public T Diameter => Radius * T.CreateTruncating(2);

        /// <summary>
        /// The radius squared.
        /// </summary>
        [IgnoreDataMember]
        public T SquaredRadius => Radius * Radius;

        /// <summary>
        /// The circumference.
        /// </summary>
        [IgnoreDataMember]
        public T Circumference => T.Tau * Radius;

        /// <summary>
        /// Calculates the squared distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance squared.</returns>
        public T GetDistanceToNearestEdgeSquared(Vector2D<T> point)
        {
            return Vector2D.DistanceSquared(Center, point) - SquaredRadius;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector2D<T> point) => T.Sqrt(GetDistanceToNearestEdgeSquared(point));

        /// <summary>
        /// Calculates a new circle translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated cube.</returns>
        public Circle<T> GetTranslated(Vector2D<T> distance)
        {
            return new(Center + distance, Radius);
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
        /// <param name="left">The first Circles to compare.</param>
        /// <param name="right">The second Circles to compare.</param>
        /// <returns>True if the Circles are equal; False otherwise.</returns>
        public static bool operator ==(Circle<T> left, Circle<T> right) =>
            left.Center == right.Center && left.Radius == right.Radius;

        /// <summary>Returns a boolean indicating whether the two given Circles are not equal.</summary>
        /// <param name="left">The first Circle to compare.</param>
        /// <param name="right">The second Circle to compare.</param>
        /// <returns>True if the Circles are not equal; False if they are equal.</returns>
        public static bool operator !=(Circle<T> left, Circle<T> right) =>
            left.Center != right.Center || left.Radius != right.Radius;

        /// <summary>
        /// Returns this circle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted circle</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Circle<TOther> As<TOther>() where TOther : IRootFunctions<TOther>
        {
            return new(Center.As<TOther>(), TOther.CreateTruncating(Radius));
        }
    }

    /// <summary>
    /// Helper methods to work with <see cref="Circle{T}"/>
    /// </summary>
    public static class Circle
    {
        /// <summary>
        /// Calculates whether this circle contains a point.
        /// </summary>
        /// <param name="circle">The circle.</param>
        /// <param name="point">The point.</param>
        /// <returns>True if this circle contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public static bool Contains<T>(this Circle<T> circle, Vector2D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            return Vector2D.DistanceSquared(point, circle.Center) <= circle.Radius;
        }

        /// <summary>
        /// Calculates whether this circle contains another circle
        /// </summary>
        /// <param name="circle">The circle.</param>
        /// <param name="other">The other circle.</param>
        /// <returns>True if this circle contains the given circle; False otherwise.</returns>
        /// <remarks>This does consider a circle that touches the edge contained.</remarks>
        public static bool Contains<T>(this Circle<T> circle, Circle<T> other)
            where T : INumber<T>, IRootFunctions<T>
        {
            var distanceSquared = Vector2D.DistanceSquared(circle.Center, other.Center);
            var radiusDiff = circle.Radius - other.Radius;
            return distanceSquared <= radiusDiff * radiusDiff;
        }

        /// <summary>
        /// Calculates a circle inflated to contain the given point.
        /// </summary>
        /// <param name="circle">The circle.</param>
        /// <param name="point">The point.</param>
        /// <returns>The circle.</returns>
        public static Circle<T> GetInflated<T>(this Circle<T> circle, Vector2D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            return new(circle.Center, T.Max(circle.Radius, Vector2D.Distance(circle.Center, point)));
        }
    }
}
