// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS")]
    public enum VideoEncoderAV1RestorationSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"FlagNotSupported\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_NOT_SUPPORTED")]
        VideoEncoderAV1RestorationSupportFlagNotSupported = 0x0,
        [Obsolete("Deprecated in favour of \"Flag32x32\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_32x32")]
        VideoEncoderAV1RestorationSupportFlag32x32 = 0x1,
        [Obsolete("Deprecated in favour of \"Flag64x64\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_64x64")]
        VideoEncoderAV1RestorationSupportFlag64x64 = 0x2,
        [Obsolete("Deprecated in favour of \"Flag128x128\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_128x128")]
        VideoEncoderAV1RestorationSupportFlag128x128 = 0x4,
        [Obsolete("Deprecated in favour of \"Flag256x256\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_256x256")]
        VideoEncoderAV1RestorationSupportFlag256x256 = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_NOT_SUPPORTED")]
        FlagNotSupported = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_32x32")]
        Flag32x32 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_64x64")]
        Flag64x64 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_128x128")]
        Flag128x128 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_256x256")]
        Flag256x256 = 0x8,
    }
}
