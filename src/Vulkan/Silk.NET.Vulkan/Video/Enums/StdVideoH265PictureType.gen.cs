// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH265PictureType")]
    public enum StdVideoH265PictureType : int
    {
        [NativeName("Name", "STD_VIDEO_H265_PICTURE_TYPE_P")]
        StdVideoH265PictureTypeP = 0x0,
        [NativeName("Name", "STD_VIDEO_H265_PICTURE_TYPE_B")]
        StdVideoH265PictureTypeB = 0x1,
        [NativeName("Name", "STD_VIDEO_H265_PICTURE_TYPE_I")]
        StdVideoH265PictureTypeI = 0x2,
        [NativeName("Name", "STD_VIDEO_H265_PICTURE_TYPE_IDR")]
        StdVideoH265PictureTypeIdr = 0x3,
        [NativeName("Name", "STD_VIDEO_H265_PICTURE_TYPE_INVALID")]
        StdVideoH265PictureTypeInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_PICTURE_TYPE_MAX_ENUM")]
        StdVideoH265PictureTypeMaxEnum = 0x7FFFFFFF,
    }
}
