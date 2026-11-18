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
        where T : INumber<T>, IRootFunctions<T>
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
        /// Calculates whether this circle contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns><c>true</c> if this circle contains the point; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector2D<T> point) =>
            Vector2D.DistanceSquared(Center, point) <= SquaredRadius;

        /// <summary>
        /// Calculates whether this circle contains another circle
        /// </summary>
        /// <param name="other">The other circle.</param>
        /// <returns><c>true</c> if this circle contains the given circle; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider a circle that touches the edge contained.</remarks>
        public bool Contains(Circle<T> other)
        {
            if (Radius < other.Radius)
            {
                return false;
            }

            var distanceSquared = Vector2D.DistanceSquared(Center, other.Center);
            var radiusDiff = Radius - other.Radius;
            return distanceSquared <= radiusDiff * radiusDiff;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetSignedDistanceToEdge(Vector2D<T> point) =>
            Vector2D.Distance(Center, point) - Radius;

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToEdge(Vector2D<T> point) =>
            T.Abs(GetSignedDistanceToEdge(point));

        /// <summary>
        /// Calculates the distance to the interior from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToInterior(Vector2D<T> point) =>
            T.Max(GetSignedDistanceToEdge(point), T.Zero);

        /// <summary>
        /// Calculates a circle inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The circle.</returns>
        public Circle<T> GetInflated(Vector2D<T> point)
        {
            return new(Center, T.Max(Radius, Vector2D.Distance(Center, point)));
        }

        /// <summary>
        /// Calculates a new circle scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated circle.</returns>
        public readonly Circle<T> GetScaled(T scale, Vector2D<T> anchor)
        {
            var min = (scale * (Center - anchor)) + anchor;
            return new(min, scale * Radius);
        }

        /// <summary>
        /// Calculates a new circle translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated circle.</returns>
        public readonly Circle<T> GetTranslated(Vector2D<T> distance) =>
            new(Center + distance, Radius);

        /// <summary>
        /// Determines whether a points lies within the circle.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>A value indicating whether the point lies within the circle.</returns>
        public bool Intersects(Vector2D<T> point) =>
            GetSignedDistanceToEdge(point) <= T.Zero;

        /// <summary>
        /// Determines whether two circles intersect.
        /// </summary>
        /// <param name="other">The other circle.</param>
        /// <returns>A value indicating whether circles contain any intersecting points.</returns>
        public bool Intersects(Circle<T> other) =>
            Intersects(other.Center) || other.Intersects(Center);

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
        public Circle<TOther> As<TOther>()
            where TOther : INumber<TOther>, IRootFunctions<TOther>
        {
            return new(Center.As<TOther>(), TOther.CreateTruncating(Radius));
        }

        /// <summary>
        /// Returns this circle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted circle</returns>
        public readonly Circle<TOther> AsChecked<TOther>()
            where TOther : INumber<TOther>, IRootFunctions<TOther>
        {
            return new(Center.AsChecked<TOther>(), TOther.CreateChecked(Radius));
        }

        /// <summary>
        /// Returns this circle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted circle</returns>
        public readonly Circle<TOther> AsSaturating<TOther>()
            where TOther : INumber<TOther>, IRootFunctions<TOther>
        {
            return new(Center.AsSaturating<TOther>(), TOther.CreateSaturating(Radius));
        }

        /// <summary>
        /// Returns this circle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted circle</returns>
        public readonly Circle<TOther> AsTruncating<TOther>()
            where TOther : INumber<TOther>, IRootFunctions<TOther>
        {
            return new(Center.AsTruncating<TOther>(), TOther.CreateTruncating(Radius));
        }
    }
}
