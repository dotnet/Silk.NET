// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceAccelerationStructurePropertiesKHR")]
public unsafe partial struct PhysicalDeviceAccelerationStructurePropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceAccelerationStructurePropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxGeometryCount")]
    public ulong MaxGeometryCount;

    [NativeName("maxInstanceCount")]
    public ulong MaxInstanceCount;

    [NativeName("maxPrimitiveCount")]
    public ulong MaxPrimitiveCount;

    [NativeName("maxPerStageDescriptorAccelerationStructures")]
    public uint MaxPerStageDescriptorAccelerationStructures;

    [NativeName("maxPerStageDescriptorUpdateAfterBindAccelerationStructures")]
    public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;

    [NativeName("maxDescriptorSetAccelerationStructures")]
    public uint MaxDescriptorSetAccelerationStructures;

    [NativeName("maxDescriptorSetUpdateAfterBindAccelerationStructures")]
    public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;

    [NativeName("minAccelerationStructureScratchOffsetAlignment")]
    public uint MinAccelerationStructureScratchOffsetAlignment;

    public PhysicalDeviceAccelerationStructurePropertiesKHR() { }
}
