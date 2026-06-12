// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTensorFeaturesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceTensorFeaturesARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public StructureType SType = StructureType.PhysicalDeviceTensorFeaturesARM;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("tensorNonPacked")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public MaybeBool<uint> TensorNonPacked;

    [NativeName("shaderTensorAccess")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public MaybeBool<uint> ShaderTensorAccess;

    [NativeName("shaderStorageTensorArrayDynamicIndexing")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public MaybeBool<uint> ShaderStorageTensorArrayDynamicIndexing;

    [NativeName("shaderStorageTensorArrayNonUniformIndexing")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public MaybeBool<uint> ShaderStorageTensorArrayNonUniformIndexing;

    [NativeName("descriptorBindingStorageTensorUpdateAfterBind")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public MaybeBool<uint> DescriptorBindingStorageTensorUpdateAfterBind;

    [NativeName("tensors")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public MaybeBool<uint> Tensors;

    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public PhysicalDeviceTensorFeaturesARM() { }
}
