// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_TIER")]
    public enum RaytracingTier : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_TIER_NOT_SUPPORTED")]
        RaytracingTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_TIER_1_0")]
        RaytracingTier10 = 0xA,
        [NativeName("Name", "D3D12_RAYTRACING_TIER_1_1")]
        RaytracingTier11 = 0xB,
    }
}
