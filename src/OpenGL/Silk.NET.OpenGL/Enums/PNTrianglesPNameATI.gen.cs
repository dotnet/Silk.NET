// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PNTrianglesPNameATI")]
    public enum PNTrianglesPNameATI : int
    {
        [NativeName("Name", "GL_PN_TRIANGLES_POINT_MODE_ATI")]
        PNTrianglesPointModeAti = 0x87F2,
        [NativeName("Name", "GL_PN_TRIANGLES_NORMAL_MODE_ATI")]
        PNTrianglesNormalModeAti = 0x87F3,
        [NativeName("Name", "GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI")]
        PNTrianglesTesselationLevelAti = 0x87F4,
    }
}
