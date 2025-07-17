// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceTensorPropertiesARM
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTensorDimensionCount;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxTensorElements;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxPerDimensionTensorElements;

    [NativeTypeName("int64_t")]
    [SupportedApiProfile("vulkan")]
    public long MaxTensorStride;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxTensorSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTensorShaderAccessArrayLength;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTensorShaderAccessSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetStorageTensors;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorSetStorageTensors;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindStorageTensors;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public uint ShaderStorageTensorArrayNonUniformIndexingNative;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags ShaderTensorSupportedStages;
}
