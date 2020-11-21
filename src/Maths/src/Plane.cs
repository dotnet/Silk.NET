using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Silk.NET.Numerics
{
    public struct Plane<T>
        : IEquatable<Plane<T>> where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float NormalizeEpsilon = 1.192092896e-07f; // smallest such that 1.0+NormalizeEpsilon != 1.0

        /// <summary>The normal vector of the Plane.</summary>
        public Vector3<T> Normal;

        /// <summary>The distance of the Plane along its normal from the origin.</summary>
        public T D;

        /// <summary>Constructs a Plane from the X, Y, and Z components of its normal, and its distance from the origin on that normal.</summary>
        /// <param name="x">The X-component of the normal.</param>
        /// <param name="y">The Y-component of the normal.</param>
        /// <param name="z">The Z-component of the normal.</param>
        /// <param name="d">The distance of the Plane along its normal from the origin.</param>
        public Plane(T x, T y, T z, T d)
        {
            Normal = new Vector3<T>(x, y, z);
            D = d;
        }

        /// <summary>Constructs a Plane from the given normal and distance along the normal from the origin.</summary>
        /// <param name="normal">The Plane's normal vector.</param>
        /// <param name="d">The Plane's distance from the origin along its normal vector.</param>
        public Plane(Vector3<T> normal, T d)
        {
            Normal = normal;
            D = d;
        }

        /// <summary>Constructs a Plane from the given Vector4.</summary>
        /// <param name="value">A vector whose first 3 elements describe the normal vector,
        /// and whose W component defines the distance along that normal from the origin.</param>
        public Plane(Vector4<T> value)
        {
            Normal = new Vector3<T>(value.X, value.Y, value.Z);
            D = value.W;
        }

        /// <summary>Creates a Plane that contains the three given points.</summary>
        /// <param name="point1">The first point defining the Plane.</param>
        /// <param name="point2">The second point defining the Plane.</param>
        /// <param name="point3">The third point defining the Plane.</param>
        /// <returns>The Plane containing the three points.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Plane<T> CreateFromVertices(Vector3<T> point1, Vector3<T> point2, Vector3<T> point3)
        {
            var a = point1;
            var b = point2;
            var c = point3;
            var ab = b - a;
            var ac = c - a;

            var cross = Vector3<T>.Cross(ab, ac);
            Plane<T> p;
            p.Normal = cross;
            p.D = Operations.Negate(Operations.Add(
                Operations.Add(Operations.Multiply(p.Normal.X, a.X), Operations.Multiply(p.Normal.Y, a.Y)),
                Operations.Multiply(p.Normal.Z, a.Z)));

            return p;

            /*if (Vector.IsHardwareAccelerated)
            {
                Vector3<T> a = point2 - point1;
                Vector3<T> b = point3 - point1;

                // N = Cross(a, b)
                Vector3<T> n = Vector3<T>.Cross(a, b);
                Vector3<T> normal = Vector3<T>.Normalize(n);

                // D = - Dot(N, point1)
                T d = Operations.Negate(Vector3<T>.Dot(normal, point1));

                return new Plane<T>(normal, d);
            }
            else
            {
                T ax = Operations.Subtract(point2.X, point1.X);
                T ay = Operations.Subtract(point2.Y, point1.Y);
                T az = Operations.Subtract(point2.Z, point1.Z);

                T bx = Operations.Subtract(point3.X, point1.X);
                T by = Operations.Subtract(point3.Y, point1.Y);
                T bz = Operations.Subtract(point3.Z, point1.Z);

                // N=Cross(a,b)
                T nx = Operations.Subtract(Operations.Multiply(ay, bz), Operations.Multiply(az, by));
                T ny = Operations.Subtract(Operations.Multiply(az, bx), Operations.Multiply(ax, bz));
                T nz = Operations.Subtract(Operations.Multiply(ax, by), Operations.Multiply(ay, bx));

                // Normalize(N)
                T ls = Operations.Add(Operations.Add(Operations.Multiply(nx, nx), Operations.Multiply(ny, ny)), Operations.Multiply(nz, nz));
                T invNorm = Operations.Divide(Constants<T>.One, Operations.Sqrt(ls));

                Vector3<T> normal = new Vector3<T>(
                    Operations.Multiply(nx, invNorm),
                    Operations.Multiply(ny, invNorm),
                    Operations.Multiply(nz, invNorm));

                return new(normal,
                    Operations.Negate(Operations.Add(
                        Operations.Add(Operations.Multiply(normal.X, point1.X),
                            Operations.Multiply(normal.Y, point1.Y)), Operations.Multiply(normal.Z, point1.Z))));
            }*/
        }

        /// <summary>Calculates the dot product of a Plane and Vector4.</summary>
        /// <param name="plane">The Plane.</param>
        /// <param name="value">The Vector4.</param>
        /// <returns>The dot product.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Dot(Plane<T> plane, Vector4<T> value)
            => Operations.Add(
                Operations.Add(
                    Operations.Add(Operations.Multiply(plane.Normal.X, value.X),
                        Operations.Multiply(plane.Normal.Y, value.Y)), Operations.Multiply(plane.Normal.Z, value.Z)),
                Operations.Multiply(plane.D, value.W));

        /// <summary>Returns the dot product of a specified Vector3 and the normal vector of this Plane plus the distance (D) value of the Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3.</param>
        /// <returns>The resulting value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DotCoordinate(Plane<T> plane, Vector3<T> value)
            => Operations.Add(Vector3<T>.Dot(plane.Normal, value), plane.D);

        /// <summary>Returns the dot product of a specified Vector3 and the Normal vector of this Plane.</summary>
        /// <param name="plane">The plane.</param>
        /// <param name="value">The Vector3.</param>
        /// <returns>The resulting dot product.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DotNormal(Plane<T> plane, Vector3<T> value)
            => Vector3<T>.Dot(plane.Normal, value);

        /// <summary>Creates a new Plane whose normal vector is the source Plane's normal vector normalized.</summary>
        /// <param name="value">The source Plane.</param>
        /// <returns>The normalized Plane.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Plane<T> Normalize(Plane<T> value)
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
                T f = Operations.Add(
                    Operations.Add(Operations.Multiply(value.Normal.X, value.Normal.X),
                        Operations.Multiply(value.Normal.Y, value.Normal.Y)),
                    Operations.Multiply(value.Normal.Z, value.Normal.Z));

                if (!Operations.GreaterThanOrEqual(Operations.Abs(Operations.Subtract(f, Constants<T>.One)), Operations.As<float, T>(NormalizeEpsilon)))
                {
                    return value; // It already normalized, so we don't need to further process.
                }

                T fInv = Operations.Divide(Constants<T>.One, Operations.Sqrt(f));

                return new(
                    Operations.Multiply(value.Normal.X, fInv),
                    Operations.Multiply(value.Normal.Y, fInv),
                    Operations.Multiply(value.Normal.Z, fInv),
                    Operations.Multiply(value.D, fInv));
            }
        }

        /// <summary>Transforms a normalized Plane by a Matrix.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="matrix">The transformation matrix to apply to the Plane.</param>
        /// <returns>The transformed Plane.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Plane<T> Transform(Plane<T> plane, Matrix4x4<T> matrix)
        {
            Matrix4x4<T>.Invert(matrix, out Matrix4x4<T> m);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z, w = plane.D;

            return new(
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(x, m.M11),  Operations.Multiply(y, m.M12)), Operations.Multiply(z, m.M13)), Operations.Multiply(w, m.M14)),
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(x, m.M21),  Operations.Multiply(y, m.M22)), Operations.Multiply(z, m.M23)), Operations.Multiply(w, m.M24)),
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(x, m.M31),  Operations.Multiply(y, m.M32)), Operations.Multiply(z, m.M33)), Operations.Multiply(w, m.M34)),
                Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(x, m.M41),  Operations.Multiply(y, m.M42)), Operations.Multiply(z, m.M43)), Operations.Multiply(w, m.M44)));
        }

        /// <summary> Transforms a normalized Plane by a Quaternion rotation.</summary>
        /// <param name="plane"> The normalized Plane to transform.
        /// This Plane must already be normalized, so that its Normal vector is of unit length, before this method is called.</param>
        /// <param name="rotation">The Quaternion rotation to apply to the Plane.</param>
        /// <returns>A new Plane that results from applying the rotation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Plane<T> Transform(Plane<T> plane, Quaternion<T> rotation)
        {
            // Compute rotation matrix.
            T x2 = Operations.Add(rotation.X, rotation.X);
            T y2 = Operations.Add(rotation.Y, rotation.Y);
            T z2 = Operations.Add(rotation.Z, rotation.Z);

            T wx2 = Operations.Multiply(rotation.W, x2);
            T wy2 = Operations.Multiply(rotation.W, y2);
            T wz2 = Operations.Multiply(rotation.W, z2);
            T xx2 = Operations.Multiply(rotation.X, x2);
            T xy2 = Operations.Multiply(rotation.X, y2);
            T xz2 = Operations.Multiply(rotation.X, z2);
            T yy2 = Operations.Multiply(rotation.Y, y2);
            T yz2 = Operations.Multiply(rotation.Y, z2);
            T zz2 = Operations.Multiply(rotation.Z, z2);

            T m11 = Operations.Subtract(Operations.Subtract(Constants<T>.One, yy2), zz2);
            T m21 = Operations.Subtract(xy2, wz2);
            T m31 = Operations.Add(xz2, wy2);

            T m12 = Operations.Add(xy2, wz2);
            T m22 = Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), zz2);
            T m32 = Operations.Subtract(yz2, wx2);

            T m13 = Operations.Subtract(xz2, wy2);
            T m23 = Operations.Add(yz2, wx2);
            T m33 = Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), yy2);

            T x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z;

            return new(
                Operations.Add(Operations.Add(Operations.Multiply(x, m11), Operations.Multiply(y, m21)), Operations.Multiply(z, m31)),
                Operations.Add(Operations.Add(Operations.Multiply(x, m12), Operations.Multiply(y, m22)), Operations.Multiply(z, m32)),
                Operations.Add(Operations.Add(Operations.Multiply(x, m13), Operations.Multiply(y, m23)), Operations.Multiply(z, m33)),
                plane.D);
        }

        /// <summary>Returns a boolean indicating whether the two given Planes are equal.</summary>
        /// <param name="value1">The first Plane to compare.</param>
        /// <param name="value2">The second Plane to compare.</param>
        /// <returns>True if the Planes are equal; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Plane<T> value1, Plane<T> value2) 
            => value1.Normal == value2.Normal && Operations.Equal(value1.D, value2.D);

        /// <summary>Returns a boolean indicating whether the two given Planes are not equal.</summary>
        /// <param name="value1">The first Plane to compare.</param>
        /// <param name="value2">The second Plane to compare.</param>
        /// <returns>True if the Planes are not equal; False if they are equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Plane<T> value1, Plane<T> value2) 
            => !(value1 == value2);

        /// <summary>Returns a boolean indicating whether the given Object is equal to this Plane instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this Plane; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
        {
            return (obj is Plane<T> other) && Equals(other);
        }

        /// <summary>Returns a boolean indicating whether the given Plane is equal to this Plane instance.</summary>
        /// <param name="other">The Plane to compare this instance to.</param>
        /// <returns>True if the other Plane is equal to this instance; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Plane<T> other)
        {
            return Normal.Equals(other.Normal) && Operations.Equal(D, other.D);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return Normal.GetHashCode() + D.GetHashCode();
        }

        /// <summary>Returns a String representing this Plane instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return string.Format(ci, "{{Normal:{0} D:{1}}}", Normal.ToString(), D.ToString("G", ci));
        }

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Plane<Half>(Plane<T> from)
            => new((Vector3<Half>) from.Normal, Operations.As<T, Half>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Plane<float>(Plane<T> from)
            => new((Vector3<float>) from.Normal, Operations.As<T, float>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Plane<double>(Plane<T> from)
            => new((Vector3<double>) from.Normal, Operations.As<T, double>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Plane<decimal>(Plane<T> from)
            => new((Vector3<decimal>) from.Normal, Operations.As<T, decimal>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Plane<sbyte>(Plane<T> from)
            => new((Vector3<sbyte>) from.Normal, Operations.As<T, sbyte>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Plane<byte>(Plane<T> from)
            => new((Vector3<byte>) from.Normal, Operations.As<T, byte>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Plane<ushort>(Plane<T> from)
            => new((Vector3<ushort>) from.Normal, Operations.As<T, ushort>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Plane<short>(Plane<T> from)
            => new((Vector3<short>) from.Normal, Operations.As<T, short>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Plane<uint>(Plane<T> from)
            => new((Vector3<uint>) from.Normal, Operations.As<T, uint>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Plane<int>(Plane<T> from)
            => new((Vector3<int>) from.Normal, Operations.As<T, int>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Plane<ulong>(Plane<T> from)
            => new((Vector3<ulong>) from.Normal, Operations.As<T, ulong>(from.D));
        
        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Plane<long>(Plane<T> from)
            => new((Vector3<long>) from.Normal, Operations.As<T, long>(from.D));
    }
}
