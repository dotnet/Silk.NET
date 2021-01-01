// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "OcclusionQueryEventMaskAMD")]
    public enum OcclusionQueryEventMaskAMD : int
    {
        [NativeName("Name", "GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD")]
        QueryDepthPassEventBitAmd = 0x1,
        [NativeName("Name", "GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD")]
        QueryDepthFailEventBitAmd = 0x2,
        [NativeName("Name", "GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD")]
        QueryStencilFailEventBitAmd = 0x4,
        [NativeName("Name", "GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD")]
        QueryDepthBoundsFailEventBitAmd = 0x8,
        [NativeName("Name", "GL_QUERY_ALL_EVENT_BITS_AMD")]
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF),
    }
}
