// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
    public enum VideoEncoderIntraRefreshMode : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_NONE")]
        VideoEncoderIntraRefreshModeNone = 0x0,
        [Obsolete("Deprecated in favour of \"RowBased\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_ROW_BASED")]
        VideoEncoderIntraRefreshModeRowBased = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE_ROW_BASED")]
        RowBased = 0x1,
    }
}
