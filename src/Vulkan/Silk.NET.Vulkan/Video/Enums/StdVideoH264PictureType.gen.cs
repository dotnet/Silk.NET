// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264PictureType")]
    public enum StdVideoH264PictureType : int
    {
        [NativeName("Name", "std_video_h264_picture_type_i")]
        StdVideoH264PictureTypeI = 0x0,
        [NativeName("Name", "std_video_h264_picture_type_p")]
        StdVideoH264PictureTypeP = 0x1,
        [NativeName("Name", "std_video_h264_picture_type_b")]
        StdVideoH264PictureTypeB = 0x2,
        [NativeName("Name", "std_video_h264_picture_type_invalid")]
        StdVideoH264PictureTypeInvalid = 0x7FFFFFFF,
    }
}
