// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkConservativeRasterizationModeEXT")]
    public enum ConservativeRasterizationModeEXT : int
    {
        [NativeName("Name", "VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT")]
        ConservativeRasterizationModeDisabledExt = 0,
        [NativeName("Name", "VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT")]
        ConservativeRasterizationModeOverestimateExt = 1,
        [NativeName("Name", "VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT")]
        ConservativeRasterizationModeUnderestimateExt = 2,
    }
}
