using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    [Serializable]
    [DataContract]
    public struct Matrix2x3<T> : IEquatable<Matrix2x3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private static readonly Matrix2x3<T> _identity = new
        (
            Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero,
            Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero
        );

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        [DataMember]
        public T M11;

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        [DataMember]
        public T M12;

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        [DataMember]
        public T M13;

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        [DataMember]
        public T M21;

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        [DataMember]
        public T M22;

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        [DataMember]
        public T M23;

        /// <summary>Constructs a Matrix2x3 from the given components.</summary>
        public Matrix2x3(T m11, T m12, T m13,
                         T m21, T m22, T m23)
            => (M11, M12, M13,
                M21, M22, M23)
            =  (m11, m12, m13,
                m21, m22, m23);

        /// <summary>Constructs a Matrix2x3 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix2x3(Matrix3x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Scalar<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Scalar<T>.Zero;
        }

        /// <summary>Constructs a Matrix2x3 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix2x3(Matrix4x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
        }
        
        /// <summary>Constructs a Matrix2x3 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix2x3(Matrix3x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
        }
        
        /// <summary>Constructs a Matrix4x4 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix2x3(Matrix2x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
        }
        
        /// <summary>Constructs a Matrix4x4 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix2x3(Matrix4x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Scalar<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Scalar<T>.Zero;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2x3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        [IgnoreDataMember]
        public readonly bool IsIdentity
            => Scalar.Equal(M11, Scalar<T>.One) &&
               Scalar.Equal(M22, Scalar<T>.One) && // Check diagonal element first for early out.
               Scalar.Equal(M12, Scalar<T>.Zero) && Scalar.Equal(M13, Scalar<T>.Zero) &&
               Scalar.Equal(M21, Scalar<T>.Zero) && Scalar.Equal(M23, Scalar<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix2x3<T> operator +(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            Matrix2x3<T> m;

            m.M11 = Scalar.Add(value1.M11, value2.M11);
            m.M12 = Scalar.Add(value1.M12, value2.M12);
            m.M13 = Scalar.Add(value1.M13, value2.M13);
            m.M21 = Scalar.Add(value1.M21, value2.M21);
            m.M22 = Scalar.Add(value1.M22, value2.M22);
            m.M23 = Scalar.Add(value1.M23, value2.M23);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            return Scalar.Equal(value1.M11, value2.M11) && Scalar.Equal(value1.M22, value2.M22) &&
                   // Check diagonal elements first for early out.
                   Scalar.Equal(value1.M12, value2.M12) && Scalar.Equal(value1.M13, value2.M13) &&
                   Scalar.Equal(value1.M21, value2.M21) && Scalar.Equal(value1.M23, value2.M23);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            return Scalar.NotEqual(value1.M11, value2.M11) ||
                   Scalar.NotEqual(value1.M22, value2.M22) || // Check diagonal elements first for early out.
                   Scalar.NotEqual(value1.M12, value2.M12) || Scalar.NotEqual(value1.M13, value2.M13) ||
                   Scalar.NotEqual(value1.M21, value2.M21) || Scalar.NotEqual(value1.M23, value2.M23);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x3<T> operator *(Matrix2x3<T> value1, Matrix3x3<T> value2)
        {
            Matrix2x3<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21)), Scalar.Multiply(value1.M13, value2.M31));
            m.M12 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22)), Scalar.Multiply(value1.M13, value2.M32));
            m.M13 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M11, value2.M13), Scalar.Multiply(value1.M12, value2.M23)), Scalar.Multiply(value1.M13, value2.M33));

            // Second row
            m.M21 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21)), Scalar.Multiply(value1.M23, value2.M31));
            m.M22 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22)), Scalar.Multiply(value1.M23, value2.M32));
            m.M23 = Scalar.Add(Scalar.Add(Scalar.Multiply(value1.M21, value2.M13), Scalar.Multiply(value1.M22, value2.M23)), Scalar.Multiply(value1.M23, value2.M33));
            return m;
        }
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Vector3<T> operator *(Vector2<T> value1, Matrix2x3<T> value2)
        {
            Vector3<T> m;

            // First row
            m.X = Scalar.Add(Scalar.Multiply(value1.X, value2.M11), Scalar.Multiply(value1.Y, value2.M21));
            m.Y = Scalar.Add(Scalar.Multiply(value1.X, value2.M12), Scalar.Multiply(value1.Y, value2.M22));
            m.Z = Scalar.Add(Scalar.Multiply(value1.X, value2.M13), Scalar.Multiply(value1.Y, value2.M23));

            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x3<T> operator *(Matrix2x2<T> value1, Matrix2x3<T> value2)
        {
            Matrix2x3<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21));
            m.M12 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22));
            m.M13 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M13), Scalar.Multiply(value1.M12, value2.M23));

            // Second row
            m.M21 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21));
            m.M22 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22));
            m.M23 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M13), Scalar.Multiply(value1.M22, value2.M23));
            
            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x2<T> operator *(Matrix2x3<T> value1, Matrix3x2<T> value2)
        {
            Matrix2x2<T> m;

            // First row
            m.M11 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M11), Scalar.Multiply(value1.M12, value2.M21));
            m.M12 = Scalar.Add(Scalar.Multiply(value1.M11, value2.M12), Scalar.Multiply(value1.M12, value2.M22));

            // Second row
            m.M21 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M11), Scalar.Multiply(value1.M22, value2.M21));
            m.M22 = Scalar.Add(Scalar.Multiply(value1.M21, value2.M12), Scalar.Multiply(value1.M22, value2.M22));
            
            return m;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix2x3<T> operator *(Matrix2x3<T> value1, T value2)
        {
            Matrix2x3<T> m;

            m.M11 = Scalar.Multiply(value1.M11, value2);
            m.M12 = Scalar.Multiply(value1.M12, value2);
            m.M13 = Scalar.Multiply(value1.M13, value2);
            m.M21 = Scalar.Multiply(value1.M21, value2);
            m.M22 = Scalar.Multiply(value1.M22, value2);
            m.M23 = Scalar.Multiply(value1.M23, value2);

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix2x3<T> operator -(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            Matrix2x3<T> m;

            m.M11 = Scalar.Subtract(value1.M11, value2.M11);
            m.M12 = Scalar.Subtract(value1.M12, value2.M12);
            m.M13 = Scalar.Subtract(value1.M13, value2.M13);
            m.M21 = Scalar.Subtract(value1.M21, value2.M21);
            m.M22 = Scalar.Subtract(value1.M22, value2.M22);
            m.M23 = Scalar.Subtract(value1.M23, value2.M23);

            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix2x3<T> operator -(Matrix2x3<T> value)
        {
            Matrix2x3<T> m;

            m.M11 = Scalar.Negate(value.M11);
            m.M12 = Scalar.Negate(value.M12);
            m.M13 = Scalar.Negate(value.M13);
            m.M21 = Scalar.Negate(value.M21);
            m.M22 = Scalar.Negate(value.M22);
            m.M23 = Scalar.Negate(value.M23);
            
            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Add(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            return value1 + value2;
        }

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix2x3<T> CreateBillboard(Vector3<T> objectPosition, Vector3<T> cameraPosition, Vector3<T> cameraUpVector, Vector3<T> cameraForwardVector)
        {
            Vector3<T> zaxis = objectPosition - cameraPosition;
            var norm = zaxis.LengthSquared();

            if (!Scalar.GreaterThanOrEqual(norm, Scalar.As<float, T>(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3<T>.Multiply(zaxis, Scalar.Inverse(Scalar.Sqrt(norm)));
            }

            Vector3<T> xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(cameraUpVector, zaxis));
            Vector3<T> yaxis = Vector3<T>.Cross(zaxis, xaxis);

            Matrix2x3<T> result;

            result.M11 = xaxis.X;
            result.M12 = xaxis.Y;
            result.M13 = xaxis.Z;

            result.M21 = yaxis.X;
            result.M22 = yaxis.Y;
            result.M23 = yaxis.Z;

            return result;
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2x3<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
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

            Matrix2x3<T> result = Identity;

            result.M11 = Scalar.Add(xx, Scalar.Multiply(ca, Scalar.Subtract(Scalar<T>.One, xx)));
            result.M12 = Scalar.Add(Scalar.Subtract(xy, Scalar.Multiply(ca, xy)), Scalar.Multiply(sa, z));
            result.M13 = Scalar.Subtract(Scalar.Subtract(xz, Scalar.Multiply(ca, xz)), Scalar.Multiply(sa, y));

            result.M21 = Scalar.Subtract(Scalar.Subtract(xy, Scalar.Multiply(ca, xy)), Scalar.Multiply(sa, z));
            result.M22 = Scalar.Add(yy, Scalar.Multiply(ca, Scalar.Subtract(Scalar<T>.One, yy)));
            result.M23 = Scalar.Add(Scalar.Subtract(yz, Scalar.Multiply(ca, yz)), Scalar.Multiply(sa, x));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2x3<T> CreateFromQuaternion(Quaternion<T> quaternion)
        {
            Matrix2x3<T> result = Identity;

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

            return result;
        }
        

        /// <summary>Creates a rotation matrix from the specified yaw, pitch, and roll.</summary>
        /// <param name="yaw">Angle of rotation, in radians, around the Y-axis.</param>
        /// <param name="pitch">Angle of rotation, in radians, around the X-axis.</param>
        /// <param name="roll">Angle of rotation, in radians, around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2x3<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
        {
            Quaternion<T> q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Multiply(Matrix2x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Multiply(Matrix2x3<T> value1, Matrix3x2<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Multiply(Matrix2x2<T> value1, Matrix2x3<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Multiply(Matrix2x3<T> value1, T value2)
            => value1 * value2;
        
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3<T> Multiply(Vector2<T> value1, Matrix2x3<T> value2)
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Negate(Matrix2x3<T> value)
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Subtract(Matrix2x3<T> value1, Matrix2x3<T> value2)
            => value1 - value2;


        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix2x3<T> Lerp(Matrix2x3<T> matrix1, Matrix2x3<T> matrix2, T amount)
        {
            Matrix2x3<T> result;

            // First row
            result.M11 = Scalar.Add(matrix1.M11, Scalar.Multiply(Scalar.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Scalar.Add(matrix1.M12, Scalar.Multiply(Scalar.Subtract(matrix2.M12, matrix1.M12), amount));
            result.M13 = Scalar.Add(matrix1.M13, Scalar.Multiply(Scalar.Subtract(matrix2.M13, matrix1.M13), amount));

            // Second row
            result.M21 = Scalar.Add(matrix1.M21, Scalar.Multiply(Scalar.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Scalar.Add(matrix1.M22, Scalar.Multiply(Scalar.Subtract(matrix2.M22, matrix1.M22), amount));
            result.M23 = Scalar.Add(matrix1.M23, Scalar.Multiply(Scalar.Subtract(matrix2.M23, matrix1.M23), amount));

            return result;
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix2x3<T> Transform(Matrix2x3<T> value, Quaternion<T> rotation)
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

            Matrix2x3<T> result;

            // First row
            result.M11 = Scalar.Add(Scalar.Add(Scalar.Multiply(value.M11, q11), Scalar.Multiply(value.M12, q21)), Scalar.Multiply(value.M13, q31));
            result.M12 = Scalar.Add(Scalar.Add(Scalar.Multiply(value.M11, q12), Scalar.Multiply(value.M12, q22)), Scalar.Multiply(value.M13, q32));
            result.M13 = Scalar.Add(Scalar.Add(Scalar.Multiply(value.M11, q13), Scalar.Multiply(value.M12, q23)), Scalar.Multiply(value.M13, q33));

            // Second row
            result.M21 = Scalar.Add(Scalar.Add(Scalar.Multiply(value.M21, q11), Scalar.Multiply(value.M22, q21)), Scalar.Multiply(value.M23, q31));
            result.M22 = Scalar.Add(Scalar.Add(Scalar.Multiply(value.M21, q12), Scalar.Multiply(value.M22, q22)), Scalar.Multiply(value.M23, q32));
            result.M23 = Scalar.Add(Scalar.Add(Scalar.Multiply(value.M21, q13), Scalar.Multiply(value.M22, q23)), Scalar.Multiply(value.M23, q33));

            return result;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix2x3<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix2x3<T> other)
            => this == other;

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

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} }} {{M21:{3} M22:{4} M23:{5} }} }}",
                                 M11, M12, M13,
                                 M21, M22, M23);
        }
        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix2x3<Half>(Matrix2x3<T> from)
            => new(Scalar.As<T, Half>(from.M11), Scalar.As<T, Half>(from.M12), Scalar.As<T, Half>(from.M13),
                Scalar.As<T, Half>(from.M21), Scalar.As<T, Half>(from.M22), Scalar.As<T, Half>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix2x3<float>(Matrix2x3<T> from)
            => new(Scalar.As<T, float>(from.M11), Scalar.As<T, float>(from.M12),
                Scalar.As<T, float>(from.M13), Scalar.As<T, float>(from.M21), Scalar.As<T, float>(from.M22),
                Scalar.As<T, float>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix2x3<double>(Matrix2x3<T> from)
            => new(Scalar.As<T, double>(from.M11), Scalar.As<T, double>(from.M12),
                Scalar.As<T, double>(from.M13), Scalar.As<T, double>(from.M21),
                Scalar.As<T, double>(from.M22), Scalar.As<T, double>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix2x3<decimal>(Matrix2x3<T> from)
            => new(Scalar.As<T, decimal>(from.M11), Scalar.As<T, decimal>(from.M12),
                Scalar.As<T, decimal>(from.M13), Scalar.As<T, decimal>(from.M21),
                Scalar.As<T, decimal>(from.M22), Scalar.As<T, decimal>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix2x3<sbyte>(Matrix2x3<T> from)
            => new(Scalar.As<T, sbyte>(from.M11), Scalar.As<T, sbyte>(from.M12),
                Scalar.As<T, sbyte>(from.M13), Scalar.As<T, sbyte>(from.M21), Scalar.As<T, sbyte>(from.M22),
                Scalar.As<T, sbyte>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix2x3<byte>(Matrix2x3<T> from)
            => new(Scalar.As<T, byte>(from.M11), Scalar.As<T, byte>(from.M12), Scalar.As<T, byte>(from.M13),
                Scalar.As<T, byte>(from.M21), Scalar.As<T, byte>(from.M22), Scalar.As<T, byte>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix2x3<ushort>(Matrix2x3<T> from)
            => new(Scalar.As<T, ushort>(from.M11), Scalar.As<T, ushort>(from.M12),
                Scalar.As<T, ushort>(from.M13), Scalar.As<T, ushort>(from.M21),
                Scalar.As<T, ushort>(from.M22), Scalar.As<T, ushort>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix2x3<short>(Matrix2x3<T> from)
            => new(Scalar.As<T, short>(from.M11), Scalar.As<T, short>(from.M12),
                Scalar.As<T, short>(from.M13), Scalar.As<T, short>(from.M21), Scalar.As<T, short>(from.M22),
                Scalar.As<T, short>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix2x3<uint>(Matrix2x3<T> from)
            => new(Scalar.As<T, uint>(from.M11), Scalar.As<T, uint>(from.M12), Scalar.As<T, uint>(from.M13),
                Scalar.As<T, uint>(from.M21), Scalar.As<T, uint>(from.M22), Scalar.As<T, uint>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix2x3<int>(Matrix2x3<T> from)
            => new(Scalar.As<T, int>(from.M11), Scalar.As<T, int>(from.M12), Scalar.As<T, int>(from.M13),
                Scalar.As<T, int>(from.M21), Scalar.As<T, int>(from.M22), Scalar.As<T, int>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix2x3<ulong>(Matrix2x3<T> from)
            => new(Scalar.As<T, ulong>(from.M11), Scalar.As<T, ulong>(from.M12),
                Scalar.As<T, ulong>(from.M13), Scalar.As<T, ulong>(from.M21), Scalar.As<T, ulong>(from.M22),
                Scalar.As<T, ulong>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix2x3<long>(Matrix2x3<T> from)
            => new(Scalar.As<T, long>(from.M11), Scalar.As<T, long>(from.M12), Scalar.As<T, long>(from.M13),
                Scalar.As<T, long>(from.M21), Scalar.As<T, long>(from.M22), Scalar.As<T, long>(from.M23));
    }
}
