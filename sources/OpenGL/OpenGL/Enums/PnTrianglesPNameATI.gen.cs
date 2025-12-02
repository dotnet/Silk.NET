// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("PNTrianglesPNameATI")]
public enum PnTrianglesPNameATI : uint
{
    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_PN_TRIANGLES_POINT_MODE_ATI")]
    PointMode = 34802,

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
    NormalMode = 34803,

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
    TesselationLevel = 34804,
}
