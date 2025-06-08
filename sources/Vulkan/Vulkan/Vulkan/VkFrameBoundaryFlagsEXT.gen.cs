// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkFrameBoundaryFlagsEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_EXT_frame_boundary"])]
    VK_FRAME_BOUNDARY_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
