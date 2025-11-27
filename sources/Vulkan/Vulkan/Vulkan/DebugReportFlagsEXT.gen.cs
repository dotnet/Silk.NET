// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugReportFlagBitsEXT")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum DebugReportFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    InformationBitEXT = 0x1,

    [NativeName("VK_DEBUG_REPORT_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    WarningBitEXT = 0x2,

    [NativeName("VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PerformanceWarningBitEXT = 0x4,

    [NativeName("VK_DEBUG_REPORT_ERROR_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ErrorBitEXT = 0x8,

    [NativeName("VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugBitEXT = 0x10,
}
