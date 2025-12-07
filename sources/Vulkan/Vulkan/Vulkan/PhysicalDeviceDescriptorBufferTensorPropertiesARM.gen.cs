// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorBufferTensorPropertiesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDescriptorBufferTensorPropertiesARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("tensorCaptureReplayDescriptorDataSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public nuint TensorCaptureReplayDescriptorDataSize;

    [NativeName("tensorViewCaptureReplayDescriptorDataSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public nuint TensorViewCaptureReplayDescriptorDataSize;

    [NativeName("tensorDescriptorSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public nuint TensorDescriptorSize;
}
