using System;
using System.Globalization;
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
    public struct Plane<T>
        : IEquatable<Plane<T>> where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        /// <summary>The normal vector of the Plane.</summary>
        [DataMember]
        public Vector3<T> Normal;

        /// <summary>The distance of the Plane along its normal from the origin.</summary>
        [DataMember]
        public T Distance;

        /// <summary>Constructs a Plane from the X, Y, and Z components of its normal, and its distance from the origin on that normal.</summary>
        /// <param name="x">The X-component of the normal.</param>
        /// <param name="y">The Y-component of the normal.</param>
        /// <param name="z">The Z-component of the normal.</param>
        /// <param name="distance">The distance of the Plane along its normal from the origin.</param>
        public Plane(T x, T y, T z, T distance)
        {
            Normal = new Vector3<T>(x, y, z);
            Distance = distance;
        }

        /// <summary>Constructs a Plane from the given normal and distance along the normal from the origin.</summary>
        /// <param name="normal">The Plane's normal vector.</param>
        /// <param name="distance">The Plane's distance from the origin along its normal vector.</param>
        public Plane(Vector3<T> normal, T distance)
        {
            Normal = normal;
            Distance = distance;
        }

        /// <summary>Constructs a Plane from the given Vector4.</summary>
        /// <param name="value">A vector whose first 3 elements describe the normal vector,
        /// and whose W component defines the distance along that normal from the origin.</param>
        public Plane(Vector4<T> value)
        {
            Normal = new Vector3<T>(value.X, value.Y, value.Z);
            Distance = value.W;
        }

        /// <summary>Returns a boolean indicating whether the two given Planes are equal.</summary>
        /// <param name="value1">The first Plane to compare.</param>
        /// <param name="value2">The second Plane to compare.</param>
        /// <returns>True if the Planes are equal; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static bool operator ==(Plane<T> value1, Plane<T> value2) 
            => value1.Normal == value2.Normal && Scalar.Equal(value1.Distance, value2.Distance);

        /// <summary>Returns a boolean indicating whether the two given Planes are not equal.</summary>
        /// <param name="value1">The first Plane to compare.</param>
        /// <param name="value2">The second Plane to compare.</param>
        /// <returns>True if the Planes are not equal; False if they are equal.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static bool operator !=(Plane<T> value1, Plane<T> value2) 
            => !(value1 == value2);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Plane instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Plane; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public override readonly bool Equals(object? obj)
        {
            return (obj is Plane<T> other) && Equals(other);
        }

        /// <summary>Returns a boolean indicating whether the given Plane is equal to this Plane instance.</summary>
        /// <param name="other">The Plane to compare this instance to.</param>
        /// <returns>True if the other Plane is equal to this instance; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public readonly bool Equals(Plane<T> other)
        {
            return Normal.Equals(other.Normal) && Scalar.Equal(Distance, other.Distance);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return Normal.GetHashCode() + Distance.GetHashCode();
        }

        /// <summary>Returns a String representing this Plane instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return string.Format(ci, "{{Normal:{0} D:{1}}}", Normal.ToString(), Distance.ToString("G", ci));
        }

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Plane<Half>(Plane<T> from)
            => new((Vector3<Half>) from.Normal, Scalar.As<T, Half>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Plane<float>(Plane<T> from)
            => new((Vector3<float>) from.Normal, Scalar.As<T, float>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Plane<double>(Plane<T> from)
            => new((Vector3<double>) from.Normal, Scalar.As<T, double>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Plane<decimal>(Plane<T> from)
            => new((Vector3<decimal>) from.Normal, Scalar.As<T, decimal>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Plane<sbyte>(Plane<T> from)
            => new((Vector3<sbyte>) from.Normal, Scalar.As<T, sbyte>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Plane<byte>(Plane<T> from)
            => new((Vector3<byte>) from.Normal, Scalar.As<T, byte>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Plane<ushort>(Plane<T> from)
            => new((Vector3<ushort>) from.Normal, Scalar.As<T, ushort>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Plane<short>(Plane<T> from)
            => new((Vector3<short>) from.Normal, Scalar.As<T, short>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Plane<uint>(Plane<T> from)
            => new((Vector3<uint>) from.Normal, Scalar.As<T, uint>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Plane<int>(Plane<T> from)
            => new((Vector3<int>) from.Normal, Scalar.As<T, int>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Plane<ulong>(Plane<T> from)
            => new((Vector3<ulong>) from.Normal, Scalar.As<T, ulong>(from.Distance));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Plane<long>(Plane<T> from)
            => new((Vector3<long>) from.Normal, Scalar.As<T, long>(from.Distance));
    }

    public static class Plane
    {
        /// <summary>Creates a Plane that contains the three given points.</summary>
        /// <param name="point1">The first point defining the Plane.</param>
        /// <param name="point2">The second point defining the Plane.</param>
        /// <param name="point3">The third point defining the Plane.</param>
        /// <returns>The Plane containing the three points.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> CreateFromVertices<T>(Vector3<T> point1, Vector3<T> point2, Vector3<T> point3)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            var a = point1;
            var b = point2;
            var c = point3;
            var ab = b - a;
            var ac = c - a;

            var cross = Vector3.Cross(ab, ac);
            Plane<T> p;
            p.Normal = cross;
            p.Distance = Scalar.Negate(Scalar.Add(
                Scalar.Add(Scalar.Multiply(p.Normal.X, a.X), Scalar.Multiply(p.Normal.Y, a.Y)),
                Scalar.Multiply(p.Normal.Z, a.Z)));

            return p;

            /*if (Vector.IsHardwareAccelerated)
            {
                Vector3<T> a = point2 - point1;
                Vector3<T> b = point3 - point1;

                // N = Cross(a, b)
                Vector3<T> n = Vector3.Cross(a, b);
                Vector3<T> normal = Vector3.Normalize(n);

                // D = - Dot(N, point1)
                T d = Scalar.Negate(Vector3.Dot(normal, point1));

                return new Plane<T>(normal, d);
            }
            else
            {
                T ax = Scalar.Subtract(point2.X, point1.X);
                T ay = Scalar.Subtract(point2.Y, point1.Y);
                T az = Scalar.Subtract(point2.Z, point1.Z);

                T bx = Scalar.Subtract(point3.X, point1.X);
                T by = Scalar.Subtract(point3.Y, point1.Y);
                T bz = Scalar.Subtract(point3.Z, point1.Z);

                // N=Cross(a,b)
                T nx = Scalar.Subtract(Scalar.Multiply(ay, bz), Scalar.Multiply(az, by));
                T ny = Scalar.Subtract(Scalar.Multiply(az, bx), Scalar.Multiply(ax, bz));
                T nz = Scalar.Subtract(Scalar.Multiply(ax, by), Scalar.Multiply(ay, bx));

                // Normalize(N)
                T ls = Scalar.Add(Scalar.Add(Scalar.Multiply(nx, nx), Scalar.Multiply(ny, ny)), Scalar.Multiply(nz, nz));
                T invNorm = Scalar.Inverse(Scalar.Sqrt(ls));

                Vector3<T> normal = new Vector3<T>(
                    Scalar.Multiply(nx, invNorm),
                    Scalar.Multiply(ny, invNorm),
                    Scalar.Multiply(nz, invNorm));

                return new(normal,
                    Scalar.Negate(Scalar.Add(
                        Scalar.Add(Scalar.Multiply(normal.X, point1.X),
                            Scalar.Multiply(normal.Y, point1.Y)), Scalar.Multiply(normal.Z, point1.Z))));
            }*/
        }

        /// <summary>Calculates the dot product of a Plane and Vector4.</summary>
        /// <param name="plane">The Plane.</param>
        /// <param name="value">The Vector4.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T Dot<T>(Plane<T> plane, Vector4<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Add(
                Scalar.Add(
                    Scalar.Add(Scalar.Multiply(plane.Normal.X, value.X),
                        Scalar.Multiply(plane.Normal.Y, value.Y)), Scalar.Multiply(plane.Normal.Z, value.Z)),
                Scalar.Multiply(plane.Distance, value.W));

        /// <summary>Returns the dot product of a specified Vector3 and the normal vector of this Plane plus the distance (D) value of the Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3.</param>
        /// <returns>The resulting value.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T DotCoordinate<T>(Plane<T> plane, Vector3<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Scalar.Add(Vector3.Dot(plane.Normal, value), plane.Distance);

        /// <summary>Returns the dot product of a specified Vector3 and the Normal vector of this Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3.</param>
        /// <returns>The resulting dot product.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static T DotNormal<T>(Plane<T> plane, Vector3<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => Vector3.Dot(plane.Normal, value);
        
        private const float NormalizeEpsilon = 1.192092896e-07f; // smallest such that 1.0+NormalizeEpsilon != 1.0

        /// <summary>Creates a new Plane whose normal vector is the source Plane's normal vector normalized.</summary>
        /// <param name="value">The source Plane.</param>
        /// <returns>The normalized Plane.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Normalize<T>(Plane<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            /*if (Vector.IsHardwareAccelerated)
            {
                T normalLengthSquared = value.Normal.LengthSquared();
                if (MathF.Abs(normalLengthSquared - 1.0f) < NormalizeEpsilon)
                {
                    // It already normalized, so we don't need to farther process.
                    return value;
                }
                T normalLength = MathF.Sqrt(normalLengthSquared);
                return new Plane(
                    value.Normal / normalLength,
                    value.D / normalLength);
            }
            else*/
            {
                T f = Scalar.Add(
                    Scalar.Add(Scalar.Multiply(value.Normal.X, value.Normal.X),
                        Scalar.Multiply(value.Normal.Y, value.Normal.Y)),
                    Scalar.Multiply(value.Normal.Z, value.Normal.Z));

                if (!Scalar.GreaterThanOrEqual(Scalar.Abs(Scalar.Subtract(f, Scalar<T>.One)), Scalar.As<float, T>(NormalizeEpsilon)))
                {
                    return value; // It already normalized, so we don't need to further process.
                }

                T fInv = Scalar.Reciprocal(Scalar.Sqrt(f));

                return new(
                    Scalar.Multiply(value.Normal.X, fInv),
                    Scalar.Multiply(value.Normal.Y, fInv),
                    Scalar.Multiply(value.Normal.Z, fInv),
                    Scalar.Multiply(value.Distance, fInv));
            }
        }

        /// <summary>Transforms a normalized Plane by a Matrix.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="matrix">The transformation matrix to apply to the Plane.</param>
        /// <returns>The transformed Plane.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Transform<T>(Plane<T> plane, Matrix4x4<T> matrix)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix4x4.Invert(matrix, out Matrix4x4<T> m);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z, w = plane.Distance;

            return new(
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M11),  Scalar.Multiply(y, m.M12)), Scalar.Multiply(z, m.M13)), Scalar.Multiply(w, m.M14)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M21),  Scalar.Multiply(y, m.M22)), Scalar.Multiply(z, m.M23)), Scalar.Multiply(w, m.M24)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M31),  Scalar.Multiply(y, m.M32)), Scalar.Multiply(z, m.M33)), Scalar.Multiply(w, m.M34)),
                Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(x, m.M41),  Scalar.Multiply(y, m.M42)), Scalar.Multiply(z, m.M43)), Scalar.Multiply(w, m.M44)));
        }

        /// <summary> Transforms a normalized Plane by a Quaternion rotation.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="rotation">The Quaternion rotation to apply to the Plane.</param>
        /// <returns>A new Plane that results from applying the rotation.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Plane<T> Transform<T>(Plane<T> plane, Quaternion<T> rotation)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            // Compute rotation matrix.
            T x2 = Scalar.Add(rotation.X, rotation.X);
            T y2 = Scalar.Add(rotation.Y, rotation.Y);
            T z2 = Scalar.Add(rotation.Z, rotation.Z);

            T wx2 = Scalar.Multiply(rotation.W, x2);
            T wy2 = Scalar.Multiply(rotation.W, y2);
            T wz2 = Scalar.Multiply(rotation.W, z2);
            T xx2 = Scalar.Multiply(rotation.X, x2);
            T xy2 = Scalar.Multiply(rotation.X, y2);
            T xz2 = Scalar.Multiply(rotation.X, z2);
            T yy2 = Scalar.Multiply(rotation.Y, y2);
            T yz2 = Scalar.Multiply(rotation.Y, z2);
            T zz2 = Scalar.Multiply(rotation.Z, z2);

            T m11 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2);
            T m21 = Scalar.Subtract(xy2, wz2);
            T m31 = Scalar.Add(xz2, wy2);

            T m12 = Scalar.Add(xy2, wz2);
            T m22 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2);
            T m32 = Scalar.Subtract(yz2, wx2);

            T m13 = Scalar.Subtract(xz2, wy2);
            T m23 = Scalar.Add(yz2, wx2);
            T m33 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), yy2);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z;

            return new(
                Scalar.Add(Scalar.Add(Scalar.Multiply(x, m11), Scalar.Multiply(y, m21)), Scalar.Multiply(z, m31)),
                Scalar.Add(Scalar.Add(Scalar.Multiply(x, m12), Scalar.Multiply(y, m22)), Scalar.Multiply(z, m32)),
                Scalar.Add(Scalar.Add(Scalar.Multiply(x, m13), Scalar.Multiply(y, m23)), Scalar.Multiply(z, m33)),
                plane.Distance);
        }
    }
}
