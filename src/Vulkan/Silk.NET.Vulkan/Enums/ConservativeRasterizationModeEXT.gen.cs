// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkConservativeRasterizationModeEXT")]
    public enum ConservativeRasterizationModeEXT
    {
        [NativeName("Name", "VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT")]
        ConservativeRasterizationModeDisabledExt = 0,
        [NativeName("Name", "VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT")]
        ConservativeRasterizationModeOverestimateExt = 1,
        [NativeName("Name", "VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT")]
        ConservativeRasterizationModeUnderestimateExt = 2,
    }
}
