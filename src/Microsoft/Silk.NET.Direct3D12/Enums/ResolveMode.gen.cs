// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
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
