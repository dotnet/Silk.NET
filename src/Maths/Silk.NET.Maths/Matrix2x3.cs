// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;

namespace Silk.NET.Maths
{
    public struct Matrix2X3<T> : IEquatable<Matrix2X3<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Matrix2X3<T> Zero;
        public Vector3<T> Row0;
        public Vector3<T> Row1;
        
        public T M11 => Row0.X;
        public T M12 => Row0.Y;
        public T M13 => Row0.Z;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;
        public T M23 => Row1.Z;

        public Matrix2X3(Vector3<T> row0, Vector3<T> row1)
        {
            throw new NotImplementedException();
        }

        public Matrix2X3(T m00, T m01, T m02, T m10, T m11, T m12)
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

        public static void CreateRotation(T angle, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> CreateRotation(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(Vector2<T> scale, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> CreateScale(Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> CreateScale(T x, T y)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X3<T> left, T right, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> Multiply(Matrix2X3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X3<T> left, ref Matrix3x2<T> right, out Matrix2X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X2<T> Multiply(Matrix2X3<T> left, Matrix3x2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X3<T> left, ref Matrix3X3<T> right, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> Multiply(Matrix2X3<T> left, Matrix3X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X3<T> left, ref Matrix3X4<T> right, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> Multiply(Matrix2X3<T> left, Matrix3X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix2X3<T> left, ref Matrix2X3<T> right, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> Add(Matrix2X3<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix2X3<T> left, ref Matrix2X3<T> right, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> Subtract(Matrix2X3<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix2X3<T> mat, out Matrix3x2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix3x2<T> Transpose(Matrix2X3<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> operator *(T left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> operator *(Matrix2X3<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X2<T> operator *(Matrix2X3<T> left, Matrix3x2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> operator *(Matrix2X3<T> left, Matrix3X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> operator *(Matrix2X3<T> left, Matrix3X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> operator +(Matrix2X3<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> operator -(Matrix2X3<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix2X3<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix2X3<T> left, Matrix2X3<T> right)
        {
            throw new NotImplementedException();
        }


        public override string ToString() => ToString("G");

        public string ToString(string format) => ToString(format, CultureInfo.CurrentCulture);
        
        public string ToString(string format, IFormatProvider formatProvider)
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

        public bool Equals(Matrix2X3<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
