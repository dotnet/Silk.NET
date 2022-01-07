// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageViewCreateFlags")]
    public enum ImageViewCreateFlags : int
    {
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT")]
        ImageViewCreateFragmentDensityMapDynamicBitExt = 1,
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT")]
        ImageViewCreateFragmentDensityMapDeferredBitExt = 2,
    }
}
