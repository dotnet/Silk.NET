// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH265SliceType")]
    public enum StdVideoH265SliceType : int
    {
        [NativeName("Name", "std_video_h265_slice_type_b")]
        StdVideoH265SliceTypeB = 0x0,
        [NativeName("Name", "std_video_h265_slice_type_p")]
        StdVideoH265SliceTypeP = 0x1,
        [NativeName("Name", "std_video_h265_slice_type_i")]
        StdVideoH265SliceTypeI = 0x2,
        [NativeName("Name", "std_video_h265_slice_type_invalid")]
        StdVideoH265SliceTypeInvalid = 0x7FFFFFFF,
    }
}
