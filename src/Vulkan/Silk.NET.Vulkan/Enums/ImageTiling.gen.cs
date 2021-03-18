// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageTiling")]
    public enum ImageTiling : int
    {
        [NativeName("Name", "VK_IMAGE_TILING_OPTIMAL")]
        Optimal = 0,
        [NativeName("Name", "VK_IMAGE_TILING_LINEAR")]
        Linear = 1,
        [NativeName("Name", "VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT")]
        DrmFormatModifierExt = 1000158000,
    }
}
