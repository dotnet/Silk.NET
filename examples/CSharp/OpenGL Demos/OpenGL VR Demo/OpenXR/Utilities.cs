// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.OpenXR;

namespace OpenGL_VR_Demo.OpenXR
{
    public static class Utilities
    {
        public const float DefaultNearZ = 0.01f;
        public const float DefaultFarZ = 100.0f;
        public const float DefaultOffset = 0f;

        public static Matrix4x4 ToView(this Posef pose, Vector3 offset = default)
            => Matrix4x4.Identity
               * Matrix4x4.CreateTranslation(Unsafe.As<Vector3f, Vector3>(ref pose.Position) + offset)
               * Matrix4x4.CreateFromQuaternion(Unsafe.As<Quaternionf, Quaternion>(ref pose.Orientation));

        public static Matrix4x4
            ToProjection
            (
                this Fovf fov,
                bool isGlSpace = true,
                float nearZ = DefaultNearZ,
                float farZ = DefaultFarZ
            )
        {
            Matrix4x4 result = default;

            var tanAngleLeft = MathF.Tan(fov.AngleLeft);
            var tanAngleRight = MathF.Tan(fov.AngleRight);

            var tanAngleDown = MathF.Tan(fov.AngleDown);
            var tanAngleUp = MathF.Tan(fov.AngleUp);

            var tanAngleWidth = tanAngleRight - tanAngleLeft;
            var angleWidth = fov.AngleRight - fov.AngleLeft;
            var angleHeight = !isGlSpace ? fov.AngleDown - fov.AngleUp : fov.AngleUp - fov.AngleDown;

            // Set to tanAngleDown - tanAngleUp for a clip space with positive Y
            // down (Vulkan). Set to tanAngleUp - tanAngleDown for a clip space with
            // positive Y up (OpenGL / D3D / Metal).
            var tanAngleHeight = !isGlSpace ? tanAngleDown - tanAngleUp : tanAngleUp - tanAngleDown;

            // Set to nearZ for a [-1,1] Z clip space (OpenGL / OpenGL ES).
            // Set to zero for a [0,1] Z clip space (Vulkan / D3D / Metal).
            var offsetZ = isGlSpace ? nearZ : 0;

            if (farZ <= nearZ)
            {
                // place the far plane at infinity
                result.M11 = 2 / tanAngleWidth;
                result.M21 = 0;
                result.M31 = (tanAngleRight + tanAngleLeft) / tanAngleWidth;
                result.M41 = 0;

                result.M12 = 0;
                result.M22 = 2 / tanAngleHeight;
                result.M32 = (tanAngleUp + tanAngleDown) / tanAngleHeight;
                result.M42 = 0;

                result.M13 = 0;
                result.M23 = 0;
                result.M33 = -1;
                result.M43 = -(nearZ + offsetZ);

                result.M14 = 0;
                result.M24 = 0;
                result.M34 = -1;
                result.M44 = 0;
            }
            else
            {
                // normal projection
                result.M11 = 2 / tanAngleWidth;
                result.M21 = 0;
                result.M31 = (tanAngleRight + tanAngleLeft) / tanAngleWidth;
                result.M41 = 0;

                result.M12 = 0;
                result.M22 = 2 / tanAngleHeight;
                result.M32 = (tanAngleUp + tanAngleDown) / tanAngleHeight;
                result.M42 = 0;

                result.M13 = 0;
                result.M23 = 0;
                result.M33 = -(farZ + offsetZ) / (farZ - nearZ);
                result.M43 = -(farZ * (nearZ + offsetZ)) / (farZ - nearZ);

                result.M14 = 0;
                result.M24 = 0;
                result.M34 = -1;
                result.M44 = 0;
            }

            return Matrix4x4.Transpose(result);
        }
    }
}
