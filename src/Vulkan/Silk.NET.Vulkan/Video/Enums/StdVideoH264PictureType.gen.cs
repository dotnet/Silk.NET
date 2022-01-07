// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264PictureType")]
    public enum StdVideoH264PictureType : int
    {
        [NativeName("Name", "STD_VIDEO_H264_PICTURE_TYPE_P")]
        StdVideoH264PictureTypeP = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_PICTURE_TYPE_B")]
        StdVideoH264PictureTypeB = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_PICTURE_TYPE_I")]
        StdVideoH264PictureTypeI = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_PICTURE_TYPE_IDR")]
        StdVideoH264PictureTypeIdr = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_PICTURE_TYPE_INVALID")]
        StdVideoH264PictureTypeInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_PICTURE_TYPE_MAX_ENUM")]
        StdVideoH264PictureTypeMaxEnum = 0x7FFFFFFF,
    }
}
