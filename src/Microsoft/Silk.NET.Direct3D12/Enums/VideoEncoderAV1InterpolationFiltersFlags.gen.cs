// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS")]
    public enum VideoEncoderAV1InterpolationFiltersFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_NONE")]
        VideoEncoderAV1InterpolationFiltersFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Eighttap\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP")]
        VideoEncoderAV1InterpolationFiltersFlagEighttap = 0x1,
        [Obsolete("Deprecated in favour of \"EighttapSmooth\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SMOOTH")]
        VideoEncoderAV1InterpolationFiltersFlagEighttapSmooth = 0x2,
        [Obsolete("Deprecated in favour of \"EighttapSharp\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SHARP")]
        VideoEncoderAV1InterpolationFiltersFlagEighttapSharp = 0x4,
        [Obsolete("Deprecated in favour of \"Bilinear\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_BILINEAR")]
        VideoEncoderAV1InterpolationFiltersFlagBilinear = 0x8,
        [Obsolete("Deprecated in favour of \"Switchable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_SWITCHABLE")]
        VideoEncoderAV1InterpolationFiltersFlagSwitchable = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP")]
        Eighttap = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SMOOTH")]
        EighttapSmooth = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SHARP")]
        EighttapSharp = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_BILINEAR")]
        Bilinear = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_SWITCHABLE")]
        Switchable = 0x10,
    }
}
