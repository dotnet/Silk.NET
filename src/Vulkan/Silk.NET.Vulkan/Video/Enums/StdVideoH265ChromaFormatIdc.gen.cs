// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH265ChromaFormatIdc")]
    public enum StdVideoH265ChromaFormatIdc : int
    {
        [NativeName("Name", "std_video_h265_chroma_format_idc_monochrome")]
        StdVideoH265ChromaFormatIdcMonochrome = 0x0,
        [NativeName("Name", "std_video_h265_chroma_format_idc_420")]
        StdVideoH265ChromaFormatIdc420 = 0x1,
        [NativeName("Name", "std_video_h265_chroma_format_idc_422")]
        StdVideoH265ChromaFormatIdc422 = 0x2,
        [NativeName("Name", "std_video_h265_chroma_format_idc_444")]
        StdVideoH265ChromaFormatIdc444 = 0x3,
    }
}
