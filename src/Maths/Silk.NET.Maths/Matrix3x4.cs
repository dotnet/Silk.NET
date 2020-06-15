// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix3x4<T> : IEquatable<Matrix3x4<T>> where T:unmanaged
    {
        public static Matrix3x4<T> Zero;
        public Vector4<T> Row0;
        public Vector4<T> Row1;
        public Vector4<T> Row2;

        public Matrix3x4(Vector4<T> row0, Vector4<T> row1, Vector4<T> row2)
        {
            throw new NotImplementedException();
        }

        public Matrix3x4
        (
            T m00,
            T m01,
            T m02,
            T m03,
            T m10,
            T m11,
            T m12,
            T m13,
            T m20,
            T m21,
            T m22,
            T m23
        )
        {
            throw new NotImplementedException();
        }

        public Vector3<T> Column0 => throw new NotImplementedException();

        public Vector3<T> Column1 => throw new NotImplementedException();

        public Vector3<T> Column2 => throw new NotImplementedException();

        public Vector3<T> Column3 => throw new NotImplementedException();

        public Vector3<T> Diagonal
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public T Trace => throw new NotImplementedException();

        public T this[int rowIndex, int columnIndex]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateFromQuaternion(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationX(T angle, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateRotationX(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationY(T angle, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateRotationY(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationZ(T angle, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateRotationZ(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(T x, T y, T z, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(ref Vector3<T> vector, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateTranslation(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateTranslation(Vector3<T> vector)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateScale(Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> CreateScale(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> Multiply(Matrix3x4<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix3x4<T> left, ref Matrix4x3<T> right, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> Multiply(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix3x4<T> left, ref Matrix3x4<T> right, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> Multiply(Matrix3x4<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix3x4<T> left, T right, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> Add(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix3x4<T> left, ref Matrix3x4<T> right, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> Subtract(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix3x4<T> left, ref Matrix3x4<T> right, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> Invert(Matrix3x4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Matrix3x4<T> mat, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> Transpose(Matrix3x4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix3x4<T> mat, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> operator *(Matrix3x4<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> operator *(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> operator *(Matrix3x4<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> operator +(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> operator -(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix3x4<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix3x4<T> left, Matrix3x4<T> right)
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

        public bool Equals(Matrix3x4<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
