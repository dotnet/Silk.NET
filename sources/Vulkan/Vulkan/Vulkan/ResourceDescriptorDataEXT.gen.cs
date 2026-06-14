// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResourceDescriptorDataEXT")]
[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ResourceDescriptorDataEXT
{
    [NativeName("pImage")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public ImageDescriptorInfoEXT* PImage;

    [NativeName("pTexelBuffer")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public TexelBufferDescriptorInfoEXT* PTexelBuffer;

    [NativeName("pAddressRange")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public DeviceAddressRangeKHR* PAddressRange;

    [NativeName("pTensorARM")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public TensorViewCreateInfoARM* PTensorARM;
}
