// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264DisableDeblockingFilterIdc")]
    public enum StdVideoH264DisableDeblockingFilterIdc : int
    {
        [NativeName("Name", "std_video_h264_disable_deblocking_filter_idc_disabled")]
        StdVideoH264DisableDeblockingFilterIdcDisabled = 0x0,
        [NativeName("Name", "std_video_h264_disable_deblocking_filter_idc_enabled")]
        StdVideoH264DisableDeblockingFilterIdcEnabled = 0x1,
        [NativeName("Name", "std_video_h264_disable_deblocking_filter_idc_partial")]
        StdVideoH264DisableDeblockingFilterIdcPartial = 0x2,
        [NativeName("Name", "std_video_h264_disable_deblocking_filter_idc_invalid")]
        StdVideoH264DisableDeblockingFilterIdcInvalid = 0x7FFFFFFF,
    }
}
