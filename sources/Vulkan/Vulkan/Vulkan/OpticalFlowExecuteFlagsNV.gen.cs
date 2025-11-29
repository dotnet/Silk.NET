// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkOpticalFlowExecuteFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum OpticalFlowExecuteFlagsNV : uint
{
    None = 0x0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    DisableTemporalHintsBitNV = 0x1,
}
