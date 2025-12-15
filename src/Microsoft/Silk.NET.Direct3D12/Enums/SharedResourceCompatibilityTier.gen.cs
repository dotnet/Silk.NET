// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER")]
    public enum SharedResourceCompatibilityTier : int
    {
        [Obsolete("Deprecated in favour of \"Tier0\"")]
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0")]
        SharedResourceCompatibilityTier0 = 0x0,
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1")]
        SharedResourceCompatibilityTier1 = 0x1,
        [Obsolete("Deprecated in favour of \"Tier2\"")]
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2")]
        SharedResourceCompatibilityTier2 = 0x2,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0")]
        Tier0 = 0x0,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1")]
        Tier1 = 0x1,
        [NativeName("Name", "D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2")]
        Tier2 = 0x2,
    }
}
