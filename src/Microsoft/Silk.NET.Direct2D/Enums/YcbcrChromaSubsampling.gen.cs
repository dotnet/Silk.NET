// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING")]
    public enum YcbcrChromaSubsampling : int
    {
        [Obsolete("Deprecated in favour of \"SubsamplingAuto\"")]
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO")]
        YcbcrChromaSubsamplingAuto = 0x0,
        [Obsolete("Deprecated in favour of \"Subsampling420\"")]
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_420")]
        YcbcrChromaSubsampling420 = 0x1,
        [Obsolete("Deprecated in favour of \"Subsampling422\"")]
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_422")]
        YcbcrChromaSubsampling422 = 0x2,
        [Obsolete("Deprecated in favour of \"Subsampling444\"")]
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_444")]
        YcbcrChromaSubsampling444 = 0x3,
        [Obsolete("Deprecated in favour of \"Subsampling440\"")]
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_440")]
        YcbcrChromaSubsampling440 = 0x4,
        [Obsolete("Deprecated in favour of \"SubsamplingForceDword\"")]
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_FORCE_DWORD")]
        YcbcrChromaSubsamplingForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO")]
        SubsamplingAuto = 0x0,
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_420")]
        Subsampling420 = 0x1,
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_422")]
        Subsampling422 = 0x2,
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_444")]
        Subsampling444 = 0x3,
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_440")]
        Subsampling440 = 0x4,
        [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING_FORCE_DWORD")]
        SubsamplingForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
