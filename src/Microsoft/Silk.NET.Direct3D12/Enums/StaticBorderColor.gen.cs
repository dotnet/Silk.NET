// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATIC_BORDER_COLOR")]
    public enum StaticBorderColor
    {
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK")]
        StaticBorderColorTransparentBlack = 0x0,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK")]
        StaticBorderColorOpaqueBlack = 0x1,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE")]
        StaticBorderColorOpaqueWhite = 0x2,
    }
}
