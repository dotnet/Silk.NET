// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFragmentShadingRateTypeNV")]
    public enum FragmentShadingRateTypeNV : int
    {
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV")]
        FragmentShadingRateTypeFragmentSizeNV = 0,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV")]
        FragmentShadingRateTypeEnumsNV = 1,
    }
}
