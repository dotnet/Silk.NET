// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a sphere using a <see cref="Center"/> and a <see cref="Radius"/>.
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Sphere<T>
        : IEquatable<Sphere<T>>
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
        public T Diameter => Scalar.Multiply(Radius, Scalar<T>.Two);

        /// <summary>
        /// The radius squared.
        /// </summary>
        [IgnoreDataMember]
        public T SquaredRadius => Scalar.Multiply(Radius, Radius);


        /// <summary>
        /// Calculates whether this sphere contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this sphere contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector3D<T> point)
        {
            return Scalar.LessThanOrEqual(Vector3D.DistanceSquared(point, Center), Radius);
        }

        /// <summary>
        /// Calculates whether this sphere contains another sphere
        /// </summary>
        /// <param name="other">The sphere.</param>
        /// <returns>True if this sphere contains the given sphere; False otherwise.</returns>
        /// <remarks>This does consider a sphere that touches the edge contained.</remarks>
        public bool Contains(Sphere<T> other)
        {
            var distanceSquared = Vector3D.DistanceSquared(Center, other.Center);
            var radiusDiff = Scalar.Subtract(Radius, other.Radius);
            return Scalar.LessThanOrEqual(distanceSquared, Scalar.Multiply(radiusDiff, radiusDiff));
        }

        /// <summary>
        /// Calculates the squared distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance squared.</returns>
        public T GetDistanceToNearestEdgeSquared(Vector3D<T> point)
        {
            return Scalar.Subtract(Vector3D.DistanceSquared(Center, point), SquaredRadius);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector3D<T> point) => Scalar.Sqrt(GetDistanceToNearestEdgeSquared(point));

        /// <summary>
        /// Calculates a new sphere translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated sphere.</returns>
        public Sphere<T> GetTranslated(Vector3D<T> distance)
        {
            return new(Center + distance, Radius);
        }

        /// <summary>
        /// Calculates a sphere inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The sphere.</returns>
        public Sphere<T> GetInflated(Vector3D<T> point)
        {
            return new(Center, Scalar.Max(Radius, Vector3D.Distance(Center, point)));
        }

        /// <summary>Returns a boolean indicating whether the given Sphere is equal to this Sphere instance.</summary>
        /// <param name="other">The Sphere to compare this instance to.</param>
        /// <returns>True if the other Sphere is equal to this instance; False otherwise.</returns>
        public bool Equals(Sphere<T> other)
        {
            return Center.Equals(other.Center) && Radius.Equals(other.Radius);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Sphere instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Sphere; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Sphere<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Center, Radius);
        }

        /// <summary>Returns a boolean indicating whether the two given Spheres are equal.</summary>
        /// <param name="value1">The first Spheres to compare.</param>
        /// <param name="value2">The second Spheres to compare.</param>
        /// <returns>True if the Spheres are equal; False otherwise.</returns>
        public static bool operator ==(Sphere<T> value1, Sphere<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Spheres are not equal.</summary>
        /// <param name="value1">The first Sphere to compare.</param>
        /// <param name="value2">The second Sphere to compare.</param>
        /// <returns>True if the Spheres are not equal; False if they are equal.</returns>
        public static bool operator !=(Sphere<T> value1, Sphere<T> value2)
        {
            return !value1.Equals(value2);
        }
        
        /// <summary>
        /// Returns this sphere casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted sphere</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Sphere<TOther> As<TOther>()
            where TOther : IRootFunctions<TOther>
        {
            return new(Center.As<TOther>(), Scalar.As<T, TOther>(Radius));
        }
    }
}
