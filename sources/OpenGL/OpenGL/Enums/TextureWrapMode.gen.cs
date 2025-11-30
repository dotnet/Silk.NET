// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureWrapMode")]
[Transformed]
public enum TextureWrapMode : uint
{
    [NativeName("GL_LINEAR_MIPMAP_LINEAR")]
    LinearMipmapLinear = unchecked((uint)0x2703),

    [NativeName("GL_REPEAT")]
    Repeat = unchecked((uint)0x2901),

    [NativeName("GL_CLAMP_TO_EDGE")]
    ClampToEdge = unchecked((uint)0x812F),

    [NativeName("GL_CLAMP")]
    Clamp = unchecked((uint)0x2900),

    [NativeName("GL_CLAMP_TO_BORDER")]
    ClampToBorder = unchecked((uint)0x812D),

    [NativeName("GL_MIRRORED_REPEAT")]
    MirroredRepeat = unchecked((uint)0x8370),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_ARB")]
    ClampToBorderARB = unchecked((uint)0x812D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_SGIS")]
    ClampToBorderSGIS = unchecked((uint)0x812D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_CLAMP_TO_EDGE_SGIS")]
    ClampToEdgeSGIS = unchecked((uint)0x812F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CLAMP_TO_BORDER_NV")]
    ClampToBorderNV = unchecked((uint)0x812D),
}
