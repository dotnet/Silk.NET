// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
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
#if MATHF
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
#else
        private const float BillboardMinAngle = 1.0f - (0.1f * (((float) Math.PI) / 180.0f)); // 0.1 degrees
#endif
        private const float DecomposeEpsilon = 0.0001f;

        /*
        private struct CanonicalBasis<T>
            where T : INumberBase<T>
        {
            public Vector3D<T> Row0;
            public Vector3D<T> Row1;
            public Vector3D<T> Row2;
        };

        private struct VectorBasis<T>
            where T : INumberBase<T>
        {
#pragma warning disable 649
            public unsafe Vector3D<T>* Element0;
            public unsafe Vector3D<T>* Element1;
            public unsafe Vector3D<T>* Element2;
#pragma warning restore 649
        }
        */

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix4X4<T> CreateBillboard<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> cameraUpVector, Vector3D<T> cameraForwardVector)
            where T : IRootFunctions<T>
        {
            Vector3D<T> zaxis = objectPosition - cameraPosition;
            var norm = zaxis.LengthSquared;

            if (!Scalar.GreaterThanOrEqual(norm, Scalar.As<float, T>(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3D.Multiply(zaxis, Scalar.Reciprocal(Scalar.Sqrt(norm)));
            }

            Vector3D<T> xaxis = Vector3D.Normalize(Vector3D.Cross(cameraUpVector, zaxis));
            Vector3D<T> yaxis = Vector3D.Cross(zaxis, xaxis);

            return new(
                new(xaxis, T.Zero),
                new(yaxis, T.Zero),
                new(zaxis, T.Zero),
                new(objectPosition, Scalar<T>.One));
        }

        /// <summary>Creates a cylindrical billboard that rotates around a specified axis.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="rotateAxis">Axis to rotate the billboard around.</param>
        /// <param name="cameraForwardVector">Forward vector of the camera.</param>
        /// <param name="objectForwardVector">Forward vector of the object.</param>
        /// <returns>The created billboard matrix.</returns>
        public static Matrix4X4<T> CreateConstrainedBillboard<T>(Vector3D<T> objectPosition, Vector3D<T> cameraPosition, Vector3D<T> rotateAxis, Vector3D<T> cameraForwardVector, Vector3D<T> objectForwardVector)
            where T : IRootFunctions<T>
        {
            // Treat the case when object and camera positions are too close.
            Vector3D<T> faceDir = objectPosition - cameraPosition;
            T norm = faceDir.LengthSquared;

            if (!Scalar.GreaterThanOrEqual(norm, Scalar.As<float, T>(BillboardEpsilon)))
            {
                faceDir = -cameraForwardVector;
            }
            else
            {
                faceDir = Vector3D.Multiply(faceDir, Scalar.Reciprocal(Scalar.Sqrt(norm)));
            }

            Vector3D<T> yaxis = rotateAxis;
            Vector3D<T> xaxis;
            Vector3D<T> zaxis;

            // Treat the case when angle between faceDir and rotateAxis is too close to 0.
            T dot = Vector3D.Dot(rotateAxis, faceDir);

            if (Scalar.GreaterThan(T.Abs(dot), Scalar.As<float, T>(BillboardMinAngle)))
            {
                zaxis = objectForwardVector;

                // Make sure passed values are useful for compute.
                dot = Vector3D.Dot(rotateAxis, zaxis);

                if (Scalar.GreaterThan(T.Abs(dot), Scalar.As<float, T>(BillboardMinAngle)))
                {
                    zaxis =
                        Scalar.GreaterThan(T.Abs(rotateAxis.Z), Scalar.As<float, T>(BillboardMinAngle))
                            ? new Vector3D<T>(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero)
                            : new Vector3D<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.MinusOne);
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
                new(objectPosition, Scalar<T>.One));
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateFromAxisAngle<T>(Vector3D<T> axis, T angle)
            where T : INumberBase<T>
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

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

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
        public static Matrix4X4<T> CreateFromQuaternion<T>(Quaternion<T> quaternion)
            where T : ITrigonometricFunctions<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

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
        public static Matrix4X4<T> CreateFromYawPitchRoll<T>(T yaw, T pitch, T roll)
            where T : ITrigonometricFunctions<T>
        {
            var q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraTarget">The target towards which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4X4<T> CreateLookAt<T>(Vector3D<T> cameraPosition, Vector3D<T> cameraTarget, Vector3D<T> cameraUpVector)
            where T : IRootFunctions<T>
        {
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

            result.M41 = Scalar.Negate(Vector3D.Dot(xaxis, cameraPosition));
            result.M42 = Scalar.Negate(Vector3D.Dot(yaxis, cameraPosition));
            result.M43 = Scalar.Negate(Vector3D.Dot(zaxis, cameraPosition));

            return result;
        }

        /// <summary>Creates an orthographic perspective matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume.</param>
        /// <param name="height">Height of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4X4<T> CreateOrthographic<T>(T width, T height, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = Scalar.Divide(Scalar<T>.Two, width);
            result.M22 = Scalar.Divide(Scalar<T>.Two, height);
            result.M33 = Scalar.Reciprocal(Scalar.Subtract(zNearPlane, zFarPlane));
            result.M43 = Scalar.Divide(zNearPlane, Scalar.Subtract(zNearPlane, zFarPlane));

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
        public static Matrix4X4<T> CreateOrthographicOffCenter<T>(T left, T right, T bottom, T top, T zNearPlane, T zFarPlane)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = Scalar.Divide(Scalar<T>.Two, Scalar.Subtract(right, left));

            result.M22 = Scalar.Divide(Scalar<T>.Two, Scalar.Subtract(top, bottom));

            result.M33 = Scalar.Reciprocal(Scalar.Subtract(zNearPlane, zFarPlane));

            result.M41 = Scalar.Divide(Scalar.Add(left, right), Scalar.Subtract(left, right));
            result.M42 = Scalar.Divide(Scalar.Add(top, bottom), Scalar.Subtract(bottom, top));
            result.M43 = Scalar.Divide(zNearPlane, Scalar.Subtract(zNearPlane, zFarPlane));

            return result;
        }

        /// <summary>Creates a perspective projection matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume at the near view plane.</param>
        /// <param name="height">Height of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspective<T>(T width, T height, T nearPlaneDistance, T farPlaneDistance)
            where T : INumberBase<T>
        {
            if (!Scalar.GreaterThan(nearPlaneDistance, Scalar<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!Scalar.GreaterThan(farPlaneDistance, Scalar<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X4<T> result = default;

            result.M11 = Scalar.Divide(Scalar.Multiply(Scalar<T>.Two, nearPlaneDistance), width);
            result.M12 = result.M13 = result.M14 = Scalar<T>.Zero;

            result.M22 = Scalar.Divide(Scalar.Multiply(Scalar<T>.Two, nearPlaneDistance), height);
            result.M21 = result.M23 = result.M24 = Scalar<T>.Zero;

            T negFarRange = Scalar.IsPositiveInfinity(farPlaneDistance)
                ? Scalar<T>.MinusOne
                : Scalar.Divide(farPlaneDistance, Scalar.Subtract(nearPlaneDistance, farPlaneDistance));
            result.M33 = negFarRange;
            result.M31 = result.M32 = Scalar<T>.Zero;
            result.M34 = Scalar<T>.MinusOne;

            result.M41 = result.M42 = result.M44 = Scalar<T>.Zero;
            result.M43 = Scalar.Multiply(nearPlaneDistance, negFarRange);

            return result;
        }

        /// <summary>Creates a perspective projection matrix based on a field of view, aspect ratio, and near and far view plane distances.</summary>
        /// <param name="fieldOfView">Field of view in the y direction, in radians.</param>
        /// <param name="aspectRatio">Aspect ratio, defined as view space width divided by height.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4X4<T> CreatePerspectiveFieldOfView<T>(T fieldOfView, T aspectRatio, T nearPlaneDistance, T farPlaneDistance)
            where T : INumberBase<T>
        {
            if (!Scalar.GreaterThan(fieldOfView, Scalar<T>.Zero) || Scalar.GreaterThanOrEqual(fieldOfView, Scalar<T>.Pi))
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (!Scalar.GreaterThan(nearPlaneDistance, Scalar<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!Scalar.GreaterThan(farPlaneDistance, Scalar<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            T yScale = Scalar.Reciprocal(Scalar.Tan(Scalar.Divide(fieldOfView, Scalar<T>.Two)));
            T xScale = Scalar.Divide(yScale, aspectRatio);

            Matrix4X4<T> result = default;

            result.M11 = xScale;
            result.M12 = result.M13 = result.M14 = Scalar<T>.Zero;

            result.M22 = yScale;
            result.M21 = result.M23 = result.M24 = Scalar<T>.Zero;

            result.M31 = result.M32 = Scalar<T>.Zero;
            T negFarRange = Scalar.IsPositiveInfinity(farPlaneDistance) ? Scalar<T>.MinusOne : Scalar.Divide(farPlaneDistance, Scalar.Subtract(nearPlaneDistance, farPlaneDistance));
            result.M33 = negFarRange;
            result.M34 = Scalar<T>.MinusOne;

            result.M41 = result.M42 = result.M44 = Scalar<T>.Zero;
            result.M43 = Scalar.Multiply(nearPlaneDistance, negFarRange);

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
        public static Matrix4X4<T> CreatePerspectiveOffCenter<T>(T left, T right, T bottom, T top, T nearPlaneDistance, T farPlaneDistance)
            where T : INumberBase<T>
        {
            if (!Scalar.GreaterThan(nearPlaneDistance, Scalar<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!Scalar.GreaterThan(farPlaneDistance, Scalar<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            Matrix4X4<T> result = default;

            result.M11 = Scalar.Divide(Scalar.Multiply(Scalar<T>.Two, nearPlaneDistance), Scalar.Subtract(right, left));
            result.M12 = result.M13 = result.M14 = Scalar<T>.Zero;

            result.M22 = Scalar.Divide(Scalar.Multiply(Scalar<T>.Two, nearPlaneDistance), Scalar.Subtract(top, bottom));
            result.M21 = result.M23 = result.M24 = Scalar<T>.Zero;

            result.M31 = Scalar.Divide(Scalar.Add(left, right), Scalar.Subtract(right, left));
            result.M32 = Scalar.Divide(Scalar.Add(top, bottom), Scalar.Subtract(top, bottom));
            T negFarRange = Scalar.IsPositiveInfinity(farPlaneDistance) ? Scalar<T>.MinusOne : Scalar.Divide(farPlaneDistance, Scalar.Subtract(nearPlaneDistance, farPlaneDistance));
            result.M33 = negFarRange;
            result.M34 = Scalar<T>.MinusOne;

            result.M43 = Scalar.Multiply(nearPlaneDistance, negFarRange);
            result.M41 = result.M42 = result.M44 = Scalar<T>.Zero;

            return result;
        }

        /// <summary>Creates a Matrix that reflects the coordinate system about a specified Plane.</summary>
        /// <param name="value">The Plane about which to create a reflection.</param>
        /// <returns>A new matrix expressing the reflection.</returns>
        public static Matrix4X4<T> CreateReflection<T>(Plane<T> value)
            where T : INumberBase<T>
        {
            value = Plane.Normalize(value);

            T a = value.Normal.X;
            T b = value.Normal.Y;
            T c = value.Normal.Z;

            T fa = Scalar.Multiply(Scalar<T>.MinusTwo, a);
            T fb = Scalar.Multiply(Scalar<T>.MinusTwo, b);
            T fc = Scalar.Multiply(Scalar<T>.MinusTwo, c);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = Scalar.Add(Scalar.Multiply(fa, a), Scalar<T>.One);
            result.M12 = Scalar.Multiply(fb, a);
            result.M13 = Scalar.Multiply(fc, a);

            result.M21 = Scalar.Multiply(fa, b);
            result.M22 = Scalar.Add(Scalar.Multiply(fb, b), Scalar<T>.One);
            result.M23 = Scalar.Multiply(fc, b);

            result.M31 = Scalar.Multiply(fa, c);
            result.M32 = Scalar.Multiply(fb, c);
            result.M33 = Scalar.Add(Scalar.Multiply(fc, c), Scalar<T>.One);

            result.M41 = Scalar.Multiply(fa, value.Distance);
            result.M42 = Scalar.Multiply(fb, value.Distance);
            result.M43 = Scalar.Multiply(fc, value.Distance);

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the X-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationX<T>(T radians)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

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

        /// <summary>Creates a matrix for rotating points around the X-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationX<T>(T radians, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = Scalar.Cos(radians);
            T s = Scalar.Sin(radians);

            T y = Scalar.Add(Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.Z, s));
            T z = Scalar.Subtract(Scalar.Multiply(centerPoint.Z, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.Y, s));

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  y  z  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = Scalar.Negate(s);
            result.M33 = c;
            result.M42 = y;
            result.M43 = z;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationY<T>(T radians)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

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

        /// <summary>Creates a matrix for rotating points around the Y-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationY<T>(T radians, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = Scalar.Cos(radians);
            T s = Scalar.Sin(radians);

            T x = Scalar.Subtract(Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.Z, s));
            T z = Scalar.Add(Scalar.Multiply(centerPoint.Z, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.X, s));

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  x  0  z  1 ]
            result.M11 = c;
            result.M13 = Scalar.Negate(s);
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
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

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

        /// <summary>Creates a matrix for rotating points around the Z-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4X4<T> CreateRotationZ<T>(T radians, Vector3D<T> centerPoint)
            where T : INumberBase<T>
        {
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T c = Scalar.Cos(radians);
            T s = Scalar.Sin(radians);

            T x = Scalar.Add(Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.Y, s));
            T y = Scalar.Subtract(Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.X, s));

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  x  y  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = Scalar.Negate(s);
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
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T tx = Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, xScale));
            T ty = Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, yScale));
            T tz = Scalar.Multiply(centerPoint.Z, Scalar.Subtract(Scalar<T>.One, zScale));

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
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T tx = Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, scales.X));
            T ty = Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, scales.Y));
            T tz = Scalar.Multiply(centerPoint.Z, Scalar.Subtract(Scalar<T>.One, scales.Z));

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
            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            T tx = Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, scale));
            T ty = Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, scale));
            T tz = Scalar.Multiply(centerPoint.Z, Scalar.Subtract(Scalar<T>.One, scale));

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
            where T : INumberBase<T>
        {
            Plane<T> p = Plane.Normalize(plane);

            T dot = Scalar.Add(Scalar.Add(Scalar.Multiply(p.Normal.X, lightDirection.X), Scalar.Multiply(p.Normal.Y, lightDirection.Y)), Scalar.Multiply(p.Normal.Z, lightDirection.Z));
            T a = Scalar.Negate(p.Normal.X);
            T b = Scalar.Negate(p.Normal.Y);
            T c = Scalar.Negate(p.Normal.Z);
            T d = Scalar.Negate(p.Distance);

            Matrix4X4<T> result = Matrix4X4<T>.Identity;

            result.M11 = Scalar.Add(Scalar.Multiply(a, lightDirection.X), dot);
            result.M21 = Scalar.Multiply(b, lightDirection.X);
            result.M31 = Scalar.Multiply(c, lightDirection.X);
            result.M41 = Scalar.Multiply(d, lightDirection.X);

            result.M12 = Scalar.Multiply(a, lightDirection.Y);
            result.M22 = Scalar.Add(Scalar.Multiply(b, lightDirection.Y), dot);
            result.M32 = Scalar.Multiply(c, lightDirection.Y);
            result.M42 = Scalar.Multiply(d, lightDirection.Y);

            result.M13 = Scalar.Multiply(a, lightDirection.Z);
            result.M23 = Scalar.Multiply(b, lightDirection.Z);
            result.M33 = Scalar.Add(Scalar.Multiply(c, lightDirection.Z), dot);
            result.M43 = Scalar.Multiply(d, lightDirection.Z);

            result.M44 = dot;

            return result;
        }

        /// <summary>Creates a translation matrix.</summary>
        /// <param name="position">The amount to translate in each axis.</param>
        /// <returns>The translation matrix.</returns>
        public static Matrix4X4<T> CreateTranslation<T>(Vector3D<T> position)
            where T : INumberBase<T>
        {
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
            Matrix4X4<T> result = Matrix4X4<T>.Identity; ;
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

        /// <summary>Attempts to calculate the inverse of the given matrix. If successful, result will contain the inverted matrix.</summary>
        /// <param name="matrix">The source matrix to invert.</param>
        /// <param name="result">If successful, contains the inverted matrix.</param>
        /// <returns>True if the source matrix could be inverted; False otherwise.</returns>
        ///
        [MethodImpl((MethodImplOptions) 768)]
        public static unsafe bool Invert<T>(Matrix4X4<T> matrix, out Matrix4X4<T> result)
            where T : INumberBase<T>
        {
            // This implementation is based on the DirectX Math Library XMMatrixInverse method
            // https://github.com/microsoft/DirectXMath/blob/master/Inc/DirectXMathMatrix.inl

            /*if (Sse.IsSupported)
            {
                return SseImpl(matrix, out result);
            }*/

            return SoftwareFallback(matrix, out result);

            /*static unsafe bool SseImpl(Matrix4X4 matrix, out Matrix4X4 result)
            {
                if (!Sse.IsSupported)
                {
                    // Redundant test so we won't prejit remainder of this method on platforms without SSE.
                    throw new PlatformNotSupportedException();
                }

                // Load the matrix values into rows
                Vector128<T> row1 = Sse.LoadVector128(&matrix.M11);
                Vector128<T> row2 = Sse.LoadVector128(&matrix.M21);
                Vector128<T> row3 = Sse.LoadVector128(&matrix.M31);
                Vector128<T> row4 = Sse.LoadVector128(&matrix.M41);

                // Transpose the matrix
                Vector128<T> vTemp1 = Sse.Shuffle(row1, row2, 0x44); //_MM_SHUFFLE(1, 0, 1, 0)
                Vector128<T> vTemp3 = Sse.Shuffle(row1, row2, 0xEE); //_MM_SHUFFLE(3, 2, 3, 2)
                Vector128<T> vTemp2 = Sse.Shuffle(row3, row4, 0x44); //_MM_SHUFFLE(1, 0, 1, 0)
                Vector128<T> vTemp4 = Sse.Shuffle(row3, row4, 0xEE); //_MM_SHUFFLE(3, 2, 3, 2)

                row1 = Sse.Shuffle(vTemp1, vTemp2, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)
                row2 = Sse.Shuffle(vTemp1, vTemp2, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)
                row3 = Sse.Shuffle(vTemp3, vTemp4, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)
                row4 = Sse.Shuffle(vTemp3, vTemp4, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)

                Vector128<T> V00 = Permute(row3, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                Vector128<T> V10 = Permute(row4, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                Vector128<T> V01 = Permute(row1, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                Vector128<T> V11 = Permute(row2, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                Vector128<T> V02 = Sse.Shuffle(row3, row1, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)
                Vector128<T> V12 = Sse.Shuffle(row4, row2, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)

                Vector128<T> D0 = Sse.Multiply(V00, V10);
                Vector128<T> D1 = Sse.Multiply(V01, V11);
                Vector128<T> D2 = Sse.Multiply(V02, V12);

                V00 = Permute(row3, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                V10 = Permute(row4, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                V01 = Permute(row1, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                V11 = Permute(row2, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                V02 = Sse.Shuffle(row3, row1, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)
                V12 = Sse.Shuffle(row4, row2, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)

                // Note:  We use this expansion pattern instead of Fused Multiply Add
                // in order to support older hardware
                D0 = Sse.Subtract(D0, Sse.Multiply(V00, V10));
                D1 = Sse.Subtract(D1, Sse.Multiply(V01, V11));
                D2 = Sse.Subtract(D2, Sse.Multiply(V02, V12));

                // V11 = D0Y,D0W,D2Y,D2Y
                V11 = Sse.Shuffle(D0, D2, 0x5D);  //_MM_SHUFFLE(1, 1, 3, 1)
                V00 = Permute(row2, 0x49);        //_MM_SHUFFLE(1, 0, 2, 1)
                V10 = Sse.Shuffle(V11, D0, 0x32); //_MM_SHUFFLE(0, 3, 0, 2)
                V01 = Permute(row1, 0x12);        //_MM_SHUFFLE(0, 1, 0, 2)
                V11 = Sse.Shuffle(V11, D0, 0x99); //_MM_SHUFFLE(2, 1, 2, 1)

                // V13 = D1Y,D1W,D2W,D2W
                Vector128<T> V13 = Sse.Shuffle(D1, D2, 0xFD); //_MM_SHUFFLE(3, 3, 3, 1)
                V02 = Permute(row4, 0x49);                        //_MM_SHUFFLE(1, 0, 2, 1)
                V12 = Sse.Shuffle(V13, D1, 0x32);                 //_MM_SHUFFLE(0, 3, 0, 2)
                Vector128<T> V03 = Permute(row3, 0x12);       //_MM_SHUFFLE(0, 1, 0, 2)
                V13 = Sse.Shuffle(V13, D1, 0x99);                 //_MM_SHUFFLE(2, 1, 2, 1)

                Vector128<T> C0 = Sse.Multiply(V00, V10);
                Vector128<T> C2 = Sse.Multiply(V01, V11);
                Vector128<T> C4 = Sse.Multiply(V02, V12);
                Vector128<T> C6 = Sse.Multiply(V03, V13);

                // V11 = D0X,D0Y,D2X,D2X
                V11 = Sse.Shuffle(D0, D2, 0x4);    //_MM_SHUFFLE(0, 0, 1, 0)
                V00 = Permute(row2, 0x9e);         //_MM_SHUFFLE(2, 1, 3, 2)
                V10 = Sse.Shuffle(D0, V11, 0x93);  //_MM_SHUFFLE(2, 1, 0, 3)
                V01 = Permute(row1, 0x7b);         //_MM_SHUFFLE(1, 3, 2, 3)
                V11 = Sse.Shuffle(D0, V11, 0x26);  //_MM_SHUFFLE(0, 2, 1, 2)

                // V13 = D1X,D1Y,D2Z,D2Z
                V13 = Sse.Shuffle(D1, D2, 0xa4);   //_MM_SHUFFLE(2, 2, 1, 0)
                V02 = Permute(row4, 0x9e);         //_MM_SHUFFLE(2, 1, 3, 2)
                V12 = Sse.Shuffle(D1, V13, 0x93);  //_MM_SHUFFLE(2, 1, 0, 3)
                V03 = Permute(row3, 0x7b);         //_MM_SHUFFLE(1, 3, 2, 3)
                V13 = Sse.Shuffle(D1, V13, 0x26);  //_MM_SHUFFLE(0, 2, 1, 2)

                C0 = Sse.Subtract(C0, Sse.Multiply(V00, V10));
                C2 = Sse.Subtract(C2, Sse.Multiply(V01, V11));
                C4 = Sse.Subtract(C4, Sse.Multiply(V02, V12));
                C6 = Sse.Subtract(C6, Sse.Multiply(V03, V13));

                V00 = Permute(row2, 0x33); //_MM_SHUFFLE(0, 3, 0, 3)

                // V10 = D0Z,D0Z,D2X,D2Y
                V10 = Sse.Shuffle(D0, D2, 0x4A); //_MM_SHUFFLE(1, 0, 2, 2)
                V10 = Permute(V10, 0x2C);        //_MM_SHUFFLE(0, 2, 3, 0)
                V01 = Permute(row1, 0x8D);       //_MM_SHUFFLE(2, 0, 3, 1)

                // V11 = D0X,D0W,D2X,D2Y
                V11 = Sse.Shuffle(D0, D2, 0x4C); //_MM_SHUFFLE(1, 0, 3, 0)
                V11 = Permute(V11, 0x93);        //_MM_SHUFFLE(2, 1, 0, 3)
                V02 = Permute(row4, 0x33);       //_MM_SHUFFLE(0, 3, 0, 3)

                // V12 = D1Z,D1Z,D2Z,D2W
                V12 = Sse.Shuffle(D1, D2, 0xEA); //_MM_SHUFFLE(3, 2, 2, 2)
                V12 = Permute(V12, 0x2C);        //_MM_SHUFFLE(0, 2, 3, 0)
                V03 = Permute(row3, 0x8D);       //_MM_SHUFFLE(2, 0, 3, 1)

                // V13 = D1X,D1W,D2Z,D2W
                V13 = Sse.Shuffle(D1, D2, 0xEC); //_MM_SHUFFLE(3, 2, 3, 0)
                V13 = Permute(V13, 0x93);        //_MM_SHUFFLE(2, 1, 0, 3)

                V00 = Sse.Multiply(V00, V10);
                V01 = Sse.Multiply(V01, V11);
                V02 = Sse.Multiply(V02, V12);
                V03 = Sse.Multiply(V03, V13);

                Vector128<T> C1 = Sse.Subtract(C0, V00);
                C0 = Sse.Add(C0, V00);
                Vector128<T> C3 = Sse.Add(C2, V01);
                C2 = Sse.Subtract(C2, V01);
                Vector128<T> C5 = Sse.Subtract(C4, V02);
                C4 = Sse.Add(C4, V02);
                Vector128<T> C7 = Sse.Add(C6, V03);
                C6 = Sse.Subtract(C6, V03);

                C0 = Sse.Shuffle(C0, C1, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C2 = Sse.Shuffle(C2, C3, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C4 = Sse.Shuffle(C4, C5, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C6 = Sse.Shuffle(C6, C7, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)

                C0 = Permute(C0, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C2 = Permute(C2, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C4 = Permute(C4, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C6 = Permute(C6, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)

                // Get the determinant
                vTemp2 = row1;
                T det = Vector4D.Dot(C0.AsVector4(), vTemp2.AsVector4());

                // Check determinate is not zero
                if (MathF.Abs(det) < T.Epsilon)
                {
                    result = new Matrix4X4(T.NaN, T.NaN, T.NaN, T.NaN,
                                T.NaN, T.NaN, T.NaN, T.NaN,
                                T.NaN, T.NaN, T.NaN, T.NaN,
                                T.NaN, T.NaN, T.NaN, T.NaN);
                    return false;
                }

                // Create Vector128<T> copy of the determinant and invert them.
                Vector128<T> ones = Vector128.Create(1.0f);
                Vector128<T> vTemp = Vector128.Create(det);
                vTemp = Sse.Divide(ones, vTemp);

                row1 = Sse.Multiply(C0, vTemp);
                row2 = Sse.Multiply(C2, vTemp);
                row3 = Sse.Multiply(C4, vTemp);
                row4 = Sse.Multiply(C6, vTemp);

                Unsafe.SkipInit(out result);
                ref Vector128<T> vResult = ref Unsafe.As<Matrix4X4, Vector128<T>>(ref result);

                vResult = row1;
                Unsafe.Add(ref vResult, 1) = row2;
                Unsafe.Add(ref vResult, 2) = row3;
                Unsafe.Add(ref vResult, 3) = row4;

                return true;
            }*/

            static bool SoftwareFallback(Matrix4X4<T> matrix, out Matrix4X4<T> result)
            {
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

                T kp_lo = Scalar.Subtract(Scalar.Multiply(k, p), Scalar.Multiply(l, o));
                T jp_ln = Scalar.Subtract(Scalar.Multiply(j, p), Scalar.Multiply(l, n));
                T jo_kn = Scalar.Subtract(Scalar.Multiply(j, o), Scalar.Multiply(k, n));
                T ip_lm = Scalar.Subtract(Scalar.Multiply(i, p), Scalar.Multiply(l, m));
                T io_km = Scalar.Subtract(Scalar.Multiply(i, o), Scalar.Multiply(k, m));
                T in_jm = Scalar.Subtract(Scalar.Multiply(i, n), Scalar.Multiply(j, m));

                T a11 = Scalar.Add(Scalar.Subtract(Scalar.Multiply(f, kp_lo), Scalar.Multiply(g, jp_ln)), Scalar.Multiply(h, jo_kn));
                T a12 = Scalar.Negate(Scalar.Add(Scalar.Subtract(Scalar.Multiply(e, kp_lo), Scalar.Multiply(g, ip_lm)), Scalar.Multiply(h, io_km)));
                T a13 = Scalar.Add(Scalar.Subtract(Scalar.Multiply(e, jp_ln), Scalar.Multiply(f, ip_lm)), Scalar.Multiply(h, in_jm));
                T a14 = Scalar.Negate(Scalar.Add(Scalar.Subtract(Scalar.Multiply(e, jo_kn), Scalar.Multiply(f, io_km)), Scalar.Multiply(g, in_jm)));

                T det = Scalar.Add(Scalar.Add(Scalar.Add(Scalar.Multiply(a, a11), Scalar.Multiply(b, a12)), Scalar.Multiply(c, a13)), Scalar.Multiply(d, a14));

                if (!Scalar.GreaterThanOrEqual(T.Abs(det), Scalar<T>.Epsilon))
                {
                    result = new Matrix4X4<T>(Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN,
                                           Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN,
                                           Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN,
                                           Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN);
                    return false;
                }

                T invDet = Scalar.Reciprocal(det);

                // TODO: Vectorize
                result = default;

                result.M11 = Scalar.Multiply(a11, invDet);
                result.M21 = Scalar.Multiply(a12, invDet);
                result.M31 = Scalar.Multiply(a13, invDet);
                result.M41 = Scalar.Multiply(a14, invDet);

                result.M12 = Scalar.Negate(Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(b, kp_lo), Scalar.Multiply(c, jp_ln)), Scalar.Multiply(d, jo_kn)), invDet));
                result.M22 = Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, kp_lo), Scalar.Multiply(c, ip_lm)), Scalar.Multiply(d, io_km)), invDet);
                result.M32 = Scalar.Negate(Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, jp_ln), Scalar.Multiply(b, ip_lm)), Scalar.Multiply(d, in_jm)), invDet));
                result.M42 = Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, jo_kn), Scalar.Multiply(b, io_km)), Scalar.Multiply(c, in_jm)), invDet);

                T gp_ho = Scalar.Subtract(Scalar.Multiply(g, p), Scalar.Multiply(h, o));
                T fp_hn = Scalar.Subtract(Scalar.Multiply(f, p), Scalar.Multiply(h, n));
                T fo_gn = Scalar.Subtract(Scalar.Multiply(f, o), Scalar.Multiply(g, n));
                T ep_hm = Scalar.Subtract(Scalar.Multiply(e, p), Scalar.Multiply(h, m));
                T eo_gm = Scalar.Subtract(Scalar.Multiply(e, o), Scalar.Multiply(g, m));
                T en_fm = Scalar.Subtract(Scalar.Multiply(e, n), Scalar.Multiply(f, m));

                result.M13 = Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(b, gp_ho), Scalar.Multiply(c, fp_hn)), Scalar.Multiply(d, fo_gn)), invDet);
                result.M23 = Scalar.Negate(Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, gp_ho), Scalar.Multiply(c, ep_hm)), Scalar.Multiply(d, eo_gm)), invDet));
                result.M33 = Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, fp_hn), Scalar.Multiply(b, ep_hm)), Scalar.Multiply(d, en_fm)), invDet);
                result.M43 = Scalar.Negate(Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, fo_gn), Scalar.Multiply(b, eo_gm)), Scalar.Multiply(c, en_fm)), invDet));

                T gl_hk = Scalar.Subtract(Scalar.Multiply(g, l), Scalar.Multiply(h, k));
                T fl_hj = Scalar.Subtract(Scalar.Multiply(f, l), Scalar.Multiply(h, j));
                T fk_gj = Scalar.Subtract(Scalar.Multiply(f, k), Scalar.Multiply(g, j));
                T el_hi = Scalar.Subtract(Scalar.Multiply(e, l), Scalar.Multiply(h, i));
                T ek_gi = Scalar.Subtract(Scalar.Multiply(e, k), Scalar.Multiply(g, i));
                T ej_fi = Scalar.Subtract(Scalar.Multiply(e, j), Scalar.Multiply(f, i));

                result.M14 = Scalar.Negate(Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(b, gl_hk), Scalar.Multiply(c, fl_hj)), Scalar.Multiply(d, fk_gj)), invDet));
                result.M24 = Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, gl_hk), Scalar.Multiply(c, el_hi)), Scalar.Multiply(d, ek_gi)), invDet);
                result.M34 = Scalar.Negate(Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, fl_hj), Scalar.Multiply(b, el_hi)), Scalar.Multiply(d, ej_fi)), invDet));
                result.M44 = Scalar.Multiply(Scalar.Add(Scalar.Subtract(Scalar.Multiply(a, fk_gj), Scalar.Multiply(b, ek_gi)), Scalar.Multiply(c, ej_fi)), invDet);

                return true;
            }
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

        /*
        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <param name="translation">The translation component of the transformation matrix</param>
        /// <returns>True if the source matrix was successfully decomposed; False otherwise.</returns>
        public static bool Decompose<T>(Matrix4X4<T> matrix, out Vector3D<T> scale, out Silk.NET.Maths.Legacy.Quaternion<T> rotation, out Vector3D<T> translation)
            where T : INumberBase<T>
        {
            bool result = true;

            unsafe
            {
                fixed (Vector3D<T>* scaleBase = &scale)
                {
                    T* pfScales = (T*) scaleBase;
                    T det;

                    VectorBasis<T> vectorBasis;
                    Vector3D<T>** pVectorBasis = (Vector3D<T>**) &vectorBasis;

                    Matrix4X4<T> matTemp = Matrix4X4<T>.Identity;
                    CanonicalBasis<T> canonicalBasis = default;
                    Vector3D<T>* pCanonicalBasis = &canonicalBasis.Row0;

                    canonicalBasis.Row0 = new Vector3D<T>(Scalar<T>.One, Scalar<T>.Zero, Scalar<T>.Zero);
                    canonicalBasis.Row1 = new Vector3D<T>(Scalar<T>.Zero, Scalar<T>.One, Scalar<T>.Zero);
                    canonicalBasis.Row2 = new Vector3D<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);

                    translation = new Vector3D<T>(
                        matrix.M41,
                        matrix.M42,
                        matrix.M43);

                    pVectorBasis[0] = (Vector3D<T>*) &matTemp.Row1;
                    pVectorBasis[1] = (Vector3D<T>*) &matTemp.Row2;
                    pVectorBasis[2] = (Vector3D<T>*) &matTemp.Row3;

                    *(pVectorBasis[0]) = new Vector3D<T>(matrix.M11, matrix.M12, matrix.M13);
                    *(pVectorBasis[1]) = new Vector3D<T>(matrix.M21, matrix.M22, matrix.M23);
                    *(pVectorBasis[2]) = new Vector3D<T>(matrix.M31, matrix.M32, matrix.M33);

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

                    *pVectorBasis[a] = Vector3D.Normalize(*pVectorBasis[a]);

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

                        *pVectorBasis[b] = Vector3D.Cross(*pVectorBasis[a], *(pCanonicalBasis + cc));
                    }

                    *pVectorBasis[b] = Vector3D.Normalize(*pVectorBasis[b]);

                    if (!Scalar.GreaterThanOrEqual(pfScales[c], Scalar.As<float, T>(DecomposeEpsilon)))
                    {
                        *pVectorBasis[c] = Vector3D.Cross(*pVectorBasis[a], *pVectorBasis[b]);
                    }

                    *pVectorBasis[c] = Vector3D.Normalize(*pVectorBasis[c]);

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
                        rotation = Legacy.Quaternion<T>.Identity;
                        result = false;
                    }
                    else
                    {
                        // generate the quaternion from the matrix
                        rotation = Legacy.Quaternion<T>.CreateFromRotationMatrix(matTemp);
                    }
                }
            }

            return result;
        }
        */

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix4X4<T> Transform<T>(Matrix4X4<T> value, Quaternion<T> rotation)
            where T : ITrigonometricFunctions<T>
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
        public static unsafe Matrix4X4<T> Transpose<T>(Matrix4X4<T> matrix)
            where T : INumberBase<T>
        {
            return new(matrix.Column1, matrix.Column2, matrix.Column3, matrix.Column4);
        }
    }
}
