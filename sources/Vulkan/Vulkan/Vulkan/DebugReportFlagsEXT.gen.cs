// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum DebugReportFlagsEXT : uint
{
    None = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    InformationBitEXT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    WarningBitEXT = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    PerformanceWarningBitEXT = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    ErrorBitEXT = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugBitEXT = 0x00000010,
}
