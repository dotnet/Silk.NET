// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCommandBufferLevel")]
    public enum CommandBufferLevel : int
    {
        [NativeName("Name", "VK_COMMAND_BUFFER_LEVEL_PRIMARY")]
        Primary = 0,
        [NativeName("Name", "VK_COMMAND_BUFFER_LEVEL_SECONDARY")]
        Secondary = 1,
    }
}
