// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264ModificationOfPicNumsIdc")]
    public enum StdVideoH264ModificationOfPicNumsIdc : int
    {
        [NativeName("Name", "std_video_h264_modification_of_pic_nums_idc_short_term_subtract")]
        StdVideoH264ModificationOfPicNumsIdcShortTermSubtract = 0x0,
        [NativeName("Name", "std_video_h264_modification_of_pic_nums_idc_short_term_add")]
        StdVideoH264ModificationOfPicNumsIdcShortTermAdd = 0x1,
        [NativeName("Name", "std_video_h264_modification_of_pic_nums_idc_long_term")]
        StdVideoH264ModificationOfPicNumsIdcLongTerm = 0x2,
        [NativeName("Name", "std_video_h264_modification_of_pic_nums_idc_end")]
        StdVideoH264ModificationOfPicNumsIdcEnd = 0x3,
        [NativeName("Name", "std_video_h264_modification_of_pic_nums_idc_invalid")]
        StdVideoH264ModificationOfPicNumsIdcInvalid = 0x7FFFFFFF,
    }
}
