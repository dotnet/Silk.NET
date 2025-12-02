// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureMagFilter")]
public enum TextureMagFilter : uint
{
    [NativeName("GL_NEAREST")]
    Nearest = unchecked((uint)0x2600),

    [NativeName("GL_LINEAR")]
    Linear = unchecked((uint)0x2601),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_DETAIL_SGIS")]
    LinearDetailSGIS = unchecked((uint)0x8097),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_DETAIL_ALPHA_SGIS")]
    LinearDetailAlphaSGIS = unchecked((uint)0x8098),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_DETAIL_COLOR_SGIS")]
    LinearDetailColorSGIS = unchecked((uint)0x8099),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_SHARPEN_SGIS")]
    LinearSharpenSGIS = unchecked((uint)0x80AD),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_SHARPEN_ALPHA_SGIS")]
    LinearSharpenAlphaSGIS = unchecked((uint)0x80AE),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_LINEAR_SHARPEN_COLOR_SGIS")]
    LinearSharpenColorSGIS = unchecked((uint)0x80AF),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_FILTER4_SGIS")]
    Filter4SGIS = unchecked((uint)0x8146),
}
