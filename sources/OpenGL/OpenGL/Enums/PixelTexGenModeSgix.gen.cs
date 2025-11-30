// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIX", 0)]
[NativeName("PixelTexGenModeSGIX")]
[Transformed]
public enum PixelTexGenModeSgix : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),

    [NativeName("GL_RGB")]
    Rgb = unchecked((uint)0x1907),

    [NativeName("GL_RGBA")]
    Rgba = unchecked((uint)0x1908),
}
