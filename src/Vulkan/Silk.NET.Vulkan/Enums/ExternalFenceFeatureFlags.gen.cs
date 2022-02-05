// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalFenceFeatureFlags")]
    public enum ExternalFenceFeatureFlags : int
    {
        [NativeName("Name", "VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT")]
        ExternalFenceFeatureExportableBit = 1,
        [NativeName("Name", "VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT")]
        ExternalFenceFeatureImportableBit = 2,
    }
}
