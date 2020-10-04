// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;
using static Silk.NET.Maths.ShortScalarHelper;
using static Silk.NET.Maths.Scalar;

namespace Silk.NET.Maths
{
    public readonly struct Matrix4x2<T> : IEquatable<Matrix4x2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static Matrix4x2<T> Zero => default;
        public Vector2<T> Row0 { get; }
        public Vector2<T> Row1 { get; }
        public Vector2<T> Row2 { get; }
        public Vector2<T> Row3 { get; }

        public T M11 => Row0.X;
        public T M12 => Row0.Y;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;

        public T M31 => Row2.X;
        public T M32 => Row2.Y;

        public T M41 => Row3.X;
        public T M42 => Row3.Y;

        public Matrix4x2(Vector2<T> row0, Vector2<T> row1, Vector2<T> row2, Vector2<T> row3)
            => throw new NotImplementedException();

        public Matrix4x2(T m11, T m12, T m21, T m22, T m31, T m32, T m41, T m42) => throw new NotImplementedException();

        public Vector4<T> Column0
        {
            get => throw new NotImplementedException();
        }

        public Vector4<T> Column1
        {
            get => throw new NotImplementedException();
        }

        public Vector2<T> Diagonal
        {
            get => throw new NotImplementedException();
        }

        public T Trace => throw new NotImplementedException();

        public T this[int rowIndex, int columnIndex]
        {
            get => throw new NotImplementedException();
        }

        public static void CreateRotation(T angle, out Matrix4x2<T> result) => throw new NotImplementedException();

        public static Matrix4x2<T> CreateRotation(T angle) => throw new NotImplementedException();

        public static void CreateScale(T scale, out Matrix4x2<T> result) => throw new NotImplementedException();

        public static Matrix4x2<T> CreateScale(T scale) => throw new NotImplementedException();

        public static void CreateScale
            (Vector2<T> scale, out Matrix4x2<T> result)
            => throw new NotImplementedException();

        public static Matrix4x2<T> CreateScale(Vector2<T> scale) => throw new NotImplementedException();

        public static void CreateScale(T x, T y, out Matrix4x2<T> result) => throw new NotImplementedException();

        public static Matrix4x2<T> CreateScale(T x, T y) => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x2<T> left, T right, out Matrix4x2<T> result)
            => throw new NotImplementedException();

        public static Matrix4x2<T> Multiply(Matrix4x2<T> left, T right) => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x2<T> left, ref Matrix2x2<T> right, out Matrix4x2<T> result)
            => throw new NotImplementedException();

        public static Matrix4x2<T> Multiply(Matrix4x2<T> left, Matrix2x2<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x2<T> left, ref Matrix2x3<T> right, out Matrix4x3<T> result)
            => throw new NotImplementedException();

        public static Matrix4x3<T> Multiply(Matrix4x2<T> left, Matrix2x3<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x2<T> left, ref Matrix2x4<T> right, out Matrix4x4<T> result)
            => throw new NotImplementedException();

        public static Matrix4x4<T> Multiply(Matrix4x2<T> left, Matrix2x4<T> right)
            => throw new NotImplementedException();

        public static void Add(ref Matrix4x2<T> left, ref Matrix4x2<T> right, out Matrix4x2<T> result)
            => throw new NotImplementedException();

        public static Matrix4x2<T> Add(Matrix4x2<T> left, Matrix4x2<T> right) => throw new NotImplementedException();

        public static void Subtract(ref Matrix4x2<T> left, ref Matrix4x2<T> right, out Matrix4x2<T> result)
            => throw new NotImplementedException();

        public static Matrix4x2<T> Subtract(Matrix4x2<T> left, Matrix4x2<T> right)
            => throw new NotImplementedException();

        public static void Transpose(ref Matrix4x2<T> mat, out Matrix2x4<T> result)
            => throw new NotImplementedException();

        public static Matrix2x4<T> Transpose(Matrix4x2<T> mat) => throw new NotImplementedException();

        public static Matrix4x2<T> operator *(T left, Matrix4x2<T> right) => throw new NotImplementedException();

        public static Matrix4x2<T> operator *(Matrix4x2<T> left, T right) => throw new NotImplementedException();

        public static Matrix4x2<T> operator *(Matrix4x2<T> left, Matrix2x2<T> right)
            => throw new NotImplementedException();

        public static Matrix4x3<T> operator *(Matrix4x2<T> left, Matrix2x3<T> right)
            => throw new NotImplementedException();

        public static Matrix4x4<T> operator *(Matrix4x2<T> left, Matrix2x4<T> right)
            => throw new NotImplementedException();

        public static Matrix4x2<T> operator +(Matrix4x2<T> left, Matrix4x2<T> right)
            => throw new NotImplementedException();

        public static Matrix4x2<T> operator -(Matrix4x2<T> left, Matrix4x2<T> right)
            => throw new NotImplementedException();

        public static bool operator ==(Matrix4x2<T> left, Matrix4x2<T> right) => throw new NotImplementedException();

        public static bool operator !=(Matrix4x2<T> left, Matrix4x2<T> right) => throw new NotImplementedException();


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public override int GetHashCode() => throw new NotImplementedException();

        public override bool Equals(object? obj) => throw new NotImplementedException();

        public bool Equals(Matrix4x2<T> other) => throw new NotImplementedException();
    }
}