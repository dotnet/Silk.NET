// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADING_RATE")]
    public enum ShadingRate : int
    {
        [Obsolete("Deprecated in favour of \"Rate1X1\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_1X1")]
        ShadingRate1X1 = 0x0,
        [Obsolete("Deprecated in favour of \"Rate1X2\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_1X2")]
        ShadingRate1X2 = 0x1,
        [Obsolete("Deprecated in favour of \"Rate2X1\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_2X1")]
        ShadingRate2X1 = 0x4,
        [Obsolete("Deprecated in favour of \"Rate2X2\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_2X2")]
        ShadingRate2X2 = 0x5,
        [Obsolete("Deprecated in favour of \"Rate2X4\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_2X4")]
        ShadingRate2X4 = 0x6,
        [Obsolete("Deprecated in favour of \"Rate4X2\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_4X2")]
        ShadingRate4X2 = 0x9,
        [Obsolete("Deprecated in favour of \"Rate4X4\"")]
        [NativeName("Name", "D3D12_SHADING_RATE_4X4")]
        ShadingRate4X4 = 0xA,
        [NativeName("Name", "D3D12_SHADING_RATE_1X1")]
        Rate1X1 = 0x0,
        [NativeName("Name", "D3D12_SHADING_RATE_1X2")]
        Rate1X2 = 0x1,
        [NativeName("Name", "D3D12_SHADING_RATE_2X1")]
        Rate2X1 = 0x4,
        [NativeName("Name", "D3D12_SHADING_RATE_2X2")]
        Rate2X2 = 0x5,
        [NativeName("Name", "D3D12_SHADING_RATE_2X4")]
        Rate2X4 = 0x6,
        [NativeName("Name", "D3D12_SHADING_RATE_4X2")]
        Rate4X2 = 0x9,
        [NativeName("Name", "D3D12_SHADING_RATE_4X4")]
        Rate4X4 = 0xA,
    }
}
