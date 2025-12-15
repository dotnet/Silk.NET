// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RECREATE_AT_TIER")]
    public enum RecreateATTier : int
    {
        [Obsolete("Deprecated in favour of \"TierNotSupported\"")]
        [NativeName("Name", "D3D12_RECREATE_AT_TIER_NOT_SUPPORTED")]
        RecreateATTierNotSupported = 0x0,
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D12_RECREATE_AT_TIER_1")]
        RecreateATTier1 = 0x1,
        [NativeName("Name", "D3D12_RECREATE_AT_TIER_NOT_SUPPORTED")]
        TierNotSupported = 0x0,
        [NativeName("Name", "D3D12_RECREATE_AT_TIER_1")]
        Tier1 = 0x1,
    }
}
