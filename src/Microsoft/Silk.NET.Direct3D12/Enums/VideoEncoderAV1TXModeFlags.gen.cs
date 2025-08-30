// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS")]
    public enum VideoEncoderAV1TXModeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_NONE")]
        VideoEncoderAV1TXModeFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Only4x4\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_ONLY4x4")]
        VideoEncoderAV1TXModeFlagOnly4x4 = 0x1,
        [Obsolete("Deprecated in favour of \"Largest\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_LARGEST")]
        VideoEncoderAV1TXModeFlagLargest = 0x2,
        [Obsolete("Deprecated in favour of \"Select\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_SELECT")]
        VideoEncoderAV1TXModeFlagSelect = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_ONLY4x4")]
        Only4x4 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_LARGEST")]
        Largest = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_SELECT")]
        Select = 0x4,
    }
}
