// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorHeapTensorPropertiesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDescriptorHeapTensorPropertiesARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorHeapTensorPropertiesARM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("tensorDescriptorSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public ulong TensorDescriptorSize;

    [NativeName("tensorDescriptorAlignment")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public ulong TensorDescriptorAlignment;

    [NativeName("tensorCaptureReplayOpaqueDataSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public nuint TensorCaptureReplayOpaqueDataSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ],
        RequireAll = true
    )]
    public PhysicalDeviceDescriptorHeapTensorPropertiesARM() { }
}
