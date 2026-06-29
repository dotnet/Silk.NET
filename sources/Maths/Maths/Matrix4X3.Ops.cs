// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X3{T}"/>
    /// </summary>
    public static partial class Matrix4X3
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public static Matrix4X3<T> CreateFromAffine<T>(Matrix3X2<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, T.Zero),
                new(value.M21, value.M22, T.Zero),
                Vector3D<T>.UnitZ,
                new(value.M31, value.M32, T.Zero)
            );

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public static Matrix4X3<T> CreateFromAffine<T>(Matrix3X3<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, value.M13),
                new(value.M21, value.M22, value.M23),
                Vector3D<T>.UnitZ,
                new(value.M31, value.M32, value.M33)
            );

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix4X3<T> CreateBillboardRH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
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

            return new(
                xaxis,
                yaxis,
                zaxis,
                objectPosition);
        }

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix4X3<T> CreateBillboardLH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
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
                xaxis,
                yaxis,
                zaxis,
                objectPosition);
        }

        /// <summary>Creates a cylindrical billboard that rotates around a specified axis.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="rotateAxis">Axis to rotate the billboard around.</param>
        /// <param name="cameraForwardVector">Forward vector of the camera.</param>
        /// <param name="objectForwardVector">Forward vector of the object.</param>
        /// <returns>The created billboard matrix.</returns>
        public static Matrix4X3<T> CreateConstrainedBillboardRH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> rotateAxis, Vector3D<T> cameraForwardVector, Vector3D<T> objectForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
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
                xaxis,
                yaxis,
                zaxis,
                objectPosition);
        }

        /// <summary>Creates a cylindrical billboard that rotates around a specified axis.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="rotateAxis">Axis to rotate the billboard around.</param>
        /// <param name="cameraForwardVector">Forward vector of the camera.</param>
        /// <param name="objectForwardVector">Forward vector of the object.</param>
        /// <returns>The created billboard matrix.</returns>
        public static Matrix4X3<T> CreateConstrainedBillboardLH<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> rotateAxis, Vector3D<T> cameraForwardVector, Vector3D<T> objectForwardVector)
            where T : INumber<T>, IRootFunctions<T>
        {
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
                xaxis,
                yaxis,
                zaxis,
                objectPosition);
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X3<T> CreateFromAxisAngle<T>(Vector3D<T> axis, T angle)
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

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateFromQuaternion<T>(Quaternion<T> quaternion)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
            var q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraTarget">The target towards which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4X3<T> CreateLookAtRH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraTarget, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            Vector3D<T> zaxis = Vector3D.Normalize(cameraPosition - cameraTarget);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateLookToRH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraForwardVector, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            Vector3D<T> zaxis = Vector3D.Normalize(cameraForwardVector);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateLookAtLH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraTarget, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            Vector3D<T> zaxis = Vector3D.Normalize(cameraTarget - cameraPosition);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateLookToLH<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraForwardVector, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
            Vector3D<T> zaxis = Vector3D.Normalize(cameraForwardVector);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateOrthographicRH<T>(T width, T height, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateOrthographicLH<T>(T width, T height, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateOrthographicOffCenterRH<T>(T left, T right, T bottom, T top, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateOrthographicOffCenterLH<T>(T left, T right, T bottom, T top, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreatePerspectiveRH<T>(T width, T height, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X3<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / width;
            result.M12 = result.M13 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / height;
            result.M21 = result.M23 = T.Zero;

            T negFarRange = T.IsPositiveInfinity(farPlaneDistance)
                ? -T.One
                : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M33 = negFarRange;
            result.M31 = result.M32 = T.Zero;

            result.M41 = result.M42 = T.Zero;
            result.M43 = nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a perspective projection matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume at the near view plane.</param>
        /// <param name="height">Height of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X3<T> CreatePerspectiveLH<T>(T width, T height, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X3<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / width;
            result.M12 = result.M13 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / height;
            result.M21 = result.M23 = T.Zero;

            T negFarRange = T.IsPositiveInfinity(farPlaneDistance)
                ? T.One
                : farPlaneDistance / (farPlaneDistance - nearPlaneDistance);
            result.M33 = negFarRange;
            result.M31 = result.M32 = T.Zero;

            result.M41 = result.M42 = T.Zero;
            result.M43 = -nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a perspective projection matrix based on a field of view, aspect ratio, and near and far view plane distances.</summary>
        /// <param name="fieldOfView">Field of view in the y direction, in radians.</param>
        /// <param name="aspectRatio">Aspect ratio, defined as view space width divided by height.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X3<T> CreatePerspectiveFieldOfViewRH<T>(T fieldOfView, T aspectRatio, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>, ITrigonometricFunctions<T>
        {
            if (!(fieldOfView > T.Zero) || (fieldOfView >= T.Pi))
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            T yScale = T.One / T.Tan(fieldOfView / T.CreateTruncating(2));
            T xScale = yScale / aspectRatio;

            Matrix4X3<T> result = default;

            result.M11 = xScale;
            result.M12 = result.M13 = T.Zero;

            result.M22 = yScale;
            result.M21 = result.M23 = T.Zero;

            result.M31 = result.M32 = T.Zero;
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? -T.One : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M33 = negFarRange;

            result.M41 = result.M42 = T.Zero;
            result.M43 = nearPlaneDistance * negFarRange;

            return result;
        }

        /// <summary>Creates a perspective projection matrix based on a field of view, aspect ratio, and near and far view plane distances.</summary>
        /// <param name="fieldOfView">Field of view in the y direction, in radians.</param>
        /// <param name="aspectRatio">Aspect ratio, defined as view space width divided by height.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X3<T> CreatePerspectiveFieldOfViewLH<T>(T fieldOfView, T aspectRatio, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>, ITrigonometricFunctions<T>
        {
            if (!(fieldOfView > T.Zero) || (fieldOfView >= T.Pi))
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            T yScale = T.One / T.Tan(fieldOfView / T.CreateTruncating(2));
            T xScale = yScale / aspectRatio;

            Matrix4X3<T> result = default;

            result.M11 = xScale;
            result.M12 = result.M13 = T.Zero;

            result.M22 = yScale;
            result.M21 = result.M23 = T.Zero;

            result.M31 = result.M32 = T.Zero;
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? T.One : farPlaneDistance / (farPlaneDistance - nearPlaneDistance);
            result.M33 = negFarRange;

            result.M41 = result.M42 = T.Zero;
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
        public static Matrix4X3<T> CreatePerspectiveOffCenterRH<T>(T left, T right, T bottom, T top, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X3<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / (right - left);
            result.M12 = result.M13 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / (top - bottom);
            result.M21 = result.M23 = T.Zero;

            result.M31 = (left + right) / (right - left);
            result.M32 = (top + bottom) / (top - bottom);
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? -T.One : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.M33 = negFarRange;

            result.M43 = nearPlaneDistance * negFarRange;
            result.M41 = result.M42 = T.Zero;

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
        public static Matrix4X3<T> CreatePerspectiveOffCenterLH<T>(T left, T right, T bottom, T top, T nearPlaneDistance, T farPlaneDistance)
            where T : INumber<T>
        {
            if (!(nearPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!(farPlaneDistance > T.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X3<T> result = default;

            result.M11 = T.CreateTruncating(2) * nearPlaneDistance / (right - left);
            result.M12 = result.M13 = T.Zero;

            result.M22 = T.CreateTruncating(2) * nearPlaneDistance / (top - bottom);
            result.M21 = result.M23 = T.Zero;

            result.M31 = (left + right) / (right - left);
            result.M32 = (top + bottom) / (top - bottom);
            T negFarRange = T.IsPositiveInfinity(farPlaneDistance) ? T.One : farPlaneDistance / (farPlaneDistance - nearPlaneDistance);
            result.M33 = negFarRange;

            result.M43 = -nearPlaneDistance * negFarRange;
            result.M41 = result.M42 = T.Zero;

            return result;
        }

        /// <summary>Creates a Matrix that reflects the coordinate system about a specified Plane.</summary>
        /// <param name="value">The Plane about which to create a reflection.</param>
        /// <returns>A new matrix expressing the reflection.</returns>
        public static Matrix4X3<T> CreateReflection<T>(Plane<T> value)
            where T : INumber<T>, IRootFunctions<T>
        {
            value = Plane.Normalize(value);

            T a = value.Normal.X;
            T b = value.Normal.Y;
            T c = value.Normal.Z;

            T fa = -T.CreateTruncating(2) * a;
            T fb = -T.CreateTruncating(2) * b;
            T fc = -T.CreateTruncating(2) * c;

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateRotationX<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateRotationX<T>(T radians, Vector3D<T> centerPoint)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateRotationY<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateRotationY<T>(T radians, Vector3D<T> centerPoint)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateRotationZ<T>(T radians)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateRotationZ<T>(T radians, Vector3D<T> centerPoint)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateScale<T>(T xScale, T yScale, T zScale)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;
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
        public static Matrix4X3<T> CreateScale<T>(T xScale, T yScale, T zScale, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateScale<T>(Vector3D<T> scales)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;
            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            return result;
        }

        /// <summary>Creates a scaling matrix with a center point.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X3<T> CreateScale<T>(Vector3D<T> scales, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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
        public static Matrix4X3<T> CreateScale<T>(T scale)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis with a center point.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4X3<T> CreateScale<T>(T scale, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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

        /// <summary>Creates a translation matrix.</summary>
        /// <param name="position">The amount to translate in each axis.</param>
        /// <returns>The translation matrix.</returns>
        public static Matrix4X3<T> CreateTranslation<T>(Vector3D<T> position)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;
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
        public static Matrix4X3<T> CreateTranslation<T>(T xPosition, T yPosition, T zPosition)
            where T : INumberBase<T>
        {
            Matrix4X3<T> result = Matrix4X3<T>.Identity;
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
        public static Matrix4X3<T> CreateWorld<T>(Vector3D<T> position, Vector3D<T> forward, Vector3D<T> up)
            where T : IRootFunctions<T>
        {
            Vector3D<T> zaxis = Vector3D.Normalize(-forward);
            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(up, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            Matrix4X3<T> result = Matrix4X3<T>.Identity;

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

        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <param name="translation">The translation component of the transformation matrix</param>
        /// <returns><c>true</c> if the source matrix was successfully decomposed; <c>false</c> otherwise.</returns>
        public static bool Decompose<T>(Matrix4X3<T> matrix, out Vector3D<T> scale, out Quaternion<T> rotation, out Vector3D<T> translation)
            where T : INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
        {
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
                rotation = Quaternion<T>.CreateFromRotationMatrix(matTemp);
            }

            return result;
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix4X3<T> Transform<T>(Matrix4X3<T> value, Quaternion<T> rotation)
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

            return new(
                value.M11 * q1 + value.M12 * q2 + value.M13 * q3,
                value.M21 * q1 + value.M22 * q2 + value.M23 * q3,
                value.M31 * q1 + value.M32 * q2 + value.M33 * q3,
                value.M41 * q1 + value.M42 * q2 + value.M43 * q3);
        }

    }
}
