// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSystemAllocationScope")]
    public enum SystemAllocationScope
    {
        [NativeName("Name", "VK_SYSTEM_ALLOCATION_SCOPE_COMMAND")]
        Command = 0,
        [NativeName("Name", "VK_SYSTEM_ALLOCATION_SCOPE_OBJECT")]
        Object = 1,
        [NativeName("Name", "VK_SYSTEM_ALLOCATION_SCOPE_CACHE")]
        Cache = 2,
        [NativeName("Name", "VK_SYSTEM_ALLOCATION_SCOPE_DEVICE")]
        Device = 3,
        [NativeName("Name", "VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE")]
        Instance = 4,
    }
}
