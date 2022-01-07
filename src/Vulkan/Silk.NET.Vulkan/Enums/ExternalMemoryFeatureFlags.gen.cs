// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalMemoryFeatureFlags")]
    public enum ExternalMemoryFeatureFlags : int
    {
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT")]
        ExternalMemoryFeatureDedicatedOnlyBit = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT")]
        ExternalMemoryFeatureExportableBit = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT")]
        ExternalMemoryFeatureImportableBit = 4,
    }
}
