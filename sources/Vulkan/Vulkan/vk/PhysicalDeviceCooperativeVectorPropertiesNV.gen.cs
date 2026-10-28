// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeVectorPropertiesNV")]
public unsafe partial struct PhysicalDeviceCooperativeVectorPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceCooperativeVectorPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("cooperativeVectorSupportedStages")]
    public ShaderStageFlags CooperativeVectorSupportedStages;

    [NativeName("cooperativeVectorTrainingFloat16Accumulation")]
    public MaybeBool<uint> CooperativeVectorTrainingFloat16Accumulation;

    [NativeName("cooperativeVectorTrainingFloat32Accumulation")]
    public MaybeBool<uint> CooperativeVectorTrainingFloat32Accumulation;

    [NativeName("maxCooperativeVectorComponents")]
    public uint MaxCooperativeVectorComponents;

    public PhysicalDeviceCooperativeVectorPropertiesNV() { }
}
