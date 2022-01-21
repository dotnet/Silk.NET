// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264PocType")]
    public enum StdVideoH264PocType : int
    {
        [NativeName("Name", "STD_VIDEO_H264_POC_TYPE_0")]
        StdVideoH264PocType0 = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_POC_TYPE_1")]
        StdVideoH264PocType1 = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_POC_TYPE_2")]
        StdVideoH264PocType2 = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_POC_TYPE_INVALID")]
        StdVideoH264PocTypeInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_POC_TYPE_MAX_ENUM")]
        StdVideoH264PocTypeMaxEnum = 0x7FFFFFFF,
    }
}
