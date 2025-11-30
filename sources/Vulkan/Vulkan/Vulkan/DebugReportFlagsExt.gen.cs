// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDebugReportFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DebugReportFlagsExt : uint
{
    None = 0x0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_INFORMATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    InformationBitext = 0x1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    WarningBitext = 0x2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PerformanceWarningBitext = 0x4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_ERROR_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ErrorBitext = 0x8,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_REPORT_DEBUG_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugBitext = 0x10,
}
