// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkValidationFeatureEnableEXT")]
public enum ValidationFeatureEnableEXT : uint
{
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
    GpuAssisted = 0,

    [NativeName("VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
    GpuAssistedReserveBindingSlot = 1,

    [NativeName("VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
    BestPractices = 2,

    [NativeName("VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
    DebugPrintf = 3,

    [NativeName("VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT")]
    SynchronizationValidation = 4,
}
