// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceDiagnosticsConfigFlagsNV")]
[Flags]
public enum DeviceDiagnosticsConfigFlagsNV : uint
{
    None = 0x0,

    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
    EnableShaderDebugInfoBit = 0x1,

    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
    EnableResourceTrackingBit = 0x2,

    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
    EnableAutomaticCheckpointsBit = 0x4,

    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV")]
    EnableShaderErrorReportingBit = 0x8,
}
