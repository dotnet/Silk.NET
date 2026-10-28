// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageAspectFlags")]
[Flags]
public enum ImageAspectFlags : uint
{
    [NativeName("VK_IMAGE_ASPECT_COLOR_BIT")]
    ColorBit = 0x1,

    [NativeName("VK_IMAGE_ASPECT_DEPTH_BIT")]
    DepthBit = 0x2,

    [NativeName("VK_IMAGE_ASPECT_STENCIL_BIT")]
    StencilBit = 0x4,

    [NativeName("VK_IMAGE_ASPECT_METADATA_BIT")]
    MetadataBit = 0x8,

    [NativeName("VK_IMAGE_ASPECT_PLANE_0_BIT")]
    Plane0Bit = 0x10,

    [NativeName("VK_IMAGE_ASPECT_PLANE_1_BIT")]
    Plane1Bit = 0x20,

    [NativeName("VK_IMAGE_ASPECT_PLANE_2_BIT")]
    Plane2Bit = 0x40,

    [NativeName("VK_IMAGE_ASPECT_NONE")]
    None = 0x0,

    [NativeName("VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT")]
    MemoryPlane0BitEXT = 0x80,

    [NativeName("VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT")]
    MemoryPlane1BitEXT = 0x100,

    [NativeName("VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT")]
    MemoryPlane2BitEXT = 0x200,

    [NativeName("VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT")]
    MemoryPlane3BitEXT = 0x400,

    [NativeName("VK_IMAGE_ASPECT_PLANE_0_BIT_KHR")]
    Plane0BitKHR = Plane0Bit,

    [NativeName("VK_IMAGE_ASPECT_PLANE_1_BIT_KHR")]
    Plane1BitKHR = Plane1Bit,

    [NativeName("VK_IMAGE_ASPECT_PLANE_2_BIT_KHR")]
    Plane2BitKHR = Plane2Bit,

    [NativeName("VK_IMAGE_ASPECT_NONE_KHR")]
    NoneKHR = None,
}
