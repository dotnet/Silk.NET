// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ImageViewAddressPropertiesNVX
{
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public void* PNext;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public ulong DeviceAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan", ["VK_NVX_image_view_handle"])]
    public ulong Size;
}
