// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;
using System.Text;
#if BTEC_INTRINSICS
using System.Numerics;
#endif
#if INTRINSICS 
using System.Runtime.Intrinsics;
#endif

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Vector4<T> : IEquatable<Vector4<T>>, IFormattable where T : unmanaged, IFormattable
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
        public T X;
        public T Y;
        public T Z;
        public T W;

        public Vector4(T value) : this(value, value, value, value)
        { }

        public Vector4(T x, T y, T z, T w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public Vector4(Vector2<T> xyzw) : this(xyzw, xyzw)
        { }
        
        
        public Vector4(Vector2<T> xy, Vector2<T> zw) : this(xy.X, xy.Y, zw.X, zw.Y)
        { }

        public Vector4(Vector3<T> xyz, T w = default) : this(xyz.X, xyz.Y, xyz.Z, w)
        { }

        public Vector4(Vector4<T> xyzw)
        {
            this = xyzw;
        }

        public T this[int index]
        {
            readonly get
            {
                if (index == 0)
                    return X;
                
                if (index == 1)
                    return Y;
                
                if (index == 2)
                    return Z;

                if (index == 3)
                    return W;
                
                Scalar<T>.ThrowIndexOutOfRange();
                return default;
            }
            set
            {
                if (index == 0)
                    X = value;
                else if (index == 1)
                    Y = value;
                else if (index == 2)
                    Z = value;
                else if (index == 3)
                    W = value;
                else
                    Scalar<T>.ThrowIndexOutOfRange();
            }
        }

        public T Length => Scalar<T>.SquareRoot(LengthSquared);

        public T LengthSquared => Dot(this, this);

        public Vector4<T> Normalized()
        {
            return Normalize(this);
        }

        public void Normalize()
        {
            this = Normalized();
        }

        public static Vector4<T> Add(Vector4<T> a, Vector4<T> b)
        {
            return new Vector4<T>
            (
                Scalar<T>.Add(a.X, b.X),
                Scalar<T>.Add(a.Y, b.Y),
                Scalar<T>.Add(a.Z, b.Z),
                Scalar<T>.Add(a.W, b.W)
            );
        }

        public static void Add(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            result = Add(a, b);
        }

        public static Vector4<T> Subtract(Vector4<T> a, Vector4<T> b)
        {
            return new Vector4<T>
            (
                Scalar<T>.Subtract(a.X, b.X),
                Scalar<T>.Subtract(a.Y, b.Y),
                Scalar<T>.Subtract(a.Z, b.Z),
                Scalar<T>.Subtract(a.W, b.W)
            );
        }

        public static void Subtract(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            result = Subtract(a, b);
        }

        public static Vector4<T> Multiply(Vector4<T> vector, T scale)
        {
            return new Vector4<T>
            (
                Scalar<T>.Multiply(vector.X, scale),
                Scalar<T>.Multiply(vector.Y, scale),
                Scalar<T>.Multiply(vector.Z, scale),
                Scalar<T>.Multiply(vector.W, scale)
            );
        }

        public static void Multiply(ref Vector4<T> vector, T scale, out Vector4<T> result)
        {
            result = Multiply(vector, scale);
        }

        public static Vector4<T> Multiply(Vector4<T> vector, Vector4<T> scale)
        {
            return new Vector4<T>
            (
                Scalar<T>.Multiply(vector.X, scale.X),
                Scalar<T>.Multiply(vector.Y, scale.Y),
                Scalar<T>.Multiply(vector.Z, scale.Z),
                Scalar<T>.Multiply(vector.W, scale.W)
            );
        }

        public static void Multiply(ref Vector4<T> vector, ref Vector4<T> scale, out Vector4<T> result)
        {
            result = Multiply(vector, scale);
        }

        public static Vector4<T> Divide(Vector4<T> vector, T scale)
        {
            return new Vector4<T>
            (
                Scalar<T>.Divide(vector.X, scale),
                Scalar<T>.Divide(vector.Y, scale),
                Scalar<T>.Divide(vector.Z, scale),
                Scalar<T>.Divide(vector.W, scale)
            );
        }

        public static void Divide(ref Vector4<T> vector, T scale, out Vector4<T> result)
        {
            result = Divide(vector, scale);
        }

        public static Vector4<T> Divide(Vector4<T> vector, Vector4<T> scale)
        {
            return new Vector4<T>
            (
                Scalar<T>.Divide(vector.X, scale.X),
                Scalar<T>.Divide(vector.Y, scale.Y),
                Scalar<T>.Divide(vector.Z, scale.Z),
                Scalar<T>.Divide(vector.W, scale.W)
            );
        }

        public static void Divide(ref Vector4<T> vector, ref Vector4<T> scale, out Vector4<T> result)
        {
            result = Divide(vector, scale);
        }
        
        public static Vector4<T> Divide(T value, Vector4<T> scale)
        {
            return new Vector4<T>
            (
                Scalar<T>.Divide(value, scale.X),
                Scalar<T>.Divide(value, scale.Y),
                Scalar<T>.Divide(value, scale.Z),
                Scalar<T>.Divide(value, scale.W)
            );
        }

        public static void Divide(T value, ref Vector4<T> scale, out Vector4<T> result)
        {
            result = Divide(value, scale);
        }

        public static Vector4<T> ComponentMin(Vector4<T> a, Vector4<T> b)
        {
            return new Vector4<T>
            (
                Scalar<T>.Min(a.X, b.X),
                Scalar<T>.Min(a.Y, b.Y),
                Scalar<T>.Min(a.Z, b.Z),
                Scalar<T>.Min(a.W, b.W)
            );
        }

        public static void ComponentMin(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            result = ComponentMin(a, b);
        }

        public static Vector4<T> ComponentMax(Vector4<T> a, Vector4<T> b)
        {
            return new Vector4<T>
            (
                Scalar<T>.Max(a.X, b.X),
                Scalar<T>.Max(a.Y, b.Y),
                Scalar<T>.Max(a.Z, b.Z),
                Scalar<T>.Max(a.W, b.W)
            );
        }

        public static void ComponentMax(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            result = ComponentMax(a, b);
        }

        public static Vector4<T> MagnitudeMin(Vector4<T> left, Vector4<T> right)
        {
            if (Scalar<T>.Larger(left.LengthSquared, right.LengthSquared))
                return right;
            return left;
        }

        public static void MagnitudeMin(ref Vector4<T> left, ref Vector4<T> right, out Vector4<T> result)
        {
            result = MagnitudeMin(left, right);
        }

        public static Vector4<T> MagnitudeMax(Vector4<T> left, Vector4<T> right)
        {
            if (Scalar<T>.Larger(left.LengthSquared, right.LengthSquared))
                return left;
            return right;
        }

        public static void MagnitudeMax(ref Vector4<T> left, ref Vector4<T> right, out Vector4<T> result)
        {
            result = MagnitudeMax(left, right);
        }

        public static Vector4<T> Clamp(Vector4<T> vec, Vector4<T> min, Vector4<T> max)
        {
            return new Vector4<T>
            (
                Scalar<T>.Clamp(vec.X, min.X, max.X),
                Scalar<T>.Clamp(vec.Y, min.Y, max.Y),
                Scalar<T>.Clamp(vec.Z, min.Z, max.Z),
                Scalar<T>.Clamp(vec.W, min.W, max.W)
            );
        }

        public static void Clamp
        (
            ref Vector4<T> vec,
            ref Vector4<T> min,
            ref Vector4<T> max,
            out Vector4<T> result
        )
        {
            result = Clamp(vec, min, max);
        }

        public static Vector4<T> Normalize(Vector4<T> vec)
        {
            return vec / vec.Length;
        }

        public static void Normalize(ref Vector4<T> vec, out Vector4<T> result)
        {
            result = Normalize(vec);
        }

        public static T Dot(Vector4<T> left, Vector4<T> right)
        {
            var mul = left * right;
            return Scalar<T>.Add(Scalar<T>.Add(mul.X, mul.Y), Scalar<T>.Add(mul.Z, mul.W));
        }

        public static void Dot(ref Vector4<T> left, ref Vector4<T> right, out T result)
        {
            result = Dot(left, right);
        }

        public static Vector4<T> Lerp(Vector4<T> a, Vector4<T> b, T blend)
        {
            return a * Scalar<T>.Subtract(Scalar<T>.One, blend) + b * blend;
        }

        public static void Lerp(ref Vector4<T> a, ref Vector4<T> b, T blend, out Vector4<T> result)
        {
            result = Lerp(a, b, blend);
        }

        public static Vector4<T> BaryCentric(Vector4<T> a, Vector4<T> b, Vector4<T> c, T u, T v)
        {
            return a * Scalar<T>.Subtract(Scalar<T>.One, u) * (Scalar<T>.Subtract(Scalar<T>.One, v))
                   + b * u * (Scalar<T>.Subtract(Scalar<T>.One, v))
                   + c * Scalar<T>.Subtract(Scalar<T>.One, u) * v;
        }

        public static void BaryCentric
        (
            ref Vector4<T> a,
            ref Vector4<T> b,
            ref Vector4<T> c,
            T u,
            T v,
            out Vector4<T> result
        )
        {
            result = BaryCentric(a, b, c, u, v);
        }

        public static Vector4<T> Transform(Vector4<T> vec, Matrix4X4<T> mat)
        {
            return new Vector4<T>(
                Scalar<T>.Add(Scalar<T>.Multiply(vec.X, mat.M11), Scalar<T>.Add(Scalar<T>.Multiply(vec.Y, mat.M21), Scalar<T>.Multiply(vec.Z, mat.M31))),
                Scalar<T>.Add(Scalar<T>.Multiply(vec.X, mat.M12), Scalar<T>.Add(Scalar<T>.Multiply(vec.Y, mat.M22), Scalar<T>.Multiply(vec.Z, mat.M32))),
                Scalar<T>.Add(Scalar<T>.Multiply(vec.X, mat.M13), Scalar<T>.Add(Scalar<T>.Multiply(vec.Y, mat.M23), Scalar<T>.Multiply(vec.Z, mat.M33))),
                Scalar<T>.Add(Scalar<T>.Multiply(vec.X, mat.M14), Scalar<T>.Add(Scalar<T>.Multiply(vec.Y, mat.M24), Scalar<T>.Multiply(vec.Z, mat.M34))));
        }

        public static void Transform(ref Vector4<T> vec, ref Matrix4X4<T> mat, out Vector4<T> result)
        {
            result = Transform(vec, mat);
        }

        public static Vector4<T> Transform(Vector4<T> vec, Quaternion<T> quat)
        {
            // note that this is the same as Vector3<T> + the fourth element is just kept
            // for performance reason copying is chosen over casting
            var x2 = Scalar<T>.Add(quat.X, quat.X);
            var y2 = Scalar<T>.Add(quat.Y, quat.Y);
            var z2 = Scalar<T>.Add(quat.Z, quat.Z);

            var wx2 = Scalar<T>.Multiply(quat.W, x2);
            var wy2 = Scalar<T>.Multiply(quat.W, y2);
            var wz2 = Scalar<T>.Multiply(quat.W, z2);
            var xx2 = Scalar<T>.Multiply(quat.X, x2);
            var xy2 = Scalar<T>.Multiply(quat.X, y2);
            var xz2 = Scalar<T>.Multiply(quat.X, z2);
            var yy2 = Scalar<T>.Multiply(quat.Y, y2);
            var yz2 = Scalar<T>.Multiply(quat.Y, z2);
            var zz2 = Scalar<T>.Multiply(quat.Z, z2);

            return new Vector4<T>
            (
                Scalar<T>.Add
                (
                    Scalar<T>.Multiply(vec.X, (Scalar<T>.Subtract(Scalar<T>.One, Scalar<T>.Subtract(yy2, zz2)))),
                    Scalar<T>.Add
                    (
                        Scalar<T>.Multiply(vec.Y, Scalar<T>.Subtract(xy2, wz2)),
                        Scalar<T>.Multiply(vec.Z, (Scalar<T>.Add(xz2, wy2)))
                    )
                ),
                Scalar<T>.Add
                (
                    Scalar<T>.Multiply(vec.X, (Scalar<T>.Add(xy2, wz2))),
                    Scalar<T>.Add
                    (
                        Scalar<T>.Multiply(vec.Y, Scalar<T>.Subtract(Scalar<T>.One, Scalar<T>.Subtract(xx2, zz2))),
                        Scalar<T>.Multiply(vec.Z, Scalar<T>.Subtract(yz2, wx2))
                    )
                ),
                Scalar<T>.Add
                (
                    Scalar<T>.Multiply(vec.X, Scalar<T>.Subtract(xz2, wy2)),
                    Scalar<T>.Add
                    (
                        Scalar<T>.Multiply(vec.Y, (Scalar<T>.Add(yz2, wx2))),
                        Scalar<T>.Multiply(vec.Z, Scalar<T>.Subtract(Scalar<T>.One, Scalar<T>.Subtract(xx2, yy2)))
                    )
                ),
                vec.W
            );
        }

        public static void Transform(ref Vector4<T> vec, ref Quaternion<T> quat, out Vector4<T> result)
        {
            result = Transform(vec, quat);
        }
        
        public static Vector4<T> Negate(Vector4<T> vec)
        {
            return new Vector4<T>(Scalar<T>.Negate(vec.X), Scalar<T>.Negate(vec.Y), Scalar<T>.Negate(vec.Z), Scalar<T>.Negate(vec.W));
        }

        public static void Negate(ref Vector4<T> vec, out Vector4<T> result)
        {
            result = Negate(vec);
        }

        public static Vector4<T> operator +(Vector4<T> left, Vector4<T> right)
        {
            return Add(left, right);
        }

        public static Vector4<T> operator -(Vector4<T> left, Vector4<T> right)
        {
            return Subtract(left, right);
        }

        public static Vector4<T> operator -(Vector4<T> vec)
        {
            return Negate(vec);
        }

        public static Vector4<T> operator *(Vector4<T> vec, T scale)
        {
            return Multiply(vec, scale);
        }

        public static Vector4<T> operator *(T scale, Vector4<T> vec)
        {
            return Multiply(vec, scale);
        }

        public static Vector4<T> operator *(Vector4<T> vec, Vector4<T> scale)
        {
            return Multiply(vec, scale);
        }

        public static Vector4<T> operator *(Vector4<T> vec, Matrix4X4<T> mat)
        {
            return Transform(vec, mat);
        }

        public static Vector4<T> operator *(Matrix4X4<T> mat, Vector4<T> vec)
        {
            return Transform(vec, mat);
        }
        
        public static Vector4<T> operator *(Vector4<T> vec, Quaternion<T> quat)
        {
            return Transform(vec, quat);
        }

        public static Vector4<T> operator *(Quaternion<T> quat, Vector4<T> vec)
        {
            return Transform(vec, quat);
        }

        public static Vector4<T> operator /(Vector4<T> vec, T scale)
        {
            return Divide(vec, scale);
        }

        public static Vector4<T> operator /(T value, Vector4<T> scale)
        {
            return Divide(value, scale);
        }

        public static bool operator ==(Vector4<T> left, Vector4<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector4<T> left, Vector4<T> right)
        {
            return !(left == right);
        }

        public static implicit operator Vector4<T>((T X, T Y, T Z, T W) values)
        {
            return new Vector4<T>(values.X, values.Y, values.Z, values.W);
        }

        public override string ToString() => ToString("G");

        public string ToString(string format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string format, IFormatProvider formatProvider)
        {
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(((IFormattable)X).ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(((IFormattable)Y).ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(((IFormattable)Z).ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(((IFormattable)W).ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }

        public override int GetHashCode()
        {
#if NETSTANDARD2_1
            return HashCode.Combine(X, Y, Z, W);
#else
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
#endif
        }

        public override bool Equals(object obj) => obj is Vector4<T> vec && this.Equals(vec);

        public bool Equals(Vector4<T> other)
        {
            return Scalar<T>.Equal(X, other.X)
                   && Scalar<T>.Equal(Y, other.Y)
                   && Scalar<T>.Equal(Z, other.Z)
                   && Scalar<T>.Equal(W, other.W);
        }

        public void Deconstruct(out T x, out T y, out T z, out T w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
#if INTRINSICS 
        public readonly Vector64<T> AsVector64()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector64<T>)(object)Vector64.Create((byte)(object)X, (byte)(object)Y, (byte)(object)Z, (byte)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector64<T>)(object)Vector64.Create((sbyte)(object)X, (sbyte)(object)Y, (sbyte)(object)Z, (sbyte)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector64<T>)(object)Vector64.Create((ushort)(object)X, (ushort)(object)Y, (ushort)(object)Z, (ushort)(object)W);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector64<T>)(object)Vector64.Create((short)(object)X, (short)(object)Y, (short)(object)Z, (short)(object)W);
            }

            if (typeof(T) == typeof(uint) || 
                typeof(T) == typeof(int) ||
                typeof(T) == typeof(Half) ||
                typeof(T) == typeof(float))
            {
                Scalar<T>.ThrowNotSupportedByUnderlying();
            }
            
            Scalar<T>.ThrowInvalidType();
            return default;
        }

        public readonly Vector128<T> AsVector128()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector128<T>)(object)Vector128.Create((byte)(object)X, (byte)(object)Y, (byte)(object)Z, (byte)(object)W, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector128<T>)(object)Vector128.Create((sbyte)(object)X, (sbyte)(object)Y, (sbyte)(object)Z, (sbyte)(object)W, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector128<T>)(object)Vector128.Create((ushort)(object)X, (ushort)(object)Y, (ushort)(object)Z, (ushort)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector128<T>)(object)Vector128.Create((short)(object)X, (short)(object)Y, (short)(object)Z, (short)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector128<T>)(object)Vector128.Create((uint)(object)X, (uint)(object)Y, (uint)(object)Z, (uint)(object)W);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector128<T>)(object)Vector128.Create((int)(object)X, (int)(object)Y, (int)(object)Z, (int)(object)W);
            }

            if (typeof(T) == typeof(ulong)||typeof(T) == typeof(long) || typeof(T) == typeof(Half) || typeof(T) == typeof(double))
            {
                Scalar<T>.ThrowNotSupportedByUnderlying();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector128<T>)(object)Vector128.Create((float)(object)X, (float)(object)Y, (float)(object)Z, (float)(object)W);
            }

            Scalar<T>.ThrowInvalidType();
            return default;
        }

        public readonly Vector256<T> AsVector256()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector256<T>)(object)Vector256.Create((byte)(object)X, (byte)(object)Y, (byte)(object)Z, (byte)(object)W, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector256<T>)(object)Vector256.Create((sbyte)(object)X, (sbyte)(object)Y, (sbyte)(object)Z, (sbyte)(object)W, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector256<T>)(object)Vector256.Create((ushort)(object)X, (ushort)(object)Y, (ushort)(object)Z, (ushort)(object)W, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector256<T>)(object)Vector256.Create((short)(object)X, (short)(object)Y, (short)(object)Z, (short)(object)W, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector256<T>)(object)Vector256.Create((uint)(object)X, (uint)(object)Y, (uint)(object)Z, (uint)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector256<T>)(object)Vector256.Create((int)(object)X, (int)(object)Y, (int)(object)Z, (int)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (Vector256<T>)(object)Vector256.Create((ulong)(object)X, (ulong)(object)Y, (ulong)(object)Z, (ulong)(object)W);
            }

            if (typeof(T) == typeof(long))
            {
                return (Vector256<T>)(object)Vector256.Create((long)(object)X, (long)(object)Y, (long)(object)Z, (long)(object)W);
            }

            if (typeof(T) == typeof(Half))
            {
                Scalar<T>.ThrowNotSupportedByUnderlying();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector256<T>)(object)Vector256.Create((float)(object)X, (float)(object)Y, (float)(object)Z, (float)(object)W, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(double))
            {
                return (Vector256<T>)(object)Vector256.Create((double)(object)X, (double)(object)Y, (double)(object)Z, (double)(object)W);
            }

            Scalar<T>.ThrowInvalidType();
            return default;
        }
#endif

#if BTEC_INTRINSICS
        public readonly unsafe Vector<T> AsVector()
        { 
            if (Vector<T>.Count >= 4)
            {
                Span<T> span = stackalloc T[] {X, Y, Z, W};
                var vec = new Vector<T>(span);
                return vec;
            }

            Scalar<T>.ThrowVectorTTooSmall();
            return default; // not reached
        }
#endif
    }
}
