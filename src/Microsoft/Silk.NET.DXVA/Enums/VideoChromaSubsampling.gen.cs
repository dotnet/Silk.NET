// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_VideoChromaSubsampling")]
    public enum VideoChromaSubsampling : int
    {
        [Obsolete("Deprecated in favour of \"Shift\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsamplingShift")]
        VideoChromaSubsamplingShift = 0x8,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsamplingMask")]
        VideoChromaSubsamplingMask = 0xF00,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Unknown")]
        VideoChromaSubsamplingUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"ProgressiveChroma\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_ProgressiveChroma")]
        VideoChromaSubsamplingProgressiveChroma = 0x8,
        [Obsolete("Deprecated in favour of \"HorizontallyCosited\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Horizontally_Cosited")]
        VideoChromaSubsamplingHorizontallyCosited = 0x4,
        [Obsolete("Deprecated in favour of \"VerticallyCosited\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Vertically_Cosited")]
        VideoChromaSubsamplingVerticallyCosited = 0x2,
        [Obsolete("Deprecated in favour of \"VerticallyAlignedChromaPlanes\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Vertically_AlignedChromaPlanes")]
        VideoChromaSubsamplingVerticallyAlignedChromaPlanes = 0x1,
        [Obsolete("Deprecated in favour of \"Mpeg2\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_MPEG2")]
        VideoChromaSubsamplingMpeg2 = 0x5,
        [Obsolete("Deprecated in favour of \"Mpeg1\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_MPEG1")]
        VideoChromaSubsamplingMpeg1 = 0x1,
        [Obsolete("Deprecated in favour of \"DVPal\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_DV_PAL")]
        VideoChromaSubsamplingDVPal = 0x6,
        [Obsolete("Deprecated in favour of \"Cosited\"")]
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Cosited")]
        VideoChromaSubsamplingCosited = 0x7,
        [NativeName("Name", "DXVA_VideoChromaSubsamplingShift")]
        Shift = 0x8,
        [NativeName("Name", "DXVA_VideoChromaSubsamplingMask")]
        Mask = 0xF00,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_ProgressiveChroma")]
        ProgressiveChroma = 0x8,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Horizontally_Cosited")]
        HorizontallyCosited = 0x4,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Vertically_Cosited")]
        VerticallyCosited = 0x2,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Vertically_AlignedChromaPlanes")]
        VerticallyAlignedChromaPlanes = 0x1,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_MPEG2")]
        Mpeg2 = 0x5,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_MPEG1")]
        Mpeg1 = 0x1,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_DV_PAL")]
        DVPal = 0x6,
        [NativeName("Name", "DXVA_VideoChromaSubsampling_Cosited")]
        Cosited = 0x7,
    }
}
