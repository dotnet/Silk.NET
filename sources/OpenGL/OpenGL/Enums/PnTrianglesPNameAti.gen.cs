// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("PNTrianglesPNameATI")]
[Transformed]
public enum PnTrianglesPNameAti : uint
{
    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_POINT_MODE_ATI")]
    PointModeati = unchecked((uint)0x87F2),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
    NormalModeati = unchecked((uint)0x87F3),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    TesselationLevelati = unchecked((uint)0x87F4),
}
