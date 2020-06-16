// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
#if INTRINSICS
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Silk.NET.Maths
{
    /* Note: The following patterns are used throughout the code here and are described here
    *
    * PATTERN:
    *    if (typeof(T) == typeof(int)) { ... }
    *    else if (typeof(T) == typeof(float)) { ... }
     *   ...
    * EXPLANATION:
    *    At runtime, each instantiation of Vector2<T> will be type-specific, and each of these typeof blocks will be eliminated,
    *    as typeof(T) is a (JIT) compile-time constant for each instantiation. This design was chosen to eliminate any overhead from
    *    delegates and other patterns.
    */
        
    [Serializable]
    public struct Vector2<T> : IEquatable<Vector2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static Vector2<T> UnitX => new Vector2<T>(Scalar<T>.One, default);

        public static Vector2<T> UnitY => new Vector2<T>(default, Scalar<T>.One);

        public static Vector2<T> Zero => default;

        public static Vector2<T> One => new Vector2<T>(Scalar<T>.One);

        public static Vector2<T> PositiveInfinity => new Vector2<T>(Scalar<T>.PositiveInfinity);

        public static Vector2<T> NegativeInfinity => new Vector2<T>(Scalar<T>.NegativeInfinity);

        public static unsafe int SizeInBytes => sizeof(Vector2<T>);
        public T X;
        public T Y;

        public Vector2(T value) : this(value, value)
        { }

        public Vector2(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T this[int index]
        {
            readonly get
            {
                if (index == 0)
                {
                    return X;
                }

                if (index == 1)
                {
                    return Y;
                }

                Scalar<T>.ThrowIndexOutOfRange();
                return default;
            }
            set
            {
                if (index == 0)
                {
                    X = value;
                }
                else if (index == 1)
                {
                    Y = value;
                }
                else
                {
                    Scalar<T>.ThrowIndexOutOfRange();
                }
            }
        }

        public readonly T Length => Scalar<T>.SquareRoot(LengthSquared);

        public readonly T LengthSquared => Dot(this, this);

        public readonly Vector2<T> PerpendicularRight => new Vector2<T>(Y, Scalar<T>.Negate(X));

        public readonly Vector2<T> PerpendicularLeft => new Vector2<T>(Scalar<T>.Negate(Y), X);

        public readonly Vector2<T> Normalized()
        {
            return Normalize(this);
        }

        public void Normalize()
        {
            this = Normalize(this);
        }

        public static Vector2<T> Add(Vector2<T> a, Vector2<T> b)
        {
            return new Vector2<T>(Scalar<T>.Add(a.X, b.X), Scalar<T>.Add(a.Y, b.Y));
        }

        public static void Add(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            result = Add(a, b);
        }

        public static Vector2<T> Subtract(Vector2<T> a, Vector2<T> b)
        {
            return new Vector2<T>(Scalar<T>.Subtract(a.X, b.X), Scalar<T>.Subtract(a.Y, b.Y));
        }

        public static void Subtract(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            result = Subtract(a, b);
        }

        public static Vector2<T> Multiply(Vector2<T> vector, T scale)
        {
            return new Vector2<T>(Scalar<T>.Multiply(vector.X, scale), Scalar<T>.Multiply(vector.Y, scale));
        }

        public static void Multiply(ref Vector2<T> vector, T scale, out Vector2<T> result)
        {
            result = Multiply(vector, scale);
        }

        public static Vector2<T> Multiply(Vector2<T> vector, Vector2<T> scale)
        {
            return new Vector2<T>(Scalar<T>.Multiply(vector.X, scale.X), Scalar<T>.Multiply(vector.Y, scale.Y));
        }

        public static void Multiply(ref Vector2<T> vector, ref Vector2<T> scale, out Vector2<T> result)
        {
            result = Multiply(vector, scale);
        }

        public static Vector2<T> Divide(Vector2<T> vector, T scale)
        {
            return new Vector2<T>(Scalar<T>.Divide(vector.X, scale), Scalar<T>.Divide(vector.Y, scale));
        }

        public static void Divide(ref Vector2<T> vector, T scale, out Vector2<T> result)
        {
            result = Divide(vector, scale);
        }

        public static Vector2<T> Divide(Vector2<T> vector, Vector2<T> scale)
        {
            return new Vector2<T>(Scalar<T>.Divide(vector.X, scale.X), Scalar<T>.Divide(vector.Y, scale.Y));
        }

        public static void Divide(ref Vector2<T> vector, ref Vector2<T> scale, out Vector2<T> result)
        {
            result = Divide(vector, scale);
        }

        public static Vector2<T> ComponentMin(Vector2<T> a, Vector2<T> b)
        {
            return new Vector2<T>(Scalar<T>.Min(a.X, b.X), Scalar<T>.Min(a.Y, b.Y));
        }

        public static void ComponentMin(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            result = ComponentMin(a, b);
        }

        public static Vector2<T> ComponentMax(Vector2<T> a, Vector2<T> b)
        {
            return new Vector2<T>(Scalar<T>.Max(a.X, b.X), Scalar<T>.Max(a.Y, b.Y));
        }

        public static void ComponentMax(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            result = ComponentMax(a, b);
        }

        public static Vector2<T> MagnitudeMin(Vector2<T> left, Vector2<T> right)
        {
            if (Scalar<T>.Larger(left.LengthSquared, right.LengthSquared))
                return right;
            return left;
        }

        public static void MagnitudeMin(ref Vector2<T> left, ref Vector2<T> right, out Vector2<T> result)
        {
            result = MagnitudeMin(left, right);
        }

        public static Vector2<T> MagnitudeMax(Vector2<T> left, Vector2<T> right)
        {
            if (Scalar<T>.Larger(left.LengthSquared, right.LengthSquared))
                return left;
            return right;
        }

        public static void MagnitudeMax(ref Vector2<T> left, ref Vector2<T> right, out Vector2<T> result)
        {
            result = MagnitudeMax(left, right);
        }

        public static Vector2<T> Clamp(Vector2<T> vec, Vector2<T> min, Vector2<T> max)
        {
            return new Vector2<T>(Scalar<T>.Clamp(vec.X, min.X, max.X), Scalar<T>.Clamp(vec.Y, min.Y, max.Y));
        }

        public static void Clamp
        (
            ref Vector2<T> vec,
            ref Vector2<T> min,
            ref Vector2<T> max,
            out Vector2<T> result
        )
        {
            result = Clamp(vec, min, max);
        }

        public static T Distance(Vector2<T> vec1, Vector2<T> vec2) => (vec1 - vec2).Length;

        public static void Distance(ref Vector2<T> vec1, ref Vector2<T> vec2, out T result)
        {
            result = Distance(vec1, vec2);
        }

        public static T DistanceSquared(Vector2<T> vec1, Vector2<T> vec2) => (vec1 - vec2).LengthSquared;

        public static void DistanceSquared(ref Vector2<T> vec1, ref Vector2<T> vec2, out T result)
        {
            result = DistanceSquared(vec1, vec2);
        }

        public static Vector2<T> Normalize(Vector2<T> vec)
        {
            return vec / vec.Length;
        }

        public static void Normalize(ref Vector2<T> vec, out Vector2<T> result)
        {
            result = Normalize(vec);
        }

        public static T Dot(Vector2<T> left, Vector2<T> right)
        {
            var mul = left * right;
            return Scalar<T>.Add(mul.X, mul.Y);
        }

        public static void Dot(ref Vector2<T> left, ref Vector2<T> right, out T result)
        {
            result = Dot(left, right);
        }

        public static T PerpDot(Vector2<T> left, Vector2<T> right)
        {
            return Scalar<T>.Subtract(Scalar<T>.Multiply(left.X, right.Y), Scalar<T>.Multiply(left.Y, right.X));
        }

        public static void PerpDot(ref Vector2<T> left, ref Vector2<T> right, out T result)
        {
            result = PerpDot(left, right);
        }

        public static Vector2<T> Lerp(Vector2<T> a, Vector2<T> b, T blend) => a * Scalar<T>.Subtract(Scalar<T>.One, blend) + b * blend;

        public static void Lerp(ref Vector2<T> a, ref Vector2<T> b, T blend, out Vector2<T> result)
        {
            result = Lerp(a, b, blend);
        }

        public static Vector2<T> BaryCentric(Vector2<T> a, Vector2<T> b, Vector2<T> c, T u, T v)
        {
            throw new NotImplementedException();
        }

        public static void BaryCentric
        (
            ref Vector2<T> a,
            ref Vector2<T> b,
            ref Vector2<T> c,
            T u,
            T v,
            out Vector2<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Transform(Vector2<T> vec, Matrix2X2<T> mat)
        {
            return new Vector2<T>(
                Scalar<T>.Add(Scalar<T>.Multiply(vec.X, mat.M11), Scalar<T>.Multiply(vec.Y, mat.M21)),
                Scalar<T>.Add(Scalar<T>.Multiply(vec.X, mat.M12), Scalar<T>.Multiply(vec.Y, mat.M22)));
        }

        public static void Transform(ref Vector2<T> vec, ref Matrix2X2<T> mat, out Vector2<T> result)
        {
            result = Transform(vec, mat);
        }

        public static Vector2<T> Transform(Vector2<T> vec, Quaternion<T> quat)
        {
            var x2 = Scalar<T>.Add(quat.X, quat.X);
            var y2 = Scalar<T>.Add(quat.Y,quat.Y);
            var z2 = Scalar<T>.Add(quat.Z, quat.Z);

            var wz2 = Scalar<T>.Multiply(quat.W, z2);
            var xx2 = Scalar<T>.Multiply(quat.X, x2);
            var xy2 = Scalar<T>.Multiply(quat.X, y2);
            var yy2 = Scalar<T>.Multiply(quat.Y, y2);
            var zz2 = Scalar<T>.Multiply(quat.Z, z2);

            return new Vector2<T>
            (
                Scalar<T>.Add
                (
                    Scalar<T>.Multiply(vec.X, Scalar<T>.Subtract(Scalar<T>.Subtract(Scalar<T>.One, yy2), zz2)),
                    Scalar<T>.Multiply(vec.Y, Scalar<T>.Subtract(xy2, wz2))
                ),
                Scalar<T>.Add
                (
                    Scalar<T>.Multiply(vec.X, Scalar<T>.Add(xy2, wz2)),
                    Scalar<T>.Multiply(vec.Y, Scalar<T>.Subtract(Scalar<T>.Subtract(Scalar<T>.One, xx2), zz2))
                )
            );
        }

        public static void Transform(ref Vector2<T> vec, ref Quaternion<T> quat, out Vector2<T> result)
        {
            result = Transform(vec, quat);
        }

        public static Vector2<T> Transform(Matrix2X2<T> mat, Vector2<T> vec)
        {
            return Transform(vec, mat);
        }

        public static void Transform(ref Matrix2X2<T> mat, ref Vector2<T> vec, out Vector2<T> result)
        {
            result = Transform(mat, vec);
        }

        public static Vector2<T> Negate(Vector2<T> vec)
        {
            return new Vector2<T>(Scalar<T>.Negate(vec.X), Scalar<T>.Negate(vec.Y));
        }

        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right)
        {
            return Add(left, right);
        }

        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right)
        {
            return Subtract(left, right);
        }

        public static Vector2<T> operator -(Vector2<T> vec)
        {
            return Negate(vec);
        }

        public static Vector2<T> operator *(Vector2<T> vec, T scale)
        {
            return Multiply(vec, scale);
        }

        public static Vector2<T> operator *(T scale, Vector2<T> vec)
        {
            return Multiply(vec, scale);
        }

        public static Vector2<T> operator *(Vector2<T> vec, Vector2<T> scale)
        {
            return Multiply(vec, scale);
        }

        public static Vector2<T> operator *(Vector2<T> vec, Matrix2X2<T> mat)
        {
            return Transform(vec, mat);
        }

        public static Vector2<T> operator *(Matrix2X2<T> mat, Vector2<T> vec)
        {
            return Transform(mat, vec);
        }

        public static Vector2<T> operator *(Quaternion<T> quat, Vector2<T> vec)
        {
            return Transform(vec, quat);
        }

        public static Vector2<T> operator /(Vector2<T> vec, T scale)
        {
            return Divide(vec, scale);
        }

        public static bool operator ==(Vector2<T> left, Vector2<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector2<T> left, Vector2<T> right)
        {
            return !(left == right);
        }

        public static implicit operator Vector2<T>((T X, T Y) values)
        {
            return new Vector2<T>(values.X, values.Y);
        }

        public override readonly string ToString() => ToString("G");

        public readonly string ToString(string format) => ToString(format, CultureInfo.CurrentCulture);

        public readonly string ToString(string format, IFormatProvider formatProvider)
        {
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }

        public override readonly int GetHashCode()
        {
#if NETSTANDARD2_1
            return HashCode.Combine(X, Y);
#else
            return X.GetHashCode() ^ Y.GetHashCode();
#endif
        }

        public override readonly bool Equals(object obj) => obj is Vector2<T> vec && Equals(vec);

        public readonly bool Equals(Vector2<T> other) => Scalar<T>.Equal(X, other.X) && Scalar<T>.Equal(Y, other.Y);

        public readonly void Deconstruct(out T x, out T y)
        {
            x = X;
            y = Y;
        }

#if INTRINSICS 
        public readonly Vector64<T> AsVector64()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector64<T>)(object)Vector64.Create((byte)(object)X, (byte)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector64<T>)(object)Vector64.Create((sbyte)(object)X, (sbyte)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector64<T>)(object)Vector64.Create((ushort)(object)X, (ushort)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector64<T>)(object)Vector64.Create((short)(object)X, (short)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector64<T>)(object)Vector64.Create((uint)(object)X, (uint)(object)Y);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector64<T>)(object)Vector64.Create((int)(object)X, (int)(object)Y);
            }

            if (typeof(T) == typeof(Half))
            {
                Scalar<T>.ThrowHalfNotSupported();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector64<T>)(object)Vector64.Create((float)(object)X, (float)(object)Y);
            }
            
            Scalar<T>.ThrowInvalidType();
            return default;
        }

        public readonly Vector128<T> AsVector128()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector128<T>)(object)Vector128.Create((byte)(object)X, (byte)(object)Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector128<T>)(object)Vector128.Create((sbyte)(object)X, (sbyte)(object)Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector128<T>)(object)Vector128.Create((ushort)(object)X, (ushort)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector128<T>)(object)Vector128.Create((short)(object)X, (short)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector128<T>)(object)Vector128.Create((uint)(object)X, (uint)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector128<T>)(object)Vector128.Create((int)(object)X, (int)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (Vector128<T>)(object)Vector128.Create((ulong)(object)X, (ulong)(object)Y);
            }

            if (typeof(T) == typeof(long))
            {
                return (Vector128<T>)(object)Vector128.Create((long)(object)X, (long)(object)Y);
            }

            if (typeof(T) == typeof(Half))
            {
                Scalar<T>.ThrowHalfNotSupported();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector128<T>)(object)Vector128.Create((float)(object)X, (float)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(double))
            {
                return (Vector128<T>)(object)Vector128.Create((double)(object)X, (double)(object)Y);
            }

            Scalar<T>.ThrowInvalidType();
            return default;
        }

        public readonly Vector256<T> AsVector256()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector256<T>)(object)Vector256.Create((byte)(object)X, (byte)(object)Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector256<T>)(object)Vector256.Create((sbyte)(object)X, (sbyte)(object)Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector256<T>)(object)Vector256.Create((ushort)(object)X, (ushort)(object)Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector256<T>)(object)Vector256.Create((short)(object)X, (short)(object)Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector256<T>)(object)Vector256.Create((uint)(object)X, (uint)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector256<T>)(object)Vector256.Create((int)(object)X, (int)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (Vector256<T>)(object)Vector256.Create((ulong)(object)X, (ulong)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(long))
            {
                return (Vector256<T>)(object)Vector256.Create((long)(object)X, (long)(object)Y, 0, 0);
            }

            if (typeof(T) == typeof(Half))
            {
                Scalar<T>.ThrowHalfNotSupported();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector256<T>)(object)Vector256.Create((float)(object)X, (float)(object)Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(double))
            {
                return (Vector256<T>)(object)Vector256.Create((double)(object)X, (double)(object)Y, 0, 0);
            }

            Scalar<T>.ThrowInvalidType();
            return default;
        }
#endif

#if BTEC_INTRINSICS
        public readonly unsafe Vector<T> AsVector()
        { 
            if (Vector<T>.Count >= 2)
            {
                Span<T> span = stackalloc T[] {X, Y};
                var vec = new Vector<T>(span);
                return vec;
            }

            Scalar<T>.ThrowVectorTTooSmall();
            return default; // not reached
        }
#endif
    }
}
