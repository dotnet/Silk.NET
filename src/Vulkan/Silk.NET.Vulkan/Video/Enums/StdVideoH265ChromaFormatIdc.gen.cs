// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH265ChromaFormatIdc")]
    public enum StdVideoH265ChromaFormatIdc : int
    {
        [Obsolete("Deprecated in favour of \"IdcMonochrome\"")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_MONOCHROME")]
        StdVideoH265ChromaFormatIdcMonochrome = 0x0,
        [Obsolete("Deprecated in favour of \"Idc420\"")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_420")]
        StdVideoH265ChromaFormatIdc420 = 0x1,
        [Obsolete("Deprecated in favour of \"Idc422\"")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_422")]
        StdVideoH265ChromaFormatIdc422 = 0x2,
        [Obsolete("Deprecated in favour of \"Idc444\"")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_444")]
        StdVideoH265ChromaFormatIdc444 = 0x3,
        [Obsolete("Deprecated in favour of \"IdcInvalid\"")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_INVALID")]
        StdVideoH265ChromaFormatIdcInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"IdcMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_MAX_ENUM")]
        StdVideoH265ChromaFormatIdcMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_MONOCHROME")]
        IdcMonochrome = 0x0,
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_420")]
        Idc420 = 0x1,
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_422")]
        Idc422 = 0x2,
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_444")]
        Idc444 = 0x3,
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_INVALID")]
        IdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_CHROMA_FORMAT_IDC_MAX_ENUM")]
        IdcMaxEnum = 0x7FFFFFFF,
    }
}
