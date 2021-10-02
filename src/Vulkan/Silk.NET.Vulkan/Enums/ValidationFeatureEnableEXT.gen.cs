// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationFeatureEnableEXT")]
    public enum ValidationFeatureEnableEXT : int
    {
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
        ValidationFeatureEnableGpuAssistedExt = 0,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
        ValidationFeatureEnableGpuAssistedReserveBindingSlotExt = 1,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
        ValidationFeatureEnableBestPracticesExt = 2,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
        ValidationFeatureEnableDebugPrintfExt = 3,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT")]
        ValidationFeatureEnableSynchronizationValidationExt = 4,
    }
}
