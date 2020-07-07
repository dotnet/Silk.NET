#region

using System;
using System.Globalization;
using static Silk.NET.Maths.Scalar;

#endregion

namespace Silk.NET.Maths
{
    [Serializable]
    [Generator.GenerateMethodAliases]
    public readonly partial struct Matrix4x4<T> : IEquatable<Matrix4x4<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static Matrix4x4<T> Identity
            => new Matrix4x4<T>(Vector4<T>.UnitX, Vector4<T>.UnitY, Vector4<T>.UnitZ, Vector4<T>.UnitW);

        public static Matrix4x4<T> Zero => default;
        public readonly Vector4<T> Row0 { get; }
        public readonly Vector4<T> Row1 { get; }
        public readonly Vector4<T> Row2 { get; }
        public readonly Vector4<T> Row3 { get; }

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

        public T M41 => Row3.X;
        public T M42 => Row3.Y;
        public T M43 => Row3.Z;
        public T M44 => Row3.W;


        public Matrix4x4(Vector4<T> row0, Vector4<T> row1, Vector4<T> row2, Vector4<T> row3)
            => (Row0, Row1, Row2, Row3) = (row0, row1, row2, row3);

        public Matrix4x4
        (
            T m11,
            T m12,
            T m13,
            T m14,
            T m21,
            T m22,
            T m23,
            T m24,
            T m31,
            T m32,
            T m33,
            T m34,
            T m41,
            T m42,
            T m43,
            T m44
        ) : this
        (
            new Vector4<T>(m11, m12, m13, m14), new Vector4<T>(m21, m22, m23, m24), new Vector4<T>(m31, m32, m33, m34),
            new Vector4<T>(m41, m42, m43, m44)
        )
        { }

        public Matrix4x4(Matrix3x3<T> topLeft) : this
        (
            new Vector4<T>(topLeft.Row0, default), new Vector4<T>(topLeft.Row1, default), new Vector4<T>(topLeft.Row2, default), Vector4<T>.UnitW
        )
        { }

        public Matrix4x4<T> WithRow0(Vector4<T> row0) => new Matrix4x4<T>(row0, Row1, Row2, Row3);
        public Matrix4x4<T> WithRow1(Vector4<T> row1) => new Matrix4x4<T>(Row0, row1, Row2, Row3);
        public Matrix4x4<T> WithRow2(Vector4<T> row2) => new Matrix4x4<T>(Row0, Row1, row2, Row3);
        public Matrix4x4<T> WithRow3(Vector4<T> row3) => new Matrix4x4<T>(Row0, Row1, Row2, row3);

        public Matrix4x4<T> WithColumn0(Vector4<T> column)
            => new Matrix4x4<T>
                (column.X, M12, M13, M14, column.Y, M22, M23, M24, column.Z, M32, M33, M34, column.W, M42, M43, M44);

        public Matrix4x4<T> WithColumn1(Vector4<T> column)
            => new Matrix4x4<T>
                (M11, column.X, M13, M14, M21, column.Y, M23, M24, M31, column.Z, M33, M34, M41, column.W, M43, M44);

        public Matrix4x4<T> WithColumn2(Vector4<T> column)
            => new Matrix4x4<T>
                (M11, M12, column.X, M14, M21, M22, column.Y, M24, M31, M32, column.Z, M34, M41, M42, column.W, M44);

        public Matrix4x4<T> WithColumn3(Vector4<T> column)
            => new Matrix4x4<T>
                (M11, M12, M13, column.X, M21, M22, M23, column.Y, M31, M32, M33, column.Z, M41, M42, M43, column.W);

        public Matrix4x4<T> WithM11(T m11) => WithRow0(new Vector4<T>(m11, M12, M13, M14));
        public Matrix4x4<T> WithM12(T m12) => WithRow0(new Vector4<T>(M11, m12, M13, M14));
        public Matrix4x4<T> WithM13(T m13) => WithRow0(new Vector4<T>(M11, M12, m13, M14));
        public Matrix4x4<T> WithM14(T m14) => WithRow0(new Vector4<T>(M11, M12, M13, m14));

