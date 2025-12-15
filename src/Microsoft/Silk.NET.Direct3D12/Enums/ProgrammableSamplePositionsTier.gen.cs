// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER")]
    public enum ProgrammableSamplePositionsTier : int
    {
        [Obsolete("Deprecated in favour of \"TierNotSupported\"")]
        [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_NOT_SUPPORTED")]
        ProgrammableSamplePositionsTierNotSupported = 0x0,
        [Obsolete("Deprecated in favour of \"Tier1\"")]
        [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_1")]
        ProgrammableSamplePositionsTier1 = 0x1,
        [Obsolete("Deprecated in favour of \"Tier2\"")]
        [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_2")]
        ProgrammableSamplePositionsTier2 = 0x2,
        [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_NOT_SUPPORTED")]
        TierNotSupported = 0x0,
        [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_1")]
        Tier1 = 0x1,
        [NativeName("Name", "D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER_2")]
        Tier2 = 0x2,
    }
}
