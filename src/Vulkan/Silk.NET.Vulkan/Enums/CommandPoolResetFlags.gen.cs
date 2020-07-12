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
    [NativeName("Name", "VkCommandPoolResetFlags")]
    public enum CommandPoolResetFlags
    {
        [NativeName("Name", "VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT")]
        CommandPoolResetReleaseResourcesBit = 1,
    }
}