        public Matrix4x4<T> WithM21(T m21) => WithRow1(new Vector4<T>(m21, M22, M23, M24));
        public Matrix4x4<T> WithM22(T m22) => WithRow1(new Vector4<T>(M21, m22, M23, M24));
        public Matrix4x4<T> WithM23(T m23) => WithRow1(new Vector4<T>(M21, M22, m23, M24));
        public Matrix4x4<T> WithM24(T m24) => WithRow1(new Vector4<T>(M21, M22, M23, m24));

        public Matrix4x4<T> WithM31(T m31) => WithRow2(new Vector4<T>(m31, M32, M33, M34));
        public Matrix4x4<T> WithM32(T m32) => WithRow2(new Vector4<T>(M31, m32, M33, M34));
        public Matrix4x4<T> WithM33(T m33) => WithRow2(new Vector4<T>(M31, M32, m33, M34));
        public Matrix4x4<T> WithM34(T m34) => WithRow2(new Vector4<T>(M31, M32, M33, m34));

        public Matrix4x4<T> WithM41(T m41) => WithRow3(new Vector4<T>(m41, M42, M43, M44));
        public Matrix4x4<T> WithM42(T m42) => WithRow3(new Vector4<T>(M41, m42, M43, M44));
        public Matrix4x4<T> WithM43(T m43) => WithRow3(new Vector4<T>(M41, M42, m43, M44));
        public Matrix4x4<T> WithM44(T m44) => WithRow3(new Vector4<T>(M41, M42, M43, m44));

