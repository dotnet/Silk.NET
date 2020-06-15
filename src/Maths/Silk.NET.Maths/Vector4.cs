// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Vector4<T> : IEquatable<Vector4<T>> where T : unmanaged
    {
        public static readonly Vector4<T> UnitX;
        public static readonly Vector4<T> UnitY;
        public static readonly Vector4<T> UnitZ;
        public static readonly Vector4<T> UnitW;
        public static readonly Vector4<T> Zero;
        public static readonly Vector4<T> One;
        public static readonly Vector4<T> PositiveInfinity;
        public static readonly Vector4<T> NegativeInfinity;
        public static readonly int SizeInBytes;
        private static readonly string ListSeparator;
        public T X;
        public T Y;
        public T Z;
        public T W;

        public Vector4(T value)
        {
            throw new NotImplementedException();
        }

        public Vector4(T x, T y, T z, T w)
        {
            throw new NotImplementedException();
        }

        public Vector4(Vector2<T> v)
        {
            throw new NotImplementedException();
        }

        public Vector4(Vector3<T> v)
        {
            throw new NotImplementedException();
        }

        public Vector4(Vector3<T> v, T w)
        {
            throw new NotImplementedException();
        }

        public Vector4(Vector4<T> v)
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

        public Vector4<T> Normalized()
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

        public static Vector4<T> Add(Vector4<T> a, Vector4<T> b)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Subtract(Vector4<T> a, Vector4<T> b)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Multiply(Vector4<T> vector, T scale)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Vector4<T> vector, T scale, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Multiply(Vector4<T> vector, Vector4<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Vector4<T> vector, ref Vector4<T> scale, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Divide(Vector4<T> vector, T scale)
        {
            throw new NotImplementedException();
        }

        public static void Divide(ref Vector4<T> vector, T scale, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Divide(Vector4<T> vector, Vector4<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void Divide(ref Vector4<T> vector, ref Vector4<T> scale, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> ComponentMin(Vector4<T> a, Vector4<T> b)
        {
            throw new NotImplementedException();
        }

        public static void ComponentMin(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> ComponentMax(Vector4<T> a, Vector4<T> b)
        {
            throw new NotImplementedException();
        }

        public static void ComponentMax(ref Vector4<T> a, ref Vector4<T> b, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> MagnitudeMin(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void MagnitudeMin(ref Vector4<T> left, ref Vector4<T> right, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> MagnitudeMax(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void MagnitudeMax(ref Vector4<T> left, ref Vector4<T> right, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Clamp(Vector4<T> vec, Vector4<T> min, Vector4<T> max)
        {
            throw new NotImplementedException();
        }

        public static void Clamp
        (
            ref Vector4<T> vec,
            ref Vector4<T> min,
            ref Vector4<T> max,
            out Vector4<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Normalize(Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void Normalize(ref Vector4<T> vec, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> NormalizeFast(Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void NormalizeFast(ref Vector4<T> vec, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static T Dot(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Dot(ref Vector4<T> left, ref Vector4<T> right, out T result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Lerp(Vector4<T> a, Vector4<T> b, T blend)
        {
            throw new NotImplementedException();
        }

        public static void Lerp(ref Vector4<T> a, ref Vector4<T> b, T blend, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> BaryCentric(Vector4<T> a, Vector4<T> b, Vector4<T> c, T u, T v)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public static Vector4<T> Transform(Vector4<T> vec, Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Vector4<T> vec, ref Matrix4X4<T> mat, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Transform(Vector4<T> vec, Quaternion<T> quat)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Vector4<T> vec, ref Quaternion<T> quat, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> Transform(Matrix4X4<T> mat, Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static void Transform(ref Matrix4X4<T> mat, ref Vector4<T> vec, out Vector4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator +(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator -(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator -(Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator *(Vector4<T> vec, T scale)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator *(T scale, Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator *(Vector4<T> vec, Vector4<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator *(Vector4<T> vec, Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator *(Matrix4X4<T> mat, Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator *(Quaternion<T> quat, Vector4<T> vec)
        {
            throw new NotImplementedException();
        }

        public static Vector4<T> operator /(Vector4<T> vec, T scale)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Vector4<T> left, Vector4<T> right)
        {
            throw new NotImplementedException();
        }

        public static explicit operator IntPtr(Vector4<T> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Vector4<T>((T X, T Y, T Z, T W) values)
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

        public bool Equals(Vector4<T> other)
        {
            throw new NotImplementedException();
        }

        public void Deconstruct(out T x, out T y, out T z, out T w)
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
