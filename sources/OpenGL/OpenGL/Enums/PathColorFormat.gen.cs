// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathColorFormat")]
public enum PathColorFormat : uint
{
    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),

    [NativeName("GL_RGB")]
    Rgb = unchecked((uint)0x1907),

    [NativeName("GL_RGBA")]
    Rgba = unchecked((uint)0x1908),

    [NativeName("GL_LUMINANCE")]
    Luminance = unchecked((uint)0x1909),

    [NativeName("GL_LUMINANCE_ALPHA")]
    LuminanceAlpha = unchecked((uint)0x190A),

    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_INTENSITY")]
    Intensity = unchecked((uint)0x8049),
}
