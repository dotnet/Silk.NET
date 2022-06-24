// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoDecodeH264FieldOrderCount")]
    public enum StdVideoDecodeH264FieldOrderCount : int
    {
        [Obsolete("Deprecated in favour of \"Top\"")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_TOP")]
        StdVideoDecodeH264FieldOrderCountTop = 0x0,
        [Obsolete("Deprecated in favour of \"Bottom\"")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_BOTTOM")]
        StdVideoDecodeH264FieldOrderCountBottom = 0x1,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_INVALID")]
        StdVideoDecodeH264FieldOrderCountInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_MAX_ENUM")]
        StdVideoDecodeH264FieldOrderCountMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_TOP")]
        Top = 0x0,
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_BOTTOM")]
        Bottom = 0x1,
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
