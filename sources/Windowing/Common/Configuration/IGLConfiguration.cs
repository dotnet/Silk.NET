// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing;

/// <summary>
/// OpenGL configuration abstraction.
/// </summary>
public interface IGLConfiguration
{
    /// <summary>
    /// Preferred depth buffer bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> to use the system default.
    /// </remarks>
    int? PreferredDepthBufferBits { get; }

    /// <summary>
    /// Preferred stencil buffer bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> to use the system default.
    /// </remarks>
    int? PreferredStencilBufferBits { get; }

    /// <summary>
    /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> for any of the channels to use the system default.
    /// </remarks>
    Vector4D<int>? PreferredBitDepth { get; }

    /// <summary>
    /// The API version to use.
    /// </summary>
    Version32? Version { get; set; }

    /// <summary>
    /// Flags used to create the OpenGL context.
    /// </summary>
    OpenGLContextFlags Flags { get; set; }

    /// <summary>
    /// The profile the OpenGL context should use.
    /// </summary>
    OpenGLContextProfile Profile { get; set; }
}
