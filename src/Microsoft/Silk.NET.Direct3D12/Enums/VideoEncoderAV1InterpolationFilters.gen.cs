// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS")]
    public enum VideoEncoderAV1InterpolationFilters : int
    {
        [Obsolete("Deprecated in favour of \"Eighttap\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP")]
        VideoEncoderAV1InterpolationFiltersEighttap = 0x0,
        [Obsolete("Deprecated in favour of \"EighttapSmooth\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SMOOTH")]
        VideoEncoderAV1InterpolationFiltersEighttapSmooth = 0x1,
        [Obsolete("Deprecated in favour of \"EighttapSharp\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SHARP")]
        VideoEncoderAV1InterpolationFiltersEighttapSharp = 0x2,
        [Obsolete("Deprecated in favour of \"Bilinear\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_BILINEAR")]
        VideoEncoderAV1InterpolationFiltersBilinear = 0x3,
        [Obsolete("Deprecated in favour of \"Switchable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_SWITCHABLE")]
        VideoEncoderAV1InterpolationFiltersSwitchable = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP")]
        Eighttap = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SMOOTH")]
        EighttapSmooth = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SHARP")]
        EighttapSharp = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_BILINEAR")]
        Bilinear = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_SWITCHABLE")]
        Switchable = 0x4,
    }
}
