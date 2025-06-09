// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDebugReportFlagsEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_INFORMATION_BIT_EXT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_WARNING_BIT_EXT = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_ERROR_BIT_EXT = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_DEBUG_BIT_EXT = 0x00000010,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VK_DEBUG_REPORT_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
