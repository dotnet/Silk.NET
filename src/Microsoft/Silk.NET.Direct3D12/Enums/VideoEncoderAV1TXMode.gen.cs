// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE")]
    public enum VideoEncoderAV1TXMode : int
    {
        [Obsolete("Deprecated in favour of \"Only4x4\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_ONLY4x4")]
        VideoEncoderAV1TXModeOnly4x4 = 0x0,
        [Obsolete("Deprecated in favour of \"Largest\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_LARGEST")]
        VideoEncoderAV1TXModeLargest = 0x1,
        [Obsolete("Deprecated in favour of \"Select\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_SELECT")]
        VideoEncoderAV1TXModeSelect = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_ONLY4x4")]
        Only4x4 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_LARGEST")]
        Largest = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_SELECT")]
        Select = 0x2,
    }
}
