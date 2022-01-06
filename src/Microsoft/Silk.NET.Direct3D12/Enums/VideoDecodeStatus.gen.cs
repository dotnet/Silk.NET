// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS")]
    public enum VideoDecodeStatus : int
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
