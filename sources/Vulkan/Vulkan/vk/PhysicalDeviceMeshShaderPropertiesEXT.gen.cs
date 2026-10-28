// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMeshShaderPropertiesEXT")]
public unsafe partial struct PhysicalDeviceMeshShaderPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMeshShaderPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxTaskWorkGroupTotalCount")]
    public uint MaxTaskWorkGroupTotalCount;

    [NativeName("maxTaskWorkGroupCount")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxTaskWorkGroupCount MaxTaskWorkGroupCount;

    [NativeName("maxTaskWorkGroupInvocations")]
    public uint MaxTaskWorkGroupInvocations;

    [NativeName("maxTaskWorkGroupSize")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxTaskWorkGroupSize MaxTaskWorkGroupSize;

    [NativeName("maxTaskPayloadSize")]
    public uint MaxTaskPayloadSize;

    [NativeName("maxTaskSharedMemorySize")]
    public uint MaxTaskSharedMemorySize;

    [NativeName("maxTaskPayloadAndSharedMemorySize")]
    public uint MaxTaskPayloadAndSharedMemorySize;

    [NativeName("maxMeshWorkGroupTotalCount")]
    public uint MaxMeshWorkGroupTotalCount;

    [NativeName("maxMeshWorkGroupCount")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxMeshWorkGroupCount MaxMeshWorkGroupCount;

    [NativeName("maxMeshWorkGroupInvocations")]
    public uint MaxMeshWorkGroupInvocations;

    [NativeName("maxMeshWorkGroupSize")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxMeshWorkGroupSize MaxMeshWorkGroupSize;

    [NativeName("maxMeshSharedMemorySize")]
    public uint MaxMeshSharedMemorySize;

    [NativeName("maxMeshPayloadAndSharedMemorySize")]
    public uint MaxMeshPayloadAndSharedMemorySize;

    [NativeName("maxMeshOutputMemorySize")]
    public uint MaxMeshOutputMemorySize;

    [NativeName("maxMeshPayloadAndOutputMemorySize")]
    public uint MaxMeshPayloadAndOutputMemorySize;

    [NativeName("maxMeshOutputComponents")]
    public uint MaxMeshOutputComponents;

    [NativeName("maxMeshOutputVertices")]
    public uint MaxMeshOutputVertices;

    [NativeName("maxMeshOutputPrimitives")]
    public uint MaxMeshOutputPrimitives;

    [NativeName("maxMeshOutputLayers")]
    public uint MaxMeshOutputLayers;

    [NativeName("maxMeshMultiviewViewCount")]
    public uint MaxMeshMultiviewViewCount;

    [NativeName("meshOutputPerVertexGranularity")]
    public uint MeshOutputPerVertexGranularity;

    [NativeName("meshOutputPerPrimitiveGranularity")]
    public uint MeshOutputPerPrimitiveGranularity;

    [NativeName("maxPreferredTaskWorkGroupInvocations")]
    public uint MaxPreferredTaskWorkGroupInvocations;

    [NativeName("maxPreferredMeshWorkGroupInvocations")]
    public uint MaxPreferredMeshWorkGroupInvocations;

    [NativeName("prefersLocalInvocationVertexOutput")]
    public MaybeBool<uint> PrefersLocalInvocationVertexOutput;

    [NativeName("prefersLocalInvocationPrimitiveOutput")]
    public MaybeBool<uint> PrefersLocalInvocationPrimitiveOutput;

    [NativeName("prefersCompactVertexOutput")]
    public MaybeBool<uint> PrefersCompactVertexOutput;

    [NativeName("prefersCompactPrimitiveOutput")]
    public MaybeBool<uint> PrefersCompactPrimitiveOutput;

    public PhysicalDeviceMeshShaderPropertiesEXT() { }
}
