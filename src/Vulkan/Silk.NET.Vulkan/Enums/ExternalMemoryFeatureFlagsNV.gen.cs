// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalMemoryFeatureFlagsNV")]
    public enum ExternalMemoryFeatureFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DedicatedOnlyBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV")]
        ExternalMemoryFeatureDedicatedOnlyBitNV = 1,
        [Obsolete("Deprecated in favour of \"ExportableBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV")]
        ExternalMemoryFeatureExportableBitNV = 2,
        [Obsolete("Deprecated in favour of \"ImportableBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV")]
        ExternalMemoryFeatureImportableBitNV = 4,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV")]
        DedicatedOnlyBitNV = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV")]
        ExportableBitNV = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV")]
        ImportableBitNV = 4,
    }
}
