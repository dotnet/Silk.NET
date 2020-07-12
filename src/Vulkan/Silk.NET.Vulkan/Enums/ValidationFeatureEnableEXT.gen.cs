// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationFeatureEnableEXT")]
    public enum ValidationFeatureEnableEXT
    {
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
        ValidationFeatureEnableGpuAssistedExt = 0,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
        ValidationFeatureEnableGpuAssistedReserveBindingSlotExt = 1,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
        ValidationFeatureEnableBestPracticesExt = 2,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
        ValidationFeatureEnableDebugPrintfExt = 3,
    }
}
