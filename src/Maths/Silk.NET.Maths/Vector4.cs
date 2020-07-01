#region

#if BTEC_INTRINSICS
using System.Numerics;
#endif
#if INTRINSICS
using System.Runtime.Intrinsics;
#endif
using System;
using System.Globalization;
using System.Text;
using static Silk.NET.Maths.Scalar;

#endregion

namespace Silk.NET.Maths
{
    [Serializable]
    public readonly partial struct Vector4<T> : IVector4<T, Vector4<T>> where T : unmanaged, IFormattable
    {
        public static Vector4<T> UnitX => new Vector4<T>(Scalar<T>.One, default, default, default);
        public static Vector4<T> UnitY => new Vector4<T>(default, Scalar<T>.One, default, default);
        public static Vector4<T> UnitZ => new Vector4<T>(default, default, Scalar<T>.One, default);
        public static Vector4<T> UnitW => new Vector4<T>(default, default, default, Scalar<T>.One);
        public static Vector4<T> Zero => default;
        public static Vector4<T> One => new Vector4<T>(Scalar<T>.One);
        public static Vector4<T> PositiveInfinity => new Vector4<T>(Scalar<T>.PositiveInfinity);
        public static Vector4<T> NegativeInfinity => new Vector4<T>(Scalar<T>.NegativeInfinity);
        public static unsafe int SizeInBytes => sizeof(Vector4<T>);

        public T X { get; }
        public T Y { get; }
        public T Z { get; }
        public T W { get; }

        public Vector4(T value) : this(value, value, value, value) { }

        public Vector4(T x, T y, T z, T w) => (X, Y, Z, W) = (x, y, z, w);

        public Vector4(Vector2<T> xyzw) : this(xyzw, xyzw) { }


        public Vector4(Vector2<T> xy, Vector2<T> zw) : this(xy.X, xy.Y, zw.X, zw.Y) { }

        public Vector4(Vector3<T> xyz, T w = default) : this(xyz.X, xyz.Y, xyz.Z, w) { }

        public Vector4(Vector4<T> xyzw) => this = xyzw;

        public Vector4<T> WithX(T x) => new Vector4<T>(x, Y, Z, W);

        public Vector4<T> WithY(T y) => new Vector4<T>(X, y, Z, W);

        public Vector4<T> WithZ(T z) => new Vector4<T>(X, Y, z, W);

        public Vector4<T> WithW(T w) => new Vector4<T>(X, Y, Y, w);

        public T this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return X;
                }

                if (index == 1)
                {
                    return Y;
                }

                if (index == 2)
                {
                    return Z;
                }

                if (index == 3)
                {
                    return W;
                }

