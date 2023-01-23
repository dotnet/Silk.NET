// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_PROCESSOR_CAPS")]
    public enum HDProcessorCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeinterlaceBlend\"")]
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_BLEND")]
        HDProcessorCapsDeinterlaceBlend = 0x1,
        [Obsolete("Deprecated in favour of \"DeinterlaceBob\"")]
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_BOB")]
        HDProcessorCapsDeinterlaceBob = 0x2,
        [Obsolete("Deprecated in favour of \"DeinterlaceAdaptive\"")]
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE")]
        HDProcessorCapsDeinterlaceAdaptive = 0x4,
        [Obsolete("Deprecated in favour of \"DeinterlaceMotionCompensation\"")]
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION")]
        HDProcessorCapsDeinterlaceMotionCompensation = 0x8,
        [Obsolete("Deprecated in favour of \"InverseTelecine\"")]
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_INVERSE_TELECINE")]
        HDProcessorCapsInverseTelecine = 0x10,
        [Obsolete("Deprecated in favour of \"FrameRateConversion\"")]
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_FRAME_RATE_CONVERSION")]
        HDProcessorCapsFrameRateConversion = 0x20,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_BLEND")]
        DeinterlaceBlend = 0x1,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_BOB")]
        DeinterlaceBob = 0x2,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE")]
        DeinterlaceAdaptive = 0x4,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION")]
        DeinterlaceMotionCompensation = 0x8,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_INVERSE_TELECINE")]
        InverseTelecine = 0x10,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_FRAME_RATE_CONVERSION")]
        FrameRateConversion = 0x20,
    }
}
