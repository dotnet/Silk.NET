// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE")]
    public enum VideoEncoderAV1RestorationType : int
    {
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_DISABLED")]
        VideoEncoderAV1RestorationTypeDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"Switchable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SWITCHABLE")]
        VideoEncoderAV1RestorationTypeSwitchable = 0x1,
        [Obsolete("Deprecated in favour of \"Wiener\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_WIENER")]
        VideoEncoderAV1RestorationTypeWiener = 0x2,
        [Obsolete("Deprecated in favour of \"Sgrproj\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SGRPROJ")]
        VideoEncoderAV1RestorationTypeSgrproj = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_DISABLED")]
        Disabled = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SWITCHABLE")]
        Switchable = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_WIENER")]
        Wiener = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE_SGRPROJ")]
        Sgrproj = 0x3,
    }
}
