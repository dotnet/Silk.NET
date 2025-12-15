// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER")]
    public enum ResourceBindingTier : int
    {
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_1")]
        ResourceBindingTier1 = 0x1,
        [Obsolete("Deprecated in favour of \"Tier2\"")]
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_2")]
        ResourceBindingTier2 = 0x2,
        [Obsolete("Deprecated in favour of \"Tier3\"")]
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_3")]
        ResourceBindingTier3 = 0x3,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_1")]
        Tier1 = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_2")]
        Tier2 = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_3")]
        Tier3 = 0x3,
    }
}
