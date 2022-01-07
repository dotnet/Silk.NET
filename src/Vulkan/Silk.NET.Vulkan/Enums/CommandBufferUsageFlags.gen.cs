// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCommandBufferUsageFlags")]
    public enum CommandBufferUsageFlags : int
    {
        [NativeName("Name", "VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT")]
        CommandBufferUsageOneTimeSubmitBit = 1,
        [NativeName("Name", "VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT")]
        CommandBufferUsageRenderPassContinueBit = 2,
        [NativeName("Name", "VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT")]
        CommandBufferUsageSimultaneousUseBit = 4,
    }
}
