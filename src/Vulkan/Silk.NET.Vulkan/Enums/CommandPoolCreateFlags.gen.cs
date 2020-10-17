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
    [NativeName("Name", "VkCommandPoolCreateFlags")]
    public enum CommandPoolCreateFlags
    {
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_TRANSIENT_BIT")]
        CommandPoolCreateTransientBit = 1,
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT")]
        CommandPoolCreateResetCommandBufferBit = 2,
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_PROTECTED_BIT")]
        CommandPoolCreateProtectedBit = 4,
    }
}
