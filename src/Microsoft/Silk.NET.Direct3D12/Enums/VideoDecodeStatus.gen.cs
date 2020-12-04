// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS")]
    public enum VideoDecodeStatus
    {
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_OK")]
        VideoDecodeStatusOK = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_CONTINUE")]
        VideoDecodeStatusContinue = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY")]
        VideoDecodeStatusContinueSkipDisplay = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_RESTART")]
        VideoDecodeStatusRestart = 0x3,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED")]
        VideoDecodeStatusRateExceeded = 0x4,
    }
}
