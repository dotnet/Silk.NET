// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_WAVE_MMA_TIER")]
    public enum WaveMmaTier : int
    {
        [Obsolete("Deprecated in favour of \"TierNotSupported\"")]
        [NativeName("Name", "D3D12_WAVE_MMA_TIER_NOT_SUPPORTED")]
        WaveMmaTierNotSupported = 0x0,
        [Obsolete("Deprecated in favour of \"Tier10\"")]
        [NativeName("Name", "D3D12_WAVE_MMA_TIER_1_0")]
        WaveMmaTier10 = 0xA,
        [NativeName("Name", "D3D12_WAVE_MMA_TIER_NOT_SUPPORTED")]
        TierNotSupported = 0x0,
        [NativeName("Name", "D3D12_WAVE_MMA_TIER_1_0")]
        Tier10 = 0xA,
    }
}