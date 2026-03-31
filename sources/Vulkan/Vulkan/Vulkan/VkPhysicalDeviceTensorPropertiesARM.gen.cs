// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTensorPropertiesARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceTensorPropertiesARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("maxTensorDimensionCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxTensorDimensionCount;

    [NativeName("maxTensorElements")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong MaxTensorElements;

    [NativeName("maxPerDimensionTensorElements")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong MaxPerDimensionTensorElements;

    [NativeName("maxTensorStride")]
    [NativeTypeName("int64_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public long MaxTensorStride;

    [NativeName("maxTensorSize")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong MaxTensorSize;

    [NativeName("maxTensorShaderAccessArrayLength")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxTensorShaderAccessArrayLength;

    [NativeName("maxTensorShaderAccessSize")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxTensorShaderAccessSize;

    [NativeName("maxDescriptorSetStorageTensors")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxDescriptorSetStorageTensors;

    [NativeName("maxPerStageDescriptorSetStorageTensors")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxPerStageDescriptorSetStorageTensors;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageTensors")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxDescriptorSetUpdateAfterBindStorageTensors;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageTensors")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors;

    [NativeName("shaderStorageTensorArrayNonUniformIndexingNative")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderStorageTensorArrayNonUniformIndexingNative;

    [NativeName("shaderTensorSupportedStages")]
    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkShaderStageFlags ShaderTensorSupportedStages;
}
