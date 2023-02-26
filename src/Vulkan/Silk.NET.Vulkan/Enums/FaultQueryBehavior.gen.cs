// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFaultQueryBehavior")]
    public enum FaultQueryBehavior : int
    {
        [NativeName("Name", "VK_FAULT_QUERY_BEHAVIOR_GET_AND_CLEAR_ALL_FAULTS")]
        GetAndClearAllFaults = 0,
    }
}