                ThrowIndexOutOfRange();
                return default;
            }
        }
        
        public T Length => SquareRoot(LengthSquared);

        public T LengthSquared => Dot(this, this);

        public Vector4<T> Normalized() => Normalize(this);

        public static Vector4<T> Add(Vector4<T> a, Vector4<T> b)
            => new Vector4<T>(Scalar.Add(a.X, b.X), Scalar.Add(a.Y, b.Y), Scalar.Add(a.Z, b.Z), Scalar.Add(a.W, b.W));

        public static void Add(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result) => result = Add(a, b);

        [GenerateReferenceFunction]
        public static Vector4<T> Subtract(Vector4<T> a, Vector4<T> b)
            =>
                new Vector4<T>
                    (
                    Scalar.Subtract(a.X, b.X), Scalar.Subtract(a.Y, b.Y), Scalar.Subtract(a.Z, b.Z),
                    Scalar.Subtract(a.W, b.W));

        [GenerateReferenceFunction]
        public static Vector4<T> Multiply(Vector4<T> vector, T scale)
            =>
                new Vector4<T>
                    (
                    Scalar.Multiply(vector.X, scale), Scalar.Multiply(vector.Y, scale), Scalar.Multiply(vector.Z, scale),
                    Scalar.Multiply(vector.W, scale));

        [GenerateReferenceFunction]
        public static Vector4<T> Multiply(Vector4<T> vector, Vector4<T> scale)
            =>
                new Vector4<T>
                    (
                    Scalar.Multiply(vector.X, scale.X), Scalar.Multiply(vector.Y, scale.Y),
                    Scalar.Multiply(vector.Z, scale.Z), Scalar.Multiply(vector.W, scale.W));

        [GenerateReferenceFunction]
        public static Vector4<T> Divide(Vector4<T> vector, T scale)
            =>
                new Vector4<T>
                    (
                    Scalar.Divide(vector.X, scale), Scalar.Divide(vector.Y, scale), Scalar.Divide(vector.Z, scale),
                    Scalar.Divide(vector.W, scale));

        [GenerateReferenceFunction]
        public static Vector4<T> Divide(Vector4<T> vector, Vector4<T> scale)
            =>
                new Vector4<T>
                    (
                    Scalar.Divide(vector.X, scale.X), Scalar.Divide(vector.Y, scale.Y), Scalar.Divide(vector.Z, scale.Z),
                    Scalar.Divide(vector.W, scale.W));

        [GenerateReferenceFunction]
        public static Vector4<T> Divide(T value, Vector4<T> scale)
            =>
                new Vector4<T>
                    (
                    Scalar.Divide(value, scale.X), Scalar.Divide(value, scale.Y), Scalar.Divide(value, scale.Z),
                    Scalar.Divide(value, scale.W));

        [GenerateReferenceFunction]
        public static Vector4<T> ComponentMin(Vector4<T> a, Vector4<T> b)
            => new Vector4<T>(Min(a.X, b.X), Min(a.Y, b.Y), Min(a.Z, b.Z), Min(a.W, b.W));

        [GenerateReferenceFunction]
        public static Vector4<T> ComponentMax(Vector4<T> a, Vector4<T> b)
            => new Vector4<T>(Max(a.X, b.X), Max(a.Y, b.Y), Max(a.Z, b.Z), Max(a.W, b.W));

        [GenerateReferenceFunction]
        public static Vector4<T> MagnitudeMin(Vector4<T> left, Vector4<T> right)
        {
            if (Larger(left.LengthSquared, right.LengthSquared))
            {
                return right;
            }

            return left;
        }

        [GenerateReferenceFunction]
        public static Vector4<T> MagnitudeMax(Vector4<T> left, Vector4<T> right)
        {
            if (Larger(left.LengthSquared, right.LengthSquared))
            {
                return left;
            }

            return right;
        }

        [GenerateReferenceFunction]
        public static Vector4<T> Clamp(Vector4<T> vec, Vector4<T> min, Vector4<T> max)
            =>
                new Vector4<T>
                    (
                    Scalar.Clamp(vec.X, min.X, max.X), Scalar.Clamp(vec.Y, min.Y, max.Y),
                    Scalar.Clamp(vec.Z, min.Z, max.Z), Scalar.Clamp(vec.W, min.W, max.W));

        [GenerateReferenceFunction]
        public static Vector4<T> Normalize(Vector4<T> vec) => vec / vec.Length;

        [GenerateReferenceFunction]
        public static T Dot(Vector4<T> left, Vector4<T> right)
        {
            var mul = left * right;
            return Scalar.Add(Scalar.Add(mul.X, mul.Y), Scalar.Add(mul.Z, mul.W));
        }

        [GenerateReferenceFunction]
        public static Vector4<T> Lerp(Vector4<T> a, Vector4<T> b, T blend)
            => a * Scalar.Subtract(Scalar<T>.One, blend) + b * blend;

        [GenerateReferenceFunction]
        public static Vector4<T> BaryCentric(Vector4<T> a, Vector4<T> b, Vector4<T> c, T u, T v)
            =>
                a * Scalar.Subtract(Scalar<T>.One, u) * Scalar.Subtract(Scalar<T>.One, v) +
                b * u * Scalar.Subtract(Scalar<T>.One, v) + c * Scalar.Subtract(Scalar<T>.One, u) * v;

        [GenerateReferenceFunction]
        public static Vector4<T> Transform(Vector4<T> vec, Matrix4X4<T> mat)
            =>
                new Vector4<T>
                    (
                    Scalar.Add
                        (
                            Scalar.Multiply(vec.X, mat.M11),
                            Scalar.Add(Scalar.Multiply(vec.Y, mat.M21), Scalar.Multiply(vec.Z, mat.M31))),
                    Scalar.Add
                        (
                            Scalar.Multiply(vec.X, mat.M12),
                            Scalar.Add(Scalar.Multiply(vec.Y, mat.M22), Scalar.Multiply(vec.Z, mat.M32))),
                    Scalar.Add
                        (
                            Scalar.Multiply(vec.X, mat.M13),
                            Scalar.Add(Scalar.Multiply(vec.Y, mat.M23), Scalar.Multiply(vec.Z, mat.M33))),
                    Scalar.Add
                        (
                            Scalar.Multiply(vec.X, mat.M14),
                            Scalar.Add(Scalar.Multiply(vec.Y, mat.M24), Scalar.Multiply(vec.Z, mat.M34))));

        [GenerateReferenceFunction]
        public static Vector4<T> Transform(Vector4<T> vec, Quaternion<T> quat)
        {
            // note that this is the same as Vector3<T> + the fourth element is just kept
            // for performance reason copying is chosen over casting
            var x2 = Scalar.Add(quat.X, quat.X);
            var y2 = Scalar.Add(quat.Y, quat.Y);
            var z2 = Scalar.Add(quat.Z, quat.Z);

            var wx2 = Scalar.Multiply(quat.W, x2);
            var wy2 = Scalar.Multiply(quat.W, y2);
            var wz2 = Scalar.Multiply(quat.W, z2);
            var xx2 = Scalar.Multiply(quat.X, x2);
            var xy2 = Scalar.Multiply(quat.X, y2);
            var xz2 = Scalar.Multiply(quat.X, z2);
            var yy2 = Scalar.Multiply(quat.Y, y2);
            var yz2 = Scalar.Multiply(quat.Y, z2);
            var zz2 = Scalar.Multiply(quat.Z, z2);

            return new Vector4<T>
                (
                Scalar.Add
                    (
                        Scalar.Multiply(vec.X, Scalar.Subtract(Scalar<T>.One, Scalar.Subtract(yy2, zz2))),
                        Scalar.Add
                            (
                                Scalar.Multiply(vec.Y, Scalar.Subtract(xy2, wz2)),
                                Scalar.Multiply(vec.Z, Scalar.Add(xz2, wy2)))),
                Scalar.Add
                    (
                        Scalar.Multiply(vec.X, Scalar.Add(xy2, wz2)),
                        Scalar.Add
                            (
                                Scalar.Multiply(vec.Y, Scalar.Subtract(Scalar<T>.One, Scalar.Subtract(xx2, zz2))),
                                Scalar.Multiply(vec.Z, Scalar.Subtract(yz2, wx2)))),
                Scalar.Add
                    (
                        Scalar.Multiply(vec.X, Scalar.Subtract(xz2, wy2)),
                        Scalar.Add
                            (
                                Scalar.Multiply(vec.Y, Scalar.Add(yz2, wx2)),
                                Scalar.Multiply(vec.Z, Scalar.Subtract(Scalar<T>.One, Scalar.Subtract(xx2, yy2))))),
                vec.W);
        }

        [GenerateReferenceFunction]
        public static Vector4<T> Negate(Vector4<T> vec)
            => new Vector4<T>(Scalar.Negate(vec.X), Scalar.Negate(vec.Y), Scalar.Negate(vec.Z), Scalar.Negate(vec.W));
        
        [GenerateReferenceFunction]
        public static Vector4<T> Cos(Vector4<T> vector)
            => new Vector4<T>(Scalar.Cos(vector.X), Scalar.Cos(vector.Y), Scalar.Cos(vector.Z), Scalar.Cos(vector.W));

        [GenerateReferenceFunction]
        public static Vector4<T> Sin(Vector4<T> vector)
            => new Vector4<T>(Scalar.Sin(vector.X), Scalar.Sin(vector.Y), Scalar.Sin(vector.Z), Scalar.Sin(vector.W));

        public static Vector4<T> operator +(Vector4<T> left, Vector4<T> right) => Add(left, right);

        public static Vector4<T> operator -(Vector4<T> left, Vector4<T> right) => Subtract(left, right);

        public static Vector4<T> operator -(Vector4<T> vec) => Negate(vec);

        public static Vector4<T> operator *(Vector4<T> vec, T scale) => Multiply(vec, scale);

        public static Vector4<T> operator *(T scale, Vector4<T> vec) => Multiply(vec, scale);

        public static Vector4<T> operator *(Vector4<T> vec, Vector4<T> scale) => Multiply(vec, scale);

        public static Vector4<T> operator *(Vector4<T> vec, Matrix4X4<T> mat) => Transform(vec, mat);

        public static Vector4<T> operator *(Matrix4X4<T> mat, Vector4<T> vec) => Transform(vec, mat);

        public static Vector4<T> operator *(Vector4<T> vec, Quaternion<T> quat) => Transform(vec, quat);

        public static Vector4<T> operator *(Quaternion<T> quat, Vector4<T> vec) => Transform(vec, quat);

        public static Vector4<T> operator /(Vector4<T> vec, Vector4<T> scale) => Divide(vec, scale);

        public static Vector4<T> operator /(Vector4<T> vec, T scale) => Divide(vec, scale);

        public static Vector4<T> operator /(T value, Vector4<T> scale) => Divide(value, scale);

        public static bool operator ==(Vector4<T> left, Vector4<T> right) => left.Equals(right);

        public static bool operator !=(Vector4<T> left, Vector4<T> right) => !(left == right);

        public static implicit operator Vector4<T>((T X, T Y, T Z, T W) values)
            => new Vector4<T>(values.X, values.Y, values.Z, values.W);

        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            var sb = new StringBuilder();
            var separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Z.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(W.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }

        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);

        public override bool Equals(object? obj) => obj is Vector4<T> vec && Equals(vec);

        public bool Equals(Vector4<T> other)
            => Equal(X, other.X) && Equal(Y, other.Y) && Equal(Z, other.Z) && Equal(W, other.W);

        public void Deconstruct(out T x, out T y, out T z, out T w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }

