// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Quaternion<T> : IEquatable<Quaternion<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Quaternion<T> Identity;
        public Vector3<T> Xyz;
        public T W;

        public Quaternion(Vector3<T> v, T w)
        {
            throw new NotImplementedException();
        }

        public Quaternion(T x, T y, T z, T w)
        {
            throw new NotImplementedException();
        }

        public Quaternion(T rotationX, T rotationY, T rotationZ)
        {
            throw new NotImplementedException();
        }

        public Quaternion(Vector3<T> eulerAngles)
        {
            throw new NotImplementedException();
        }

        public T X
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public T Y
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public T Z
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void ToAxisAngle(out Vector3<T> axis, out T angle)
        {
            throw new NotImplementedException();
        }

        public Vector4<T> ToAxisAngle()
        {
            throw new NotImplementedException();
        }

        public void ToEulerAngles(out Vector3<T> angles)
        {
            throw new NotImplementedException();
        }

        public Vector3<T> ToEulerAngles()
        {
            throw new NotImplementedException();
        }

        public T Length => throw new NotImplementedException();

        public T LengthSquared => throw new NotImplementedException();

        public Quaternion<T> Normalized()
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public Quaternion<T> Inverted()
        {
            throw new NotImplementedException();
        }

        public void Normalize()
        {
            throw new NotImplementedException();
        }

        public void Conjugate()
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Add(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Quaternion<T> left, ref Quaternion<T> right, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Subtract(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Quaternion<T> left, ref Quaternion<T> right, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Multiply(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Quaternion<T> left, ref Quaternion<T> right, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Quaternion<T> quaternion, T scale, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Multiply(Quaternion<T> quaternion, T scale)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Conjugate(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void Conjugate(ref Quaternion<T> q, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Invert(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Quaternion<T> q, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Normalize(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void Normalize(ref Quaternion<T> q, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> FromAxisAngle(Vector3<T> axis, T angle)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> FromEulerAngles(T pitch, T yaw, T roll)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> FromEulerAngles(Vector3<T> eulerAngles)
        {
            throw new NotImplementedException();
        }

        public static void FromEulerAngles(ref Vector3<T> eulerAngles, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static void ToEulerAngles(in Quaternion<T> q, out Vector3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> FromMatrix(Matrix3X3<T> matrix)
        {
            throw new NotImplementedException();
        }

        public static void FromMatrix(ref Matrix3X3<T> matrix, out Quaternion<T> result)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> Slerp(Quaternion<T> q1, Quaternion<T> q2, T blend)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator +(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator -(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator *(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator *(Quaternion<T> quaternion, T scale)
        {
            throw new NotImplementedException();
        }

        public static Quaternion<T> operator *(T scale, Quaternion<T> quaternion)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Quaternion<T> left, Quaternion<T> right)
        {
            throw new NotImplementedException();
        }


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);
        
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Quaternion<T> other)
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
            // return true if int, uint, or float; false otherwise
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
