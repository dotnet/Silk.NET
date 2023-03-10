// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkValidationFeatureEnableEXT")]
    public enum ValidationFeatureEnableEXT : int
    {
        [Obsolete("Deprecated in favour of \"GpuAssistedExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
        ValidationFeatureEnableGpuAssistedExt = 0,
        [Obsolete("Deprecated in favour of \"GpuAssistedReserveBindingSlotExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
        ValidationFeatureEnableGpuAssistedReserveBindingSlotExt = 1,
        [Obsolete("Deprecated in favour of \"BestPracticesExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
        ValidationFeatureEnableBestPracticesExt = 2,
        [Obsolete("Deprecated in favour of \"DebugPrintfExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
        ValidationFeatureEnableDebugPrintfExt = 3,
        [Obsolete("Deprecated in favour of \"SynchronizationValidationExt\"")]
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT")]
        ValidationFeatureEnableSynchronizationValidationExt = 4,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT")]
        GpuAssistedExt = 0,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT")]
        GpuAssistedReserveBindingSlotExt = 1,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT")]
        BestPracticesExt = 2,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT")]
        DebugPrintfExt = 3,
        [NativeName("Name", "VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT")]
        SynchronizationValidationExt = 4,
    }
}
