// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTensorFeaturesARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceTensorFeaturesARM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeName("tensorNonPacked")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint TensorNonPacked;

    [NativeName("shaderTensorAccess")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderTensorAccess;

    [NativeName("shaderStorageTensorArrayDynamicIndexing")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderStorageTensorArrayDynamicIndexing;

    [NativeName("shaderStorageTensorArrayNonUniformIndexing")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint ShaderStorageTensorArrayNonUniformIndexing;

    [NativeName("descriptorBindingStorageTensorUpdateAfterBind")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint DescriptorBindingStorageTensorUpdateAfterBind;

    [NativeName("tensors")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint Tensors;
}
