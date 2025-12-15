// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE")]
    public enum VideoEncoderMotionEstimationPrecisionMode : int
    {
        [Obsolete("Deprecated in favour of \"Maximum\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_MAXIMUM")]
        VideoEncoderMotionEstimationPrecisionModeMaximum = 0x0,
        [Obsolete("Deprecated in favour of \"FullPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_FULL_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeFullPixel = 0x1,
        [Obsolete("Deprecated in favour of \"HalfPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_HALF_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeHalfPixel = 0x2,
        [Obsolete("Deprecated in favour of \"QuarterPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_QUARTER_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeQuarterPixel = 0x3,
        [Obsolete("Deprecated in favour of \"EighthPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_EIGHTH_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeEighthPixel = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_MAXIMUM")]
        Maximum = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_FULL_PIXEL")]
        FullPixel = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_HALF_PIXEL")]
        HalfPixel = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_QUARTER_PIXEL")]
        QuarterPixel = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_EIGHTH_PIXEL")]
        EighthPixel = 0x4,
    }
}
