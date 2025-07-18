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
public unsafe partial struct PhysicalDeviceCooperativeVectorPropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public void* PNext;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public ShaderStageFlags CooperativeVectorSupportedStages;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public MaybeBool<uint> CooperativeVectorTrainingFloat16Accumulation;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public MaybeBool<uint> CooperativeVectorTrainingFloat32Accumulation;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint MaxCooperativeVectorComponents;
}
