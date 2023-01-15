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
        [Obsolete("Deprecated in favour of \"AllExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_ALL_EXT")]
        ValidationFeatureDisableAllExt = 0,
        [Obsolete("Deprecated in favour of \"ShadersExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT")]
        ValidationFeatureDisableShadersExt = 1,
        [Obsolete("Deprecated in favour of \"ThreadSafetyExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT")]
        ValidationFeatureDisableThreadSafetyExt = 2,
        [Obsolete("Deprecated in favour of \"ApiParametersExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT")]
        ValidationFeatureDisableApiParametersExt = 3,
        [Obsolete("Deprecated in favour of \"ObjectLifetimesExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT")]
        ValidationFeatureDisableObjectLifetimesExt = 4,
        [Obsolete("Deprecated in favour of \"CoreChecksExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT")]
        ValidationFeatureDisableCoreChecksExt = 5,
        [Obsolete("Deprecated in favour of \"UniqueHandlesExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT")]
        ValidationFeatureDisableUniqueHandlesExt = 6,
        [Obsolete("Deprecated in favour of \"ShaderValidationCacheExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT")]
        ValidationFeatureDisableShaderValidationCacheExt = 7,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_ALL_EXT")]
        AllExt = 0,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT")]
        ShadersExt = 1,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT")]
        ThreadSafetyExt = 2,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT")]
        ApiParametersExt = 3,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT")]
        ObjectLifetimesExt = 4,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT")]
        CoreChecksExt = 5,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT")]
        UniqueHandlesExt = 6,
        [NativeName("Name", "VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT")]
        ShaderValidationCacheExt = 7,
    }
}
