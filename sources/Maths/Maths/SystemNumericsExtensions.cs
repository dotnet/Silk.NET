// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Maths
{
    /// <summary>
    /// A collection of extension methods to convert the float versions of the generic types into System.Numerics types.
    /// </summary>
    public static class SystemNumericsExtensions
    {
        /// <summary>
        /// Converts a <see cref="Matrix3X2{T}"/> into a <see cref="System.Numerics.Matrix3x2"/>
        /// </summary>
        /// <param name="value">The source matrix</param>
        /// <returns>The converted matrix</returns>
        public static System.Numerics.Matrix3x2 ToSystem(this Matrix3X2<float> value)
            => new(value.M11, value.M12, value.M21, value.M22, value.M31, value.M32);

        /// <summary>
        /// Converts a <see cref="Matrix4X4{T}"/> into a <see cref="System.Numerics.Matrix4x4"/>
        /// </summary>
        /// <param name="value">The source matrix</param>
        /// <returns>The converted matrix</returns>
        public static System.Numerics.Matrix4x4 ToSystem(this Matrix4X4<float> value)
            => new(
                value.M11, value.M12, value.M13, value.M14,
                value.M21, value.M22, value.M23, value.M24,
                value.M31, value.M32, value.M33, value.M34,
                value.M41, value.M42, value.M43, value.M44
            );

        /// <summary>
        /// Converts a <see cref="Plane{T}"/> into a <see cref="System.Numerics.Plane"/>
        /// </summary>
        /// <param name="value">The source plane</param>
        /// <returns>The converted plane</returns>
        public static System.Numerics.Plane ToSystem(this Plane<float> value)
            => new(value.Normal.ToSystem(), value.Distance);

        /// <summary>
        /// Converts a <see cref="Quaternion{T}"/> into a <see cref="System.Numerics.Quaternion"/>
        /// </summary>
        /// <param name="value">The source quaternion</param>
        /// <returns>The converted quaternion</returns>
        public static System.Numerics.Quaternion ToSystem(this Quaternion<float> value)
            => new(value.X, value.Y, value.Z, value.W);

        /// <summary>
        /// Converts a <see cref="Vector2D{T}"/> into a <see cref="System.Numerics.Vector2"/>
        /// </summary>
        /// <param name="value">The source vector</param>
        /// <returns>The converted vector</returns>
        public static System.Numerics.Vector2 ToSystem(this Vector2D<float> value)
            => new(value.X, value.Y);

        /// <summary>
        /// Converts a <see cref="Vector3D{T}"/> into a <see cref="System.Numerics.Vector3"/>
        /// </summary>
        /// <param name="value">The source vector</param>
        /// <returns>The converted vector</returns>
        public static System.Numerics.Vector3 ToSystem(this Vector3D<float> value)
            => new(value.X, value.Y, value.Z);

        /// <summary>
        /// Converts a <see cref="Vector4D"/> into a <see cref="System.Numerics.Vector4"/>
        /// </summary>
        /// <param name="value">The source vector</param>
        /// <returns>The converted vector</returns>
        public static System.Numerics.Vector4 ToSystem(this Vector4D<float> value)
            => new(value.X, value.Y, value.Z, value.W);

        /// <summary>
        /// Converts a <see cref="System.Numerics.Matrix3x2"/> into a <see cref="Matrix3X2{T}"/>
        /// </summary>
        /// <param name="value">The source matrix</param>
        /// <returns>The converted matrix</returns>
        public static Matrix3X2<float> ToGeneric(this System.Numerics.Matrix3x2 value)
            => new(value.M11, value.M12, value.M21, value.M22, value.M31, value.M32);

        /// <summary>
        /// Converts a <see cref="System.Numerics.Matrix4x4"/> into a <see cref="Matrix4X4{T}"/>
        /// </summary>
        /// <param name="value">The source matrix</param>
        /// <returns>The converted matrix</returns>
        public static Matrix4X4<float> ToGeneric(this System.Numerics.Matrix4x4 value)
            => new(
                value.M11, value.M12, value.M13, value.M14,
                value.M21, value.M22, value.M23, value.M24,
                value.M31, value.M32, value.M33, value.M34,
                value.M41, value.M42, value.M43, value.M44
            );

        /// <summary>
        /// Converts a <see cref="System.Numerics.Plane"/> into a <see cref="Plane{T}"/>
        /// </summary>
        /// <param name="value">The source plane</param>
        /// <returns>The converted plane</returns>
        public static Plane<float> ToGeneric(this System.Numerics.Plane value)
            => new(value.Normal.ToGeneric(), value.D);

        /// <summary>
        /// Converts a <see cref="System.Numerics.Quaternion"/> into a <see cref="Quaternion{T}"/>
        /// </summary>
        /// <param name="value">The source quaternion</param>
        /// <returns>The converted quaternion</returns>
        public static Quaternion<float> ToGeneric(this System.Numerics.Quaternion value)
            => new(value.X, value.Y, value.Z, value.W);

        /// <summary>
        /// Converts a <see cref="System.Numerics.Vector2"/> into a <see cref="Vector2D{T}"/>
        /// </summary>
        /// <param name="value">The source vector</param>
        /// <returns>The converted vector</returns>
        public static Vector2D<float> ToGeneric(this System.Numerics.Vector2 value)
            => new(value.X, value.Y);

        /// <summary>
        /// Converts a <see cref="System.Numerics.Vector3"/> into a <see cref="Vector3D{T}"/>
        /// </summary>
        /// <param name="value">The source vector</param>
        /// <returns>The converted vector</returns>
        public static Vector3D<float> ToGeneric(this System.Numerics.Vector3 value)
            => new(value.X, value.Y, value.Z);

        /// <summary>
        /// Converts a <see cref="System.Numerics.Vector4"/> into a <see cref="Vector4D"/>
        /// </summary>
        /// <param name="value">The source vector</param>
        /// <returns>The converted vector</returns>
        public static Vector4D<float> ToGeneric(this System.Numerics.Vector4 value)
            => new(value.X, value.Y, value.Z, value.W);
    }
}
