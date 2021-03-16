// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE")]
    public enum TextureAddressMode : int
    {
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_WRAP")]
        TextureAddressModeWrap = 0x1,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_MIRROR")]
        TextureAddressModeMirror = 0x2,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_CLAMP")]
        TextureAddressModeClamp = 0x3,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_BORDER")]
        TextureAddressModeBorder = 0x4,
        [NativeName("Name", "D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE")]
        TextureAddressModeMirrorOnce = 0x5,
    }
}
