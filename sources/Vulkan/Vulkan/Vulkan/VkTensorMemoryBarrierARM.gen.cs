// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorMemoryBarrierARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkTensorMemoryBarrierARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("srcStageMask")]
    [NativeTypeName("VkPipelineStageFlags2")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkPipelineStageFlags2 SrcStageMask;

    [NativeName("srcAccessMask")]
    [NativeTypeName("VkAccessFlags2")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkAccessFlags2 SrcAccessMask;

    [NativeName("dstStageMask")]
    [NativeTypeName("VkPipelineStageFlags2")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkPipelineStageFlags2 DstStageMask;

    [NativeName("dstAccessMask")]
    [NativeTypeName("VkAccessFlags2")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkAccessFlags2 DstAccessMask;

    [NativeName("srcQueueFamilyIndex")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint SrcQueueFamilyIndex;

    [NativeName("dstQueueFamilyIndex")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint DstQueueFamilyIndex;

    [NativeName("tensor")]
    [NativeTypeName("VkTensorARM")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkTensorHandleARM Tensor;
}
