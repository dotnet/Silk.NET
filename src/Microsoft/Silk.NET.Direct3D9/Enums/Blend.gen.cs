// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBLEND")]
    public enum Blend
    {
        [NativeName("Name", "D3DBLEND_ZERO")]
        BlendZero = 0x1,
        [NativeName("Name", "D3DBLEND_ONE")]
        BlendOne = 0x2,
        [NativeName("Name", "D3DBLEND_SRCCOLOR")]
        BlendSrccolor = 0x3,
        [NativeName("Name", "D3DBLEND_INVSRCCOLOR")]
        BlendInvsrccolor = 0x4,
        [NativeName("Name", "D3DBLEND_SRCALPHA")]
        BlendSrcalpha = 0x5,
        [NativeName("Name", "D3DBLEND_INVSRCALPHA")]
        BlendInvsrcalpha = 0x6,
        [NativeName("Name", "D3DBLEND_DESTALPHA")]
        BlendDestalpha = 0x7,
        [NativeName("Name", "D3DBLEND_INVDESTALPHA")]
        BlendInvdestalpha = 0x8,
        [NativeName("Name", "D3DBLEND_DESTCOLOR")]
        BlendDestcolor = 0x9,
        [NativeName("Name", "D3DBLEND_INVDESTCOLOR")]
        BlendInvdestcolor = 0xA,
        [NativeName("Name", "D3DBLEND_SRCALPHASAT")]
        BlendSrcalphasat = 0xB,
        [NativeName("Name", "D3DBLEND_BOTHSRCALPHA")]
        BlendBothsrcalpha = 0xC,
        [NativeName("Name", "D3DBLEND_BOTHINVSRCALPHA")]
        BlendBothinvsrcalpha = 0xD,
        [NativeName("Name", "D3DBLEND_BLENDFACTOR")]
        BlendBlendfactor = 0xE,
        [NativeName("Name", "D3DBLEND_INVBLENDFACTOR")]
        BlendInvblendfactor = 0xF,
        [NativeName("Name", "D3DBLEND_SRCCOLOR2")]
        BlendSrccolor2 = 0x10,
        [NativeName("Name", "D3DBLEND_INVSRCCOLOR2")]
        BlendInvsrccolor2 = 0x11,
        [NativeName("Name", "D3DBLEND_FORCE_DWORD")]
        BlendForceDword = 0x7FFFFFFF,
    }
}
