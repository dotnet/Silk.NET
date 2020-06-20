// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;

namespace Silk.NET.Maths
{
    public struct Matrix3x2<T> : IEquatable<Matrix3x2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Matrix3x2<T> Zero;
        public Vector2<T> Row0;
        public Vector2<T> Row1;
        public Vector2<T> Row2;

        public T M11 => Row0.X;
        public T M12 => Row0.Y;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;

        public T M31 => Row2.X;
        public T M32 => Row2.Y;

        public Matrix3x2(Vector2<T> row0, Vector2<T> row1, Vector2<T> row2) => throw new NotImplementedException();

        public Matrix3x2(T m00, T m01, T m10, T m11, T m20, T m21) => throw new NotImplementedException();

        public Vector3<T> Column0
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector3<T> Column1
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

        public static void CreateRotation(T angle, out Matrix3x2<T> result) => throw new NotImplementedException();

        public static Matrix3x2<T> CreateRotation(T angle) => throw new NotImplementedException();

        public static void CreateScale(T scale, out Matrix3x2<T> result) => throw new NotImplementedException();

        public static Matrix3x2<T> CreateScale(T scale) => throw new NotImplementedException();

        public static void CreateScale
            (Vector2<T> scale, out Matrix3x2<T> result) => throw new NotImplementedException();

        public static Matrix3x2<T> CreateScale(Vector2<T> scale) => throw new NotImplementedException();

        public static void CreateScale(T x, T y, out Matrix3x2<T> result) => throw new NotImplementedException();

        public static Matrix3x2<T> CreateScale(T x, T y) => throw new NotImplementedException();

        public static void Multiply
            (ref Matrix3x2<T> left, T right, out Matrix3x2<T> result) => throw new NotImplementedException();

        public static Matrix3x2<T> Multiply(Matrix3x2<T> left, T right) => throw new NotImplementedException();

        public static void Multiply
            (ref Matrix3x2<T> left, ref Matrix2X2<T> right, out Matrix3x2<T> result) =>
            throw new NotImplementedException();

        public static Matrix3x2<T> Multiply
            (Matrix3x2<T> left, Matrix2X2<T> right) => throw new NotImplementedException();

        public static void Multiply
            (ref Matrix3x2<T> left, ref Matrix2X3<T> right, out Matrix3X3<T> result) =>
            throw new NotImplementedException();

        public static Matrix3X3<T> Multiply
            (Matrix3x2<T> left, Matrix2X3<T> right) => throw new NotImplementedException();

        public static void Multiply
            (ref Matrix3x2<T> left, ref Matrix2X4<T> right, out Matrix3X4<T> result) =>
            throw new NotImplementedException();

        public static Matrix3X4<T> Multiply
            (Matrix3x2<T> left, Matrix2X4<T> right) => throw new NotImplementedException();

        public static void Add
            (ref Matrix3x2<T> left, ref Matrix3x2<T> right, out Matrix3x2<T> result) =>
            throw new NotImplementedException();

        public static Matrix3x2<T> Add(Matrix3x2<T> left, Matrix3x2<T> right) => throw new NotImplementedException();

        public static void Subtract
            (ref Matrix3x2<T> left, ref Matrix3x2<T> right, out Matrix3x2<T> result) =>
            throw new NotImplementedException();

        public static Matrix3x2<T> Subtract
            (Matrix3x2<T> left, Matrix3x2<T> right) => throw new NotImplementedException();

        public static void Transpose
            (ref Matrix3x2<T> mat, out Matrix2X3<T> result) => throw new NotImplementedException();

        public static Matrix2X3<T> Transpose(Matrix3x2<T> mat) => throw new NotImplementedException();

        public static Matrix3x2<T> operator *(T left, Matrix3x2<T> right) => throw new NotImplementedException();

        public static Matrix3x2<T> operator *(Matrix3x2<T> left, T right) => throw new NotImplementedException();

        public static Matrix3x2<T> operator *
            (Matrix3x2<T> left, Matrix2X2<T> right) => throw new NotImplementedException();

        public static Matrix3X3<T> operator *
            (Matrix3x2<T> left, Matrix2X3<T> right) => throw new NotImplementedException();

        public static Matrix3X4<T> operator *
            (Matrix3x2<T> left, Matrix2X4<T> right) => throw new NotImplementedException();

        public static Matrix3x2<T> operator +
            (Matrix3x2<T> left, Matrix3x2<T> right) => throw new NotImplementedException();

        public static Matrix3x2<T> operator -
            (Matrix3x2<T> left, Matrix3x2<T> right) => throw new NotImplementedException();

        public static bool operator ==(Matrix3x2<T> left, Matrix3x2<T> right) => throw new NotImplementedException();

        public static bool operator !=(Matrix3x2<T> left, Matrix3x2<T> right) => throw new NotImplementedException();


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public override int GetHashCode() => throw new NotImplementedException();

        public override bool Equals(object? obj) => throw new NotImplementedException();

        public bool Equals(Matrix3x2<T> other) => throw new NotImplementedException();
    }
}
