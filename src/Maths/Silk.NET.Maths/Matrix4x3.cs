// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix4x3<T> : IEquatable<Matrix4x3<T>> where T:unmanaged
    {
        public static readonly Matrix4x3<T> Zero;
        public Vector3<T> Row0;
        public Vector3<T> Row1;
        public Vector3<T> Row2;
        public Vector3<T> Row3;

        public Matrix4x3(Vector3<T> row0, Vector3<T> row1, Vector3<T> row2, Vector3<T> row3)
        {
            throw new NotImplementedException();
        }

        public Matrix4x3
        (
            T m00,
            T m01,
            T m02,
            T m10,
            T m11,
            T m12,
            T m20,
            T m21,
            T m22,
            T m30,
            T m31,
            T m32
        )
        {
            throw new NotImplementedException();
        }

        public Vector4<T> Column0 => throw new NotImplementedException();
        public Vector4<T> Column1 => throw new NotImplementedException();
        public Vector4<T> Column2 => throw new NotImplementedException();

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

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateFromQuaternion(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationX(T angle, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateRotationX(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationY(T angle, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateRotationY(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationZ(T angle, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateRotationZ(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(T x, T y, T z, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(ref Vector3<T> vector, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateTranslation(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateTranslation(Vector3<T> vector)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateScale(Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> CreateScale(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix4<T> Multiply(Matrix4x3<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4x3<T> left, ref Matrix3x4<T> right, out Matrix4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> Multiply(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4x3<T> left, ref Matrix4x3<T> right, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> Multiply(Matrix4x3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4x3<T> left, T right, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> Add(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix4x3<T> left, ref Matrix4x3<T> right, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> Subtract(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix4x3<T> left, ref Matrix4x3<T> right, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> Invert(Matrix4x3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Matrix4x3<T> mat, out Matrix4x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x4<T> Transpose(Matrix4x3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix4x3<T> mat, out Matrix3x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4<T> operator *(Matrix4x3<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> operator *(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> operator *(Matrix4x3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> operator +(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4x3<T> operator -(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix4x3<T> left, Matrix4x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix4x3<T> left, Matrix4x3<T> right)
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

        public bool Equals(Matrix4x3<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
