// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NVX", 0)]
[NativeName("VkImageViewAddressPropertiesNVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImageViewAddressPropertiesNVX
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public void* PNext;

    [NativeName("deviceAddress")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public ulong DeviceAddress;

    [NativeName("size")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public ulong Size;
}
