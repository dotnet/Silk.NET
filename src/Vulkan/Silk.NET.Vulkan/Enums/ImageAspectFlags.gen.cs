// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageAspectFlags")]
    public enum ImageAspectFlags : int
    {
        [Obsolete("Deprecated in favour of \"ColorBit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_COLOR_BIT")]
        ImageAspectColorBit = 1,
        [Obsolete("Deprecated in favour of \"DepthBit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_DEPTH_BIT")]
        ImageAspectDepthBit = 2,
        [Obsolete("Deprecated in favour of \"StencilBit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_STENCIL_BIT")]
        ImageAspectStencilBit = 4,
        [Obsolete("Deprecated in favour of \"MetadataBit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_METADATA_BIT")]
        ImageAspectMetadataBit = 8,
        [Obsolete("Deprecated in favour of \"Plane0BitKhr\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_0_BIT_KHR")]
        ImageAspectPlane0BitKhr = 16,
        [Obsolete("Deprecated in favour of \"Plane1BitKhr\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_1_BIT_KHR")]
        ImageAspectPlane1BitKhr = 32,
        [Obsolete("Deprecated in favour of \"Plane2BitKhr\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_2_BIT_KHR")]
        ImageAspectPlane2BitKhr = 64,
        [Obsolete("Deprecated in favour of \"MemoryPlane0BitExt\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT")]
        ImageAspectMemoryPlane0BitExt = 128,
        [Obsolete("Deprecated in favour of \"MemoryPlane1BitExt\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT")]
        ImageAspectMemoryPlane1BitExt = 256,
        [Obsolete("Deprecated in favour of \"MemoryPlane2BitExt\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT")]
        ImageAspectMemoryPlane2BitExt = 512,
        [Obsolete("Deprecated in favour of \"MemoryPlane3BitExt\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT")]
        ImageAspectMemoryPlane3BitExt = 1024,
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_NONE_KHR")]
        ImageAspectNoneKhr = 0,
        [Obsolete("Deprecated in favour of \"Plane0Bit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_0_BIT")]
        ImageAspectPlane0Bit = 16,
        [Obsolete("Deprecated in favour of \"Plane1Bit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_1_BIT")]
        ImageAspectPlane1Bit = 32,
        [Obsolete("Deprecated in favour of \"Plane2Bit\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_2_BIT")]
        ImageAspectPlane2Bit = 64,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_IMAGE_ASPECT_NONE")]
        ImageAspectNone = 0,
        [NativeName("Name", "VK_IMAGE_ASPECT_COLOR_BIT")]
        ColorBit = 1,
        [NativeName("Name", "VK_IMAGE_ASPECT_DEPTH_BIT")]
        DepthBit = 2,
        [NativeName("Name", "VK_IMAGE_ASPECT_STENCIL_BIT")]
        StencilBit = 4,
        [NativeName("Name", "VK_IMAGE_ASPECT_METADATA_BIT")]
        MetadataBit = 8,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_0_BIT_KHR")]
        Plane0BitKhr = 16,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_1_BIT_KHR")]
        Plane1BitKhr = 32,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_2_BIT_KHR")]
        Plane2BitKhr = 64,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT")]
        MemoryPlane0BitExt = 128,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT")]
        MemoryPlane1BitExt = 256,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT")]
        MemoryPlane2BitExt = 512,
        [NativeName("Name", "VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT")]
        MemoryPlane3BitExt = 1024,
        [NativeName("Name", "VK_IMAGE_ASPECT_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_0_BIT")]
        Plane0Bit = 16,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_1_BIT")]
        Plane1Bit = 32,
        [NativeName("Name", "VK_IMAGE_ASPECT_PLANE_2_BIT")]
        Plane2Bit = 64,
        [NativeName("Name", "VK_IMAGE_ASPECT_NONE")]
        None = 0,
    }
}
