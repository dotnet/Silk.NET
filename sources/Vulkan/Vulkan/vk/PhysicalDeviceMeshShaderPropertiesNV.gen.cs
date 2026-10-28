// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMeshShaderPropertiesNV")]
public unsafe partial struct PhysicalDeviceMeshShaderPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMeshShaderPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxDrawMeshTasksCount")]
    public uint MaxDrawMeshTasksCount;

    [NativeName("maxTaskWorkGroupInvocations")]
    public uint MaxTaskWorkGroupInvocations;

    [NativeName("maxTaskWorkGroupSize")]
    public PhysicalDeviceMeshShaderPropertiesNVMaxTaskWorkGroupSize MaxTaskWorkGroupSize;

    [NativeName("maxTaskTotalMemorySize")]
    public uint MaxTaskTotalMemorySize;

    [NativeName("maxTaskOutputCount")]
    public uint MaxTaskOutputCount;

    [NativeName("maxMeshWorkGroupInvocations")]
    public uint MaxMeshWorkGroupInvocations;

    [NativeName("maxMeshWorkGroupSize")]
    public PhysicalDeviceMeshShaderPropertiesNVMaxMeshWorkGroupSize MaxMeshWorkGroupSize;

    [NativeName("maxMeshTotalMemorySize")]
    public uint MaxMeshTotalMemorySize;

    [NativeName("maxMeshOutputVertices")]
    public uint MaxMeshOutputVertices;

    [NativeName("maxMeshOutputPrimitives")]
    public uint MaxMeshOutputPrimitives;

    [NativeName("maxMeshMultiviewViewCount")]
    public uint MaxMeshMultiviewViewCount;

    [NativeName("meshOutputPerVertexGranularity")]
    public uint MeshOutputPerVertexGranularity;

    [NativeName("meshOutputPerPrimitiveGranularity")]
    public uint MeshOutputPerPrimitiveGranularity;

    public PhysicalDeviceMeshShaderPropertiesNV() { }
}
