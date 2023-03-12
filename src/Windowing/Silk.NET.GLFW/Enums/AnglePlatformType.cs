// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Values for the Initialization Hint AnglePlatformType used in <see cref="InitHint" />
    /// which sets the rendering backend when using ANGLE.
    /// </summary>
    public enum AnglePlatformType
    {
        /// <summary>
        /// No Rendering Backend.
        /// </summary>
        None = 0x00037001,

        /// <summary>
        /// Use OpenGL ANGLE Platform Type.
        /// </summary>
        OpenGL = 0x00037002,

        /// <summary>
        /// Use OpenGLES ANGLE Platform Type.
        /// </summary>
        OpenGLES = 0x00037003,

        /// <summary>
        /// Use Direct3D 9 ANGLE Platform Type.
        /// </summary>
        D3D9 = 0x00037004,

        /// <summary>
        /// Use Direct3D 11 ANGLE Platform Type.
        /// </summary>
        D3D11 = 0x00037005,

        /// <summary>
        /// Use Vulkan ANGLE Platform Type.
        /// </summary>
        Vulkan = 0x00037007,

        /// <summary>
        /// Use Metal (Apple Devices like Mac/iOS, etc) ANGLE Platform Type.
        /// </summary>
        Metal = 0x00037008
    }
}