        public T Determinant
            => Scalar.Add
            (
                Scalar.Subtract
                (
                    Scalar.Add
                    (
                        Scalar.Subtract
                        (
                            Scalar.Add
                            (
                                Scalar.Subtract
                                (
                                    Scalar.Subtract
                                    (
                                        Scalar.Add
                                        (
                                            Scalar.Subtract
                                            (
                                                Scalar.Add
                                                (
                                                    Scalar.Subtract
                                                    (
                                                        Scalar.Add
                                                        (
                                                            Scalar.Add
                                                            (
                                                                Scalar.Subtract
                                                                (
                                                                    Scalar.Add
                                                                    (
                                                                        Scalar.Subtract
                                                                        (
                                                                            Scalar.Add
                                                                            (
                                                                                Scalar.Subtract
                                                                                (
                                                                                    Scalar.Subtract
                                                                                    (
                                                                                        Scalar.Add
                                                                                        (
                                                                                            Scalar.Subtract
                                                                                            (
                                                                                                Scalar.Add
                                                                                                (
                                                                                                    Scalar.Subtract
                                                                                                    (
                                                                                                        Scalar.Multiply
                                                                                                        (
                                                                                                            Scalar
                                                                                                                .Multiply
                                                                                                                (
                                                                                                                    Scalar
                                                                                                                        .Multiply
                                                                                                                        (
                                                                                                                            M11,
                                                                                                                            M22
                                                                                                                        ),
                                                                                                                    M33
                                                                                                                ), M44
                                                                                                        ),
                                                                                                        Scalar.Multiply
                                                                                                        (
                                                                                                            Scalar
                                                                                                                .Multiply
                                                                                                                (
                                                                                                                    Scalar
                                                                                                                        .Multiply
                                                                                                                        (
                                                                                                                            M11,
                                                                                                                            M22
                                                                                                                        ),
                                                                                                                    M34
                                                                                                                ), M43
                                                                                                        )
                                                                                                    ),
                                                                                                    Scalar.Multiply
                                                                                                    (
                                                                                                        Scalar.Multiply
                                                                                                        (
                                                                                                            Scalar
                                                                                                                .Multiply
                                                                                                                (
                                                                                                                    M11,
                                                                                                                    M23
                                                                                                                ), M34
                                                                                                        ), M42
                                                                                                    )
                                                                                                ),
                                                                                                Scalar.Multiply
                                                                                                (
                                                                                                    Scalar.Multiply
                                                                                                    (
                                                                                                        Scalar.Multiply
                                                                                                            (M11, M23),
                                                                                                        M32
                                                                                                    ), M44
                                                                                                )
                                                                                            ),
                                                                                            Scalar.Multiply
                                                                                            (
                                                                                                Scalar.Multiply
                                                                                                (
                                                                                                    Scalar.Multiply
                                                                                                        (M11, M24), M32
                                                                                                ), M43
                                                                                            )
                                                                                        ),
                                                                                        Scalar.Multiply
                                                                                        (
                                                                                            Scalar.Multiply
                                                                                            (
                                                                                                Scalar.Multiply
                                                                                                    (M11, M24), M33
                                                                                            ), M42
                                                                                        )
                                                                                    ),
                                                                                    Scalar.Multiply
                                                                                    (
                                                                                        Scalar.Multiply
                                                                                        (
                                                                                            Scalar.Multiply(M12, M23),
                                                                                            M34
                                                                                        ), M41
                                                                                    )
                                                                                ),
                                                                                Scalar.Multiply
                                                                                (
                                                                                    Scalar.Multiply
                                                                                    (
                                                                                        Scalar.Multiply(M12, M23), M31
                                                                                    ), M44
                                                                                )
                                                                            ),
                                                                            Scalar.Multiply
                                                                            (
                                                                                Scalar.Multiply
                                                                                    (Scalar.Multiply(M12, M24), M31),
                                                                                M43
                                                                            )
                                                                        ),
                                                                        Scalar.Multiply
                                                                        (
                                                                            Scalar.Multiply
                                                                                (Scalar.Multiply(M12, M24), M33), M41
                                                                        )
                                                                    ),
                                                                    Scalar.Multiply
                                                                    (
                                                                        Scalar.Multiply(Scalar.Multiply(M12, M21), M33),
                                                                        M44
                                                                    )
                                                                ),
                                                                Scalar.Multiply
                                                                (
                                                                    Scalar.Multiply(Scalar.Multiply(M12, M21), M34), M43
                                                                )
                                                            ),
                                                            Scalar.Multiply
                                                                (Scalar.Multiply(Scalar.Multiply(M13, M24), M31), M42)
                                                        ),
                                                        Scalar.Multiply
                                                            (Scalar.Multiply(Scalar.Multiply(M13, M24), M32), M41)
                                                    ),
                                                    Scalar.Multiply
                                                        (Scalar.Multiply(Scalar.Multiply(M13, M21), M32), M44)
                                                ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M13, M21), M34), M42)
                                            ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M13, M22), M34), M41)
                                        ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M13, M22), M31), M44)
                                    ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M14, M21), M32), M43)
                                ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M14, M21), M33), M42)
                            ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M14, M22), M33), M41)
                        ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M14, M22), M31), M43)
                    ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M14, M23), M31), M42)
                ), Scalar.Multiply(Scalar.Multiply(Scalar.Multiply(M14, M23), M32), M41)
            );

        public static Vector4<T> GetColumn0(Matrix4x4<T> mat) => new Vector4<T>(mat.M11, mat.M21, mat.M31, mat.M41);
        public static Vector4<T> GetColumn1(Matrix4x4<T> mat) => new Vector4<T>(mat.M12, mat.M22, mat.M32, mat.M42);
        public static Vector4<T> GetColumn2(Matrix4x4<T> mat) => new Vector4<T>(mat.M13, mat.M23, mat.M33, mat.M43);
        public static Vector4<T> GetColumn3(Matrix4x4<T> mat) => new Vector4<T>(mat.M14, mat.M24, mat.M34, mat.M44);
        public static Vector4<T> GetDiagonal(Matrix4x4<T> mat) => new Vector4<T>(mat.M11, mat.M22, mat.M33, mat.M44);

        public static T GetTrace
            (Matrix4x4<T> mat)
            => Scalar.Add(Scalar.Add(Scalar.Add(mat.M11, mat.M22), mat.M33), mat.M44);

        public T this[int rowIndex, int columnIndex] => this[rowIndex][columnIndex];

        public Vector4<T> this[int rowIndex]
        {
            get
            {
                if (rowIndex == 0)
                {
                    return Row0;
                }

                if (rowIndex == 1)
                {
                    return Row1;
                }

                if (rowIndex == 2)
                {
                    return Row2;
                }

                if (rowIndex == 3)
                {
                    return Row3;
                }

                ThrowIndexOutOfRange();
                return default;
            }
        }

        public static Matrix4x4<T> CreateFromAxisAngle(Vector3<T> axis, T angle) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateFromQuaternion(Quaternion<T> q) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateRotationX(T angle) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateRotationY(T angle) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateRotationZ(T angle) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateTranslation(Vector3<T> vector) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateScale(T scale) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateScale(Vector3<T> scale) => throw new NotImplementedException();

        public static Matrix4x4<T> CreateOrthographic(T width, T height, T depthNear, T depthFar)
            => throw new NotImplementedException();

        public static Matrix4x4<T> CreateOrthographicOffCenter
            (T left, T right, T bottom, T top, T depthNear, T depthFar)
            => throw new NotImplementedException();

        public static Matrix4x4<T> CreatePerspectiveFieldOfView(T fovy, T aspect, T depthNear, T depthFar)
            => throw new NotImplementedException();

        public static Matrix4x4<T> CreatePerspectiveOffCenter(T left, T right, T bottom, T top, T depthNear, T depthFar)
            => throw new NotImplementedException();

        public static Matrix4x4<T> LookAt(Vector3<T> eye, Vector3<T> target, Vector3<T> up)
            => throw new NotImplementedException();

        public static Matrix4x4<T> Add(Matrix4x4<T> left, Matrix4x4<T> right) => throw new NotImplementedException();

        public static Matrix4x4<T> Subtract(Matrix4x4<T> left, Matrix4x4<T> right)
            => throw new NotImplementedException();

        public static Matrix4x4<T> Multiply(Matrix4x4<T> left, Matrix4x4<T> right)
            => throw new NotImplementedException();

        public static Matrix4x4<T> Multiply(Matrix4x4<T> left, T right) => throw new NotImplementedException();

        public static Matrix4x4<T> Invert(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Matrix4x4<T> Normalize(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Matrix4x4<T> ClearTranslation(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Matrix4x4<T> ClearScale(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Matrix4x4<T> ClearRotation(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Matrix4x4<T> ClearProjection(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Vector3<T> ExtractTranslation(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Vector3<T> ExtractScale(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Quaternion<T> ExtractRotation(Matrix4x4<T> mat, bool rowNormalize = true)
            => throw new NotImplementedException();

        public static Vector4<T> ExtractProjection(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static Matrix4x4<T> Transpose(Matrix4x4<T> mat) => throw new NotImplementedException();

        public static bool operator ==(Matrix4x4<T> left, Matrix4x4<T> right) => left.Equals(right);

        public static bool operator !=(Matrix4x4<T> left, Matrix4x4<T> right) => !(left == right);

        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string? format, IFormatProvider? formatProvider)
            => string.Format
            (
                formatProvider,
                "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} {{M31:{8} M32:{9} M33:{10} M34:{11}}} {{M41:{12} M42:{13} M43:{14} M44:{15}}} }}",
                M11.ToString(format, formatProvider), M12.ToString(format, formatProvider),
                M13.ToString(format, formatProvider), M14.ToString(format, formatProvider),
                M21.ToString(format, formatProvider), M22.ToString(format, formatProvider),
                M23.ToString(format, formatProvider), M24.ToString(format, formatProvider),
                M31.ToString(format, formatProvider), M32.ToString(format, formatProvider),
                M33.ToString(format, formatProvider), M34.ToString(format, formatProvider),
                M41.ToString(format, formatProvider), M42.ToString(format, formatProvider),
                M43.ToString(format, formatProvider), M44.ToString(format, formatProvider)
            );

        public override int GetHashCode() => HashCode.Combine(Row0, Row1, Row2, Row3);

        public override bool Equals(object? obj) => obj is Matrix4x4<T> matrix && Equals(matrix);

        public bool Equals(Matrix4x4<T> other)
            => Row0 == other.Row0 && Row1 == other.Row1 && Row2 == other.Row2 && Row3 == other.Row3;
    }
}