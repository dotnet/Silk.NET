// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264CreateFlagsEXT")]
    public enum VideoEncodeH264CreateFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CREATE_DEFAULT_EXT")]
        VideoEncodeH264CreateDefaultExt = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_CREATE_RESERVED_0_BIT_EXT")]
        VideoEncodeH264CreateReserved0BitExt = 1,
    }
}
