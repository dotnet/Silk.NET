// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeContentFlagsKHR")]
    public enum VideoEncodeContentFlagsKHR : int
    {
        [Obsolete("Deprecated in favour of \"DefaultKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR")]
        VideoEncodeContentDefaultKhr = 0,
        [Obsolete("Deprecated in favour of \"CameraBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR")]
        VideoEncodeContentCameraBitKhr = 1,
        [Obsolete("Deprecated in favour of \"DesktopBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR")]
        VideoEncodeContentDesktopBitKhr = 2,
        [Obsolete("Deprecated in favour of \"RenderedBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR")]
        VideoEncodeContentRenderedBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR")]
        DefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR")]
        CameraBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR")]
        DesktopBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR")]
        RenderedBitKhr = 4,
    }
}
