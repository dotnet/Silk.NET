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

        public static Vector4 FovfToTanFovVector(this Fovf fovf) => new
        (
            MathF.Tan(fovf.AngleLeft),
            MathF.Tan(fovf.AngleRight),
            MathF.Tan(fovf.AngleUp),
            MathF.Tan(fovf.AngleDown)
        );

        public static Matrix4x4 FovfToMatrix
        (
            this Fovf fovf,
            float nearZ = DefaultNearZ,
            float farZ = DefaultFarZ,
            float offsetZ = DefaultOffset
        )
        {
            var tanFov = fovf.FovfToTanFovVector();
            var tanAngleWidth = tanFov.Y - tanFov.X;
            var tanAngleHeight = tanFov.W - tanFov.Z;
            return new
            (
                2 / tanAngleWidth, 0, (tanFov.Y + tanFov.X) / tanAngleWidth, 0,
                0, 2 / tanAngleHeight, (tanFov.Z + tanFov.W) / tanAngleHeight, 0,
                0, 0, -(farZ + offsetZ) / (farZ - nearZ), -(farZ * (nearZ + offsetZ)) / (farZ - nearZ),
                0, 0, -1, 0
            );
        }

        public static Quaternion QuaternionfToQuaternion(this Quaternionf quat)
            => Unsafe.As<Quaternionf, Quaternion>(ref quat);

        public static Vector3 Vector3fToVector3(this Vector3f vec)
            => Unsafe.As<Vector3f, Vector3>(ref vec);

        public static Matrix4x4 PosefToMatrix(this Posef pose)
            => Matrix4x4.Identity
               * Matrix4x4.CreateTranslation(pose.Position.Vector3fToVector3())
               * Matrix4x4.CreateFromQuaternion(pose.Orientation.QuaternionfToQuaternion());
    }
}
