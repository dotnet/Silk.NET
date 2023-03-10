// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSystemAllocationScope")]
    public enum SystemAllocationScope : int
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
