// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#if INTRINSICS
using System.Runtime.Intrinsics;
#endif
#if BTEC_INTRINSICS
using System.Numerics;
#endif
using System;
using System.Globalization;
using static Silk.NET.Maths.Scalar;

namespace Silk.NET.Maths
{
    [Serializable]
    public readonly struct Quaternion<T> : IEquatable<Quaternion<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public readonly Vector4<T> Xyzw;

        public Quaternion(Vector4<T> xyzw)
        {
            ThrowForIntegerBaseType<T>();
            Xyzw = xyzw;
        }

        public Quaternion(Vector3<T> xyz, T w) : this(new Vector4<T>(xyz, w))
        {
        }

        public Quaternion(T x, T y, T z, T w) : this(new Vector4<T>(x, y, z, w))
        {
        }

        public T X => Xyzw.X;

        public T Y => Xyzw.Y;

        public T Z => Xyzw.Z;

        public T W => Xyzw.W;

        public void ToAxisAngle(out Vector3<T> axis, out T angle)
        {
            var q = this;
            if (Larger(Abs(q.W), One<T>()))
            {
                q = q.Normalized();
            }

            angle = Scalar.Multiply(Two<T>(), Acos(q.W));

            var denominator = SquareRoot(Scalar.Subtract(One<T>(), Scalar.Multiply(q.W, q.W)));
            axis = Larger(denominator, As<T>(0.0001f)) ? q.Xyzw.XYZ / denominator : Vector3<T>.UnitX;
        }

        public Vector4<T> ToAxisAngle()
        {
            ToAxisAngle(out var axis, out var angle);
            return new Vector4<T>(axis, angle);
        }

        public void ToEulerAngles(out Vector3<T> angles) => angles = ToEulerAngles();

        public Vector3<T> ToEulerAngles() => ToEulerAngles(this);

        public T Length => SquareRoot(LengthSquared);

        public T LengthSquared => Xyzw.LengthSquared;

        public Quaternion<T> Normalized() => Normalize(this);

        public Quaternion<T> Inverted() => Invert(this);

        public Quaternion<T> Conjugated() => Conjugate(this);

        public static Quaternion<T> Identity => new Quaternion<T>(default, default, default, One<T>());

        public static Quaternion<T> Add
            (Quaternion<T> left, Quaternion<T> right) => new Quaternion<T>(left.Xyzw + right.Xyzw);

        public static void Add
            (ref Quaternion<T> left, ref Quaternion<T> right, out Quaternion<T> result) => result = Add(left, right);

        public static Quaternion<T> Subtract
            (Quaternion<T> left, Quaternion<T> right) => new Quaternion<T>(left.Xyzw - right.Xyzw);

        public static void Subtract
            (ref Quaternion<T> left, ref Quaternion<T> right, out Quaternion<T> result) =>
            result = Subtract(left, right);

        public static Quaternion<T> Multiply
            (Quaternion<T> left, Quaternion<T> right) => new Quaternion<T>(left.Xyzw * right.Xyzw);

        public static void Multiply
            (ref Quaternion<T> left, ref Quaternion<T> right, out Quaternion<T> result) =>
            result = Multiply(left, right);

        public static Quaternion<T> Multiply
            (Quaternion<T> quaternion, T scale) => new Quaternion<T>(quaternion.Xyzw * scale);

        public static void Multiply
            (ref Quaternion<T> quaternion, T scale, out Quaternion<T> result) => result = Multiply(quaternion, scale);

        public static Quaternion<T> Conjugate(Quaternion<T> q) => new Quaternion<T>(-q.Xyzw.XYZ, q.W);

        public static void Conjugate
            (ref Quaternion<T> q, out Quaternion<T> result) => result = Conjugate(q);

        public static Quaternion<T> Invert(Quaternion<T> q)
        {
            var lengthSquared = q.LengthSquared;

            if (!Equal(lengthSquared, default))
            {
                var i = Divide(One<T>(), lengthSquared);
                return new Quaternion<T>(q.Xyzw.XYZ * Negate(i), Scalar.Multiply(q.W, i));
            }

            return q;
        }

        public static void Invert(ref Quaternion<T> q, out Quaternion<T> result) => result = Invert(q);

        public static Quaternion<T> Normalize
            (Quaternion<T> q) => new Quaternion<T>(q.Xyzw / Divide(One<T>(), q.Length));

        public static void Normalize
            (ref Quaternion<T> q, out Quaternion<T> result) => result = Normalize(q);

        public static Quaternion<T> FromAxisAngle(Vector3<T> axis, T angle)
        {
            if (Equal(axis.LengthSquared, As<T>(0.0f)))
            {
                return Identity;
            }

            angle = Divide(angle, Two<T>());
            axis = axis.Normalized();
            return Normalize(new Quaternion<T>(axis * Sin(angle), Cos(angle)));
        }

        public static Quaternion<T> FromEulerAngles(T pitch, T yaw, T roll) => FromEulerAngles
            (new Vector3<T>(pitch, yaw, roll));

