// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkCompositeAlphaFlagsKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COMPOSITE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
