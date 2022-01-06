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
        [NativeName("Name", "std_video_h264_poc_type_0")]
        StdVideoH264PocType0 = 0x0,
        [NativeName("Name", "std_video_h264_poc_type_1")]
        StdVideoH264PocType1 = 0x1,
        [NativeName("Name", "std_video_h264_poc_type_2")]
        StdVideoH264PocType2 = 0x2,
        [NativeName("Name", "std_video_h264_poc_type_invalid")]
        StdVideoH264PocTypeInvalid = 0x7FFFFFFF,
    }
}
