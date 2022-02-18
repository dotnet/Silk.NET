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
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND")]
        VideoProcessorProcessorCapsDeinterlaceBlend = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB")]
        VideoProcessorProcessorCapsDeinterlaceBob = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE")]
        VideoProcessorProcessorCapsDeinterlaceAdaptive = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION")]
        VideoProcessorProcessorCapsDeinterlaceMotionCompensation = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE")]
        VideoProcessorProcessorCapsInverseTelecine = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION")]
        VideoProcessorProcessorCapsFrameRateConversion = 0x20,
    }
}
