// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS")]
    public enum VideoProcessorProcessorCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeinterlaceBlend\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND")]
        VideoProcessorProcessorCapsDeinterlaceBlend = 0x1,
        [Obsolete("Deprecated in favour of \"DeinterlaceBob\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB")]
        VideoProcessorProcessorCapsDeinterlaceBob = 0x2,
        [Obsolete("Deprecated in favour of \"DeinterlaceAdaptive\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE")]
        VideoProcessorProcessorCapsDeinterlaceAdaptive = 0x4,
        [Obsolete("Deprecated in favour of \"DeinterlaceMotionCompensation\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION")]
        VideoProcessorProcessorCapsDeinterlaceMotionCompensation = 0x8,
        [Obsolete("Deprecated in favour of \"InverseTelecine\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE")]
        VideoProcessorProcessorCapsInverseTelecine = 0x10,
        [Obsolete("Deprecated in favour of \"FrameRateConversion\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION")]
        VideoProcessorProcessorCapsFrameRateConversion = 0x20,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND")]
        DeinterlaceBlend = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB")]
        DeinterlaceBob = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE")]
        DeinterlaceAdaptive = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION")]
        DeinterlaceMotionCompensation = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE")]
        InverseTelecine = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION")]
        FrameRateConversion = 0x20,
    }
}
