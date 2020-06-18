// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix4X3<T> : IEquatable<Matrix4X3<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Matrix4X3<T> Zero;
        public Vector3<T> Row0;
        public Vector3<T> Row1;
        public Vector3<T> Row2;
        public Vector3<T> Row3;

        public T M11 => Row0.X;
        public T M12 => Row0.Y;
        public T M13 => Row0.Z;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;
        public T M23 => Row1.Z;
        
        public T M31 => Row2.X;
        public T M32 => Row2.Y;
        public T M33 => Row2.Z;
        
        public T M41 => Row3.X;
        public T M42 => Row3.Y;
        public T M43 => Row3.Z;

        public Matrix4X3(Vector3<T> row0, Vector3<T> row1, Vector3<T> row2, Vector3<T> row3)
        {
            throw new NotImplementedException();
        }

        public Matrix4X3
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

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateFromQuaternion(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationX(T angle, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateRotationX(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationY(T angle, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateRotationY(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationZ(T angle, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateRotationZ(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(T x, T y, T z, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(ref Vector3<T> vector, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateTranslation(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateTranslation(Vector3<T> vector)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateScale(Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> CreateScale(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Multiply(Matrix4X3<T> left, Matrix3X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X3<T> left, ref Matrix3X4<T> right, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> Multiply(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X3<T> left, ref Matrix4X3<T> right, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> Multiply(Matrix4X3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X3<T> left, T right, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> Add(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix4X3<T> left, ref Matrix4X3<T> right, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> Subtract(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix4X3<T> left, ref Matrix4X3<T> right, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> Invert(Matrix4X3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Matrix4X3<T> mat, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3X4<T> Transpose(Matrix4X3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix4X3<T> mat, out Matrix3X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> operator *(Matrix4X3<T> left, Matrix3X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> operator *(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> operator *(Matrix4X3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> operator +(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> operator -(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix4X3<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);
        
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Matrix4X3<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
