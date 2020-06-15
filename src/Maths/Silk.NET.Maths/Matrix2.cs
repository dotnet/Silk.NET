// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    public struct Matrix2<T> : IEquatable<Matrix2<T>> where T:unmanaged
    {
        public static readonly Matrix2<T> Identity;
        public static readonly Matrix2<T> Zero;
        public Vector2<T> Row0;
        public Vector2<T> Row1;

        public Matrix2(Vector2<T> row0, Vector2<T> row1)
        {
            throw new NotImplementedException();
        }

        public Matrix2(T m00, T m01, T m10, T m11)
        {
            throw new NotImplementedException();
        }

        public T Determinant => throw new NotImplementedException();

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

        public void Transpose()
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public static void CreateRotation(T angle, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> CreateRotation(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(Vector2<T> scale, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> CreateScale(Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> CreateScale(T x, T y)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2<T> left, T right, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Multiply(Matrix2<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2<T> left, ref Matrix2<T> right, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Multiply(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2<T> left, ref Matrix2x3<T> right, out Matrix2x3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> Multiply(Matrix2<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2<T> left, ref Matrix2x4<T> right, out Matrix2x4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x4<T> Multiply(Matrix2<T> left, Matrix2x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix2<T> left, ref Matrix2<T> right, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Add(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix2<T> left, ref Matrix2<T> right, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Subtract(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Matrix2<T> mat, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Invert(Matrix2<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix2<T> mat, out Matrix2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> Transpose(Matrix2<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> operator *(T left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> operator *(Matrix2<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> operator *(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x3<T> operator *(Matrix2<T> left, Matrix2x3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2x4<T> operator *(Matrix2<T> left, Matrix2x4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> operator +(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2<T> operator -(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix2<T> left, Matrix2<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix2<T> left, Matrix2<T> right)
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

        public bool Equals(Matrix2<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
