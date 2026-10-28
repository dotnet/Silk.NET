// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceClusterAccelerationStructurePropertiesNV")]
public unsafe partial struct PhysicalDeviceClusterAccelerationStructurePropertiesNV
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.PhysicalDeviceClusterAccelerationStructurePropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxVerticesPerCluster")]
    public uint MaxVerticesPerCluster;

    [NativeName("maxTrianglesPerCluster")]
    public uint MaxTrianglesPerCluster;

    [NativeName("clusterScratchByteAlignment")]
    public uint ClusterScratchByteAlignment;

    [NativeName("clusterByteAlignment")]
    public uint ClusterByteAlignment;

    [NativeName("clusterTemplateByteAlignment")]
    public uint ClusterTemplateByteAlignment;

    [NativeName("clusterBottomLevelByteAlignment")]
    public uint ClusterBottomLevelByteAlignment;

    [NativeName("clusterTemplateBoundsByteAlignment")]
    public uint ClusterTemplateBoundsByteAlignment;

    [NativeName("maxClusterGeometryIndex")]
    public uint MaxClusterGeometryIndex;

    public PhysicalDeviceClusterAccelerationStructurePropertiesNV() { }
}
