// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ConditionalRenderMode")]
    public enum ConditionalRenderMode : int
    {
        [NativeName("Name", "GL_QUERY_WAIT")]
        QueryWait = 0x8E13,
        [NativeName("Name", "GL_QUERY_NO_WAIT")]
        QueryNoWait = 0x8E14,
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT")]
        QueryByRegionWait = 0x8E15,
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT")]
        QueryByRegionNoWait = 0x8E16,
        [NativeName("Name", "GL_QUERY_WAIT_INVERTED")]
        QueryWaitInverted = 0x8E17,
        [NativeName("Name", "GL_QUERY_NO_WAIT_INVERTED")]
        QueryNoWaitInverted = 0x8E18,
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT_INVERTED")]
        QueryByRegionWaitInverted = 0x8E19,
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
        QueryByRegionNoWaitInverted = 0x8E1A,
    }
}
