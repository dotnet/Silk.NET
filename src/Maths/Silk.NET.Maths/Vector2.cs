#region

#if INTRINSICS
using System.Runtime.Intrinsics;
#endif
using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using static Silk.NET.Maths.Scalar;

#endregion

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
    [Generator.GenerateMethodAliases]
    public readonly partial struct Vector2<T> where T : unmanaged, IFormattable
    {
        public static Vector2<T> UnitX => new Vector2<T>(Scalar<T>.One, default);

        public static Vector2<T> UnitY => new Vector2<T>(default, Scalar<T>.One);

        public static Vector2<T> Zero => default;

        public static Vector2<T> One => new Vector2<T>(Scalar<T>.One);

        public static Vector2<T> PositiveInfinity => new Vector2<T>(Scalar<T>.PositiveInfinity);

        public static Vector2<T> NegativeInfinity => new Vector2<T>(Scalar<T>.NegativeInfinity);

        public static unsafe int SizeInBytes => sizeof(Vector2<T>);

        public T X { get; }

        public T Y { get; }

        public Vector2(T value) : this(value, value) { }

        public Vector2(T x, T y) => (X, Y) = (x, y);

        public Vector2<T> WithX(T x) => new Vector2<T>(x, Y);

        public Vector2<T> WithY(T y) => new Vector2<T>(X, y);

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

                ThrowIndexOutOfRange();
                return default;
            }
        }

        public static T GetLength(Vector2<T> vec) => SquareRoot(vec.LengthSquared);

        public static T GetLengthSquared(Vector2<T> vec) => Dot(vec, vec);

        public static Vector2<T> GetPerpendicularRight(Vector2<T> vec) => new Vector2<T>(vec.Y, Scalar.Negate(vec.X));

        public static Vector2<T> GetPerpendicularLeft(Vector2<T> vec) => new Vector2<T>(Scalar.Negate(vec.Y), vec.X);

        public static Vector2<T> GetNormalized(Vector2<T> vec) => Normalize(vec);

        
        public static Vector2<T> Add(Vector2<T> a, Vector2<T> b)
            => new Vector2<T>(Scalar.Add(a.X, b.X), Scalar.Add(a.Y, b.Y));

        
        public static Vector2<T> Subtract(Vector2<T> a, Vector2<T> b)
            => new Vector2<T>(Scalar.Subtract(a.X, b.X), Scalar.Subtract(a.Y, b.Y));

        
        public static Vector2<T> Multiply(Vector2<T> vector, T scale)
            => new Vector2<T>(Scalar.Multiply(vector.X, scale), Scalar.Multiply(vector.Y, scale));

        
        public static Vector2<T> Multiply(Vector2<T> vector, Vector2<T> scale)
            => new Vector2<T>(Scalar.Multiply(vector.X, scale.X), Scalar.Multiply(vector.Y, scale.Y));

        
        public static Vector2<T> Divide(Vector2<T> vector, T scale)
            => new Vector2<T>(Scalar.Divide(vector.X, scale), Scalar.Divide(vector.Y, scale));

        
        public static Vector2<T> Divide(T value, Vector2<T> scale)
            => new Vector2<T>(Scalar.Divide(value, scale.X), Scalar.Divide(value, scale.Y));

        
        public static Vector2<T> Divide(Vector2<T> vector, Vector2<T> scale)
            => new Vector2<T>(Scalar.Divide(vector.X, scale.X), Scalar.Divide(vector.Y, scale.Y));

        
        public static Vector2<T> ComponentMin(Vector2<T> a, Vector2<T> b)
            => new Vector2<T>(Min(a.X, b.X), Min(a.Y, b.Y));

        
        public static Vector2<T> ComponentMax(Vector2<T> a, Vector2<T> b)
            => new Vector2<T>(Max(a.X, b.X), Max(a.Y, b.Y));

        
        public static Vector2<T> MagnitudeMin(Vector2<T> left, Vector2<T> right)
        {
            if (Larger(left.LengthSquared, right.LengthSquared))
            {
                return right;
            }

            return left;
        }

        
        public static Vector2<T> MagnitudeMax(Vector2<T> left, Vector2<T> right)
        {
            if (Larger(left.LengthSquared, right.LengthSquared))
            {
                return left;
            }

            return right;
        }

        
        public static Vector2<T> Clamp(Vector2<T> vec, Vector2<T> min, Vector2<T> max)
            => new Vector2<T>(Scalar.Clamp(vec.X, min.X, max.X), Scalar.Clamp(vec.Y, min.Y, max.Y));

        
        public static T Distance(Vector2<T> vec1, Vector2<T> vec2) => (vec1 - vec2).Length;

        
        public static T DistanceSquared(Vector2<T> vec1, Vector2<T> vec2) => (vec1 - vec2).LengthSquared;

        
        public static Vector2<T> Normalize(Vector2<T> vec) => vec / vec.Length;

        
        public static T Dot(Vector2<T> left, Vector2<T> right)
        {
            var mul = left * right;
            return Scalar.Add(mul.X, mul.Y);
        }

        
        public static T PerpDot(Vector2<T> left, Vector2<T> right)
            => Scalar.Subtract(Scalar.Multiply(left.X, right.Y), Scalar.Multiply(left.Y, right.X));

        
        public static Vector2<T> Lerp(Vector2<T> a, Vector2<T> b, T blend)
            => a * Scalar.Subtract(Scalar<T>.One, blend) + b * blend;

        
        public static Vector2<T> BaryCentric(Vector2<T> a, Vector2<T> b, Vector2<T> c, T u, T v)
            =>
                a * Scalar.Subtract(Scalar<T>.One, u) * Scalar.Subtract(Scalar<T>.One, v) +
                b * u * Scalar.Subtract(Scalar<T>.One, v) + c * Scalar.Subtract(Scalar<T>.One, u) * v;

        
        public static Vector2<T> Transform(Vector2<T> vec, Matrix2X2<T> mat)
            =>
                new Vector2<T>
                    (
                    Scalar.Add(Scalar.Multiply(vec.X, mat.M11), Scalar.Multiply(vec.Y, mat.M21)),
                    Scalar.Add(Scalar.Multiply(vec.X, mat.M12), Scalar.Multiply(vec.Y, mat.M22)));

        
        public static Vector2<T> Transform(Vector2<T> vec, Quaternion<T> quat)
        {
            var x2 = Scalar.Add(quat.X, quat.X);
            var y2 = Scalar.Add(quat.Y, quat.Y);
            var z2 = Scalar.Add(quat.Z, quat.Z);

            var wz2 = Scalar.Multiply(quat.W, z2);
            var xx2 = Scalar.Multiply(quat.X, x2);
            var xy2 = Scalar.Multiply(quat.X, y2);
            var yy2 = Scalar.Multiply(quat.Y, y2);
            var zz2 = Scalar.Multiply(quat.Z, z2);

            return new Vector2<T>
                (
                Scalar.Add
                    (
                        Scalar.Multiply(vec.X, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2)),
                        Scalar.Multiply(vec.Y, Scalar.Subtract(xy2, wz2))),
                Scalar.Add
                    (
                        Scalar.Multiply(vec.X, Scalar.Add(xy2, wz2)),
                        Scalar.Multiply(vec.Y, Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2))));
        }

        
        public static Vector2<T> Cos(Vector2<T> vector) => new Vector2<T>(Scalar.Cos(vector.X), Scalar.Cos(vector.Y));

        
        public static Vector2<T> Sin(Vector2<T> vector) => new Vector2<T>(Scalar.Sin(vector.X), Scalar.Sin(vector.Y));
        
        
        public static Vector2<T> Negate(Vector2<T> vec) => new Vector2<T>(Scalar.Negate(vec.X), Scalar.Negate(vec.Y));

        public static bool operator ==(Vector2<T> left, Vector2<T> right) => left.Equals(right);

        public static bool operator !=(Vector2<T> left, Vector2<T> right) => !(left == right);

        public static implicit operator Vector2<T>((T X, T Y) values) => new Vector2<T>(values.X, values.Y);

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
            sb.Append('>');
            return sb.ToString();
        }

        public override int GetHashCode() => HashCode.Combine(X, Y);

        public override bool Equals(object? obj) => obj is Vector2<T> vec && Equals(vec);

        public bool Equals(Vector2<T> other) => Equal(X, other.X) && Equal(Y, other.Y);

        public void Deconstruct(out T x, out T y)
        {
            x = X;
            y = Y;
        }

