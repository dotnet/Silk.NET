// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDiscardRectangleModeEXT")]
    public enum DiscardRectangleModeEXT
    {
        [NativeName("Name", "VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT")]
        DiscardRectangleModeInclusiveExt = 0,
        [NativeName("Name", "VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT")]
        DiscardRectangleModeExclusiveExt = 1,
    }
}
