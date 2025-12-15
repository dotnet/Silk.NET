// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION")]
    public enum VideoEncoderFrameInputMotionUnitPrecision : int
    {
        [Obsolete("Deprecated in favour of \"FullPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_FULL_PIXEL")]
        VideoEncoderFrameInputMotionUnitPrecisionFullPixel = 0x0,
        [Obsolete("Deprecated in favour of \"HalfPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_HALF_PIXEL")]
        VideoEncoderFrameInputMotionUnitPrecisionHalfPixel = 0x1,
        [Obsolete("Deprecated in favour of \"QuarterPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_QUARTER_PIXEL")]
        VideoEncoderFrameInputMotionUnitPrecisionQuarterPixel = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_FULL_PIXEL")]
        FullPixel = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_HALF_PIXEL")]
        HalfPixel = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_QUARTER_PIXEL")]
        QuarterPixel = 0x2,
    }
}
