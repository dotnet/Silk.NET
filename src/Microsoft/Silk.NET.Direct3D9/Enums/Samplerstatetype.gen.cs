// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSAMPLERSTATETYPE")]
    public enum Samplerstatetype : int
    {
        [NativeName("Name", "D3DSAMP_ADDRESSU")]
        SampAddressu = 0x1,
        [NativeName("Name", "D3DSAMP_ADDRESSV")]
        SampAddressv = 0x2,
        [NativeName("Name", "D3DSAMP_ADDRESSW")]
        SampAddressw = 0x3,
        [NativeName("Name", "D3DSAMP_BORDERCOLOR")]
        SampBordercolor = 0x4,
        [NativeName("Name", "D3DSAMP_MAGFILTER")]
        SampMagfilter = 0x5,
        [NativeName("Name", "D3DSAMP_MINFILTER")]
        SampMinfilter = 0x6,
        [NativeName("Name", "D3DSAMP_MIPFILTER")]
        SampMipfilter = 0x7,
        [NativeName("Name", "D3DSAMP_MIPMAPLODBIAS")]
        SampMipmaplodbias = 0x8,
        [NativeName("Name", "D3DSAMP_MAXMIPLEVEL")]
        SampMaxmiplevel = 0x9,
        [NativeName("Name", "D3DSAMP_MAXANISOTROPY")]
        SampMaxanisotropy = 0xA,
        [NativeName("Name", "D3DSAMP_SRGBTEXTURE")]
        SampSrgbtexture = 0xB,
        [NativeName("Name", "D3DSAMP_ELEMENTINDEX")]
        SampElementindex = 0xC,
        [NativeName("Name", "D3DSAMP_DMAPOFFSET")]
        SampDmapoffset = 0xD,
        [NativeName("Name", "D3DSAMP_FORCE_DWORD")]
        SampForceDword = 0x7FFFFFFF,
    }
}
