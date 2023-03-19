// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER")]
    public enum ModeScanlineOrder : int
    {
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED")]
        ModeScanlineOrderUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"Progressive\"")]
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE")]
        ModeScanlineOrderProgressive = 0x1,
        [Obsolete("Deprecated in favour of \"UpperFieldFirst\"")]
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST")]
        ModeScanlineOrderUpperFieldFirst = 0x2,
        [Obsolete("Deprecated in favour of \"LowerFieldFirst\"")]
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST")]
        ModeScanlineOrderLowerFieldFirst = 0x3,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED")]
        Unspecified = 0x0,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE")]
        Progressive = 0x1,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST")]
        UpperFieldFirst = 0x2,
        [NativeName("Name", "DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST")]
        LowerFieldFirst = 0x3,
    }
}
