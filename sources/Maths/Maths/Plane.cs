// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Represents a plane in three-dimensional space.
    /// </summary>
    /// <typeparam name="T">The type used to store values.</typeparam>
    [Serializable]
    [DataContract]
    public struct Plane<T> : IEquatable<Plane<T>>
        where T : INumberBase<T>
    {
        /// <summary>The normal vector of the Plane.</summary>
        [DataMember]
        public Vector3D<T> Normal;

        /// <summary>The distance of the Plane along its normal from the origin.</summary>
        [DataMember]
        public T Distance;

        /// <summary>Constructs a Plane from the X, Y, and Z components of its normal, and its distance from the origin on that normal.</summary>
        /// <param name="x">The X-component of the normal.</param>
        /// <param name="y">The Y-component of the normal.</param>
        /// <param name="z">The Z-component of the normal.</param>
        /// <param name="distance">The distance of the Plane along its normal from the origin.</param>
        public Plane(T x, T y, T z, T distance)
            : this(new Vector3D<T>(x, y, z), distance)
        {
        }

        /// <summary>Constructs a Plane from the given normal and distance along the normal from the origin.</summary>
        /// <param name="normal">The Plane's normal vector.</param>
        /// <param name="distance">The Plane's distance from the origin along its normal vector.</param>
        public Plane(Vector3D<T> normal, T distance)
        {
            Normal = normal;
            Distance = distance;
        }

        /// <summary>Constructs a Plane from the given Vector4D.</summary>
        /// <param name="value">A vector whose first 3 elements describe the normal vector,
        /// and whose W component defines the distance along that normal from the origin.</param>
        public Plane(Vector4D<T> value)
        {
            Normal = new Vector3D<T>(value.X, value.Y, value.Z);
            Distance = value.W;
        }

        /// <summary>Returns a boolean indicating whether the given Plane is equal to this Plane instance.</summary>
        /// <param name="other">The Plane to compare this instance to.</param>
        /// <returns><c>true</c> if the other Plane is equal to this instance; <c>false</c> otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public readonly bool Equals(Plane<T> other) =>
            Normal.Equals(other.Normal) && Distance.Equals(other.Distance);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Plane instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns><c>true</c> if the Object is equal to this Plane; <c>false</c> otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public override readonly bool Equals(object? obj) =>
            obj is Plane<T> other && Equals(other);

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode() =>
            HashCode.Combine(Normal, Distance);

        /// <summary>Returns a boolean indicating whether the two given Planes are equal.</summary>
        /// <param name="left">The first Plane to compare.</param>
        /// <param name="right">The second Plane to compare.</param>
        /// <returns><c>true</c> if the Planes are equal; <c>false</c> otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static bool operator ==(Plane<T> left, Plane<T> right) =>
            left.Normal == right.Normal && left.Distance == right.Distance;

        /// <summary>Returns a boolean indicating whether the two given Planes are not equal.</summary>
        /// <param name="left">The first Plane to compare.</param>
        /// <param name="right">The second Plane to compare.</param>
        /// <returns><c>true</c> if the Planes are not equal; <c>false</c> if they are equal.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static bool operator !=(Plane<T> left, Plane<T> right) =>
            left.Normal != right.Normal || left.Distance != right.Distance;

        /// <summary>Returns a String representing this Plane instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return string.Format(
                ci,
                "{{Normal:{0} D:{1}}}",
                Normal.ToString(),
                Distance.ToString("G", ci)
            );
        }

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Plane<Half>(Plane<T> from) =>
            new((Vector3D<Half>)from.Normal, Half.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Plane<float>(Plane<T> from) =>
            new((Vector3D<float>)from.Normal, float.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into <see cref="System.Numerics.Plane"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="System.Numerics"/> matrix</returns>
        public static explicit operator System.Numerics.Plane(Plane<T> from) =>
            new((System.Numerics.Vector3)from.Normal, float.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Plane<double>(Plane<T> from) =>
            new((Vector3D<double>)from.Normal, double.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Plane<decimal>(Plane<T> from) =>
            new((Vector3D<decimal>)from.Normal, decimal.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Plane<sbyte>(Plane<T> from) =>
            new((Vector3D<sbyte>)from.Normal, sbyte.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Plane<byte>(Plane<T> from) =>
            new((Vector3D<byte>)from.Normal, byte.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Plane<ushort>(Plane<T> from) =>
            new((Vector3D<ushort>)from.Normal, ushort.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Plane<short>(Plane<T> from) =>
            new((Vector3D<short>)from.Normal, short.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Plane<uint>(Plane<T> from) =>
            new((Vector3D<uint>)from.Normal, uint.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Plane<int>(Plane<T> from) =>
            new((Vector3D<int>)from.Normal, int.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Plane<ulong>(Plane<T> from) =>
            new((Vector3D<ulong>)from.Normal, ulong.CreateTruncating(from.Distance));

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Plane<long>(Plane<T> from) =>
            new((Vector3D<long>)from.Normal, long.CreateTruncating(from.Distance));

        /// <summary>
        /// Returns this plane casted to <typeparamref name="TOther"></typeparamref>
        /// </summary>
        /// <typeparam name="TOther">The type to cast to</typeparam>
        /// <returns>The casted plane</returns>
        [Obsolete("Use AsChecked, AsSaturating, or AsTruncating instead.", error: false)]
        public Plane<TOther> As<TOther>()
            where TOther : INumberBase<TOther>
        {
            return new(Normal.As<TOther>(), TOther.CreateTruncating(Distance));
        }
    }
}
