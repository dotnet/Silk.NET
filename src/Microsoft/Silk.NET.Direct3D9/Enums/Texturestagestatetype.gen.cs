// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTURESTAGESTATETYPE")]
    public enum Texturestagestatetype
    {
        [NativeName("Name", "D3DTSS_COLOROP")]
        TssColorop = 0x1,
        [NativeName("Name", "D3DTSS_COLORARG1")]
        TssColorarg1 = 0x2,
        [NativeName("Name", "D3DTSS_COLORARG2")]
        TssColorarg2 = 0x3,
        [NativeName("Name", "D3DTSS_ALPHAOP")]
        TssAlphaop = 0x4,
        [NativeName("Name", "D3DTSS_ALPHAARG1")]
        TssAlphaarg1 = 0x5,
        [NativeName("Name", "D3DTSS_ALPHAARG2")]
        TssAlphaarg2 = 0x6,
        [NativeName("Name", "D3DTSS_BUMPENVMAT00")]
        TssBumpenvmat00 = 0x7,
        [NativeName("Name", "D3DTSS_BUMPENVMAT01")]
        TssBumpenvmat01 = 0x8,
        [NativeName("Name", "D3DTSS_BUMPENVMAT10")]
        TssBumpenvmat10 = 0x9,
        [NativeName("Name", "D3DTSS_BUMPENVMAT11")]
        TssBumpenvmat11 = 0xA,
        [NativeName("Name", "D3DTSS_TEXCOORDINDEX")]
        TssTexcoordindex = 0xB,
        [NativeName("Name", "D3DTSS_BUMPENVLSCALE")]
        TssBumpenvlscale = 0x16,
        [NativeName("Name", "D3DTSS_BUMPENVLOFFSET")]
        TssBumpenvloffset = 0x17,
        [NativeName("Name", "D3DTSS_TEXTURETRANSFORMFLAGS")]
        TssTexturetransformflags = 0x18,
        [NativeName("Name", "D3DTSS_COLORARG0")]
        TssColorarg0 = 0x1A,
        [NativeName("Name", "D3DTSS_ALPHAARG0")]
        TssAlphaarg0 = 0x1B,
        [NativeName("Name", "D3DTSS_RESULTARG")]
        TssResultarg = 0x1C,
        [NativeName("Name", "D3DTSS_CONSTANT")]
        TssConstant = 0x20,
        [NativeName("Name", "D3DTSS_FORCE_DWORD")]
        TssForceDword = 0x7FFFFFFF,
    }
}
