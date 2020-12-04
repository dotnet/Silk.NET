// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_LAYOUT")]
    public enum TextureLayout
    {
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_UNKNOWN")]
        TextureLayoutUnknown = 0x0,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_ROW_MAJOR")]
        TextureLayoutRowMajor = 0x1,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE")]
        TextureLayout64KBUndefinedSwizzle = 0x2,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE")]
        TextureLayout64KBStandardSwizzle = 0x3,
    }
}
