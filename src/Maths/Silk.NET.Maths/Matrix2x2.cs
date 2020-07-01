#region

using System;
using System.Globalization;
using static Silk.NET.Maths.ShortScalarHelper;
using static Silk.NET.Maths.Scalar;

#endregion

namespace Silk.NET.Maths
{
    public struct Matrix2X2<T> : IEquatable<Matrix2X2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Matrix2X2<T> Identity;
        public static readonly Matrix2X2<T> Zero;
        public Vector2<T> Row0;
        public Vector2<T> Row1;

        public T M11 => Row0.X;
        public T M12 => Row0.Y;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;

        public Matrix2X2(Vector2<T> row0, Vector2<T> row1) => (Row0, Row1) = (row0, row1);

        public Matrix2X2(T m11, T m12, T m21, T m22) : this(new Vector2<T>(m11, m12), new Vector2<T>(m21, m22)) { }
        
        public Matrix2X2(T value) : this(new Vector2<T>(value), new Vector2<T>(value)) { }

        public T Determinant => s(m(M11, M22), m(M12, M21));

        public Vector2<T> Column0 => new Vector2<T>(M11, M21);

        public Vector2<T> Column1 => new Vector2<T>(M21, M22);

        public Vector2<T> Diagonal => new Vector2<T>(M11, M22);

        public T Trace => a(M11, M22);

        public T this[int rowIndex, int columnIndex] => (rowIndex switch { 0 => Row0, 1 => Row1 })[columnIndex];

        public Matrix2X2<T> WithM11(T m11) => new Matrix2X2<T>(m11, M12, M21, M22);
        public Matrix2X2<T> WithM12(T m12) => new Matrix2X2<T>(M11, m12, M21, M22);
        public Matrix2X2<T> WithM21(T m21) => new Matrix2X2<T>(M11, M12, m21, M22);
        public Matrix2X2<T> WithM22(T m22) => new Matrix2X2<T>(M11, M12, M21, m22);

        public static void CreateRotation(T angle, out Matrix2X2<T> result) => result = CreateRotation(angle);

        public static Matrix2X2<T> CreateRotation(T angle)
        {
            var sin = Sin(angle);
            var cos = Cos(angle);
            return new Matrix2X2<T>(cos, Negate(sin), sin, cos);
        }

        public static void CreateScale(T scale, out Matrix2X2<T> result) => result = CreateScale(scale);

        public static Matrix2X2<T> CreateScale(T scale) => CreateScale(new Vector2<T>(scale));

        public static void CreateScale(Vector2<T> scale, out Matrix2X2<T> result) => result = CreateScale(scale);

        public static Matrix2X2<T> CreateScale(Vector2<T> scale) => new Matrix2X2<T>(scale.X, default, default, scale.Y);

        public static void CreateScale(T x, T y, out Matrix2X2<T> result) => result = CreateScale(x, y);

        public static Matrix2X2<T> CreateScale(T x, T y) => CreateScale(new Vector2<T>(x, y));

        public static void Multiply
            (ref Matrix2X2<T> left, T right, out Matrix2X2<T> result)
            => result = Multiply(left, right);

        public static Matrix2X2<T> Multiply(Matrix2X2<T> left, T right) => Multiply(left, new Matrix2X2<T>(right));

        public static void Multiply(ref Matrix2X2<T> left, ref Matrix2X2<T> right, out Matrix2X2<T> result)
            => result = Multiply(left, right);

        public static Matrix2X2<T> Multiply(Matrix2X2<T> left, Matrix2X2<T> right)
            => new Matrix2X2<T>(m(left.M11, right.M11), m(left.M12, right.M12), m(left.M21, right.M21), m(left.M22, right
            .M22));

        public static void Multiply(ref Matrix2X2<T> left, ref Matrix2X3<T> right, out Matrix2X3<T> result)
            => throw new NotImplementedException();

        public static Matrix2X3<T> Multiply(Matrix2X2<T> left, Matrix2X3<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix2X2<T> left, ref Matrix2X4<T> right, out Matrix2X4<T> result)
            => throw new NotImplementedException();

        public static Matrix2X4<T> Multiply(Matrix2X2<T> left, Matrix2X4<T> right)
            => throw new NotImplementedException();

        public static void Add(ref Matrix2X2<T> left, ref Matrix2X2<T> right, out Matrix2X2<T> result)
            => throw new NotImplementedException();

        public static Matrix2X2<T> Add(Matrix2X2<T> left, Matrix2X2<T> right) => throw new NotImplementedException();

        public static void Subtract(ref Matrix2X2<T> left, ref Matrix2X2<T> right, out Matrix2X2<T> result)
            => throw new NotImplementedException();

        public static Matrix2X2<T> Subtract(Matrix2X2<T> left, Matrix2X2<T> right)
            => throw new NotImplementedException();

        public static void Invert(ref Matrix2X2<T> mat, out Matrix2X2<T> result) => throw new NotImplementedException();

        public static Matrix2X2<T> Invert(Matrix2X2<T> mat) => throw new NotImplementedException();

        public static void Transpose(ref Matrix2X2<T> mat, out Matrix2X2<T> result)
            => throw new NotImplementedException();

        public static Matrix2X2<T> Transpose(Matrix2X2<T> mat) => throw new NotImplementedException();

        public static Matrix2X2<T> operator *(T left, Matrix2X2<T> right) => throw new NotImplementedException();

        public static Matrix2X2<T> operator *(Matrix2X2<T> left, T right) => throw new NotImplementedException();

        public static Matrix2X2<T> operator *(Matrix2X2<T> left, Matrix2X2<T> right)
            => throw new NotImplementedException();

        public static Matrix2X3<T> operator *(Matrix2X2<T> left, Matrix2X3<T> right)
            => throw new NotImplementedException();

        public static Matrix2X4<T> operator *(Matrix2X2<T> left, Matrix2X4<T> right)
            => throw new NotImplementedException();

        public static Matrix2X2<T> operator +(Matrix2X2<T> left, Matrix2X2<T> right)
            => throw new NotImplementedException();

        public static Matrix2X2<T> operator -(Matrix2X2<T> left, Matrix2X2<T> right)
            => throw new NotImplementedException();

        public static bool operator ==(Matrix2X2<T> left, Matrix2X2<T> right) => throw new NotImplementedException();

        public static bool operator !=(Matrix2X2<T> left, Matrix2X2<T> right) => throw new NotImplementedException();


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public override int GetHashCode() => throw new NotImplementedException();

        public override bool Equals(object? obj) => throw new NotImplementedException();

        public bool Equals(Matrix2X2<T> other) => throw new NotImplementedException();
    }
}