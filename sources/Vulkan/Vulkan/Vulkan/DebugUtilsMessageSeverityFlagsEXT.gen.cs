// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDebugUtilsMessageSeverityFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DebugUtilsMessageSeverityFlagsEXT : uint
{
    None = 0x0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VerboseBitEXT = 0x1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    InfoBitEXT = 0x10,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    WarningBitEXT = 0x100,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    ErrorBitEXT = 0x1000,
}
