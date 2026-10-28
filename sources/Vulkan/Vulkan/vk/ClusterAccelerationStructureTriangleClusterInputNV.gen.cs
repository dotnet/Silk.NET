// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureTriangleClusterInputNV")]
public unsafe partial struct ClusterAccelerationStructureTriangleClusterInputNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ClusterAccelerationStructureTriangleClusterInputNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("vertexFormat")]
    public Format VertexFormat;

    [NativeName("maxGeometryIndexValue")]
    public uint MaxGeometryIndexValue;

    [NativeName("maxClusterUniqueGeometryCount")]
    public uint MaxClusterUniqueGeometryCount;

    [NativeName("maxClusterTriangleCount")]
    public uint MaxClusterTriangleCount;

    [NativeName("maxClusterVertexCount")]
    public uint MaxClusterVertexCount;

    [NativeName("maxTotalTriangleCount")]
    public uint MaxTotalTriangleCount;

    [NativeName("maxTotalVertexCount")]
    public uint MaxTotalVertexCount;

    [NativeName("minPositionTruncateBitCount")]
    public uint MinPositionTruncateBitCount;

    public ClusterAccelerationStructureTriangleClusterInputNV() { }
}
