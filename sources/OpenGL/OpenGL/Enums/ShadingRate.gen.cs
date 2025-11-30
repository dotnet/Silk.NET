// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShadingRate")]
[Transformed]
public enum ShadingRate : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_1X1_PIXELS_EXT")]
    Rate1X1Pixelsext = unchecked((uint)0x96A6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_1X2_PIXELS_EXT")]
    Rate1X2Pixelsext = unchecked((uint)0x96A7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_2X1_PIXELS_EXT")]
    Rate2X1Pixelsext = unchecked((uint)0x96A8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_2X2_PIXELS_EXT")]
    Rate2X2Pixelsext = unchecked((uint)0x96A9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_1X4_PIXELS_EXT")]
    Rate1X4Pixelsext = unchecked((uint)0x96AA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_4X1_PIXELS_EXT")]
    Rate4X1Pixelsext = unchecked((uint)0x96AB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_4X2_PIXELS_EXT")]
    Rate4X2Pixelsext = unchecked((uint)0x96AC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_2X4_PIXELS_EXT")]
    Rate2X4Pixelsext = unchecked((uint)0x96AD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADING_RATE_4X4_PIXELS_EXT")]
    Rate4X4Pixelsext = unchecked((uint)0x96AE),
}
