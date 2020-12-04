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
    [NativeName("Name", "VkCommandBufferResetFlags")]
    public enum CommandBufferResetFlags
    {
        [NativeName("Name", "VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT")]
        CommandBufferResetReleaseResourcesBit = 1,
    }
}
