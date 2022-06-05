// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeFlagsKHR")]
    public enum VideoEncodeFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DefaultKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_DEFAULT_KHR")]
        VideoEncodeDefaultKhr = 0,
        [Obsolete("Deprecated in favour of \"Reserved0BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RESERVED_0_BIT_KHR")]
        VideoEncodeReserved0BitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_DEFAULT_KHR")]
        DefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_RESERVED_0_BIT_KHR")]
        Reserved0BitKhr = 1,
    }
}
