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
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsamplingMask")]
        DXVA2VideoChromaSubsamplingMask = 0xF,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Unknown")]
        DXVA2VideoChromaSubsamplingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"ProgressiveChroma\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_ProgressiveChroma")]
        DXVA2VideoChromaSubsamplingProgressiveChroma = 0x8,
        [Obsolete("Deprecated in favour of \"HorizontallyCosited\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Horizontally_Cosited")]
        DXVA2VideoChromaSubsamplingHorizontallyCosited = 0x4,
        [Obsolete("Deprecated in favour of \"VerticallyCosited\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_Cosited")]
        DXVA2VideoChromaSubsamplingVerticallyCosited = 0x2,
        [Obsolete("Deprecated in favour of \"VerticallyAlignedChromaPlanes\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_AlignedChromaPlanes")]
        DXVA2VideoChromaSubsamplingVerticallyAlignedChromaPlanes = 0x1,
        [Obsolete("Deprecated in favour of \"Mpeg2\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG2")]
        DXVA2VideoChromaSubsamplingMpeg2 = 0x5,
        [Obsolete("Deprecated in favour of \"Mpeg1\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG1")]
        DXVA2VideoChromaSubsamplingMpeg1 = 0x1,
        [Obsolete("Deprecated in favour of \"DVPal\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_DV_PAL")]
        DXVA2VideoChromaSubsamplingDVPal = 0x6,
        [Obsolete("Deprecated in favour of \"Cosited\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Cosited")]
        DXVA2VideoChromaSubsamplingCosited = 0x7,
        [NativeName("Name", "DXVA2_VideoChromaSubsamplingMask")]
        Mask = 0xF,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_ProgressiveChroma")]
        ProgressiveChroma = 0x8,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Horizontally_Cosited")]
        HorizontallyCosited = 0x4,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_Cosited")]
        VerticallyCosited = 0x2,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_AlignedChromaPlanes")]
        VerticallyAlignedChromaPlanes = 0x1,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG2")]
        Mpeg2 = 0x5,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG1")]
        Mpeg1 = 0x1,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_DV_PAL")]
        DVPal = 0x6,
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Cosited")]
        Cosited = 0x7,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsamplingMask")]
        VideoChromaSubsamplingMask = 0xF,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Unknown")]
        VideoChromaSubsamplingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"ProgressiveChroma\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_ProgressiveChroma")]
        VideoChromaSubsamplingProgressiveChroma = 0x8,
        [Obsolete("Deprecated in favour of \"HorizontallyCosited\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Horizontally_Cosited")]
        VideoChromaSubsamplingHorizontallyCosited = 0x4,
        [Obsolete("Deprecated in favour of \"VerticallyCosited\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_Cosited")]
        VideoChromaSubsamplingVerticallyCosited = 0x2,
        [Obsolete("Deprecated in favour of \"VerticallyAlignedChromaPlanes\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Vertically_AlignedChromaPlanes")]
        VideoChromaSubsamplingVerticallyAlignedChromaPlanes = 0x1,
        [Obsolete("Deprecated in favour of \"Mpeg2\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG2")]
        VideoChromaSubsamplingMpeg2 = 0x5,
        [Obsolete("Deprecated in favour of \"Mpeg1\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_MPEG1")]
        VideoChromaSubsamplingMpeg1 = 0x1,
        [Obsolete("Deprecated in favour of \"DVPal\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_DV_PAL")]
        VideoChromaSubsamplingDVPal = 0x6,
        [Obsolete("Deprecated in favour of \"Cosited\"")]
        [NativeName("Name", "DXVA2_VideoChromaSubsampling_Cosited")]
        VideoChromaSubsamplingCosited = 0x7,
    }
}
