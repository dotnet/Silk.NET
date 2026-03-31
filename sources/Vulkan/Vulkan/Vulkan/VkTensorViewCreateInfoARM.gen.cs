// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorViewCreateInfoARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkTensorViewCreateInfoARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkTensorViewCreateFlagsARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkTensorViewCreateFlagsARM Flags;

    [NativeName("tensor")]
    [NativeTypeName("VkTensorARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkTensorHandleARM Tensor;

    [NativeName("format")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkFormat Format;
}
