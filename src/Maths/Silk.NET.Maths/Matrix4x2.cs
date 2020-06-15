// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    public struct Matrix4X2<T> : IEquatable<Matrix4X2<T>> where T:unmanaged
    {
        public static readonly Matrix4X2<T> Zero;
        public Vector2<T> Row0;
        public Vector2<T> Row1;
        public Vector2<T> Row2;
        public Vector2<T> Row3;

        public Matrix4X2(Vector2<T> row0, Vector2<T> row1, Vector2<T> row2, Vector2<T> row3)
        {
            throw new NotImplementedException();
        }

        public Matrix4X2
        (
            T m00,
            T m01,
            T m10,
            T m11,
            T m20,
            T m21,
            T m30,
            T m31
        )
        {
            throw new NotImplementedException();
        }

        public Vector4<T> Column0
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector4<T> Column1
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Diagonal
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

        public static void CreateRotation(T angle, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> CreateRotation(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(Vector2<T> scale, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> CreateScale(Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> CreateScale(T x, T y)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X2<T> left, T right, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> Multiply(Matrix4X2<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X2<T> left, ref Matrix2X2<T> right, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> Multiply(Matrix4X2<T> left, Matrix2X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X2<T> left, ref Matrix2X3<T> right, out Matrix4X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> Multiply(Matrix4X2<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X2<T> left, ref Matrix2X4<T> right, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Multiply(Matrix4X2<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix4X2<T> left, ref Matrix4X2<T> right, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> Add(Matrix4X2<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix4X2<T> left, ref Matrix4X2<T> right, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> Subtract(Matrix4X2<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix4X2<T> mat, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> Transpose(Matrix4X2<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> operator *(T left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> operator *(Matrix4X2<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> operator *(Matrix4X2<T> left, Matrix2X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X3<T> operator *(Matrix4X2<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> operator *(Matrix4X2<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> operator +(Matrix4X2<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> operator -(Matrix4X2<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix4X2<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix4X2<T> left, Matrix4X2<T> right)
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

        public bool Equals(Matrix4X2<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
