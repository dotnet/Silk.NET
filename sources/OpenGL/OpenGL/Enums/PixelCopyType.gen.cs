// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelCopyType")]
public enum PixelCopyType : uint
{
    [NativeName("GL_COLOR_EXT")]
    ColorEXT = unchecked((uint)0x1800),

    [NativeName("GL_DEPTH_EXT")]
    DepthEXT = unchecked((uint)0x1801),

    [NativeName("GL_STENCIL_EXT")]
    StencilEXT = unchecked((uint)0x1802),

    [NativeName("GL_COLOR")]
    Color = unchecked((uint)0x1800),

    [NativeName("GL_DEPTH")]
    Depth = unchecked((uint)0x1801),

    [NativeName("GL_STENCIL")]
    Stencil = unchecked((uint)0x1802),
}
