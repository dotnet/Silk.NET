// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFrameBoundaryTensorsARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkFrameBoundaryTensorsARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("tensorCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public uint TensorCount;

    [NativeName("pTensors")]
    [NativeTypeName("const VkTensorARM *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public VkTensorHandleARM* PTensors;
}
