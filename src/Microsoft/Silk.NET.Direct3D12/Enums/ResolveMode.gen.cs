// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOLVE_MODE")]
    public enum ResolveMode : int
    {
        [Obsolete("Deprecated in favour of \"Decompress\"")]
        [NativeName("Name", "D3D12_RESOLVE_MODE_DECOMPRESS")]
        ResolveModeDecompress = 0x0,
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "D3D12_RESOLVE_MODE_MIN")]
        ResolveModeMin = 0x1,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "D3D12_RESOLVE_MODE_MAX")]
        ResolveModeMax = 0x2,
        [Obsolete("Deprecated in favour of \"Average\"")]
        [NativeName("Name", "D3D12_RESOLVE_MODE_AVERAGE")]
        ResolveModeAverage = 0x3,
        [Obsolete("Deprecated in favour of \"EncodeSamplerFeedback\"")]
        [NativeName("Name", "D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK")]
        ResolveModeEncodeSamplerFeedback = 0x4,
        [Obsolete("Deprecated in favour of \"DecodeSamplerFeedback\"")]
        [NativeName("Name", "D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK")]
        ResolveModeDecodeSamplerFeedback = 0x5,
        [NativeName("Name", "D3D12_RESOLVE_MODE_DECOMPRESS")]
        Decompress = 0x0,
        [NativeName("Name", "D3D12_RESOLVE_MODE_MIN")]
        Min = 0x1,
        [NativeName("Name", "D3D12_RESOLVE_MODE_MAX")]
        Max = 0x2,
        [NativeName("Name", "D3D12_RESOLVE_MODE_AVERAGE")]
        Average = 0x3,
        [NativeName("Name", "D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK")]
        EncodeSamplerFeedback = 0x4,
        [NativeName("Name", "D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK")]
        DecodeSamplerFeedback = 0x5,
    }
}
