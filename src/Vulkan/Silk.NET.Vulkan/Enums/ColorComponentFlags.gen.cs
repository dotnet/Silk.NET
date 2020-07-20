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
    [NativeName("Name", "VkColorComponentFlags")]
    public enum ColorComponentFlags
    {
        [NativeName("Name", "VK_COLOR_COMPONENT_R_BIT")]
        ColorComponentRBit = 1,
        [NativeName("Name", "VK_COLOR_COMPONENT_G_BIT")]
        ColorComponentGBit = 2,
        [NativeName("Name", "VK_COLOR_COMPONENT_B_BIT")]
        ColorComponentBBit = 4,
        [NativeName("Name", "VK_COLOR_COMPONENT_A_BIT")]
        ColorComponentABit = 8,
    }
}
