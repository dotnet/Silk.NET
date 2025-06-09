// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkValidationFeatureDisableEXT : uint
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = 5,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = 6,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT = 7,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VK_VALIDATION_FEATURE_DISABLE_MAX_ENUM_EXT = 0x7FFFFFFF,
}
