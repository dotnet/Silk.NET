// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkValidationFeatureDisableEXT")]
[SupportedApiProfile("vulkan")]
public enum ValidationFeatureDisableExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_ALL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    Allext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    Shadersext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ThreadSafetyext = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ApiParametersext = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ObjectLifetimesext = 4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    CoreChecksext = 5,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    UniqueHandlesext = 6,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ShaderValidationCacheext = 7,
}
