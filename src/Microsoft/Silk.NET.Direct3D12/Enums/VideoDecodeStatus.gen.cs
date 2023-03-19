// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS")]
    public enum VideoDecodeStatus : int
    {
        [Obsolete("Deprecated in favour of \"OK\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_OK")]
        VideoDecodeStatusOK = 0x0,
        [Obsolete("Deprecated in favour of \"Continue\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_CONTINUE")]
        VideoDecodeStatusContinue = 0x1,
        [Obsolete("Deprecated in favour of \"ContinueSkipDisplay\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY")]
        VideoDecodeStatusContinueSkipDisplay = 0x2,
        [Obsolete("Deprecated in favour of \"Restart\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_RESTART")]
        VideoDecodeStatusRestart = 0x3,
        [Obsolete("Deprecated in favour of \"RateExceeded\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED")]
        VideoDecodeStatusRateExceeded = 0x4,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_OK")]
        OK = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_CONTINUE")]
        Continue = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY")]
        ContinueSkipDisplay = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_RESTART")]
        Restart = 0x3,
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED")]
        RateExceeded = 0x4,
    }
}
