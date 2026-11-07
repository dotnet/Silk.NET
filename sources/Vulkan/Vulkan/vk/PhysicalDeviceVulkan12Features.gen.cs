// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan12Features")]
public unsafe partial struct PhysicalDeviceVulkan12Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x2Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("samplerMirrorClampToEdge")]
    public MaybeBool<uint> SamplerMirrorClampToEdge;

    [NativeName("drawIndirectCount")]
    public MaybeBool<uint> DrawIndirectCount;

    [NativeName("storageBuffer8BitAccess")]
    public MaybeBool<uint> StorageBuffer8BitAccess;

    [NativeName("uniformAndStorageBuffer8BitAccess")]
    public MaybeBool<uint> UniformAndStorageBuffer8BitAccess;

    [NativeName("storagePushConstant8")]
    public MaybeBool<uint> StoragePushConstant8;

    [NativeName("shaderBufferInt64Atomics")]
    public MaybeBool<uint> ShaderBufferInt64Atomics;

    [NativeName("shaderSharedInt64Atomics")]
    public MaybeBool<uint> ShaderSharedInt64Atomics;

    [NativeName("shaderFloat16")]
    public MaybeBool<uint> ShaderFloat16;

    [NativeName("shaderInt8")]
    public MaybeBool<uint> ShaderInt8;

    [NativeName("descriptorIndexing")]
    public MaybeBool<uint> DescriptorIndexing;

    [NativeName("shaderInputAttachmentArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderInputAttachmentArrayDynamicIndexing;

    [NativeName("shaderUniformTexelBufferArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderUniformTexelBufferArrayDynamicIndexing;

    [NativeName("shaderStorageTexelBufferArrayDynamicIndexing")]
    public MaybeBool<uint> ShaderStorageTexelBufferArrayDynamicIndexing;

    [NativeName("shaderUniformBufferArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderUniformBufferArrayNonUniformIndexing;

    [NativeName("shaderSampledImageArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderSampledImageArrayNonUniformIndexing;

    [NativeName("shaderStorageBufferArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderStorageBufferArrayNonUniformIndexing;

    [NativeName("shaderStorageImageArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderStorageImageArrayNonUniformIndexing;

    [NativeName("shaderInputAttachmentArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderInputAttachmentArrayNonUniformIndexing;

    [NativeName("shaderUniformTexelBufferArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderUniformTexelBufferArrayNonUniformIndexing;

    [NativeName("shaderStorageTexelBufferArrayNonUniformIndexing")]
    public MaybeBool<uint> ShaderStorageTexelBufferArrayNonUniformIndexing;

    [NativeName("descriptorBindingUniformBufferUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingUniformBufferUpdateAfterBind;

    [NativeName("descriptorBindingSampledImageUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingSampledImageUpdateAfterBind;

    [NativeName("descriptorBindingStorageImageUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingStorageImageUpdateAfterBind;

    [NativeName("descriptorBindingStorageBufferUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingStorageBufferUpdateAfterBind;

    [NativeName("descriptorBindingUniformTexelBufferUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingUniformTexelBufferUpdateAfterBind;

    [NativeName("descriptorBindingStorageTexelBufferUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingStorageTexelBufferUpdateAfterBind;

    [NativeName("descriptorBindingUpdateUnusedWhilePending")]
    public MaybeBool<uint> DescriptorBindingUpdateUnusedWhilePending;

    [NativeName("descriptorBindingPartiallyBound")]
    public MaybeBool<uint> DescriptorBindingPartiallyBound;

    [NativeName("descriptorBindingVariableDescriptorCount")]
    public MaybeBool<uint> DescriptorBindingVariableDescriptorCount;

    [NativeName("runtimeDescriptorArray")]
    public MaybeBool<uint> RuntimeDescriptorArray;

    [NativeName("samplerFilterMinmax")]
    public MaybeBool<uint> SamplerFilterMinmax;

    [NativeName("scalarBlockLayout")]
    public MaybeBool<uint> ScalarBlockLayout;

    [NativeName("imagelessFramebuffer")]
    public MaybeBool<uint> ImagelessFramebuffer;

    [NativeName("uniformBufferStandardLayout")]
    public MaybeBool<uint> UniformBufferStandardLayout;

    [NativeName("shaderSubgroupExtendedTypes")]
    public MaybeBool<uint> ShaderSubgroupExtendedTypes;

    [NativeName("separateDepthStencilLayouts")]
    public MaybeBool<uint> SeparateDepthStencilLayouts;

    [NativeName("hostQueryReset")]
    public MaybeBool<uint> HostQueryReset;

    [NativeName("timelineSemaphore")]
    public MaybeBool<uint> TimelineSemaphore;

    [NativeName("bufferDeviceAddress")]
    public MaybeBool<uint> BufferDeviceAddress;

    [NativeName("bufferDeviceAddressCaptureReplay")]
    public MaybeBool<uint> BufferDeviceAddressCaptureReplay;

    [NativeName("bufferDeviceAddressMultiDevice")]
    public MaybeBool<uint> BufferDeviceAddressMultiDevice;

    [NativeName("vulkanMemoryModel")]
    public MaybeBool<uint> VulkanMemoryModel;

    [NativeName("vulkanMemoryModelDeviceScope")]
    public MaybeBool<uint> VulkanMemoryModelDeviceScope;

    [NativeName("vulkanMemoryModelAvailabilityVisibilityChains")]
    public MaybeBool<uint> VulkanMemoryModelAvailabilityVisibilityChains;

    [NativeName("shaderOutputViewportIndex")]
    public MaybeBool<uint> ShaderOutputViewportIndex;

    [NativeName("shaderOutputLayer")]
    public MaybeBool<uint> ShaderOutputLayer;

    [NativeName("subgroupBroadcastDynamicId")]
    public MaybeBool<uint> SubgroupBroadcastDynamicId;

    public PhysicalDeviceVulkan12Features() { }
}
