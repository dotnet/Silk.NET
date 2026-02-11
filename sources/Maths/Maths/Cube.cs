// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Cube with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Cube<T> :
        IEquatable<Cube<T>>
        where T : INumber<T>
    {
        /// <summary>
        /// The origin.
        /// </summary>
        [DataMember]
        public Vector3D<T> Origin;

        /// <summary>
        /// The size.
        /// </summary>
        [DataMember]
        public Vector3D<T> Size;

        /// <summary>
        /// Constructs a Cube from an origin and a size
        /// </summary>
        /// <param name="origin">The origin of the cube.</param>
        /// <param name="size">The size of the cube.</param>
        public Cube(Vector3D<T> origin, Vector3D<T> size)
        {
            Origin = origin;
            Size = size;
        }

        /// <summary>
        /// Constructs a Cube from an origin and components of a size
        /// </summary>
        /// <param name="origin">The origin of the cube.</param>
        /// <param name="sizeX">The X component of the size of the cube.</param>
        /// <param name="sizeY">The Y component of the size of the cube.</param>
        /// <param name="sizeZ">The Z component of the size of the cube.</param>
        public Cube(Vector3D<T> origin, T sizeX, T sizeY, T sizeZ)
            : this(origin, new Vector3D<T>(sizeX, sizeY, sizeZ))
        {
        }

        /// <summary>
        /// Constructs a Cube from components of an origin and a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the cube.</param>
        /// <param name="originY">The Y component of the origin of the cube.</param>
        /// <param name="originZ">The Z component of the origin of the cube.</param>
        /// <param name="size">The size of the cube.</param>
        public Cube(T originX, T originY, T originZ, Vector3D<T> size)
            : this(new Vector3D<T>(originX, originY, originZ), size)
        {
        }

        /// <summary>
        /// Constructs a Cube from components of an origin and components of a size
        /// </summary>
        /// <param name="originX">The X component of the origin of the cube.</param>
        /// <param name="originY">The Y component of the origin of the cube.</param>
        /// <param name="originZ">The Z component of the origin of the cube.</param>
        /// <param name="sizeX">The X component of the size of the cube.</param>
        /// <param name="sizeY">The Y component of the size of the cube.</param>
        /// <param name="sizeZ">The Z component of the size of the cube.</param>
        public Cube(T originX, T originY, T originZ, T sizeX, T sizeY, T sizeZ)
            : this(new Vector3D<T>(originX, originY, originZ), new Vector3D<T>(sizeX, sizeY, sizeZ))
        {
        }

        /// <summary>
        /// The center of this cube.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Center => Origin + HalfSize;

        /// <summary>
        /// The Maximum point of this cube.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Max => Origin + Size;

        /// <summary>
        /// Half the size of this cube.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> HalfSize => Size / T.CreateTruncating(2);

        /// <summary>
        /// Calculates whether this cube contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this cube contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector3D<T> point)
        {
            var max = Max;
            return (point.X >= Origin.X) && (point.Y >= Origin.Y) && (point.Z >= Origin.Z)
                && (point.X <= max.X) && (point.Y <= max.Y) && (point.Z <= max.Z);
        }

        /// <summary>
        /// Calculates whether this cube contains another cube
        /// </summary>
        /// <param name="other">The cube.</param>
        /// <returns>True if this cube contains the given cube; False otherwise.</returns>
        /// <remarks>This does consider a cube that touches the edge contained.</remarks>
        public bool Contains(Cube<T> other)
        {
            var tMax = this.Max;
            var oMax = other.Max;
            return (other.Origin.X >= this.Origin.X) && (other.Origin.Y >= this.Origin.Y) && (other.Origin.Z >= this.Origin.Z)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y) && (oMax.Y <= tMax.Y);
        }

        /// <summary>
        /// Calculates a new cube translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated cube.</returns>
        public Cube<T> GetTranslated(Vector3D<T> distance)
        {
            return new(Origin + distance, Size);
        }

        /// <summary>
        /// Calculates a new cube scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated cube.</returns>
        public Cube<T> GetScaled(Vector3D<T> scale, Vector3D<T> anchor)
        {
            var min = (scale * (Origin - anchor)) + anchor;
            var max = (scale * (Max - anchor)) + anchor;
            return new(min, max - min);
        }

        /// <summary>
        /// Calculates a new cube scaled by the given scale around the given anchor.
        /// </summary>
        /// <typeparam name="TScale">The type of the scale.</typeparam>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated cube.</returns>
        public Cube<T> GetScaled<TScale>(Vector3D<TScale> scale, Vector3D<T> anchor)
            where TScale : INumberBase<TScale>
        {
            var convertedAnchor = anchor.AsTruncating<TScale>();
            var min = (scale * (Origin.AsTruncating<TScale>() - convertedAnchor)) + convertedAnchor;
            var max = (scale * (Max.AsTruncating<TScale>() - convertedAnchor)) + convertedAnchor;
            return new(min.AsTruncating<T>(), (max - min).AsTruncating<T>());
        }

        /// <summary>
        /// Calculates a cube inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The cube.</returns>
        public Cube<T> GetInflated(Vector3D<T> point)
        {
            var min = Vector3D.Min(Origin, point);
            var max = Vector3D.Max(Max, point);
            return new(min, max - min);
        }

        /// <summary>Returns a boolean indicating whether the given Cube is equal to this Cube instance.</summary>
        /// <param name="other">The Cube to compare this instance to.</param>
        /// <returns><c>true</c> if the other Cube is equal to this instance; <c>false</c> otherwise.</returns>
        public bool Equals(Cube<T> other) =>
            Origin.Equals(other.Origin) && Size.Equals(other.Size);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Cube instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Cube; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Cube<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Origin, Size);

        /// <summary>Returns a boolean indicating whether the two given Cubes are equal.</summary>
        /// <param name="left">The first Cube to compare.</param>
        /// <param name="right">The second Cube to compare.</param>
        /// <returns><c>true</c> if the Cubes are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Cube<T> left, Cube<T> right) =>
            left.Origin == right.Origin && left.Size == right.Size;

        /// <summary>Returns a boolean indicating whether the two given Cubes are not equal.</summary>
        /// <param name="left">The first Cube to compare.</param>
        /// <param name="right">The second Cube to compare.</param>
        /// <returns><c>true</c> if the Cubes are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Cube<T> left, Cube<T> right) =>
            left.Origin != right.Origin || left.Size != right.Size;

        /// <summary>
        /// Returns this circle casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted cube</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Cube<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Origin.As<TOther>(), Max.As<TOther>());
        }
    }

    /// <summary>
    /// Helper methods to work with <see cref="Cube{T}"/>
    /// </summary>
    public static class Cube
    {
        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="cube">The cube.</param>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public static T GetDistanceToNearestEdge<T>(Cube<T> cube, Vector3D<T> point)
            where T : INumber<T>, IRootFunctions<T>
        {
            var max = cube.Max;
            var dx = T.Max(T.Max(cube.Origin.X - point.X, T.Zero), point.X - max.X);
            var dy = T.Max(T.Max(cube.Origin.Y - point.Y, T.Zero), point.Y - max.Y);
            var dz = T.Max(T.Max(cube.Origin.Z - point.Z, T.Zero), point.Z - max.Z);
            return T.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
        }
    }
}
