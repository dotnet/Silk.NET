// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_AXIS_SHADING_RATE")]
    public enum AxisShadingRate : int
    {
        [NativeName("Name", "D3D12_AXIS_SHADING_RATE_1X")]
        AxisShadingRate1X = 0x0,
        [NativeName("Name", "D3D12_AXIS_SHADING_RATE_2X")]
        AxisShadingRate2X = 0x1,
        [NativeName("Name", "D3D12_AXIS_SHADING_RATE_4X")]
        AxisShadingRate4X = 0x2,
    }
}
