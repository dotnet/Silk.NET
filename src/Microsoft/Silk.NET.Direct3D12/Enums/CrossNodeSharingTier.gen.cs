// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_CROSS_NODE_SHARING_TIER")]
    public enum CrossNodeSharingTier : int
    {
        [NativeName("Name", "D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED")]
        CrossNodeSharingTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED")]
        CrossNodeSharingTier1Emulated = 0x1,
        [NativeName("Name", "D3D12_CROSS_NODE_SHARING_TIER_1")]
        CrossNodeSharingTier1 = 0x2,
        [NativeName("Name", "D3D12_CROSS_NODE_SHARING_TIER_2")]
        CrossNodeSharingTier2 = 0x3,
        [NativeName("Name", "D3D12_CROSS_NODE_SHARING_TIER_3")]
        CrossNodeSharingTier3 = 0x4,
    }
}
