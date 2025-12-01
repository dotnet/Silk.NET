// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShadingRate")]
public enum ShadingRate : uint
{
    [NativeName("GL_SHADING_RATE_1X1_PIXELS_EXT")]
    Rate1X1PixelsEXT = unchecked((uint)0x96A6),

    [NativeName("GL_SHADING_RATE_1X2_PIXELS_EXT")]
    Rate1X2PixelsEXT = unchecked((uint)0x96A7),

    [NativeName("GL_SHADING_RATE_2X1_PIXELS_EXT")]
    Rate2X1PixelsEXT = unchecked((uint)0x96A8),

    [NativeName("GL_SHADING_RATE_2X2_PIXELS_EXT")]
    Rate2X2PixelsEXT = unchecked((uint)0x96A9),

    [NativeName("GL_SHADING_RATE_1X4_PIXELS_EXT")]
    Rate1X4PixelsEXT = unchecked((uint)0x96AA),

    [NativeName("GL_SHADING_RATE_4X1_PIXELS_EXT")]
    Rate4X1PixelsEXT = unchecked((uint)0x96AB),

    [NativeName("GL_SHADING_RATE_4X2_PIXELS_EXT")]
    Rate4X2PixelsEXT = unchecked((uint)0x96AC),

    [NativeName("GL_SHADING_RATE_2X4_PIXELS_EXT")]
    Rate2X4PixelsEXT = unchecked((uint)0x96AD),

    [NativeName("GL_SHADING_RATE_4X4_PIXELS_EXT")]
    Rate4X4PixelsEXT = unchecked((uint)0x96AE),
}
