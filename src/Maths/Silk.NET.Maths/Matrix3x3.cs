#region

using System;
using System.Globalization;

#endregion

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix3x3<T> : IEquatable<Matrix3x3<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Matrix3x3<T> Identity;
        public static readonly Matrix3x3<T> Zero;
        public Vector3<T> Row0 { get; }
        public Vector3<T> Row1 { get; }
        public Vector3<T> Row2 { get; }

        public T M11 => Row0.X;
        public T M12 => Row0.Y;
        public T M13 => Row0.Z;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;
        public T M23 => Row1.Z;

        public T M31 => Row2.X;
        public T M32 => Row2.Y;
        public T M33 => Row2.Z;

        public Matrix3x3(Vector3<T> row0, Vector3<T> row1, Vector3<T> row2) => throw new NotImplementedException();

        public Matrix3x3(T m00, T m01, T m02, T m10, T m11, T m12, T m20, T m21, T m22)
            => throw new NotImplementedException();

        public Matrix3x3(Matrix4x4<T> matrix) => throw new NotImplementedException();

        public T Determinant => throw new NotImplementedException();

        public Vector3<T> Column0 => throw new NotImplementedException();

        public Vector3<T> Column1 => throw new NotImplementedException();

        public Vector3<T> Column2 => throw new NotImplementedException();

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

        public void Transpose() => throw new NotImplementedException();

        public Matrix3x3<T> Normalized() => throw new NotImplementedException();

        public void Normalize() => throw new NotImplementedException();

        public Matrix3x3<T> Inverted() => throw new NotImplementedException();

        public Matrix3x3<T> ClearScale() => throw new NotImplementedException();

        public Matrix3x3<T> ClearRotation() => throw new NotImplementedException();

        public Vector3<T> ExtractScale() => throw new NotImplementedException();

        public Quaternion<T> ExtractRotation(bool rowNormalize = true) => throw new NotImplementedException();

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix3x3<T> result)
            => throw new NotImplementedException();

        public static Matrix3x3<T> CreateFromAxisAngle(Vector3<T> axis, T angle) => throw new NotImplementedException();

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix3x3<T> result)
            => throw new NotImplementedException();

        public static Matrix3x3<T> CreateFromQuaternion(Quaternion<T> q) => throw new NotImplementedException();

        public static void CreateRotationX(T angle, out Matrix3x3<T> result) => throw new NotImplementedException();

        public static Matrix3x3<T> CreateRotationX(T angle) => throw new NotImplementedException();

        public static void CreateRotationY(T angle, out Matrix3x3<T> result) => throw new NotImplementedException();

        public static Matrix3x3<T> CreateRotationY(T angle) => throw new NotImplementedException();

        public static void CreateRotationZ(T angle, out Matrix3x3<T> result) => throw new NotImplementedException();

        public static Matrix3x3<T> CreateRotationZ(T angle) => throw new NotImplementedException();

        public static Matrix3x3<T> CreateScale(T scale) => throw new NotImplementedException();

        public static Matrix3x3<T> CreateScale(Vector3<T> scale) => throw new NotImplementedException();

        public static Matrix3x3<T> CreateScale(T x, T y, T z) => throw new NotImplementedException();

        public static void CreateScale(T scale, out Matrix3x3<T> result) => throw new NotImplementedException();

        public static void CreateScale(ref Vector3<T> scale, out Matrix3x3<T> result)
            => throw new NotImplementedException();

        public static void CreateScale(T x, T y, T z, out Matrix3x3<T> result) => throw new NotImplementedException();

        public static Matrix3x3<T> Add(Matrix3x3<T> left, Matrix3x3<T> right) => throw new NotImplementedException();

        public static void Add(ref Matrix3x3<T> left, ref Matrix3x3<T> right, out Matrix3x3<T> result)
            => throw new NotImplementedException();

        public static Matrix3x3<T> Multiply(Matrix3x3<T> left, Matrix3x3<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix3x3<T> left, ref Matrix3x3<T> right, out Matrix3x3<T> result)
            => throw new NotImplementedException();

        public static void Invert(ref Matrix3x3<T> mat, out Matrix3x3<T> result) => throw new NotImplementedException();

        public static Matrix3x3<T> Invert(Matrix3x3<T> mat) => throw new NotImplementedException();

        public static Matrix3x3<T> Transpose(Matrix3x3<T> mat) => throw new NotImplementedException();

        public static void Transpose(ref Matrix3x3<T> mat, out Matrix3x3<T> result)
            => throw new NotImplementedException();

        public static Matrix3x3<T> operator *(Matrix3x3<T> left, Matrix3x3<T> right)
            => throw new NotImplementedException();

        public static bool operator ==(Matrix3x3<T> left, Matrix3x3<T> right) => throw new NotImplementedException();

        public static bool operator !=(Matrix3x3<T> left, Matrix3x3<T> right) => throw new NotImplementedException();


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

        public override int GetHashCode() => throw new NotImplementedException();

        public override bool Equals(object? obj) => throw new NotImplementedException();

        public bool Equals(Matrix3x3<T> other) => throw new NotImplementedException();
    }
}
