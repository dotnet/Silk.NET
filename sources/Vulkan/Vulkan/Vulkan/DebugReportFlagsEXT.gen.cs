// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugReportFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DebugReportFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    InformationBit = 0x1,

    [NativeName("VK_DEBUG_REPORT_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    WarningBit = 0x2,

    [NativeName("VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PerformanceWarningBit = 0x4,

    [NativeName("VK_DEBUG_REPORT_ERROR_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ErrorBit = 0x8,

    [NativeName("VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugBit = 0x10,
}
