// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ResolveImageFlagsKHR : uint
{
    None = 0x0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10+VK_KHR_copy_commands2", "VK_KHR_maintenance10+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    SkipTransferFunctionBitKHR = 0x1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10+VK_KHR_copy_commands2", "VK_KHR_maintenance10+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    EnableTransferFunctionBitKHR = 0x2,
}
