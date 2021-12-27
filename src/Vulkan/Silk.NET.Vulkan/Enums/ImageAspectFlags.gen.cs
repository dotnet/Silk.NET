// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkImageAspectFlags")]
    public enum ImageAspectFlags : int
    {
        [NativeName("Name", "VK_IMAGE_ASPECT_COLOR_BIT")]
        ImageAspectColorBit = 1,
        [NativeName("Name", "VK_IMAGE_ASPECT_DEPTH_BIT")]
        ImageAspectDepthBit = 2,
        [NativeName("Name", "VK_IMAGE_ASPECT_STENCIL_BIT")]
        ImageAspectStencilBit = 4,
        [NativeName("Name", "VK_IMAGE_ASPECT_METADATA_BIT")]
        ImageAspectMetadataBit = 8,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_0_BIT_KHR")]
        ImageAspectPlane0BitKhr = 16,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_1_BIT_KHR")]
        ImageAspectPlane1BitKhr = 32,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_2_BIT_KHR")]
        ImageAspectPlane2BitKhr = 64,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT")]
        ImageAspectMemoryPlane0BitExt = 128,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT")]
        ImageAspectMemoryPlane1BitExt = 256,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT")]
        ImageAspectMemoryPlane2BitExt = 512,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT")]
        ImageAspectMemoryPlane3BitExt = 1024,
        [NativeName("Name", "VK_IMAGE_ASPECT_NONE_KHR")]
        ImageAspectNoneKhr = 0,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_0_BIT")]
        ImageAspectPlane0Bit = 16,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_1_BIT")]
        ImageAspectPlane1Bit = 32,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_2_BIT")]
        ImageAspectPlane2Bit = 64,
    }
}