        public static Quaternion<T> FromEulerAngles(Vector3<T> eulerAngles)
        {
            eulerAngles = eulerAngles / Two<T>();

            var c = Vector3<T>.Cos(eulerAngles);
            var s = Vector3<T>.Sin(eulerAngles);

            Scalar.Add
                (Scalar.Multiply(s.X, Scalar.Multiply(c.Y, c.Z)), Scalar.Multiply(c.X, Scalar.Multiply(s.Y, s.Z)));
            return new Quaternion<T>
            (
                Scalar.Add
                    (Scalar.Multiply(s.X, Scalar.Multiply(c.Y, c.Z)), Scalar.Multiply(c.X, Scalar.Multiply(s.Y, s.Z))),
                Scalar.Subtract
                    (Scalar.Multiply(c.X, Scalar.Multiply(s.Y, c.Z)), Scalar.Multiply(s.X, Scalar.Multiply(c.Y, s.Z))),
                Scalar.Add
                    (Scalar.Multiply(c.X, Scalar.Multiply(c.Y, s.Z)), Scalar.Multiply(s.X, Scalar.Multiply(s.Y, c.Z))),
                Scalar.Subtract
                    (Scalar.Multiply(c.X, Scalar.Multiply(c.Y, c.Z)), Scalar.Multiply(s.X, Scalar.Multiply(s.Y, s.Z)))
            );
        }

        public static void FromEulerAngles
            (ref Vector3<T> eulerAngles, out Quaternion<T> result) => result = FromEulerAngles(eulerAngles);

        public static Vector3<T> ToEulerAngles(Quaternion<T> q)
        {
            // Threshold for the singularities found at the north/south poles.
            const float singularityThreshold = 0.4999995f;

            var sqw = Scalar.Multiply(q.W, q.W);
            var sqx = Scalar.Multiply(q.X, q.X);
            var sqy = Scalar.Multiply(q.Y, q.Y);
            var sqz = Scalar.Multiply(q.Z, q.Z);
            var unit = Scalar.Add(sqx, Scalar.Add(sqy, Scalar.Add(sqz, sqw)));
            var singularityTest = Scalar.Add(Scalar.Multiply(q.X, q.Z), Scalar.Multiply(q.W, q.Y));

            T x;
            T y;
            T z;
            if (Larger(singularityTest, Scalar.Multiply(As<T>(singularityThreshold), unit)))
            {
                x = default;
                y = Tau<T>();
                z = Scalar.Multiply(Two<T>(), Atan2(q.X, q.W));
            }
            else if (Smaller(singularityTest, Scalar.Multiply(Negate(As<T>(singularityThreshold)), unit)))
            {
                x = default;
                y = Negate(Tau<T>());
                z = Negate(Scalar.Multiply(Two<T>(), Atan2(q.X, q.W)));
            }
            else
            {
                x = Atan2
                (
                    Scalar.Multiply(Two<T>(), Scalar.Subtract(Scalar.Multiply(q.W, q.X), Scalar.Multiply(q.Y, q.Z))),
                    Scalar.Subtract(sqw, Scalar.Subtract(sqx, Scalar.Add(sqy, sqz)))
                );
                y = Asin(Divide(Scalar.Multiply(Two<T>(), singularityTest), unit));
                z = Atan2
                (
                    Scalar.Multiply(Two<T>(), Scalar.Subtract(Scalar.Multiply(q.W, q.Z), Scalar.Multiply(q.X, q.Y))),
                    Scalar.Add(sqw, Scalar.Subtract(sqx, Scalar.Subtract(sqy, sqz)))
                );
            }

            return new Vector3<T>(x, y, z);
        }

        public static void ToEulerAngles
            (in Quaternion<T> q, out Vector3<T> result) => result = ToEulerAngles(q);

