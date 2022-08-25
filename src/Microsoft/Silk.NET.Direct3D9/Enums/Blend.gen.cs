// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBLEND")]
    public enum Blend : int
    {
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "D3DBLEND_ZERO")]
        BlendZero = 0x1,
        [Obsolete("Deprecated in favour of \"One\"")]
        [NativeName("Name", "D3DBLEND_ONE")]
        BlendOne = 0x2,
        [Obsolete("Deprecated in favour of \"Srccolor\"")]
        [NativeName("Name", "D3DBLEND_SRCCOLOR")]
        BlendSrccolor = 0x3,
        [Obsolete("Deprecated in favour of \"Invsrccolor\"")]
        [NativeName("Name", "D3DBLEND_INVSRCCOLOR")]
        BlendInvsrccolor = 0x4,
        [Obsolete("Deprecated in favour of \"Srcalpha\"")]
        [NativeName("Name", "D3DBLEND_SRCALPHA")]
        BlendSrcalpha = 0x5,
        [Obsolete("Deprecated in favour of \"Invsrcalpha\"")]
        [NativeName("Name", "D3DBLEND_INVSRCALPHA")]
        BlendInvsrcalpha = 0x6,
        [Obsolete("Deprecated in favour of \"Destalpha\"")]
        [NativeName("Name", "D3DBLEND_DESTALPHA")]
        BlendDestalpha = 0x7,
        [Obsolete("Deprecated in favour of \"Invdestalpha\"")]
        [NativeName("Name", "D3DBLEND_INVDESTALPHA")]
        BlendInvdestalpha = 0x8,
        [Obsolete("Deprecated in favour of \"Destcolor\"")]
        [NativeName("Name", "D3DBLEND_DESTCOLOR")]
        BlendDestcolor = 0x9,
        [Obsolete("Deprecated in favour of \"Invdestcolor\"")]
        [NativeName("Name", "D3DBLEND_INVDESTCOLOR")]
        BlendInvdestcolor = 0xA,
        [Obsolete("Deprecated in favour of \"Srcalphasat\"")]
        [NativeName("Name", "D3DBLEND_SRCALPHASAT")]
        BlendSrcalphasat = 0xB,
        [Obsolete("Deprecated in favour of \"Bothsrcalpha\"")]
        [NativeName("Name", "D3DBLEND_BOTHSRCALPHA")]
        BlendBothsrcalpha = 0xC,
        [Obsolete("Deprecated in favour of \"Bothinvsrcalpha\"")]
        [NativeName("Name", "D3DBLEND_BOTHINVSRCALPHA")]
        BlendBothinvsrcalpha = 0xD,
        [Obsolete("Deprecated in favour of \"Blendfactor\"")]
        [NativeName("Name", "D3DBLEND_BLENDFACTOR")]
        BlendBlendfactor = 0xE,
        [Obsolete("Deprecated in favour of \"Invblendfactor\"")]
        [NativeName("Name", "D3DBLEND_INVBLENDFACTOR")]
        BlendInvblendfactor = 0xF,
        [Obsolete("Deprecated in favour of \"Srccolor2\"")]
        [NativeName("Name", "D3DBLEND_SRCCOLOR2")]
        BlendSrccolor2 = 0x10,
        [Obsolete("Deprecated in favour of \"Invsrccolor2\"")]
        [NativeName("Name", "D3DBLEND_INVSRCCOLOR2")]
        BlendInvsrccolor2 = 0x11,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DBLEND_FORCE_DWORD")]
        BlendForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DBLEND_ZERO")]
        Zero = 0x1,
        [NativeName("Name", "D3DBLEND_ONE")]
        One = 0x2,
        [NativeName("Name", "D3DBLEND_SRCCOLOR")]
        Srccolor = 0x3,
        [NativeName("Name", "D3DBLEND_INVSRCCOLOR")]
        Invsrccolor = 0x4,
        [NativeName("Name", "D3DBLEND_SRCALPHA")]
        Srcalpha = 0x5,
        [NativeName("Name", "D3DBLEND_INVSRCALPHA")]
        Invsrcalpha = 0x6,
        [NativeName("Name", "D3DBLEND_DESTALPHA")]
        Destalpha = 0x7,
        [NativeName("Name", "D3DBLEND_INVDESTALPHA")]
        Invdestalpha = 0x8,
        [NativeName("Name", "D3DBLEND_DESTCOLOR")]
        Destcolor = 0x9,
        [NativeName("Name", "D3DBLEND_INVDESTCOLOR")]
        Invdestcolor = 0xA,
        [NativeName("Name", "D3DBLEND_SRCALPHASAT")]
        Srcalphasat = 0xB,
        [NativeName("Name", "D3DBLEND_BOTHSRCALPHA")]
        Bothsrcalpha = 0xC,
        [NativeName("Name", "D3DBLEND_BOTHINVSRCALPHA")]
        Bothinvsrcalpha = 0xD,
        [NativeName("Name", "D3DBLEND_BLENDFACTOR")]
        Blendfactor = 0xE,
        [NativeName("Name", "D3DBLEND_INVBLENDFACTOR")]
        Invblendfactor = 0xF,
        [NativeName("Name", "D3DBLEND_SRCCOLOR2")]
        Srccolor2 = 0x10,
        [NativeName("Name", "D3DBLEND_INVSRCCOLOR2")]
        Invsrccolor2 = 0x11,
        [NativeName("Name", "D3DBLEND_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
