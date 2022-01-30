// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA2_VideoChromaSubSampling")]
    public enum DXVA2VideoChromaSubSampling : int
    {
        [NativeName("Name", "DXVA2_VideoChromaSubsamplingMask")]
        DXVA2VideoChromaSubsamplingMask = 0xF,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Unknown")]
        DXVA2VideoChromaSubsamplingUnknown = 0x0,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_ProgressiveChroma")]
        DXVA2VideoChromaSubsamplingProgressiveChroma = 0x8,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Horizontally_Cosited")]
        DXVA2VideoChromaSubsamplingHorizontallyCosited = 0x4,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_Cosited")]
        DXVA2VideoChromaSubsamplingVerticallyCosited = 0x2,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_AlignedChromaPlanes")]
        DXVA2VideoChromaSubsamplingVerticallyAlignedChromaPlanes = 0x1,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG2")]
        DXVA2VideoChromaSubsamplingMpeg2 = 0x5,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG1")]
        DXVA2VideoChromaSubsamplingMpeg1 = 0x1,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_DV_PAL")]
        DXVA2VideoChromaSubsamplingDVPal = 0x6,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Cosited")]
        DXVA2VideoChromaSubsamplingCosited = 0x7,
    }
}
