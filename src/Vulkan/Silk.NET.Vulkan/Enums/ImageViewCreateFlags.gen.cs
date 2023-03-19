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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapDynamicBitExt\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT")]
        ImageViewCreateFragmentDensityMapDynamicBitExt = 1,
        [Obsolete("Deprecated in favour of \"DescriptorBufferCaptureReplayBitExt\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        ImageViewCreateDescriptorBufferCaptureReplayBitExt = 4,
        [Obsolete("Deprecated in favour of \"FragmentDensityMapDeferredBitExt\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT")]
        ImageViewCreateFragmentDensityMapDeferredBitExt = 2,
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT")]
        FragmentDensityMapDynamicBitExt = 1,
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
        DescriptorBufferCaptureReplayBitExt = 4,
        [NativeName("Name", "VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT")]
        FragmentDensityMapDeferredBitExt = 2,
    }
}
