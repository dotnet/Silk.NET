// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    public struct Matrix2x3<T> : IEquatable<Matrix2x3<T>> where T:unmanaged
    {
        public static readonly Matrix2x3<T> Zero;
        public Vector3<T> Row0;
        public Vector3<T> Row1;

        public Matrix2x3(Vector3<T> row0, Vector3<T> row1)
        {
            throw new NotImplementedException();
        }

        public Matrix2x3(T m00, T m01, T m02, T m10, T m11, T m12)
        {
            throw new NotImplementedException();
        }

        public Vector2<T> Column0
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Column1
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Column2
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

        public static void CreateRotation(T angle, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> CreateRotation(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(Vector2<T> scale, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> CreateScale(Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> CreateScale(T x, T y)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2x3<T> left, T right, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> Multiply(Matrix2x3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2x3<T> left, ref Matrix3x2<T> right, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Multiply(Matrix2x3<T> left, Matrix3x2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2x3<T> left, ref Matrix3<T> right, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> Multiply(Matrix2x3<T> left, Matrix3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2x3<T> left, ref Matrix3x4<T> right, out Matrix2x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x4<T> Multiply(Matrix2x3<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix2x3<T> left, ref Matrix2x3<T> right, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> Add(Matrix2x3<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix2x3<T> left, ref Matrix2x3<T> right, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> Subtract(Matrix2x3<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix2x3<T> mat, out Matrix3x2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x2<T> Transpose(Matrix2x3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> operator *(T left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> operator *(Matrix2x3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> operator *(Matrix2x3<T> left, Matrix3x2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> operator *(Matrix2x3<T> left, Matrix3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x4<T> operator *(Matrix2x3<T> left, Matrix3x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> operator +(Matrix2x3<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> operator -(Matrix2x3<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix2x3<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix2x3<T> left, Matrix2x3<T> right)
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

        public bool Equals(Matrix2x3<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
