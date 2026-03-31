// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkDebugReportFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkDebugReportFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportInformationBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportWarningBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportPerformanceWarningBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_ERROR_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportErrorBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportDebugBit = 0x00000010,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_REPORT_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    VkDebugReportFlagBitsMaxEnum = 0x7FFFFFFF,
}
