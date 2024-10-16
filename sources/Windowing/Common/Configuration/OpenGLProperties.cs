// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing;

/// <summary>
/// OpenGL initial configuration.
/// </summary>
public struct OpenGLProperties : IGLConfiguration
{
    /// <inheritdoc />
    public int? PreferredDepthBufferBits { get; set; }

    /// <inheritdoc />
    public int? PreferredStencilBufferBits { get; set; }

    /// <inheritdoc />
    public Vector4D<int>? PreferredBitDepth { get; set; }

    /// <inheritdoc />
    public Version32? Version { get; set; }

    /// <inheritdoc />
    public OpenGLContextFlags Flags { get; set; }

    /// <inheritdoc />
    public OpenGLContextProfile Profile { get; set; }
}
