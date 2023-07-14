// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_YCBCR_CHROMA_SUBSAMPLING")]
    public enum YcbcrChromaSubsampling : int
    {
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
