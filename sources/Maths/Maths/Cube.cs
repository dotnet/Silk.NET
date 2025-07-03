// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Cube with an <see cref="Origin"/> and <see cref="Size"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Cube<T>
        : IEquatable<Cube<T>>
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
        public Vector3D<T> HalfSize => Size / Scalar<T>.Two;

        /// <summary>
        /// Calculates whether this cube contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this cube contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector3D<T> point)
        {
            var max = Max;
            return Scalar.GreaterThanOrEqual(point.X, Origin.X) && Scalar.GreaterThanOrEqual
                (point.Y, Origin.Y) && Scalar.GreaterThanOrEqual(point.Z, Origin.Z) && Scalar.LessThanOrEqual
                (point.X, max.X) && Scalar.LessThanOrEqual(point.Y, max.Y) && Scalar.LessThanOrEqual(point.Z, max.Z);
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
            return Scalar.GreaterThanOrEqual(other.Origin.X, this.Origin.X) && Scalar.GreaterThanOrEqual
                (other.Origin.Y, this.Origin.Y) && Scalar.GreaterThanOrEqual
                (other.Origin.Z, this.Origin.Z) && Scalar.LessThanOrEqual(oMax.X, tMax.X) && Scalar.LessThanOrEqual
                (oMax.Y, tMax.Y) && Scalar.GreaterThanOrEqual(oMax.Y, tMax.Y);
        }

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector3D<T> point)
        {
            var max = Max;
            var dx = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.X, point.X), Scalar<T>.Zero), Scalar.Subtract(point.X, max.X));
            var dy = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.Y, point.Y), Scalar<T>.Zero), Scalar.Subtract(point.Y, max.Y));
            var dz = Scalar.Max(Scalar.Max(Scalar.Subtract(Origin.Z, point.Z), Scalar<T>.Zero), Scalar.Subtract(point.Z, max.Z));
            return Scalar.Sqrt(Scalar.Add(Scalar.Add(Scalar.Multiply(dx, dx), Scalar.Multiply(dy, dy)), Scalar.Multiply(dz, dz)));
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
        /// <returns>True if the other Cube is equal to this instance; False otherwise.</returns>
        public bool Equals(Cube<T> other)
        {
            return Origin.Equals(other.Origin) && Size.Equals(other.Size);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Cube instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Cube; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Cube<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Origin, Size);
        }

        /// <summary>Returns a boolean indicating whether the two given Cubes are equal.</summary>
        /// <param name="value1">The first Cube to compare.</param>
        /// <param name="value2">The second Cube to compare.</param>
        /// <returns>True if the Cubes are equal; False otherwise.</returns>
        public static bool operator ==(Cube<T> value1, Cube<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Cubes are not equal.</summary>
        /// <param name="value1">The first Cube to compare.</param>
        /// <param name="value2">The second Cube to compare.</param>
        /// <returns>True if the Cubes are not equal; False if they are equal.</returns>
        public static bool operator !=(Cube<T> value1, Cube<T> value2)
        {
            return !value1.Equals(value2);
        }

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
}
