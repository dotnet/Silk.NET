// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationFeatureDisableEXT")]
    public enum ValidationFeatureDisableEXT
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
    }
}
