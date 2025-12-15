// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SAMPLER_FLAGS")]
    public enum SamplerFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_SAMPLER_FLAG_NONE")]
        SamplerFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"UintBorderColor\"")]
        [NativeName("Name", "D3D12_SAMPLER_FLAG_UINT_BORDER_COLOR")]
        SamplerFlagUintBorderColor = 0x1,
        [Obsolete("Deprecated in favour of \"NonNormalizedCoordinates\"")]
        [NativeName("Name", "D3D12_SAMPLER_FLAG_NON_NORMALIZED_COORDINATES")]
        SamplerFlagNonNormalizedCoordinates = 0x2,
        [NativeName("Name", "D3D12_SAMPLER_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_SAMPLER_FLAG_UINT_BORDER_COLOR")]
        UintBorderColor = 0x1,
        [NativeName("Name", "D3D12_SAMPLER_FLAG_NON_NORMALIZED_COORDINATES")]
        NonNormalizedCoordinates = 0x2,
    }
}
