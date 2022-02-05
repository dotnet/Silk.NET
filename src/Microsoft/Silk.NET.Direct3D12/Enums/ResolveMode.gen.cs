// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOLVE_MODE")]
    public enum ResolveMode : int
    {
        [NativeName("Name", "D3D12_RESOLVE_MODE_DECOMPRESS")]
        ResolveModeDecompress = 0x0,
        [NativeName("Name", "D3D12_RESOLVE_MODE_MIN")]
        ResolveModeMin = 0x1,
        [NativeName("Name", "D3D12_RESOLVE_MODE_MAX")]
        ResolveModeMax = 0x2,
        [NativeName("Name", "D3D12_RESOLVE_MODE_AVERAGE")]
        ResolveModeAverage = 0x3,
        [NativeName("Name", "D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK")]
        ResolveModeEncodeSamplerFeedback = 0x4,
        [NativeName("Name", "D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK")]
        ResolveModeDecodeSamplerFeedback = 0x5,
    }
}
