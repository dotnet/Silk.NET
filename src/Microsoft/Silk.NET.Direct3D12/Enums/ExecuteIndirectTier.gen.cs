// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_EXECUTE_INDIRECT_TIER")]
    public enum ExecuteIndirectTier : int
    {
        [Obsolete("Deprecated in favour of \"D3D1210\"")]
        [NativeName("Name", "D3D12_EXECUTE_INDIRECT_TIER_1_0")]
        ExecuteIndirectTier10 = 0xA,
        [Obsolete("Deprecated in favour of \"D3D1211\"")]
        [NativeName("Name", "D3D12_EXECUTE_INDIRECT_TIER_1_1")]
        ExecuteIndirectTier11 = 0xB,
        [NativeName("Name", "D3D12_EXECUTE_INDIRECT_TIER_1_0")]
        D3D1210 = 0xA,
        [NativeName("Name", "D3D12_EXECUTE_INDIRECT_TIER_1_1")]
        D3D1211 = 0xB,
    }
}
