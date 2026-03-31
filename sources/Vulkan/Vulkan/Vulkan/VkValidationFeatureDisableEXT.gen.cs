// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkValidationFeatureDisableEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkValidationFeatureDisableEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_ALL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableAll = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableShaders = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableThreadSafety = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableApiParameters = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableObjectLifetimes = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableCoreChecks = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableUniqueHandles = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableShaderValidationCache = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_VALIDATION_FEATURE_DISABLE_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    VkValidationFeatureDisableMaxEnum = 0x7FFFFFFF,
}
