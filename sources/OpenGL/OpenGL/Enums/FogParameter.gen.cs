// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FogParameter")]
public enum FogParameter : uint
{
    [NativeName("GL_FOG_INDEX")]
    Index = 2913,

    [NativeName("GL_FOG_DENSITY")]
    Density = 2914,

    [NativeName("GL_FOG_START")]
    Start = 2915,

    [NativeName("GL_FOG_END")]
    End = 2916,

    [NativeName("GL_FOG_MODE")]
    Mode = 2917,

    [NativeName("GL_FOG_COLOR")]
    Color = 2918,

    [NativeName("GL_FOG_OFFSET_VALUE_SGIX")]
    OffsetValueSGIX = 33177,
}
