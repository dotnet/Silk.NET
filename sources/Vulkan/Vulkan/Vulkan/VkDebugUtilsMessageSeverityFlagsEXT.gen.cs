// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkDebugUtilsMessageSeverityFlagsEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = 0x00000010,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = 0x00000100,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = 0x00001000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VK_DEBUG_UTILS_MESSAGE_SEVERITY_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
