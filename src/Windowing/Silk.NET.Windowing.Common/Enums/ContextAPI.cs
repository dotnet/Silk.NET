// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents which API the graphics context should use.
    /// </summary>
    public enum ContextAPI
    {
        /// <summary>
        /// Don't use any API. This is necessary for linking an external API, such as Vulkan, to the window.
        /// </summary>
        None = 0,

        /// <summary>
        /// Use Vulkan. Silk.NET doesn't support this yet.
        /// </summary>
        Vulkan,

        /// <summary>
        /// Use core OpenGL. This is standard for software intended for desktop computers.
        /// </summary>
        OpenGL,

        /// <summary>
        /// Use OpenGL ES. This is standard for software intended to be compatible with embedded systems, such as phones.
        /// </summary>
        OpenGLES
    }
}