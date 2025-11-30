// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "ARM", 0)]
[NativeName("VkPhysicalDeviceTensorPropertiesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceTensorPropertiesArm
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("maxTensorDimensionCount")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxTensorDimensionCount;

    [NativeName("maxTensorElements")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong MaxTensorElements;

    [NativeName("maxPerDimensionTensorElements")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong MaxPerDimensionTensorElements;

    [NativeName("maxTensorStride")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public long MaxTensorStride;

    [NativeName("maxTensorSize")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong MaxTensorSize;

    [NativeName("maxTensorShaderAccessArrayLength")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxTensorShaderAccessArrayLength;

    [NativeName("maxTensorShaderAccessSize")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxTensorShaderAccessSize;

    [NativeName("maxDescriptorSetStorageTensors")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxDescriptorSetStorageTensors;

    [NativeName("maxPerStageDescriptorSetStorageTensors")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxPerStageDescriptorSetStorageTensors;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageTensors")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxDescriptorSetUpdateAfterBindStorageTensors;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageTensors")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors;

    [NativeName("shaderStorageTensorArrayNonUniformIndexingNative")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderStorageTensorArrayNonUniformIndexingNative;

    [NativeName("shaderTensorSupportedStages")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ShaderStageFlags ShaderTensorSupportedStages;
}
