// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkPhysicalDeviceLayeredApiPropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceLayeredApiPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public void* PNext;

    [NativeName("vendorID")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint VendorID;

    [NativeName("deviceID")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint DeviceID;

    [NativeName("layeredAPI")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public PhysicalDeviceLayeredApiKHR LayeredAPI;

    [NativeName("deviceName")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    public PhysicalDeviceLayeredApiPropertiesKHRDeviceName DeviceName;
}
