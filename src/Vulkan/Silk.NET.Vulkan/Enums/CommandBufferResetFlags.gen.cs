// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCommandBufferResetFlags")]
    public enum CommandBufferResetFlags : int
    {
        [NativeName("Name", "VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT")]
        CommandBufferResetReleaseResourcesBit = 1,
    }
}
