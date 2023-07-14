// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFaultLevel")]
    public enum FaultLevel : int
    {
        [NativeName("Name", "VK_FAULT_LEVEL_UNASSIGNED")]
        Unassigned = 0,
        [NativeName("Name", "VK_FAULT_LEVEL_CRITICAL")]
        Critical = 1,
        [NativeName("Name", "VK_FAULT_LEVEL_RECOVERABLE")]
        Recoverable = 2,
        [NativeName("Name", "VK_FAULT_LEVEL_WARNING")]
        Warning = 3,
    }
}
