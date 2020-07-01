#region

using System;
using System.Globalization;

#endregion

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix3X4<T> : IEquatable<Matrix3X4<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static Matrix3X4<T> Zero;
        public Vector4<T> Row0;
        public Vector4<T> Row1;
        public Vector4<T> Row2;

        public T M11 => Row0.X;
        public T M12 => Row0.Y;
        public T M13 => Row0.Z;
        public T M14 => Row0.W;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;
        public T M23 => Row1.Z;
        public T M24 => Row1.W;

        public T M31 => Row2.X;
        public T M32 => Row2.Y;
        public T M33 => Row2.Z;
        public T M34 => Row2.W;

        public Matrix3X4(Vector4<T> row0, Vector4<T> row1, Vector4<T> row2) => throw new NotImplementedException();

        public Matrix3X4(T m00, T m01, T m02, T m03, T m10, T m11, T m12, T m13, T m20, T m21, T m22, T m23)
            => throw new NotImplementedException();

        public Vector3<T> Column0 => throw new NotImplementedException();

        public Vector3<T> Column1 => throw new NotImplementedException();

        public Vector3<T> Column2 => throw new NotImplementedException();

        public Vector3<T> Column3 => throw new NotImplementedException();

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

        public void Invert() => throw new NotImplementedException();

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> CreateFromAxisAngle(Vector3<T> axis, T angle) => throw new NotImplementedException();

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> CreateFromQuaternion(Quaternion<T> q) => throw new NotImplementedException();

        public static void CreateRotationX(T angle, out Matrix3X4<T> result) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateRotationX(T angle) => throw new NotImplementedException();

        public static void CreateRotationY(T angle, out Matrix3X4<T> result) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateRotationY(T angle) => throw new NotImplementedException();

        public static void CreateRotationZ(T angle, out Matrix3X4<T> result) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateRotationZ(T angle) => throw new NotImplementedException();

        public static void CreateTranslation(T x, T y, T z, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static void CreateTranslation(ref Vector3<T> vector, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> CreateTranslation(T x, T y, T z) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateTranslation(Vector3<T> vector) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateScale(T scale) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateScale(Vector3<T> scale) => throw new NotImplementedException();

        public static Matrix3X4<T> CreateScale(T x, T y, T z) => throw new NotImplementedException();

        public static Matrix3X3<T> Multiply(Matrix3X4<T> left, Matrix4X3<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix3X4<T> left, ref Matrix4X3<T> right, out Matrix3X3<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> Multiply(Matrix3X4<T> left, Matrix3X4<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix3X4<T> left, ref Matrix3X4<T> right, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> Multiply(Matrix3X4<T> left, T right) => throw new NotImplementedException();

        public static void Multiply(ref Matrix3X4<T> left, T right, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> Add(Matrix3X4<T> left, Matrix3X4<T> right) => throw new NotImplementedException();

        public static void Add(ref Matrix3X4<T> left, ref Matrix3X4<T> right, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> Subtract(Matrix3X4<T> left, Matrix3X4<T> right)
            => throw new NotImplementedException();

        public static void Subtract(ref Matrix3X4<T> left, ref Matrix3X4<T> right, out Matrix3X4<T> result)
            => throw new NotImplementedException();

        public static Matrix3X4<T> Invert(Matrix3X4<T> mat) => throw new NotImplementedException();

        public static void Invert(ref Matrix3X4<T> mat, out Matrix3X4<T> result) => throw new NotImplementedException();

        public static Matrix4X3<T> Transpose(Matrix3X4<T> mat) => throw new NotImplementedException();

        public static void Transpose(ref Matrix3X4<T> mat, out Matrix4X3<T> result)
            => throw new NotImplementedException();

        public static Matrix3X3<T> operator *(Matrix3X4<T> left, Matrix4X3<T> right)
            => throw new NotImplementedException();

        public static Matrix3X4<T> operator *(Matrix3X4<T> left, Matrix3X4<T> right)
            => throw new NotImplementedException();

        public static Matrix3X4<T> operator *(Matrix3X4<T> left, T right) => throw new NotImplementedException();

        public static Matrix3X4<T> operator +(Matrix3X4<T> left, Matrix3X4<T> right)
            => throw new NotImplementedException();

        public static Matrix3X4<T> operator -(Matrix3X4<T> left, Matrix3X4<T> right)
            => throw new NotImplementedException();

        public static bool operator ==(Matrix3X4<T> left, Matrix3X4<T> right) => throw new NotImplementedException();

        public static bool operator !=(Matrix3X4<T> left, Matrix3X4<T> right) => throw new NotImplementedException();


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public override int GetHashCode() => throw new NotImplementedException();

        public override bool Equals(object? obj) => throw new NotImplementedException();

        public bool Equals(Matrix3X4<T> other) => throw new NotImplementedException();
    }
}