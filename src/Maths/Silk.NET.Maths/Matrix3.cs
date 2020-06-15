// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix3<T> : IEquatable<Matrix3<T>> where T:unmanaged
    {
        public static readonly Matrix3<T> Identity;
        public static readonly Matrix3<T> Zero;
        public Vector3<T> Row0;
        public Vector3<T> Row1;
        public Vector3<T> Row2;

        public Matrix3(Vector3<T> row0, Vector3<T> row1, Vector3<T> row2)
        {
            throw new NotImplementedException();
        }

        public Matrix3
        (
            T m00,
            T m01,
            T m02,
            T m10,
            T m11,
            T m12,
            T m20,
            T m21,
            T m22
        )
        {
            throw new NotImplementedException();
        }

        public Matrix3(Matrix4<T> matrix)
        {
            throw new NotImplementedException();
        }

        public T Determinant => throw new NotImplementedException();

        public Vector3<T> Column0 => throw new NotImplementedException();

        public Vector3<T> Column1 => throw new NotImplementedException();

        public Vector3<T> Column2 => throw new NotImplementedException();

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

        public void Transpose()
        {
            throw new NotImplementedException();
        }

        public Matrix3<T> Normalized()
        {
            throw new NotImplementedException();
        }

        public void Normalize()
        {
            throw new NotImplementedException();
        }

        public Matrix3<T> Inverted()
        {
            throw new NotImplementedException();
        }

        public Matrix3<T> ClearScale()
        {
            throw new NotImplementedException();
        }

        public Matrix3<T> ClearRotation()
        {
            throw new NotImplementedException();
        }

        public Vector3<T> ExtractScale()
        {
            throw new NotImplementedException();
        }

        public Quaternion<T> ExtractRotation(bool rowNormalize = true)
        {
            throw new NotImplementedException();
        }

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateFromQuaternion(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationX(T angle, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateRotationX(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationY(T angle, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateRotationY(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationZ(T angle, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateRotationZ(T angle)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateScale(Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> CreateScale(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(ref Vector3<T> scale, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, T z, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> Add(Matrix3<T> left, Matrix3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix3<T> left, ref Matrix3<T> right, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> Multiply(Matrix3<T> left, Matrix3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix3<T> left, ref Matrix3<T> right, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Matrix3<T> mat, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> Invert(Matrix3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> Transpose(Matrix3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix3<T> mat, out Matrix3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3<T> operator *(Matrix3<T> left, Matrix3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix3<T> left, Matrix3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix3<T> left, Matrix3<T> right)
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

        public bool Equals(Matrix3<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
