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
        public readonly T Diameter => Radius + Radius;

        /// <summary>
        /// The radius squared.
        /// </summary>
        [IgnoreDataMember]
        public readonly T SquaredRadius => Radius * Radius;

        /// <summary>
        /// The circumference.
        /// </summary>
        [IgnoreDataMember]
        public readonly T Circumference => T.Tau * Radius;

        /// <summary>
        /// Calculates the squared distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance squared.</returns>
        public readonly T GetDistanceToNearestEdgeSquared(Vector2D<T> point) =>
            Vector2D.DistanceSquared(Center, point) - SquaredRadius;

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector2D<T> point) =>
            T.Sqrt(GetDistanceToNearestEdgeSquared(point));

        /// <summary>
        /// Calculates a new circle translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated circle.</returns>
        public readonly Circle<T> GetTranslated(Vector2D<T> distance) =>
            new(Center + distance, Radius);

        /// <summary>Returns a boolean indicating whether the given Circle is equal to this Circle instance.</summary>
        /// <param name="other">The Circle to compare this instance to.</param>
        /// <returns><c>true</c> if the other Circle is equal to this instance; <c>false</c> otherwise.</returns>
        public bool Equals(Circle<T> other) =>
            Center.Equals(other.Center) && Radius.Equals(other.Radius);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Circle instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Circle; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Circle<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Center, Radius);

        /// <summary>Returns a boolean indicating whether the two given Circles are equal.</summary>
        /// <param name="left">The first Circles to compare.</param>
        /// <param name="right">The second Circles to compare.</param>
        /// <returns><c>true</c> if the Circles are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Circle<T> left, Circle<T> right) =>
            left.Center == right.Center && left.Radius == right.Radius;

        /// <summary>Returns a boolean indicating whether the two given Circles are not equal.</summary>
        /// <param name="left">The first Circle to compare.</param>
        /// <param name="right">The second Circle to compare.</param>
        /// <returns><c>true</c> if the Circles are not equal; <c>false</c> if they are equal.</returns>
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
        /// <returns><c>true</c> if this circle contains the point; <c>false</c> otherwise.</returns>
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
        /// <returns><c>true</c> if this circle contains the given circle; <c>false</c> otherwise.</returns>
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
