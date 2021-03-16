// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSharingMode")]
    public enum SharingMode : int
    {
        [NativeName("Name", "VK_SHARING_MODE_EXCLUSIVE")]
        Exclusive = 0,
        [NativeName("Name", "VK_SHARING_MODE_CONCURRENT")]
        Concurrent = 1,
    }
}
