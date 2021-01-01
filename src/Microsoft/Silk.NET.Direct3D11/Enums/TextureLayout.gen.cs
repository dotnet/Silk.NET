// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEXTURE_LAYOUT")]
    public enum TextureLayout : int
    {
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_UNDEFINED")]
        TextureLayoutUndefined = 0x0,
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_ROW_MAJOR")]
        TextureLayoutRowMajor = 0x1,
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE")]
        TextureLayout64KStandardSwizzle = 0x2,
    }
}
