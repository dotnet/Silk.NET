// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkValidationFeatureEnableEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkValidationFeatureEnableEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureEnableGpuAssisted = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureEnableGpuAssistedReserveBindingSlot = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureEnableBestPractices = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureEnableDebugPrintf = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureEnableSynchronizationValidation = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_ENABLE_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureEnableMaxEnum = 0x7FFFFFFF,
}
