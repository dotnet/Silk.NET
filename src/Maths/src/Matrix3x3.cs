using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix3x3<T> : IEquatable<Matrix3x3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix3x3<T> _identity = new
        (
            Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One
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

        /// <summary>Value at row 3, column 1 of the matrix.</summary>
        public T M31;

        /// <summary>Value at row 3, column 2 of the matrix.</summary>
        public T M32;

        /// <summary>Value at row 3, column 3 of the matrix.</summary>
        public T M33;

        /// <summary>Constructs a Matrix3x3 from the given components.</summary>
        public Matrix3x3(T m11, T m12, T m13,
                         T m21, T m22, T m23,
                         T m31, T m32, T m33)
            => (M11, M12, M13,
                M21, M22, M23,
                M31, M32, M33)
            =  (m11, m12, m13,
                m21, m22, m23,
                m31, m32, m33);

        /// <summary>Constructs a Matrix3x3 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix3x3(Matrix3x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Constants<T>.Zero;

            M31 = Constants<T>.Zero;
            M32 = Constants<T>.Zero;
            M33 = Constants<T>.One;
        }

        /// <summary>Constructs a Matrix3x3 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix3x3(Matrix4x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;
        }
        
        /// <summary>Constructs a Matrix3x3 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix3x3(Matrix3x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3x3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Operations.Equal(M11, Constants<T>.One) && Operations.Equal(M22, Constants<T>.One) &&
               Operations.Equal(M33, Constants<T>.One) && // Check diagonal element first for early out.
               Operations.Equal(M12, Constants<T>.Zero) && Operations.Equal(M13, Constants<T>.Zero) &&
               Operations.Equal(M21, Constants<T>.Zero) && Operations.Equal(M23, Constants<T>.Zero) &&
               Operations.Equal(M31, Constants<T>.Zero) && Operations.Equal(M32, Constants<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix3x3<T> operator +(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            /*if (AdvSimd.IsSupported)
            {
                AdvSimd.Store(&value1.M11, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M11), AdvSimd.LoadVector128(&value2.M11)));
                AdvSimd.Store(&value1.M21, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M21), AdvSimd.LoadVector128(&value2.M21)));
                AdvSimd.Store(&value1.M31, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M31), AdvSimd.LoadVector128(&value2.M31)));
                AdvSimd.Store(&value1.M41, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M41), AdvSimd.LoadVector128(&value2.M41)));
                return value1;
            }
            else if (Sse.IsSupported)
            {
                Sse.Store(&value1.M11, Sse.Add(Sse.LoadVector128(&value1.M11), Sse.LoadVector128(&value2.M11)));
                Sse.Store(&value1.M21, Sse.Add(Sse.LoadVector128(&value1.M21), Sse.LoadVector128(&value2.M21)));
                Sse.Store(&value1.M31, Sse.Add(Sse.LoadVector128(&value1.M31), Sse.LoadVector128(&value2.M31)));
                Sse.Store(&value1.M41, Sse.Add(Sse.LoadVector128(&value1.M41), Sse.LoadVector128(&value2.M41)));
                return value1;
            }*/

            Matrix3x3<T> m;

            m.M11 = Operations.Add(value1.M11, value2.M11);
            m.M12 = Operations.Add(value1.M12, value2.M12);
            m.M13 = Operations.Add(value1.M13, value2.M13);
            m.M21 = Operations.Add(value1.M21, value2.M21);
            m.M22 = Operations.Add(value1.M22, value2.M22);
            m.M23 = Operations.Add(value1.M23, value2.M23);
            m.M31 = Operations.Add(value1.M31, value2.M31);
            m.M32 = Operations.Add(value1.M32, value2.M32);
            m.M33 = Operations.Add(value1.M33, value2.M33);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            /*if (AdvSimd.Arm64.IsSupported)
            {
                return VectorMath.Equal(AdvSimd.LoadVector128(&value1.M11), AdvSimd.LoadVector128(&value2.M11)) &&
                       VectorMath.Equal(AdvSimd.LoadVector128(&value1.M21), AdvSimd.LoadVector128(&value2.M21)) &&
                       VectorMath.Equal(AdvSimd.LoadVector128(&value1.M31), AdvSimd.LoadVector128(&value2.M31)) &&
                       VectorMath.Equal(AdvSimd.LoadVector128(&value1.M41), AdvSimd.LoadVector128(&value2.M41));
            }
            else if (Sse.IsSupported)
            {
                return VectorMath.Equal(Sse.LoadVector128(&value1.M11), Sse.LoadVector128(&value2.M11)) &&
                       VectorMath.Equal(Sse.LoadVector128(&value1.M21), Sse.LoadVector128(&value2.M21)) &&
                       VectorMath.Equal(Sse.LoadVector128(&value1.M31), Sse.LoadVector128(&value2.M31)) &&
                       VectorMath.Equal(Sse.LoadVector128(&value1.M41), Sse.LoadVector128(&value2.M41));
            }*/

            return Operations.Equal(value1.M11, value2.M11) && Operations.Equal(value1.M22, value2.M22) &&
                   Operations.Equal(value1.M33, value2.M33) &&
                   // Check diagonal elements first for early out.
                   Operations.Equal(value1.M12, value2.M12) && Operations.Equal(value1.M13, value2.M13) &&
                   Operations.Equal(value1.M21, value2.M21) && Operations.Equal(value1.M23, value2.M23) &&
                   Operations.Equal(value1.M31, value2.M31) && Operations.Equal(value1.M32, value2.M32);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            return Operations.NotEqual(value1.M11, value2.M11) || Operations.NotEqual(value1.M22, value2.M22) ||
                   Operations.NotEqual(value1.M33, value2.M33) || // Check diagonal elements first for early out.
                   Operations.NotEqual(value1.M12, value2.M12) || Operations.NotEqual(value1.M13, value2.M13) ||
                   Operations.NotEqual(value1.M21, value2.M21) || Operations.NotEqual(value1.M23, value2.M23) ||
                   Operations.NotEqual(value1.M31, value2.M31) || Operations.NotEqual(value1.M32, value2.M32);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x3<T> operator *(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            Matrix3x3<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Multiply(value1.M13, value2.M31));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Multiply(value1.M13, value2.M32));
            m.M13 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23)), Operations.Multiply(value1.M13, value2.M33));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Multiply(value1.M23, value2.M31));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Multiply(value1.M23, value2.M32));
            m.M23 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23)), Operations.Multiply(value1.M23, value2.M33));

            // Third row
            m.M31 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21)), Operations.Multiply(value1.M33, value2.M31));
            m.M32 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22)), Operations.Multiply(value1.M33, value2.M32));
            m.M33 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M13), Operations.Multiply(value1.M32, value2.M23)), Operations.Multiply(value1.M33, value2.M33));

            return m;
        }
        
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix3x3<T> operator *(Matrix3x3<T> value1, T value2)
        {
            Matrix3x3<T> m;

            m.M11 = Operations.Multiply(value1.M11, value2);
            m.M12 = Operations.Multiply(value1.M12, value2);
            m.M13 = Operations.Multiply(value1.M13, value2);
            m.M21 = Operations.Multiply(value1.M21, value2);
            m.M22 = Operations.Multiply(value1.M22, value2);
            m.M23 = Operations.Multiply(value1.M23, value2);
            m.M31 = Operations.Multiply(value1.M31, value2);
            m.M32 = Operations.Multiply(value1.M32, value2);
            m.M33 = Operations.Multiply(value1.M33, value2);

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix3x3<T> operator -(Matrix3x3<T> value1, Matrix3x3<T> value2)
        {
            Matrix3x3<T> m;

            m.M11 = Operations.Subtract(value1.M11, value2.M11);
            m.M12 = Operations.Subtract(value1.M12, value2.M12);
            m.M13 = Operations.Subtract(value1.M13, value2.M13);
            m.M21 = Operations.Subtract(value1.M21, value2.M21);
            m.M22 = Operations.Subtract(value1.M22, value2.M22);
            m.M23 = Operations.Subtract(value1.M23, value2.M23);
            m.M31 = Operations.Subtract(value1.M31, value2.M31);
            m.M32 = Operations.Subtract(value1.M32, value2.M32);
            m.M33 = Operations.Subtract(value1.M33, value2.M33);

            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix3x3<T> operator -(Matrix3x3<T> value)
        {
            /*if (AdvSimd.IsSupported)
            {
                AdvSimd.Store(&value.M11, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M11)));
                AdvSimd.Store(&value.M21, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M21)));
                AdvSimd.Store(&value.M31, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M31)));
                AdvSimd.Store(&value.M41, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M41)));
                return value;
            }
            else if (Sse.IsSupported)
            {
                Vector128<T> zero = Vector128<T>.Zero;
                Sse.Store(&value.M11, Sse.Subtract(zero, Sse.LoadVector128(&value.M11)));
                Sse.Store(&value.M21, Sse.Subtract(zero, Sse.LoadVector128(&value.M21)));
                Sse.Store(&value.M31, Sse.Subtract(zero, Sse.LoadVector128(&value.M31)));
                Sse.Store(&value.M41, Sse.Subtract(zero, Sse.LoadVector128(&value.M41)));
                return value;
            }*/

            Matrix3x3<T> m;

            m.M11 = Operations.Negate(value.M11);
            m.M12 = Operations.Negate(value.M12);
            m.M13 = Operations.Negate(value.M13);
            m.M21 = Operations.Negate(value.M21);
            m.M22 = Operations.Negate(value.M22);
            m.M23 = Operations.Negate(value.M23);
            m.M31 = Operations.Negate(value.M31);
            m.M32 = Operations.Negate(value.M32);
            m.M33 = Operations.Negate(value.M33);
            
            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            Matrix3x3<T> result;

            result.M11 = xaxis.X;
            result.M12 = xaxis.Y;
            result.M13 = xaxis.Z;

            result.M21 = yaxis.X;
            result.M22 = yaxis.Y;
            result.M23 = yaxis.Z;

            result.M31 = zaxis.X;
            result.M32 = zaxis.Y;
            result.M33 = zaxis.Z;

            return result;
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
            T sa = Operations.Sin(angle), ca = Operations.Cos(angle);
            T xx = Operations.Multiply(x, x), yy = Operations.Multiply(y, y), zz = Operations.Multiply(z, z);
            T xy = Operations.Multiply(x, y), xz = Operations.Multiply(x, z), yz = Operations.Multiply(y, z);

            Matrix3x3<T> result = Identity;

            result.M11 = Operations.Add(xx, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, xx)));
            result.M12 = Operations.Add(Operations.Subtract(xy, Operations.Multiply(ca, xy)), Operations.Multiply(sa, z));
            result.M13 = Operations.Subtract(Operations.Subtract(xz, Operations.Multiply(ca, xz)), Operations.Multiply(sa, y));

            result.M21 = Operations.Subtract(Operations.Subtract(xy, Operations.Multiply(ca, xy)), Operations.Multiply(sa, z));
            result.M22 = Operations.Add(yy, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, yy)));
            result.M23 = Operations.Add(Operations.Subtract(yz, Operations.Multiply(ca, yz)), Operations.Multiply(sa, x));

            result.M31 = Operations.Add(Operations.Subtract(xz, Operations.Multiply(ca, xz)), Operations.Multiply(sa, y));
            result.M32 = Operations.Subtract(Operations.Subtract(yz, Operations.Multiply(ca, yz)), Operations.Multiply(sa, x));
            result.M33 = Operations.Add(zz, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, zz)));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateFromQuaternion(Quaternion<T> quaternion)
        {
            Matrix3x3<T> result = Identity;

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

            result.M31 = Operations.Multiply(Constants<T>.Two, Operations.Add(xz, wy));
            result.M32 = Operations.Multiply(Constants<T>.Two, Operations.Subtract(yz, wx));
            result.M33 = Operations.Subtract(Constants<T>.One, Operations.Multiply(Constants<T>.Two, Operations.Add(yy, xx)));

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

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  0  0  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = Operations.Negate(s);
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix3x3<T> CreateRotationY(T radians)
        {
            Matrix3x3<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M13 = Operations.Negate(s);
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

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = Operations.Negate(s);
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Multiply(Matrix3x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
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
        public static Matrix3x2<T> Multiply(Matrix3x3<T> value1, Matrix3x2<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Multiply(Matrix4x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Multiply(Matrix3x3<T> value1, Matrix3x4<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Multiply(Matrix3x3<T> value1, T value2)
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Negate(Matrix3x3<T> value)
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Subtract(Matrix3x3<T> value1, Matrix3x3<T> value2)
            => value1 - value2;

        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <param name="translation">The translation component of the transformation matrix</param>
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

                    canonicalBasis.Row0 = new Vector3<T>(Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero);
                    canonicalBasis.Row1 = new Vector3<T>(Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero);
                    canonicalBasis.Row2 = new Vector3<T>(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One);

                    pVectorBasis[0] = (Vector3<T>*)&matTemp.M11;
                    pVectorBasis[1] = (Vector3<T>*)&matTemp.M21;
                    pVectorBasis[2] = (Vector3<T>*)&matTemp.M31;

                    *(pVectorBasis[0]) = new Vector3<T>(matrix.M11, matrix.M12, matrix.M13);
                    *(pVectorBasis[1]) = new Vector3<T>(matrix.M21, matrix.M22, matrix.M23);
                    *(pVectorBasis[2]) = new Vector3<T>(matrix.M31, matrix.M32, matrix.M33);

                    scale.X = pVectorBasis[0]->Length();
                    scale.Y = pVectorBasis[1]->Length();
                    scale.Z = pVectorBasis[2]->Length();

                    uint a, b, c;
                    #region Ranking
                    T x = pfScales[0], y = pfScales[1], z = pfScales[2];
                    if (!Operations.GreaterThanOrEqual(x, y))
                    {
                        if (!Operations.GreaterThanOrEqual(y, z))
                        {
                            a = 2;
                            b = 1;
                            c = 0;
                        }
                        else
                        {
                            a = 1;

                            if (!Operations.GreaterThanOrEqual(x, z))
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
                        if (!Operations.GreaterThanOrEqual(x, z))
                        {
                            a = 2;
                            b = 0;
                            c = 1;
                        }
                        else
                        {
                            a = 0;

                            if (!Operations.GreaterThanOrEqual(y, z))
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

                    if (!Operations.GreaterThanOrEqual(pfScales[a], Operations.As<float, T>(DecomposeEpsilon)))
                    {
                        *(pVectorBasis[a]) = pCanonicalBasis[a];
                    }

                    *pVectorBasis[a] = Vector3<T>.Normalize(*pVectorBasis[a]);

                    if (!Operations.GreaterThanOrEqual(pfScales[b], Operations.As<float, T>(DecomposeEpsilon)))
                    {
                        uint cc;
                        T fAbsX, fAbsY, fAbsZ;

                        fAbsX = Operations.Abs(pVectorBasis[a]->X);
                        fAbsY = Operations.Abs(pVectorBasis[a]->Y);
                        fAbsZ = Operations.Abs(pVectorBasis[a]->Z);

                        #region Ranking
                        if (!Operations.GreaterThanOrEqual(fAbsX, fAbsY))
                        {
                            if (!Operations.GreaterThanOrEqual(fAbsY, fAbsZ))
                            {
                                cc = 0;
                            }
                            else
                            {
                                if (!Operations.GreaterThanOrEqual(fAbsX, fAbsZ))
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
                            if (!Operations.GreaterThanOrEqual(fAbsX, fAbsZ))
                            {
                                cc = 1;
                            }
                            else
                            {
                                if (!Operations.GreaterThanOrEqual(fAbsY, fAbsZ))
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

                    if (!Operations.GreaterThanOrEqual(pfScales[c], Operations.As<float, T>(DecomposeEpsilon)))
                    {
                        *pVectorBasis[c] = Vector3<T>.Cross(*pVectorBasis[a], *pVectorBasis[b]);
                    }

                    *pVectorBasis[c] = Vector3<T>.Normalize(*pVectorBasis[c]);

                    det = matTemp.GetDeterminant();

                    // use Kramer's rule to check for handedness of coordinate system
                    if (!Operations.GreaterThanOrEqual(det, Constants<T>.Zero))
                    {
                        // switch coordinate system by negating the scale and inverting the basis vector on the x-axis
                        pfScales[a] = Operations.Negate(pfScales[a]);
                        *pVectorBasis[a] = -(*pVectorBasis[a]);

                        det = Operations.Negate(det);
                    }

                    det = Operations.Subtract(det, Constants<T>.One);
                    det = Operations.Multiply(det, det);

                    if (!Operations.GreaterThanOrEqual(Operations.As<float, T>(DecomposeEpsilon), det))
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
            Matrix3x3<T> result;

            // First row
            result.M11 = Operations.Add(matrix1.M11, Operations.Multiply(Operations.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Operations.Add(matrix1.M12, Operations.Multiply(Operations.Subtract(matrix2.M12, matrix1.M12), amount));
            result.M13 = Operations.Add(matrix1.M13, Operations.Multiply(Operations.Subtract(matrix2.M13, matrix1.M13), amount));

            // Second row
            result.M21 = Operations.Add(matrix1.M21, Operations.Multiply(Operations.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Operations.Add(matrix1.M22, Operations.Multiply(Operations.Subtract(matrix2.M22, matrix1.M22), amount));
            result.M23 = Operations.Add(matrix1.M23, Operations.Multiply(Operations.Subtract(matrix2.M23, matrix1.M23), amount));

            // Third row
            result.M31 = Operations.Add(matrix1.M31, Operations.Multiply(Operations.Subtract(matrix2.M31, matrix1.M31), amount));
            result.M32 = Operations.Add(matrix1.M32, Operations.Multiply(Operations.Subtract(matrix2.M32, matrix1.M32), amount));
            result.M33 = Operations.Add(matrix1.M33, Operations.Multiply(Operations.Subtract(matrix2.M33, matrix1.M33), amount));

            return result;
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix3x3<T> Transform(Matrix3x3<T> value, Quaternion<T> rotation)
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

            Matrix3x3<T> result;

            // First row
            result.M11 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q11), Operations.Multiply(value.M12, q21)), Operations.Multiply(value.M13, q31));
            result.M12 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q12), Operations.Multiply(value.M12, q22)), Operations.Multiply(value.M13, q32));
            result.M13 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q13), Operations.Multiply(value.M12, q23)), Operations.Multiply(value.M13, q33));

            // Second row
            result.M21 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q11), Operations.Multiply(value.M22, q21)), Operations.Multiply(value.M23, q31));
            result.M22 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q12), Operations.Multiply(value.M22, q22)), Operations.Multiply(value.M23, q32));
            result.M23 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q13), Operations.Multiply(value.M22, q23)), Operations.Multiply(value.M23, q33));

            // Third row
            result.M31 = Operations.Add(Operations.Add(Operations.Multiply(value.M31, q11), Operations.Multiply(value.M32, q21)), Operations.Multiply(value.M33, q31));
            result.M32 = Operations.Add(Operations.Add(Operations.Multiply(value.M31, q12), Operations.Multiply(value.M32, q22)), Operations.Multiply(value.M33, q32));
            result.M33 = Operations.Add(Operations.Add(Operations.Multiply(value.M31, q13), Operations.Multiply(value.M32, q23)), Operations.Multiply(value.M33, q33));

            return result;
        }

        /// <summary>Transposes the rows and columns of a matrix.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <returns>The transposed matrix.</returns>
        public static unsafe Matrix3x3<T> Transpose(Matrix3x3<T> matrix)
        {
            Matrix3x3<T> result;

            result.M11 = matrix.M11;
            result.M12 = matrix.M21;
            result.M13 = matrix.M31;
            result.M21 = matrix.M12;
            result.M22 = matrix.M22;
            result.M23 = matrix.M32;
            result.M31 = matrix.M13;
            result.M32 = matrix.M23;
            result.M33 = matrix.M33;

            return result;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            return Operations.Add(
                Operations.Subtract(
                    Operations.Multiply(a, Operations.Subtract(Operations.Multiply(e, i), Operations.Multiply(f, h))),
                    Operations.Multiply(b, Operations.Subtract(Operations.Multiply(d, i), Operations.Multiply(f, g)))),
                Operations.Multiply(c, Operations.Subtract(Operations.Multiply(d, h), Operations.Multiply(e, g))));
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
            => new(Operations.As<T, Half>(from.M11), Operations.As<T, Half>(from.M12), Operations.As<T, Half>(from.M13),
                Operations.As<T, Half>(from.M21), Operations.As<T, Half>(from.M22), Operations.As<T, Half>(from.M23),
                Operations.As<T, Half>(from.M31), Operations.As<T, Half>(from.M32), Operations.As<T, Half>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix3x3<float>(Matrix3x3<T> from)
            => new(Operations.As<T, float>(from.M11), Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M13), Operations.As<T, float>(from.M21), Operations.As<T, float>(from.M22),
                Operations.As<T, float>(from.M23), Operations.As<T, float>(from.M31), Operations.As<T, float>(from.M32),
                Operations.As<T, float>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix3x3<double>(Matrix3x3<T> from)
            => new(Operations.As<T, double>(from.M11), Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M13), Operations.As<T, double>(from.M21),
                Operations.As<T, double>(from.M22), Operations.As<T, double>(from.M23),
                Operations.As<T, double>(from.M31), Operations.As<T, double>(from.M32),
                Operations.As<T, double>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix3x3<decimal>(Matrix3x3<T> from)
            => new(Operations.As<T, decimal>(from.M11), Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M13), Operations.As<T, decimal>(from.M21),
                Operations.As<T, decimal>(from.M22), Operations.As<T, decimal>(from.M23),
                Operations.As<T, decimal>(from.M31), Operations.As<T, decimal>(from.M32),
                Operations.As<T, decimal>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix3x3<sbyte>(Matrix3x3<T> from)
            => new(Operations.As<T, sbyte>(from.M11), Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M13), Operations.As<T, sbyte>(from.M21), Operations.As<T, sbyte>(from.M22),
                Operations.As<T, sbyte>(from.M23), Operations.As<T, sbyte>(from.M31), Operations.As<T, sbyte>(from.M32),
                Operations.As<T, sbyte>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix3x3<byte>(Matrix3x3<T> from)
            => new(Operations.As<T, byte>(from.M11), Operations.As<T, byte>(from.M12), Operations.As<T, byte>(from.M13),
                Operations.As<T, byte>(from.M21), Operations.As<T, byte>(from.M22), Operations.As<T, byte>(from.M23),
                Operations.As<T, byte>(from.M31), Operations.As<T, byte>(from.M32), Operations.As<T, byte>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix3x3<ushort>(Matrix3x3<T> from)
            => new(Operations.As<T, ushort>(from.M11), Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M13), Operations.As<T, ushort>(from.M21),
                Operations.As<T, ushort>(from.M22), Operations.As<T, ushort>(from.M23),
                Operations.As<T, ushort>(from.M31), Operations.As<T, ushort>(from.M32),
                Operations.As<T, ushort>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix3x3<short>(Matrix3x3<T> from)
            => new(Operations.As<T, short>(from.M11), Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M13), Operations.As<T, short>(from.M21), Operations.As<T, short>(from.M22),
                Operations.As<T, short>(from.M23), Operations.As<T, short>(from.M31), Operations.As<T, short>(from.M32),
                Operations.As<T, short>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix3x3<uint>(Matrix3x3<T> from)
            => new(Operations.As<T, uint>(from.M11), Operations.As<T, uint>(from.M12), Operations.As<T, uint>(from.M13),
                Operations.As<T, uint>(from.M21), Operations.As<T, uint>(from.M22), Operations.As<T, uint>(from.M23),
                Operations.As<T, uint>(from.M31), Operations.As<T, uint>(from.M32), Operations.As<T, uint>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix3x3<int>(Matrix3x3<T> from)
            => new(Operations.As<T, int>(from.M11), Operations.As<T, int>(from.M12), Operations.As<T, int>(from.M13),
                Operations.As<T, int>(from.M21), Operations.As<T, int>(from.M22), Operations.As<T, int>(from.M23),
                Operations.As<T, int>(from.M31), Operations.As<T, int>(from.M32), Operations.As<T, int>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix3x3<ulong>(Matrix3x3<T> from)
            => new(Operations.As<T, ulong>(from.M11), Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M13), Operations.As<T, ulong>(from.M21), Operations.As<T, ulong>(from.M22),
                Operations.As<T, ulong>(from.M23), Operations.As<T, ulong>(from.M31), Operations.As<T, ulong>(from.M32),
                Operations.As<T, ulong>(from.M33));

        /// <summary>
        /// Converts a <see cref="Matrix3x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix3x3<long>(Matrix3x3<T> from)
            => new(Operations.As<T, long>(from.M11), Operations.As<T, long>(from.M12), Operations.As<T, long>(from.M13),
                Operations.As<T, long>(from.M21), Operations.As<T, long>(from.M22), Operations.As<T, long>(from.M23),
                Operations.As<T, long>(from.M31), Operations.As<T, long>(from.M32), Operations.As<T, long>(from.M33));
    }
}
