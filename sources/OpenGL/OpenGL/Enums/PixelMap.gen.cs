// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelMap")]
public enum PixelMap : uint
{
    [NativeName("GL_PIXEL_MAP_I_TO_I")]
    IToI = 3184,

    [NativeName("GL_PIXEL_MAP_S_TO_S")]
    SToS = 3185,

    [NativeName("GL_PIXEL_MAP_I_TO_R")]
    IToR = 3186,

    [NativeName("GL_PIXEL_MAP_I_TO_G")]
    IToG = 3187,

    [NativeName("GL_PIXEL_MAP_I_TO_B")]
    IToB = 3188,

    [NativeName("GL_PIXEL_MAP_I_TO_A")]
    IToA = 3189,

    [NativeName("GL_PIXEL_MAP_R_TO_R")]
    RToR = 3190,

    [NativeName("GL_PIXEL_MAP_G_TO_G")]
    GToG = 3191,

    [NativeName("GL_PIXEL_MAP_B_TO_B")]
    BToB = 3192,

    [NativeName("GL_PIXEL_MAP_A_TO_A")]
    AToA = 3193,
}
