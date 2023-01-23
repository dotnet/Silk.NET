// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PNTrianglesPNameATI")]
    public enum PNTrianglesPNameATI : int
    {
        [Obsolete("Deprecated in favour of \"PointModeAti\"")]
        [NativeName("Name", "GL_PN_TRIANGLES_POINT_MODE_ATI")]
        PNTrianglesPointModeAti = 0x87F2,
        [Obsolete("Deprecated in favour of \"NormalModeAti\"")]
        [NativeName("Name", "GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
        PNTrianglesNormalModeAti = 0x87F3,
        [Obsolete("Deprecated in favour of \"TesselationLevelAti\"")]
        [NativeName("Name", "GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
        PNTrianglesTesselationLevelAti = 0x87F4,
        [NativeName("Name", "GL_PN_TRIANGLES_POINT_MODE_ATI")]
        PointModeAti = 0x87F2,
        [NativeName("Name", "GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
        NormalModeAti = 0x87F3,
        [NativeName("Name", "GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
        TesselationLevelAti = 0x87F4,
    }
}
