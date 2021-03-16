// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SAMPLER_FEEDBACK_TIER")]
    public enum SamplerFeedbackTier : int
    {
        [NativeName("Name", "D3D12_SAMPLER_FEEDBACK_TIER_NOT_SUPPORTED")]
        SamplerFeedbackTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_SAMPLER_FEEDBACK_TIER_0_9")]
        SamplerFeedbackTier09 = 0x5A,
        [NativeName("Name", "D3D12_SAMPLER_FEEDBACK_TIER_1_0")]
        SamplerFeedbackTier10 = 0x64,
    }
}
