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
    public readonly struct Matrix2x2<T> : IEquatable<Matrix2x2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static Matrix2x2<T> Identity => new Matrix2x2<T>(One<T>(), default, One<T>(), default);
        public static Matrix2x2<T> Zero => default;
        public Vector2<T> Row0 { get; }
        public Vector2<T> Row1 { get; }

        public T M11 => Row0.X;
        public T M12 => Row0.Y;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;

        public Matrix2x2(Vector2<T> row0, Vector2<T> row1) => (Row0, Row1) = (row0, row1);

        public Matrix2x2(T m11, T m12, T m21, T m22) : this(new Vector2<T>(m11, m12), new Vector2<T>(m21, m22)) { }

        public Matrix2x2(T value) : this(new Vector2<T>(value), new Vector2<T>(value)) { }

        public T Determinant => s(m(M11, M22), m(M12, M21));

        public Vector2<T> Column0 => new Vector2<T>(M11, M21);

        public Vector2<T> Column1 => new Vector2<T>(M21, M22);

        public Vector2<T> Diagonal => new Vector2<T>(M11, M22);

        public T Trace => a(M11, M22);

        public T this[int rowIndex, int columnIndex] => (rowIndex switch { 0 => Row0, 1 => Row1 })[columnIndex];

        public Matrix2x2<T> WithM11(T m11) => new Matrix2x2<T>(m11, M12, M21, M22);
        public Matrix2x2<T> WithM12(T m12) => new Matrix2x2<T>(M11, m12, M21, M22);
        public Matrix2x2<T> WithM21(T m21) => new Matrix2x2<T>(M11, M12, m21, M22);
        public Matrix2x2<T> WithM22(T m22) => new Matrix2x2<T>(M11, M12, M21, m22);

        public static void CreateRotation(T angle, out Matrix2x2<T> result) => result = CreateRotation(angle);

        public static Matrix2x2<T> CreateRotation(T angle)
        {
            var sin = Sin(angle);
            var cos = Cos(angle);
            return new Matrix2x2<T>(cos, Negate(sin), sin, cos);
        }

        public static void CreateScale(T scale, out Matrix2x2<T> result) => result = CreateScale(scale);

        public static Matrix2x2<T> CreateScale(T scale) => CreateScale(new Vector2<T>(scale));

        public static void CreateScale(Vector2<T> scale, out Matrix2x2<T> result) => result = CreateScale(scale);

        public static Matrix2x2<T> CreateScale
            (Vector2<T> scale)
            => new Matrix2x2<T>(scale.X, default, default, scale.Y);

        public static void CreateScale(T x, T y, out Matrix2x2<T> result) => result = CreateScale(x, y);

        public static Matrix2x2<T> CreateScale(T x, T y) => CreateScale(new Vector2<T>(x, y));

        public static void Multiply
            (ref Matrix2x2<T> left, T right, out Matrix2x2<T> result)
            => result = Multiply(left, right);

        public static Matrix2x2<T> Multiply(Matrix2x2<T> left, T right) => Multiply(left, new Matrix2x2<T>(right));

        public static void Multiply(ref Matrix2x2<T> left, ref Matrix2x2<T> right, out Matrix2x2<T> result)
            => result = Multiply(left, right);

        public static Matrix2x2<T> Multiply(Matrix2x2<T> left, Matrix2x2<T> right)
            => new Matrix2x2<T>
                (m(left.M11, right.M11), m(left.M12, right.M12), m(left.M21, right.M21), m(left.M22, right.M22));

        public static void Multiply(ref Matrix2x2<T> left, ref Matrix2x3<T> right, out Matrix2x3<T> result)
            => throw new NotImplementedException();

        public static Matrix2x3<T> Multiply(Matrix2x2<T> left, Matrix2x3<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix2x2<T> left, ref Matrix2x4<T> right, out Matrix2x4<T> result)
            => throw new NotImplementedException();

        public static Matrix2x4<T> Multiply(Matrix2x2<T> left, Matrix2x4<T> right)
            => throw new NotImplementedException();

        public static void Add(ref Matrix2x2<T> left, ref Matrix2x2<T> right, out Matrix2x2<T> result)
            => throw new NotImplementedException();

        public static Matrix2x2<T> Add(Matrix2x2<T> left, Matrix2x2<T> right) => throw new NotImplementedException();

        public static void Subtract(ref Matrix2x2<T> left, ref Matrix2x2<T> right, out Matrix2x2<T> result)
            => throw new NotImplementedException();

        public static Matrix2x2<T> Subtract(Matrix2x2<T> left, Matrix2x2<T> right)
            => throw new NotImplementedException();

        public static void Invert(ref Matrix2x2<T> mat, out Matrix2x2<T> result) => throw new NotImplementedException();

        public static Matrix2x2<T> Invert(Matrix2x2<T> mat) => throw new NotImplementedException();

        public static void Transpose(ref Matrix2x2<T> mat, out Matrix2x2<T> result)
            => throw new NotImplementedException();

        public static Matrix2x2<T> Transpose(Matrix2x2<T> mat) => throw new NotImplementedException();

        public static Matrix2x2<T> operator *(T left, Matrix2x2<T> right) => throw new NotImplementedException();

        public static Matrix2x2<T> operator *(Matrix2x2<T> left, T right) => throw new NotImplementedException();

        public static Matrix2x2<T> operator *(Matrix2x2<T> left, Matrix2x2<T> right)
            => throw new NotImplementedException();

        public static Matrix2x3<T> operator *(Matrix2x2<T> left, Matrix2x3<T> right)
            => throw new NotImplementedException();

        public static Matrix2x4<T> operator *(Matrix2x2<T> left, Matrix2x4<T> right)
            => throw new NotImplementedException();

        public static Matrix2x2<T> operator +(Matrix2x2<T> left, Matrix2x2<T> right)
            => throw new NotImplementedException();

        public static Matrix2x2<T> operator -(Matrix2x2<T> left, Matrix2x2<T> right)
            => throw new NotImplementedException();

        public static bool operator ==(Matrix2x2<T> left, Matrix2x2<T> right) => throw new NotImplementedException();

        public static bool operator !=(Matrix2x2<T> left, Matrix2x2<T> right) => throw new NotImplementedException();


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public override int GetHashCode() => throw new NotImplementedException();

        public override bool Equals(object? obj) => throw new NotImplementedException();

        public bool Equals(Matrix2x2<T> other) => throw new NotImplementedException();
    }
}