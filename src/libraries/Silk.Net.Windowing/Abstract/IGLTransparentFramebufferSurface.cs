// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents a GL Surface with a transparent Framebuffer
    /// </summary>
    // Is GLFW making this an optional feature worth adding this? -Donovan/Redhacker1
    public interface IGLTransparentFramebuffer : INativeGLSurface
    {
        /// <summary>
        /// Whether the buffer can be actually transparent
        /// </summary>
        bool TransparentFramebuffer { get; set; }
    }
}
