// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Box3D with a <see cref="Min"/> and a` <see cref="Max"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Box3D<T>
        : IEquatable<Box3D<T>>
        where T : INumber<T>
    {
        /// <summary>
        /// The min.
        /// </summary>
        [DataMember]
        public Vector3D<T> Min;
        /// <summary>
        /// The max.
        /// </summary>
        [DataMember]
        public Vector3D<T> Max;

        /// <summary>
        /// Constructs a Box3D from a min and a max
        /// </summary>
        /// <param name="min">The min of the box.</param>
        /// <param name="max">The max of the box.</param>
        public Box3D(Vector3D<T> min, Vector3D<T> max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Constructs a Box3D from a min and components of a max
        /// </summary>
        /// <param name="min">The min of the box.</param>
        /// <param name="maxX">The max X component of the box.</param>
        /// <param name="maxY">The max Y component of the box.</param>
        /// <param name="maxZ">The max Z component of the box.</param>
        public Box3D(Vector3D<T> min, T maxX, T maxY, T maxZ)
            : this(min, new Vector3D<T>(maxX, maxY, maxZ))
        {
        }

        /// <summary>
        /// Constructs a Box3D from components of a min and a max
        /// </summary>
        /// <param name="minX">The min X component of the box.</param>
        /// <param name="minY">The min Y component of the box.</param>
        /// <param name="minZ">The min Z component of the box.</param>
        /// <param name="max">The max of the box.</param>
        public Box3D(T minX, T minY, T minZ, Vector3D<T> max)
            : this(new Vector3D<T>(minX, minY, minZ), max)
        {
        }

        /// <summary>
        /// Constructs a Box3D from components of a min and a max
        /// </summary>
        /// <param name="minX">The min X component of the box.</param>
        /// <param name="minY">The min Y component of the box.</param>
        /// <param name="minZ">The min Z component of the box.</param>
        /// <param name="maxX">The max X component of the box.</param>
        /// <param name="maxY">The max Y component of the box.</param>
        /// <param name="maxZ">The max Z component of the box.</param>
        public Box3D(T minX, T minY, T minZ, T maxX, T maxY, T maxZ)
            : this(new Vector3D<T>(minX, minY, minZ), new Vector3D<T>(maxX, maxY, maxZ))
        {
        }

        /// <summary>
        /// The center of this box.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Center => (Min + Max) / Scalar<T>.Two;

        /// <summary>
        /// The size of this box.
        /// When setting the box is scaled about its center.
        /// </summary>
        [IgnoreDataMember]
        public Vector3D<T> Size => Max - Min;

        /// <summary>
        /// Calculates whether this box contains a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>True if this box contains the point; False otherwise.</returns>
        /// <remarks>This does consider a point on the edge contained.</remarks>
        public bool Contains(Vector3D<T> point)
            => Scalar.GreaterThanOrEqual(point.X, Min.X) && Scalar.GreaterThanOrEqual(point.Y, Min.Y)
            && Scalar.GreaterThanOrEqual(point.Z, Min.Z)
            && Scalar.LessThanOrEqual(point.X, Max.X) && Scalar.LessThanOrEqual(point.Y, Max.Y)
            && Scalar.LessThanOrEqual(point.Z, Max.Z);

        /// <summary>
        /// Calculates whether this box contains another box
        /// </summary>
        /// <param name="other">The box.</param>
        /// <returns>True if this box contains the given box; False otherwise.</returns>
        /// <remarks>This does consider a box that touches the edge contained.</remarks>
        public bool Contains(Box3D<T> other)
            => Scalar.GreaterThanOrEqual(other.Min.X, this.Min.X) && Scalar.GreaterThanOrEqual(other.Min.Y, this.Min.Y)
            && Scalar.GreaterThanOrEqual(other.Min.Z, this.Min.Z)
            && Scalar.LessThanOrEqual(other.Max.X, this.Max.X) && Scalar.LessThanOrEqual(other.Max.Y, this.Max.Y)
            && Scalar.LessThanOrEqual(other.Max.Z, this.Max.Z);

        /// <summary>
        /// Calculates the distance to the nearest edge from the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The distance.</returns>
        public T GetDistanceToNearestEdge(Vector3D<T> point)
        {
            var dx = Scalar.Max(Scalar.Max(Scalar.Subtract(Min.X, point.X), Scalar<T>.Zero), Scalar.Subtract(point.X, Max.X));
            var dy = Scalar.Max(Scalar.Max(Scalar.Subtract(Min.Y, point.Y), Scalar<T>.Zero), Scalar.Subtract(point.Y, Max.Y));
            var dz = Scalar.Max(Scalar.Max(Scalar.Subtract(Min.Z, point.Z), Scalar<T>.Zero), Scalar.Subtract(point.Z, Max.Z));
            return Scalar.Sqrt(Scalar.Add(Scalar.Add(Scalar.Multiply(dx, dx), Scalar.Multiply(dy, dy)), Scalar.Multiply(dz, dz)));
        }

        /// <summary>
        /// Calculates this box translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated box.</returns>
        public Box3D<T> GetTranslated(Vector3D<T> distance)
        {
            return new(Min + distance, Max + distance);
        }

        /// <summary>
        /// Calculates a new box scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated box.</returns>
        public Box3D<T> GetScaled(Vector3D<T> scale, Vector3D<T> anchor)
        {
            var min = (scale * (Min - anchor)) + anchor;
            var max = (scale * (Max - anchor)) + anchor;
            return new(min, max);
        }
        
        /// <summary>
        /// Calculates a new box scaled by the given scale around the given anchor.
        /// </summary>
        /// <typeparam name="TScale">The type of the scale.</typeparam>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated box.</returns>
        public Box3D<T> GetScaled<TScale>(Vector3D<TScale> scale, Vector3D<T> anchor)
            where TScale : INumberBase<TScale>
        {
            var convertedAnchor = anchor.AsTruncating<TScale>();
            var min = (scale * (Min.AsTruncating<TScale>() - convertedAnchor)) + convertedAnchor;
            var max = (scale * (Max.AsTruncating<TScale>() - convertedAnchor)) + convertedAnchor;
            return new Box3D<T>(min.AsTruncating<T>(), max.AsTruncating<T>());
        }

        /// <summary>
        /// Calculates a box inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated box.</returns>
        public Box3D<T> GetInflated(Vector3D<T> point)
        {
            return new(Vector3D.Min(Min, point), Vector3D.Max(Max, point));
        }

        /// <summary>Returns a boolean indicating whether the given Box3D is equal to this Box3D instance.</summary>
        /// <param name="other">The Box3D to compare this instance to.</param>
        /// <returns>True if the other Box3D is equal to this instance; False otherwise.</returns>
        public bool Equals(Box3D<T> other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Box3D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Box3D; False otherwise.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Box3D<T> other && Equals(other);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Min, Max);
        }

        /// <summary>Returns a boolean indicating whether the two given Box3s are equal.</summary>
        /// <param name="value1">The first Box3D to compare.</param>
        /// <param name="value2">The second Box3D to compare.</param>
        /// <returns>True if the Box3s are equal; False otherwise.</returns>
        public static bool operator ==(Box3D<T> value1, Box3D<T> value2)
        {
            return value1.Equals(value2);
        }

        /// <summary>Returns a boolean indicating whether the two given Box3s are not equal.</summary>
        /// <param name="value1">The first Box3D to compare.</param>
        /// <param name="value2">The second Box3D to compare.</param>
        /// <returns>True if the Box3s are not equal; False if they are equal.</returns>
        public static bool operator !=(Box3D<T> value1, Box3D<T> value2)
        {
            return !value1.Equals(value2);
        }
        
        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Box3D<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.As<TOther>(), Max.As<TOther>());
        }
    }
}
