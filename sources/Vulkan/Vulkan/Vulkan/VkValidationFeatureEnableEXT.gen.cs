// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkValidationFeatureEnableEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_ENABLE_MAX_ENUM_EXT = 0x7FFFFFFF,
}
