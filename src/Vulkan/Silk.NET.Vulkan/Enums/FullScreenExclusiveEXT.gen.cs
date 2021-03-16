// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFullScreenExclusiveEXT")]
    public enum FullScreenExclusiveEXT : int
    {
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT")]
        FullScreenExclusiveDefaultExt = 0,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT")]
        FullScreenExclusiveAllowedExt = 1,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT")]
        FullScreenExclusiveDisallowedExt = 2,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT")]
        FullScreenExclusiveApplicationControlledExt = 3,
    }
}
