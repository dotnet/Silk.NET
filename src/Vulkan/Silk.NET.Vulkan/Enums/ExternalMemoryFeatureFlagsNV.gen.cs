// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkExternalMemoryFeatureFlagsNV")]
    public enum ExternalMemoryFeatureFlagsNV : int
    {
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV")]
        ExternalMemoryFeatureDedicatedOnlyBitNV = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV")]
        ExternalMemoryFeatureExportableBitNV = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV")]
        ExternalMemoryFeatureImportableBitNV = 4,
    }
}
