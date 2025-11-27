// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkDeviceEventTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum DeviceEventTypeEXT : uint
{
    [NameSuffix("EXT", 0)]
    [NativeName("VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    DisplayHotplugEXT = 0,
}
