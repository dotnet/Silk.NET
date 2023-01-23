// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSAMPLERSTATETYPE")]
    public enum Samplerstatetype : int
    {
        [Obsolete("Deprecated in favour of \"Addressu\"")]
        [NativeName("Name", "D3DSAMP_ADDRESSU")]
        SampAddressu = 0x1,
        [Obsolete("Deprecated in favour of \"Addressv\"")]
        [NativeName("Name", "D3DSAMP_ADDRESSV")]
        SampAddressv = 0x2,
        [Obsolete("Deprecated in favour of \"Addressw\"")]
        [NativeName("Name", "D3DSAMP_ADDRESSW")]
        SampAddressw = 0x3,
        [Obsolete("Deprecated in favour of \"Bordercolor\"")]
        [NativeName("Name", "D3DSAMP_BORDERCOLOR")]
        SampBordercolor = 0x4,
        [Obsolete("Deprecated in favour of \"Magfilter\"")]
        [NativeName("Name", "D3DSAMP_MAGFILTER")]
        SampMagfilter = 0x5,
        [Obsolete("Deprecated in favour of \"Minfilter\"")]
        [NativeName("Name", "D3DSAMP_MINFILTER")]
        SampMinfilter = 0x6,
        [Obsolete("Deprecated in favour of \"Mipfilter\"")]
        [NativeName("Name", "D3DSAMP_MIPFILTER")]
        SampMipfilter = 0x7,
        [Obsolete("Deprecated in favour of \"Mipmaplodbias\"")]
        [NativeName("Name", "D3DSAMP_MIPMAPLODBIAS")]
        SampMipmaplodbias = 0x8,
        [Obsolete("Deprecated in favour of \"Maxmiplevel\"")]
        [NativeName("Name", "D3DSAMP_MAXMIPLEVEL")]
        SampMaxmiplevel = 0x9,
        [Obsolete("Deprecated in favour of \"Maxanisotropy\"")]
        [NativeName("Name", "D3DSAMP_MAXANISOTROPY")]
        SampMaxanisotropy = 0xA,
        [Obsolete("Deprecated in favour of \"Srgbtexture\"")]
        [NativeName("Name", "D3DSAMP_SRGBTEXTURE")]
        SampSrgbtexture = 0xB,
        [Obsolete("Deprecated in favour of \"Elementindex\"")]
        [NativeName("Name", "D3DSAMP_ELEMENTINDEX")]
        SampElementindex = 0xC,
        [Obsolete("Deprecated in favour of \"Dmapoffset\"")]
        [NativeName("Name", "D3DSAMP_DMAPOFFSET")]
        SampDmapoffset = 0xD,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSAMP_FORCE_DWORD")]
        SampForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSAMP_ADDRESSU")]
        Addressu = 0x1,
        [NativeName("Name", "D3DSAMP_ADDRESSV")]
        Addressv = 0x2,
        [NativeName("Name", "D3DSAMP_ADDRESSW")]
        Addressw = 0x3,
        [NativeName("Name", "D3DSAMP_BORDERCOLOR")]
        Bordercolor = 0x4,
        [NativeName("Name", "D3DSAMP_MAGFILTER")]
        Magfilter = 0x5,
        [NativeName("Name", "D3DSAMP_MINFILTER")]
        Minfilter = 0x6,
        [NativeName("Name", "D3DSAMP_MIPFILTER")]
        Mipfilter = 0x7,
        [NativeName("Name", "D3DSAMP_MIPMAPLODBIAS")]
        Mipmaplodbias = 0x8,
        [NativeName("Name", "D3DSAMP_MAXMIPLEVEL")]
        Maxmiplevel = 0x9,
        [NativeName("Name", "D3DSAMP_MAXANISOTROPY")]
        Maxanisotropy = 0xA,
        [NativeName("Name", "D3DSAMP_SRGBTEXTURE")]
        Srgbtexture = 0xB,
        [NativeName("Name", "D3DSAMP_ELEMENTINDEX")]
        Elementindex = 0xC,
        [NativeName("Name", "D3DSAMP_DMAPOFFSET")]
        Dmapoffset = 0xD,
        [NativeName("Name", "D3DSAMP_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
