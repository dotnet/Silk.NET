// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceEventTypeEXT")]
    public enum DeviceEventTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"DisplayHotplugExt\"")]
        [NativeName("Name", "VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT")]
        DeviceEventTypeDisplayHotplugExt = 0,
        [NativeName("Name", "VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT")]
        DisplayHotplugExt = 0,
    }
}
