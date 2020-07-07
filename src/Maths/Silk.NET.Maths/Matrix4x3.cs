#region

using System;
using System.Globalization;

#endregion

namespace Silk.NET.Maths
{
    [Serializable]
    public readonly struct Matrix4x3<T> : IEquatable<Matrix4x3<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static Matrix4x3<T> Zero => default;
        public readonly Vector3<T> Row0 { get; }
        public readonly Vector3<T> Row1 { get; }
        public readonly Vector3<T> Row2 { get; }
        public readonly Vector3<T> Row3 { get; }

        public T M11 => Row0.X;
        public T M12 => Row0.Y;
        public T M13 => Row0.Z;

        public T M21 => Row1.X;
        public T M22 => Row1.Y;
        public T M23 => Row1.Z;

        public T M31 => Row2.X;
        public T M32 => Row2.Y;
        public T M33 => Row2.Z;

        public T M41 => Row3.X;
        public T M42 => Row3.Y;
        public T M43 => Row3.Z;

        public Matrix4x3(Vector3<T> row0, Vector3<T> row1, Vector3<T> row2, Vector3<T> row3)
            => (Row0, Row1, Row2, Row3) = (row0, row1, row2, row3);

        public Matrix4x3(T m11, T m12, T m13, T m21, T m22, T m23, T m31, T m32, T m33, T m41, T m42, T m43) : this
        (
            new Vector3<T>(m11, m12, m13), new Vector3<T>(m21, m22, m23), new Vector3<T>(m31, m32, m33),
            new Vector3<T>(m41, m42, m43)
        )
        { }


        public Matrix4x3<T> WithRow0(Vector3<T> row0) => new Matrix4x3<T>(row0, Row1, Row2, Row3);
        public Matrix4x3<T> WithRow1(Vector3<T> row1) => new Matrix4x3<T>(Row0, row1, Row2, Row3);
        public Matrix4x3<T> WithRow2(Vector3<T> row2) => new Matrix4x3<T>(Row0, Row1, row2, Row3);
        public Matrix4x3<T> WithRow3(Vector3<T> row3) => new Matrix4x3<T>(Row0, Row1, Row2, row3);

        public Matrix4x3<T> WithColumn0(Vector4<T> column)
            => new Matrix4x3<T>(column.X, M12, M13, column.Y, M22, M23, column.Z, M32, M33, column.W, M42, M43);

        public Matrix4x3<T> WithColumn1(Vector4<T> column)
            => new Matrix4x3<T>(M11, column.X, M13, M21, column.Y, M23, M31, column.Z, M33, M41, column.W, M43);

        public Matrix4x3<T> WithColumn2(Vector4<T> column)
            => new Matrix4x3<T>(M11, M12, column.X, M21, M22, column.Y, M31, M32, column.Z, M41, M42, column.W);

        public Matrix4x3<T> WithM11(T m11) => WithRow0(new Vector3<T>(m11, M12, M13));
        public Matrix4x3<T> WithM12(T m12) => WithRow0(new Vector3<T>(M11, m12, M13));
        public Matrix4x3<T> WithM13(T m13) => WithRow0(new Vector3<T>(M11, M12, m13));

        public Matrix4x3<T> WithM21(T m21) => WithRow1(new Vector3<T>(m21, M22, M23));
        public Matrix4x3<T> WithM22(T m22) => WithRow1(new Vector3<T>(M21, m22, M23));
        public Matrix4x3<T> WithM23(T m23) => WithRow1(new Vector3<T>(M21, M22, m23));

        public Matrix4x3<T> WithM31(T m31) => WithRow2(new Vector3<T>(m31, M32, M33));
        public Matrix4x3<T> WithM32(T m32) => WithRow2(new Vector3<T>(M31, m32, M33));
        public Matrix4x3<T> WithM33(T m33) => WithRow2(new Vector3<T>(M31, M32, m33));

        public Matrix4x3<T> WithM41(T m41) => WithRow3(new Vector3<T>(m41, M42, M43));
        public Matrix4x3<T> WithM42(T m42) => WithRow3(new Vector3<T>(M41, m42, M43));
        public Matrix4x3<T> WithM43(T m43) => WithRow3(new Vector3<T>(M41, M42, m43));

        public Vector4<T> Column0 => new Vector4<T>(M11, M21, M31, M41);
        public Vector4<T> Column1 => new Vector4<T>(M12, M22, M32, M42);
        public Vector4<T> Column2 => new Vector4<T>(M13, M23, M33, M43);

        public Vector3<T> Diagonal => new Vector3<T>(M11, M22, M33);

        public T Trace => throw new NotImplementedException();

        public T this[int rowIndex, int columnIndex] => this[rowIndex][columnIndex];

        public Vector3<T> this[int rowIndex] => rowIndex switch { 0 => Row0, 1 => Row1, 2 => Row2, 3 => Row3 };

        public static Matrix4x4<T> CreateFromAxisAngle(Vector3<T> axis, T angle) => throw new NotImplementedException();

        public static void CreateFromAxisAngle(ref Vector3<T> axis, T angle, out Matrix4x4<T> result)
            => result = CreateFromAxisAngle(axis, angle);

