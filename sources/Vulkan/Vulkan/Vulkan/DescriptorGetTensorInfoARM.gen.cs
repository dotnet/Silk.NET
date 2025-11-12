// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DescriptorGetTensorInfoARM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeTypeName("VkTensorViewARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_tensors", "VK_EXT_descriptor_buffer"],
        ImpliesSets = ["VK_VERSION_1_3"],
        RequireAll = true
    )]
    public TensorViewARMTHandle TensorView;
}