#if INTRINSICS
        public Vector64<T> AsVector64()
        {
            if (typeof(T) == typeof(byte))
            {
                return
                    (Vector64<T>)
                        (object)
                            Vector64.Create
                                ((byte) (object) X, (byte) (object) Y, (byte) (object) Z, (byte) (object) W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return
                    (Vector64<T>)
                        (object)
                            Vector64.Create
                                (
                                    (sbyte) (object) X, (sbyte) (object) Y, (sbyte) (object) Z, (sbyte) (object) W, 0, 0,
                                    0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return
                    (Vector64<T>)
                        (object)
                            Vector64.Create
                                ((ushort) (object) X, (ushort) (object) Y, (ushort) (object) Z, (ushort) (object) W);
            }

            if (typeof(T) == typeof(short))
            {
                return
                    (Vector64<T>)
                        (object)
                            Vector64.Create
                                ((short) (object) X, (short) (object) Y, (short) (object) Z, (short) (object) W);
            }

            if (typeof(T) == typeof(uint) || typeof(T) == typeof(int) || typeof(T) == typeof(Half) ||
                typeof(T) == typeof(float))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            ThrowInvalidType();
            return default;
        }

        public Vector128<T> AsVector128()
        {
            if (typeof(T) == typeof(byte))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create
                                (
                                    (byte) (object) X, (byte) (object) Y, (byte) (object) Z, (byte) (object) W, 0, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create
                                (
                                    (sbyte) (object) X, (sbyte) (object) Y, (sbyte) (object) Z, (sbyte) (object) W, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create
                                (
                                    (ushort) (object) X, (ushort) (object) Y, (ushort) (object) Z, (ushort) (object) W,
                                    0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create
                                (
                                    (short) (object) X, (short) (object) Y, (short) (object) Z, (short) (object) W, 0, 0,
                                    0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create((uint) (object) X, (uint) (object) Y, (uint) (object) Z, (uint) (object) W);
            }

            if (typeof(T) == typeof(int))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create((int) (object) X, (int) (object) Y, (int) (object) Z, (int) (object) W);
            }

            if (typeof(T) == typeof(ulong) || typeof(T) == typeof(long) || typeof(T) == typeof(Half) ||
                typeof(T) == typeof(double))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            if (typeof(T) == typeof(float))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create
                                ((float) (object) X, (float) (object) Y, (float) (object) Z, (float) (object) W);
            }

            ThrowInvalidType();
            return default;
        }

        public Vector256<T> AsVector256()
        {
            if (typeof(T) == typeof(byte))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                (
                                    (byte) (object) X, (byte) (object) Y, (byte) (object) Z, (byte) (object) W, 0, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                (
                                    (sbyte) (object) X, (sbyte) (object) Y, (sbyte) (object) Z, (sbyte) (object) W, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                (
                                    (ushort) (object) X, (ushort) (object) Y, (ushort) (object) Z, (ushort) (object) W,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                (
                                    (short) (object) X, (short) (object) Y, (short) (object) Z, (short) (object) W, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                ((uint) (object) X, (uint) (object) Y, (uint) (object) Z, (uint) (object) W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(int))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                ((int) (object) X, (int) (object) Y, (int) (object) Z, (int) (object) W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ulong))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                ((ulong) (object) X, (ulong) (object) Y, (ulong) (object) Z, (ulong) (object) W);
            }

            if (typeof(T) == typeof(long))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create((long) (object) X, (long) (object) Y, (long) (object) Z, (long) (object) W);
            }

            if (typeof(T) == typeof(Half))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            if (typeof(T) == typeof(float))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                (
                                    (float) (object) X, (float) (object) Y, (float) (object) Z, (float) (object) W, 0, 0,
                                    0, 0);
            }

            if (typeof(T) == typeof(double))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                ((double) (object) X, (double) (object) Y, (double) (object) Z, (double) (object) W);
            }

            ThrowInvalidType();
            return default;
        }
#endif

#if BTEC_INTRINSICS
        // @formatter:off
        public unsafe Vector<T> AsVector()
        {
            if (Vector<T>.Count >= 4)
            {
                Span<T> span = stackalloc T[] {X, Y, Z, W};
                var vec = new Vector<T>(span);
                return vec;
            }

            ThrowVectorTTooSmall();
            return default; // not reached
        }
        // @formatter:on
#endif
    }
}