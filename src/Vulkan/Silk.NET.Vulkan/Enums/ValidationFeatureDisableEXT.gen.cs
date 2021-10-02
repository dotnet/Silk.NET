// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationFeatureDisableEXT")]
    public enum ValidationFeatureDisableEXT : int
    {
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_ALL_EXT")]
        ValidationFeatureDisableAllExt = 0,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT")]
        ValidationFeatureDisableShadersExt = 1,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT")]
        ValidationFeatureDisableThreadSafetyExt = 2,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT")]
        ValidationFeatureDisableApiParametersExt = 3,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT")]
        ValidationFeatureDisableObjectLifetimesExt = 4,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT")]
        ValidationFeatureDisableCoreChecksExt = 5,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT")]
        ValidationFeatureDisableUniqueHandlesExt = 6,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT")]
        ValidationFeatureDisableShaderValidationCacheExt = 7,
    }
}
