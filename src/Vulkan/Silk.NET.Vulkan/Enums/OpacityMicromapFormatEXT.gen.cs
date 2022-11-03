// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkOpacityMicromapFormatEXT")]
    public enum OpacityMicromapFormatEXT : int
    {
        [Obsolete("Deprecated in favour of \"Format2StateExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT")]
        OpacityMicromapFormat2StateExt = 1,
        [Obsolete("Deprecated in favour of \"Format4StateExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT")]
        OpacityMicromapFormat4StateExt = 2,
        [NativeName("Name", "VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT")]
        Format2StateExt = 1,
        [NativeName("Name", "VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT")]
        Format4StateExt = 2,
    }
}
