// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Vector3<T> : IEquatable<Vector3<T>> where T:unmanaged
    {
        public static readonly Vector3<T> UnitX;
        public static readonly Vector3<T> UnitY;
        public static readonly Vector3<T> UnitZ;
        public static readonly Vector3<T> Zero;
        public static readonly Vector3<T> One;
        public static readonly Vector3<T> PositiveInfinity;
        public static readonly Vector3<T> NegativeInfinity;
        public static readonly int SizeInBytes;
        private static readonly string ListSeparator;
        public T X;
        public T Y;
        public T Z;

        public Vector3(T value)
        {
            throw new NotImplementedException();
        }

        public Vector3(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public Vector3(Vector2<T> v)
        {
            throw new NotImplementedException();
        }

        public Vector3(Vector3<T> v)
        {
            throw new NotImplementedException();
        }

        public Vector3(Vector4<T> v)
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

        public Vector3<T> Normalized()
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

        public static Vector3<T> Add(Vector3<T> a, Vector3<T> b)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Vector3<T> a, ref Vector3<T> b, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Subtract(Vector3<T> a, Vector3<T> b)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Vector3<T> a, ref Vector3<T> b, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Multiply(Vector3<T> vector, T scale)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Vector3<T> vector, T scale, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Multiply(Vector3<T> vector, Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Vector3<T> vector, ref Vector3<T> scale, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Divide(Vector3<T> vector, T scale)
        {
            throw new NotImplementedException();
        }

        public static void Divide(ref Vector3<T> vector, T scale, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Divide(Vector3<T> vector, Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void Divide(ref Vector3<T> vector, ref Vector3<T> scale, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> ComponentMin(Vector3<T> a, Vector3<T> b)
        {
            throw new NotImplementedException();
        }

        public static void ComponentMin(ref Vector3<T> a, ref Vector3<T> b, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> ComponentMax(Vector3<T> a, Vector3<T> b)
        {
            throw new NotImplementedException();
        }

        public static void ComponentMax(ref Vector3<T> a, ref Vector3<T> b, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> MagnitudeMin(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void MagnitudeMin(ref Vector3<T> left, ref Vector3<T> right, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> MagnitudeMax(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void MagnitudeMax(ref Vector3<T> left, ref Vector3<T> right, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Clamp(Vector3<T> vec, Vector3<T> min, Vector3<T> max)
        {
            throw new NotImplementedException();
        }

        public static void Clamp
        (
            ref Vector3<T> vec,
            ref Vector3<T> min,
            ref Vector3<T> max,
            out Vector3<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static T Distance(Vector3<T> vec1, Vector3<T> vec2)
        {
            throw new NotImplementedException();
        }

        public static void Distance(ref Vector3<T> vec1, ref Vector3<T> vec2, out T result)
        {
            throw new NotImplementedException();
        }

        public static T DistanceSquared(Vector3<T> vec1, Vector3<T> vec2)
        {
            throw new NotImplementedException();
        }

        public static void DistanceSquared(ref Vector3<T> vec1, ref Vector3<T> vec2, out T result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Normalize(Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void Normalize(ref Vector3<T> vec, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> NormalizeFast(Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void NormalizeFast(ref Vector3<T> vec, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static T Dot(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Dot(ref Vector3<T> left, ref Vector3<T> right, out T result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Cross(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Cross(ref Vector3<T> left, ref Vector3<T> right, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Lerp(Vector3<T> a, Vector3<T> b, T blend)
        {
            throw new NotImplementedException();
        }

        public static void Lerp(ref Vector3<T> a, ref Vector3<T> b, T blend, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> BaryCentric(Vector3<T> a, Vector3<T> b, Vector3<T> c, T u, T v)
        {
            throw new NotImplementedException();
        }

        public static void BaryCentric
        (
            ref Vector3<T> a,
            ref Vector3<T> b,
            ref Vector3<T> c,
            T u,
            T v,
            out Vector3<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> TransformVector(Vector3<T> vec, Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void TransformVector(ref Vector3<T> vec, ref Matrix4X4<T> mat, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> TransformNormal(Vector3<T> norm, Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void TransformNormal(ref Vector3<T> norm, ref Matrix4X4<T> mat, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> TransformNormalInverse(Vector3<T> norm, Matrix4X4<T> invMat)
        {
            throw new NotImplementedException();
        }

        public static void TransformNormalInverse
        (
            ref Vector3<T> norm,
            ref Matrix4X4<T> invMat,
            out Vector3<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> TransformPosition(Vector3<T> pos, Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void TransformPosition(ref Vector3<T> pos, ref Matrix4X4<T> mat, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Transform(Vector3<T> vec, Matrix3X3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Vector3<T> vec, ref Matrix3X3<T> mat, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Transform(Vector3<T> vec, Quaternion<T> quat)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Vector3<T> vec, ref Quaternion<T> quat, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Transform(Matrix3X3<T> mat, Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Matrix3X3<T> mat, ref Vector3<T> vec, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> TransformPerspective(Vector3<T> vec, Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void TransformPerspective(ref Vector3<T> vec, ref Matrix4X4<T> mat, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static T CalculateAngle(Vector3<T> first, Vector3<T> second)
        {
            throw new NotImplementedException();
        }

        public static void CalculateAngle(ref Vector3<T> first, ref Vector3<T> second, out T result)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Project
        (
            Vector3<T> vector,
            T x,
            T y,
            T width,
            T height,
            T minZ,
            T maxZ,
            Matrix4X4<T> worldViewProjection
        )
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> Unproject
        (
            Vector3<T> vector,
            T x,
            T y,
            T width,
            T height,
            T minZ,
            T maxZ,
            Matrix4X4<T> inverseWorldViewProjection
        )
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator +(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator -(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator -(Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator *(Vector3<T> vec, T scale)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator *(T scale, Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator *(Vector3<T> vec, Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator *(Vector3<T> vec, Matrix3X3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator *(Matrix3X3<T> mat, Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator *(Quaternion<T> quat, Vector3<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector3<T> operator /(Vector3<T> vec, T scale)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Vector3<T> left, Vector3<T> right)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Vector3<T>((T X, T Y, T Z) values)
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

        public bool Equals(Vector3<T> other)
        {
            throw new NotImplementedException();
        }

        public void Deconstruct(out T x, out T y, out T z)
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
