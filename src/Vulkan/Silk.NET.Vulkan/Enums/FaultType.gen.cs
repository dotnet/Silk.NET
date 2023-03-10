// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFaultType")]
    public enum FaultType : int
    {
        [NativeName("Name", "VK_FAULT_TYPE_INVALID")]
        Invalid = 0,
        [NativeName("Name", "VK_FAULT_TYPE_UNASSIGNED")]
        Unassigned = 1,
        [NativeName("Name", "VK_FAULT_TYPE_IMPLEMENTATION")]
        Implementation = 2,
        [NativeName("Name", "VK_FAULT_TYPE_SYSTEM")]
        System = 3,
        [NativeName("Name", "VK_FAULT_TYPE_PHYSICAL_DEVICE")]
        PhysicalDevice = 4,
        [NativeName("Name", "VK_FAULT_TYPE_COMMAND_BUFFER_FULL")]
        CommandBufferFull = 5,
        [NativeName("Name", "VK_FAULT_TYPE_INVALID_API_USAGE")]
        InvalidApiUsage = 6,
    }
}
