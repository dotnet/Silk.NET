// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE")]
    public enum VideoEncoderMotionEstimationPrecisionMode : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_MAXIMUM")]
        VideoEncoderMotionEstimationPrecisionModeMaximum = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_FULL_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeFullPixel = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_HALF_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeHalfPixel = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_QUARTER_PIXEL")]
        VideoEncoderMotionEstimationPrecisionModeQuarterPixel = 0x3,
    }
}
