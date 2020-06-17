// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;

namespace Silk.NET.Maths
{
    [Serializable]
    public struct Matrix4X4<T> : IEquatable<Matrix4X4<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public static readonly Matrix4X4<T> Identity;
        public static readonly Matrix4X4<T> Zero;
        public Vector4<T> Row0;
        public Vector4<T> Row1;
        public Vector4<T> Row2;
        public Vector4<T> Row3;

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

        
        public Matrix4X4(Vector4<T> row0, Vector4<T> row1, Vector4<T> row2, Vector4<T> row3)
        {
            throw new NotImplementedException();
        }

        public Matrix4X4
        (
            T m00,
            T m01,
            T m02,
            T m03,
            T m10,
            T m11,
            T m12,
            T m13,
            T m20,
            T m21,
            T m22,
            T m23,
            T m30,
            T m31,
            T m32,
            T m33
        )
        {
            throw new NotImplementedException();
        }

        public Matrix4X4(Matrix3X3<T> topLeft)
        {
            throw new NotImplementedException();
        }

        public T Determinant => throw new NotImplementedException();

        public Vector4<T> Column0
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector4<T> Column1
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector4<T> Column2
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector4<T> Column3
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector4<T> Diagonal
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

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public void Transpose()
        {
            throw new NotImplementedException();
        }

        public Matrix4X4<T> Normalized()
        {
            throw new NotImplementedException();
        }

        public void Normalize()
        {
            throw new NotImplementedException();
        }

        public Matrix4X4<T> Inverted()
        {
            throw new NotImplementedException();
        }

        public Matrix4X4<T> ClearTranslation()
        {
            throw new NotImplementedException();
        }

        public Matrix4X4<T> ClearScale()
        {
            throw new NotImplementedException();
        }

        public Matrix4X4<T> ClearRotation()
        {
            throw new NotImplementedException();
        }

        public Matrix4X4<T> ClearProjection()
        {
            throw new NotImplementedException();
        }

        public Vector3<T> ExtractTranslation()
        {
            throw new NotImplementedException();
        }

        public Vector3<T> ExtractScale()
        {
            throw new NotImplementedException();
        }

        public Quaternion<T> ExtractRotation(bool rowNormalize = true)
        {
            throw new NotImplementedException();
        }

        public Vector4<T> ExtractProjection()
        {
            throw new NotImplementedException();
        }

        public static void CreateFromAxisAngle(Vector3<T> axis, T angle, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateFromQuaternion(ref Quaternion<T> q, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateFromQuaternion(Quaternion<T> q)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationX(T angle, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateRotationX(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationY(T angle, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateRotationY(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateRotationZ(T angle, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateRotationZ(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(T x, T y, T z, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateTranslation(ref Vector3<T> vector, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateTranslation(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateTranslation(Vector3<T> vector)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateScale(Vector3<T> scale)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateScale(T x, T y, T z)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(ref Vector3<T> scale, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, T z, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static void CreateOrthographic
        (
            T width,
            T height,
            T depthNear,
            T depthFar,
            out Matrix4X4<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateOrthographic
        (
            T width,
            T height,
            T depthNear,
            T depthFar
        )
        {
            throw new NotImplementedException();
        }

        public static void CreateOrthographicOffCenter
        (
            T left,
            T right,
            T bottom,
            T top,
            T depthNear,
            T depthFar,
            out Matrix4X4<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreateOrthographicOffCenter
        (
            T left,
            T right,
            T bottom,
            T top,
            T depthNear,
            T depthFar
        )
        {
            throw new NotImplementedException();
        }

        public static void CreatePerspectiveFieldOfView
        (
            T fovy,
            T aspect,
            T depthNear,
            T depthFar,
            out Matrix4X4<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreatePerspectiveFieldOfView
        (
            T fovy,
            T aspect,
            T depthNear,
            T depthFar
        )
        {
            throw new NotImplementedException();
        }

        public static void CreatePerspectiveOffCenter
        (
            T left,
            T right,
            T bottom,
            T top,
            T depthNear,
            T depthFar,
            out Matrix4X4<T> result
        )
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> CreatePerspectiveOffCenter
        (
            T left,
            T right,
            T bottom,
            T top,
            T depthNear,
            T depthFar
        )
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> LookAt(Vector3<T> eye, Vector3<T> target, Vector3<T> up)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> LookAt
        (
            T eyeX,
            T eyeY,
            T eyeZ,
            T targetX,
            T targetY,
            T targetZ,
            T upX,
            T upY,
            T upZ
        )
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Add(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix4X4<T> left, ref Matrix4X4<T> right, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Subtract(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix4X4<T> left, ref Matrix4X4<T> right, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Multiply(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X4<T> left, ref Matrix4X4<T> right, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Multiply(Matrix4X4<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix4X4<T> left, T right, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static void Invert(ref Matrix4X4<T> mat, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Invert(Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> Transpose(Matrix4X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix4X4<T> mat, out Matrix4X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> operator *(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> operator *(Matrix4X4<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> operator +(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X4<T> operator -(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix4X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix4X4<T> left, Matrix4X4<T> right)
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

        public bool Equals(Matrix4X4<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
