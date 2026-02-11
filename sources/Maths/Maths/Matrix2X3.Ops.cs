// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix2X3{T}"/>
    /// </summary>
    public static partial class Matrix2X3
    {
        private const float BillboardEpsilon = 1e-4f;

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix2X3<T> CreateBillboard<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
            Vector3D<T> zaxis = objectPosition - cameraPosition;
            var norm = zaxis.LengthSquared;

            if (!(norm >= T.CreateTruncating(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3D.Multiply(zaxis, T.One / T.Sqrt(norm));
            }

            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            return new(xaxis, yaxis);
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2X3<T> CreateFromAxisAngle<T>(Vector3D<T> axis, T angle)
            where T : ITrigonometricFunctions<T>
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
            T sa = T.Sin(angle), ca = T.Cos(angle);
            T xx = x * x, yy = y * y, zz = z * z;
            T xy = x * y, xz = x * z, yz = y * z;

            Matrix2X3<T> result = Matrix2X3<T>.Identity;

            result.M11 = xx + (ca * (T.One - xx));
            result.M12 = xy - (ca * xy) + (sa * z);
            result.M13 = xz - (ca * xz) - (sa * y);

            result.M21 = xy - (ca * xy) - (sa * z);
            result.M22 = yy + (ca * (T.One - yy));
            result.M23 = yz - (ca * yz) + (sa * x);

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2X3<T> CreateFromQuaternion<T>(Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            Matrix2X3<T> result = Matrix2X3<T>.Identity;

            T xx = quaternion.X * quaternion.X;
            T yy = quaternion.Y * quaternion.Y;
            T zz = quaternion.Z * quaternion.Z;

            T xy = quaternion.X * quaternion.Y;
            T wz = quaternion.Z * quaternion.W;
            T xz = quaternion.Z * quaternion.X;
            T wy = quaternion.Y * quaternion.W;
            T yz = quaternion.Y * quaternion.Z;
            T wx = quaternion.X * quaternion.W;

            result.M11 = T.One - (T.CreateTruncating(2) * (yy + zz));
            result.M12 = T.CreateTruncating(2) * (xy + wz);
            result.M13 = T.CreateTruncating(2) * (xz - wy);

            result.M21 = T.CreateTruncating(2) * (xy - wz);
            result.M22 = T.One - (T.CreateTruncating(2) * (zz + xx));
            result.M23 = T.CreateTruncating(2) * (yz + wx);

            return result;
        }


        /// <summary>Creates a rotation matrix from the specified yaw, pitch, and roll.</summary>
        /// <param name="yaw">Angle of rotation, in radians, around the Y-axis.</param>
        /// <param name="pitch">Angle of rotation, in radians, around the X-axis.</param>
        /// <param name="roll">Angle of rotation, in radians, around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix2X3<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix2X3<T> Transform<T>(Matrix2X3<T> value, Quaternion<T> rotation)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            // Compute rotation matrix.
            T x2 = rotation.X + rotation.X;
            T y2 = rotation.Y + rotation.Y;
            T z2 = rotation.Z + rotation.Z;

            T wx2 = rotation.W * x2;
            T wy2 = rotation.W * y2;
            T wz2 = rotation.W * z2;
            T xx2 = rotation.X * x2;
            T xy2 = rotation.X * y2;
            T xz2 = rotation.X * z2;
            T yy2 = rotation.Y * y2;
            T yz2 = rotation.Y * z2;
            T zz2 = rotation.Z * z2;

            T q11 = T.One - yy2 - zz2;
            T q21 = xy2 - wz2;
            T q31 = xz2 + wy2;

            T q12 = xy2 + wz2;
            T q22 = T.One - xx2 - zz2;
            T q32 = yz2 - wx2;

            T q13 = xz2 - wy2;
            T q23 = yz2 + wx2;
            T q33 = T.One - xx2 - yy2;

            var q1 = new Vector3D<T>(q11, q12, q13);
            var q2 = new Vector3D<T>(q21, q22, q23);
            var q3 = new Vector3D<T>(q31, q32, q33);

            return new((value.M11 * q1) + (value.M12 * q2) + (value.M13 * q3), (value.M21 * q1) + (value.M22 * q2) + (value.M23 * q3));
        }
    }
}
