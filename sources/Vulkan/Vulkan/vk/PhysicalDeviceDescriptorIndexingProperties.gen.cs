// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorIndexingProperties")]
public unsafe partial struct PhysicalDeviceDescriptorIndexingProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorIndexingProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxUpdateAfterBindDescriptorsInAllPools")]
    public uint MaxUpdateAfterBindDescriptorsInAllPools;

    [NativeName("shaderUniformBufferArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderUniformBufferArrayNonUniformIndexingNative;

    [NativeName("shaderSampledImageArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderSampledImageArrayNonUniformIndexingNative;

    [NativeName("shaderStorageBufferArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderStorageBufferArrayNonUniformIndexingNative;

    [NativeName("shaderStorageImageArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderStorageImageArrayNonUniformIndexingNative;

    [NativeName("shaderInputAttachmentArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderInputAttachmentArrayNonUniformIndexingNative;

    [NativeName("robustBufferAccessUpdateAfterBind")]
    public MaybeBool<uint> RobustBufferAccessUpdateAfterBind;

    [NativeName("quadDivergentImplicitLod")]
    public MaybeBool<uint> QuadDivergentImplicitLod;

    [NativeName("maxPerStageDescriptorUpdateAfterBindSamplers")]
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeName("maxPerStageDescriptorUpdateAfterBindUniformBuffers")]
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageBuffers")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeName("maxPerStageDescriptorUpdateAfterBindSampledImages")]
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageImages")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeName("maxPerStageDescriptorUpdateAfterBindInputAttachments")]
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeName("maxPerStageUpdateAfterBindResources")]
    public uint MaxPerStageUpdateAfterBindResources;

    [NativeName("maxDescriptorSetUpdateAfterBindSamplers")]
    public uint MaxDescriptorSetUpdateAfterBindSamplers;

    [NativeName("maxDescriptorSetUpdateAfterBindUniformBuffers")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeName("maxDescriptorSetUpdateAfterBindUniformBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageBuffers")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageBuffersDynamic")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeName("maxDescriptorSetUpdateAfterBindSampledImages")]
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageImages")]
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;

    [NativeName("maxDescriptorSetUpdateAfterBindInputAttachments")]
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;

    public PhysicalDeviceDescriptorIndexingProperties() { }
}
