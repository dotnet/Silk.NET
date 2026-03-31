// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkDebugUtilsMessageSeverityFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkDebugUtilsMessageSeverityFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageSeverityVerboseBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageSeverityInfoBit = 0x00000010,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageSeverityWarningBit = 0x00000100,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageSeverityErrorBit = 0x00001000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageSeverityFlagBitsMaxEnum = 0x7FFFFFFF,
}
