// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum AntiLagStageAMD : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    InputAMD = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    PresentAMD = 1,
}
