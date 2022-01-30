// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VARIABLE_SHADING_RATE_TIER")]
    public enum VariableShadingRateTier : int
    {
        [NativeName("Name", "D3D12_VARIABLE_SHADING_RATE_TIER_NOT_SUPPORTED")]
        VariableShadingRateTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_VARIABLE_SHADING_RATE_TIER_1")]
        VariableShadingRateTier1 = 0x1,
        [NativeName("Name", "D3D12_VARIABLE_SHADING_RATE_TIER_2")]
        VariableShadingRateTier2 = 0x2,
    }
}
