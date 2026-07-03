// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X4{T}"/>
    /// </summary>
    public static partial class Matrix4X4
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public static Matrix4X4<T> CreateFromAffine<T>(Matrix3X2<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, T.Zero, T.Zero),
                new(value.M21, value.M22, T.Zero, T.Zero),
                Vector4D<T>.UnitZ,
                new(value.M31, value.M32, T.Zero, T.One)
            );

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public static Matrix4X4<T> CreateFromAffine<T>(Matrix3X3<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, value.M13, T.Zero),
                new(value.M21, value.M22, value.M23, T.Zero),
                Vector4D<T>.UnitZ,
                new(value.M31, value.M32, value.M33, T.One)
            );

        /// <summary>Constructs a <see cref="Matrix4X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public static Matrix4X4<T> CreateFromHomogeneous<T>(Matrix3X3<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, T.Zero, value.M13),
                new(value.M21, value.M22, T.Zero, value.M23),
                Vector4D<T>.UnitZ,
                new(value.M31, value.M32, T.Zero, value.M33)
            );

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix4X4<T> CreateBillboardRH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateBillboard(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(objectPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraUpVector),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraForwardVector)
                ));
            }

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

            return new(
                new(xaxis, T.Zero),
                new(yaxis, T.Zero),
                new(zaxis, T.Zero),
                new(objectPosition, T.One));
        }

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix4X4<T> CreateBillboardLH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateBillboardLeftHanded(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(objectPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraUpVector),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraForwardVector)
                ));
            }

            Vector3D<T> zaxis = cameraPosition - objectPosition;
            var norm = zaxis.LengthSquared;

            if (!(norm >= T.CreateTruncating(BillboardEpsilon)))
            {
                zaxis = cameraForwardVector;
            }
            else
            {
                zaxis = Vector3D.Multiply(zaxis, T.One / T.Sqrt(norm));
            }

            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            return new(
                new(xaxis, T.Zero),
                new(yaxis, T.Zero),
                new(zaxis, T.Zero),
                new(objectPosition, T.One));
        }

        /// <summary>Creates a cylindrical billboard that rotates around a specified axis.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="rotateAxis">Axis to rotate the billboard around.</param>
        /// <param name="cameraForwardVector">Forward vector of the camera.</param>
        /// <param name="objectForwardVector">Forward vector of the object.</param>
        /// <returns>The created billboard matrix.</returns>
        public static Matrix4X4<T> CreateConstrainedBillboardRH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> rotateAxis, Vector3D<T> cameraForwardVector, Vector3D<T> objectForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateConstrainedBillboard(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(objectPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(rotateAxis),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraForwardVector),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(objectForwardVector)
                ));
            }

            // Treat the case when object and camera positions are too close.
            Vector3D<T> faceDir = objectPosition - cameraPosition;
            T norm = faceDir.LengthSquared;

            if (!(norm >= T.CreateTruncating(BillboardEpsilon)))
            {
                faceDir = -cameraForwardVector;
            }
            else
            {
                faceDir = Vector3D.Multiply(faceDir, T.One / T.Sqrt(norm));
            }

            Vector3D<T> yaxis = rotateAxis;
            Vector3D<T> xaxis;
            Vector3D<T> zaxis;

            // Treat the case when angle between faceDir and rotateAxis is too close to 0.
            T dot = Vector3D.Dot(rotateAxis, faceDir);

            if (T.Abs(dot) > T.CreateTruncating(BillboardMinAngle))
            {
                zaxis = objectForwardVector;

                // Make sure passed values are useful for compute.
                dot = Vector3D.Dot(rotateAxis, zaxis);

                if (T.Abs(dot) > T.CreateTruncating(BillboardMinAngle))
                {
                    zaxis =
                        T.Abs(rotateAxis.Z) > T.CreateTruncating(BillboardMinAngle)
                            ? new Vector3D<T>(T.One, T.Zero, T.Zero)
                            : new Vector3D<T>(T.Zero, T.Zero, -T.One);
                }

                xaxis = Vector3D.Normalize(Vector3D.Cross(rotateAxis, zaxis));
                zaxis = Vector3D.Normalize(Vector3D.Cross(xaxis, rotateAxis));
            }
            else
            {
                xaxis = Vector3D.Normalize(Vector3D.Cross(rotateAxis, faceDir));
                zaxis = Vector3D.Normalize(Vector3D.Cross(xaxis, yaxis));
            }

            return new(
                new(xaxis, T.Zero),
                new(yaxis, T.Zero),
                new(zaxis, T.Zero),
                new(objectPosition, T.One));
        }

        /// <summary>Creates a cylindrical billboard that rotates around a specified axis.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="rotateAxis">Axis to rotate the billboard around.</param>
        /// <param name="cameraForwardVector">Forward vector of the camera.</param>
        /// <param name="objectForwardVector">Forward vector of the object.</param>
        /// <returns>The created billboard matrix.</returns>
        public static Matrix4X4<T> CreateConstrainedBillboardLH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> rotateAxis, Vector3D<T> cameraForwardVector, Vector3D<T> objectForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateConstrainedBillboardLeftHanded(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(objectPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(rotateAxis),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraForwardVector),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(objectForwardVector)
                ));
            }

            // Treat the case when object and camera positions are too close.
            Vector3D<T> faceDir = cameraPosition - objectPosition;
            T norm = faceDir.LengthSquared;

            if (!(norm >= T.CreateTruncating(BillboardEpsilon)))
            {
                faceDir = cameraForwardVector;
            }
            else
            {
                faceDir = Vector3D.Multiply(faceDir, T.One / T.Sqrt(norm));
            }

            Vector3D<T> yaxis = rotateAxis;
            Vector3D<T> xaxis;
            Vector3D<T> zaxis;

            // Treat the case when angle between faceDir and rotateAxis is too close to 0.
            T dot = Vector3D.Dot(rotateAxis, faceDir);

            if (T.Abs(dot) > T.CreateTruncating(BillboardMinAngle))
            {
                zaxis = -objectForwardVector;

                // Make sure passed values are useful for compute.
                dot = Vector3D.Dot(rotateAxis, zaxis);

                if (T.Abs(dot) > T.CreateTruncating(BillboardMinAngle))
                {
                    zaxis =
                        T.Abs(rotateAxis.Z) > T.CreateTruncating(BillboardMinAngle)
                            ? new Vector3D<T>(-T.One, T.Zero, T.Zero)
                            : new Vector3D<T>(T.Zero, T.Zero, -T.One);
                }

                xaxis = Vector3D.Normalize(Vector3D.Cross(rotateAxis, zaxis));
                zaxis = Vector3D.Normalize(Vector3D.Cross(xaxis, rotateAxis));
            }
            else
            {
                xaxis = Vector3D.Normalize(Vector3D.Cross(rotateAxis, faceDir));
                zaxis = Vector3D.Normalize(Vector3D.Cross(xaxis, yaxis));
            }

            return new(
                new(xaxis, T.Zero),
                new(yaxis, T.Zero),
                new(zaxis, T.Zero),
                new(objectPosition, T.One));
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateFromAxisAngle<T>(Vector3D<T> axis, T angle)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateFromAxisAngle(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(axis),
                    Unsafe.BitCast<T, float>(angle)
                ));
            }

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

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = xx + (ca * (T.One - xx));
            result.M12 = xy - (ca * xy) + (sa * z);
            result.M13 = xz - (ca * xz) - (sa * y);

            result.M21 = xy - (ca * xy) - (sa * z);
            result.M22 = yy + (ca * (T.One - yy));
            result.M23 = yz - (ca * yz) + (sa * x);

            result.M31 = xz - (ca * xz) + (sa * y);
            result.M32 = yz - (ca * yz) - (sa * x);
            result.M33 = zz + (ca * (T.One - zz));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateFromQuaternion<T>(Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateFromQuaternion(
                    Unsafe.BitCast<Quaternion<T>, System.Numerics.Quaternion>(quaternion)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

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

            result.M31 = T.CreateTruncating(2) * (xz + wy);
            result.M32 = T.CreateTruncating(2) * (yz - wx);
            result.M33 = T.One - (T.CreateTruncating(2) * (yy + xx));

            return result;
        }


        /// <summary>Creates a rotation matrix from the specified yaw, pitch, and roll.</summary>
        /// <param name="yaw">Angle of rotation, in radians, around the Y-axis.</param>
        /// <param name="pitch">Angle of rotation, in radians, around the X-axis.</param>
        /// <param name="roll">Angle of rotation, in radians, around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateFromYawPitchRoll(
                    Unsafe.BitCast<T, float>(yaw),
                    Unsafe.BitCast<T, float>(pitch),
                    Unsafe.BitCast<T, float>(roll)
                ));
            }

            var q = Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraTarget">The target towards which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4X4<T> CreateLookAtRH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraTarget, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateLookAt(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraTarget),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraUpVector)
                ));
            }

            Vector3D<T> zaxis = Vector3D.Normalize(cameraPosition - cameraTarget);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = xaxis.X;
            result.M12 = yaxis.X;
            result.M13 = zaxis.X;

            result.M21 = xaxis.Y;
            result.M22 = yaxis.Y;
            result.M23 = zaxis.Y;

            result.M31 = xaxis.Z;
            result.M32 = yaxis.Z;
            result.M33 = zaxis.Z;

            result.M41 = -Vector3D.Dot(xaxis, cameraPosition);
            result.M42 = -Vector3D.Dot(yaxis, cameraPosition);
            result.M43 = -Vector3D.Dot(zaxis, cameraPosition);

            return result;
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraForwardVector">The direction along which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4X4<T> CreateLookToRH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraForwardVector, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateLookTo(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraForwardVector),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraUpVector)
                ));
            }

            Vector3D<T> zaxis = Vector3D.Normalize(cameraForwardVector);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = xaxis.X;
            result.M12 = yaxis.X;
            result.M13 = zaxis.X;

            result.M21 = xaxis.Y;
            result.M22 = yaxis.Y;
            result.M23 = zaxis.Y;

            result.M31 = xaxis.Z;
            result.M32 = yaxis.Z;
            result.M33 = zaxis.Z;

            result.M41 = -Vector3D.Dot(xaxis, cameraPosition);
            result.M42 = -Vector3D.Dot(yaxis, cameraPosition);
            result.M43 = -Vector3D.Dot(zaxis, cameraPosition);

            return result;
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraTarget">The target towards which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4X4<T> CreateLookAtLH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraTarget, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateLookAtLeftHanded(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraTarget),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraUpVector)
                ));
            }

            Vector3D<T> zaxis = Vector3D.Normalize(cameraTarget - cameraPosition);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = xaxis.X;
            result.M12 = yaxis.X;
            result.M13 = zaxis.X;

            result.M21 = xaxis.Y;
            result.M22 = yaxis.Y;
            result.M23 = zaxis.Y;

            result.M31 = xaxis.Z;
            result.M32 = yaxis.Z;
            result.M33 = zaxis.Z;

            result.M41 = -Vector3D.Dot(xaxis, cameraPosition);
            result.M42 = -Vector3D.Dot(yaxis, cameraPosition);
            result.M43 = -Vector3D.Dot(zaxis, cameraPosition);

            return result;
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraForwardVector">The direction along which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4X4<T> CreateLookToLH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraForwardVector, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateLookToLeftHanded(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraPosition),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraForwardVector),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(cameraUpVector)
                ));
            }

            Vector3D<T> zaxis = Vector3D.Normalize(cameraForwardVector);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = xaxis.X;
            result.M12 = yaxis.X;
            result.M13 = zaxis.X;

            result.M21 = xaxis.Y;
            result.M22 = yaxis.Y;
            result.M23 = zaxis.Y;

            result.M31 = xaxis.Z;
            result.M32 = yaxis.Z;
            result.M33 = zaxis.Z;

            result.M41 = -Vector3D.Dot(xaxis, cameraPosition);
            result.M42 = -Vector3D.Dot(yaxis, cameraPosition);
            result.M43 = -Vector3D.Dot(zaxis, cameraPosition);

            return result;
        }

        /// <summary>Creates an orthographic perspective matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume.</param>
        /// <param name="height">Height of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4X4<T> CreateOrthographicRH<T>(T width, T height, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateOrthographic(
                    Unsafe.BitCast<T, float>(width),
                    Unsafe.BitCast<T, float>(height),
                    Unsafe.BitCast<T, float>(zNearPlane),
                    Unsafe.BitCast<T, float>(zFarPlane)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            var range = T.One / (zNearPlane - zFarPlane);
            result.M11 = T.CreateTruncating(2) / width;
            result.M22 = T.CreateTruncating(2) / height;
            result.M33 = range;
            result.M43 = range * zNearPlane;

            return result;
        }

        /// <summary>Creates an orthographic perspective matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume.</param>
        /// <param name="height">Height of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4X4<T> CreateOrthographicLH<T>(T width, T height, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateOrthographicLeftHanded(
                    Unsafe.BitCast<T, float>(width),
                    Unsafe.BitCast<T, float>(height),
                    Unsafe.BitCast<T, float>(zNearPlane),
                    Unsafe.BitCast<T, float>(zFarPlane)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            var range = T.One / (zFarPlane - zNearPlane);
            result.M11 = T.CreateTruncating(2) / width;
            result.M22 = T.CreateTruncating(2) / height;
            result.M33 = range;
            result.M43 = -range * zNearPlane;

            return result;
        }

        /// <summary>Builds a customized, orthographic projection matrix.</summary>
        /// <param name="left">Minimum X-value of the view volume.</param>
        /// <param name="right">Maximum X-value of the view volume.</param>
        /// <param name="bottom">Minimum Y-value of the view volume.</param>
        /// <param name="top">Maximum Y-value of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4X4<T> CreateOrthographicOffCenterRH<T>(T left, T right, T bottom, T top, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateOrthographicOffCenter(
                    Unsafe.BitCast<T, float>(left),
                    Unsafe.BitCast<T, float>(right),
                    Unsafe.BitCast<T, float>(bottom),
                    Unsafe.BitCast<T, float>(top),
                    Unsafe.BitCast<T, float>(zNearPlane),
                    Unsafe.BitCast<T, float>(zFarPlane)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            var reciprocalWidth = T.One / (right - left);
            var reciprocalHeight = T.One / (top - bottom);
            var range = T.One / (zNearPlane - zFarPlane);

            result.M11 = reciprocalWidth + reciprocalWidth;

            result.M22 = reciprocalHeight + reciprocalHeight;

            result.M33 = range;

            result.M41 = -(left + right) * reciprocalWidth;
            result.M42 = -(top + bottom) * reciprocalHeight;
            result.M43 = range * zNearPlane;

            return result;
        }

        /// <summary>Builds a customized, orthographic projection matrix.</summary>
        /// <param name="left">Minimum X-value of the view volume.</param>
        /// <param name="right">Maximum X-value of the view volume.</param>
        /// <param name="bottom">Minimum Y-value of the view volume.</param>
        /// <param name="top">Maximum Y-value of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4X4<T> CreateOrthographicOffCenterLH<T>(T left, T right, T bottom, T top, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateOrthographicOffCenterLeftHanded(
                    Unsafe.BitCast<T, float>(left),
                    Unsafe.BitCast<T, float>(right),
                    Unsafe.BitCast<T, float>(bottom),
                    Unsafe.BitCast<T, float>(top),
                    Unsafe.BitCast<T, float>(zNearPlane),
                    Unsafe.BitCast<T, float>(zFarPlane)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            var reciprocalWidth = T.One / (right - left);
            var reciprocalHeight = T.One / (top - bottom);
            var range = T.One / (zFarPlane - zNearPlane);

            result.M11 = reciprocalWidth + reciprocalWidth;

            result.M22 = reciprocalHeight + reciprocalHeight;

            result.M33 = range;

            result.M41 = -(left + right) * reciprocalWidth;
            result.M42 = -(top + bottom) * reciprocalHeight;
            result.M43 = -range * zNearPlane;

            return result;
        }

        /// <summary>Creates a perspective projection matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume at the near view plane.</param>
        /// <param name="height">Height of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveRH<T>(T width, T height, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreatePerspective(
                    Unsafe.BitCast<T, float>(width),
                    Unsafe.BitCast<T, float>(height),
                    Unsafe.BitCast<T, float>(nearPlaneDistance),
                    Unsafe.BitCast<T, float>(farPlaneDistance)
                ));
            }

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X4<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / width;
            result.M12 = result.M13 = result.M14 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / height;
            result.M21 = result.M23 = result.M24 = T.Zero;

            T negFarRange = T.IsPositiveInfinity(farPlaneDistance)
                ? -T.One
                : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M33 = negFarRange;
            result.M31 = result.M32 = T.Zero;
            result.M34 = -T.One;

            result.M41 = result.M42 = result.M44 = T.Zero;
            result.M43 = nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a perspective projection matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume at the near view plane.</param>
        /// <param name="height">Height of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveLH<T>(T width, T height, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreatePerspectiveLeftHanded(
                    Unsafe.BitCast<T, float>(width),
                    Unsafe.BitCast<T, float>(height),
                    Unsafe.BitCast<T, float>(nearPlaneDistance),
                    Unsafe.BitCast<T, float>(farPlaneDistance)
                ));
            }

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X4<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / width;
            result.M12 = result.M13 = result.M14 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / height;
            result.M21 = result.M23 = result.M24 = T.Zero;

            T negFarRange = T.IsPositiveInfinity(farPlaneDistance)
                ? T.One
                : farPlaneDistance / (farPlaneDistance - nearPlaneDistance);
            result.M33 = negFarRange;
            result.M31 = result.M32 = T.Zero;
            result.M34 = -T.One;

            result.M41 = result.M42 = result.M44 = T.Zero;
            result.M43 = -nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a perspective projection matrix based on a field of view, aspect ratio, and near and far view plane distances.</summary>
        /// <param name="fieldOfView">Field of view in the y direction, in radians.</param>
        /// <param name="aspectRatio">Aspect ratio, defined as view space width divided by height.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveFieldOfViewRH<T>(T fieldOfView, T aspectRatio, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreatePerspectiveFieldOfView(
                    Unsafe.BitCast<T, float>(fieldOfView),
                    Unsafe.BitCast<T, float>(aspectRatio),
                    Unsafe.BitCast<T, float>(nearPlaneDistance),
                    Unsafe.BitCast<T, float>(farPlaneDistance)
                ));
            }

            if (!(fieldOfView > T.Zero) || (fieldOfView >= T.Pi))
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            T yScale = T.One / T.Tan(fieldOfView / T.CreateTruncating(2));
            T xScale = yScale / aspectRatio;

            Matrix4X4<T> result = default;

            result.M11 = xScale;
            result.M12 = result.M13 = result.M14 = T.Zero;

            result.M22 = yScale;
            result.M21 = result.M23 = result.M24 = T.Zero;

            result.M31 = result.M32 = T.Zero;
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? -T.One : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M33 = negFarRange;
            result.M34 = -T.One;

            result.M41 = result.M42 = result.M44 = T.Zero;
            result.M43 = nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a perspective projection matrix based on a field of view, aspect ratio, and near and far view plane distances.</summary>
        /// <param name="fieldOfView">Field of view in the y direction, in radians.</param>
        /// <param name="aspectRatio">Aspect ratio, defined as view space width divided by height.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveFieldOfViewLH<T>(T fieldOfView, T aspectRatio, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreatePerspectiveFieldOfViewLeftHanded(
                    Unsafe.BitCast<T, float>(fieldOfView),
                    Unsafe.BitCast<T, float>(aspectRatio),
                    Unsafe.BitCast<T, float>(nearPlaneDistance),
                    Unsafe.BitCast<T, float>(farPlaneDistance)
                ));
            }

            if (!(fieldOfView > T.Zero) || (fieldOfView >= T.Pi))
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            T yScale = T.One / T.Tan(fieldOfView / T.CreateTruncating(2));
            T xScale = yScale / aspectRatio;

            Matrix4X4<T> result = default;

            result.M11 = xScale;
            result.M12 = result.M13 = result.M14 = T.Zero;

            result.M22 = yScale;
            result.M21 = result.M23 = result.M24 = T.Zero;

            result.M31 = result.M32 = T.Zero;
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? T.One : farPlaneDistance / (farPlaneDistance - nearPlaneDistance);
            result.M33 = negFarRange;
            result.M34 = -T.One;

            result.M41 = result.M42 = result.M44 = T.Zero;
            result.M43 = -nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a customized, perspective projection matrix.</summary>
        /// <param name="left">Minimum x-value of the view volume at the near view plane.</param>
        /// <param name="right">Maximum x-value of the view volume at the near view plane.</param>
        /// <param name="bottom">Minimum y-value of the view volume at the near view plane.</param>
        /// <param name="top">Maximum y-value of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to of the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveOffCenterRH<T>(T left, T right, T bottom, T top, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreatePerspectiveOffCenter(
                    Unsafe.BitCast<T, float>(left),
                    Unsafe.BitCast<T, float>(right),
                    Unsafe.BitCast<T, float>(bottom),
                    Unsafe.BitCast<T, float>(top),
                    Unsafe.BitCast<T, float>(nearPlaneDistance),
                    Unsafe.BitCast<T, float>(farPlaneDistance)
                ));
            }

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X4<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / (right - left);
            result.M12 = result.M13 = result.M14 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / (top - bottom);
            result.M21 = result.M23 = result.M24 = T.Zero;

            result.M31 = (left + right) / (right - left);
            result.M32 = (top + bottom) / (top - bottom);
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? -T.One : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M33 = negFarRange;
            result.M34 = -T.One;

            result.M43 = nearPlaneDistance * negFarRange;
            result.M41 = result.M42 = result.M44 = T.Zero;

            return result;
        }

        /// <summary>Creates a customized, perspective projection matrix.</summary>
        /// <param name="left">Minimum x-value of the view volume at the near view plane.</param>
        /// <param name="right">Maximum x-value of the view volume at the near view plane.</param>
        /// <param name="bottom">Minimum y-value of the view volume at the near view plane.</param>
        /// <param name="top">Maximum y-value of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to of the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveOffCenterLH<T>(T left, T right, T bottom, T top, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreatePerspectiveOffCenterLeftHanded(
                    Unsafe.BitCast<T, float>(left),
                    Unsafe.BitCast<T, float>(right),
                    Unsafe.BitCast<T, float>(bottom),
                    Unsafe.BitCast<T, float>(top),
                    Unsafe.BitCast<T, float>(nearPlaneDistance),
                    Unsafe.BitCast<T, float>(farPlaneDistance)
                ));
            }

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X4<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / (right - left);
            result.M12 = result.M13 = result.M14 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / (top - bottom);
            result.M21 = result.M23 = result.M24 = T.Zero;

            result.M31 = (left + right) / (right - left);
            result.M32 = (top + bottom) / (top - bottom);
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? T.One : farPlaneDistance / (farPlaneDistance - nearPlaneDistance);
            result.M33 = negFarRange;
            result.M34 = -T.One;

            result.M43 = -nearPlaneDistance * negFarRange;
            result.M41 = result.M42 = result.M44 = T.Zero;

            return result;
        }

        /// <summary>Creates a Matrix that reflects the coordinate system about a specified Plane.</summary>
        /// <param name="value">The Plane about which to create a reflection.</param>
        /// <returns>A new matrix expressing the reflection.</returns>
        public static Matrix4X4<T> CreateReflection<T>(Plane<T> value)
            where T : INumber<T>, IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateReflection(
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(value)
                ));
            }

            value = Plane.Normalize(value);

            T a = value.Normal.X;
            T b = value.Normal.Y;
            T c = value.Normal.Z;

            T fa = -T.CreateTruncating(2) * a;
            T fb = -T.CreateTruncating(2) * b;
            T fc = -T.CreateTruncating(2) * c;

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = (fa * a) + T.One;
            result.M12 = fb * a;
            result.M13 = fc * a;

            result.M21 = fa * b;
            result.M22 = (fb * b) + T.One;
            result.M23 = fc * b;

            result.M31 = fa * c;
            result.M32 = fb * c;
            result.M33 = (fc * c) + T.One;

            result.M41 = fa * value.Distance;
            result.M42 = fb * value.Distance;
            result.M43 = fc * value.Distance;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the X-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationX<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateRotationX(
                    Unsafe.BitCast<T, float>(radians)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  0  0  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = -s;
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the X-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationX<T>(T radians, Vector3D<T> centerPoint)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateRotationX(
                    Unsafe.BitCast<T, float>(radians),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(centerPoint)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            T y = (centerPoint.Y * (T.One - c)) + (centerPoint.Z * s);
            T z = (centerPoint.Z * (T.One - c)) - (centerPoint.Y * s);

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  y  z  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = -s;
            result.M33 = c;
            result.M42 = y;
            result.M43 = z;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationY<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateRotationY(
                    Unsafe.BitCast<T, float>(radians)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M13 = -s;
            result.M31 = s;
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationY<T>(T radians, Vector3D<T> centerPoint)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateRotationY(
                    Unsafe.BitCast<T, float>(radians),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(centerPoint)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            T x = (centerPoint.X * (T.One - c)) - (centerPoint.Z * s);
            T z = (centerPoint.Z * (T.One - c)) + (centerPoint.X * s);

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  x  0  z  1 ]
            result.M11 = c;
            result.M13 = -s;
            result.M31 = s;
            result.M33 = c;
            result.M41 = x;
            result.M43 = z;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Z-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationZ<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateRotationZ(
                    Unsafe.BitCast<T, float>(radians)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = -s;
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Z-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationZ<T>(T radians, Vector3D<T> centerPoint)
            where T : ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateRotationZ(
                    Unsafe.BitCast<T, float>(radians),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(centerPoint)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = T.Cos(radians);
            T s = T.Sin(radians);

            T x = (centerPoint.X * (T.One - c)) + (centerPoint.Y * s);
            T y = (centerPoint.Y * (T.One - c)) - (centerPoint.X * s);

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  x  y  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = -s;
            result.M22 = c;
            result.M41 = x;
            result.M42 = y;

            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="zScale">Value to scale by on the Z-axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X4<T> CreateScale<T>(T xScale, T yScale, T zScale)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateScale(
                    Unsafe.BitCast<T, float>(xScale),
                    Unsafe.BitCast<T, float>(yScale),
                    Unsafe.BitCast<T, float>(zScale)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;
            result.M11 = xScale;
            result.M22 = yScale;
            result.M33 = zScale;
            return result;
        }

        /// <summary>Creates a scaling matrix with a center point.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="zScale">Value to scale by on the Z-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X4<T> CreateScale<T>(T xScale, T yScale, T zScale, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateScale(
                    Unsafe.BitCast<T, float>(xScale),
                    Unsafe.BitCast<T, float>(yScale),
                    Unsafe.BitCast<T, float>(zScale),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(centerPoint)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T tx = centerPoint.X * (T.One - xScale);
            T ty = centerPoint.Y * (T.One - yScale);
            T tz = centerPoint.Z * (T.One - zScale);

            result.M11 = xScale;
            result.M22 = yScale;
            result.M33 = zScale;
            result.M41 = tx;
            result.M42 = ty;
            result.M43 = tz;
            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X4<T> CreateScale<T>(Vector3D<T> scales)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateScale(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(scales)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;
            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            return result;
        }

        /// <summary>Creates a scaling matrix with a center point.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X4<T> CreateScale<T>(Vector3D<T> scales, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateScale(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(scales),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(centerPoint)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T tx = centerPoint.X * (T.One - scales.X);
            T ty = centerPoint.Y * (T.One - scales.Y);
            T tz = centerPoint.Z * (T.One - scales.Z);

            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            result.M41 = tx;
            result.M42 = ty;
            result.M43 = tz;
            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X4<T> CreateScale<T>(T scale)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateScale(
                    Unsafe.BitCast<T, float>(scale)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis with a center point.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X4<T> CreateScale<T>(T scale, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateScale(
                    Unsafe.BitCast<T, float>(scale),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(centerPoint)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T tx = centerPoint.X * (T.One - scale);
            T ty = centerPoint.Y * (T.One - scale);
            T tz = centerPoint.Z * (T.One - scale);

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            result.M41 = tx;
            result.M42 = ty;
            result.M43 = tz;

            return result;
        }

        /// <summary>Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.</summary>
        /// <param name="lightDirection">The direction from which the light that will cast the shadow is coming.</param>
        /// <param name="plane">The Plane onto which the new matrix should flatten geometry so as to cast a shadow.</param>
        /// <returns>A new Matrix that can be used to flatten geometry onto the specified plane from the specified direction.</returns>
        public static Matrix4X4<T> CreateShadow<T>(Vector3D<T> lightDirection, Plane<T> plane)
            where T : INumber<T>, IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateShadow(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(lightDirection),
                    Unsafe.BitCast<Plane<T>, System.Numerics.Plane>(plane)
                ));
            }

            Plane<T> p = Plane.Normalize(plane);

            T dot = (p.Normal.X * lightDirection.X) + (p.Normal.Y * lightDirection.Y) + (p.Normal.Z * lightDirection.Z);
            T a = -p.Normal.X;
            T b = -p.Normal.Y;
            T c = -p.Normal.Z;
            T d = -p.Distance;

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = (a * lightDirection.X) + dot;
            result.M21 = b * lightDirection.X;
            result.M31 = c * lightDirection.X;
            result.M41 = d * lightDirection.X;

            result.M12 = a * lightDirection.Y;
            result.M22 = (b * lightDirection.Y) + dot;
            result.M32 = c * lightDirection.Y;
            result.M42 = d * lightDirection.Y;

            result.M13 = a * lightDirection.Z;
            result.M23 = b * lightDirection.Z;
            result.M33 = (c * lightDirection.Z) + dot;
            result.M43 = d * lightDirection.Z;

            result.M44 = dot;

            return result;
        }

        /// <summary>Creates a translation matrix.</summary>
        /// <param name="position">The amount to translate in each axis.</param>
        /// <returns>The translation matrix.</returns>
        public static Matrix4X4<T> CreateTranslation<T>(Vector3D<T> position)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateTranslation(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(position)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;
            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;
            return result;
        }

        /// <summary>Creates a translation matrix.</summary>
        /// <param name="xPosition">The amount to translate on the X-axis.</param>
        /// <param name="yPosition">The amount to translate on the Y-axis.</param>
        /// <param name="zPosition">The amount to translate on the Z-axis.</param>
        /// <returns>The translation matrix.</returns>
        public static Matrix4X4<T> CreateTranslation<T>(T xPosition, T yPosition, T zPosition)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateTranslation(
                    Unsafe.BitCast<T, float>(xPosition),
                    Unsafe.BitCast<T, float>(yPosition),
                    Unsafe.BitCast<T, float>(zPosition)
                ));
            }

            Matrix4X4<T> result = Matrix4X4<T>.Identity;
            result.M41 = xPosition;
            result.M42 = yPosition;
            result.M43 = zPosition;
            return result;
        }

        /// <summary>Creates a world matrix with the specified parameters.</summary>
        /// <param name="position">The position of the object; used in translation operations.</param>
        /// <param name="forward">Forward direction of the object.</param>
        /// <param name="up">Upward direction of the object; usually [0, 1, 0].</param>
        /// <returns>The world matrix.</returns>
        public static Matrix4X4<T> CreateWorld<T>(Vector3D<T> position, Vector3D<T> forward, Vector3D<T> up)
            where T : IRootFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateWorld(
                    Unsafe.BitCast<Vector3D<T>, Vector3>(position),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(forward),
                    Unsafe.BitCast<Vector3D<T>, Vector3>(up)
                ));
            }

            Vector3D<T> zaxis = Vector3D.Normalize(-forward);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(up, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = xaxis.X;
            result.M12 = xaxis.Y;
            result.M13 = xaxis.Z;

            result.M21 = yaxis.X;
            result.M22 = yaxis.Y;
            result.M23 = yaxis.Z;

            result.M31 = zaxis.X;
            result.M32 = zaxis.Y;
            result.M33 = zaxis.Z;

            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;

            return result;
        }

        /// <summary>Creates a right-handed viewport matrix from the specified parameters.</summary>
        /// <param name="x">X coordinate of the viewport upper left corner.</param>
        /// <param name="y">Y coordinate of the viewport upper left corner.</param>
        /// <param name="width">Viewport width.</param>
        /// <param name="height">Viewport height.</param>
        /// <param name="minDepth">Viewport minimum depth.</param>
        /// <param name="maxDepth">Viewport maximum depth.</param>
        /// <returns>The right-handed viewport matrix.</returns>
        /// <remarks>
        /// Viewport matrix
        /// |   width / 2   |        0       |          0          | 0 |
        /// |       0       |   -height / 2  |          0          | 0 |
        /// |       0       |        0       | minDepth - maxDepth | 0 |
        /// | x + width / 2 | y + height / 2 |       minDepth      | 1 |
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4X4<T> CreateViewportRH<T>(T x, T y, T width, T height, T minDepth, T maxDepth)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateViewport(
                    Unsafe.BitCast<T, float>(x),
                    Unsafe.BitCast<T, float>(y),
                    Unsafe.BitCast<T, float>(width),
                    Unsafe.BitCast<T, float>(height),
                    Unsafe.BitCast<T, float>(minDepth),
                    Unsafe.BitCast<T, float>(maxDepth)
                ));
            }

            // From: https://github.com/dotnet/dotnet/blob/main/src/runtime/src/libraries/System.Private.CoreLib/src/System/Numerics/Matrix4x4.Impl.cs
            Matrix4X4<T> result;
            result.Row4 = new Vector4D<T>(width, height, T.Zero, T.Zero) / T.CreateTruncating(2);
            result.Row1 = new Vector4D<T>(result.Row4.X, T.Zero, T.Zero, T.Zero);
            result.Row2 = new Vector4D<T>(T.Zero, -result.Row4.Y, T.Zero, T.Zero);
            result.Row3 = new Vector4D<T>(T.Zero, T.Zero, minDepth - maxDepth, T.Zero);
            result.Row4 += new Vector4D<T>(x, y, minDepth, T.One);
            return result;
        }

        /// <summary>Creates a left-handed viewport matrix from the specified parameters.</summary>
        /// <param name="x">X coordinate of the viewport upper left corner.</param>
        /// <param name="y">Y coordinate of the viewport upper left corner.</param>
        /// <param name="width">Viewport width.</param>
        /// <param name="height">Viewport height.</param>
        /// <param name="minDepth">Viewport minimum depth.</param>
        /// <param name="maxDepth">Viewport maximum depth.</param>
        /// <returns>The left-handed viewport matrix.</returns>
        /// <remarks>
        /// Viewport matrix
        /// |   width / 2   |        0       |          0          | 0 |
        /// |       0       |   -height / 2  |          0          | 0 |
        /// |       0       |        0       | maxDepth - minDepth | 0 |
        /// | x + width / 2 | y + height / 2 |       minDepth      | 1 |
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4X4<T> CreateViewportLH<T>(T x, T y, T width, T height, T minDepth, T maxDepth)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.CreateViewportLeftHanded(
                    Unsafe.BitCast<T, float>(x),
                    Unsafe.BitCast<T, float>(y),
                    Unsafe.BitCast<T, float>(width),
                    Unsafe.BitCast<T, float>(height),
                    Unsafe.BitCast<T, float>(minDepth),
                    Unsafe.BitCast<T, float>(maxDepth)
                ));
            }

            // From: https://github.com/dotnet/dotnet/blob/main/src/runtime/src/libraries/System.Private.CoreLib/src/System/Numerics/Matrix4x4.Impl.cs
            Matrix4X4<T> result;
            result.Row4 = new Vector4D<T>(width, height, T.Zero, T.Zero) / T.CreateTruncating(2);
            result.Row1 = new Vector4D<T>(result.Row4.X, T.Zero, T.Zero, T.Zero);
            result.Row2 = new Vector4D<T>(T.Zero, -result.Row4.Y, T.Zero, T.Zero);
            result.Row3 = new Vector4D<T>(T.Zero, T.Zero, maxDepth - minDepth, T.Zero);
            result.Row4 += new Vector4D<T>(x, y, minDepth, T.One);
            return result;
        }

        /// <summary>Attempts to calculate the inverse of the given matrix. If successful, result will contain the inverted matrix.</summary>
        /// <param name="matrix">The source matrix to invert.</param>
        /// <param name="result">If successful, contains the inverted matrix.</param>
        /// <returns><c>true</c> if the source matrix could be inverted; <c>false</c> otherwise.</returns>
        ///
        [MethodImpl((MethodImplOptions)768)]
        public static bool Invert<T>(Matrix4X4<T> matrix, out Matrix4X4<T> result)
            where T : IFloatingPointIeee754<T>
        {
            if (typeof(T) == typeof(float))
            {
                result = default;
                return Matrix4x4.Invert(
                    Unsafe.BitCast<Matrix4X4<T>, Matrix4x4>(matrix),
                    out Unsafe.As<Matrix4X4<T>, Matrix4x4>(ref result)
                );
            }

            //                                       -1
            // If you have matrix M, inverse Matrix M   can compute
            //
            //     -1       1
            //    M   = --------- A
            //            det(M)
            //
            // A is adjugate (adjoint) of M, where,
            //
            //      T
            // A = C
            //
            // C is Cofactor matrix of M, where,
            //           i + j
            // C   = (-1)      * det(M  )
            //  ij                    ij
            //
            //     [ a b c d ]
            // M = [ e f g h ]
            //     [ i j k l ]
            //     [ m n o p ]
            //
            // First Row
            //           2 | f g h |
            // C   = (-1)  | j k l | = + ( f ( kp - lo ) - g ( jp - ln ) + h ( jo - kn ) )
            //  11         | n o p |
            //
            //           3 | e g h |
            // C   = (-1)  | i k l | = - ( e ( kp - lo ) - g ( ip - lm ) + h ( io - km ) )
            //  12         | m o p |
            //
            //           4 | e f h |
            // C   = (-1)  | i j l | = + ( e ( jp - ln ) - f ( ip - lm ) + h ( in - jm ) )
            //  13         | m n p |
            //
            //           5 | e f g |
            // C   = (-1)  | i j k | = - ( e ( jo - kn ) - f ( io - km ) + g ( in - jm ) )
            //  14         | m n o |
            //
            // Second Row
            //           3 | b c d |
            // C   = (-1)  | j k l | = - ( b ( kp - lo ) - c ( jp - ln ) + d ( jo - kn ) )
            //  21         | n o p |
            //
            //           4 | a c d |
            // C   = (-1)  | i k l | = + ( a ( kp - lo ) - c ( ip - lm ) + d ( io - km ) )
            //  22         | m o p |
            //
            //           5 | a b d |
            // C   = (-1)  | i j l | = - ( a ( jp - ln ) - b ( ip - lm ) + d ( in - jm ) )
            //  23         | m n p |
            //
            //           6 | a b c |
            // C   = (-1)  | i j k | = + ( a ( jo - kn ) - b ( io - km ) + c ( in - jm ) )
            //  24         | m n o |
            //
            // Third Row
            //           4 | b c d |
            // C   = (-1)  | f g h | = + ( b ( gp - ho ) - c ( fp - hn ) + d ( fo - gn ) )
            //  31         | n o p |
            //
            //           5 | a c d |
            // C   = (-1)  | e g h | = - ( a ( gp - ho ) - c ( ep - hm ) + d ( eo - gm ) )
            //  32         | m o p |
            //
            //           6 | a b d |
            // C   = (-1)  | e f h | = + ( a ( fp - hn ) - b ( ep - hm ) + d ( en - fm ) )
            //  33         | m n p |
            //
            //           7 | a b c |
            // C   = (-1)  | e f g | = - ( a ( fo - gn ) - b ( eo - gm ) + c ( en - fm ) )
            //  34         | m n o |
            //
            // Fourth Row
            //           5 | b c d |
            // C   = (-1)  | f g h | = - ( b ( gl - hk ) - c ( fl - hj ) + d ( fk - gj ) )
            //  41         | j k l |
            //
            //           6 | a c d |
            // C   = (-1)  | e g h | = + ( a ( gl - hk ) - c ( el - hi ) + d ( ek - gi ) )
            //  42         | i k l |
            //
            //           7 | a b d |
            // C   = (-1)  | e f h | = - ( a ( fl - hj ) - b ( el - hi ) + d ( ej - fi ) )
            //  43         | i j l |
            //
            //           8 | a b c |
            // C   = (-1)  | e f g | = + ( a ( fk - gj ) - b ( ek - gi ) + c ( ej - fi ) )
            //  44         | i j k |
            //
            // Cost of operation
            // 53 adds, 104 muls, and 1 div.
            T a = matrix.M11, b = matrix.M12, c = matrix.M13, d = matrix.M14;
            T e = matrix.M21, f = matrix.M22, g = matrix.M23, h = matrix.M24;
            T i = matrix.M31, j = matrix.M32, k = matrix.M33, l = matrix.M34;
            T m = matrix.M41, n = matrix.M42, o = matrix.M43, p = matrix.M44;

            T kp_lo = (k * p) - (l * o);
            T jp_ln = (j * p) - (l * n);
            T jo_kn = (j * o) - (k * n);
            T ip_lm = (i * p) - (l * m);
            T io_km = (i * o) - (k * m);
            T in_jm = (i * n) - (j * m);

            T a11 = (f * kp_lo) - (g * jp_ln) + (h * jo_kn);
            T a12 = -((e * kp_lo) - (g * ip_lm) + (h * io_km));
            T a13 = (e * jp_ln) - (f * ip_lm) + (h * in_jm);
            T a14 = -((e * jo_kn) - (f * io_km) + (g * in_jm));

            T det = (a * a11) + (b * a12) + (c * a13) + (d * a14);

            if (!(T.Abs(det) >= T.Epsilon))
            {
                result = default;
                return false;
            }

            T invDet = T.One / det;

            result = default;

            result.M11 = a11 * invDet;
            result.M21 = a12 * invDet;
            result.M31 = a13 * invDet;
            result.M41 = a14 * invDet;

            result.M12 = -(((b * kp_lo) - (c * jp_ln) + (d * jo_kn)) * invDet);
            result.M22 = ((a * kp_lo) - (c * ip_lm) + (d * io_km)) * invDet;
            result.M32 = -(((a * jp_ln) - (b * ip_lm) + (d * in_jm)) * invDet);
            result.M42 = ((a * jo_kn) - (b * io_km) + (c * in_jm)) * invDet;

            T gp_ho = (g * p) - (h * o);
            T fp_hn = (f * p) - (h * n);
            T fo_gn = (f * o) - (g * n);
            T ep_hm = (e * p) - (h * m);
            T eo_gm = (e * o) - (g * m);
            T en_fm = (e * n) - (f * m);

            result.M13 = ((b * gp_ho) - (c * fp_hn) + (d * fo_gn)) * invDet;
            result.M23 = -(((a * gp_ho) - (c * ep_hm) + (d * eo_gm)) * invDet);
            result.M33 = ((a * fp_hn) - (b * ep_hm) + (d * en_fm)) * invDet;
            result.M43 = -(((a * fo_gn) - (b * eo_gm) + (c * en_fm)) * invDet);

            T gl_hk = (g * l) - (h * k);
            T fl_hj = (f * l) - (h * j);
            T fk_gj = (f * k) - (g * j);
            T el_hi = (e * l) - (h * i);
            T ek_gi = (e * k) - (g * i);
            T ej_fi = (e * j) - (f * i);

            result.M14 = -(((b * gl_hk) - (c * fl_hj) + (d * fk_gj)) * invDet);
            result.M24 = ((a * gl_hk) - (c * el_hi) + (d * ek_gi)) * invDet;
            result.M34 = -(((a * fl_hj) - (b * el_hi) + (d * ej_fi)) * invDet);
            result.M44 = ((a * fk_gj) - (b * ek_gi) + (c * ej_fi)) * invDet;

            return true;
        }

        /*[MethodImpl((MethodImplOptions)768)]
        private static Vector128<T> Permute(Vector128<T> value, byte control)
        {
            if (Avx.IsSupported)
            {
                return Avx.Permute(value, control);
            }
            else if (Sse.IsSupported)
            {
                return Sse.Shuffle(value, value, control);
            }
            else
            {
                // Redundant test so we won't prejit remainder of this method on platforms without AdvSimd.
                throw new PlatformNotSupportedException();
            }
        }*/

        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <param name="translation">The translation component of the transformation matrix</param>
        /// <returns><c>true</c> if the source matrix was successfully decomposed; <c>false</c> otherwise.</returns>
        public static bool Decompose<T>(Matrix4X4<T> matrix, out Vector3D<T> scale, out Quaternion<T> rotation, out Vector3D<T> translation)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                scale = default;
                rotation = default;
                translation = default;
                return Matrix4x4.Decompose(
                    Unsafe.BitCast<Matrix4X4<T>, Matrix4x4>(matrix),
                    out Unsafe.As<Vector3D<T>, Vector3>(ref scale),
                    out Unsafe.As<Quaternion<T>, System.Numerics.Quaternion>(ref rotation),
                    out Unsafe.As<Vector3D<T>, Vector3>(ref translation)
                );
            }

            bool result = true;
            scale = default;

            Vector3D<T>[] vectorBasis = new Vector3D<T>[3];
            Matrix3X3<T> canonicalBasis = Matrix3X3<T>.Identity;
            Matrix4X4<T> matTemp;

            translation = new Vector3D<T>(
                matrix.M41,
                matrix.M42,
                matrix.M43);

            matTemp = new Matrix4X4<T>(
                matrix.M11, matrix.M12, matrix.M13, T.Zero,
                matrix.M21, matrix.M22, matrix.M23, T.Zero,
                matrix.M31, matrix.M32, matrix.M33, T.Zero,
                T.Zero, T.Zero, T.Zero, T.One);

            T x = scale.X = matTemp.Row1.Length;
            T y = scale.Y = matTemp.Row2.Length;
            T z = scale.Z = matTemp.Row3.Length;

            int a, b, c;
            if (!(x >= y))
            {
                if (!(y >= z))
                {
                    a = 2;
                    b = 1;
                    c = 0;
                }
                else
                {
                    a = 1;

                    if (!(x >= z))
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
                if (!(x >= z))
                {
                    a = 2;
                    b = 0;
                    c = 1;
                }
                else
                {
                    a = 0;

                    if (!(y >= z))
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

            T eps = T.CreateTruncating(DecomposeEpsilon);

            if (!(scale[a] >= eps))
            {
                var normalA = canonicalBasis[a];
                matTemp[a][0] = normalA[0];
                matTemp[a][1] = normalA[1];
                matTemp[a][2] = normalA[2];
            }

            matTemp[a] = matTemp[a].Normalize();

            if (!(scale[b] >= eps))
            {
                int cc;
                T absX, absY, absZ;

                absX = T.Abs(matTemp[a].X);
                absY = T.Abs(matTemp[a].Y);
                absZ = T.Abs(matTemp[a].Z);

                if (!(absX >= absY))
                {
                    if (!(absY >= absZ))
                    {
                        cc = 0;
                    }
                    else
                    {
                        if (!(absX >= absZ))
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
                    if (!(absX >= absZ))
                    {
                        cc = 1;
                    }
                    else
                    {
                        if (!(absY >= absZ))
                        {
                            cc = 1;
                        }
                        else
                        {
                            cc = 2;
                        }
                    }
                }

                var normalB = Vector3D.Cross((Vector3D<T>)matTemp[a], canonicalBasis[cc]);
                matTemp[b][0] = normalB[0];
                matTemp[b][1] = normalB[1];
                matTemp[b][2] = normalB[2];
            }

            matTemp[b] = matTemp[b].Normalize();

            if (!(scale[c] >= eps))
            {
                var normalC = Vector3D.Cross((Vector3D<T>)matTemp[a], (Vector3D<T>)matTemp[b]);
                matTemp[c][0] = normalC[0];
                matTemp[c][1] = normalC[1];
                matTemp[c][2] = normalC[2];
            }

            matTemp[c] = matTemp[c].Normalize();

            T det = matTemp.GetDeterminant();

            // use Kramer's rule to check for handedness of coordinate system
            if (!(det >= T.Zero))
            {
                // switch coordinate system by negating the scale and inverting the basis vector on the x-axis
                scale[a] = -scale[a];
                matTemp[a][0] = -matTemp[a][0];
                matTemp[a][1] = -matTemp[a][1];
                matTemp[a][2] = -matTemp[a][2];
                det = -det;
            }

            det = det - T.One;
            det = det * det;

            if (!(eps >= det))
            {
                // Non-SRT matrix encountered
                rotation = Quaternion<T>.Identity;
                result = false;
            }
            else
            {
                // generate the quaternion from the matrix
                rotation = Quaternion.CreateFromRotationMatrix(matTemp);
            }

            return result;
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix4X4<T> Transform<T>(Matrix4X4<T> value, Quaternion<T> rotation)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.Transform(
                    Unsafe.BitCast<Matrix4X4<T>, Matrix4x4>(value),
                    Unsafe.BitCast<Quaternion<T>, System.Numerics.Quaternion>(rotation)
                ));
            }

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

            return new(
                new(value.M11 * q1 + value.M12 * q2 + value.M13 * q3, value.M14),
                new(value.M21 * q1 + value.M22 * q2 + value.M23 * q3, value.M24),
                new(value.M31 * q1 + value.M32 * q2 + value.M33 * q3, value.M34),
                new(value.M41 * q1 + value.M42 * q2 + value.M43 * q3, value.M44)
                );
        }

        /// <summary>Transposes the rows and columns of a matrix.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <returns>The transposed matrix.</returns>
        public static Matrix4X4<T> Transpose<T>(Matrix4X4<T> matrix)
            where T : INumberBase<T>
        {
            if (typeof(T) == typeof(float))
            {
                return Unsafe.BitCast<Matrix4x4, Matrix4X4<T>>(Matrix4x4.Transpose(
                    Unsafe.BitCast<Matrix4X4<T>, Matrix4x4>(matrix)
                ));
            }

            return new(matrix.Column1, matrix.Column2, matrix.Column3, matrix.Column4);
        }
    }
}
