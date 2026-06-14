// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMicromapTriangleKHR")]
[SupportedApiProfile("vulkan")]
public partial struct MicromapTriangleKHR
{
    [NativeName("dataOffset")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public uint DataOffset;

    [NativeName("subdivisionLevel")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public ushort SubdivisionLevel;

    [NativeName("format")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public ushort Format;
}