#if INTRINSICS
        public Vector64<T> AsVector64()
        {
            if (typeof(T) == typeof(byte))
            {
                return (Vector64<T>) (object) Vector64.Create((byte) (object) X, (byte) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (Vector64<T>) (object) Vector64.Create((sbyte) (object) X, (sbyte) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (Vector64<T>) (object) Vector64.Create((ushort) (object) X, (ushort) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return (Vector64<T>) (object) Vector64.Create((short) (object) X, (short) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector64<T>) (object) Vector64.Create((uint) (object) X, (uint) (object) Y);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector64<T>) (object) Vector64.Create((int) (object) X, (int) (object) Y);
            }

            if (typeof(T) == typeof(Half))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector64<T>) (object) Vector64.Create((float) (object) X, (float) (object) Y);
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
                                ((byte) (object) X, (byte) (object) Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return
                    (Vector128<T>)
                        (object)
                            Vector128.Create
                                ((sbyte) (object) X, (sbyte) (object) Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return
                    (Vector128<T>) (object) Vector128.Create((ushort) (object) X, (ushort) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return
                    (Vector128<T>) (object) Vector128.Create((short) (object) X, (short) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector128<T>) (object) Vector128.Create((uint) (object) X, (uint) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector128<T>) (object) Vector128.Create((int) (object) X, (int) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (Vector128<T>) (object) Vector128.Create((ulong) (object) X, (ulong) (object) Y);
            }

            if (typeof(T) == typeof(long))
            {
                return (Vector128<T>) (object) Vector128.Create((long) (object) X, (long) (object) Y);
            }

            if (typeof(T) == typeof(Half))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            if (typeof(T) == typeof(float))
            {
                return (Vector128<T>) (object) Vector128.Create((float) (object) X, (float) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(double))
            {
                return (Vector128<T>) (object) Vector128.Create((double) (object) X, (double) (object) Y);
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
                                    (byte) (object) X, (byte) (object) Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                (
                                    (sbyte) (object) X, (sbyte) (object) Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ushort))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                ((ushort) (object) X, (ushort) (object) Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(short))
            {
                return
                    (Vector256<T>)
                        (object)
                            Vector256.Create
                                ((short) (object) X, (short) (object) Y, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(uint))
            {
                return (Vector256<T>) (object) Vector256.Create((uint) (object) X, (uint) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(int))
            {
                return (Vector256<T>) (object) Vector256.Create((int) (object) X, (int) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (Vector256<T>) (object) Vector256.Create((ulong) (object) X, (ulong) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(long))
            {
                return (Vector256<T>) (object) Vector256.Create((long) (object) X, (long) (object) Y, 0, 0);
            }

            if (typeof(T) == typeof(Half))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            if (typeof(T) == typeof(float))
            {
                return
                    (Vector256<T>) (object) Vector256.Create((float) (object) X, (float) (object) Y, 0, 0, 0, 0, 0, 0);
            }

            if (typeof(T) == typeof(double))
            {
                return (Vector256<T>) (object) Vector256.Create((double) (object) X, (double) (object) Y, 0, 0);
            }

            ThrowInvalidType();
            return default;
        }
#endif

#if BTEC_INTRINSICS
        // @formatter:off
        public unsafe Vector<T> AsVector()
        {
            if (Vector<T>.Count >= 2)
            {
                Span<T> span = stackalloc T[] {X, Y};
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