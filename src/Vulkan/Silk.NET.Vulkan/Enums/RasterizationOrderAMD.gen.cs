// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRasterizationOrderAMD")]
    public enum RasterizationOrderAMD
    {
        [NativeName("Name", "VK_RASTERIZATION_ORDER_STRICT_AMD")]
        RasterizationOrderStrictAmd = 0,
        [NativeName("Name", "VK_RASTERIZATION_ORDER_RELAXED_AMD")]
        RasterizationOrderRelaxedAmd = 1,
    }
}
