// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_AXIS_SHADING_RATE")]
    public enum AxisShadingRate
    {
        [NativeName("Name", "D3D12_AXIS_SHADING_RATE_1X")]
        AxisShadingRate1X = 0x0,
        [NativeName("Name", "D3D12_AXIS_SHADING_RATE_2X")]
        AxisShadingRate2X = 0x1,
        [NativeName("Name", "D3D12_AXIS_SHADING_RATE_4X")]
        AxisShadingRate4X = 0x2,
    }
}
