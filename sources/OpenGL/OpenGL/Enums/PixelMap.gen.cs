// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelMap")]
[Transformed]
public enum PixelMap : uint
{
    [NativeName("GL_PIXEL_MAP_I_TO_I")]
    IToI = unchecked((uint)0x0C70),

    [NativeName("GL_PIXEL_MAP_S_TO_S")]
    SToS = unchecked((uint)0x0C71),

    [NativeName("GL_PIXEL_MAP_I_TO_R")]
    IToR = unchecked((uint)0x0C72),

    [NativeName("GL_PIXEL_MAP_I_TO_G")]
    IToG = unchecked((uint)0x0C73),

    [NativeName("GL_PIXEL_MAP_I_TO_B")]
    IToB = unchecked((uint)0x0C74),

    [NativeName("GL_PIXEL_MAP_I_TO_A")]
    IToA = unchecked((uint)0x0C75),

    [NativeName("GL_PIXEL_MAP_R_TO_R")]
    RToR = unchecked((uint)0x0C76),

    [NativeName("GL_PIXEL_MAP_G_TO_G")]
    GToG = unchecked((uint)0x0C77),

    [NativeName("GL_PIXEL_MAP_B_TO_B")]
    BToB = unchecked((uint)0x0C78),

    [NativeName("GL_PIXEL_MAP_A_TO_A")]
    AToA = unchecked((uint)0x0C79),
}
