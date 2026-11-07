// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkWriteDescriptorSetPartitionedAccelerationStructureNV")]
public unsafe partial struct WriteDescriptorSetPartitionedAccelerationStructureNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.WriteDescriptorSetPartitionedAccelerationStructureNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("accelerationStructureCount")]
    public uint AccelerationStructureCount;

    [NativeName("pAccelerationStructures")]
    public ulong* PAccelerationStructures;

    public WriteDescriptorSetPartitionedAccelerationStructureNV() { }
}
