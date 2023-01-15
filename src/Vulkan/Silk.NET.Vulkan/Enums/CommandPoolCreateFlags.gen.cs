// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCommandPoolCreateFlags")]
    public enum CommandPoolCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransientBit\"")]
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_TRANSIENT_BIT")]
        CommandPoolCreateTransientBit = 1,
        [Obsolete("Deprecated in favour of \"ResetCommandBufferBit\"")]
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT")]
        CommandPoolCreateResetCommandBufferBit = 2,
        [Obsolete("Deprecated in favour of \"ProtectedBit\"")]
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_PROTECTED_BIT")]
        CommandPoolCreateProtectedBit = 4,
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_TRANSIENT_BIT")]
        TransientBit = 1,
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT")]
        ResetCommandBufferBit = 2,
        [NativeName("Name", "VK_COMMAND_POOL_CREATE_PROTECTED_BIT")]
        ProtectedBit = 4,
    }
}