        public static Matrix4x4<T> CreateFromQuaternion(Quaternion<T> q) => throw new NotImplementedException();

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix4x4<T> result)
            => result = CreateFromQuaternion(q);

        public static Matrix4x4<T> CreateRotationX(T angle) => throw new NotImplementedException();

        public static void CreateRotationX(T angle, out Matrix4x4<T> result) => result = CreateRotationX(angle);

        public static Matrix4x4<T> CreateRotationY(T angle) => throw new NotImplementedException();

        public static void CreateRotationY(T angle, out Matrix4x4<T> result) => result = CreateRotationY(angle);

        public static Matrix4x4<T> CreateRotationZ(T angle) => throw new NotImplementedException();

        public static void CreateRotationZ(T angle, out Matrix4x4<T> result) => result = CreateRotationZ(angle);

        public static Matrix4x3<T> CreateTranslation(T x, T y, T z) => throw new NotImplementedException();

        public static Matrix4x3<T> CreateTranslation(Vector3<T> vector) => throw new NotImplementedException();

        public static void CreateTranslation(T x, T y, T z, out Matrix4x3<T> result)
            => result = CreateTranslation(x, y, z);

        public static void CreateTranslation(ref Vector3<T> vector, out Matrix4x3<T> result)
            => result = CreateTranslation(vector);

        public static Matrix4x3<T> CreateScale(T scale) => throw new NotImplementedException();

        public static Matrix4x3<T> CreateScale(Vector3<T> scale) => throw new NotImplementedException();

        public static Matrix4x3<T> CreateScale(T x, T y, T z) => throw new NotImplementedException();

        public static Matrix4x4<T> Multiply(Matrix4x3<T> left, Matrix3x4<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x3<T> left, ref Matrix3x4<T> right, out Matrix4x4<T> result)
            => result = Multiply(left, right);

        public static Matrix4x3<T> Multiply(Matrix4x3<T> left, Matrix4x3<T> right)
            => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x3<T> left, ref Matrix4x3<T> right, out Matrix4x3<T> result)
            => result = Multiply(left, right);

        public static Matrix4x3<T> Multiply(Matrix4x3<T> left, T right) => throw new NotImplementedException();

        public static void Multiply(ref Matrix4x3<T> left, T right, out Matrix4x3<T> result)
            => result = Multiply(left, right);

        public static Matrix4x3<T> Add(Matrix4x3<T> left, Matrix4x3<T> right) => throw new NotImplementedException();

        public static void Add(ref Matrix4x3<T> left, ref Matrix4x3<T> right, out Matrix4x3<T> result)
            => result = Add(left, right);

        public static Matrix4x3<T> Subtract(Matrix4x3<T> left, Matrix4x3<T> right)
            => throw new NotImplementedException();

        public static void Subtract(ref Matrix4x3<T> left, ref Matrix4x3<T> right, out Matrix4x3<T> result)
            => result = Subtract(left, right);

        public static Matrix4x3<T> Invert(Matrix4x3<T> mat) => throw new NotImplementedException();

        public static void Invert(ref Matrix4x3<T> mat, out Matrix4x3<T> result) => result = Invert(mat);

        public static Matrix3x4<T> Transpose(Matrix4x3<T> mat) => throw new NotImplementedException();

        public static void Transpose(ref Matrix4x3<T> mat, out Matrix3x4<T> result) => result = Transpose(mat);

        public static Matrix4x4<T> operator *(Matrix4x3<T> left, Matrix3x4<T> right) => Multiply(left, right);

        public static Matrix4x3<T> operator *(Matrix4x3<T> left, Matrix4x3<T> right) => Multiply(left, right);

        public static Matrix4x3<T> operator *(Matrix4x3<T> left, T right) => Multiply(left, right);
        public static Matrix4x3<T> operator *(T left, Matrix4x3<T> right) => Multiply(right, left);

        public static Matrix4x3<T> operator +(Matrix4x3<T> left, Matrix4x3<T> right) => Add(left, right);

        public static Matrix4x3<T> operator -(Matrix4x3<T> left, Matrix4x3<T> right) => Subtract(left, right);

        public static bool operator ==(Matrix4x3<T> left, Matrix4x3<T> right) => left.Equals(right);

        public static bool operator !=(Matrix4x3<T> left, Matrix4x3<T> right) => !(left == right);


        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider)
            => string.Format
            (
                formatProvider,
                "{{ {{M11:{0} M12:{1} M13:{2}}} {{M21:{3} M22:{4} M23:{5}}} {{M31:{6} M32:{7} M33:{8}}} {{M41:{9} M42:{10} M43:{11}}} }}",
                M11.ToString(format, formatProvider), M12.ToString(format, formatProvider),
                M13.ToString(format, formatProvider), M21.ToString(format, formatProvider),
                M22.ToString(format, formatProvider), M23.ToString(format, formatProvider),
                M31.ToString(format, formatProvider), M32.ToString(format, formatProvider),
                M33.ToString(format, formatProvider), M41.ToString(format, formatProvider),
                M42.ToString(format, formatProvider), M43.ToString(format, formatProvider)
            );

        public override int GetHashCode() => HashCode.Combine(Row0, Row1, Row2, Row3);

        public override bool Equals(object? obj) => obj is Matrix4x3<T> matrix && Equals(matrix);

        public bool Equals(Matrix4x3<T> other)
            => Row0 == other.Row0 && Row1 == other.Row1 && Row2 == other.Row2 && Row3 == other.Row3;
    }
}