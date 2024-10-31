// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDepthClampModeEXT")]
    public enum DepthClampModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"ViewportRangeExt\"")]
        [NativeName("Name", "VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT")]
        DepthClampModeViewportRangeExt = 0,
        [Obsolete("Deprecated in favour of \"UserDefinedRangeExt\"")]
        [NativeName("Name", "VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT")]
        DepthClampModeUserDefinedRangeExt = 1,
        [NativeName("Name", "VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT")]
        ViewportRangeExt = 0,
        [NativeName("Name", "VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT")]
        UserDefinedRangeExt = 1,
    }
}
