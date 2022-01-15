// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
    public enum SharedResourceCompatibilityTier : int
    {
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0")]
        SharedResourceCompatibilityTier0 = 0x0,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1")]
        SharedResourceCompatibilityTier1 = 0x1,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2")]
        SharedResourceCompatibilityTier2 = 0x2,
    }
}