        public static Quaternion<T> FromMatrix(Matrix3X3<T> matrix)
        {
            var trace = matrix.Trace;

            if (Larger(trace, default))
            {
                var s = Scalar.Multiply(SquareRoot(Scalar.Add(trace, One<T>())), Two<T>());

                var xyz = new Vector3<T>
                (
                    Scalar.Subtract(matrix.M32, matrix.M23),
                    Scalar.Subtract(matrix.M13, matrix.M31),
                    Scalar.Subtract(matrix.M21, matrix.M12)
                );
                return new Quaternion<T>
                (
                    xyz / s,
                    Divide(s, As<T>(4))
                );
            }

            if (Larger(matrix.M11, matrix.M22) && Larger(matrix.M11, matrix.M33))
            {
                var s = Scalar.Multiply
                (
                    SquareRoot
                        (Scalar.Subtract(Scalar.Subtract(Scalar.Add(One<T>(), matrix.M11), matrix.M22), matrix.M33)),
                    Two<T>()
                );

                return new Quaternion<T>
                (
                    Divide(s, As<T>(4)),
                    Divide(Scalar.Add(matrix.M12, matrix.M21), s),
                    Divide(Scalar.Add(matrix.M13, matrix.M31), s),
                    Divide(Scalar.Subtract(matrix.M32, matrix.M23), s)
                );
            }

            if (Larger(matrix.M22, matrix.M33))
            {
                var s = Scalar.Multiply
                (
                    SquareRoot
                        (Scalar.Subtract(Scalar.Subtract(Scalar.Add(One<T>(), matrix.M22), matrix.M11), matrix.M33)),
                    Two<T>()
                );

                return new Quaternion<T>
                (
                    Divide(Scalar.Add(matrix.M12, matrix.M21), s),
                    Divide(s, As<T>(4)),
                    Divide(Scalar.Add(matrix.M23, matrix.M32), s),
                    Divide(Scalar.Add(matrix.M13, matrix.M31), s)
                );
            }

            {
                var s = Scalar.Multiply
                (
                    SquareRoot
                        (Scalar.Subtract(Scalar.Subtract(Scalar.Add(One<T>(), matrix.M33), matrix.M11), matrix.M22)),
                    Two<T>()
                );

                return new Quaternion<T>
                (
                    Divide(Scalar.Add(matrix.Row0.Z, matrix.Row2.X), s),
                    Divide(Scalar.Add(matrix.Row1.Z, matrix.Row2.Y), s),
                    Divide(s, As<T>(4)),
                    Divide(Scalar.Subtract(matrix.Row1.X, matrix.Row0.Y), s)
                );
            }
        }

        public static void FromMatrix
            (ref Matrix3X3<T> matrix, out Quaternion<T> result) => result = FromMatrix(matrix);

        public static Quaternion<T> Slerp
            (Quaternion<T> q1, Quaternion<T> q2, T blend)
        {
            // if either input is zero, return the other.
            if (Equal(q1.LengthSquared, default))
            {
                if (Equal(q2.LengthSquared, default))
                {
                    return Identity;
                }

                return q2;
            }

            if (Equal(q2.LengthSquared, default))
            {
                return q1;
            }

            var cosHalfAngle = Scalar.Add(Scalar.Multiply(q1.W, q2.W), Vector3<T>.Dot(q1.Xyzw.XYZ, q2.Xyzw.XYZ));

            if (LargerEquals(cosHalfAngle, One<T>()) || SmallerEquals(cosHalfAngle, Negate(One<T>())))
            {
                return q1;
            }

            if (Smaller(cosHalfAngle, default))
            {
                q2 = new Quaternion<T>(Vector4<T>.Negate(q2.Xyzw));
                cosHalfAngle = Negate(cosHalfAngle);
            }

            T blendA;
            T blendB;
            if (Smaller(cosHalfAngle, As<T>(0.99f)))
            {
                // do proper slerp for big angles
                var halfAngle = Acos(cosHalfAngle);
                var sinHalfAngle = Sin(halfAngle);
                blendA = Divide(Sin(Scalar.Multiply(halfAngle, Scalar.Subtract(One<T>(), blend))), sinHalfAngle);
                blendB = Divide(Sin(Scalar.Multiply(halfAngle, blend)), sinHalfAngle);
            }
            else
            {
                // do lerp if angle is really small.
                blendA = Scalar.Subtract(One<T>(), blend);
                blendB = blend;
            }

            var result = q1 * blendA + q2 * blendB;
            if (Larger(result.LengthSquared, default))
            {
                return Normalize(result);
            }

            return Identity;
        }

        public static Quaternion<T> operator +
            (Quaternion<T> left, Quaternion<T> right) => Add(left, right);

        public static Quaternion<T> operator -
            (Quaternion<T> left, Quaternion<T> right) => Subtract(left, right);

        public static Quaternion<T> operator *
            (Quaternion<T> left, Quaternion<T> right) => Multiply(left, right);

        public static Quaternion<T> operator *
            (Quaternion<T> quaternion, T scale) => Multiply(quaternion, scale);

        public static Quaternion<T> operator *
            (T scale, Quaternion<T> quaternion) => Multiply(quaternion, scale);

        public static bool operator ==(Quaternion<T> left, Quaternion<T> right) => left.Equals(right);

        public static bool operator !=(Quaternion<T> left, Quaternion<T> right) => !(left == right);


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => Xyzw.ToString
            (format, formatProvider);

        public override bool Equals(object? other) => other is Quaternion<T> quaternion && Equals(quaternion);

        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        public bool Equals(Quaternion<T> other) => Xyzw.Equals(other.Xyzw);


#if INTRINSICS
        public Vector64<T> AsVector64() => Xyzw.AsVector64();

        public Vector128<T> AsVector128() => Xyzw.AsVector128();

        public Vector256<T> AsVector256() => Xyzw.AsVector256();
#endif

#if BTEC_INTRINSICS
        public Vector<T> AsVector() => Xyzw.AsVector();
#endif
    }
}
