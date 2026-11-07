// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureBuildGeometryInfoKHR")]
public unsafe partial struct AccelerationStructureBuildGeometryInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureBuildGeometryInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("type")]
    public AccelerationStructureTypeKHR Type;

    [NativeName("flags")]
    public BuildAccelerationStructureFlagsKHR Flags;

    [NativeName("mode")]
    public BuildAccelerationStructureModeKHR Mode;

    [NativeName("srcAccelerationStructure")]
    public AccelerationStructureHandleKHR SrcAccelerationStructure;

    [NativeName("dstAccelerationStructure")]
    public AccelerationStructureHandleKHR DstAccelerationStructure;

    [NativeName("geometryCount")]
    public uint GeometryCount;

    [NativeName("pGeometries")]
    public AccelerationStructureGeometryKHR* PGeometries;

    [NativeName("ppGeometries")]
    public AccelerationStructureGeometryKHR** PpGeometries;

    [NativeName("scratchData")]
    public DeviceOrHostAddressKHR ScratchData;

    public AccelerationStructureBuildGeometryInfoKHR() { }
}
