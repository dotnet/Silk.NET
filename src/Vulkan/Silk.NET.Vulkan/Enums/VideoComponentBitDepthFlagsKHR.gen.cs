// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoComponentBitDepthFlagsKHR")]
    public enum VideoComponentBitDepthFlagsKHR : int
    {
        [Obsolete("Deprecated in favour of \"DepthInvalidKhr\"")]
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR")]
        VideoComponentBitDepthInvalidKhr = 0,
        [Obsolete("Deprecated in favour of \"Depth8BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR")]
        VideoComponentBitDepth8BitKhr = 1,
        [Obsolete("Deprecated in favour of \"Depth10BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR")]
        VideoComponentBitDepth10BitKhr = 4,
        [Obsolete("Deprecated in favour of \"Depth12BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR")]
        VideoComponentBitDepth12BitKhr = 16,
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR")]
        DepthInvalidKhr = 0,
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR")]
        Depth8BitKhr = 1,
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR")]
        Depth10BitKhr = 4,
        [NativeName("Name", "VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR")]
        Depth12BitKhr = 16,
    }
}
