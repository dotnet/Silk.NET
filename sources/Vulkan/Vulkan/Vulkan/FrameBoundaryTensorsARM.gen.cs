// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFrameBoundaryTensorsARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct FrameBoundaryTensorsARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("tensorCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public uint TensorCount;

    [NativeName("pTensors")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_frame_boundary"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public TensorARMHandle* PTensors;
}
