// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH265PictureType")]
    public enum StdVideoH265PictureType : int
    {
        [NativeName("Name", "std_video_h265_picture_type_i")]
        StdVideoH265PictureTypeI = 0x0,
        [NativeName("Name", "std_video_h265_picture_type_p")]
        StdVideoH265PictureTypeP = 0x1,
        [NativeName("Name", "std_video_h265_picture_type_b")]
        StdVideoH265PictureTypeB = 0x2,
        [NativeName("Name", "std_video_h265_picture_type_idr")]
        StdVideoH265PictureTypeIdr = 0x3,
        [NativeName("Name", "std_video_h265_picture_type_invalid")]
        StdVideoH265PictureTypeInvalid = 0x7FFFFFFF,
    }
}
