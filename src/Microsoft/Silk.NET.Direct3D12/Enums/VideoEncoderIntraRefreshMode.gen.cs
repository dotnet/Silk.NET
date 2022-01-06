// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
    public enum VideoEncoderIntraRefreshMode : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_NONE")]
        VideoEncoderIntraRefreshModeNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_ROW_BASED")]
        VideoEncoderIntraRefreshModeRowBased = 0x1,
    }
}
