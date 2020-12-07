// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADING_RATE")]
    public enum ShadingRate
    {
        [NativeName("Name", "D3D12_SHADING_RATE_1X1")]
        ShadingRate1X1 = 0x0,
        [NativeName("Name", "D3D12_SHADING_RATE_1X2")]
        ShadingRate1X2 = 0x1,
        [NativeName("Name", "D3D12_SHADING_RATE_2X1")]
        ShadingRate2X1 = 0x4,
        [NativeName("Name", "D3D12_SHADING_RATE_2X2")]
        ShadingRate2X2 = 0x5,
        [NativeName("Name", "D3D12_SHADING_RATE_2X4")]
        ShadingRate2X4 = 0x6,
        [NativeName("Name", "D3D12_SHADING_RATE_4X2")]
        ShadingRate4X2 = 0x9,
        [NativeName("Name", "D3D12_SHADING_RATE_4X4")]
        ShadingRate4X4 = 0xA,
    }
}
