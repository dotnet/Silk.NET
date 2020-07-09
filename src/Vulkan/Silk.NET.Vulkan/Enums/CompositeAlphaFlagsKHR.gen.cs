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
    [NativeName("Name", "VkCompositeAlphaFlagsKHR")]
    public enum CompositeAlphaFlagsKHR
    {
        [NativeName("Name", "VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
        CompositeAlphaOpaqueBitKhr = 1,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
        CompositeAlphaPreMultipliedBitKhr = 2,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
        CompositeAlphaPostMultipliedBitKhr = 4,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
        CompositeAlphaInheritBitKhr = 8,
    }
}
