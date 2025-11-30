// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FogParameter")]
[Transformed]
public enum FogParameter : uint
{
    [NativeName("GL_FOG_DENSITY")]
    Density = unchecked((uint)0x0B62),

    [NativeName("GL_FOG_START")]
    Start = unchecked((uint)0x0B63),

    [NativeName("GL_FOG_END")]
    End = unchecked((uint)0x0B64),

    [NativeName("GL_FOG_MODE")]
    Mode = unchecked((uint)0x0B65),

    [NativeName("GL_FOG_COLOR")]
    Color = unchecked((uint)0x0B66),

    [NativeName("GL_FOG_INDEX")]
    Index = unchecked((uint)0x0B61),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_FOG_OFFSET_VALUE_SGIX")]
    OffsetValueSGIX = unchecked((uint)0x8199),
}
