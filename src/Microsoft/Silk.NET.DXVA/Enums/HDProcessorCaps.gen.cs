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
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_BLEND")]
        HDProcessorCapsDeinterlaceBlend = 0x1,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_BOB")]
        HDProcessorCapsDeinterlaceBob = 0x2,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE")]
        HDProcessorCapsDeinterlaceAdaptive = 0x4,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION")]
        HDProcessorCapsDeinterlaceMotionCompensation = 0x8,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_INVERSE_TELECINE")]
        HDProcessorCapsInverseTelecine = 0x10,
        [NativeName("Name", "DXVAHD_PROCESSOR_CAPS_FRAME_RATE_CONVERSION")]
        HDProcessorCapsFrameRateConversion = 0x20,
    }
}
