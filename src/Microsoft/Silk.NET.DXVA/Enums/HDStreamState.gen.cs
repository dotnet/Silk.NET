// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_STREAM_STATE")]
    public enum HDStreamState : int
    {
        [NativeName("Name", "DXVAHD_STREAM_STATE_D3DFORMAT")]
        HDStreamStateD3Dformat = 0x0,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FRAME_FORMAT")]
        HDStreamStateFrameFormat = 0x1,
        [NativeName("Name", "DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE")]
        HDStreamStateInputColorSpace = 0x2,
        [NativeName("Name", "DXVAHD_STREAM_STATE_OUTPUT_RATE")]
        HDStreamStateOutputRate = 0x3,
        [NativeName("Name", "DXVAHD_STREAM_STATE_SOURCE_RECT")]
        HDStreamStateSourceRect = 0x4,
        [NativeName("Name", "DXVAHD_STREAM_STATE_DESTINATION_RECT")]
        HDStreamStateDestinationRect = 0x5,
        [NativeName("Name", "DXVAHD_STREAM_STATE_ALPHA")]
        HDStreamStateAlpha = 0x6,
        [NativeName("Name", "DXVAHD_STREAM_STATE_PALETTE")]
        HDStreamStatePalette = 0x7,
        [NativeName("Name", "DXVAHD_STREAM_STATE_LUMA_KEY")]
        HDStreamStateLumaKey = 0x8,
        [NativeName("Name", "DXVAHD_STREAM_STATE_ASPECT_RATIO")]
        HDStreamStateAspectRatio = 0x9,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_BRIGHTNESS")]
        HDStreamStateFilterBrightness = 0x64,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_CONTRAST")]
        HDStreamStateFilterContrast = 0x65,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_HUE")]
        HDStreamStateFilterHue = 0x66,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_SATURATION")]
        HDStreamStateFilterSaturation = 0x67,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_NOISE_REDUCTION")]
        HDStreamStateFilterNoiseReduction = 0x68,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_EDGE_ENHANCEMENT")]
        HDStreamStateFilterEdgeEnhancement = 0x69,
        [NativeName("Name", "DXVAHD_STREAM_STATE_FILTER_ANAMORPHIC_SCALING")]
        HDStreamStateFilterAnamorphicScaling = 0x6A,
        [NativeName("Name", "DXVAHD_STREAM_STATE_PRIVATE")]
        HDStreamStatePrivate = 0x3E8,
    }
}
