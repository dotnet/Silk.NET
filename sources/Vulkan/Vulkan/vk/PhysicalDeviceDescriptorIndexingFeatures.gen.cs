// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorIndexingFeatures")]
public unsafe partial struct PhysicalDeviceDescriptorIndexingFeatures
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures;

    [NativeName("pNext")]
    public void* PNext;

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

    public PhysicalDeviceDescriptorIndexingFeatures() { }
}
