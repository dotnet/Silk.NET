// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindAccelerationStructureMemoryInfoNV")]
public unsafe partial struct BindAccelerationStructureMemoryInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BindAccelerationStructureMemoryInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("accelerationStructure")]
    public AccelerationStructureHandleNV AccelerationStructure;

    [NativeName("memory")]
    public DeviceMemoryHandle Memory;

    [NativeName("memoryOffset")]
    public ulong MemoryOffset;

    [NativeName("deviceIndexCount")]
    public uint DeviceIndexCount;

    [NativeName("pDeviceIndices")]
    public uint* PDeviceIndices;

    public BindAccelerationStructureMemoryInfoNV() { }
}
