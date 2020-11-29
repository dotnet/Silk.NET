// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER")]
    public enum ModeScanlineOrder
    {
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED")]
        ModeScanlineOrderUnspecified = 0x0,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE")]
        ModeScanlineOrderProgressive = 0x1,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST")]
        ModeScanlineOrderUpperFieldFirst = 0x2,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST")]
        ModeScanlineOrderLowerFieldFirst = 0x3,
    }
}
