// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTUREADDRESS")]
    public enum Textureaddress : int
    {
        [NativeName("Name", "D3DTADDRESS_WRAP")]
        TaddressWrap = 0x1,
        [NativeName("Name", "D3DTADDRESS_MIRROR")]
        TaddressMirror = 0x2,
        [NativeName("Name", "D3DTADDRESS_CLAMP")]
        TaddressClamp = 0x3,
        [NativeName("Name", "D3DTADDRESS_BORDER")]
        TaddressBorder = 0x4,
        [NativeName("Name", "D3DTADDRESS_MIRRORONCE")]
        TaddressMirroronce = 0x5,
        [NativeName("Name", "D3DTADDRESS_FORCE_DWORD")]
        TaddressForceDword = 0x7FFFFFFF,
    }
}
