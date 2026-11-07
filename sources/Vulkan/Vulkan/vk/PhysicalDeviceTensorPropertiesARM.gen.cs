// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTensorPropertiesARM")]
public unsafe partial struct PhysicalDeviceTensorPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTensorPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxTensorDimensionCount")]
    public uint MaxTensorDimensionCount;

    [NativeName("maxTensorElements")]
    public ulong MaxTensorElements;

    [NativeName("maxPerDimensionTensorElements")]
    public ulong MaxPerDimensionTensorElements;

    [NativeName("maxTensorStride")]
    public long MaxTensorStride;

    [NativeName("maxTensorSize")]
    public ulong MaxTensorSize;

    [NativeName("maxTensorShaderAccessArrayLength")]
    public uint MaxTensorShaderAccessArrayLength;

    [NativeName("maxTensorShaderAccessSize")]
    public uint MaxTensorShaderAccessSize;

    [NativeName("maxDescriptorSetStorageTensors")]
    public uint MaxDescriptorSetStorageTensors;

    [NativeName("maxPerStageDescriptorSetStorageTensors")]
    public uint MaxPerStageDescriptorSetStorageTensors;

    [NativeName("maxDescriptorSetUpdateAfterBindStorageTensors")]
    public uint MaxDescriptorSetUpdateAfterBindStorageTensors;

    [NativeName("maxPerStageDescriptorUpdateAfterBindStorageTensors")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors;

    [NativeName("shaderStorageTensorArrayNonUniformIndexingNative")]
    public MaybeBool<uint> ShaderStorageTensorArrayNonUniformIndexingNative;

    [NativeName("shaderTensorSupportedStages")]
    public ShaderStageFlags ShaderTensorSupportedStages;

    public PhysicalDeviceTensorPropertiesARM() { }
}
