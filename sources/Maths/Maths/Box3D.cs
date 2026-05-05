// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// A structure representing a Box3D with a <see cref="Min"/> and a` <see cref="Max"/>
    /// </summary>
    [Serializable]
    [DataContract]
    public struct Box3D<T> :
        IEquatable<Box3D<T>>, IExtents3D<T>
        where T : INumber<T>
    {
        /// <inheritdoc/>
        [DataMember]
        public Vector3D<T> Min { get; set; }

        /// <inheritdoc/>
        [DataMember]
        public Vector3D<T> Max { get; set; }

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

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector3D<T> Center => (Min + Max) / T.CreateTruncating(2);

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector3D<T> Size => Max - Min;

        /// <inheritdoc/>
        [IgnoreDataMember]
        public readonly Vector3D<T> HalfSize => Size / T.CreateTruncating(2);

        /// <inheritdoc/>
        public readonly bool Contains<TOther>(TOther other)
            where TOther : IExtents3D<T>
        {
            var tMin = Min;
            var tMax = Max;
            var oMin = other.Min;
            var oMax = other.Max;
            return (oMin.X >= tMin.X) && (oMin.Y >= tMin.Y) && (oMin.Z >= tMin.Z)
                && (oMax.X <= tMax.X) && (oMax.Y <= tMax.Y) && (oMax.Z <= tMax.Z);
        }

        /// <summary>
        /// Calculates a new Box3D scaled by the given scale around the given anchor.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor.</param>
        /// <returns>The calculated Box3D.</returns>
        public readonly Box3D<T> GetScaled(Vector3D<T> scale, Vector3D<T> anchor)
        {
            var min = (scale * (Min - anchor)) + anchor;
            var max = (scale * (Max - anchor)) + anchor;
            return new(min, max);
        }

        /// <summary>
        /// Calculates this box translated by a given distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <returns>The calculated box.</returns>
        public readonly Box3D<T> GetTranslated(Vector3D<T> distance)
        {
            return new(Min + distance, Max + distance);
        }

        /// <summary>
        /// Calculates a box inflated to contain the given point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The calculated box.</returns>
        public readonly Box3D<T> GetInflated(Vector3D<T> point) =>
            new(Vector3D.Min(Min, point), Vector3D.Max(Max, point));

        /// <summary>Returns a boolean indicating whether the given Box3D is equal to this Box3D instance.</summary>
        /// <param name="other">The Box3D to compare this instance to.</param>
        /// <returns><c>true</c> if the other Box3D is equal to this instance; <c>false</c> otherwise.</returns>
        public readonly bool Equals(Box3D<T> other) =>
            Min.Equals(other.Min) && Max.Equals(other.Max);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Box3D instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Box3D; <c>false</c> otherwise.</returns>
        public override bool Equals(object? obj) =>
            obj is Box3D<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Min, Max);

        /// <summary>Returns a boolean indicating whether the two given Box3s are equal.</summary>
        /// <param name="left">The first Box3D to compare.</param>
        /// <param name="right">The second Box3D to compare.</param>
        /// <returns><c>true</c> if the Box3s are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Box3D<T> left, Box3D<T> right) =>
             left.Min == right.Min && left.Max == right.Max;

        /// <summary>Returns a boolean indicating whether the two given Box3s are not equal.</summary>
        /// <param name="left">The first Box3D to compare.</param>
        /// <param name="right">The second Box3D to compare.</param>
        /// <returns><c>true</c> if the Box3s are not equal; <c>false</c> if they are equal.</returns>
        public static bool operator !=(Box3D<T> left, Box3D<T> right) =>
             left.Min != right.Min || left.Max != right.Max;

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public readonly Box3D<TOther> As<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.As<TOther>(), Max.As<TOther>());
        }

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        public readonly Box3D<TOther> AsChecked<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.AsChecked<TOther>(), Max.AsChecked<TOther>());
        }

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        public readonly Box3D<TOther> AsSaturating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.AsSaturating<TOther>(), Max.AsSaturating<TOther>());
        }

        /// <summary>
        /// Returns this box casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted box</returns>
        public readonly Box3D<TOther> AsTruncating<TOther>()
            where TOther : INumber<TOther>
        {
            return new(Min.AsTruncating<TOther>(), Max.AsTruncating<TOther>());
        }
    }
}
