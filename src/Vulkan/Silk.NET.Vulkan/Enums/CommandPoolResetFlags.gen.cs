// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkCommandPoolResetFlags")]
    public enum CommandPoolResetFlags : int
    {
        [NativeName("Name", "VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT")]
        CommandPoolResetReleaseResourcesBit = 1,
        [NativeName("Name", "VK_COMMAND_POOL_RESET_RESERVED_1_BIT_COREAVI")]
        CommandPoolResetReserved1BitCoreavi = 2,
    }
}
