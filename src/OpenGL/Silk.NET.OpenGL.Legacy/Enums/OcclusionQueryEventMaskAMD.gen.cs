// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy
{
    public enum OcclusionQueryEventMaskAMD
    {
        QueryDepthPassEventBitAmd = 0x1,
        QueryDepthFailEventBitAmd = 0x2,
        QueryStencilFailEventBitAmd = 0x4,
        QueryDepthBoundsFailEventBitAmd = 0x8,
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF),
    }
}
