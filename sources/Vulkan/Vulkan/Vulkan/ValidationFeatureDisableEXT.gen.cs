// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkValidationFeatureDisableEXT")]
[SupportedApiProfile("vulkan")]
public enum ValidationFeatureDisableEXT : uint
{
    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_ALL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    AllEXT = 0,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ShadersEXT = 1,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ThreadSafetyEXT = 2,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ApiParametersEXT = 3,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ObjectLifetimesEXT = 4,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    CoreChecksEXT = 5,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    UniqueHandlesEXT = 6,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ShaderValidationCacheEXT = 7,
}
