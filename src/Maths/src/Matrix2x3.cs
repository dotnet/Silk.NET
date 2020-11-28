using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix2x3<T> : IEquatable<Matrix2x3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix2x3<T> _identity = new
        (
            Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero
        );

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        public T M11;

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        public T M12;

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        public T M13;

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        public T M21;

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        public T M22;

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
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
            M13 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Constants<T>.Zero;
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
            M13 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Constants<T>.Zero;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2x3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Operations.Equal(M11, Constants<T>.One) &&
               Operations.Equal(M22, Constants<T>.One) && // Check diagonal element first for early out.
               Operations.Equal(M12, Constants<T>.Zero) && Operations.Equal(M13, Constants<T>.Zero) &&
               Operations.Equal(M21, Constants<T>.Zero) && Operations.Equal(M23, Constants<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix2x3<T> operator +(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            Matrix2x3<T> m;

            m.M11 = Operations.Add(value1.M11, value2.M11);
            m.M12 = Operations.Add(value1.M12, value2.M12);
            m.M13 = Operations.Add(value1.M13, value2.M13);
            m.M21 = Operations.Add(value1.M21, value2.M21);
            m.M22 = Operations.Add(value1.M22, value2.M22);
            m.M23 = Operations.Add(value1.M23, value2.M23);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            return Operations.Equal(value1.M11, value2.M11) && Operations.Equal(value1.M22, value2.M22) &&
                   // Check diagonal elements first for early out.
                   Operations.Equal(value1.M12, value2.M12) && Operations.Equal(value1.M13, value2.M13) &&
                   Operations.Equal(value1.M21, value2.M21) && Operations.Equal(value1.M23, value2.M23);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            return Operations.NotEqual(value1.M11, value2.M11) ||
                   Operations.NotEqual(value1.M22, value2.M22) || // Check diagonal elements first for early out.
                   Operations.NotEqual(value1.M12, value2.M12) || Operations.NotEqual(value1.M13, value2.M13) ||
                   Operations.NotEqual(value1.M21, value2.M21) || Operations.NotEqual(value1.M23, value2.M23);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x3<T> operator *(Matrix2x3<T> value1, Matrix3x3<T> value2)
        {
            Matrix2x3<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Multiply(value1.M13, value2.M31));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Multiply(value1.M13, value2.M32));
            m.M13 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23)), Operations.Multiply(value1.M13, value2.M33));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Multiply(value1.M23, value2.M31));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Multiply(value1.M23, value2.M32));
            m.M23 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23)), Operations.Multiply(value1.M23, value2.M33));
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
            m.M11 = Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21));
            m.M12 = Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22));
            m.M13 = Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23));

            // Second row
            m.M21 = Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21));
            m.M22 = Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22));
            m.M23 = Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23));
            
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
            m.M11 = Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21));
            m.M12 = Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22));

            // Second row
            m.M21 = Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21));
            m.M22 = Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22));
            
            return m;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix2x3<T> operator *(Matrix2x3<T> value1, T value2)
        {
            Matrix2x3<T> m;

            m.M11 = Operations.Multiply(value1.M11, value2);
            m.M12 = Operations.Multiply(value1.M12, value2);
            m.M13 = Operations.Multiply(value1.M13, value2);
            m.M21 = Operations.Multiply(value1.M21, value2);
            m.M22 = Operations.Multiply(value1.M22, value2);
            m.M23 = Operations.Multiply(value1.M23, value2);

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix2x3<T> operator -(Matrix2x3<T> value1, Matrix2x3<T> value2)
        {
            Matrix2x3<T> m;

            m.M11 = Operations.Subtract(value1.M11, value2.M11);
            m.M12 = Operations.Subtract(value1.M12, value2.M12);
            m.M13 = Operations.Subtract(value1.M13, value2.M13);
            m.M21 = Operations.Subtract(value1.M21, value2.M21);
            m.M22 = Operations.Subtract(value1.M22, value2.M22);
            m.M23 = Operations.Subtract(value1.M23, value2.M23);

            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix2x3<T> operator -(Matrix2x3<T> value)
        {
            Matrix2x3<T> m;

            m.M11 = Operations.Negate(value.M11);
            m.M12 = Operations.Negate(value.M12);
            m.M13 = Operations.Negate(value.M13);
            m.M21 = Operations.Negate(value.M21);
            m.M22 = Operations.Negate(value.M22);
            m.M23 = Operations.Negate(value.M23);
            
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

            if (!Operations.GreaterThanOrEqual(norm, Operations.As<float, T>(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3<T>.Multiply(zaxis, Operations.Divide(Constants<T>.One, Operations.Sqrt(norm)));
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
            T sa = Operations.Sin(angle), ca = Operations.Cos(angle);
            T xx = Operations.Multiply(x, x), yy = Operations.Multiply(y, y), zz = Operations.Multiply(z, z);
            T xy = Operations.Multiply(x, y), xz = Operations.Multiply(x, z), yz = Operations.Multiply(y, z);

            Matrix2x3<T> result = Identity;

            result.M11 = Operations.Add(xx, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, xx)));
            result.M12 = Operations.Add(Operations.Subtract(xy, Operations.Multiply(ca, xy)), Operations.Multiply(sa, z));
            result.M13 = Operations.Subtract(Operations.Subtract(xz, Operations.Multiply(ca, xz)), Operations.Multiply(sa, y));

            result.M21 = Operations.Subtract(Operations.Subtract(xy, Operations.Multiply(ca, xy)), Operations.Multiply(sa, z));
            result.M22 = Operations.Add(yy, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, yy)));
            result.M23 = Operations.Add(Operations.Subtract(yz, Operations.Multiply(ca, yz)), Operations.Multiply(sa, x));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2x3<T> CreateFromQuaternion(Quaternion<T> quaternion)
        {
            Matrix2x3<T> result = Identity;

            T xx = Operations.Multiply(quaternion.X, quaternion.X);
            T yy = Operations.Multiply(quaternion.Y, quaternion.Y);
            T zz = Operations.Multiply(quaternion.Z, quaternion.Z);

            T xy = Operations.Multiply(quaternion.X, quaternion.Y);
            T wz = Operations.Multiply(quaternion.Z, quaternion.W);
            T xz = Operations.Multiply(quaternion.Z, quaternion.X);
            T wy = Operations.Multiply(quaternion.Y, quaternion.W);
            T yz = Operations.Multiply(quaternion.Y, quaternion.Z);
            T wx = Operations.Multiply(quaternion.X, quaternion.W);

            result.M11 = Operations.Subtract(Constants<T>.One, Operations.Multiply(Constants<T>.Two, Operations.Add(yy, zz)));
            result.M12 = Operations.Multiply(Constants<T>.Two, Operations.Add(xy, wz));
            result.M13 = Operations.Multiply(Constants<T>.Two, Operations.Subtract(xz, wy));

            result.M21 = Operations.Multiply(Constants<T>.Two, Operations.Subtract(xy, wz));
            result.M22 = Operations.Subtract(Constants<T>.One, Operations.Multiply(Constants<T>.Two, Operations.Add(zz, xx)));
            result.M23 = Operations.Multiply(Constants<T>.Two, Operations.Add(yz, wx));

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
            result.M11 = Operations.Add(matrix1.M11, Operations.Multiply(Operations.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Operations.Add(matrix1.M12, Operations.Multiply(Operations.Subtract(matrix2.M12, matrix1.M12), amount));
            result.M13 = Operations.Add(matrix1.M13, Operations.Multiply(Operations.Subtract(matrix2.M13, matrix1.M13), amount));

            // Second row
            result.M21 = Operations.Add(matrix1.M21, Operations.Multiply(Operations.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Operations.Add(matrix1.M22, Operations.Multiply(Operations.Subtract(matrix2.M22, matrix1.M22), amount));
            result.M23 = Operations.Add(matrix1.M23, Operations.Multiply(Operations.Subtract(matrix2.M23, matrix1.M23), amount));

            return result;
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix2x3<T> Transform(Matrix2x3<T> value, Quaternion<T> rotation)
        {
            // Compute rotation matrix.
            T x2 = Operations.Add(rotation.X, rotation.X);
            T y2 = Operations.Add(rotation.Y, rotation.Y);
            T z2 = Operations.Add(rotation.Z, rotation.Z);

            T wx2 = Operations.Multiply(rotation.W, x2);
            T wy2 = Operations.Multiply(rotation.W, y2);
            T wz2 = Operations.Multiply(rotation.W, z2);
            T xx2 = Operations.Multiply(rotation.X, x2);
            T xy2 = Operations.Multiply(rotation.X, y2);
            T xz2 = Operations.Multiply(rotation.X, z2);
            T yy2 = Operations.Multiply(rotation.Y, y2);
            T yz2 = Operations.Multiply(rotation.Y, z2);
            T zz2 = Operations.Multiply(rotation.Z, z2);

            T q11 = Operations.Subtract(Operations.Subtract(Constants<T>.One, yy2), zz2);
            T q21 = Operations.Subtract(xy2, wz2);
            T q31 = Operations.Add(xz2, wy2);

            T q12 = Operations.Add(xy2, wz2);
            T q22 = Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), zz2);
            T q32 = Operations.Subtract(yz2, wx2);

            T q13 = Operations.Subtract(xz2, wy2);
            T q23 = Operations.Add(yz2, wx2);
            T q33 = Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), yy2);

            Matrix2x3<T> result;

            // First row
            result.M11 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q11), Operations.Multiply(value.M12, q21)), Operations.Multiply(value.M13, q31));
            result.M12 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q12), Operations.Multiply(value.M12, q22)), Operations.Multiply(value.M13, q32));
            result.M13 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q13), Operations.Multiply(value.M12, q23)), Operations.Multiply(value.M13, q33));

            // Second row
            result.M21 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q11), Operations.Multiply(value.M22, q21)), Operations.Multiply(value.M23, q31));
            result.M22 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q12), Operations.Multiply(value.M22, q22)), Operations.Multiply(value.M23, q32));
            result.M23 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q13), Operations.Multiply(value.M22, q23)), Operations.Multiply(value.M23, q33));

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
            => new(Operations.As<T, Half>(from.M11), Operations.As<T, Half>(from.M12), Operations.As<T, Half>(from.M13),
                Operations.As<T, Half>(from.M21), Operations.As<T, Half>(from.M22), Operations.As<T, Half>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix2x3<float>(Matrix2x3<T> from)
            => new(Operations.As<T, float>(from.M11), Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M13), Operations.As<T, float>(from.M21), Operations.As<T, float>(from.M22),
                Operations.As<T, float>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix2x3<double>(Matrix2x3<T> from)
            => new(Operations.As<T, double>(from.M11), Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M13), Operations.As<T, double>(from.M21),
                Operations.As<T, double>(from.M22), Operations.As<T, double>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix2x3<decimal>(Matrix2x3<T> from)
            => new(Operations.As<T, decimal>(from.M11), Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M13), Operations.As<T, decimal>(from.M21),
                Operations.As<T, decimal>(from.M22), Operations.As<T, decimal>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix2x3<sbyte>(Matrix2x3<T> from)
            => new(Operations.As<T, sbyte>(from.M11), Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M13), Operations.As<T, sbyte>(from.M21), Operations.As<T, sbyte>(from.M22),
                Operations.As<T, sbyte>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix2x3<byte>(Matrix2x3<T> from)
            => new(Operations.As<T, byte>(from.M11), Operations.As<T, byte>(from.M12), Operations.As<T, byte>(from.M13),
                Operations.As<T, byte>(from.M21), Operations.As<T, byte>(from.M22), Operations.As<T, byte>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix2x3<ushort>(Matrix2x3<T> from)
            => new(Operations.As<T, ushort>(from.M11), Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M13), Operations.As<T, ushort>(from.M21),
                Operations.As<T, ushort>(from.M22), Operations.As<T, ushort>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix2x3<short>(Matrix2x3<T> from)
            => new(Operations.As<T, short>(from.M11), Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M13), Operations.As<T, short>(from.M21), Operations.As<T, short>(from.M22),
                Operations.As<T, short>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix2x3<uint>(Matrix2x3<T> from)
            => new(Operations.As<T, uint>(from.M11), Operations.As<T, uint>(from.M12), Operations.As<T, uint>(from.M13),
                Operations.As<T, uint>(from.M21), Operations.As<T, uint>(from.M22), Operations.As<T, uint>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix2x3<int>(Matrix2x3<T> from)
            => new(Operations.As<T, int>(from.M11), Operations.As<T, int>(from.M12), Operations.As<T, int>(from.M13),
                Operations.As<T, int>(from.M21), Operations.As<T, int>(from.M22), Operations.As<T, int>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix2x3<ulong>(Matrix2x3<T> from)
            => new(Operations.As<T, ulong>(from.M11), Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M13), Operations.As<T, ulong>(from.M21), Operations.As<T, ulong>(from.M22),
                Operations.As<T, ulong>(from.M23));

        /// <summary>
        /// Converts a <see cref="Matrix2x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix2x3<long>(Matrix2x3<T> from)
            => new(Operations.As<T, long>(from.M11), Operations.As<T, long>(from.M12), Operations.As<T, long>(from.M13),
                Operations.As<T, long>(from.M21), Operations.As<T, long>(from.M22), Operations.As<T, long>(from.M23));
    }
}
