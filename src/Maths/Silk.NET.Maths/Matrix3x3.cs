using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public struct Matrix3x3<T> : IEquatable<Matrix3x3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix3x3<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One
        );

        /// <summary>
        /// Row 1 of the matrix.
        /// </summary>
        [IgnoreDataMember] 
        public Vector3<T> Row1;
        
        /// <summary>
        /// Row 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3<T> Row2;
        
        /// <summary>
        /// Row 3 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3<T> Row3;

        /// <summary>
        /// Column 1 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3<T> Column1 => new(Row1.X, Row2.X, Row3.X);
        
        
        /// <summary>
        /// Column 2 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3<T> Column2 => new(Row1.Y, Row2.Y, Row3.Y);
        
        
        /// <summary>
        /// Column 3 of the matrix.
        /// </summary>
        [IgnoreDataMember]
        public Vector3<T> Column3 => new(Row1.Z, Row2.Z, Row3.Z);

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        [DataMember]
        public T M11
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        [DataMember]
        public T M12
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        [DataMember]
        public T M13
        {
            readonly get => Row1.Z;
            set => Row1.Z = value;
        }

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        [DataMember]
        public T M21
        {
            readonly get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        [DataMember]
        public T M22
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        [DataMember]
        public T M23
        {
            readonly get => Row2.Z;
            set => Row2.Z = value;
        }

        /// <summary>Value at row 3, column 1 of the matrix.</summary>
        [DataMember]
        public T M31
        {
            readonly get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>Value at row 3, column 2 of the matrix.</summary>
        [DataMember]
        public T M32
        {
            readonly get => Row3.Y;
            set => Row3.Y = value;
        }

        /// <summary>Value at row 3, column 3 of the matrix.</summary>
        [DataMember]
        public T M33
        {
            readonly get => Row3.Z;
            set => Row3.Z = value;
        }

        public Matrix3x3(Vector3<T> row1, Vector3<T> row2, Vector3<T> row3)
        {
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }
        
        /// <summary>Constructs a Matrix3x3 from the given components.</summary>
        public Matrix3x3(T m11, T m12, T m13, T m21, T m22, T m23, T m31, T m32, T m33)
        {
            Row1 = new(m11, m12, m13);
            Row2 = new(m21, m22, m23);
            Row3 = new(m31, m32, m33);
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix3x3(Matrix3x2<T> value)
        {
            Row1 = new(value.M11, value.M12, default);
            Row2 = new(value.M21, value.M22, default);
            Row3 = new(value.M31, value.M32, Scalar<T>.One);
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix3x3(Matrix4x3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix3x3(Matrix3x4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix3x3.</summary>
        /// <param name="value">The source Matrix3x3.</param>
        public Matrix3x3(Matrix3x3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix2x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix3x3(Matrix2x4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = Vector3<T>.UnitZ;
        }
        
        /// <summary>Constructs a Matrix3x3 from the given Matrix4x2.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix3x3(Matrix4x2<T> value)
        {
            Row1 = new(value.M11, value.M12, default);
            Row2 = new(value.M21, value.M22, default);
            Row3 = new(value.M31, value.M32, Scalar<T>.One);
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix4x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix3x3(Matrix4x4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }
        
        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3x3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) && Scalar.Equal(M22, Scalar<T>.One) &&
               Scalar.Equal(M33, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M13, Scalar<T>.Zero) &&
               Scalar.Equal(M21, Scalar<T>.Zero) && Scalar.Equal(M23, Scalar<T>.Zero) &&
               Scalar.Equal(M31, Scalar<T>.Zero) && Scalar.Equal(M32, Scalar<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix3x3<T> operator +(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return new(value1.Row1 + value2.Row1, value1.Row2 + value2.Row2, value1.Row3 + value2.Row3);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return Scalar.Equal(value1.M11, value2.M11) && Scalar.Equal(value1.M22, value2.M22) &&
                   Scalar.Equal(value1.M33, value2.M33) &&
                   // Check diagonal elements first for early out.
                   Scalar.Equal(value1.M12, value2.M12) && Scalar.Equal(value1.M13, value2.M13) &&
                   Scalar.Equal(value1.M21, value2.M21) && Scalar.Equal(value1.M23, value2.M23) &&
                   Scalar.Equal(value1.M31, value2.M31) && Scalar.Equal(value1.M32, value2.M32);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return Scalar.NotEqual(value1.M11, value2.M11) || Scalar.NotEqual(value1.M22, value2.M22) ||
                   Scalar.NotEqual(value1.M33, value2.M33) || // Check diagonal elements first for early out.
                   Scalar.NotEqual(value1.M12, value2.M12) || Scalar.NotEqual(value1.M13, value2.M13) ||
                   Scalar.NotEqual(value1.M21, value2.M21) || Scalar.NotEqual(value1.M23, value2.M23) ||
                   Scalar.NotEqual(value1.M31, value2.M31) || Scalar.NotEqual(value1.M32, value2.M32);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x3<T> operator *(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return new(
                    value1.M11 * value2.Row1 + value1.M12 * value2.Row2 + value1.M13 * value2.Row3,
                    value1.M21 * value2.Row1 + value1.M22 * value2.Row2 + value1.M23 * value2.Row3,
                    value1.M31 * value2.Row1 + value1.M32 * value2.Row2 + value1.M33 * value2.Row3
                );
        }
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector3<T> operator *(Vector3<T> value1, Matrix3x3<T> value2)
        {
            return value1.X * value2.Row1 + value1.Y * value2.Row2 + value1.Z * value2.Row3;
        }
        
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix3x3<T> operator *(Matrix3x3<T> value1, T value2)
        {
            return new(value1.Row1 * value2, value1.Row2 * value2, value1.Row3 * value2);
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix3x3<T> operator -(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return new(value1.Row1 - value2.Row1, value1.Row2 - value2.Row2, value1.Row3 - value2.Row3);
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix3x3<T> operator -(Matrix3x3<T> value)
        {
            return new(-value.Row1, -value.Row2, -value.Row3);
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x3<T> Add(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return value1 + value2;
        }

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix3x3<T> CreateBillboard(Vector3<T> objectPosition, Vector3<T> cameraPosition, Vector3<T> cameraUpVector, Vector3<T> cameraForwardVector)
        {
            Vector3<T> zaxis = objectPosition - cameraPosition;
            var norm = zaxis.LengthSquared;

            if (!Scalar.GreaterThanOrEqual(norm, Scalar.As<float, T>(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3<T>.Multiply(zaxis, Scalar.Reciprocal(Scalar.Sqrt(norm)));
            }

            Vector3<T> xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(cameraUpVector, zaxis));
            Vector3<T> yaxis = Vector3<T>.Cross(zaxis, xaxis);

            return new(xaxis, yaxis, zaxis);
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            // a: angle
            // x, y, z: unit vector for axis.
            //
            // Rotation matrix M can compute by using below equation.
            //
            //        T               T
            //  M = uu + (cos a)( I-uu ) + (sin a)S
            //
            // Where:
            //
            //  u = ( x, y, z )
            //
            //      [  0 -z  y ]
            //  S = [  z  0 -x ]
            //      [ -y  x  0 ]
            //
            //      [ 1 0 0 ]
            //  I = [ 0 1 0 ]
            //      [ 0 0 1 ]
            //
            //
            //     [  xx+cosa*(1-xx)   yx-cosa*yx-sina*z zx-cosa*xz+sina*y ]
            // M = [ xy-cosa*yx+sina*z    yy+cosa(1-yy)  yz-cosa*yz-sina*x ]
            //     [ zx-cosa*zx-sina*y zy-cosa*zy+sina*x   zz+cosa*(1-zz)  ]
            //
            T x = axis.X, y = axis.Y, z = axis.Z;
            T sa = Scalar.Sin(angle), ca = Scalar.Cos(angle);
            T xx = Scalar.Multiply(x, x), yy = Scalar.Multiply(y, y), zz = Scalar.Multiply(z, z);
            T xy = Scalar.Multiply(x, y), xz = Scalar.Multiply(x, z), yz = Scalar.Multiply(y, z);

            Matrix3x3<T> result = Identity;

            result.M11 = Scalar.Add(xx, Scalar.Multiply(ca, Scalar.Subtract(Scalar<T>.One, xx)));
            result.M12 = Scalar.Add(Scalar.Subtract(xy, Scalar.Multiply(ca, xy)), Scalar.Multiply(sa, z));
            result.M13 = Scalar.Subtract(Scalar.Subtract(xz, Scalar.Multiply(ca, xz)), Scalar.Multiply(sa, y));

            result.M21 = Scalar.Subtract(Scalar.Subtract(xy, Scalar.Multiply(ca, xy)), Scalar.Multiply(sa, z));
            result.M22 = Scalar.Add(yy, Scalar.Multiply(ca, Scalar.Subtract(Scalar<T>.One, yy)));
            result.M23 = Scalar.Add(Scalar.Subtract(yz, Scalar.Multiply(ca, yz)), Scalar.Multiply(sa, x));

            result.M31 = Scalar.Add(Scalar.Subtract(xz, Scalar.Multiply(ca, xz)), Scalar.Multiply(sa, y));
            result.M32 = Scalar.Subtract(Scalar.Subtract(yz, Scalar.Multiply(ca, yz)), Scalar.Multiply(sa, x));
            result.M33 = Scalar.Add(zz, Scalar.Multiply(ca, Scalar.Subtract(Scalar<T>.One, zz)));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateFromQuaternion(Quaternion<T> quaternion)
        {
            Matrix3x3<T> result = Identity;

            T xx = Scalar.Multiply(quaternion.X, quaternion.X);
            T yy = Scalar.Multiply(quaternion.Y, quaternion.Y);
            T zz = Scalar.Multiply(quaternion.Z, quaternion.Z);

            T xy = Scalar.Multiply(quaternion.X, quaternion.Y);
            T wz = Scalar.Multiply(quaternion.Z, quaternion.W);
            T xz = Scalar.Multiply(quaternion.Z, quaternion.X);
            T wy = Scalar.Multiply(quaternion.Y, quaternion.W);
            T yz = Scalar.Multiply(quaternion.Y, quaternion.Z);
            T wx = Scalar.Multiply(quaternion.X, quaternion.W);

            result.M11 = Scalar.Subtract(Scalar<T>.One, Scalar.Multiply(Scalar<T>.Two, Scalar.Add(yy, zz)));
            result.M12 = Scalar.Multiply(Scalar<T>.Two, Scalar.Add(xy, wz));
            result.M13 = Scalar.Multiply(Scalar<T>.Two, Scalar.Subtract(xz, wy));

            result.M21 = Scalar.Multiply(Scalar<T>.Two, Scalar.Subtract(xy, wz));
            result.M22 = Scalar.Subtract(Scalar<T>.One, Scalar.Multiply(Scalar<T>.Two, Scalar.Add(zz, xx)));
            result.M23 = Scalar.Multiply(Scalar<T>.Two, Scalar.Add(yz, wx));

            result.M31 = Scalar.Multiply(Scalar<T>.Two, Scalar.Add(xz, wy));
            result.M32 = Scalar.Multiply(Scalar<T>.Two, Scalar.Subtract(yz, wx));
            result.M33 = Scalar.Subtract(Scalar<T>.One, Scalar.Multiply(Scalar<T>.Two, Scalar.Add(yy, xx)));

            return result;
        }
        

        /// <summary>Creates a rotation matrix from the specified yaw, pitch, and roll.</summary>
        /// <param name="yaw">Angle of rotation, in radians, around the Y-axis.</param>
        /// <param name="pitch">Angle of rotation, in radians, around the X-axis.</param>
        /// <param name="roll">Angle of rotation, in radians, around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
        {
            Quaternion<T> q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Creates a matrix for rotating points around the X-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateRotationX(T radians)
        {
            Matrix3x3<T> result = Identity;

            T c = Scalar.Cos(radians);
            T s = Scalar.Sin(radians);

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  0  0  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = Scalar.Negate(s);
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateRotationY(T radians)
        {
            Matrix3x3<T> result = Identity;

            T c = Scalar.Cos(radians);
            T s = Scalar.Sin(radians);

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M13 = Scalar.Negate(s);
            result.M31 = s;
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Z-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateRotationZ(T radians)
        {
            Matrix3x3<T> result = Identity;

            T c = Scalar.Cos(radians);
            T s = Scalar.Sin(radians);

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = Scalar.Negate(s);
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="zScale">Value to scale by on the Z-axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix3x3<T> CreateScale(T xScale, T yScale, T zScale)
        {
            Matrix3x3<T> result = Identity;
            result.M11 = xScale;
            result.M22 = yScale;
            result.M33 = zScale;
            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix3x3<T> CreateScale(Vector3<T> scales)
        {
            Matrix3x3<T> result = Identity;
            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix3x3<T> CreateScale(T scale)
        {
            Matrix3x3<T> result = Identity;

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            return result;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x3<T> Multiply(Matrix3x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix2x3<T> Multiply(Matrix2x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x2<T> Multiply(Matrix3x3<T> value1, Matrix3x2<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix4x3<T> Multiply(Matrix4x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x4<T> Multiply(Matrix3x3<T> value1, Matrix3x4<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x3<T> Multiply(Matrix3x3<T> value1, T value2)
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Vector3<T> Multiply(Vector3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x3<T> Negate(Matrix3x3<T> value)
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public static Matrix3x3<T> Subtract(Matrix3x3<T> value1, Matrix3x3<T> value2)
            => value1 - value2;

        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <returns>True if the source matrix was successfully decomposed; False otherwise.</returns>
        public static bool Decompose(Matrix3x3<T> matrix, out Vector3<T> scale, out Quaternion<T> rotation)
        {
            bool result = true;

            unsafe
            {
                fixed (Vector3<T>* scaleBase = &scale)
                {
                    T* pfScales = (T*)scaleBase;
                    T det;

                    VectorBasis vectorBasis;
                    Vector3<T>** pVectorBasis = (Vector3<T>**)&vectorBasis;

                    Matrix3x3<T> matTemp = Identity;
                    CanonicalBasis canonicalBasis = default;
                    Vector3<T>* pCanonicalBasis = &canonicalBasis.Row0;

                    canonicalBasis.Row0 = new Vector3<T>(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero);
                    canonicalBasis.Row1 = new Vector3<T>(Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero);
                    canonicalBasis.Row2 = new Vector3<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

                    pVectorBasis[0] = (Vector3<T>*)&matTemp.Row1;
                    pVectorBasis[1] = (Vector3<T>*)&matTemp.Row2;
                    pVectorBasis[2] = (Vector3<T>*)&matTemp.Row3;

                    *(pVectorBasis[0]) = new Vector3<T>(matrix.M11, matrix.M12, matrix.M13);
                    *(pVectorBasis[1]) = new Vector3<T>(matrix.M21, matrix.M22, matrix.M23);
                    *(pVectorBasis[2]) = new Vector3<T>(matrix.M31, matrix.M32, matrix.M33);

                    scale.X = pVectorBasis[0]->Length;
                    scale.Y = pVectorBasis[1]->Length;
                    scale.Z = pVectorBasis[2]->Length;

                    uint a, b, c;
                    #region Ranking
                    T x = pfScales[0], y = pfScales[1], z = pfScales[2];
                    if (!Scalar.GreaterThanOrEqual(x, y))
                    {
                        if (!Scalar.GreaterThanOrEqual(y, z))
                        {
                            a = 2;
                            b = 1;
                            c = 0;
                        }
                        else
                        {
                            a = 1;

                            if (!Scalar.GreaterThanOrEqual(x, z))
                            {
                                b = 2;
                                c = 0;
                            }
                            else
                            {
                                b = 0;
                                c = 2;
                            }
                        }
                    }
                    else
                    {
                        if (!Scalar.GreaterThanOrEqual(x, z))
                        {
                            a = 2;
                            b = 0;
                            c = 1;
                        }
                        else
                        {
                            a = 0;

                            if (!Scalar.GreaterThanOrEqual(y, z))
                            {
                                b = 2;
                                c = 1;
                            }
                            else
                            {
                                b = 1;
                                c = 2;
                            }
                        }
                    }
                    #endregion

                    if (!Scalar.GreaterThanOrEqual(pfScales[a], Scalar.As<float, T>(DecomposeEpsilon)))
                    {
                        *(pVectorBasis[a]) = pCanonicalBasis[a];
                    }

                    *pVectorBasis[a] = Vector3<T>.Normalize(*pVectorBasis[a]);

                    if (!Scalar.GreaterThanOrEqual(pfScales[b], Scalar.As<float, T>(DecomposeEpsilon)))
                    {
                        uint cc;
                        T fAbsX, fAbsY, fAbsZ;

                        fAbsX = Scalar.Abs(pVectorBasis[a]->X);
                        fAbsY = Scalar.Abs(pVectorBasis[a]->Y);
                        fAbsZ = Scalar.Abs(pVectorBasis[a]->Z);

                        #region Ranking
                        if (!Scalar.GreaterThanOrEqual(fAbsX, fAbsY))
                        {
                            if (!Scalar.GreaterThanOrEqual(fAbsY, fAbsZ))
                            {
                                cc = 0;
                            }
                            else
                            {
                                if (!Scalar.GreaterThanOrEqual(fAbsX, fAbsZ))
                                {
                                    cc = 0;
                                }
                                else
                                {
                                    cc = 2;
                                }
                            }
                        }
                        else
                        {
                            if (!Scalar.GreaterThanOrEqual(fAbsX, fAbsZ))
                            {
                                cc = 1;
                            }
                            else
                            {
                                if (!Scalar.GreaterThanOrEqual(fAbsY, fAbsZ))
                                {
                                    cc = 1;
                                }
                                else
                                {
                                    cc = 2;
                                }
                            }
                        }
                        #endregion

                        *pVectorBasis[b] = Vector3<T>.Cross(*pVectorBasis[a], *(pCanonicalBasis + cc));
                    }

                    *pVectorBasis[b] = Vector3<T>.Normalize(*pVectorBasis[b]);

                    if (!Scalar.GreaterThanOrEqual(pfScales[c], Scalar.As<float, T>(DecomposeEpsilon)))
                    {
                        *pVectorBasis[c] = Vector3<T>.Cross(*pVectorBasis[a], *pVectorBasis[b]);
                    }

                    *pVectorBasis[c] = Vector3<T>.Normalize(*pVectorBasis[c]);

                    det = matTemp.GetDeterminant();

                    // use Kramer's rule to check for handedness of coordinate system
                    if (!Scalar.GreaterThanOrEqual(det, Scalar<T>.Zero))
                    {
                        // switch coordinate system by negating the scale and inverting the basis vector on the x-axis
                        pfScales[a] = Scalar.Negate(pfScales[a]);
                        *pVectorBasis[a] = -(*pVectorBasis[a]);

                        det = Scalar.Negate(det);
                    }

                    det = Scalar.Subtract(det, Scalar<T>.One);
                    det = Scalar.Multiply(det, det);

                    if (!Scalar.GreaterThanOrEqual(Scalar.As<float, T>(DecomposeEpsilon), det))
                    {
                        // Non-SRT matrix encountered
                        rotation = Quaternion<T>.Identity;
                        result = false;
                    }
                    else
                    {
                        // generate the quaternion from the matrix
                        rotation = Quaternion<T>.CreateFromRotationMatrix(matTemp);
                    }
                }
            }

            return result;
        }

        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix3x3<T> Lerp(Matrix3x3<T> matrix1, Matrix3x3<T> matrix2, T amount)
        {
            return new(
                Vector3<T>.Lerp(matrix1.Row1, matrix2.Row1, amount),
                Vector3<T>.Lerp(matrix1.Row2, matrix2.Row2, amount),
                Vector3<T>.Lerp(matrix1.Row3, matrix2.Row3, amount)
            );
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix3x3<T> Transform(Matrix3x3<T> value, Quaternion<T> rotation)
        {
            // Compute rotation matrix.
            T x2 = Scalar.Add(rotation.X, rotation.X);
            T y2 = Scalar.Add(rotation.Y, rotation.Y);
            T z2 = Scalar.Add(rotation.Z, rotation.Z);

            T wx2 = Scalar.Multiply(rotation.W, x2);
            T wy2 = Scalar.Multiply(rotation.W, y2);
            T wz2 = Scalar.Multiply(rotation.W, z2);
            T xx2 = Scalar.Multiply(rotation.X, x2);
            T xy2 = Scalar.Multiply(rotation.X, y2);
            T xz2 = Scalar.Multiply(rotation.X, z2);
            T yy2 = Scalar.Multiply(rotation.Y, y2);
            T yz2 = Scalar.Multiply(rotation.Y, z2);
            T zz2 = Scalar.Multiply(rotation.Z, z2);

            T q11 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, yy2), zz2);
            T q21 = Scalar.Subtract(xy2, wz2);
            T q31 = Scalar.Add(xz2, wy2);

            T q12 = Scalar.Add(xy2, wz2);
            T q22 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), zz2);
            T q32 = Scalar.Subtract(yz2, wx2);

            T q13 = Scalar.Subtract(xz2, wy2);
            T q23 = Scalar.Add(yz2, wx2);
            T q33 = Scalar.Subtract(Scalar.Subtract(Scalar<T>.One, xx2), yy2);

            var q1 = new Vector3<T>(q11, q12, q13);
            var q2 = new Vector3<T>(q21, q22, q23);
            var q3 = new Vector3<T>(q31, q32, q33);

            return new(value.M11 * q1 + value.M12 * q2 + value.M13 * q3, value.M21 * q1 + value.M22 * q2 + value.M23 * q3, value.M31 * q1 + value.M32 * q2 + value.M33 * q3);
        }

        /// <summary>Transposes the rows and columns of a matrix.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <returns>The transposed matrix.</returns>
        public static unsafe Matrix3x3<T> Transpose(Matrix3x3<T> matrix)
        {
            return new(matrix.Column1, matrix.Column2, matrix.Column3);
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl((MethodImplOptions)768)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix3x3<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix3x3<T> other)
            => this == other;

        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        { 
            //   | a b c |
            //   | d e f | = ( a ( ei - fh ) - b ( di - fg ) + c ( dh - eg ) )
            //   | g h i |

            T a = M11, b = M12, c = M13;
            T d = M21, e = M22, f = M23;
            T g = M31, h = M32, i = M33;

            return Scalar.Add(
                Scalar.Subtract(
                    Scalar.Multiply(a, Scalar.Subtract(Scalar.Multiply(e, i), Scalar.Multiply(f, h))),
                    Scalar.Multiply(b, Scalar.Subtract(Scalar.Multiply(d, i), Scalar.Multiply(f, g)))),
                Scalar.Multiply(c, Scalar.Subtract(Scalar.Multiply(d, h), Scalar.Multiply(e, g))));
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);
            hash.Add(M13);

            hash.Add(M21);
            hash.Add(M22);
            hash.Add(M23);

            hash.Add(M31);
            hash.Add(M32);
            hash.Add(M33);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} }} {{M21:{3} M22:{4} M23:{5} }} {{M31:{6} M32:{7} M33:{8}}} }}",
                                 M11, M12, M13,
                                 M21, M22, M23,
                                 M31, M32, M33);
        }
        
        private struct CanonicalBasis
        {
            public Vector3<T> Row0;
            public Vector3<T> Row1;
            public Vector3<T> Row2;
        };

        private struct VectorBasis
        {
            public unsafe Vector3<T>* Element0;
            public unsafe Vector3<T>* Element1;
            public unsafe Vector3<T>* Element2;
        }

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix3x3<Half>(Matrix3x3<T> from)
            => new(Scalar.As<T, Half>(from.M11), Scalar.As<T, Half>(from.M12), Scalar.As<T, Half>(from.M13),
                Scalar.As<T, Half>(from.M21), Scalar.As<T, Half>(from.M22), Scalar.As<T, Half>(from.M23),
                Scalar.As<T, Half>(from.M31), Scalar.As<T, Half>(from.M32), Scalar.As<T, Half>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix3x3<float>(Matrix3x3<T> from)
            => new(Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M13), Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M23), Scalar.As<T, float>(from.M31), Scalar.As<T, float>(from.M32),
                Scalar.As<T, float>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix3x3<double>(Matrix3x3<T> from)
            => new(Scalar.As<T, double>(from.M11), Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M13), Scalar.As<T, double>(from.M21),
                Scalar.As<T, double>(from.M22), Scalar.As<T, double>(from.M23),
                Scalar.As<T, double>(from.M31), Scalar.As<T, double>(from.M32),
                Scalar.As<T, double>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix3x3<decimal>(Matrix3x3<T> from)
            => new(Scalar.As<T, decimal>(from.M11), Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M13), Scalar.As<T, decimal>(from.M21),
                Scalar.As<T, decimal>(from.M22), Scalar.As<T, decimal>(from.M23),
                Scalar.As<T, decimal>(from.M31), Scalar.As<T, decimal>(from.M32),
                Scalar.As<T, decimal>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix3x3<sbyte>(Matrix3x3<T> from)
            => new(Scalar.As<T, sbyte>(from.M11), Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M13), Scalar.As<T, sbyte>(from.M21), Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M23), Scalar.As<T, sbyte>(from.M31), Scalar.As<T, sbyte>(from.M32),
                Scalar.As<T, sbyte>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix3x3<byte>(Matrix3x3<T> from)
            => new(Scalar.As<T, byte>(from.M11), Scalar.As<T, byte>(from.M12), Scalar.As<T, byte>(from.M13),
                Scalar.As<T, byte>(from.M21), Scalar.As<T, byte>(from.M22), Scalar.As<T, byte>(from.M23),
                Scalar.As<T, byte>(from.M31), Scalar.As<T, byte>(from.M32), Scalar.As<T, byte>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix3x3<ushort>(Matrix3x3<T> from)
            => new(Scalar.As<T, ushort>(from.M11), Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M13), Scalar.As<T, ushort>(from.M21),
                Scalar.As<T, ushort>(from.M22), Scalar.As<T, ushort>(from.M23),
                Scalar.As<T, ushort>(from.M31), Scalar.As<T, ushort>(from.M32),
                Scalar.As<T, ushort>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix3x3<short>(Matrix3x3<T> from)
            => new(Scalar.As<T, short>(from.M11), Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M13), Scalar.As<T, short>(from.M21), Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M23), Scalar.As<T, short>(from.M31), Scalar.As<T, short>(from.M32),
                Scalar.As<T, short>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix3x3<uint>(Matrix3x3<T> from)
            => new(Scalar.As<T, uint>(from.M11), Scalar.As<T, uint>(from.M12), Scalar.As<T, uint>(from.M13),
                Scalar.As<T, uint>(from.M21), Scalar.As<T, uint>(from.M22), Scalar.As<T, uint>(from.M23),
                Scalar.As<T, uint>(from.M31), Scalar.As<T, uint>(from.M32), Scalar.As<T, uint>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix3x3<int>(Matrix3x3<T> from)
            => new(Scalar.As<T, int>(from.M11), Scalar.As<T, int>(from.M12), Scalar.As<T, int>(from.M13),
                Scalar.As<T, int>(from.M21), Scalar.As<T, int>(from.M22), Scalar.As<T, int>(from.M23),
                Scalar.As<T, int>(from.M31), Scalar.As<T, int>(from.M32), Scalar.As<T, int>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix3x3<ulong>(Matrix3x3<T> from)
            => new(Scalar.As<T, ulong>(from.M11), Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M13), Scalar.As<T, ulong>(from.M21), Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M23), Scalar.As<T, ulong>(from.M31), Scalar.As<T, ulong>(from.M32),
                Scalar.As<T, ulong>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix3x3<long>(Matrix3x3<T> from)
            => new(Scalar.As<T, long>(from.M11), Scalar.As<T, long>(from.M12), Scalar.As<T, long>(from.M13),
                Scalar.As<T, long>(from.M21), Scalar.As<T, long>(from.M22), Scalar.As<T, long>(from.M23),
                Scalar.As<T, long>(from.M31), Scalar.As<T, long>(from.M32), Scalar.As<T, long>(from.M33));
    }
}
