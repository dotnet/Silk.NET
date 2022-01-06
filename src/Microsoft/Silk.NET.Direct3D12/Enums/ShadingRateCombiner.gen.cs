// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHADING_RATE_COMBINER")]
    public enum ShadingRateCombiner : int
    {
        [NativeName("Name", "D3D12_SHADING_RATE_COMBINER_PASSTHROUGH")]
        ShadingRateCombinerPassthrough = 0x0,
        [NativeName("Name", "D3D12_SHADING_RATE_COMBINER_OVERRIDE")]
        ShadingRateCombinerOverride = 0x1,
        [NativeName("Name", "D3D12_SHADING_RATE_COMBINER_MIN")]
        ShadingRateCombinerMin = 0x2,
        [NativeName("Name", "D3D12_SHADING_RATE_COMBINER_MAX")]
        ShadingRateCombinerMax = 0x3,
        [NativeName("Name", "D3D12_SHADING_RATE_COMBINER_SUM")]
        ShadingRateCombinerSum = 0x4,
    }
}
