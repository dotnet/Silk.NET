// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkEventCreateFlags")]
    public enum EventCreateFlags : int
    {
        [NativeName("Name", "VK_EVENT_CREATE_DEVICE_ONLY_BIT_KHR")]
        EventCreateDeviceOnlyBitKhr = 1,
    }
}
