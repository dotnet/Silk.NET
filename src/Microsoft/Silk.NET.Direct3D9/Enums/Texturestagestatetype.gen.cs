// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTURESTAGESTATETYPE")]
    public enum Texturestagestatetype : int
    {
        [Obsolete("Deprecated in favour of \"Colorop\"")]
        [NativeName("Name", "D3DTSS_COLOROP")]
        TssColorop = 0x1,
        [Obsolete("Deprecated in favour of \"Colorarg1\"")]
        [NativeName("Name", "D3DTSS_COLORARG1")]
        TssColorarg1 = 0x2,
        [Obsolete("Deprecated in favour of \"Colorarg2\"")]
        [NativeName("Name", "D3DTSS_COLORARG2")]
        TssColorarg2 = 0x3,
        [Obsolete("Deprecated in favour of \"Alphaop\"")]
        [NativeName("Name", "D3DTSS_ALPHAOP")]
        TssAlphaop = 0x4,
        [Obsolete("Deprecated in favour of \"Alphaarg1\"")]
        [NativeName("Name", "D3DTSS_ALPHAARG1")]
        TssAlphaarg1 = 0x5,
        [Obsolete("Deprecated in favour of \"Alphaarg2\"")]
        [NativeName("Name", "D3DTSS_ALPHAARG2")]
        TssAlphaarg2 = 0x6,
        [Obsolete("Deprecated in favour of \"Bumpenvmat00\"")]
        [NativeName("Name", "D3DTSS_BUMPENVMAT00")]
        TssBumpenvmat00 = 0x7,
        [Obsolete("Deprecated in favour of \"Bumpenvmat01\"")]
        [NativeName("Name", "D3DTSS_BUMPENVMAT01")]
        TssBumpenvmat01 = 0x8,
        [Obsolete("Deprecated in favour of \"Bumpenvmat10\"")]
        [NativeName("Name", "D3DTSS_BUMPENVMAT10")]
        TssBumpenvmat10 = 0x9,
        [Obsolete("Deprecated in favour of \"Bumpenvmat11\"")]
        [NativeName("Name", "D3DTSS_BUMPENVMAT11")]
        TssBumpenvmat11 = 0xA,
        [Obsolete("Deprecated in favour of \"Texcoordindex\"")]
        [NativeName("Name", "D3DTSS_TEXCOORDINDEX")]
        TssTexcoordindex = 0xB,
        [Obsolete("Deprecated in favour of \"Bumpenvlscale\"")]
        [NativeName("Name", "D3DTSS_BUMPENVLSCALE")]
        TssBumpenvlscale = 0x16,
        [Obsolete("Deprecated in favour of \"Bumpenvloffset\"")]
        [NativeName("Name", "D3DTSS_BUMPENVLOFFSET")]
        TssBumpenvloffset = 0x17,
        [Obsolete("Deprecated in favour of \"Texturetransformflags\"")]
        [NativeName("Name", "D3DTSS_TEXTURETRANSFORMFLAGS")]
        TssTexturetransformflags = 0x18,
        [Obsolete("Deprecated in favour of \"Colorarg0\"")]
        [NativeName("Name", "D3DTSS_COLORARG0")]
        TssColorarg0 = 0x1A,
        [Obsolete("Deprecated in favour of \"Alphaarg0\"")]
        [NativeName("Name", "D3DTSS_ALPHAARG0")]
        TssAlphaarg0 = 0x1B,
        [Obsolete("Deprecated in favour of \"Resultarg\"")]
        [NativeName("Name", "D3DTSS_RESULTARG")]
        TssResultarg = 0x1C,
        [Obsolete("Deprecated in favour of \"Constant\"")]
        [NativeName("Name", "D3DTSS_CONSTANT")]
        TssConstant = 0x20,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DTSS_FORCE_DWORD")]
        TssForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DTSS_COLOROP")]
        Colorop = 0x1,
        [NativeName("Name", "D3DTSS_COLORARG1")]
        Colorarg1 = 0x2,
        [NativeName("Name", "D3DTSS_COLORARG2")]
        Colorarg2 = 0x3,
        [NativeName("Name", "D3DTSS_ALPHAOP")]
        Alphaop = 0x4,
        [NativeName("Name", "D3DTSS_ALPHAARG1")]
        Alphaarg1 = 0x5,
        [NativeName("Name", "D3DTSS_ALPHAARG2")]
        Alphaarg2 = 0x6,
        [NativeName("Name", "D3DTSS_BUMPENVMAT00")]
        Bumpenvmat00 = 0x7,
        [NativeName("Name", "D3DTSS_BUMPENVMAT01")]
        Bumpenvmat01 = 0x8,
        [NativeName("Name", "D3DTSS_BUMPENVMAT10")]
        Bumpenvmat10 = 0x9,
        [NativeName("Name", "D3DTSS_BUMPENVMAT11")]
        Bumpenvmat11 = 0xA,
        [NativeName("Name", "D3DTSS_TEXCOORDINDEX")]
        Texcoordindex = 0xB,
        [NativeName("Name", "D3DTSS_BUMPENVLSCALE")]
        Bumpenvlscale = 0x16,
        [NativeName("Name", "D3DTSS_BUMPENVLOFFSET")]
        Bumpenvloffset = 0x17,
        [NativeName("Name", "D3DTSS_TEXTURETRANSFORMFLAGS")]
        Texturetransformflags = 0x18,
        [NativeName("Name", "D3DTSS_COLORARG0")]
        Colorarg0 = 0x1A,
        [NativeName("Name", "D3DTSS_ALPHAARG0")]
        Alphaarg0 = 0x1B,
        [NativeName("Name", "D3DTSS_RESULTARG")]
        Resultarg = 0x1C,
        [NativeName("Name", "D3DTSS_CONSTANT")]
        Constant = 0x20,
        [NativeName("Name", "D3DTSS_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
