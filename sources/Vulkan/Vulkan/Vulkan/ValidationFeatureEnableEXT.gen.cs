// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkValidationFeatureEnableEXT")]
[SupportedApiProfile("vulkan")]
public enum ValidationFeatureEnableEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    GpuAssistedEXT = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    GpuAssistedReserveBindingSlotEXT = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    BestPracticesEXT = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    DebugPrintfEXT = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    SynchronizationValidationEXT = 4,
}
