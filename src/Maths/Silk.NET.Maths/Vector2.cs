// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Vector2<T> : IEquatable<Vector2<T>> where T:unmanaged
    {
        public static readonly Vector2<T> UnitX;
        public static readonly Vector2<T> UnitY;
        public static readonly Vector2<T> Zero;
        public static readonly Vector2<T> One;
        public static readonly Vector2<T> PositiveInfinity;
        public static readonly Vector2<T> NegativeInfinity;
        public static readonly int SizeInBytes;
        private static readonly string ListSeparator;
        public T X;
        public T Y;

        public Vector2(T value)
        {
            throw new NotImplementedException();
        }

        public Vector2(T x, T y)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public T Length => throw new NotImplementedException();

        public T LengthFast => throw new NotImplementedException();

        public T LengthSquared => throw new NotImplementedException();

        public Vector2<T> PerpendicularRight => throw new NotImplementedException();

        public Vector2<T> PerpendicularLeft => throw new NotImplementedException();

        public Vector2<T> Normalized()
        {
            throw new NotImplementedException();
        }

        public void Normalize()
        {
            throw new NotImplementedException();
        }

        public void NormalizeFast()
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Add(Vector2<T> a, Vector2<T> b)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Subtract(Vector2<T> a, Vector2<T> b)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Multiply(Vector2<T> vector, T scale)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Vector2<T> vector, T scale, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Multiply(Vector2<T> vector, Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Vector2<T> vector, ref Vector2<T> scale, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Divide(Vector2<T> vector, T scale)
        {
            throw new NotImplementedException();
        }

        public static void Divide(ref Vector2<T> vector, T scale, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Divide(Vector2<T> vector, Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void Divide(ref Vector2<T> vector, ref Vector2<T> scale, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> ComponentMin(Vector2<T> a, Vector2<T> b)
        {
            throw new NotImplementedException();
        }

        public static void ComponentMin(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> ComponentMax(Vector2<T> a, Vector2<T> b)
        {
            throw new NotImplementedException();
        }

        public static void ComponentMax(ref Vector2<T> a, ref Vector2<T> b, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> MagnitudeMin(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void MagnitudeMin(ref Vector2<T> left, ref Vector2<T> right, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> MagnitudeMax(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void MagnitudeMax(ref Vector2<T> left, ref Vector2<T> right, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Clamp(Vector2<T> vec, Vector2<T> min, Vector2<T> max)
        {
            throw new NotImplementedException();
        }

        public static void Clamp
        (
            ref Vector2<T> vec,
            ref Vector2<T> min,
            ref Vector2<T> max,
            out Vector2<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static T Distance(Vector2<T> vec1, Vector2<T> vec2)
        {
            throw new NotImplementedException();
        }

        public static void Distance(ref Vector2<T> vec1, ref Vector2<T> vec2, out T result)
        {
            throw new NotImplementedException();
        }

        public static T DistanceSquared(Vector2<T> vec1, Vector2<T> vec2)
        {
            throw new NotImplementedException();
        }

        public static void DistanceSquared(ref Vector2<T> vec1, ref Vector2<T> vec2, out T result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Normalize(Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void Normalize(ref Vector2<T> vec, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> NormalizeFast(Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void NormalizeFast(ref Vector2<T> vec, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static T Dot(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Dot(ref Vector2<T> left, ref Vector2<T> right, out T result)
        {
            throw new NotImplementedException();
        }

        public static T PerpDot(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void PerpDot(ref Vector2<T> left, ref Vector2<T> right, out T result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Lerp(Vector2<T> a, Vector2<T> b, T blend)
        {
            throw new NotImplementedException();
        }

        public static void Lerp(ref Vector2<T> a, ref Vector2<T> b, T blend, out Vector2<T> result)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public static void Transform(ref Vector2<T> vec, ref Matrix2X2<T> mat, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Transform(Vector2<T> vec, Quaternion<T> quat)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Vector2<T> vec, ref Quaternion<T> quat, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> Transform(Matrix2X2<T> mat, Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Matrix2X2<T> mat, ref Vector2<T> vec, out Vector2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator +(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator -(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator -(Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator *(Vector2<T> vec, T scale)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator *(T scale, Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator *(Vector2<T> vec, Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator *(Vector2<T> vec, Matrix2X2<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator *(Matrix2X2<T> mat, Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator *(Quaternion<T> quat, Vector2<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector2<T> operator /(Vector2<T> vec, T scale)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Vector2<T> left, Vector2<T> right)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Vector2<T>((T X, T Y) values)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Vector2<T> other)
        {
            throw new NotImplementedException();
        }

        public void Deconstruct(out T x, out T y)
        {
            throw new NotImplementedException();
        }

#if INTRINSICS
        public System.Runtime.Intrinsics.Vector64<T> AsVector64()
        {
            throw new NotImplementedException();
        }

        public System.Runtime.Intrinsics.Vector128<T> AsVector128()
        {
            throw new NotImplementedException();
        }

        public System.Runtime.Intrinsics.Vector256<T> AsVector256()
        {
            throw new NotImplementedException();
        }
#endif

#if BTEC_INTRINSICS
        public System.Numerics.Vector<T> AsVector()
        {
            throw new NotImplementedException();
        }
#endif
    }
}
