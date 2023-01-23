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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DedicatedOnlyBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT")]
        ExternalMemoryFeatureDedicatedOnlyBit = 1,
        [Obsolete("Deprecated in favour of \"ExportableBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT")]
        ExternalMemoryFeatureExportableBit = 2,
        [Obsolete("Deprecated in favour of \"ImportableBit\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT")]
        ExternalMemoryFeatureImportableBit = 4,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT")]
        DedicatedOnlyBit = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT")]
        ExportableBit = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT")]
        ImportableBit = 4,
    }
}
