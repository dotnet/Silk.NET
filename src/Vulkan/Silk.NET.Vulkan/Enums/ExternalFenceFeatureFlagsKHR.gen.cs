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
    [NativeName("Name", "VkExternalFenceFeatureFlagsKHR")]
    public enum ExternalFenceFeatureFlagsKHR
    {
        [NativeName("Name", "VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT")]
        ExternalFenceFeatureExportableBit = 1,
        [NativeName("Name", "VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT")]
        ExternalFenceFeatureImportableBit = 2,
    }
}
