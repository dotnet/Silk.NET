// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a sphere using a <see cref="Center"/> and a <see cref="Radius"/>.
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Sphere<T> :
        IEquatable<Sphere<T>>
        where T : IRootFunctions<T>
    {
        /// <summary>
        /// The center.
        /// </summary>
        [DataMember]
        public Vector3D<T> Center;

        /// <summary>
        /// The radius.
        /// </summary>
        [DataMember]
        public T Radius;

        /// <summary>
        /// Constructs a sphere from a <paramref name="center"/> and a <paramref name="radius"/>
        /// </summary>
        /// <param name="center">The center.</param>
        /// <param name="radius">The radius.</param>
        public Sphere(Vector3D<T> center, T radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// Constructs a sphere from components of a center and a <paramref name="radius"/>
        /// </summary>
        /// <param name="centerX">The X component of the center.</param>
        /// <param name="centerY">The Y component of the center.</param>
        /// <param name="centerZ">The Z component of the center.</param>
        /// <param name="radius">The radius.</param>
        public Sphere(T centerX, T centerY, T centerZ, T radius)
            : this(new Vector3D<T>(centerX, centerY, centerZ), radius)
        {
        }

        /// <summary>
        /// The diameter.
        /// </summary>
        [IgnoreDataMember]
        public readonly T Diameter => Radius * T.CreateTruncating(2);

        /// <summary>
        /// The radius squared.
        /// </summary>
        [IgnoreDataMember]
        public readonly T SquaredRadius => Radius * Radius;

        /// <summary>
        /// Calculates the squared distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance squared.</returns>
        public T GetDistanceToNearestEdgeSquared(Vector3D<T> point)
        {
            return Vector3D.DistanceSquared(Center, point) - SquaredRadius;
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector3D<T> point) => T.Sqrt(GetDistanceToNearestEdgeSquared(point));

        /// <summary>
        /// Calculates a new sphere translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated sphere.</returns>
        public readonly Sphere<T> GetTranslated(Vector3D<T> distance) =>
            new(Center + distance, Radius);

        /// <summary>Returns a boolean indicating whether the given Sphere is equal to this Sphere instance.</summary>
        /// <param name="other">The Sphere to compare this instance to.</param>
        /// <returns><c>true</c> if the other Sphere is equal to this instance; <c>false</c> otherwise.</returns>
        public bool Equals(Sphere<T> other) =>
            Center.Equals(other.Center) && Radius.Equals(other.Radius);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Sphere instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Sphere; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Sphere<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Center, Radius);

        /// <summary>Returns a boolean indicating whether the two given Spheres are equal.</summary>
        /// <param name="left">The first Spheres to compare.</param>
        /// <param name="right">The second Spheres to compare.</param>
        /// <returns><c>true</c> if the Spheres are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Sphere<T> left, Sphere<T> right) =>
            left.Center == right.Center && left.Radius == right.Radius;

        /// <summary>Returns a boolean indicating whether the two given Spheres are not equal.</summary>
        /// <param name="left">The first Sphere to compare.</param>
        /// <param name="right">The second Sphere to compare.</param>
        /// <returns><c>true</c> if the Spheres are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Sphere<T> left, Sphere<T> right) =>
            left.Center != right.Center || left.Radius != right.Radius;

        /// <summary>
        /// Returns this sphere casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted sphere</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Sphere<TOther> As<TOther>()
            where TOther : IRootFunctions<TOther>
        {
            return new(Center.As<TOther>(), TOther.CreateTruncating(Radius));
        }
    }

    /// <summary>
    /// Helper methods to work with <see cref="Sphere{T}"/>
    /// </summary>
    public static class Sphere
    {
        /// <summary>
        /// Calculates whether this sphere contains a point.
        /// </summary>
        /// <param name="sphere">The sphere.</param>
        /// <param name="point">The point.</param>
        /// <returns><c>true</c> if this sphere contains the point; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public static bool Contains<T>(this Sphere<T> sphere, Vector3D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            return Vector3D.DistanceSquared(point, sphere.Center) <= sphere.Radius;
        }

        /// <summary>
        /// Calculates whether this sphere contains another sphere
        /// </summary>
        /// <param name="sphere">The sphere.</param>
        /// <param name="other">The other sphere.</param>
        /// <returns><c>true</c> if this sphere contains the given sphere; <c>false</c> otherwise.</returns>
        /// <remarks>This does consider a sphere that touches the edge contained.</remarks>
        public static bool Contains<T>(this Sphere<T> sphere, Sphere<T> other)
            where T : INumber<T>, IRootFunctions<T>
        {
            var distanceSquared = Vector3D.DistanceSquared(sphere.Center, other.Center);
            var radiusDiff = sphere.Radius - other.Radius;
            return distanceSquared <= radiusDiff * radiusDiff;
        }

        /// <summary>
        /// Calculates a sphere inflated to contain the given point.
        /// </summary>
        /// <param name="sphere">The sphere.</param>
        /// <param name="point">The point.</param>
        /// <returns>The sphere.</returns>
        public static Sphere<T> GetInflated<T>(this Sphere<T> sphere, Vector3D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            return new(sphere.Center, T.Max(sphere.Radius, Vector3D.Distance(sphere.Center, point)));
        }
    }
}
