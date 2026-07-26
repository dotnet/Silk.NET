// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAGS")]
    public enum VideoEncoderFrameInputMotionUnitPrecisionSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_NONE")]
        VideoEncoderFrameInputMotionUnitPrecisionSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"FullPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_FULL_PIXEL")]
        VideoEncoderFrameInputMotionUnitPrecisionSupportFlagFullPixel = 0x1,
        [Obsolete("Deprecated in favour of \"HalfPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_HALF_PIXEL")]
        VideoEncoderFrameInputMotionUnitPrecisionSupportFlagHalfPixel = 0x2,
        [Obsolete("Deprecated in favour of \"QuarterPixel\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_QUARTER_PIXEL")]
        VideoEncoderFrameInputMotionUnitPrecisionSupportFlagQuarterPixel = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_FULL_PIXEL")]
        FullPixel = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_HALF_PIXEL")]
        HalfPixel = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAG_QUARTER_PIXEL")]
        QuarterPixel = 0x4,
    }
}
